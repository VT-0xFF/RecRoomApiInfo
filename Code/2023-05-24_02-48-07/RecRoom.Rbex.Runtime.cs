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
		public static KBJOPGEOOCH UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int KNABIKABPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int AFLIABLDNNC;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F27DA0", Offset = "0x6F269A0", VA = "0x186F27DA0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F27DE0", Offset = "0x6F269E0", VA = "0x186F27DE0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F27DC0", Offset = "0x6F269C0", VA = "0x186F27DC0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string DKIECHCHJFL, [Optional] UnityEngine.Object JFDMKPDIBDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string DKIECHCHJFL, [Optional] UnityEngine.Object JFDMKPDIBDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F27ED0", Offset = "0x6F26AD0", VA = "0x186F27ED0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KEDGBGINDFP
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class LNPEDHIJIMK : MLAAMHAMNCK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x12E6900", Offset = "0x12E5500", VA = "0x1812E6900", Slot = "4")]
		public Vector3 OHEPKJEBFID()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x12E6900", Offset = "0x12E5500", VA = "0x1812E6900", Slot = "5")]
		public Vector3 BFPGMPGOAEH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LNPEDHIJIMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static MLAAMHAMNCK PCMJAGFIHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DFD610", Offset = "0x5DFC210", VA = "0x185DFD610")]
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
		private static readonly MFFHLJHLBIG HMBFEDIJKIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool NHOHANJCEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private FAFKHKPFEKI HGFMEPEKMJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[KDKAGIPBBGM(MGNIEFNKKLA.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[KDKAGIPBBGM(MGNIEFNKKLA.SelfAndParent, true, false, false)]
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
		private BFCLHOINCJP physicsInterpolation;

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
		internal FAFKHKPFEKI AOOPEEENLEL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F28900", Offset = "0x6F27500", VA = "0x186F28900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> GLGFKAIAEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x84D800", Offset = "0x84C400", VA = "0x18084D800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x89D540", Offset = "0x89C140", VA = "0x18089D540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx LEIIEFIHIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F2AB30", Offset = "0x6F29730", VA = "0x186F2AB30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx ODFEIMILGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F2AAD0", Offset = "0x6F296D0", VA = "0x186F2AAD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx ONIJEEBBCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B6F0", Offset = "0x6F2A2F0", VA = "0x186F2B6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F2CC80", Offset = "0x6F2B880", VA = "0x186F2CC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform EMNGBEEEHMO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xC93B00", Offset = "0xC92700", VA = "0x180C93B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform BJCECNAIBIG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xC93B00", Offset = "0xC92700", VA = "0x180C93B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public FFFAJCBJCHK EFPMFLGMIAI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A820", Offset = "0x6F29420", VA = "0x186F2A820")]
			get
			{
				return default(FFFAJCBJCHK);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C3E0", Offset = "0x6F2AFE0", VA = "0x186F2C3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PJBJHNNIMMC
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F2ADA0", Offset = "0x6F299A0", VA = "0x186F2ADA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EMKHKPNFBNK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A9B0", Offset = "0x6F295B0", VA = "0x186F2A9B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MLAAMHAMNCK KNKDIKABJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F2ACE0", Offset = "0x6F298E0", VA = "0x186F2ACE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C5F0", Offset = "0x6F2B1F0", VA = "0x186F2C5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JHEBHKGMPAF CPNBMHEFJBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6F2AC80", Offset = "0x6F29880", VA = "0x186F2AC80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C580", Offset = "0x6F2B180", VA = "0x186F2C580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool MFEJBDEHODC
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F2AB60", Offset = "0x6F29760", VA = "0x186F2AB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody CGNLPAOPEHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F2ABC0", Offset = "0x6F297C0", VA = "0x186F2ABC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LGMFNHPALFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F2AA10", Offset = "0x6F29610", VA = "0x186F2AA10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C4A0", Offset = "0x6F2B0A0", VA = "0x186F2C4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JIKLDANODOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1EB7720", Offset = "0x1EB6320", VA = "0x181EB7720")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x3DBD6F0", Offset = "0x3DBC2F0", VA = "0x183DBD6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float CHODJKFAPAA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B690", Offset = "0x6F2A290", VA = "0x186F2B690")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float LMACMILFAEC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B630", Offset = "0x6F2A230", VA = "0x186F2B630")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F2CC10", Offset = "0x6F2B810", VA = "0x186F2CC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float OIOOEPMJBBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B000", Offset = "0x6F29C00", VA = "0x186F2B000")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C890", Offset = "0x6F2B490", VA = "0x186F2C890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float GIFDAOBHDEB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F2AE00", Offset = "0x6F29A00", VA = "0x186F2AE00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C660", Offset = "0x6F2B260", VA = "0x186F2C660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool HCMLLAEMOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F2BC10", Offset = "0x6F2A810", VA = "0x186F2BC10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F2D1C0", Offset = "0x6F2BDC0", VA = "0x186F2D1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 ADFEMPOHHKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B410", Offset = "0x6F2A010", VA = "0x186F2B410")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C9E0", Offset = "0x6F2B5E0", VA = "0x186F2C9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 HKENGGJIGFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F2BD50", Offset = "0x6F2A950", VA = "0x186F2BD50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode POOCPGIKOLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F2AF40", Offset = "0x6F29B40", VA = "0x186F2AF40")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C7B0", Offset = "0x6F2B3B0", VA = "0x186F2C7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float FNKBHNMOBNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6F2AA70", Offset = "0x6F29670", VA = "0x186F2AA70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C510", Offset = "0x6F2B110", VA = "0x186F2C510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints IJJBJLEMONJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F2AFA0", Offset = "0x6F29BA0", VA = "0x186F2AFA0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C820", Offset = "0x6F2B420", VA = "0x186F2C820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 HEEADIMOMLF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B750", Offset = "0x6F2A350", VA = "0x186F2B750")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 MCJHNLHNHKN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B750", Offset = "0x6F2A350", VA = "0x186F2B750")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F2CF90", Offset = "0x6F2BB90", VA = "0x186F2CF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float EGHKKPPIJGN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B4F0", Offset = "0x6F2A0F0", VA = "0x186F2B4F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F2CAC0", Offset = "0x6F2B6C0", VA = "0x186F2CAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float IMPMMLNMDHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6F2BBB0", Offset = "0x6F2A7B0", VA = "0x186F2BBB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F2D150", Offset = "0x6F2BD50", VA = "0x186F2D150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion JJPINILMJLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B830", Offset = "0x6F2A430", VA = "0x186F2B830")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F2CCF0", Offset = "0x6F2B8F0", VA = "0x186F2CCF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion DIEMMNDNHGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6F2BAD0", Offset = "0x6F2A6D0", VA = "0x186F2BAD0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6F2D070", Offset = "0x6F2BC70", VA = "0x186F2D070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 GMLKEOIBEGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B910", Offset = "0x6F2A510", VA = "0x186F2B910")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6F2CDD0", Offset = "0x6F2B9D0", VA = "0x186F2CDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion LKMBGCCKLPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B9F0", Offset = "0x6F2A5F0", VA = "0x186F2B9F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6F2CEB0", Offset = "0x6F2BAB0", VA = "0x186F2CEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 PPJHGOCBPCK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6F2BC70", Offset = "0x6F2A870", VA = "0x186F2BC70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6F2D230", Offset = "0x6F2BE30", VA = "0x186F2D230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 LLBIDODECBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B550", Offset = "0x6F2A150", VA = "0x186F2B550")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6F2CB30", Offset = "0x6F2B730", VA = "0x186F2CB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 JDNINLGNNJF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6F2AE60", Offset = "0x6F29A60", VA = "0x186F2AE60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C6D0", Offset = "0x6F2B2D0", VA = "0x186F2C6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 AFFJGLIILJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B330", Offset = "0x6F29F30", VA = "0x186F2B330")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C900", Offset = "0x6F2B500", VA = "0x186F2C900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 INPCFJLMNAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B1F0", Offset = "0x6F29DF0", VA = "0x186F2B1F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion MIIDBCDLHGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B110", Offset = "0x6F29D10", VA = "0x186F2B110")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 NIJGKMFFFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6F2BF10", Offset = "0x6F2AB10", VA = "0x186F2BF10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 DGBHAPEEKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6F2BE30", Offset = "0x6F2AA30", VA = "0x186F2BE30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool ICBDCKBKPKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B2D0", Offset = "0x6F29ED0", VA = "0x186F2B2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool HPAPGLPAOKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6F2AD40", Offset = "0x6F29940", VA = "0x186F2AD40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool JKOBEIFFLAA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A950", Offset = "0x6F29550", VA = "0x186F2A950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DGHDMLPPOFE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A8F0", Offset = "0x6F294F0", VA = "0x186F2A8F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool FFNCCFIMIDG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A7C0", Offset = "0x6F293C0", VA = "0x186F2A7C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool GKGFHIFHOCI
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B060", Offset = "0x6F29C60", VA = "0x186F2B060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool GLGGKOPKDGG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x900140", Offset = "0x8FED40", VA = "0x180900140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PENLMJLNPDM HACHEKBJCAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A6E0", Offset = "0x6F292E0", VA = "0x186F2A6E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C300", Offset = "0x6F2AF00", VA = "0x186F2C300")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event IJIIOKHNDCH HBKOCCDFBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A670", Offset = "0x6F29270", VA = "0x186F2A670")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C290", Offset = "0x6F2AE90", VA = "0x186F2C290")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event PENLMJLNPDM ABGONPKEDMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A3D0", Offset = "0x6F28FD0", VA = "0x186F2A3D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F2BFF0", Offset = "0x6F2ABF0", VA = "0x186F2BFF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event PENLMJLNPDM PCAPCNOAOJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A440", Offset = "0x6F29040", VA = "0x186F2A440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C060", Offset = "0x6F2AC60", VA = "0x186F2C060")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event PENLMJLNPDM DDALOGBJKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A590", Offset = "0x6F29190", VA = "0x186F2A590")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C1B0", Offset = "0x6F2ADB0", VA = "0x186F2C1B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<GBAHALBBEFO, GBAHALBBEFO> KKOALOMMEIL
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A520", Offset = "0x6F29120", VA = "0x186F2A520")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C140", Offset = "0x6F2AD40", VA = "0x186F2C140")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PENLMJLNPDM PLJODFLBJKI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A600", Offset = "0x6F29200", VA = "0x186F2A600")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C220", Offset = "0x6F2AE20", VA = "0x186F2C220")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PENLMJLNPDM INMKKNIENIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A750", Offset = "0x6F29350", VA = "0x186F2A750")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C370", Offset = "0x6F2AF70", VA = "0x186F2C370")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event PENLMJLNPDM MOMDHFIOGGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A4B0", Offset = "0x6F290B0", VA = "0x186F2A4B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F2C0D0", Offset = "0x6F2ACD0", VA = "0x186F2C0D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8370D0", Offset = "0x835CD0", VA = "0x1808370D0")]
		internal void EFGHEMDKEOG(FAFKHKPFEKI NHIFGJKHMEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F293C0", Offset = "0x6F27FC0", VA = "0x186F293C0")]
		internal void MGFPIONOJDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A0C0", Offset = "0x6F28CC0", VA = "0x186F2A0C0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody LPGBCHBJCAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6F29D50", Offset = "0x6F28950", VA = "0x186F29D50")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) DCEIBGLEFBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F28890", Offset = "0x6F27490", VA = "0x186F28890")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F28900", Offset = "0x6F27500", VA = "0x186F28900")]
		private FAFKHKPFEKI HNGOLBJLLAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F28F30", Offset = "0x6F27B30", VA = "0x186F28F30")]
		private void LEAMKENGDJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F29510", Offset = "0x6F28110", VA = "0x186F29510")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F293C0", Offset = "0x6F27FC0", VA = "0x186F293C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F28BF0", Offset = "0x6F277F0", VA = "0x186F28BF0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F294B0", Offset = "0x6F280B0", VA = "0x186F294B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F29570", Offset = "0x6F28170", VA = "0x186F29570")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F27F20", Offset = "0x6F26B20", VA = "0x186F27F20")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F295E0", Offset = "0x6F281E0", VA = "0x186F295E0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F28B90", Offset = "0x6F27790", VA = "0x186F28B90")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F29450", Offset = "0x6F28050", VA = "0x186F29450")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F29EC0", Offset = "0x6F28AC0", VA = "0x186F29EC0")]
		public void SetParent(RigidbodyEx ECNGHFJBIJL, bool NGKEIPOGCJF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F298F0", Offset = "0x6F284F0", VA = "0x186F298F0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F28E50", Offset = "0x6F27A50", VA = "0x186F28E50")]
		public bool IsRigidbodyAncestor(RigidbodyEx LDCOLCDIOIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F28E90", Offset = "0x6F27A90", VA = "0x186F28E90")]
		public bool IsRigidbodyDescendant(RigidbodyEx DHHBLOHICNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F28140", Offset = "0x6F26D40", VA = "0x186F28140")]
		public void AddInterpolationRestriction(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F29650", Offset = "0x6F28250", VA = "0x186F29650")]
		public void RemoveInterpolationRestriction(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F289B0", Offset = "0x6F275B0", VA = "0x186F289B0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F281B0", Offset = "0x6F26DB0", VA = "0x186F281B0")]
		public void AddKinematic(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F296C0", Offset = "0x6F282C0", VA = "0x186F296C0")]
		public void RemoveKinematic(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F29E40", Offset = "0x6F28A40", VA = "0x186F29E40")]
		public void SetKinematic(object FLDJLPKNKKO, bool GCGPLALBKNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F29C50", Offset = "0x6F28850", VA = "0x186F29C50")]
		public void SetDiscontinuousPositionAndRotation(Vector3 CBIOILEAJIH, Quaternion ECGDKPNOHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F29B50", Offset = "0x6F28750", VA = "0x186F29B50")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 ELPFDBFBPJP, Quaternion PDEDDIGJHCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F28D50", Offset = "0x6F27950", VA = "0x186F28D50")]
		public Vector3 GetConstrainedVelocity(Vector3 PPJHGOCBPCK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F28C50", Offset = "0x6F27850", VA = "0x186F28C50")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 JDNINLGNNJF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F280B0", Offset = "0x6F26CB0", VA = "0x186F280B0")]
		public void AddForce(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F27F90", Offset = "0x6F26B90", VA = "0x186F27F90")]
		public void AddForceAtPosition(Vector3 HCKNDFMIDDI, Vector3 NABPHMOHNDG, ForceMode MKILKFIGPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F28320", Offset = "0x6F26F20", VA = "0x186F28320")]
		public void AddTorque(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F28220", Offset = "0x6F26E20", VA = "0x186F28220")]
		public void AddRelativeTorque(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A1A0", Offset = "0x6F28DA0", VA = "0x186F2A1A0")]
		public Vector3 WorldToLocalVelocity(Vector3 PLGCJGPJLOA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F292C0", Offset = "0x6F27EC0", VA = "0x186F292C0")]
		public Vector3 LocalToWorldVelocity(Vector3 LLBIDODECBJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F28B30", Offset = "0x6F27730", VA = "0x186F28B30")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F28AD0", Offset = "0x6F276D0", VA = "0x186F28AD0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F28A70", Offset = "0x6F27670", VA = "0x186F28A70")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6F28A10", Offset = "0x6F27610", VA = "0x186F28A10")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F29A50", Offset = "0x6F28650", VA = "0x186F29A50")]
		public void ResetVelocityWorldSpace(Vector3 EOJNKDCENDM, Vector3 POIEPCCNOCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F29950", Offset = "0x6F28550", VA = "0x186F29950")]
		public void ResetVelocityLocalSpace(Vector3 NNFLIAGNPGB, Vector3 AFFJGLIILJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F29810", Offset = "0x6F28410", VA = "0x186F29810")]
		public void ResetLinearVelocityLocalSpace(Vector3 NNFLIAGNPGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F29FB0", Offset = "0x6F28BB0", VA = "0x186F29FB0")]
		public bool SweepTest(Vector3 AGOGLFBBBLL, out RaycastHit MLBCOPMGEFF, float LHLJEFHGAPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6F28ED0", Offset = "0x6F27AD0", VA = "0x186F28ED0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F29F50", Offset = "0x6F28B50", VA = "0x186F29F50")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A140", Offset = "0x6F28D40", VA = "0x186F2A140")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6F282B0", Offset = "0x6F26EB0", VA = "0x186F282B0")]
		public void AddShouldHaveUnityRigidbodyToken(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6F29730", Offset = "0x6F28330", VA = "0x186F29730")]
		public void RemoveShouldHaveUnityRigidbodyToken(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6F28660", Offset = "0x6F27260", VA = "0x186F28660")]
		public void ApplyForceVelocityChange(FPHOFMJLENJ LFJLPJDIOGB, Vector3 AFOFGLGBJEI, float CAMLBJONKHG, float KDMJGHCHEJE = 8f, float GLBOFKBMMGD = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6F28560", Offset = "0x6F27160", VA = "0x186F28560")]
		public void ApplyAngularVelocityChange(GJCDONMOIJG JCFGFBHJEMJ, Vector3 ODOOOABGMIH, float AFFFNJJAEBG = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6F28780", Offset = "0x6F27380", VA = "0x186F28780")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(GJCDONMOIJG JCFGFBHJEMJ, Vector3 KDPJNNPKKHC, float LMLCPPONLID = 7f, float EOPJPNPJINM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F284A0", Offset = "0x6F270A0", VA = "0x186F284A0")]
		public bool AllowedScaleChange(float OMOAPNBJLBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F283B0", Offset = "0x6F26FB0", VA = "0x186F283B0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx OFKMLDLKKGB, object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F297A0", Offset = "0x6F283A0", VA = "0x186F297A0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A330", Offset = "0x6F28F30", VA = "0x186F2A330")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class FDFOGIEFJDN
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9040", Offset = "0x5DE7C40", VA = "0x185DE9040")]
	public static FAFKHKPFEKI AOOPEEENLEL(this RigidbodyEx LPIBPEGGEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void PENLMJLNPDM(RigidbodyEx KNNKNILIDJH);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class AHFEBFDJGCO : FDLOOMEBFFN
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JJNJBIEPOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F0000", Offset = "0x7EEC00", VA = "0x1807F0000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int HCHMCBDKMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7F0220", Offset = "0x7EEE20", VA = "0x1807F0220", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x83E700", Offset = "0x83D300", VA = "0x18083E700", Slot = "6")]
	public GBAHALBBEFO MGLHCGNDNOG(float CIKEFFDMPDJ)
	{
		return default(GBAHALBBEFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "7")]
	public void CAILCKFFJIK(ADEMDHOELEN HHNPCHNMLMA, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "8")]
	public void CAILCKFFJIK(ADEMDHOELEN HHNPCHNMLMA, Transform ECEOKHAMMGI, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "9")]
	public void JJOACBAGNIC(ADEMDHOELEN HHNPCHNMLMA, [Optional] float? EAHPLIAGBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "10")]
	public void CPPHPNNFPKL(ADEMDHOELEN CIHBNKECJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x83E700", Offset = "0x83D300", VA = "0x18083E700", Slot = "11")]
	public GBAHALBBEFO NBABKLLOPPO(ADEMDHOELEN HHNPCHNMLMA)
	{
		return default(GBAHALBBEFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D00", Offset = "0x7F1900", VA = "0x1807F2D00", Slot = "12")]
	public bool DAOMDHGCLOP(ADEMDHOELEN HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "13")]
	public void FBMNDAIKFCN(ADEMDHOELEN HHNPCHNMLMA, FFFAJCBJCHK CCLDMBAFDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public AHFEBFDJGCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum BFCLHOINCJP
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum GJCDONMOIJG
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CJKCMEGMCAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody CNBDNPIBOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView LMFEDHHHGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 MGLJKNHHDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 NOIKJKFLDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public BFCLHOINCJP LMIIBOOAPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool GDHFCFBAIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool NADEAEAJGDH;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void IJIIOKHNDCH(RigidbodyEx KNNKNILIDJH, bool NGKEIPOGCJF = false);
[Cpp2IlInjected.Token(Token = "0x200000E")]
[KKBPAALNMJN(typeof(OFKKOHAHMCI), new string[] { "Ignore", "Mock" })]
public class PDDLMIGPOJP : OFKKOHAHMCI
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool LLJBHMHACBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CB0", Offset = "0x7F18B0", VA = "0x1807F2CB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
	public void GAHLMBDGPDK(string FKPBDLDGFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "6")]
	public void PHPCFJAKJCC(RigidbodyEx LPIBPEGGEEE, Action FOGMDOMFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x81DEB0", Offset = "0x81CAB0", VA = "0x18081DEB0", Slot = "7")]
	public FDLOOMEBFFN KKBIDAPGBJC(int MCJMDOGPMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "8")]
	public void DGMOCEENFAD(Vector3 HKENGGJIGFE, float OAOMDGGCPHF, Color OPOEPBAFNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PDDLMIGPOJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[KKBPAALNMJN(typeof(MCALNKPINNM), new string[] { })]
public class HJPPKKOGDJH : MCALNKPINNM, BOGFHHLHMCB
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly MFFHLJHLBIG HGFFDKCANPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private EDINIDCGNHI CONCNLCHMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private OFKKOHAHMCI FGOMHOJPKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private BAEMKDJGAPE OHDNLJNCDAB;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool AAABFJFMEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5DF09D0", Offset = "0x5DEF5D0", VA = "0x185DF09D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public OFKKOHAHMCI GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public BAEMKDJGAPE BJHGCJGNEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DF04A0", Offset = "0x5DEF0A0", VA = "0x185DF04A0", Slot = "12")]
	public void InitReferences(JHMGDIDCDLA EHNANGKLKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DF06D0", Offset = "0x5DEF2D0", VA = "0x185DF06D0", Slot = "7")]
	public ICDDKLLCIME NKNFIMKMBOH(RigidbodyEx LPIBPEGGEEE)
	{
		return default(ICDDKLLCIME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0530", Offset = "0x5DEF130", VA = "0x185DF0530")]
	private static ICDDKLLCIME MJGIENFHPGB(RigidbodyEx LPIBPEGGEEE)
	{
		return default(ICDDKLLCIME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0630", Offset = "0x5DEF230", VA = "0x185DF0630", Slot = "8")]
	public FAFKHKPFEKI NGAPLOHIPKM(RigidbodyEx LPIBPEGGEEE, CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DF03D0", Offset = "0x5DEEFD0", VA = "0x185DF03D0", Slot = "11")]
	private RigidbodyEx FOGFADFKIHD(GameObject NBIMDBPEIEO, CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DF02E0", Offset = "0x5DEEEE0", VA = "0x185DF02E0", Slot = "9")]
	public void EHFPLOBAFBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0190", Offset = "0x5DEED90", VA = "0x185DF0190", Slot = "10")]
	public void APKFOCFKDHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public HJPPKKOGDJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class BFCJBHENOAM
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const float OHMPLFMOANO = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const float DLFFGENFFFO = 0f;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const float JAHDEJPDGLK = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public BFCJBHENOAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NLHCAGAFFDA
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F23EA0", Offset = "0x6F22AA0", VA = "0x186F23EA0")]
	public static void MIKBJGKOOGI(this Rigidbody LPGBCHBJCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F23D90", Offset = "0x6F22990", VA = "0x186F23D90")]
	public static void MIKBJGKOOGI(this Rigidbody LPGBCHBJCAK, Vector3 LIMDIMJFPNB, Quaternion MIIDBCDLHGC, Vector3 JGECPMODFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F23FF0", Offset = "0x6F22BF0", VA = "0x186F23FF0")]
	public static void NFHMGNOLEMG(Vector3 PPJHGOCBPCK, Vector3 PKBDFEAADGM, out Vector3 HDCAFGJOKJM, out Vector3 GDPFKIBHMML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum FPHOFMJLENJ
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ECIMMNKGOEA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool PJBJHNNIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool EMKHKPNFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event PENLMJLNPDM OCCHAGGOINB;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDAMFPNNPPI();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHOLELPPCJG(FAFKHKPFEKI ONIJEEBBCHK);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CBAHCGLEALK(FAFKHKPFEKI ONIJEEBBCHK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NLOPKOPLBOH
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	float LPAEGLFGFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	float GHCFGOKLHJN
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
	void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface OFKKOHAHMCI
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool LLJBHMHACBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAHLMBDGPDK(string FKPBDLDGFCC);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PHPCFJAKJCC(RigidbodyEx LPIBPEGGEEE, Action FOGMDOMFJBB);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FDLOOMEBFFN KKBIDAPGBJC(int MCJMDOGPMFA);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DGMOCEENFAD(Vector3 HKENGGJIGFE, float OAOMDGGCPHF, Color OPOEPBAFNOG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface MCALNKPINNM
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	OFKKOHAHMCI GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	BAEMKDJGAPE BJHGCJGNEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool AAABFJFMEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ICDDKLLCIME NKNFIMKMBOH(RigidbodyEx LPIBPEGGEEE);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FAFKHKPFEKI NGAPLOHIPKM(RigidbodyEx LPIBPEGGEEE, CJKCMEGMCAM PHBHEFAPHDL);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EHFPLOBAFBB();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void APKFOCFKDHF();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx MINFOIAPHNJ(GameObject NBIMDBPEIEO, [Optional] CJKCMEGMCAM PHBHEFAPHDL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JOKBCEDMKLI
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx CGLLJFNDJEC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NABDDFAEAAL
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 FHHFPANDEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 LKILFMEFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MEILECPHJFN(FAFKHKPFEKI ONIJEEBBCHK, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FKLLDNMELNG(object FLDJLPKNKKO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal class IICGPMHJLKE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6750", Offset = "0x5DF5350", VA = "0x185DF6750")]
	public IICGPMHJLKE(KLJOINJFJMA EFBLLBPFDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DF66F0", Offset = "0x5DF52F0", VA = "0x185DF66F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KLJOINJFJMA : FAFKHKPFEKI, IDisposable, AFHDOJMAAGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const string HGPLFKFIDEE = "HasUnityRigidbodyByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly MCALNKPINNM GAICNONPFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal CMANNCNAEEB PABIOJINDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal PPMGPBJOPHG LIOEFMLCFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal ECIMMNKGOEA HFMKNNGIALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal PMKPCPNEKNE PPJHGOCBPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal NABDDFAEAAL ALIKELHIDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal IPMJOKMPDFD EDJNKFIBEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal NLOPKOPLBOH MMPBNEKGDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal DPIKHFGILLN HDFNJCCOBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal LDMPFENPFIH BDJDLEHEGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal HMNJOAIBFBB CBFFLIGMIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal JAFLIGJBBGN PLECFEFOMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal NAAOIBJHADK HCKNDFMIDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal JEDJEILBNNF EICBDICCCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal BEOHALDGFAH CNBDNPIBOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal GADMMIHBFNL OLPKFIHFFGD;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public RigidbodyEx AHAAINDKLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x83E3B0", Offset = "0x83CFB0", VA = "0x18083E3B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0E0", Offset = "0xA3CCE0", VA = "0x180A3E0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public GameObject ICCGPNIDAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x873690", Offset = "0x872290", VA = "0x180873690", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xABEE70", Offset = "0xABDA70", VA = "0x180ABEE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Transform ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5DFDCB0", Offset = "0x5DFC8B0", VA = "0x185DFDCB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public IEnumerable<object> OEJGBFHANNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E00710", Offset = "0x5DFF310", VA = "0x185E00710", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E02BF0", Offset = "0x5E017F0", VA = "0x185E02BF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5E02940", Offset = "0x5E01540", VA = "0x185E02940", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5E02C90", Offset = "0x5E01890", VA = "0x185E02C90", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IReadOnlyList<FAFKHKPFEKI> GBEAOJFNDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5E01660", Offset = "0x5E00260", VA = "0x185E01660", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public FAFKHKPFEKI ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5E02F90", Offset = "0x5E01B90", VA = "0x185E02F90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5E02FE0", Offset = "0x5E01BE0", VA = "0x185E02FE0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool PJBJHNNIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5E001F0", Offset = "0x5DFEDF0", VA = "0x185E001F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool EMKHKPNFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5E03040", Offset = "0x5E01C40", VA = "0x185E03040", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public MLAAMHAMNCK KNKDIKABJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5DFDF10", Offset = "0x5DFCB10", VA = "0x185DFDF10", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5E00FD0", Offset = "0x5DFFBD0", VA = "0x185E00FD0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public JHEBHKGMPAF CPNBMHEFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5DFFE00", Offset = "0x5DFEA00", VA = "0x185DFFE00", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5E032D0", Offset = "0x5E01ED0", VA = "0x185E032D0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float FNKBHNMOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5DFDFC0", Offset = "0x5DFCBC0", VA = "0x185DFDFC0", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5E010E0", Offset = "0x5DFFCE0", VA = "0x185E010E0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector3 LAOGHFMMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5DFFE50", Offset = "0x5DFEA50", VA = "0x185DFFE50", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5DFFF70", Offset = "0x5DFEB70", VA = "0x185DFFF70", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Vector3 EHDBLKFCOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5E03570", Offset = "0x5E02170", VA = "0x185E03570", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5DFD8E0", Offset = "0x5DFC4E0", VA = "0x185DFD8E0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5DFDA50", Offset = "0x5DFC650", VA = "0x185DFDA50", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5DFE8B0", Offset = "0x5DFD4B0", VA = "0x185DFE8B0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Vector3 KKAHELGKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5E03440", Offset = "0x5E02040", VA = "0x185E03440", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5E03700", Offset = "0x5E02300", VA = "0x185E03700", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool JKOBEIFFLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5DFD840", Offset = "0x5DFC440", VA = "0x185DFD840", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool DGHDMLPPOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5DFDE10", Offset = "0x5DFCA10", VA = "0x185DFDE10", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool FFNCCFIMIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5E01BB0", Offset = "0x5E007B0", VA = "0x185E01BB0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool MFEJBDEHODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5DFF600", Offset = "0x5DFE200", VA = "0x185DFF600", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector3 FHHFPANDEGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5E01140", Offset = "0x5DFFD40", VA = "0x185E01140", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 LKILFMEFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5E002F0", Offset = "0x5DFEEF0", VA = "0x185E002F0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 KENEHBJMFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5E02E00", Offset = "0x5E01A00", VA = "0x185E02E00", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5DFF3B0", Offset = "0x5DFDFB0", VA = "0x185DFF3B0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 KEILFIFPNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5E025B0", Offset = "0x5E011B0", VA = "0x185E025B0", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float JNGHFGELAMD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5E02C40", Offset = "0x5E01840", VA = "0x185E02C40", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public float GPAHEKCCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5DFFB40", Offset = "0x5DFE740", VA = "0x185DFFB40", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5E01CA0", Offset = "0x5E008A0", VA = "0x185E01CA0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Vector3 GJOKEJOLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5E02CF0", Offset = "0x5E018F0", VA = "0x185E02CF0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Quaternion NJHBIADEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5E00CF0", Offset = "0x5DFF8F0", VA = "0x185E00CF0", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public float LPAEGLFGFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5DFF560", Offset = "0x5DFE160", VA = "0x185DFF560", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5DFE1D0", Offset = "0x5DFCDD0", VA = "0x185DFE1D0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float GHCFGOKLHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5E00970", Offset = "0x5DFF570", VA = "0x185E00970", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5E00880", Offset = "0x5DFF480", VA = "0x185E00880", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool MMEFLHGHBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5E02210", Offset = "0x5E00E10", VA = "0x185E02210", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5E02680", Offset = "0x5E01280", VA = "0x185E02680", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public GALCBGLBFAD EFPMFLGMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5E02B40", Offset = "0x5E01740", VA = "0x185E02B40", Slot = "51")]
		get
		{
			return default(GALCBGLBFAD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5DFF650", Offset = "0x5DFE250", VA = "0x185DFF650", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5DFD890", Offset = "0x5DFC490", VA = "0x185DFD890", Slot = "53")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Transform EMNGBEEEHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5DFE720", Offset = "0x5DFD320", VA = "0x185DFE720", Slot = "54")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Transform BJCECNAIBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5DFE720", Offset = "0x5DFD320", VA = "0x185DFE720", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 COBBPPAHGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5E01210", Offset = "0x5DFFE10", VA = "0x185E01210", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5E005A0", Offset = "0x5DFF1A0", VA = "0x185E005A0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float MONKEGPBKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5E008E0", Offset = "0x5DFF4E0", VA = "0x185E008E0", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5E00900", Offset = "0x5DFF500", VA = "0x185E00900", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public float KCCKNLIMMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5E00860", Offset = "0x5DFF460", VA = "0x185E00860", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5E03330", Offset = "0x5E01F30", VA = "0x185E03330", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Quaternion AEOIOMHPLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5E02360", Offset = "0x5E00F60", VA = "0x185E02360", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5DFF4D0", Offset = "0x5DFE0D0", VA = "0x185DFF4D0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 FLNDEGFPBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5E012D0", Offset = "0x5DFFED0", VA = "0x185E012D0", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5DFDE70", Offset = "0x5DFCA70", VA = "0x185DFDE70", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Quaternion OCOFEOLGBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5E02570", Offset = "0x5E01170", VA = "0x185E02570", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5DFE730", Offset = "0x5DFD330", VA = "0x185DFE730", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public RigidbodyConstraints DDHNPMJICJD
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5E01440", Offset = "0x5E00040", VA = "0x185E01440", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5DFDF60", Offset = "0x5DFCB60", VA = "0x185DFDF60", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool LGMFNHPALFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5E01490", Offset = "0x5E00090", VA = "0x185E01490", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x5E01320", Offset = "0x5DFFF20", VA = "0x185E01320", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool BDJDMEHPAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5E00B90", Offset = "0x5DFF790", VA = "0x185E00B90", Slot = "133")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CollisionDetectionMode HDBNMHILGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5DFDEC0", Offset = "0x5DFCAC0", VA = "0x185DFDEC0", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5E02AE0", Offset = "0x5E016E0", VA = "0x185E02AE0", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool NDLKKFGHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5E01A60", Offset = "0x5E00660", VA = "0x185E01A60", Slot = "142")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public bool HPAPGLPAOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5E016B0", Offset = "0x5E002B0", VA = "0x185E016B0", Slot = "74")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool DOAGCOOFKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5E00BE0", Offset = "0x5DFF7E0", VA = "0x185E00BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool CGMDMAJLBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5E02DC0", Offset = "0x5E019C0", VA = "0x185E02DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event PENLMJLNPDM ABGONPKEDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E02A80", Offset = "0x5E01680", VA = "0x185E02A80", Slot = "80")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E01D00", Offset = "0x5E00900", VA = "0x185E01D00", Slot = "81")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event PENLMJLNPDM PCAPCNOAOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5E036A0", Offset = "0x5E022A0", VA = "0x185E036A0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5DFE420", Offset = "0x5DFD020", VA = "0x185DFE420", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event IJIIOKHNDCH IAIGIJMEMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5DFDC50", Offset = "0x5DFC850", VA = "0x185DFDC50", Slot = "84")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5DFF790", Offset = "0x5DFE390", VA = "0x185DFF790", Slot = "85")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event PENLMJLNPDM OCCHAGGOINB
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5DFE980", Offset = "0x5DFD580", VA = "0x185DFE980", Slot = "87")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5DFE5E0", Offset = "0x5DFD1E0", VA = "0x185DFE5E0", Slot = "88")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event PENLMJLNPDM DDALOGBJKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5E02F30", Offset = "0x5E01B30", VA = "0x185E02F30", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5E03510", Offset = "0x5E02110", VA = "0x185E03510", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event PENLMJLNPDM OKAHFOGBNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5E013E0", Offset = "0x5DFFFE0", VA = "0x185E013E0", Slot = "112")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5E02B90", Offset = "0x5E01790", VA = "0x185E02B90", Slot = "113")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<GBAHALBBEFO, GBAHALBBEFO> KKOALOMMEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5E03090", Offset = "0x5E01C90", VA = "0x185E03090", Slot = "116")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5E03640", Offset = "0x5E02240", VA = "0x185E03640", Slot = "117")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event PENLMJLNPDM IBIEOIEHHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5DFDBF0", Offset = "0x5DFC7F0", VA = "0x185DFDBF0", Slot = "118")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5E01380", Offset = "0x5DFFF80", VA = "0x185E01380", Slot = "119")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event PENLMJLNPDM MOMDHFIOGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5DFD9B0", Offset = "0x5DFC5B0", VA = "0x185DFD9B0", Slot = "124")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5DFFD10", Offset = "0x5DFE910", VA = "0x185DFFD10", Slot = "125")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E03810", Offset = "0x5E02410", VA = "0x185E03810")]
	public KLJOINJFJMA(GameObject ALBKEDBKENG, RigidbodyEx GNMMOMPJING, MCALNKPINNM GAICNONPFPG, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEB50", Offset = "0x5DFD750", VA = "0x185DFEB50", Slot = "143")]
	protected virtual void DIGCCAPCOMD(MCALNKPINNM GAICNONPFPG, CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF2E0", Offset = "0x5DFDEE0", VA = "0x185DFF2E0", Slot = "144")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE770", Offset = "0x5DFD370", VA = "0x185DFE770", Slot = "75")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFF20", Offset = "0x5DFEB20", VA = "0x185DFFF20", Slot = "76")]
	public void MBMKEKPNCDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF770", Offset = "0x5DFE370", VA = "0x185DFF770", Slot = "77")]
	public void FABPKIFEFOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD730", Offset = "0x5DFC330", VA = "0x185DFD730", Slot = "145")]
	public virtual void AHMPHJEIING()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5E01840", Offset = "0x5E00440", VA = "0x185E01840", Slot = "86")]
	public void JPDJPFJGJJB(FAFKHKPFEKI ECNGHFJBIJL, bool NGKEIPOGCJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E006B0", Offset = "0x5DFF2B0", VA = "0x185E006B0", Slot = "89")]
	public void GFCCENMEHND(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5E00650", Offset = "0x5DFF250", VA = "0x185E00650", Slot = "90")]
	public void GEOOCCNGKCP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF1F0", Offset = "0x5DFDDF0", VA = "0x185DFF1F0", Slot = "91")]
	public Vector3 DPKJENDBDFP(Vector3 PLGCJGPJLOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE330", Offset = "0x5DFCF30", VA = "0x185DFE330", Slot = "92")]
	public Vector3 CCMNDDEHNJA(Vector3 LLBIDODECBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFF20", Offset = "0x5DFEB20", VA = "0x185DFFF20", Slot = "93")]
	public void FMGKABPAPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5E00810", Offset = "0x5DFF410", VA = "0x185E00810", Slot = "94")]
	public void GOPHGLEKHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5E00A40", Offset = "0x5DFF640", VA = "0x185E00A40", Slot = "95")]
	public void HNPHPPHGNGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE0E0", Offset = "0x5DFCCE0", VA = "0x185DFE0E0", Slot = "96")]
	public void CBIKPKMEKKL(Vector3 EOJNKDCENDM, Vector3 POIEPCCNOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5E030F0", Offset = "0x5E01CF0", VA = "0x185E030F0", Slot = "97")]
	public void OPGFEEFJGGG(Vector3 NNFLIAGNPGB, Vector3 AFFJGLIILJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFB90", Offset = "0x5DFE790", VA = "0x185DFFB90", Slot = "98")]
	public void FEMBKDIAAAP(Vector3 KDJKJGOIBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5E014E0", Offset = "0x5E000E0", VA = "0x185E014E0", Slot = "99")]
	public void JMFNPJJKFKO(FPHOFMJLENJ LFJLPJDIOGB, Vector3 AFOFGLGBJEI, float CAMLBJONKHG, float KDMJGHCHEJE = 8f, float GLBOFKBMMGD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5E02260", Offset = "0x5E00E60", VA = "0x185E02260", Slot = "100")]
	public void KMGAIKJKMEL(GJCDONMOIJG JCFGFBHJEMJ, Vector3 ODOOOABGMIH, float AFFFNJJAEBG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5E026E0", Offset = "0x5E012E0", VA = "0x185E026E0", Slot = "101")]
	[Obsolete]
	public void LPOCGBNGDFJ(GJCDONMOIJG JCFGFBHJEMJ, Vector3 KDPJNNPKKHC, float LMLCPPONLID = 7f, float EOPJPNPJINM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5E031E0", Offset = "0x5E01DE0", VA = "0x185E031E0", Slot = "102")]
	public Vector3 PBIHOCFKCJD(Vector3 ECNGHFJBIJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5E02410", Offset = "0x5E01010", VA = "0x185E02410", Slot = "103")]
	public Vector3 KMNEHIALFMG(Vector3 ECNGHFJBIJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF5B0", Offset = "0x5DFE1B0", VA = "0x185DFF5B0", Slot = "104")]
	public void ELHHONDCCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDB20", Offset = "0x5DFC720", VA = "0x185DFDB20", Slot = "105")]
	public void BDODKLGLFCI(FAFKHKPFEKI OFKMLDLKKGB, object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD7E0", Offset = "0x5DFC3E0", VA = "0x185DFD7E0", Slot = "106")]
	public void AKFOKBBCEAC(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE640", Offset = "0x5DFD240", VA = "0x185DFE640", Slot = "44")]
	public void CLDNGGKFBHC((Quaternion rot, Vector3 moments) DCEIBGLEFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDB0", Offset = "0x5DFE9B0", VA = "0x185DFFDB0", Slot = "109")]
	public void FGMANKLHEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE590", Offset = "0x5DFD190", VA = "0x185DFE590", Slot = "110")]
	public void CFOFFHECGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5E02A30", Offset = "0x5E01630", VA = "0x185E02A30", Slot = "111")]
	public void MOGOAIJKGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD6E0", Offset = "0x5DFC2E0", VA = "0x185DFD6E0", Slot = "114")]
	public bool AHEGLGAEPAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF480", Offset = "0x5DFE080", VA = "0x185DFF480", Slot = "78")]
	public void EFAMGCMKBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5E01090", Offset = "0x5DFFC90", VA = "0x185E01090", Slot = "115")]
	public void JDFOHMHOLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFC60", Offset = "0x5DFE860", VA = "0x185DFFC60", Slot = "120")]
	public IDisposable FFBAOBHCCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5E01600", Offset = "0x5E00200", VA = "0x185E01600", Slot = "121")]
	public void JMLHFLEGLGJ(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5E02ED0", Offset = "0x5E01AD0", VA = "0x185E02ED0", Slot = "122")]
	public void OEHMBAJJPJP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5E02500", Offset = "0x5E01100", VA = "0x185E02500", Slot = "123")]
	public void LAIGJEGAOJL(object FLDJLPKNKKO, bool GCGPLALBKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5E00DC0", Offset = "0x5DFF9C0", VA = "0x185E00DC0", Slot = "126")]
	public void IKECCJJDGDP(Vector3 CBIOILEAJIH, Quaternion ECGDKPNOHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5E00040", Offset = "0x5DFEC40", VA = "0x185E00040", Slot = "127")]
	public void FPNKIBCOPLG(Vector3 ELPFDBFBPJP, Quaternion PDEDDIGJHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5E01030", Offset = "0x5DFFC30", VA = "0x185E01030", Slot = "128")]
	public bool IOBHGAHMENP(float OMOAPNBJLBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF710", Offset = "0x5DFE310", VA = "0x185DFF710", Slot = "129")]
	public void ENPJOCBLDHN(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFCB0", Offset = "0x5DFE8B0", VA = "0x185DFFCB0", Slot = "130")]
	public void FFBLKOEHHKE(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5E00760", Offset = "0x5DFF360", VA = "0x185E00760", Slot = "131")]
	public void GHIPEPNLOHM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5E00C90", Offset = "0x5DFF890", VA = "0x185E00C90", Slot = "132")]
	public void IFJCMMGNPMM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5E02990", Offset = "0x5E01590", VA = "0x185E02990")]
	public void MNKABIJBAEL(object FLDJLPKNKKO, bool AFPDPADDMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF7F0", Offset = "0x5DFE3F0", VA = "0x185DFF7F0", Slot = "134")]
	public void FCCAHBEJJFC(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE480", Offset = "0x5DFD080", VA = "0x185DFE480", Slot = "135")]
	public void CELICFPJCIO(Vector3 HCKNDFMIDDI, Vector3 NABPHMOHNDG, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5E009C0", Offset = "0x5DFF5C0", VA = "0x185E009C0", Slot = "136")]
	public void HLFGLHDAPJI(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5E027F0", Offset = "0x5E013F0", VA = "0x185E027F0", Slot = "137")]
	public void MCJILHDCBCN(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5E00A90", Offset = "0x5DFF690", VA = "0x185E00A90", Slot = "138")]
	public bool HPEHJMJKMBE(Vector3 AGOGLFBBBLL, out RaycastHit MLBCOPMGEFF, float LHLJEFHGAPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5E007C0", Offset = "0x5DFF3C0", VA = "0x185E007C0", Slot = "139")]
	public void GKCLCHKBIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5E037D0", Offset = "0x5E023D0", VA = "0x185E037D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDD40", Offset = "0x5DFC940", VA = "0x185DFDD40")]
	private void BHJDGJHMJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5E018B0", Offset = "0x5E004B0", VA = "0x185E018B0")]
	private void KBAIPCPMFOL(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5E003C0", Offset = "0x5DFEFC0", VA = "0x185E003C0")]
	private void GDBIDIMIOEI(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5E00240", Offset = "0x5DFEE40", VA = "0x185E00240")]
	private void GBEOLMMODIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE230", Offset = "0x5DFCE30", VA = "0x185DFE230")]
	private void CCGACNHJLIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5E02100", Offset = "0x5E00D00", VA = "0x185E02100")]
	private void KJEHAIENAKE(FAFKHKPFEKI DBHJCCLCMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5E02870", Offset = "0x5E01470", VA = "0x185E02870")]
	private void MHOLELPPCJG(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE010", Offset = "0x5DFCC10", VA = "0x185DFE010")]
	private void CBAHCGLEALK(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE9E0", Offset = "0x5DFD5E0", VA = "0x185DFE9E0")]
	private void DHLLADGECJC(RigidbodyEx ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5E01D60", Offset = "0x5E00960", VA = "0x185E01D60", Slot = "146")]
	protected virtual void KIDECLKFDOJ(RigidbodyEx LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5E01FD0", Offset = "0x5E00BD0", VA = "0x185E01FD0")]
	[Conditional("UNITY_EDITOR")]
	private void KIDJBHHOICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF870", Offset = "0x5DFE470", VA = "0x185DFF870")]
	protected void FCIIPIKELJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEE30", Offset = "0x5DFDA30", VA = "0x185DFEE30")]
	protected void DMFCEPEBHMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal static class EGNJBEJBNIH
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4B50", Offset = "0x5DE3750", VA = "0x185DE4B50")]
	public static FAFKHKPFEKI EDMEKBKHLAN(this FAFKHKPFEKI LPIBPEGGEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4AD0", Offset = "0x5DE36D0", VA = "0x185DE4AD0")]
	public static bool CEFJFNELIIP(this FAFKHKPFEKI LPIBPEGGEEE, FAFKHKPFEKI LDCOLCDIOIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4C80", Offset = "0x5DE3880", VA = "0x185DE4C80")]
	public static bool MAIDKEOPNBC(this FAFKHKPFEKI LPIBPEGGEEE, FAFKHKPFEKI DHHBLOHICNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4A80", Offset = "0x5DE3680", VA = "0x185DE4A80")]
	public static RigidbodyEx AHAAINDKLOK(this FAFKHKPFEKI AOOPEEENLEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4C10", Offset = "0x5DE3810", VA = "0x185DE4C10")]
	public static KLJOINJFJMA IIJFNGJDPAG(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IPMJOKMPDFD
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 KENEHBJMFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 KEILFIFPNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float JNGHFGELAMD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float GPAHEKCCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 GJOKEJOLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Quaternion NJHBIADEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event PENLMJLNPDM NGIDLMLHHJM;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CLDNGGKFBHC((Quaternion rot, Vector3 moments) DCEIBGLEFBC);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CFOFFHECGMA();

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FGMANKLHEDO();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MOGOAIJKGFM();

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GKCLCHKBIHO();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface AFHDOJMAAGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool NDLKKFGHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FAFKHKPFEKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	RigidbodyEx AHAAINDKLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	GameObject ICCGPNIDAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Transform ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	IEnumerable<object> OEJGBFHANNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	IReadOnlyList<FAFKHKPFEKI> GBEAOJFNDCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	FAFKHKPFEKI ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool PJBJHNNIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool EMKHKPNFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	MLAAMHAMNCK KNKDIKABJHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	JHEBHKGMPAF CPNBMHEFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	float FNKBHNMOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Vector3 LAOGHFMMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Vector3 EHDBLKFCOBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 KKAHELGKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool JKOBEIFFLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool DGHDMLPPOFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool FFNCCFIMIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool MFEJBDEHODC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Vector3 FHHFPANDEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Vector3 LKILFMEFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Vector3 KENEHBJMFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Vector3 KEILFIFPNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	float JNGHFGELAMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	float GPAHEKCCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Vector3 GJOKEJOLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Quaternion NJHBIADEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	float LPAEGLFGFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	float GHCFGOKLHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool MMEFLHGHBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	GALCBGLBFAD EFPMFLGMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	Transform EMNGBEEEHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Transform BJCECNAIBIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 COBBPPAHGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	float MONKEGPBKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	float KCCKNLIMMOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Quaternion AEOIOMHPLMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	Vector3 FLNDEGFPBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Quaternion OCOFEOLGBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	RigidbodyConstraints DDHNPMJICJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool LGMFNHPALFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	CollisionDetectionMode HDBNMHILGIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool HPAPGLPAOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool BDJDMEHPAFC
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "129")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event PENLMJLNPDM ABGONPKEDMI;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event PENLMJLNPDM PCAPCNOAOJG;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event IJIIOKHNDCH IAIGIJMEMKI;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event PENLMJLNPDM OCCHAGGOINB;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event PENLMJLNPDM DDALOGBJKIJ;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event PENLMJLNPDM OKAHFOGBNGD;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event Action<GBAHALBBEFO, GBAHALBBEFO> KKOALOMMEIL;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event PENLMJLNPDM IBIEOIEHHMK;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event PENLMJLNPDM MOMDHFIOGGG;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void CLDNGGKFBHC((Quaternion rot, Vector3 moments) DCEIBGLEFBC);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void DDAMFPNNPPI();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void MBMKEKPNCDC();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void FABPKIFEFOL();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void EFAMGCMKBGN();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void AHMPHJEIING();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "82")]
	void JPDJPFJGJJB(FAFKHKPFEKI ECNGHFJBIJL, bool NGKEIPOGCJF = false);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void GFCCENMEHND(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void GEOOCCNGKCP(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "87")]
	Vector3 DPKJENDBDFP(Vector3 PLGCJGPJLOA);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 CCMNDDEHNJA(Vector3 LLBIDODECBJ);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void FMGKABPAPIP();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void GOPHGLEKHBH();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void HNPHPPHGNGH();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void CBIKPKMEKKL(Vector3 EOJNKDCENDM, Vector3 POIEPCCNOCI);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void OPGFEEFJGGG(Vector3 NNFLIAGNPGB, Vector3 AFFJGLIILJO);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void FEMBKDIAAAP(Vector3 KDJKJGOIBLL);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void JMFNPJJKFKO(FPHOFMJLENJ LFJLPJDIOGB, Vector3 AFOFGLGBJEI, float CAMLBJONKHG, float KDMJGHCHEJE = 8f, float GLBOFKBMMGD = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void KMGAIKJKMEL(GJCDONMOIJG JCFGFBHJEMJ, Vector3 ODOOOABGMIH, float AFFFNJJAEBG = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void LPOCGBNGDFJ(GJCDONMOIJG JCFGFBHJEMJ, Vector3 KDPJNNPKKHC, float LMLCPPONLID = 7f, float EOPJPNPJINM = 1f);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 PBIHOCFKCJD(Vector3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 KMNEHIALFMG(Vector3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void ELHHONDCCEA();

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void BDODKLGLFCI(FAFKHKPFEKI OFKMLDLKKGB, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void AKFOKBBCEAC(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void FGMANKLHEDO();

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void CFOFFHECGMA();

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void MOGOAIJKGFM();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "110")]
	bool AHEGLGAEPAK();

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void JDFOHMHOLKJ();

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "116")]
	IDisposable FFBAOBHCCAJ();

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void JMLHFLEGLGJ(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void OEHMBAJJPJP(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void LAIGJEGAOJL(object FLDJLPKNKKO, bool GCGPLALBKNG);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void IKECCJJDGDP(Vector3 CBIOILEAJIH, Quaternion ECGDKPNOHAO);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void FPNKIBCOPLG(Vector3 ELPFDBFBPJP, Quaternion PDEDDIGJHCG);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "124")]
	bool IOBHGAHMENP(float OMOAPNBJLBI);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void ENPJOCBLDHN(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void FFBLKOEHHKE(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void GHIPEPNLOHM(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void IFJCMMGNPMM(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void FCCAHBEJJFC(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void CELICFPJCIO(Vector3 HCKNDFMIDDI, Vector3 NABPHMOHNDG, ForceMode MKILKFIGPHM);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void HLFGLHDAPJI(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void MCJILHDCBCN(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool HPEHJMJKMBE(Vector3 AGOGLFBBBLL, out RaycastHit MLBCOPMGEFF, float LHLJEFHGAPL);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void GKCLCHKBIHO();

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NAAOIBJHADK
{
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCCAHBEJJFC(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CELICFPJCIO(Vector3 HCKNDFMIDDI, Vector3 NABPHMOHNDG, ForceMode MKILKFIGPHM);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HLFGLHDAPJI(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCJILHDCBCN(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MLAAMHAMNCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 OHEPKJEBFID();

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 BFPGMPGOAEH();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PPMGPBJOPHG
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool CJIJDGNKPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	LHPAGGDFKDF NMBGGBCMFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDAMFPNNPPI();

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AFGGHBKIECF(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPELJIHJKHN(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFIPOFHIKLA(FAFKHKPFEKI LPIBPEGGEEE);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KOPPABHPADM(FAFKHKPFEKI LPIBPEGGEEE);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ODHNAICIIGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HMNJOAIBFBB : IDisposable, ADEMDHOELEN
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	GALCBGLBFAD EFPMFLGMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<GBAHALBBEFO, GBAHALBBEFO> KKOALOMMEIL;

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDAMFPNNPPI();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface CMANNCNAEEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	IReadOnlyList<FAFKHKPFEKI> GBEAOJFNDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	FAFKHKPFEKI ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event PENLMJLNPDM ABGONPKEDMI;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event PENLMJLNPDM PCAPCNOAOJG;

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	event IJIIOKHNDCH IAIGIJMEMKI;

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	event Action ILMHHPLDHOO;

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	event Action LKKCMMNHMJL;

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	event Action<FAFKHKPFEKI> HMDKKBAFIJC;

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	event Action<FAFKHKPFEKI> IDGBMMFDPEK;

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	event Action MBIPKGCCLDK;

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	event Action<FAFKHKPFEKI> ICECBJMMMCO;

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JPDJPFJGJJB(FAFKHKPFEKI PBNMPICADBG, bool NGKEIPOGCJF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface BAEMKDJGAPE
{
	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMANNCNAEEB PIKJDPLOAGA(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PMKPCPNEKNE FFCOEIPKDAE(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NABDDFAEAAL NGOPFPIKHBH(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NLOPKOPLBOH HKNKHNJFNMP(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LDMPFENPFIH PBCPKPGDLMH(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HMNJOAIBFBB NAJFMIHAFGH(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JAFLIGJBBGN MNKPOCKEPKN(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NAAOIBJHADK MLMCAEOHELL(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GADMMIHBFNL HINFDFADGBH(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DPIKHFGILLN GBLBFLKHODN(FAFKHKPFEKI NHIFGJKHMEC);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BEOHALDGFAH NFAMOAOKLDA(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ECIMMNKGOEA NBKLAOJGNOL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PPMGPBJOPHG BPIIGMDCEFM(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IPMJOKMPDFD KJLFHAFEJJI(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JEDJEILBNNF BGFDJPKHNDP(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FAFKHKPFEKI NGAPLOHIPKM(RigidbodyEx LPIBPEGGEEE, CJKCMEGMCAM PHBHEFAPHDL, MCALNKPINNM GAICNONPFPG);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface JEDJEILBNNF
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool LGMFNHPALFN
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool KGKNONHGELK
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	RigidbodyConstraints DDHNPMJICJD
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
	void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JHEBHKGMPAF
{
	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPPEKBPHOAI(Vector3 DACMIONAPNF);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CFGBDHECLAN(Vector3 JDNINLGNNJF);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OONNGPOACNE(Vector3 DACMIONAPNF);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void COEOOJPLLEB(Vector3 JDNINLGNNJF);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface JAFLIGJBBGN
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	IEnumerable<object> LDNIHOLIOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	event PENLMJLNPDM IBIEOIEHHMK;

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BAHNFOENCGE();

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JMLHFLEGLGJ(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OEHMBAJJPJP(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LAIGJEGAOJL(object FLDJLPKNKKO, bool GCGPLALBKNG);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IDisposable FFBAOBHCCAJ();

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LBEBFFILMKK(Rigidbody GGGGHNNPHJC);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface GADMMIHBFNL
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	CollisionDetectionMode HDBNMHILGIE
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
	void DDAMFPNNPPI();

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MEHHJKMGHLL(bool ICBDCKBKPKF);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJEBGEAKFJB(bool ICBDCKBKPKF);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HPEHJMJKMBE(Vector3 AGOGLFBBBLL, out RaycastHit MLBCOPMGEFF, float LHLJEFHGAPL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface PMKPCPNEKNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	MLAAMHAMNCK KNKDIKABJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	JHEBHKGMPAF CPNBMHEFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Vector3 LAOGHFMMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Vector3 KKAHELGKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	Vector3 EHDBLKFCOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	float FNKBHNMOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	bool MFEJBDEHODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DDAMFPNNPPI();

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IDHOAFOCKIJ(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KMGAIKJKMEL(GJCDONMOIJG JCFGFBHJEMJ, Vector3 ODOOOABGMIH, float AFFFNJJAEBG = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JMFNPJJKFKO(FPHOFMJLENJ LFJLPJDIOGB, Vector3 AFOFGLGBJEI, float CAMLBJONKHG, float KDMJGHCHEJE = 8f, float GLBOFKBMMGD = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LPOCGBNGDFJ(GJCDONMOIJG JCFGFBHJEMJ, Vector3 KDPJNNPKKHC, float LMLCPPONLID = 7f, float EOPJPNPJINM = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HNPHPPHGNGH();

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GOPHGLEKHBH();

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ELHHONDCCEA();

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void FMGKABPAPIP();

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 KMNEHIALFMG(Vector3 JDNINLGNNJF);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 PBIHOCFKCJD(Vector3 PPJHGOCBPCK);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void COEBAFIHDGK(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FEMBKDIAAAP(Vector3 KDJKJGOIBLL);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void OPGFEEFJGGG(Vector3 NNFLIAGNPGB, Vector3 AFFJGLIILJO);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void CBIKPKMEKKL(Vector3 EOJNKDCENDM, Vector3 POIEPCCNOCI);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 CCMNDDEHNJA(Vector3 LLBIDODECBJ);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 DPKJENDBDFP(Vector3 PLGCJGPJLOA);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BEOHALDGFAH
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	bool BDJDMEHPAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDAMFPNNPPI();

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GHIPEPNLOHM(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IFJCMMGNPMM(object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AKBFBEIOBJL();

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DBPBPENLGPL();

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IGMALIJEELK();

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NGEMPCCFGGD();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DPIKHFGILLN
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	bool MMEFLHGHBCL
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
	void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ);

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LDMPFENPFIH
{
	[Cpp2IlInjected.Token(Token = "0x14000029")]
	event PENLMJLNPDM OKAHFOGBNGD;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDAMFPNNPPI();

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AHEGLGAEPAK();

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FPMMBIEPONO();

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EFAMGCMKBGN();

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CDIMIBACCOA();

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JDFOHMHOLKJ();

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FBMPOHOFPGJ(bool AOHFCNFADMO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[KKBPAALNMJN(typeof(OCPDIKODPNM), new string[] { })]
public sealed class FAFIBKLLHHG : BOGFHHLHMCB, OCPDIKODPNM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[BDIAFGIKHDL]
	private BCOGGGBMMOK LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool JHFNJCFMCPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x851940", Offset = "0x850540", VA = "0x180851940", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8BC0", Offset = "0x5DE77C0", VA = "0x185DE8BC0", Slot = "4")]
	public void InitReferences(JHMGDIDCDLA EHNANGKLKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE87D0", Offset = "0x5DE73D0", VA = "0x185DE87D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8C10", Offset = "0x5DE7810", VA = "0x185DE8C10", Slot = "6")]
	public void JCGOMGHJDJL(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8940", Offset = "0x5DE7540", VA = "0x185DE8940", Slot = "7")]
	public void HKHBOINIIGG(ICDDKLLCIME EEOIFMPKINO, bool OFPIHBKDDCH, bool PFMKDPAMNII, bool BIHGJFFAABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8800", Offset = "0x5DE7400", VA = "0x185DE8800")]
	private bool EDBFICJLCJJ(ICDDKLLCIME EEOIFMPKINO, out KDCPJKLPAPB NHIFGJKHMEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8EF0", Offset = "0x5DE7AF0", VA = "0x185DE8EF0")]
	private bool MNKOBJCFGKK(ICDDKLLCIME EEOIFMPKINO, out JDLMFJEEHBM KEIIDHHNOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8DA0", Offset = "0x5DE79A0", VA = "0x185DE8DA0")]
	private bool JJGMIKNDDBI(ICDDKLLCIME EEOIFMPKINO, out HKFPBDAEJKC JOCBENOCNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public FAFIBKLLHHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class HKFPBDAEJKC : KOJGKBEMDEB, IPMJOKMPDFD
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	[Obsolete]
	public Vector3 KENEHBJMFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3FB0", Offset = "0x5DF2BB0", VA = "0x185DF3FB0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5DF14D0", Offset = "0x5DF00D0", VA = "0x185DF14D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 ELBOLAAKPOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DF24B0", Offset = "0x5DF10B0", VA = "0x185DF24B0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x5DF14D0", Offset = "0x5DF00D0", VA = "0x185DF14D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 HCGFPCGKPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5DF1500", Offset = "0x5DF0100", VA = "0x185DF1500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	[Obsolete]
	public Vector3 KEILFIFPNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3AC0", Offset = "0x5DF26C0", VA = "0x185DF3AC0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete]
	public float JNGHFGELAMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3EA0", Offset = "0x5DF2AA0", VA = "0x185DF3EA0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float LBKNHHCNMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DF40E0", Offset = "0x5DF2CE0", VA = "0x185DF40E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public float GPAHEKCCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DF1630", Offset = "0x5DF0230", VA = "0x185DF1630", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x5DF13D0", Offset = "0x5DEFFD0", VA = "0x185DF13D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 GJOKEJOLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3F80", Offset = "0x5DF2B80", VA = "0x185DF3F80", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public Quaternion NJHBIADEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2300", Offset = "0x5DF0F00", VA = "0x185DF2300", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4870", Offset = "0x5DE3470", VA = "0x185DE4870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event PENLMJLNPDM NGIDLMLHHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3C40", Offset = "0x5DF2840", VA = "0x185DF3C40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5DF1990", Offset = "0x5DF0590", VA = "0x185DF1990", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DF43D0", Offset = "0x5DF2FD0", VA = "0x185DF43D0")]
	public HKFPBDAEJKC(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4310", Offset = "0x5DF2F10", VA = "0x185DF4310")]
	public float3 PKIIOCFAKHH()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0AB0", Offset = "0x5DEF6B0", VA = "0x185DF0AB0")]
	public bool ADDPKNIPLIB(out float3 HKENGGJIGFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3DC0", Offset = "0x5DF29C0", VA = "0x185DF3DC0")]
	public void NHOLJPJKDGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2210", Offset = "0x5DF0E10", VA = "0x185DF2210")]
	public bool IBJDHIFLJOO(out float CHODJKFAPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1150", Offset = "0x5DEFD50", VA = "0x185DF1150", Slot = "14")]
	public void CLDNGGKFBHC((Quaternion rot, Vector3 moments) DCEIBGLEFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1710", Offset = "0x5DF0310", VA = "0x185DF1710", Slot = "16")]
	public void FGMANKLHEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0DD0", Offset = "0x5DEF9D0", VA = "0x185DF0DD0", Slot = "15")]
	public void CFOFFHECGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3970", Offset = "0x5DF2570", VA = "0x185DF3970", Slot = "18")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1F40", Offset = "0x5DF0B40", VA = "0x185DF1F40", Slot = "19")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3CE0", Offset = "0x5DF28E0", VA = "0x185DF3CE0", Slot = "17")]
	public void MOGOAIJKGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1A30", Offset = "0x5DF0630", VA = "0x185DF1A30", Slot = "20")]
	public void GKCLCHKBIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7CB0", Offset = "0x5DE68B0", VA = "0x185DE7CB0")]
	public void GBBGDIJCNCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DF41D0", Offset = "0x5DF2DD0", VA = "0x185DF41D0")]
	private void PCAAMBKMJPP(Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2330", Offset = "0x5DF0F30", VA = "0x185DF2330")]
	[Obsolete]
	private Vector3 IOGOIOLPNLB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF13D0", Offset = "0x5DEFFD0", VA = "0x185DF13D0")]
	private void DLCJAMEDIPF(float ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3730", Offset = "0x5DF2330", VA = "0x185DF3730")]
	private Vector3 KMFOEIELKBE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0BA0", Offset = "0x5DEF7A0", VA = "0x185DF0BA0")]
	private Quaternion APGNIGHBLCM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DF25E0", Offset = "0x5DF11E0", VA = "0x185DF25E0")]
	internal (float, Vector3) JCGOMGHJDJL(Rigidbody EAHCOALHCOK)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class LCLBAJICBKO
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F22C00", Offset = "0x6F21800", VA = "0x186F22C00")]
	public static HKFPBDAEJKC FNDOCLELGBE(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class POKNHPFLFJJ : KOJGKBEMDEB, PMKPCPNEKNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public MLAAMHAMNCK KNKDIKABJHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F24B10", Offset = "0x6F23710", VA = "0x186F24B10", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F26AC0", Offset = "0x6F256C0", VA = "0x186F26AC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public JHEBHKGMPAF CPNBMHEFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F26110", Offset = "0x6F24D10", VA = "0x186F26110", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F27B50", Offset = "0x6F26750", VA = "0x186F27B50", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F24790", Offset = "0x6F23390", VA = "0x186F24790", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F25590", Offset = "0x6F24190", VA = "0x186F25590", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 LAOGHFMMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F26650", Offset = "0x6F25250", VA = "0x186F26650", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F26680", Offset = "0x6F25280", VA = "0x186F26680", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 KKAHELGKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F27C50", Offset = "0x6F26850", VA = "0x186F27C50", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F27CE0", Offset = "0x6F268E0", VA = "0x186F27CE0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public Vector3 EHDBLKFCOBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F27CB0", Offset = "0x6F268B0", VA = "0x186F27CB0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x6F24760", Offset = "0x6F23360", VA = "0x186F24760", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float FNKBHNMOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6F24C40", Offset = "0x6F23840", VA = "0x186F24C40", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6F266B0", Offset = "0x6F252B0", VA = "0x186F266B0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool MFEJBDEHODC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F25F00", Offset = "0x6F24B00", VA = "0x186F25F00", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private NAAOIBJHADK KAAEMNKNEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x22F8D50", Offset = "0x22F7950", VA = "0x1822F8D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool NDLKKFGHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7FE0", Offset = "0x5DE6BE0", VA = "0x185DE7FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F23C80", Offset = "0x6F22880", VA = "0x186F23C80")]
	public POKNHPFLFJJ(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F269C0", Offset = "0x6F255C0", VA = "0x186F269C0", Slot = "20")]
	public void IDHOAFOCKIJ(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6F25420", Offset = "0x6F24020", VA = "0x186F25420", Slot = "31")]
	public void COEBAFIHDGK(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F25520", Offset = "0x6F24120", VA = "0x186F25520", Slot = "19")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F25CD0", Offset = "0x6F248D0", VA = "0x186F25CD0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6F272A0", Offset = "0x6F25EA0", VA = "0x186F272A0", Slot = "28")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6F25B60", Offset = "0x6F24760", VA = "0x186F25B60", Slot = "36")]
	public Vector3 DPKJENDBDFP(Vector3 PLGCJGPJLOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6F24ED0", Offset = "0x6F23AD0", VA = "0x186F24ED0", Slot = "35")]
	public Vector3 CCMNDDEHNJA(Vector3 LLBIDODECBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6F25520", Offset = "0x6F24120", VA = "0x186F25520", Slot = "27")]
	public void FMGKABPAPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6F26820", Offset = "0x6F25420", VA = "0x186F26820", Slot = "25")]
	public void GOPHGLEKHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6F26860", Offset = "0x6F25460", VA = "0x186F26860", Slot = "24")]
	public void HNPHPPHGNGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6F24D30", Offset = "0x6F23930", VA = "0x186F24D30", Slot = "34")]
	public void CBIKPKMEKKL(Vector3 EOJNKDCENDM, Vector3 POIEPCCNOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6F27A30", Offset = "0x6F26630", VA = "0x186F27A30", Slot = "33")]
	public void OPGFEEFJGGG(Vector3 NNFLIAGNPGB, Vector3 AFFJGLIILJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6F25FF0", Offset = "0x6F24BF0", VA = "0x186F25FF0", Slot = "32")]
	public void FEMBKDIAAAP(Vector3 KDJKJGOIBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6F26BC0", Offset = "0x6F257C0", VA = "0x186F26BC0", Slot = "22")]
	public void JMFNPJJKFKO(FPHOFMJLENJ LFJLPJDIOGB, Vector3 AFOFGLGBJEI, float CAMLBJONKHG, float KDMJGHCHEJE = 8f, float GLBOFKBMMGD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6F26F50", Offset = "0x6F25B50", VA = "0x186F26F50", Slot = "21")]
	public void KMGAIKJKMEL(GJCDONMOIJG JCFGFBHJEMJ, Vector3 ODOOOABGMIH, float AFFFNJJAEBG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6F27480", Offset = "0x6F26080", VA = "0x186F27480", Slot = "23")]
	[Obsolete]
	public void LPOCGBNGDFJ(GJCDONMOIJG JCFGFBHJEMJ, Vector3 KDPJNNPKKHC, float LMLCPPONLID = 7f, float EOPJPNPJINM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6F27A90", Offset = "0x6F26690", VA = "0x186F27A90", Slot = "30")]
	public Vector3 PBIHOCFKCJD(Vector3 PPJHGOCBPCK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6F271A0", Offset = "0x6F25DA0", VA = "0x186F271A0", Slot = "29")]
	public Vector3 KMNEHIALFMG(Vector3 JDNINLGNNJF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6F25E10", Offset = "0x6F24A10", VA = "0x186F25E10", Slot = "26")]
	public void ELHHONDCCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6F266B0", Offset = "0x6F252B0", VA = "0x186F266B0")]
	private void GNAGAOKDICE(float ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6F268A0", Offset = "0x6F254A0", VA = "0x186F268A0")]
	private void IAKIEGDKDAI(Vector3 ODOOOABGMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6F277D0", Offset = "0x6F263D0", VA = "0x186F277D0")]
	private Vector3 OPBFFCOBIJD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6F26240", Offset = "0x6F24E40", VA = "0x186F26240")]
	private void FIALGKEPIBL(Vector3 LLBIDODECBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6F247F0", Offset = "0x6F233F0", VA = "0x186F247F0")]
	private Vector3 BFPGMPGOAEH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6F25020", Offset = "0x6F23C20", VA = "0x186F25020")]
	private void CFGBDHECLAN(Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x6F27770", Offset = "0x6F26370", VA = "0x186F27770")]
	private void NIMJBANPDME(Vector3 PPJHGOCBPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6F27420", Offset = "0x6F26020", VA = "0x186F27420")]
	private void LILMCAPDKLP(Vector3 JDNINLGNNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6F25650", Offset = "0x6F24250", VA = "0x186F25650")]
	private void DENHFDHOOKI(string ADDFCMAPIBH, Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6F24A50", Offset = "0x6F23650", VA = "0x186F24A50")]
	private void BMJDIGOKBOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class KNDDJMAMFNE : KOJGKBEMDEB, NLOPKOPLBOH
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public float LPAEGLFGFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x5E03AB0", Offset = "0x5E026B0", VA = "0x185E03AB0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x5E038E0", Offset = "0x5E024E0", VA = "0x185E038E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public float GHCFGOKLHJN
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5E03E30", Offset = "0x5E02A30", VA = "0x185E03E30", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x5E03C60", Offset = "0x5E02860", VA = "0x185E03C60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE32E0", Offset = "0x5DE1EE0", VA = "0x185DE32E0")]
	public KNDDJMAMFNE(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x5E03F10", Offset = "0x5E02B10", VA = "0x185E03F10", Slot = "8")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x5E03B90", Offset = "0x5E02790", VA = "0x185E03B90", Slot = "9")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[UnityEngine.Scripting.Preserve]
public sealed class NBEFNPDKNIA : FAFKHKPFEKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly NBEFNPDKNIA EABDDJEADPB;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyEx AHAAINDKLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public GameObject ICCGPNIDAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public Transform ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7F0240", Offset = "0x7EEE40", VA = "0x1807F0240", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public IEnumerable<object> OEJGBFHANNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x84D780", Offset = "0x84C380", VA = "0x18084D780", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x83EB00", Offset = "0x83D700", VA = "0x18083EB00", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x83EB20", Offset = "0x83D720", VA = "0x18083EB20", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IReadOnlyList<FAFKHKPFEKI> GBEAOJFNDCF
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x83EB10", Offset = "0x83D710", VA = "0x18083EB10", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public FAFKHKPFEKI ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x836090", Offset = "0x834C90", VA = "0x180836090", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1201930", Offset = "0x1200530", VA = "0x181201930", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool PJBJHNNIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1595230", Offset = "0x1593E30", VA = "0x181595230", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool EMKHKPNFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xE987C0", Offset = "0xE973C0", VA = "0x180E987C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public MLAAMHAMNCK KNKDIKABJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x836080", Offset = "0x834C80", VA = "0x180836080", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x89D530", Offset = "0x89C130", VA = "0x18089D530", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public JHEBHKGMPAF CPNBMHEFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x84D800", Offset = "0x84C400", VA = "0x18084D800", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x89D540", Offset = "0x89C140", VA = "0x18089D540", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public float FNKBHNMOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x17E7040", Offset = "0x17E5C40", VA = "0x1817E7040", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x1071940", Offset = "0x1070540", VA = "0x181071940", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Vector3 LAOGHFMMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x4001640", Offset = "0x4000240", VA = "0x184001640", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x4002330", Offset = "0x4000F30", VA = "0x184002330", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Vector3 EHDBLKFCOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x26C7C90", Offset = "0x26C6890", VA = "0x1826C7C90", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x26C6150", Offset = "0x26C4D50", VA = "0x1826C6150", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x26C7CB0", Offset = "0x26C68B0", VA = "0x1826C7CB0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x26C3FE0", Offset = "0x26C2BE0", VA = "0x1826C3FE0", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 KKAHELGKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x15E52F0", Offset = "0x15E3EF0", VA = "0x1815E52F0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool JKOBEIFFLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xECEB50", Offset = "0xECD750", VA = "0x180ECEB50", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public bool DGHDMLPPOFE
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xF42C80", Offset = "0xF41880", VA = "0x180F42C80", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool FFNCCFIMIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xF42C70", Offset = "0xF41870", VA = "0x180F42C70", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool MFEJBDEHODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xCEA2E0", Offset = "0xCE8EE0", VA = "0x180CEA2E0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Vector3 FHHFPANDEGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x1DB51A0", Offset = "0x1DB3DA0", VA = "0x181DB51A0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Vector3 LKILFMEFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B8A0", Offset = "0x1F1A4A0", VA = "0x181F1B8A0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 KENEHBJMFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x15E52F0", Offset = "0x15E3EF0", VA = "0x1815E52F0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 KEILFIFPNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1D818D0", Offset = "0x1D804D0", VA = "0x181D818D0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public float JNGHFGELAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x293A2E0", Offset = "0x2938EE0", VA = "0x18293A2E0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public float GPAHEKCCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x1621EE0", Offset = "0x1620AE0", VA = "0x181621EE0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Vector3 GJOKEJOLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x15E52F0", Offset = "0x15E3EF0", VA = "0x1815E52F0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public Quaternion NJHBIADEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x17A5D50", Offset = "0x17A4950", VA = "0x1817A5D50", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public float LPAEGLFGFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x1621EE0", Offset = "0x1620AE0", VA = "0x181621EE0", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public float GHCFGOKLHJN
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1621EE0", Offset = "0x1620AE0", VA = "0x181621EE0", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool MMEFLHGHBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool OJHHJBOIBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public GALCBGLBFAD EFPMFLGMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "51")]
		get
		{
			return default(GALCBGLBFAD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x3283540", Offset = "0x3282140", VA = "0x183283540", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public Transform EMNGBEEEHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x9EF3D0", Offset = "0x9EDFD0", VA = "0x1809EF3D0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Transform BJCECNAIBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x9735B0", Offset = "0x9721B0", VA = "0x1809735B0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 COBBPPAHGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x15E52F0", Offset = "0x15E3EF0", VA = "0x1815E52F0", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public float MONKEGPBKLP
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x1621EE0", Offset = "0x1620AE0", VA = "0x181621EE0", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public float KCCKNLIMMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x1621EE0", Offset = "0x1620AE0", VA = "0x181621EE0", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public Quaternion AEOIOMHPLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x1B2F500", Offset = "0x1B2E100", VA = "0x181B2F500", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 FLNDEGFPBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x15E52F0", Offset = "0x15E3EF0", VA = "0x1815E52F0", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Quaternion OCOFEOLGBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1B2F500", Offset = "0x1B2E100", VA = "0x181B2F500", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public RigidbodyConstraints DDHNPMJICJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x83E700", Offset = "0x83D300", VA = "0x18083E700", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool LGMFNHPALFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public CollisionDetectionMode HDBNMHILGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x83E700", Offset = "0x83D300", VA = "0x18083E700", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool HPAPGLPAOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x18CF670", Offset = "0x18CE270", VA = "0x1818CF670", Slot = "74")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool BDJDMEHPAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "133")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event PENLMJLNPDM ABGONPKEDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "80")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "81")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event PENLMJLNPDM PCAPCNOAOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event IJIIOKHNDCH IAIGIJMEMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "84")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "85")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event PENLMJLNPDM OCCHAGGOINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "87")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "88")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event PENLMJLNPDM DDALOGBJKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event PENLMJLNPDM OKAHFOGBNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "112")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "113")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<GBAHALBBEFO, GBAHALBBEFO> KKOALOMMEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "116")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "117")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event PENLMJLNPDM IBIEOIEHHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "118")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "119")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event PENLMJLNPDM MOMDHFIOGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "124")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "125")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "44")]
	public void CLDNGGKFBHC((Quaternion rot, Vector3 moments) DCEIBGLEFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "75")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "76")]
	public void MBMKEKPNCDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "77")]
	public void FABPKIFEFOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "78")]
	public void EFAMGCMKBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "79")]
	public void AHMPHJEIING()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "86")]
	public void JPDJPFJGJJB(FAFKHKPFEKI ECNGHFJBIJL, bool NGKEIPOGCJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "89")]
	public void GFCCENMEHND(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "90")]
	public void GEOOCCNGKCP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x15E52F0", Offset = "0x15E3EF0", VA = "0x1815E52F0", Slot = "91")]
	public Vector3 DPKJENDBDFP(Vector3 PLGCJGPJLOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x15E52F0", Offset = "0x15E3EF0", VA = "0x1815E52F0", Slot = "92")]
	public Vector3 CCMNDDEHNJA(Vector3 LLBIDODECBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "93")]
	public void FMGKABPAPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "94")]
	public void GOPHGLEKHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "95")]
	public void HNPHPPHGNGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "96")]
	public void CBIKPKMEKKL(Vector3 EOJNKDCENDM, Vector3 POIEPCCNOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "97")]
	public void OPGFEEFJGGG(Vector3 NNFLIAGNPGB, Vector3 AFFJGLIILJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "98")]
	public void FEMBKDIAAAP(Vector3 KDJKJGOIBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "99")]
	public void JMFNPJJKFKO(FPHOFMJLENJ LFJLPJDIOGB, Vector3 AFOFGLGBJEI, float CAMLBJONKHG, float KDMJGHCHEJE = 8f, float GLBOFKBMMGD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "100")]
	public void KMGAIKJKMEL(GJCDONMOIJG JCFGFBHJEMJ, Vector3 ODOOOABGMIH, float AFFFNJJAEBG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "101")]
	public void LPOCGBNGDFJ(GJCDONMOIJG JCFGFBHJEMJ, Vector3 KDPJNNPKKHC, float LMLCPPONLID = 7f, float EOPJPNPJINM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x15E52F0", Offset = "0x15E3EF0", VA = "0x1815E52F0", Slot = "102")]
	public Vector3 PBIHOCFKCJD(Vector3 ECNGHFJBIJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x15E52F0", Offset = "0x15E3EF0", VA = "0x1815E52F0", Slot = "103")]
	public Vector3 KMNEHIALFMG(Vector3 ECNGHFJBIJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "104")]
	public void ELHHONDCCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "105")]
	public void BDODKLGLFCI(FAFKHKPFEKI OFKMLDLKKGB, object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "106")]
	public void AKFOKBBCEAC(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "109")]
	public void FGMANKLHEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "110")]
	public void CFOFFHECGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "111")]
	public void MOGOAIJKGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "114")]
	public bool AHEGLGAEPAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "115")]
	public void JDFOHMHOLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x83E700", Offset = "0x83D300", VA = "0x18083E700", Slot = "120")]
	public IDisposable FFBAOBHCCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "121")]
	public void JMLHFLEGLGJ(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "122")]
	public void OEHMBAJJPJP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "123")]
	public void LAIGJEGAOJL(object FLDJLPKNKKO, bool GCGPLALBKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "126")]
	public void IKECCJJDGDP(Vector3 CBIOILEAJIH, Quaternion ECGDKPNOHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "127")]
	public void FPNKIBCOPLG(Vector3 ELPFDBFBPJP, Quaternion PDEDDIGJHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0", Slot = "128")]
	public bool IOBHGAHMENP(float OMOAPNBJLBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "129")]
	public void ENPJOCBLDHN(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "130")]
	public void FFBLKOEHHKE(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "131")]
	public void GHIPEPNLOHM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "132")]
	public void IFJCMMGNPMM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "134")]
	public void FCCAHBEJJFC(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "135")]
	public void CELICFPJCIO(Vector3 HCKNDFMIDDI, Vector3 NABPHMOHNDG, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "136")]
	public void HLFGLHDAPJI(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "137")]
	public void MCJILHDCBCN(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F23D10", Offset = "0x6F22910", VA = "0x186F23D10", Slot = "138")]
	public bool HPEHJMJKMBE(Vector3 AGOGLFBBBLL, out RaycastHit MLBCOPMGEFF, float LHLJEFHGAPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "139")]
	public void GKCLCHKBIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public NBEFNPDKNIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class CJNJPFNNDIB : KOJGKBEMDEB, NABDDFAEAAL
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 FHHFPANDEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2FF0", Offset = "0x5DE1BF0", VA = "0x185DE2FF0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 LKILFMEFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2DE0", Offset = "0x5DE19E0", VA = "0x185DE2DE0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE26E0", Offset = "0x5DE12E0", VA = "0x185DE26E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private FAFKHKPFEKI BJGALBBDAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x5DE27C0", Offset = "0x5DE13C0", VA = "0x185DE27C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE32E0", Offset = "0x5DE1EE0", VA = "0x185DE32E0")]
	public CJNJPFNNDIB(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3020", Offset = "0x5DE1C20", VA = "0x185DE3020", Slot = "6")]
	public void MEILECPHJFN(FAFKHKPFEKI ONIJEEBBCHK, object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE31B0", Offset = "0x5DE1DB0", VA = "0x185DE31B0")]
	private void MEILECPHJFN(KDCPJKLPAPB ONIJEEBBCHK, object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2920", Offset = "0x5DE1520", VA = "0x185DE2920", Slot = "7")]
	public void FKLLDNMELNG(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2A10", Offset = "0x5DE1610", VA = "0x185DE2A10")]
	private Vector3 GAHKIOJBOFK()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class ACDBDOKBINI
{
	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEF80", Offset = "0x5DDDB80", VA = "0x185DDEF80")]
	public static CJNJPFNNDIB KNOKCGBBPPB(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class BLKBJADJNCL : KOJGKBEMDEB, CMANNCNAEEB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly MFFHLJHLBIG KKGGJGMLOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CIIGAJMMHGL JNGPCOLGDDJ;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private Transform ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF2E0", Offset = "0x5DDDEE0", VA = "0x185DDF2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public ICDDKLLCIME BKGMLNFKFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE13E0", Offset = "0x5DDFFE0", VA = "0x185DE13E0")]
		get
		{
			return default(ICDDKLLCIME);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5DE07B0", Offset = "0x5DDF3B0", VA = "0x185DE07B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0770", Offset = "0x5DDF370", VA = "0x185DE0770", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5DE10F0", Offset = "0x5DDFCF0", VA = "0x185DE10F0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public ICDDKLLCIME BNEFPIEPBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF310", Offset = "0x5DDDF10", VA = "0x185DDF310")]
		get
		{
			return default(ICDDKLLCIME);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5DE1240", Offset = "0x5DDFE40", VA = "0x185DE1240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public FAFKHKPFEKI ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5DE1200", Offset = "0x5DDFE00", VA = "0x185DE1200", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public IReadOnlyList<FAFKHKPFEKI> GBEAOJFNDCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x84D800", Offset = "0x84C400", VA = "0x18084D800", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event PENLMJLNPDM ABGONPKEDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5DE08B0", Offset = "0x5DDF4B0", VA = "0x185DE08B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0500", Offset = "0x5DDF100", VA = "0x185DE0500", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event PENLMJLNPDM PCAPCNOAOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x5DE1340", Offset = "0x5DDFF40", VA = "0x185DE1340", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF410", Offset = "0x5DDE010", VA = "0x185DDF410", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event IJIIOKHNDCH IAIGIJMEMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF240", Offset = "0x5DDDE40", VA = "0x185DDF240", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFC80", Offset = "0x5DDE880", VA = "0x185DDFC80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event Action ILMHHPLDHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF710", Offset = "0x5DDE310", VA = "0x185DDF710", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0370", Offset = "0x5DDEF70", VA = "0x185DE0370", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event Action LKKCMMNHMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFB40", Offset = "0x5DDE740", VA = "0x185DDFB40", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5DE05A0", Offset = "0x5DDF1A0", VA = "0x185DE05A0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event Action<FAFKHKPFEKI> HMDKKBAFIJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFD20", Offset = "0x5DDE920", VA = "0x185DDFD20", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE02D0", Offset = "0x5DDEED0", VA = "0x185DE02D0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event Action<FAFKHKPFEKI> IDGBMMFDPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5DE1160", Offset = "0x5DDFD60", VA = "0x185DE1160", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0190", Offset = "0x5DDED90", VA = "0x185DE0190", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event Action MBIPKGCCLDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF4B0", Offset = "0x5DDE0B0", VA = "0x185DDF4B0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0230", Offset = "0x5DDEE30", VA = "0x185DE0230", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event Action<FAFKHKPFEKI> ICECBJMMMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFDC0", Offset = "0x5DDE9C0", VA = "0x185DDFDC0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFBE0", Offset = "0x5DDE7E0", VA = "0x185DDFBE0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1570", Offset = "0x5DE0170", VA = "0x185DE1570")]
	public BLKBJADJNCL(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF970", Offset = "0x5DDE570", VA = "0x185DDF970", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0410", Offset = "0x5DDF010", VA = "0x185DE0410", Slot = "26")]
	public void JPDJPFJGJJB(FAFKHKPFEKI PBNMPICADBG, bool NGKEIPOGCJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0490", Offset = "0x5DDF090", VA = "0x185DE0490")]
	private void JPDJPFJGJJB(KDCPJKLPAPB PBNMPICADBG, bool NGKEIPOGCJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0950", Offset = "0x5DDF550", VA = "0x185DE0950")]
	private void NEFIMCAACMN(KDCPJKLPAPB PBNMPICADBG, bool NGKEIPOGCJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF550", Offset = "0x5DDE150", VA = "0x185DDF550")]
	private void DCAAKEBPGMM(KDCPJKLPAPB DBHJCCLCMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF7B0", Offset = "0x5DDE3B0", VA = "0x185DDF7B0")]
	private void DIAJFCLGHNB(KDCPJKLPAPB DBHJCCLCMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFFE0", Offset = "0x5DDEBE0", VA = "0x185DDFFE0")]
	private void HCHGKENDMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFF10", Offset = "0x5DDEB10", VA = "0x185DDFF10")]
	private void GOLOLHKODGD(KDCPJKLPAPB DBHJCCLCMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFE60", Offset = "0x5DDEA60", VA = "0x185DDFE60")]
	private void GLBGGDLJEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF110", Offset = "0x5DDDD10", VA = "0x185DDF110")]
	private void ANNGLPCKBKA(KDCPJKLPAPB LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0640", Offset = "0x5DDF240", VA = "0x185DE0640")]
	private void MEAEKDMOCMC(KDCPJKLPAPB LPIBPEGGEEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class DLFACDICEOB
{
	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4350", Offset = "0x5DE2F50", VA = "0x185DE4350")]
	public static BLKBJADJNCL AEAGMJDNIIJ(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class KDCPJKLPAPB : KLJOINJFJMA, MKCCBALLBBE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	internal ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal BCOGGGBMMOK MMMOAIMMECP;

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD600", Offset = "0x5DFC200", VA = "0x185DFD600")]
	public KDCPJKLPAPB(GameObject ALBKEDBKENG, RigidbodyEx GNMMOMPJING, MCALNKPINNM GAICNONPFPG, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCB40", Offset = "0x5DFB740", VA = "0x185DFCB40", Slot = "143")]
	protected override void DIGCCAPCOMD(MCALNKPINNM GAICNONPFPG, CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCF50", Offset = "0x5DFBB50", VA = "0x185DFCF50", Slot = "144")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCDC0", Offset = "0x5DFB9C0", VA = "0x185DFCDC0", Slot = "147")]
	public void DLNOJJNGPDA(BLMHMCOGNAC OFDNJFOOJOA, BLMHMCOGNAC MEKEHDPAILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCE90", Offset = "0x5DFBA90", VA = "0x185DFCE90", Slot = "148")]
	public void DOHGMJJCAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD1A0", Offset = "0x5DFBDA0", VA = "0x185DFD1A0", Slot = "149")]
	public void KEFOHPEBEHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD0E0", Offset = "0x5DFBCE0", VA = "0x185DFD0E0", Slot = "150")]
	public void FBMPOHOFPGJ(bool AOHFCNFADMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD260", Offset = "0x5DFBE60", VA = "0x185DFD260", Slot = "151")]
	public bool KNJFBMCNMDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD140", Offset = "0x5DFBD40", VA = "0x185DFD140", Slot = "152")]
	public void HBKADGJMAIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "146")]
	protected override void KIDECLKFDOJ(RigidbodyEx HDCPFIKNJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD3C0", Offset = "0x5DFBFC0", VA = "0x185DFD3C0")]
	private void PIEJLKKGEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "145")]
	public override void AHMPHJEIING()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class OKLLDFPMLJO
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F24710", Offset = "0x6F23310", VA = "0x186F24710")]
	public static KLJOINJFJMA KLOGBFNGGAN(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class IOIEEDEPIEL : KOJGKBEMDEB, PPMGPBJOPHG
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private const string IHEGBFLFHMK = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool CJIJDGNKPGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5DF71E0", Offset = "0x5DF5DE0", VA = "0x185DF71E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public LHPAGGDFKDF NMBGGBCMFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DF71D0", Offset = "0x5DF5DD0", VA = "0x185DF71D0", Slot = "5")]
		get
		{
			return default(LHPAGGDFKDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private LHPAGGDFKDF JCMMMGIPMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5DF77A0", Offset = "0x5DF63A0", VA = "0x185DF77A0")]
		get
		{
			return default(LHPAGGDFKDF);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5DF7900", Offset = "0x5DF6500", VA = "0x185DF7900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7B00", Offset = "0x5DF6700", VA = "0x185DF7B00")]
	public IOIEEDEPIEL(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF73C0", Offset = "0x5DF5FC0", VA = "0x185DF73C0", Slot = "6")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7700", Offset = "0x5DF6300", VA = "0x185DF7700")]
	private bool IFMJEIBBLIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DF70D0", Offset = "0x5DF5CD0", VA = "0x185DF70D0", Slot = "7")]
	public void AFGGHBKIECF(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF72C0", Offset = "0x5DF5EC0", VA = "0x185DF72C0", Slot = "8")]
	public void CPELJIHJKHN(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DF79F0", Offset = "0x5DF65F0", VA = "0x185DF79F0", Slot = "11")]
	public void ODHNAICIIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7610", Offset = "0x5DF6210", VA = "0x185DF7610")]
	private void FAEHMCHMGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7480", Offset = "0x5DF6080", VA = "0x185DF7480")]
	private void EAFCDCFDCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DF78C0", Offset = "0x5DF64C0", VA = "0x185DF78C0", Slot = "10")]
	public void KOPPABHPADM(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7880", Offset = "0x5DF6480", VA = "0x185DF7880", Slot = "9")]
	public void KFIPOFHIKLA(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class HMBOBLBMEHN : KOJGKBEMDEB, NAAOIBJHADK
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4870", Offset = "0x5DE3470", VA = "0x185DE4870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF130", Offset = "0x5DEDD30", VA = "0x185DEF130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA170", Offset = "0x5DE8D70", VA = "0x185DEA170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x5DF5500", Offset = "0x5DF4100", VA = "0x185DF5500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE32E0", Offset = "0x5DE1EE0", VA = "0x185DE32E0")]
	public HMBOBLBMEHN(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4BE0", Offset = "0x5DF37E0", VA = "0x185DF4BE0", Slot = "4")]
	public void FCCAHBEJJFC(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4F90", Offset = "0x5DF3B90", VA = "0x185DF4F90")]
	private void KEJNLHKMPMG(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5DF46C0", Offset = "0x5DF32C0", VA = "0x185DF46C0", Slot = "5")]
	public void CELICFPJCIO(Vector3 HCKNDFMIDDI, Vector3 NABPHMOHNDG, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4D40", Offset = "0x5DF3940", VA = "0x185DF4D40", Slot = "6")]
	public void HLFGLHDAPJI(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4960", Offset = "0x5DF3560", VA = "0x185DF4960")]
	private void DPDFEMBNECH(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5280", Offset = "0x5DF3E80", VA = "0x185DF5280", Slot = "7")]
	public void MCJILHDCBCN(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4EA0", Offset = "0x5DF3AA0", VA = "0x185DF4EA0")]
	private void JGIMFEIAGIB(string DKIECHCHJFL, UnityEngine.Object JFDMKPDIBDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class IPNDMHNEJCC : KOJGKBEMDEB, BEOHALDGFAH
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private const string AGPJDLGHNPA = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5DF8B50", Offset = "0x5DF7750", VA = "0x185DF8B50", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5DF83F0", Offset = "0x5DF6FF0", VA = "0x185DF83F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA170", Offset = "0x5DE8D70", VA = "0x185DEA170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool BDJDMEHPAFC
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x5DF87A0", Offset = "0x5DF73A0", VA = "0x185DF87A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8C30", Offset = "0x5DF7830", VA = "0x185DF8C30")]
	public IPNDMHNEJCC(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8340", Offset = "0x5DF6F40", VA = "0x185DF8340", Slot = "5")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF84E0", Offset = "0x5DF70E0", VA = "0x185DF84E0", Slot = "7")]
	public void GHIPEPNLOHM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8880", Offset = "0x5DF7480", VA = "0x185DF8880", Slot = "8")]
	public void IFJCMMGNPMM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7E30", Offset = "0x5DF6A30", VA = "0x185DF7E30", Slot = "9")]
	public void AKBFBEIOBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5DF80E0", Offset = "0x5DF6CE0", VA = "0x185DF80E0", Slot = "10")]
	public void DBPBPENLGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8980", Offset = "0x5DF7580", VA = "0x185DF8980", Slot = "11")]
	public void IGMALIJEELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "12")]
	public void NGEMPCCFGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5DF85E0", Offset = "0x5DF71E0", VA = "0x185DF85E0")]
	private void HMNJIJBDGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7C70", Offset = "0x5DF6870", VA = "0x185DF7C70")]
	private void AGKDIBAHEFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class JDLMFJEEHBM : KOJGKBEMDEB, JAFLIGJBBGN
{
	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAAB0", Offset = "0x5DF96B0", VA = "0x185DFAAB0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public IEnumerable<object> LDNIHOLIOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB2D0", Offset = "0x5DF9ED0", VA = "0x185DFB2D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private bool MEGCMGIMNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAC30", Offset = "0x5DF9830", VA = "0x185DFAC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event PENLMJLNPDM IBIEOIEHHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAB90", Offset = "0x5DF9790", VA = "0x185DFAB90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAFB0", Offset = "0x5DF9BB0", VA = "0x185DFAFB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE32E0", Offset = "0x5DE1EE0", VA = "0x185DE32E0")]
	public JDLMFJEEHBM(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAD10", Offset = "0x5DF9910", VA = "0x185DFAD10", Slot = "12")]
	public IDisposable FFBAOBHCCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB050", Offset = "0x5DF9C50", VA = "0x185DFB050", Slot = "9")]
	public void JMLHFLEGLGJ(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB3B0", Offset = "0x5DF9FB0", VA = "0x185DFB3B0", Slot = "10")]
	public void OEHMBAJJPJP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB060", Offset = "0x5DF9C60", VA = "0x185DFB060", Slot = "11")]
	public void LAIGJEGAOJL(object FLDJLPKNKKO, bool GCGPLALBKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB160", Offset = "0x5DF9D60", VA = "0x185DFB160", Slot = "13")]
	public void LBEBFFILMKK(Rigidbody GGGGHNNPHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5DFADD0", Offset = "0x5DF99D0", VA = "0x185DFADD0", Slot = "14")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7CB0", Offset = "0x5DE68B0", VA = "0x185DE7CB0", Slot = "6")]
	public void BAHNFOENCGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class MIIAKIBJCOD : KOJGKBEMDEB, GADMMIHBFNL
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private CollisionDetectionMode CDFCPOFNDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x6F23810", Offset = "0x6F22410", VA = "0x186F23810")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x6F23B80", Offset = "0x6F22780", VA = "0x186F23B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x6F239C0", Offset = "0x6F225C0", VA = "0x186F239C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public CollisionDetectionMode HDBNMHILGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x6F235A0", Offset = "0x6F221A0", VA = "0x186F235A0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x6F23980", Offset = "0x6F22580", VA = "0x186F23980", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x6F23C80", Offset = "0x6F22880", VA = "0x186F23C80")]
	public MIIAKIBJCOD(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x6F23650", Offset = "0x6F22250", VA = "0x186F23650", Slot = "6")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6F23910", Offset = "0x6F22510", VA = "0x186F23910", Slot = "9")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6F23970", Offset = "0x6F22570", VA = "0x186F23970", Slot = "7")]
	public void MEHHJKMGHLL(bool ICBDCKBKPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6F23900", Offset = "0x6F22500", VA = "0x186F23900", Slot = "8")]
	public void KJEBGEAKFJB(bool ICBDCKBKPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6F23710", Offset = "0x6F22310", VA = "0x186F23710", Slot = "10")]
	public bool HPEHJMJKMBE(Vector3 AGOGLFBBBLL, out RaycastHit MLBCOPMGEFF, float LHLJEFHGAPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x6F239E0", Offset = "0x6F225E0", VA = "0x186F239E0")]
	private void OIKJOBJMGEJ(bool ICBDCKBKPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public sealed class CIIGAJMMHGL : IReadOnlyList<FAFKHKPFEKI>, IEnumerable<FAFKHKPFEKI>, IEnumerable, IReadOnlyCollection<FAFKHKPFEKI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly BCOGGGBMMOK LOJMOJPJAMH;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2460", Offset = "0x5DE1060", VA = "0x185DE2460", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public FAFKHKPFEKI OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2530", Offset = "0x5DE1130", VA = "0x185DE2530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2410", Offset = "0x5DE1010", VA = "0x185DE2410")]
	public CIIGAJMMHGL(ICDDKLLCIME CMPMKFMJCNO, BCOGGGBMMOK LOJMOJPJAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2280", Offset = "0x5DE0E80", VA = "0x185DE2280", Slot = "6")]
	public IEnumerator<FAFKHKPFEKI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2280", Offset = "0x5DE0E80", VA = "0x185DE2280", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2270", Offset = "0x5DE0E70", VA = "0x185DE2270")]
	[CompilerGenerated]
	private FAFKHKPFEKI DLENALJEHIK(int OCIFJAIBHIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class BPFBGMILMIM : BAEMKDJGAPE
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5DE20A0", Offset = "0x5DE0CA0", VA = "0x185DE20A0", Slot = "4")]
	public CMANNCNAEEB PIKJDPLOAGA(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1A50", Offset = "0x5DE0650", VA = "0x185DE1A50", Slot = "5")]
	public PMKPCPNEKNE FFCOEIPKDAE(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1FA0", Offset = "0x5DE0BA0", VA = "0x185DE1FA0", Slot = "6")]
	public NABDDFAEAAL NGOPFPIKHBH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1BB0", Offset = "0x5DE07B0", VA = "0x185DE1BB0", Slot = "7")]
	public NLOPKOPLBOH HKNKHNJFNMP(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2040", Offset = "0x5DE0C40", VA = "0x185DE2040", Slot = "8")]
	public LDMPFENPFIH PBCPKPGDLMH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1E50", Offset = "0x5DE0A50", VA = "0x185DE1E50", Slot = "9")]
	public HMNJOAIBFBB NAJFMIHAFGH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1DB0", Offset = "0x5DE09B0", VA = "0x185DE1DB0", Slot = "10")]
	public JAFLIGJBBGN MNKPOCKEPKN(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1D10", Offset = "0x5DE0910", VA = "0x185DE1D10", Slot = "11")]
	public NAAOIBJHADK MLMCAEOHELL(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1B50", Offset = "0x5DE0750", VA = "0x185DE1B50", Slot = "12")]
	public GADMMIHBFNL HINFDFADGBH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1AB0", Offset = "0x5DE06B0", VA = "0x185DE1AB0", Slot = "13")]
	public DPIKHFGILLN GBLBFLKHODN(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1920", Offset = "0x5DE0520", VA = "0x185DE1920")]
	public BEOHALDGFAH NFAMOAOKLDA(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1C50", Offset = "0x5DE0850", VA = "0x185DE1C50")]
	public ECIMMNKGOEA NBKLAOJGNOL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1790", Offset = "0x5DE0390", VA = "0x185DE1790")]
	public PPMGPBJOPHG BPIIGMDCEFM(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5DE19E0", Offset = "0x5DE05E0", VA = "0x185DE19E0")]
	public IPMJOKMPDFD KJLFHAFEJJI(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1720", Offset = "0x5DE0320", VA = "0x185DE1720")]
	public JEDJEILBNNF BGFDJPKHNDP(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1EF0", Offset = "0x5DE0AF0", VA = "0x185DE1EF0", Slot = "19")]
	public FAFKHKPFEKI NGAPLOHIPKM(RigidbodyEx LPIBPEGGEEE, CJKCMEGMCAM PHBHEFAPHDL, MCALNKPINNM GAICNONPFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public BPFBGMILMIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1920", Offset = "0x5DE0520", VA = "0x185DE1920", Slot = "14")]
	private BEOHALDGFAH CILCPMEGAMD(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1C50", Offset = "0x5DE0850", VA = "0x185DE1C50", Slot = "15")]
	private ECIMMNKGOEA IEEHCBAAKNL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1790", Offset = "0x5DE0390", VA = "0x185DE1790", Slot = "16")]
	private PPMGPBJOPHG GCPHHAPAMJL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE19E0", Offset = "0x5DE05E0", VA = "0x185DE19E0", Slot = "17")]
	private IPMJOKMPDFD EEBLDPEJCHG(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1720", Offset = "0x5DE0320", VA = "0x185DE1720", Slot = "18")]
	private JEDJEILBNNF DCPHMIBPDJD(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class EPEIMKKLODK : KOJGKBEMDEB, LDMPFENPFIH
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public const int GCEPGFMHOEN = 10;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public const float EKMOPOCMBDC = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public const float OJFALJCIKDC = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public const float GPDIGMFENGK = 5f;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4870", Offset = "0x5DE3470", VA = "0x185DE4870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private bool KNEIAPCMOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7EA0", Offset = "0x5DE6AA0", VA = "0x185DE7EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private bool NDLKKFGHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7FE0", Offset = "0x5DE6BE0", VA = "0x185DE7FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8390", Offset = "0x5DE6F90", VA = "0x185DE8390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8570", Offset = "0x5DE7170", VA = "0x185DE8570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool OMKKLIAJFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7A80", Offset = "0x5DE6680", VA = "0x185DE7A80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7D00", Offset = "0x5DE6900", VA = "0x185DE7D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool EHJADDANEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7840", Offset = "0x5DE6440", VA = "0x185DE7840")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8000", Offset = "0x5DE6C00", VA = "0x185DE8000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private int PDBNGLJAJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x5DE83F0", Offset = "0x5DE6FF0", VA = "0x185DE83F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x5DE80F0", Offset = "0x5DE6CF0", VA = "0x185DE80F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event PENLMJLNPDM OKAHFOGBNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7F40", Offset = "0x5DE6B40", VA = "0x185DE7F40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE84D0", Offset = "0x5DE70D0", VA = "0x185DE84D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5DE85D0", Offset = "0x5DE71D0", VA = "0x185DE85D0")]
	public EPEIMKKLODK(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7920", Offset = "0x5DE6520", VA = "0x185DE7920", Slot = "6")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7CF0", Offset = "0x5DE68F0", VA = "0x185DE7CF0", Slot = "8")]
	public void FPMMBIEPONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7620", Offset = "0x5DE6220", VA = "0x185DE7620", Slot = "7")]
	public bool AHEGLGAEPAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE79D0", Offset = "0x5DE65D0", VA = "0x185DE79D0", Slot = "9")]
	public void EFAMGCMKBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7CB0", Offset = "0x5DE68B0", VA = "0x185DE7CB0", Slot = "12")]
	public void FBMPOHOFPGJ(bool AOHFCNFADMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7DF0", Offset = "0x5DE69F0", VA = "0x185DE7DF0", Slot = "11")]
	public void JDFOHMHOLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "10")]
	public void CDIMIBACCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5DE81E0", Offset = "0x5DE6DE0", VA = "0x185DE81E0")]
	private bool MLLBIMFCMED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7B60", Offset = "0x5DE6760", VA = "0x185DE7B60")]
	private void ENCDJLHHGBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[KKBPAALNMJN(typeof(BAEMKDJGAPE), new string[] { })]
public class GGNKIBJJDJM : BAEMKDJGAPE, BOGFHHLHMCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly BAEMKDJGAPE DLGEBMNAJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly BAEMKDJGAPE MOELMKDPIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private EDINIDCGNHI CONCNLCHMHI;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private BAEMKDJGAPE BJHGCJGNEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBCD0", Offset = "0x5DEA8D0", VA = "0x185DEBCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBC80", Offset = "0x5DEA880", VA = "0x185DEBC80", Slot = "20")]
	public void InitReferences(JHMGDIDCDLA EHNANGKLKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC140", Offset = "0x5DEAD40", VA = "0x185DEC140", Slot = "4")]
	public CMANNCNAEEB PIKJDPLOAGA(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB950", Offset = "0x5DEA550", VA = "0x185DEB950", Slot = "5")]
	public PMKPCPNEKNE FFCOEIPKDAE(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC000", Offset = "0x5DEAC00", VA = "0x185DEC000", Slot = "6")]
	public NABDDFAEAAL NGOPFPIKHBH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBB30", Offset = "0x5DEA730", VA = "0x185DEBB30", Slot = "7")]
	public NLOPKOPLBOH HKNKHNJFNMP(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC0A0", Offset = "0x5DEACA0", VA = "0x185DEC0A0", Slot = "8")]
	public LDMPFENPFIH PBCPKPGDLMH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBE70", Offset = "0x5DEAA70", VA = "0x185DEBE70", Slot = "9")]
	public HMNJOAIBFBB NAJFMIHAFGH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBDD0", Offset = "0x5DEA9D0", VA = "0x185DEBDD0", Slot = "10")]
	public JAFLIGJBBGN MNKPOCKEPKN(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBD30", Offset = "0x5DEA930", VA = "0x185DEBD30", Slot = "11")]
	public NAAOIBJHADK MLMCAEOHELL(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBA90", Offset = "0x5DEA690", VA = "0x185DEBA90", Slot = "12")]
	public GADMMIHBFNL HINFDFADGBH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB9F0", Offset = "0x5DEA5F0", VA = "0x185DEB9F0", Slot = "13")]
	public DPIKHFGILLN GBLBFLKHODN(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB7F0", Offset = "0x5DEA3F0", VA = "0x185DEB7F0")]
	public BEOHALDGFAH NFAMOAOKLDA(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBBD0", Offset = "0x5DEA7D0", VA = "0x185DEBBD0")]
	public ECIMMNKGOEA NBKLAOJGNOL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB740", Offset = "0x5DEA340", VA = "0x185DEB740")]
	public PPMGPBJOPHG BPIIGMDCEFM(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB8A0", Offset = "0x5DEA4A0", VA = "0x185DEB8A0")]
	public IPMJOKMPDFD KJLFHAFEJJI(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB690", Offset = "0x5DEA290", VA = "0x185DEB690")]
	public JEDJEILBNNF BGFDJPKHNDP(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBF10", Offset = "0x5DEAB10", VA = "0x185DEBF10", Slot = "19")]
	public FAFKHKPFEKI NGAPLOHIPKM(RigidbodyEx LPIBPEGGEEE, CJKCMEGMCAM PHBHEFAPHDL, MCALNKPINNM GAICNONPFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC1E0", Offset = "0x5DEADE0", VA = "0x185DEC1E0")]
	public GGNKIBJJDJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB7F0", Offset = "0x5DEA3F0", VA = "0x185DEB7F0", Slot = "14")]
	private BEOHALDGFAH CILCPMEGAMD(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBBD0", Offset = "0x5DEA7D0", VA = "0x185DEBBD0", Slot = "15")]
	private ECIMMNKGOEA IEEHCBAAKNL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB740", Offset = "0x5DEA340", VA = "0x185DEB740", Slot = "16")]
	private PPMGPBJOPHG GCPHHAPAMJL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB8A0", Offset = "0x5DEA4A0", VA = "0x185DEB8A0", Slot = "17")]
	private IPMJOKMPDFD EEBLDPEJCHG(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB690", Offset = "0x5DEA290", VA = "0x185DEB690", Slot = "18")]
	private JEDJEILBNNF DCPHMIBPDJD(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class IOHMOCIBMMC : KOJGKBEMDEB, DPIKHFGILLN
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool MMEFLHGHBCL
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6D10", Offset = "0x5DF5910", VA = "0x185DF6D10", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6EF0", Offset = "0x5DF5AF0", VA = "0x185DF6EF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE32E0", Offset = "0x5DE1EE0", VA = "0x185DE32E0")]
	public IOHMOCIBMMC(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6DF0", Offset = "0x5DF59F0", VA = "0x185DF6DF0", Slot = "6")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6CA0", Offset = "0x5DF58A0", VA = "0x185DF6CA0", Slot = "7")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class KOJGKBEMDEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	protected readonly KDCPJKLPAPB LPIBPEGGEEE;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	protected BCOGGGBMMOK HHCOKBJGCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xECAF00", Offset = "0xEC9B00", VA = "0x180ECAF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	protected ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x5E040E0", Offset = "0x5E02CE0", VA = "0x185E040E0")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5DE32E0", Offset = "0x5DE1EE0", VA = "0x185DE32E0")]
	public KOJGKBEMDEB(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5E04110", Offset = "0x5E02D10", VA = "0x185E04110")]
	protected FAFKHKPFEKI LLOHDMJCGLC(ICDDKLLCIME CMPMKFMJCNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class DFLPABEEADD : KOJGKBEMDEB, ECIMMNKGOEA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private PhotonView LMFEDHHHGIA;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool PJBJHNNIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3B70", Offset = "0x5DE2770", VA = "0x185DE3B70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool EMKHKPNFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x5DE41A0", Offset = "0x5DE2DA0", VA = "0x185DE41A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event PENLMJLNPDM OCCHAGGOINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x5DE38E0", Offset = "0x5DE24E0", VA = "0x185DE38E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x5DE36F0", Offset = "0x5DE22F0", VA = "0x185DE36F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5DE42C0", Offset = "0x5DE2EC0", VA = "0x185DE42C0")]
	public DFLPABEEADD(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3790", Offset = "0x5DE2390", VA = "0x185DE3790", Slot = "8")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3980", Offset = "0x5DE2580", VA = "0x185DE3980", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3B90", Offset = "0x5DE2790", VA = "0x185DE3B90", Slot = "9")]
	public void MHOLELPPCJG(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3360", Offset = "0x5DE1F60", VA = "0x185DE3360", Slot = "10")]
	public void CBAHCGLEALK(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3F70", Offset = "0x5DE2B70", VA = "0x185DE3F70")]
	private void OCNBLLJGDPJ(PhotonView LPJELBBDFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3560", Offset = "0x5DE2160", VA = "0x185DE3560")]
	private void CGHHCENOAHG(RigidbodyEx OABGENDIMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3D90", Offset = "0x5DE2990", VA = "0x185DE3D90")]
	private void NOEJOIHHMCI(PhotonView OFCHPIIFGAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class ACDPBABDOOC
{
	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEFF0", Offset = "0x5DDDBF0", VA = "0x185DDEFF0")]
	public static DFLPABEEADD GIGLDHHKGEJ(this KLJOINJFJMA NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class KAOMNGDOMJI : KOJGKBEMDEB, JEDJEILBNNF
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool LGMFNHPALFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC640", Offset = "0x5DFB240", VA = "0x185DFC640", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC470", Offset = "0x5DFB070", VA = "0x185DFC470", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool KGKNONHGELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC820", Offset = "0x5DFB420", VA = "0x185DFC820", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC280", Offset = "0x5DFAE80", VA = "0x185DFC280")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public RigidbodyConstraints DDHNPMJICJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC560", Offset = "0x5DFB160", VA = "0x185DFC560", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC080", Offset = "0x5DFAC80", VA = "0x185DFC080", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC900", Offset = "0x5DFB500", VA = "0x185DFC900")]
	public KAOMNGDOMJI(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC720", Offset = "0x5DFB320", VA = "0x185DFC720", Slot = "9")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC370", Offset = "0x5DFAF70", VA = "0x185DFC370", Slot = "10")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class IHNLBNPODAC : KOJGKBEMDEB, HMNJOAIBFBB, IDisposable, ADEMDHOELEN
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public GALCBGLBFAD BLDMCPBPHOA
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6250", Offset = "0x5DF4E50", VA = "0x185DF6250")]
		get
		{
			return default(GALCBGLBFAD);
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6160", Offset = "0x5DF4D60", VA = "0x185DF6160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public GALCBGLBFAD EFPMFLGMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6330", Offset = "0x5DF4F30", VA = "0x185DF6330", Slot = "6")]
		get
		{
			return default(GALCBGLBFAD);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6160", Offset = "0x5DF4D60", VA = "0x185DF6160", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private Transform NPPOFEKCBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x83E700", Offset = "0x83D300", VA = "0x18083E700", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event Action<GBAHALBBEFO, GBAHALBBEFO> KKOALOMMEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6550", Offset = "0x5DF5150", VA = "0x185DF6550", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6650", Offset = "0x5DF5250", VA = "0x185DF6650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE32E0", Offset = "0x5DE1EE0", VA = "0x185DE32E0")]
	public IHNLBNPODAC(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5DF65F0", Offset = "0x5DF51F0", VA = "0x185DF65F0", Slot = "11")]
	public void OnChangedDistanceBand(GBAHALBBEFO OFDNJFOOJOA, GBAHALBBEFO MEKEHDPAILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "12")]
	public void OnChangedVisibility(bool HGLINGKMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "8")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class FNHMKJDAMJI : HMNJOAIBFBB, IDisposable, ADEMDHOELEN
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const int NJDDKOGBCIF = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private GALCBGLBFAD IECEOEJJEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private FDLOOMEBFFN IBJOKKJDEIN;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public GALCBGLBFAD EFPMFLGMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA740", Offset = "0x5DE9340", VA = "0x185DEA740", Slot = "6")]
		get
		{
			return default(GALCBGLBFAD);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA610", Offset = "0x5DE9210", VA = "0x185DEA610", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private Transform NPPOFEKCBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA5A0", Offset = "0x5DE91A0", VA = "0x185DEA5A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<GBAHALBBEFO, GBAHALBBEFO> KKOALOMMEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA880", Offset = "0x5DE9480", VA = "0x185DEA880", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA920", Offset = "0x5DE9520", VA = "0x185DEA920", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA9C0", Offset = "0x5DE95C0", VA = "0x185DEA9C0")]
	public FNHMKJDAMJI(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA2C0", Offset = "0x5DE8EC0", VA = "0x185DEA2C0", Slot = "8")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA5C0", Offset = "0x5DE91C0", VA = "0x185DEA5C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA6E0", Offset = "0x5DE92E0", VA = "0x185DEA6E0", Slot = "11")]
	private void NBIJGNJENHD(GBAHALBBEFO FIIFHFDPPBC, GBAHALBBEFO DPHBMFBPJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "12")]
	private void MOOHKHCCGPF(bool HGLINGKMEAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class JMKOACEABDB : KPHACHCIEDK, ECIMMNKGOEA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private PhotonView LMFEDHHHGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool OCPCNLKJKBI;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public PhotonView PKJBIFAFLLI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool PJBJHNNIMMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3B70", Offset = "0x5DE2770", VA = "0x185DE3B70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool EMKHKPNFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC90", Offset = "0x9AA890", VA = "0x1809ABC90", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event PENLMJLNPDM OCCHAGGOINB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB8A0", Offset = "0x5DFA4A0", VA = "0x185DFB8A0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB6B0", Offset = "0x5DFA2B0", VA = "0x185DFB6B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBFE0", Offset = "0x5DFABE0", VA = "0x185DFBFE0")]
	public JMKOACEABDB(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB750", Offset = "0x5DFA350", VA = "0x185DFB750", Slot = "9")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB940", Offset = "0x5DFA540", VA = "0x185DFB940", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBA50", Offset = "0x5DFA650", VA = "0x185DFBA50", Slot = "10")]
	public void MHOLELPPCJG(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB3C0", Offset = "0x5DF9FC0", VA = "0x185DFB3C0", Slot = "11")]
	public void CBAHCGLEALK(FAFKHKPFEKI ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBE60", Offset = "0x5DFAA60", VA = "0x185DFBE60")]
	private void OCNBLLJGDPJ(PhotonView LPJELBBDFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB540", Offset = "0x5DFA140", VA = "0x185DFB540")]
	private void CGHHCENOAHG(RigidbodyEx OABGENDIMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBBD0", Offset = "0x5DFA7D0", VA = "0x185DFBBD0")]
	private void NOEJOIHHMCI(PhotonView OFCHPIIFGAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class NBDOLCFHAOA
{
	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F23C90", Offset = "0x6F22890", VA = "0x186F23C90")]
	public static KPHACHCIEDK GIGLDHHKGEJ(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class FMNGCPCGIIG : BEOHALDGFAH
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const string AGPJDLGHNPA = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly FMDOKKBAPOM PGIBOCIPOPP;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x8370D0", Offset = "0x835CD0", VA = "0x1808370D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA170", Offset = "0x5DE8D70", VA = "0x185DEA170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool BDJDMEHPAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x1821FC0", Offset = "0x1820BC0", VA = "0x181821FC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA1D0", Offset = "0x5DE8DD0", VA = "0x185DEA1D0")]
	public FMNGCPCGIIG(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9890", Offset = "0x5DE8490", VA = "0x185DE9890", Slot = "5")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9940", Offset = "0x5DE8540", VA = "0x185DE9940", Slot = "7")]
	public void GHIPEPNLOHM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9B20", Offset = "0x5DE8720", VA = "0x185DE9B20", Slot = "8")]
	public void IFJCMMGNPMM(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9330", Offset = "0x5DE7F30", VA = "0x185DE9330", Slot = "9")]
	public void AKBFBEIOBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9690", Offset = "0x5DE8290", VA = "0x185DE9690", Slot = "10")]
	public void DBPBPENLGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9B50", Offset = "0x5DE8750", VA = "0x185DE9B50", Slot = "11")]
	public void IGMALIJEELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9CD0", Offset = "0x5DE88D0", VA = "0x185DE9CD0", Slot = "12")]
	public void NGEMPCCFGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9970", Offset = "0x5DE8570", VA = "0x185DE9970")]
	private void HMNJIJBDGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9180", Offset = "0x5DE7D80", VA = "0x185DE9180")]
	private void AGKDIBAHEFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class MBFLNFMHMGO : JEDJEILBNNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private RigidbodyConstraints IJJBJLEMONJ;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool LGMFNHPALFN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x8A9720", Offset = "0x8A8320", VA = "0x1808A9720", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x8A9730", Offset = "0x8A8330", VA = "0x1808A9730", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool KGKNONHGELK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x288DAC0", Offset = "0x288C6C0", VA = "0x18288DAC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x288DAD0", Offset = "0x288C6D0", VA = "0x18288DAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public RigidbodyConstraints DDHNPMJICJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x837B50", Offset = "0x836750", VA = "0x180837B50", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F23400", Offset = "0x6F22000", VA = "0x186F23400", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F23540", Offset = "0x6F22140", VA = "0x186F23540")]
	public MBFLNFMHMGO(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F23510", Offset = "0x6F22110", VA = "0x186F23510", Slot = "9")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F234E0", Offset = "0x6F220E0", VA = "0x186F234E0", Slot = "10")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class GPKCGBKLHHG : NAAOIBJHADK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4870", Offset = "0x5DE3470", VA = "0x185DE4870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF130", Offset = "0x5DEDD30", VA = "0x185DEF130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA170", Offset = "0x5DE8D70", VA = "0x185DEA170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DEFE60", Offset = "0x5DEEA60", VA = "0x185DEFE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE49F0", Offset = "0x5DE35F0", VA = "0x185DE49F0")]
	public GPKCGBKLHHG(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF6A0", Offset = "0x5DEE2A0", VA = "0x185DEF6A0", Slot = "4")]
	public void FCCAHBEJJFC(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF960", Offset = "0x5DEE560", VA = "0x185DEF960")]
	private void KEJNLHKMPMG(Vector3 HCKNDFMIDDI, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF180", Offset = "0x5DEDD80", VA = "0x185DEF180", Slot = "5")]
	public void CELICFPJCIO(Vector3 HCKNDFMIDDI, Vector3 NABPHMOHNDG, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF800", Offset = "0x5DEE400", VA = "0x185DEF800", Slot = "6")]
	public void HLFGLHDAPJI(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF420", Offset = "0x5DEE020", VA = "0x185DEF420")]
	private void DPDFEMBNECH(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFBE0", Offset = "0x5DEE7E0", VA = "0x185DEFBE0", Slot = "7")]
	public void MCJILHDCBCN(Vector3 BAEKHIGMPHB, ForceMode MKILKFIGPHM = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class GAEJIJLABLF : JKKHCKIOLME, NABDDFAEAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly global::LBECJFLPAEM<FAFKHKPFEKI> LEGMNJLANCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private bool JBMILOFAAHA;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public global::LBECJFLPAEM<FAFKHKPFEKI> GDKFBFNMGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public Vector3 FHHFPANDEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB500", Offset = "0x5DEA100", VA = "0x185DEB500", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public Vector3 LKILFMEFLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DEAF90", Offset = "0x5DE9B90", VA = "0x185DEAF90", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x5DEAA50", Offset = "0x5DE9650", VA = "0x185DEAA50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public FAFKHKPFEKI BJGALBBDAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x5DEAB30", Offset = "0x5DE9730", VA = "0x185DEAB30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB5A0", Offset = "0x5DEA1A0", VA = "0x185DEB5A0")]
	public GAEJIJLABLF(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB530", Offset = "0x5DEA130", VA = "0x185DEB530", Slot = "8")]
	public void MEILECPHJFN(FAFKHKPFEKI ONIJEEBBCHK, object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DEABE0", Offset = "0x5DE97E0", VA = "0x185DEABE0", Slot = "9")]
	public void FKLLDNMELNG(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAC40", Offset = "0x5DE9840", VA = "0x185DEAC40")]
	private Vector3 GAHKIOJBOFK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB160", Offset = "0x5DE9D60", VA = "0x185DEB160")]
	private void GFONNFMBNPE(FAFKHKPFEKI FDEMMCBDHNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class FIODCALIDME
{
	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE90C0", Offset = "0x5DE7CC0", VA = "0x185DE90C0")]
	public static JKKHCKIOLME KNOKCGBBPPB(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class EKNABMFIJOH : BEMPIPEGMEK, IPMJOKMPDFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly OverridableVector3 MGLJKNHHDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly OverridableVector3 NOIKJKFLDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private float LMACMILFAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private float CHODJKFAPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Vector3 ADFEMPOHHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Vector3? INPCFJLMNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Quaternion? MIIDBCDLHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool DDNEEDHAJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool NFGHJPEOKIC;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Vector3 KENEHBJMFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x49F8FA0", Offset = "0x49F7BA0", VA = "0x1849F8FA0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE53A0", Offset = "0x5DE3FA0", VA = "0x185DE53A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public Vector3 KEILFIFPNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x5DE70A0", Offset = "0x5DE5CA0", VA = "0x185DE70A0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public float JNGHFGELAMD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xA6B110", Offset = "0xA69D10", VA = "0x180A6B110", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4E70", Offset = "0x5DE3A70", VA = "0x185DE4E70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public float GPAHEKCCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x165BD70", Offset = "0x165A970", VA = "0x18165BD70", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x5DE52F0", Offset = "0x5DE3EF0", VA = "0x185DE52F0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 GJOKEJOLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x5DE73B0", Offset = "0x5DE5FB0", VA = "0x185DE73B0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Quaternion NJHBIADEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5D70", Offset = "0x5DE4970", VA = "0x185DE5D70", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEE20", Offset = "0x5DDDA20", VA = "0x185DDEE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event PENLMJLNPDM NGIDLMLHHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x5DE71A0", Offset = "0x5DE5DA0", VA = "0x185DE71A0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5610", Offset = "0x5DE4210", VA = "0x185DE5610", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7520", Offset = "0x5DE6120", VA = "0x185DE7520")]
	public EKNABMFIJOH(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5450", Offset = "0x5DE4050", VA = "0x185DE5450", Slot = "17")]
	public void FGMANKLHEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4F90", Offset = "0x5DE3B90", VA = "0x185DE4F90", Slot = "16")]
	public void CFOFFHECGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6FC0", Offset = "0x5DE5BC0", VA = "0x185DE6FC0", Slot = "19")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5B70", Offset = "0x5DE4770", VA = "0x185DE5B70", Slot = "20")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7240", Offset = "0x5DE5E40", VA = "0x185DE7240", Slot = "18")]
	public void MOGOAIJKGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE56B0", Offset = "0x5DE42B0", VA = "0x185DE56B0", Slot = "21")]
	public void GKCLCHKBIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE53A0", Offset = "0x5DE3FA0", VA = "0x185DE53A0")]
	private void NEADJADLFKA(Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5EE0", Offset = "0x5DE4AE0", VA = "0x185DE5EE0")]
	[Obsolete]
	private Vector3 IOGOIOLPNLB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4E70", Offset = "0x5DE3A70", VA = "0x185DE4E70")]
	private void NLAGPGMNKKK(float ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5DE52F0", Offset = "0x5DE3EF0", VA = "0x185DE52F0")]
	private void DLCJAMEDIPF(float ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6E50", Offset = "0x5DE5A50", VA = "0x185DE6E50")]
	private Vector3 KMFOEIELKBE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x5DE50B0", Offset = "0x5DE3CB0", VA = "0x185DE50B0", Slot = "15")]
	public void CLDNGGKFBHC((Quaternion rot, Vector3 moments) DCEIBGLEFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4D00", Offset = "0x5DE3900", VA = "0x185DE4D00")]
	private Quaternion APGNIGHBLCM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6D70", Offset = "0x5DE5970", VA = "0x185DE6D70")]
	public void JCGOMGHJDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5FE0", Offset = "0x5DE4BE0", VA = "0x185DE5FE0", Slot = "4")]
	public (float, Vector3) JCGOMGHJDJL(Rigidbody EAHCOALHCOK)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class OFJMDLAOMKF
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x6F240C0", Offset = "0x6F22CC0", VA = "0x186F240C0")]
	public static BEMPIPEGMEK FNDOCLELGBE(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface JKKHCKIOLME : NABDDFAEAAL
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	global::LBECJFLPAEM<FAFKHKPFEKI> GDKFBFNMGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	FAFKHKPFEKI BJGALBBDAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class GONPMOGJPOK : PMKPCPNEKNE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly FMDOKKBAPOM CEMMLJNHMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private float FMKENJDMKIE;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public MLAAMHAMNCK KNKDIKABJHB
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0240", Offset = "0x7EEE40", VA = "0x1807F0240", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x7F0400", Offset = "0x7EF000", VA = "0x1807F0400", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public JHEBHKGMPAF CPNBMHEFJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x84D780", Offset = "0x84C380", VA = "0x18084D780", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x8A4420", Offset = "0x8A3020", VA = "0x1808A4420", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public Vector3 JKJFFMLEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC2B0", Offset = "0x5DEAEB0", VA = "0x185DEC2B0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x5DECD30", Offset = "0x5DEB930", VA = "0x185DECD30", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public Vector3 LAOGHFMMNGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x5DED5F0", Offset = "0x5DEC1F0", VA = "0x185DED5F0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x5DED6E0", Offset = "0x5DEC2E0", VA = "0x185DED6E0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Vector3 KKAHELGKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x5DEED70", Offset = "0x5DED970", VA = "0x185DEED70", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x5DEEF90", Offset = "0x5DEDB90", VA = "0x185DEEF90", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public Vector3 EHDBLKFCOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x5DEEEA0", Offset = "0x5DEDAA0", VA = "0x185DEEEA0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC280", Offset = "0x5DEAE80", VA = "0x185DEC280", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public float FNKBHNMOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x14D3EC0", Offset = "0x14D2AC0", VA = "0x1814D3EC0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x5DED710", Offset = "0x5DEC310", VA = "0x185DED710", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool MFEJBDEHODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x150EB90", Offset = "0x150D790", VA = "0x18150EB90", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private NAAOIBJHADK KAAEMNKNEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x22F8D50", Offset = "0x22F7950", VA = "0x1822F8D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private bool NDLKKFGHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7FE0", Offset = "0x5DE6BE0", VA = "0x185DE7FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF050", Offset = "0x5DEDC50", VA = "0x185DEF050")]
	public GONPMOGJPOK(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x5DECCC0", Offset = "0x5DEB8C0", VA = "0x185DECCC0", Slot = "19")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x5DECFD0", Offset = "0x5DEBBD0", VA = "0x185DECFD0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE170", Offset = "0x5DECD70", VA = "0x185DEE170", Slot = "28")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x150E1E0", Offset = "0x150CDE0", VA = "0x18150E1E0", Slot = "20")]
	public void IDHOAFOCKIJ(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x150E1C0", Offset = "0x150CDC0", VA = "0x18150E1C0", Slot = "31")]
	public void COEBAFIHDGK(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5DECDF0", Offset = "0x5DEB9F0", VA = "0x185DECDF0", Slot = "36")]
	public Vector3 DPKJENDBDFP(Vector3 PLGCJGPJLOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC7D0", Offset = "0x5DEB3D0", VA = "0x185DEC7D0", Slot = "35")]
	public Vector3 CCMNDDEHNJA(Vector3 LLBIDODECBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x5DECCC0", Offset = "0x5DEB8C0", VA = "0x185DECCC0", Slot = "27")]
	public void FMGKABPAPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x5DED830", Offset = "0x5DEC430", VA = "0x185DED830", Slot = "25")]
	public void GOPHGLEKHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x5DED870", Offset = "0x5DEC470", VA = "0x185DED870", Slot = "24")]
	public void HNPHPPHGNGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC590", Offset = "0x5DEB190", VA = "0x185DEC590", Slot = "34")]
	public void CBIKPKMEKKL(Vector3 EOJNKDCENDM, Vector3 POIEPCCNOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEC50", Offset = "0x5DED850", VA = "0x185DEEC50", Slot = "33")]
	public void OPGFEEFJGGG(Vector3 NNFLIAGNPGB, Vector3 AFFJGLIILJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x5DED190", Offset = "0x5DEBD90", VA = "0x185DED190", Slot = "32")]
	public void FEMBKDIAAAP(Vector3 KDJKJGOIBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x5DED9F0", Offset = "0x5DEC5F0", VA = "0x185DED9F0", Slot = "22")]
	public void JMFNPJJKFKO(FPHOFMJLENJ LFJLPJDIOGB, Vector3 AFOFGLGBJEI, float CAMLBJONKHG, float KDMJGHCHEJE = 8f, float GLBOFKBMMGD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDE40", Offset = "0x5DECA40", VA = "0x185DEDE40", Slot = "21")]
	public void KMGAIKJKMEL(GJCDONMOIJG JCFGFBHJEMJ, Vector3 ODOOOABGMIH, float AFFFNJJAEBG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE2A0", Offset = "0x5DECEA0", VA = "0x185DEE2A0", Slot = "23")]
	[Obsolete]
	public void LPOCGBNGDFJ(GJCDONMOIJG JCFGFBHJEMJ, Vector3 KDPJNNPKKHC, float LMLCPPONLID = 7f, float EOPJPNPJINM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEECB0", Offset = "0x5DED8B0", VA = "0x185DEECB0", Slot = "30")]
	public Vector3 PBIHOCFKCJD(Vector3 PPJHGOCBPCK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE070", Offset = "0x5DECC70", VA = "0x185DEE070", Slot = "29")]
	public Vector3 KMNEHIALFMG(Vector3 JDNINLGNNJF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x5DED030", Offset = "0x5DEBC30", VA = "0x185DED030", Slot = "26")]
	public void ELHHONDCCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x5DED710", Offset = "0x5DEC310", VA = "0x185DED710")]
	private void GNAGAOKDICE(float ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x5DED8B0", Offset = "0x5DEC4B0", VA = "0x185DED8B0")]
	private void IAKIEGDKDAI(Vector3 ODOOOABGMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEB60", Offset = "0x5DED760", VA = "0x185DEEB60")]
	private Vector3 OPBFFCOBIJD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x5DED2D0", Offset = "0x5DEBED0", VA = "0x185DED2D0")]
	private void FIALGKEPIBL(Vector3 LLBIDODECBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC3D0", Offset = "0x5DEAFD0", VA = "0x185DEC3D0")]
	private Vector3 BFPGMPGOAEH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC990", Offset = "0x5DEB590", VA = "0x185DEC990")]
	private void CFGBDHECLAN(Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE560", Offset = "0x5DED160", VA = "0x185DEE560")]
	private void NIMJBANPDME(Vector3 LLBIDODECBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC4D0", Offset = "0x5DEB0D0", VA = "0x185DEC4D0")]
	private void BMJDIGOKBOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class OFOMKPIAOLH : JAFLIGJBBGN
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private const string FBDLHJHPBGO = "IsKinematicByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly FMDOKKBAPOM IADMGPBMKLA;

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool NOPLLAJBAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6F24140", Offset = "0x6F22D40", VA = "0x186F24140", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public IEnumerable<object> LDNIHOLIOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6F24650", Offset = "0x6F23250", VA = "0x186F24650", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event PENLMJLNPDM IBIEOIEHHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x6F24220", Offset = "0x6F22E20", VA = "0x186F24220", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6F24350", Offset = "0x6F22F50", VA = "0x186F24350", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x6F24680", Offset = "0x6F23280", VA = "0x186F24680")]
	public OFOMKPIAOLH(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x6F242C0", Offset = "0x6F22EC0", VA = "0x186F242C0", Slot = "12")]
	public IDisposable FFBAOBHCCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x6F243F0", Offset = "0x6F22FF0", VA = "0x186F243F0", Slot = "9")]
	public void JMLHFLEGLGJ(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x6F24670", Offset = "0x6F23270", VA = "0x186F24670", Slot = "10")]
	public void OEHMBAJJPJP(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x6F244D0", Offset = "0x6F230D0", VA = "0x186F244D0", Slot = "11")]
	public void LAIGJEGAOJL(object FLDJLPKNKKO, bool GCGPLALBKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x6F241E0", Offset = "0x6F22DE0", VA = "0x186F241E0", Slot = "6")]
	public void BAHNFOENCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x6F245D0", Offset = "0x6F231D0", VA = "0x186F245D0", Slot = "13")]
	public void LBEBFFILMKK(Rigidbody GGGGHNNPHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x6F24320", Offset = "0x6F22F20", VA = "0x186F24320", Slot = "14")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class ECMNAPBLLLL : GADMMIHBFNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private CollisionDetectionMode IFFHGGHFFEP;

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4870", Offset = "0x5DE3470", VA = "0x185DE4870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public CollisionDetectionMode HDBNMHILGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x5DE43C0", Offset = "0x5DE2FC0", VA = "0x185DE43C0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4800", Offset = "0x5DE3400", VA = "0x185DE4800", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x5DE49F0", Offset = "0x5DE35F0", VA = "0x185DE49F0")]
	public ECMNAPBLLLL(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x5DE44D0", Offset = "0x5DE30D0", VA = "0x185DE44D0", Slot = "6")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4770", Offset = "0x5DE3370", VA = "0x185DE4770", Slot = "9")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x5DE47F0", Offset = "0x5DE33F0", VA = "0x185DE47F0", Slot = "7")]
	public void MEHHJKMGHLL(bool ICBDCKBKPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4760", Offset = "0x5DE3360", VA = "0x185DE4760", Slot = "8")]
	public void KJEBGEAKFJB(bool ICBDCKBKPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE45F0", Offset = "0x5DE31F0", VA = "0x185DE45F0", Slot = "10")]
	public bool HPEHJMJKMBE(Vector3 AGOGLFBBBLL, out RaycastHit MLBCOPMGEFF, float LHLJEFHGAPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE48C0", Offset = "0x5DE34C0", VA = "0x185DE48C0")]
	private void OIKJOBJMGEJ(bool ICBDCKBKPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class ICBBFNNPNOB : BAEMKDJGAPE
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6070", Offset = "0x5DF4C70", VA = "0x185DF6070", Slot = "4")]
	public CMANNCNAEEB PIKJDPLOAGA(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5890", Offset = "0x5DF4490", VA = "0x185DF5890", Slot = "5")]
	public PMKPCPNEKNE FFCOEIPKDAE(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5E70", Offset = "0x5DF4A70", VA = "0x185DF5E70", Slot = "6")]
	public NABDDFAEAAL NGOPFPIKHBH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5AB0", Offset = "0x5DF46B0", VA = "0x185DF5AB0", Slot = "7")]
	public NLOPKOPLBOH HKNKHNJFNMP(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5F90", Offset = "0x5DF4B90", VA = "0x185DF5F90", Slot = "8")]
	public LDMPFENPFIH PBCPKPGDLMH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5D00", Offset = "0x5DF4900", VA = "0x185DF5D00", Slot = "9")]
	public HMNJOAIBFBB NAJFMIHAFGH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5CA0", Offset = "0x5DF48A0", VA = "0x185DF5CA0", Slot = "10")]
	public JAFLIGJBBGN MNKPOCKEPKN(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5BF0", Offset = "0x5DF47F0", VA = "0x185DF5BF0", Slot = "11")]
	public NAAOIBJHADK MLMCAEOHELL(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5A00", Offset = "0x5DF4600", VA = "0x185DF5A00", Slot = "12")]
	public GADMMIHBFNL HINFDFADGBH(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x5DF59A0", Offset = "0x5DF45A0", VA = "0x185DF59A0", Slot = "13")]
	public DPIKHFGILLN GBLBFLKHODN(FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5640", Offset = "0x5DF4240", VA = "0x185DF5640")]
	public BEOHALDGFAH NFAMOAOKLDA(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5B20", Offset = "0x5DF4720", VA = "0x185DF5B20")]
	public ECIMMNKGOEA NBKLAOJGNOL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5DF55D0", Offset = "0x5DF41D0", VA = "0x185DF55D0")]
	public PPMGPBJOPHG BPIIGMDCEFM(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5760", Offset = "0x5DF4360", VA = "0x185DF5760")]
	public IPMJOKMPDFD KJLFHAFEJJI(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5560", Offset = "0x5DF4160", VA = "0x185DF5560")]
	public JEDJEILBNNF BGFDJPKHNDP(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5DC0", Offset = "0x5DF49C0", VA = "0x185DF5DC0", Slot = "19")]
	public FAFKHKPFEKI NGAPLOHIPKM(RigidbodyEx LPIBPEGGEEE, CJKCMEGMCAM PHBHEFAPHDL, MCALNKPINNM GAICNONPFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public ICBBFNNPNOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5640", Offset = "0x5DF4240", VA = "0x185DF5640", Slot = "14")]
	private BEOHALDGFAH CILCPMEGAMD(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5B20", Offset = "0x5DF4720", VA = "0x185DF5B20", Slot = "15")]
	private ECIMMNKGOEA IEEHCBAAKNL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5DF55D0", Offset = "0x5DF41D0", VA = "0x185DF55D0", Slot = "16")]
	private PPMGPBJOPHG GCPHHAPAMJL(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5760", Offset = "0x5DF4360", VA = "0x185DF5760", Slot = "17")]
	private IPMJOKMPDFD EEBLDPEJCHG(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5560", Offset = "0x5DF4160", VA = "0x185DF5560", Slot = "18")]
	private JEDJEILBNNF DCPHMIBPDJD(FAFKHKPFEKI NHIFGJKHMEC, in CJKCMEGMCAM PHBHEFAPHDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class JDLLBKNLAFL : BFCDMDFHJNM, CMANNCNAEEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly FAFKHKPFEKI LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly List<FAFKHKPFEKI> KKIGAGCNEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private FAFKHKPFEKI PMBNHDHBMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private FAFKHKPFEKI ONIJEEBBCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Transform KLNKNPJHMEE;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private Transform ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x5DF8E00", Offset = "0x5DF7A00", VA = "0x185DF8E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x84D790", Offset = "0x84C390", VA = "0x18084D790", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA8A0", Offset = "0x5DF94A0", VA = "0x185DFA8A0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public FAFKHKPFEKI ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x84D810", Offset = "0x84C410", VA = "0x18084D810", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public IReadOnlyList<FAFKHKPFEKI> GBEAOJFNDCF
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x84D800", Offset = "0x84C400", VA = "0x18084D800", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event PENLMJLNPDM ABGONPKEDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA800", Offset = "0x5DF9400", VA = "0x185DFA800", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA620", Offset = "0x5DF9220", VA = "0x185DFA620", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event PENLMJLNPDM PCAPCNOAOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA950", Offset = "0x5DF9550", VA = "0x185DFA950", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5DF8E60", Offset = "0x5DF7A60", VA = "0x185DF8E60", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event IJIIOKHNDCH IAIGIJMEMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x5DF8D60", Offset = "0x5DF7960", VA = "0x185DF8D60", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x5DF97E0", Offset = "0x5DF83E0", VA = "0x185DF97E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action ILMHHPLDHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5DF91F0", Offset = "0x5DF7DF0", VA = "0x185DF91F0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x5DF9FE0", Offset = "0x5DF8BE0", VA = "0x185DF9FE0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action LKKCMMNHMJL
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x5DF9570", Offset = "0x5DF8170", VA = "0x185DF9570", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA6C0", Offset = "0x5DF92C0", VA = "0x185DFA6C0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<FAFKHKPFEKI> HMDKKBAFIJC
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF9880", Offset = "0x5DF8480", VA = "0x185DF9880", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x5DF9DF0", Offset = "0x5DF89F0", VA = "0x185DF9DF0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event Action<FAFKHKPFEKI> IDGBMMFDPEK
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA8B0", Offset = "0x5DF94B0", VA = "0x185DFA8B0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x5DF9BC0", Offset = "0x5DF87C0", VA = "0x185DF9BC0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event Action MBIPKGCCLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x5DF8F00", Offset = "0x5DF7B00", VA = "0x185DF8F00", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x5DF9C60", Offset = "0x5DF8860", VA = "0x185DF9C60", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event Action<FAFKHKPFEKI> ICECBJMMMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x5DF9920", Offset = "0x5DF8520", VA = "0x185DF9920", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x5DF9740", Offset = "0x5DF8340", VA = "0x185DF9740", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA9F0", Offset = "0x5DF95F0", VA = "0x185DFA9F0")]
	public JDLLBKNLAFL(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5DF94F0", Offset = "0x5DF80F0", VA = "0x185DF94F0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA080", Offset = "0x5DF8C80", VA = "0x185DFA080", Slot = "30")]
	public void JPDJPFJGJJB(FAFKHKPFEKI PBNMPICADBG, bool NGKEIPOGCJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8FA0", Offset = "0x5DF7BA0", VA = "0x185DF8FA0", Slot = "6")]
	public void DCAAKEBPGMM(FAFKHKPFEKI DBHJCCLCMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9290", Offset = "0x5DF7E90", VA = "0x185DF9290", Slot = "7")]
	public void DIAJFCLGHNB(FAFKHKPFEKI DBHJCCLCMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8CC0", Offset = "0x5DF78C0", VA = "0x185DF8CC0", Slot = "4")]
	public void ANNGLPCKBKA(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA760", Offset = "0x5DF9360", VA = "0x185DFA760", Slot = "5")]
	public void MEAEKDMOCMC(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9B30", Offset = "0x5DF8730", VA = "0x185DF9B30")]
	private void HCHGKENDMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9AF0", Offset = "0x5DF86F0", VA = "0x185DF9AF0")]
	private void GOLOLHKODGD(FAFKHKPFEKI DBHJCCLCMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9E90", Offset = "0x5DF8A90", VA = "0x185DF9E90")]
	private void JGDDCMMNPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x5DF99C0", Offset = "0x5DF85C0", VA = "0x185DF99C0")]
	private void GLBGGDLJEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9610", Offset = "0x5DF8210", VA = "0x185DF9610")]
	private void EHLKHCACNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9D00", Offset = "0x5DF8900", VA = "0x185DF9D00")]
	[CompilerGenerated]
	private object INHLJOFAOEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class BGHNPIHEKLH
{
	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF050", Offset = "0x5DDDC50", VA = "0x185DDF050")]
	public static BFCDMDFHJNM AEAGMJDNIIJ(this FAFKHKPFEKI NHIFGJKHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class MADOJLIAMLE : PPMGPBJOPHG
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const string IHEGBFLFHMK = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly FMDOKKBAPOM PPNOPPNGLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly LHPAGGDFKDF LMIIBOOAPKI;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool CJIJDGNKPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x1821FC0", Offset = "0x1820BC0", VA = "0x181821FC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public LHPAGGDFKDF NMBGGBCMFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x7F0230", Offset = "0x7EEE30", VA = "0x1807F0230", Slot = "5")]
		get
		{
			return default(LHPAGGDFKDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x6F23360", Offset = "0x6F21F60", VA = "0x186F23360")]
	public MADOJLIAMLE(FAFKHKPFEKI LPIBPEGGEEE, in CJKCMEGMCAM PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x6F22E50", Offset = "0x6F21A50", VA = "0x186F22E50", Slot = "6")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x6F23110", Offset = "0x6F21D10", VA = "0x186F23110")]
	private bool IFMJEIBBLIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x6F22DF0", Offset = "0x6F219F0", VA = "0x186F22DF0", Slot = "7")]
	public void AFGGHBKIECF(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x6F22E20", Offset = "0x6F21A20", VA = "0x186F22E20", Slot = "8")]
	public void CPELJIHJKHN(object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x6F23230", Offset = "0x6F21E30", VA = "0x186F23230", Slot = "11")]
	public void ODHNAICIIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x6F23000", Offset = "0x6F21C00", VA = "0x186F23000")]
	private void FAEHMCHMGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x6F22F20", Offset = "0x6F21B20", VA = "0x186F22F20")]
	private void EAFCDCFDCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x6F231F0", Offset = "0x6F21DF0", VA = "0x186F231F0", Slot = "10")]
	public void KOPPABHPADM(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x6F231B0", Offset = "0x6F21DB0", VA = "0x186F231B0", Slot = "9")]
	public void KFIPOFHIKLA(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface BEMPIPEGMEK : IPMJOKMPDFD
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) JCGOMGHJDJL(Rigidbody EAHCOALHCOK);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface BFCDMDFHJNM : CMANNCNAEEB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANNGLPCKBKA(FAFKHKPFEKI LPIBPEGGEEE);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEAEKDMOCMC(FAFKHKPFEKI LPIBPEGGEEE);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCAAKEBPGMM(FAFKHKPFEKI DBHJCCLCMCD);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DIAJFCLGHNB(FAFKHKPFEKI DBHJCCLCMCD);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class LPEBPKEGIHE : DPIKHFGILLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool HCMLLAEMOKI;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool MMEFLHGHBCL
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x851940", Offset = "0x850540", VA = "0x180851940", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x6F22D00", Offset = "0x6F21900", VA = "0x186F22D00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x6F22DB0", Offset = "0x6F219B0", VA = "0x186F22DB0")]
	public LPEBPKEGIHE(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x6F22CD0", Offset = "0x6F218D0", VA = "0x186F22CD0", Slot = "6")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x6F22C90", Offset = "0x6F21890", VA = "0x186F22C90", Slot = "7")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class ABOJLNCAGIK : LDMPFENPFIH
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int GCEPGFMHOEN = 10;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private const float EKMOPOCMBDC = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const float OJFALJCIKDC = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const float GPDIGMFENGK = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly KLJOINJFJMA LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private bool LJFIFCNDLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool AIBBEMJFIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private int KIOKOHMNEOH;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private Rigidbody CGNLPAOPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEE20", Offset = "0x5DDDA20", VA = "0x185DDEE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private bool KNEIAPCMOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEA10", Offset = "0x5DDD610", VA = "0x185DDEA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private bool NDLKKFGHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEB50", Offset = "0x5DDD750", VA = "0x185DDEB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private FAFKHKPFEKI PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x5DDED20", Offset = "0x5DDD920", VA = "0x185DDED20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private bool IAFDPAMALCM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEE70", Offset = "0x5DDDA70", VA = "0x185DDEE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event PENLMJLNPDM OKAHFOGBNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEAB0", Offset = "0x5DDD6B0", VA = "0x185DDEAB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x5DDED80", Offset = "0x5DDD980", VA = "0x185DDED80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEED0", Offset = "0x5DDDAD0", VA = "0x185DDEED0")]
	public ABOJLNCAGIK(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE660", Offset = "0x5DDD260", VA = "0x185DDE660", Slot = "6")]
	public void DDAMFPNNPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE960", Offset = "0x5DDD560", VA = "0x185DDE960", Slot = "8")]
	public void FPMMBIEPONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE350", Offset = "0x5DDCF50", VA = "0x185DDE350", Slot = "7")]
	public bool AHEGLGAEPAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE6F0", Offset = "0x5DDD2F0", VA = "0x185DDE6F0", Slot = "9")]
	public void EFAMGCMKBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE970", Offset = "0x5DDD570", VA = "0x185DDE970", Slot = "11")]
	public void JDFOHMHOLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE920", Offset = "0x5DDD520", VA = "0x185DDE920", Slot = "12")]
	public void FBMPOHOFPGJ(bool AOHFCNFADMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE4B0", Offset = "0x5DDD0B0", VA = "0x185DDE4B0", Slot = "10")]
	public void CDIMIBACCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEB70", Offset = "0x5DDD770", VA = "0x185DDEB70")]
	private bool MLLBIMFCMED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE790", Offset = "0x5DDD390", VA = "0x185DDE790")]
	private void ENCDJLHHGBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class GPMEJGGBFFB : NLOPKOPLBOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly FAFKHKPFEKI LPIBPEGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private float OIOOEPMJBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float GIFDAOBHDEB;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public float LPAEGLFGFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x14D3EB0", Offset = "0x14D2AB0", VA = "0x1814D3EB0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DEFEC0", Offset = "0x5DEEAC0", VA = "0x185DEFEC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public float GHCFGOKLHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x11CFEB0", Offset = "0x11CEAB0", VA = "0x1811CFEB0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x5DF0030", Offset = "0x5DEEC30", VA = "0x185DF0030", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0150", Offset = "0x5DEED50", VA = "0x185DF0150")]
	public GPMEJGGBFFB(FAFKHKPFEKI LPIBPEGGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0100", Offset = "0x5DEED00", VA = "0x185DF0100", Slot = "8")]
	public void LBEBFFILMKK(Rigidbody CNBDNPIBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFF90", Offset = "0x5DEEB90", VA = "0x185DEFF90", Slot = "9")]
	public void HBECGLCKFBG(Rigidbody CNBDNPIBOOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface KPHACHCIEDK : ECIMMNKGOEA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000175")]
	PhotonView PKJBIFAFLLI
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
	internal class _RRAssemblyIndex : HPBGIGMFLIA
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F2D430", Offset = "0x6F2C030", VA = "0x186F2D430", Slot = "6")]
		public sealed override void MIJPKAHHAOP(FFIAJAAMFMA IACLOIAOHJF)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAC60", Offset = "0x1DD9860", VA = "0x181DDAC60")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
