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
		public static PBANGFKDEGA UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int PDBLHMBELKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int LMJMIGHOHOP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C700", Offset = "0x6F5BB00", VA = "0x186F5C700")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C740", Offset = "0x6F5BB40", VA = "0x186F5C740")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C720", Offset = "0x6F5BB20", VA = "0x186F5C720")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string HGJOENLBDNH, [Optional] UnityEngine.Object GEKPLLKAIKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string HGJOENLBDNH, [Optional] UnityEngine.Object GEKPLLKAIKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C830", Offset = "0x6F5BC30", VA = "0x186F5C830")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EFCBODEMGBN
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class GFLJKNAFHJM : CLNMMGNFNHK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x16197F0", Offset = "0x1618BF0", VA = "0x1816197F0", Slot = "4")]
		public Vector3 GAHJBGFKPPA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x16197F0", Offset = "0x1618BF0", VA = "0x1816197F0", Slot = "5")]
		public Vector3 IJPLOEOEKLF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GFLJKNAFHJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CLNMMGNFNHK JFNOBPAPBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5C00", Offset = "0x5DB5000", VA = "0x185DB5C00")]
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
		private static readonly NDPMEMNFALO PGNDIOGLDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool MPLBAKOOBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private HNCADDKEFCL PKLMJOFPOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[JADFEINJJEN(BGDDCFKMKBJ.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[JADFEINJJEN(BGDDCFKMKBJ.SelfAndParent, true, false, false)]
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
		private JOMEIPIHMJL physicsInterpolation;

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
		internal HNCADDKEFCL NCENENHCKFO
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F5C880", Offset = "0x6F5BC80", VA = "0x186F5C880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> ANNJFKHLGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x89EC90", Offset = "0x89E090", VA = "0x18089EC90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x89EBD0", Offset = "0x89DFD0", VA = "0x18089EBD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx BJEFICKBGOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F420", Offset = "0x6F5E820", VA = "0x186F5F420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx GILDPEKDHCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F3C0", Offset = "0x6F5E7C0", VA = "0x186F5F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx MOHMMJFCOKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FFE0", Offset = "0x6F5F3E0", VA = "0x186F5FFE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F61570", Offset = "0x6F60970", VA = "0x186F61570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform ADDLMMKPJHM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xD85170", Offset = "0xD84570", VA = "0x180D85170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform ONBHBBGKOKB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xD85170", Offset = "0xD84570", VA = "0x180D85170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public OBKHHICGOPB ELOLKHBOKNE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F180", Offset = "0x6F5E580", VA = "0x186F5F180")]
			get
			{
				return default(OBKHHICGOPB);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F60CD0", Offset = "0x6F600D0", VA = "0x186F60CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LIPNNMGAILJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F690", Offset = "0x6F5EA90", VA = "0x186F5F690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool POEKINHIMIB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F2A0", Offset = "0x6F5E6A0", VA = "0x186F5F2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CLNMMGNFNHK LJFGAKJBGFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F5D0", Offset = "0x6F5E9D0", VA = "0x186F5F5D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F60EE0", Offset = "0x6F602E0", VA = "0x186F60EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public CIICDJONOMO AMPFADHGNMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F570", Offset = "0x6F5E970", VA = "0x186F5F570")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F60E70", Offset = "0x6F60270", VA = "0x186F60E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool NFBJNCIJOAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F450", Offset = "0x6F5E850", VA = "0x186F5F450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody ANMFOPKOIPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F4B0", Offset = "0x6F5E8B0", VA = "0x186F5F4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KHGMFABOOHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F300", Offset = "0x6F5E700", VA = "0x186F5F300")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F60D90", Offset = "0x6F60190", VA = "0x186F60D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool PKMNCKIJCPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xF30490", Offset = "0xF2F890", VA = "0x180F30490")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xF304D0", Offset = "0xF2F8D0", VA = "0x180F304D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float KPNADFDDJOF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FF80", Offset = "0x6F5F380", VA = "0x186F5FF80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float EMOEMFOPHDP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FF20", Offset = "0x6F5F320", VA = "0x186F5FF20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F61500", Offset = "0x6F60900", VA = "0x186F61500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float NCDJGJJIJKN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F8F0", Offset = "0x6F5ECF0", VA = "0x186F5F8F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F61180", Offset = "0x6F60580", VA = "0x186F61180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float LJAFCEJMHDM
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F6F0", Offset = "0x6F5EAF0", VA = "0x186F5F6F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6F60F50", Offset = "0x6F60350", VA = "0x186F60F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool IHAGPGDHADD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F60500", Offset = "0x6F5F900", VA = "0x186F60500")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F61AB0", Offset = "0x6F60EB0", VA = "0x186F61AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 IAFPEAALBDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FD00", Offset = "0x6F5F100", VA = "0x186F5FD00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F612D0", Offset = "0x6F606D0", VA = "0x186F612D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 OIHKFKMAIKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F60640", Offset = "0x6F5FA40", VA = "0x186F60640")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode DHECKNNGOPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F830", Offset = "0x6F5EC30", VA = "0x186F5F830")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F610A0", Offset = "0x6F604A0", VA = "0x186F610A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float MCGDKOEGIHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F360", Offset = "0x6F5E760", VA = "0x186F5F360")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F60E00", Offset = "0x6F60200", VA = "0x186F60E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints PNEBODDKIIE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F890", Offset = "0x6F5EC90", VA = "0x186F5F890")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F61110", Offset = "0x6F60510", VA = "0x186F61110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 HIEJPBEIFAM
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F60040", Offset = "0x6F5F440", VA = "0x186F60040")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 JEMDGMPHKNB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F60040", Offset = "0x6F5F440", VA = "0x186F60040")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F61880", Offset = "0x6F60C80", VA = "0x186F61880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float EGIJLHPLPIF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FDE0", Offset = "0x6F5F1E0", VA = "0x186F5FDE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F613B0", Offset = "0x6F607B0", VA = "0x186F613B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float IBBELPHLKJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6F604A0", Offset = "0x6F5F8A0", VA = "0x186F604A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F61A40", Offset = "0x6F60E40", VA = "0x186F61A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion NPJHAOOAFIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6F60120", Offset = "0x6F5F520", VA = "0x186F60120")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F615E0", Offset = "0x6F609E0", VA = "0x186F615E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion AMLHGLPPMDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6F603C0", Offset = "0x6F5F7C0", VA = "0x186F603C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6F61960", Offset = "0x6F60D60", VA = "0x186F61960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 CKDMGFGAGNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6F60200", Offset = "0x6F5F600", VA = "0x186F60200")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6F616C0", Offset = "0x6F60AC0", VA = "0x186F616C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion EHPPGFAKMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6F602E0", Offset = "0x6F5F6E0", VA = "0x186F602E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6F617A0", Offset = "0x6F60BA0", VA = "0x186F617A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 CCEKBJKHCEP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6F60560", Offset = "0x6F5F960", VA = "0x186F60560")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6F61B20", Offset = "0x6F60F20", VA = "0x186F61B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 JONJDHHMABD
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FE40", Offset = "0x6F5F240", VA = "0x186F5FE40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6F61420", Offset = "0x6F60820", VA = "0x186F61420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 IGPNCMNEFAG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F750", Offset = "0x6F5EB50", VA = "0x186F5F750")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6F60FC0", Offset = "0x6F603C0", VA = "0x186F60FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 MADECJFHGGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FC20", Offset = "0x6F5F020", VA = "0x186F5FC20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6F611F0", Offset = "0x6F605F0", VA = "0x186F611F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 HIFIPMJFACA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FAE0", Offset = "0x6F5EEE0", VA = "0x186F5FAE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion LACDOFNOLCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FA00", Offset = "0x6F5EE00", VA = "0x186F5FA00")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 OBNKGLCLCBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6F60800", Offset = "0x6F5FC00", VA = "0x186F60800")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 CAPKNEEPLFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6F60720", Offset = "0x6F5FB20", VA = "0x186F60720")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool LMHKIOMKPEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FBC0", Offset = "0x6F5EFC0", VA = "0x186F5FBC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool HHFNLAJOPDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F630", Offset = "0x6F5EA30", VA = "0x186F5F630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool GEJCCHIKEBA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F240", Offset = "0x6F5E640", VA = "0x186F5F240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CPNJCBJMDLC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F1E0", Offset = "0x6F5E5E0", VA = "0x186F5F1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool LANMDJKFPEL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F120", Offset = "0x6F5E520", VA = "0x186F5F120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool HLIGDGINDAN
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F950", Offset = "0x6F5ED50", VA = "0x186F5F950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool GEKLMBBMKNK
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9BBE10", Offset = "0x9BB210", VA = "0x1809BBE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MIKHCFECODK EDKKGCMPELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F040", Offset = "0x6F5E440", VA = "0x186F5F040")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6F60BF0", Offset = "0x6F5FFF0", VA = "0x186F60BF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event NNKKEOCOMJB DJIDOPFMJNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6F5EFD0", Offset = "0x6F5E3D0", VA = "0x186F5EFD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6F60B80", Offset = "0x6F5FF80", VA = "0x186F60B80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event MIKHCFECODK OOBNDOHGDCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F5ED30", Offset = "0x6F5E130", VA = "0x186F5ED30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F608E0", Offset = "0x6F5FCE0", VA = "0x186F608E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event MIKHCFECODK KOKPFOIFDLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F5EDA0", Offset = "0x6F5E1A0", VA = "0x186F5EDA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F60950", Offset = "0x6F5FD50", VA = "0x186F60950")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event MIKHCFECODK GKHIKMJMNAP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F5EEF0", Offset = "0x6F5E2F0", VA = "0x186F5EEF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F60AA0", Offset = "0x6F5FEA0", VA = "0x186F60AA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<HKONAAAPIJN, HKONAAAPIJN> GBKHCJFHMEK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F5EE80", Offset = "0x6F5E280", VA = "0x186F5EE80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F60A30", Offset = "0x6F5FE30", VA = "0x186F60A30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event MIKHCFECODK AABAGKAPKHI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F5EF60", Offset = "0x6F5E360", VA = "0x186F5EF60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6F60B10", Offset = "0x6F5FF10", VA = "0x186F60B10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event MIKHCFECODK HJGOAEGHFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F0B0", Offset = "0x6F5E4B0", VA = "0x186F5F0B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F60C60", Offset = "0x6F60060", VA = "0x186F60C60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event MIKHCFECODK DBJIIOMEEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6F5EE10", Offset = "0x6F5E210", VA = "0x186F5EE10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F609C0", Offset = "0x6F5FDC0", VA = "0x186F609C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x855AF0", Offset = "0x854EF0", VA = "0x180855AF0")]
		internal void JLLDBNBFGOM(HNCADDKEFCL NBHMCHHOJCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C930", Offset = "0x6F5BD30", VA = "0x186F5C930")]
		internal void ABCIFHAMPAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F5EA20", Offset = "0x6F5DE20", VA = "0x186F5EA20")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody NDOJLICDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E6B0", Offset = "0x6F5DAB0", VA = "0x186F5E6B0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) IMLBEEHPEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D330", Offset = "0x6F5C730", VA = "0x186F5D330")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C880", Offset = "0x6F5BC80", VA = "0x186F5C880")]
		private HNCADDKEFCL GAPEHKLGFDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D400", Offset = "0x6F5C800", VA = "0x186F5D400")]
		private void CEBPBFKDMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F5DE70", Offset = "0x6F5D270", VA = "0x186F5DE70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C930", Offset = "0x6F5BD30", VA = "0x186F5C930")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D970", Offset = "0x6F5CD70", VA = "0x186F5D970")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F5DE10", Offset = "0x6F5D210", VA = "0x186F5DE10")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F5DED0", Offset = "0x6F5D2D0", VA = "0x186F5DED0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C9C0", Offset = "0x6F5BDC0", VA = "0x186F5C9C0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object IJNLJGNNJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F5DF40", Offset = "0x6F5D340", VA = "0x186F5DF40")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object IJNLJGNNJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D910", Offset = "0x6F5CD10", VA = "0x186F5D910")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F5DDB0", Offset = "0x6F5D1B0", VA = "0x186F5DDB0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E820", Offset = "0x6F5DC20", VA = "0x186F5E820")]
		public void SetParent(RigidbodyEx EOEKGHMNIDN, bool LAPMPFOBPLO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E250", Offset = "0x6F5D650", VA = "0x186F5E250")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5DBD0", Offset = "0x6F5CFD0", VA = "0x186F5DBD0")]
		public bool IsRigidbodyAncestor(RigidbodyEx KBCIAIEBDJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5DC10", Offset = "0x6F5D010", VA = "0x186F5DC10")]
		public bool IsRigidbodyDescendant(RigidbodyEx KKPEAHKPPIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CBE0", Offset = "0x6F5BFE0", VA = "0x186F5CBE0")]
		public void AddInterpolationRestriction(object IJNLJGNNJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F5DFB0", Offset = "0x6F5D3B0", VA = "0x186F5DFB0")]
		public void RemoveInterpolationRestriction(object IJNLJGNNJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D3A0", Offset = "0x6F5C7A0", VA = "0x186F5D3A0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CC50", Offset = "0x6F5C050", VA = "0x186F5CC50")]
		public void AddKinematic(object IJNLJGNNJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E020", Offset = "0x6F5D420", VA = "0x186F5E020")]
		public void RemoveKinematic(object IJNLJGNNJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E7A0", Offset = "0x6F5DBA0", VA = "0x186F5E7A0")]
		public void SetKinematic(object IJNLJGNNJFA, bool HLALGAMPNBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E5B0", Offset = "0x6F5D9B0", VA = "0x186F5E5B0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 EMIPGJANDGN, Quaternion OHBIGCJPLNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E4B0", Offset = "0x6F5D8B0", VA = "0x186F5E4B0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 LGFAFJOBNGM, Quaternion OEIEMLHEENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F5DAD0", Offset = "0x6F5CED0", VA = "0x186F5DAD0")]
		public Vector3 GetConstrainedVelocity(Vector3 CCEKBJKHCEP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D9D0", Offset = "0x6F5CDD0", VA = "0x186F5D9D0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 IGPNCMNEFAG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CB50", Offset = "0x6F5BF50", VA = "0x186F5CB50")]
		public void AddForce(Vector3 BLLAAOPKLPH, ForceMode JIPBPFDLGAD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CA30", Offset = "0x6F5BE30", VA = "0x186F5CA30")]
		public void AddForceAtPosition(Vector3 BLLAAOPKLPH, Vector3 FLBOBIODIJO, ForceMode JIPBPFDLGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CDC0", Offset = "0x6F5C1C0", VA = "0x186F5CDC0")]
		public void AddTorque(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CCC0", Offset = "0x6F5C0C0", VA = "0x186F5CCC0")]
		public void AddRelativeTorque(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5EB00", Offset = "0x6F5DF00", VA = "0x186F5EB00")]
		public Vector3 WorldToLocalVelocity(Vector3 MLIHKCLPMIC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5DCB0", Offset = "0x6F5D0B0", VA = "0x186F5DCB0")]
		public Vector3 LocalToWorldVelocity(Vector3 JONJDHHMABD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D8B0", Offset = "0x6F5CCB0", VA = "0x186F5D8B0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D850", Offset = "0x6F5CC50", VA = "0x186F5D850")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D7F0", Offset = "0x6F5CBF0", VA = "0x186F5D7F0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D790", Offset = "0x6F5CB90", VA = "0x186F5D790")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E3B0", Offset = "0x6F5D7B0", VA = "0x186F5E3B0")]
		public void ResetVelocityWorldSpace(Vector3 ELOPNDOJDBP, Vector3 OMEKBFHJPEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E2B0", Offset = "0x6F5D6B0", VA = "0x186F5E2B0")]
		public void ResetVelocityLocalSpace(Vector3 HKJGAFDNPCB, Vector3 MADECJFHGGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E170", Offset = "0x6F5D570", VA = "0x186F5E170")]
		public void ResetLinearVelocityLocalSpace(Vector3 HKJGAFDNPCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E910", Offset = "0x6F5DD10", VA = "0x186F5E910")]
		public bool SweepTest(Vector3 EPJPJGLJENE, out RaycastHit NFPNFECBHMA, float NCEKMHDDCCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6F5DC50", Offset = "0x6F5D050", VA = "0x186F5DC50")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E8B0", Offset = "0x6F5DCB0", VA = "0x186F5E8B0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5EAA0", Offset = "0x6F5DEA0", VA = "0x186F5EAA0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CD50", Offset = "0x6F5C150", VA = "0x186F5CD50")]
		public void AddShouldHaveUnityRigidbodyToken(object IJNLJGNNJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E090", Offset = "0x6F5D490", VA = "0x186F5E090")]
		public void RemoveShouldHaveUnityRigidbodyToken(object IJNLJGNNJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D100", Offset = "0x6F5C500", VA = "0x186F5D100")]
		public void ApplyForceVelocityChange(IHAJHGLLODM NIMFHBNDLJE, Vector3 KFEGEPPHIAJ, float FMDJMILNIFE, float BGKJPFEMPDM = 8f, float NKDCMOIFBFO = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D000", Offset = "0x6F5C400", VA = "0x186F5D000")]
		public void ApplyAngularVelocityChange(DCHGNBAICFJ IEOFODKJLHF, Vector3 MNNPNKKFOML, float APDOAPPOFCC = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D220", Offset = "0x6F5C620", VA = "0x186F5D220")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(DCHGNBAICFJ IEOFODKJLHF, Vector3 FKJONOBDEOA, float NKDFOLBGEBG = 7f, float ONGDPDONLHM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CF40", Offset = "0x6F5C340", VA = "0x186F5CF40")]
		public bool AllowedScaleChange(float LDKNCAHIPED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F5CE50", Offset = "0x6F5C250", VA = "0x186F5CE50")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx CDAJNGFOAON, object IJNLJGNNJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E100", Offset = "0x6F5D500", VA = "0x186F5E100")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object IJNLJGNNJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F5EC90", Offset = "0x6F5E090", VA = "0x186F5EC90")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class DPKECJJMFIN
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5B80", Offset = "0x5DB4F80", VA = "0x185DB5B80")]
	public static HNCADDKEFCL NCENENHCKFO(this RigidbodyEx LKJACCKKHID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void MIKHCFECODK(RigidbodyEx JMDOPDGDCPK);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FEONGLNBAAF : EBIKKFJAMIG
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int IMPBBODIEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA60", Offset = "0x80DE60", VA = "0x18080EA60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int LFDDLJFCBEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x80EC80", Offset = "0x80E080", VA = "0x18080EC80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D90", Offset = "0x7F1190", VA = "0x1807F1D90", Slot = "6")]
	public HKONAAAPIJN KIDKHNJFHHE(float FNENONJMBAP)
	{
		return default(HKONAAAPIJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "7")]
	public void MGOOIKEIGMG(HPNPMHNBHJG GHHNOPFOGCC, float AKNCHEAFHPI, OBKHHICGOPB LMOBIEKBBID = OBKHHICGOPB.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "8")]
	public void MGOOIKEIGMG(HPNPMHNBHJG GHHNOPFOGCC, Transform DNBOBJJKGLM, float AKNCHEAFHPI, OBKHHICGOPB LMOBIEKBBID = OBKHHICGOPB.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "9")]
	public void HNIIPPGNIHJ(HPNPMHNBHJG GHHNOPFOGCC, [Optional] float? AKNCHEAFHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "10")]
	public void AJCNBIMBJPF(HPNPMHNBHJG HAKJPFDKOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D90", Offset = "0x7F1190", VA = "0x1807F1D90", Slot = "11")]
	public HKONAAAPIJN PCPCNMAHNPD(HPNPMHNBHJG GHHNOPFOGCC)
	{
		return default(HKONAAAPIJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x811730", Offset = "0x810B30", VA = "0x180811730", Slot = "12")]
	public bool EOJBNLMLOEK(HPNPMHNBHJG GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "13")]
	public void LFDMEDLPEGH(HPNPMHNBHJG GHHNOPFOGCC, OBKHHICGOPB NAMCHOPGGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public FEONGLNBAAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JOMEIPIHMJL
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum DCHGNBAICFJ
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JALLAOKICKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody GFKPNFPKDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView EBGBBNEGBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 MGMPIIPBCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 GAPLELMOGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public JOMEIPIHMJL NINHMIPGMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool GGAODGLMFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool EOFCOFMOEMO;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void NNKKEOCOMJB(RigidbodyEx JMDOPDGDCPK, bool LAPMPFOBPLO = false);
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DGOAMDMMJCP(typeof(DKHGHMKPCBA), new string[] { "Ignore", "Mock" })]
public class KBIBEJICCCI : DKHGHMKPCBA
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool OBKIEDIEMPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8116E0", Offset = "0x810AE0", VA = "0x1808116E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
	public void EOBNAGILAOJ(string OAAMGJCNLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "6")]
	public void CDMBGEFMGEL(RigidbodyEx LKJACCKKHID, Action ENOAFIICPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x83C8E0", Offset = "0x83BCE0", VA = "0x18083C8E0", Slot = "7")]
	public EBIKKFJAMIG KGOAALJILAE(int BHBCIADNDME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "8")]
	public void IIIEKDGBAOC(Vector3 OIHKFKMAIKB, float NCMNEDFFPCK, Color OGGMNJPGMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public KBIBEJICCCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DGOAMDMMJCP(typeof(JANPOADJHGO), new string[] { })]
public class GIFEBLIPCJJ : JANPOADJHGO, LCECMPMAFGI
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly NDPMEMNFALO OLHOJKMAKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private PNEBECAEHNN KGFLHNMDGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private DKHGHMKPCBA HHBCKKPLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private ACNLDECGDAI OIAILNCPEGI;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool HLELFFAAOGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6CC0", Offset = "0x5DB60C0", VA = "0x185DB6CC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DKHGHMKPCBA FOBFCLAHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public ACNLDECGDAI BLJPMOJDMKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7460", Offset = "0x5DB6860", VA = "0x185DB7460", Slot = "12")]
	public void InitReferences(INPLDICFFFN LOBBJNOOMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6E20", Offset = "0x5DB6220", VA = "0x185DB6E20", Slot = "7")]
	public IMDEFFNCIAA DOCBCIAEIOC(RigidbodyEx LKJACCKKHID)
	{
		return default(IMDEFFNCIAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7270", Offset = "0x5DB6670", VA = "0x185DB7270")]
	private static IMDEFFNCIAA HGKBCKCIAEC(RigidbodyEx LKJACCKKHID)
	{
		return default(IMDEFFNCIAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6D10", Offset = "0x5DB6110", VA = "0x185DB6D10", Slot = "8")]
	public HNCADDKEFCL DBCPEBLAANN(RigidbodyEx LKJACCKKHID, JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6BF0", Offset = "0x5DB5FF0", VA = "0x185DB6BF0", Slot = "11")]
	private RigidbodyEx AACFPPMHAOH(GameObject NPKKHNDMELE, JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7370", Offset = "0x5DB6770", VA = "0x185DB7370", Slot = "9")]
	public void IJHLLNJFCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7120", Offset = "0x5DB6520", VA = "0x185DB7120", Slot = "10")]
	public void GFHFJOFEOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public GIFEBLIPCJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class EBFGMHACGAP
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const float OKCAOOGKFNH = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const float IFDOMFAOAPA = 0f;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const float POLJBIDNNBM = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public EBFGMHACGAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KFOLLEJLOHM
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2960", Offset = "0x5DC1D60", VA = "0x185DC2960")]
	public static void GMMFACJLKHD(this Rigidbody NDOJLICDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2AB0", Offset = "0x5DC1EB0", VA = "0x185DC2AB0")]
	public static void GMMFACJLKHD(this Rigidbody NDOJLICDABJ, Vector3 FIEPMCCAJBD, Quaternion LACDOFNOLCD, Vector3 OKOAHEMPMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2890", Offset = "0x5DC1C90", VA = "0x185DC2890")]
	public static void ANLOGEDHAGD(Vector3 CCEKBJKHCEP, Vector3 IGOMHNAHGBN, out Vector3 HJNKGPNPCPN, out Vector3 MIGCKIGOAPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum IHAJHGLLODM
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GFMMGHEHOCP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool LIPNNMGAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool POEKINHIMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MIKHCFECODK DLHBKIECPLO;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MKBEIIPNEIB();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DGJNFHBNFIF(HNCADDKEFCL MOHMMJFCOKF);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ELKBNPOFFKC(HNCADDKEFCL MOHMMJFCOKF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JHNGOMGDEDF
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	float HKLMIAEJNHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	float IJDPOHFHBBB
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
	void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GALMCDGHJPP(Rigidbody GFKPNFPKDAN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[GEDFJDPFIHC(FCAJHDGOHAJ.Application)]
public interface DKHGHMKPCBA
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool OBKIEDIEMPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOBNAGILAOJ(string OAAMGJCNLFP);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDMBGEFMGEL(RigidbodyEx LKJACCKKHID, Action ENOAFIICPMH);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EBIKKFJAMIG KGOAALJILAE(int BHBCIADNDME);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IIIEKDGBAOC(Vector3 OIHKFKMAIKB, float NCMNEDFFPCK, Color OGGMNJPGMJE);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[GEDFJDPFIHC(FCAJHDGOHAJ.Application)]
public interface JANPOADJHGO
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	DKHGHMKPCBA FOBFCLAHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	ACNLDECGDAI BLJPMOJDMKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool HLELFFAAOGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IMDEFFNCIAA DOCBCIAEIOC(RigidbodyEx LKJACCKKHID);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HNCADDKEFCL DBCPEBLAANN(RigidbodyEx LKJACCKKHID, JALLAOKICKK KOCKBILIHNN);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IJHLLNJFCMK();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GFHFJOFEOHM();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx LLLHLLEPBFO(GameObject NPKKHNDMELE, [Optional] JALLAOKICKK KOCKBILIHNN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BBCCKDJEIDA
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx GNICAMLPJMF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OOOFALFOHIF
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 FEGMNDFJJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 CPPDMGIDLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLHPBOOBFBI(HNCADDKEFCL MOHMMJFCOKF, object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCAJDBMABBB(object IJNLJGNNJFA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal class NJMLPJOFFEL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IBFGKBDICBN LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool OLOGLDMJOBK;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE310", Offset = "0x5DCD710", VA = "0x185DCE310")]
	public NJMLPJOFFEL(IBFGKBDICBN MBCPMPFIEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE2B0", Offset = "0x5DCD6B0", VA = "0x185DCE2B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class IBFGKBDICBN : HNCADDKEFCL, IDisposable, GLNLPOCAHDN
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const string PNEKOBKDMKN = "HasUnityRigidbodyByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly JANPOADJHGO JMAEGHAGIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal KAKAJECMEFH IFBHCJPNLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal CBPAJNHEOHG BCMBGJEEPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal GFMMGHEHOCP GNEJKCIHIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal PNDBILPOCAL CCEKBJKHCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal OOOFALFOHIF ANDLANGLHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal DLEOKLGAEFK GNOMHGGOCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal JHNGOMGDEDF CKHCJMFBAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal MHLMOEPKKCN GABJLPMCLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal ABAMFAEIDNO OGNOKLNCAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal PPIJHNBKLMK HJDNPHHPOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal BIKICKEFOFJ CNPICKIMPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal BIFJOJANGIA BLLAAOPKLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal FKIFKCOAGDD LDIGAMJOGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal FIJNONMINBM GFKPNFPKDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal FBHHEECMAOI ABADKBGJFBA;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public RigidbodyEx NBEPNPBGJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x85CDD0", Offset = "0x85C1D0", VA = "0x18085CDD0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAF1960", Offset = "0xAF0D60", VA = "0x180AF1960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public GameObject NKPLLMLEPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x92F3F0", Offset = "0x92E7F0", VA = "0x18092F3F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xB5B400", Offset = "0xB5A800", VA = "0x180B5B400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Transform LIOPMIPOJEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD180", Offset = "0x5DBC580", VA = "0x185DBD180", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public IEnumerable<object> DBLEKOCAHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD380", Offset = "0x5DBC780", VA = "0x185DBD380", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Rigidbody ANMFOPKOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBB70", Offset = "0x5DBAF70", VA = "0x185DBBB70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public HNCADDKEFCL GCKCFOBIHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB630", Offset = "0x5DBAA30", VA = "0x185DBB630", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC460", Offset = "0x5DBB860", VA = "0x185DBC460", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IReadOnlyList<HNCADDKEFCL> MNOGMALHBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5DBF450", Offset = "0x5DBE850", VA = "0x185DBF450", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public HNCADDKEFCL GILDPEKDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDD30", Offset = "0x5DBD130", VA = "0x185DBDD30", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool AMFPPNFBIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD9D0", Offset = "0x5DBCDD0", VA = "0x185DBD9D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool LIPNNMGAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE170", Offset = "0x5DBD570", VA = "0x185DBE170", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool POEKINHIMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE0C0", Offset = "0x5DBD4C0", VA = "0x185DBE0C0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public CLNMMGNFNHK LJFGAKJBGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC8E0", Offset = "0x5DBBCE0", VA = "0x185DBC8E0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDA30", Offset = "0x5DBCE30", VA = "0x185DBDA30", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public CIICDJONOMO AMPFADHGNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD050", Offset = "0x5DBC450", VA = "0x185DBD050", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDE40", Offset = "0x5DBD240", VA = "0x185DBDE40", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float MCGDKOEGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5DBF4A0", Offset = "0x5DBE8A0", VA = "0x185DBF4A0", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD320", Offset = "0x5DBC720", VA = "0x185DBD320", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector3 JMEHDDALPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD3D0", Offset = "0x5DBC7D0", VA = "0x185DBD3D0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5DBAE40", Offset = "0x5DBA240", VA = "0x185DBAE40", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Vector3 DFOGIPNDFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC7B0", Offset = "0x5DBBBB0", VA = "0x185DBC7B0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5DBFC70", Offset = "0x5DBF070", VA = "0x185DBFC70", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector3 CCECFEDOHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5DBAA20", Offset = "0x5DB9E20", VA = "0x185DBAA20", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE660", Offset = "0x5DBDA60", VA = "0x185DBE660", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Vector3 JCLOPKLIDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBBC0", Offset = "0x5DBAFC0", VA = "0x185DBBBC0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5DBAC90", Offset = "0x5DBA090", VA = "0x185DBAC90", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool GEJCCHIKEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB3A0", Offset = "0x5DBA7A0", VA = "0x185DBB3A0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool CPNJCBJMDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE110", Offset = "0x5DBD510", VA = "0x185DBE110", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool LANMDJKFPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5DC00D0", Offset = "0x5DBF4D0", VA = "0x185DC00D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool NFBJNCIJOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0020", Offset = "0x5DBF420", VA = "0x185DC0020", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector3 FEGMNDFJJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5DBF5F0", Offset = "0x5DBE9F0", VA = "0x185DBF5F0", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 CPPDMGIDLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBD60", Offset = "0x5DBB160", VA = "0x185DBBD60", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 FCENJNKLLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5DBAFC0", Offset = "0x5DBA3C0", VA = "0x185DBAFC0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD700", Offset = "0x5DBCB00", VA = "0x185DBD700", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 PGCNAIKHOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5DBF240", Offset = "0x5DBE640", VA = "0x185DBF240", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float FLGPCIIOBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE260", Offset = "0x5DBD660", VA = "0x185DBE260", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public float KIMEKCFKEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBA70", Offset = "0x5DBAE70", VA = "0x185DBBA70", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD0C0", Offset = "0x5DBC4C0", VA = "0x185DBD0C0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Vector3 DPMPNPGFKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0290", Offset = "0x5DBF690", VA = "0x185DC0290", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Quaternion IEOFMJCGDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB090", Offset = "0x5DBA490", VA = "0x185DBB090", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public float HKLMIAEJNHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5DBCB50", Offset = "0x5DBBF50", VA = "0x185DBCB50", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD590", Offset = "0x5DBC990", VA = "0x185DBD590", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float IJDPOHFHBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA8C0", Offset = "0x5DB9CC0", VA = "0x185DBA8C0", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDC20", Offset = "0x5DBD020", VA = "0x185DBDC20", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool LFILBCFKBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5DBCAA0", Offset = "0x5DBBEA0", VA = "0x185DBCAA0", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE540", Offset = "0x5DBD940", VA = "0x185DBE540", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public POPMGKKDDGN ELOLKHBOKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB740", Offset = "0x5DBAB40", VA = "0x185DBB740", Slot = "51")]
		get
		{
			return default(POPMGKKDDGN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC590", Offset = "0x5DBB990", VA = "0x185DBC590", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool EGICHPNLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA870", Offset = "0x5DB9C70", VA = "0x185DBA870", Slot = "53")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Transform ADDLMMKPJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC650", Offset = "0x5DBBA50", VA = "0x185DBC650", Slot = "54")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Transform ONBHBBGKOKB
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC650", Offset = "0x5DBBA50", VA = "0x185DBC650", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 JFODMGHNGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE5A0", Offset = "0x5DBD9A0", VA = "0x185DBE5A0", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5DBAF10", Offset = "0x5DBA310", VA = "0x185DBAF10", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float KNPPLOABHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5DC01C0", Offset = "0x5DBF5C0", VA = "0x185DC01C0", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC2B0", Offset = "0x5DBB6B0", VA = "0x185DBC2B0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public float NOHOOMPLHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD0A0", Offset = "0x5DBC4A0", VA = "0x185DBD0A0", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD210", Offset = "0x5DBC610", VA = "0x185DBD210", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Quaternion FIAPKFGJCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA7C0", Offset = "0x5DB9BC0", VA = "0x185DBA7C0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB290", Offset = "0x5DBA690", VA = "0x185DBB290", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 EFLKGNHAIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC410", Offset = "0x5DBB810", VA = "0x185DBC410", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5DC04A0", Offset = "0x5DBF8A0", VA = "0x185DC04A0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Quaternion EPEMEPHGANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC3D0", Offset = "0x5DBB7D0", VA = "0x185DBC3D0", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD940", Offset = "0x5DBCD40", VA = "0x185DBD940", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public RigidbodyConstraints FHGJPBBDFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE1C0", Offset = "0x5DBD5C0", VA = "0x185DBE1C0", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB680", Offset = "0x5DBAA80", VA = "0x185DBB680", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool KHGMFABOOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC320", Offset = "0x5DBB720", VA = "0x185DBC320", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD8E0", Offset = "0x5DBCCE0", VA = "0x185DBD8E0", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool NPIOKLFPNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5DBF1F0", Offset = "0x5DBE5F0", VA = "0x185DBF1F0", Slot = "133")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CollisionDetectionMode FANAAAEAKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE210", Offset = "0x5DBD610", VA = "0x185DBE210", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBE90", Offset = "0x5DBB290", VA = "0x185DBBE90", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool CIKGJKFBIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC660", Offset = "0x5DBBA60", VA = "0x185DBC660", Slot = "142")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public bool HHFNLAJOPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDA90", Offset = "0x5DBCE90", VA = "0x185DBDA90", Slot = "74")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool ANFDJELJNFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBAC0", Offset = "0x5DBAEC0", VA = "0x185DBBAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool EDNCEKKHBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDF50", Offset = "0x5DBD350", VA = "0x185DBDF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event MIKHCFECODK OOBNDOHGDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0230", Offset = "0x5DBF630", VA = "0x185DC0230", Slot = "80")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB5D0", Offset = "0x5DBA9D0", VA = "0x185DBB5D0", Slot = "81")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event MIKHCFECODK KOKPFOIFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC370", Offset = "0x5DBB770", VA = "0x185DBC370", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBE30", Offset = "0x5DBB230", VA = "0x185DBBE30", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event NNKKEOCOMJB IDJGLLKNKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE730", Offset = "0x5DBDB30", VA = "0x185DBE730", Slot = "84")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDC80", Offset = "0x5DBD080", VA = "0x185DBDC80", Slot = "85")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event MIKHCFECODK DLHBKIECPLO
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5DBFC10", Offset = "0x5DBF010", VA = "0x185DBFC10", Slot = "87")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5DBAAF0", Offset = "0x5DB9EF0", VA = "0x185DBAAF0", Slot = "88")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event MIKHCFECODK GKHIKMJMNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD5F0", Offset = "0x5DBC9F0", VA = "0x185DBD5F0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD7D0", Offset = "0x5DBCBD0", VA = "0x185DBD7D0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event MIKHCFECODK GGMPDBAHIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5DBCAF0", Offset = "0x5DBBEF0", VA = "0x185DBCAF0", Slot = "112")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA9C0", Offset = "0x5DB9DC0", VA = "0x185DBA9C0", Slot = "113")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<HKONAAAPIJN, HKONAAAPIJN> GBKHCJFHMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDDE0", Offset = "0x5DBD1E0", VA = "0x185DBDDE0", Slot = "116")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA480", Offset = "0x5DB9880", VA = "0x185DBA480", Slot = "117")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event MIKHCFECODK BLLEHHOJICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDD80", Offset = "0x5DBD180", VA = "0x185DBDD80", Slot = "118")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBF40", Offset = "0x5DBB340", VA = "0x185DBBF40", Slot = "119")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event MIKHCFECODK DBJIIOMEEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5DBFA80", Offset = "0x5DBEE80", VA = "0x185DBFA80", Slot = "124")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD4A0", Offset = "0x5DBC8A0", VA = "0x185DBD4A0", Slot = "125")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DC05A0", Offset = "0x5DBF9A0", VA = "0x185DC05A0")]
	public IBFGKBDICBN(GameObject NJMBJKHNCBN, RigidbodyEx MNBGODGICBO, JANPOADJHGO JMAEGHAGIPP, in JALLAOKICKK KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCD50", Offset = "0x5DBC150", VA = "0x185DBCD50", Slot = "143")]
	protected virtual void GJHBAAFKCLC(JANPOADJHGO JMAEGHAGIPP, JALLAOKICKK KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DBBC90", Offset = "0x5DBB090", VA = "0x185DBBC90", Slot = "144")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF310", Offset = "0x5DBE710", VA = "0x185DBF310", Slot = "75")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DBBEF0", Offset = "0x5DBB2F0", VA = "0x185DBBEF0", Slot = "76")]
	public void ECAGCNFHBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD030", Offset = "0x5DBC430", VA = "0x185DBD030", Slot = "77")]
	public void GPFGCELEJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD650", Offset = "0x5DBCA50", VA = "0x185DBD650", Slot = "145")]
	public virtual void IBHAOAOIGOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC04F0", Offset = "0x5DBF8F0", VA = "0x185DC04F0", Slot = "86")]
	public void PPONGLALHNF(HNCADDKEFCL EOEKGHMNIDN, bool LAPMPFOBPLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDEF0", Offset = "0x5DBD2F0", VA = "0x185DBDEF0", Slot = "89")]
	public void JIFCKNJDBDB(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD880", Offset = "0x5DBCC80", VA = "0x185DBD880", Slot = "90")]
	public void IFGJBFKAEIF(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0360", Offset = "0x5DBF760", VA = "0x185DC0360", Slot = "91")]
	public Vector3 PNIDAHMAOMO(Vector3 MLIHKCLPMIC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5DBFB20", Offset = "0x5DBEF20", VA = "0x185DBFB20", Slot = "92")]
	public Vector3 NNBHMNHBLHK(Vector3 JONJDHHMABD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5DBBEF0", Offset = "0x5DBB2F0", VA = "0x185DBBEF0", Slot = "93")]
	public void KAEOGPGNKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD540", Offset = "0x5DBC940", VA = "0x185DBD540", Slot = "94")]
	public void HNANFLOOICJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA770", Offset = "0x5DB9B70", VA = "0x185DBA770", Slot = "95")]
	public void AGJLHOENOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5DBABA0", Offset = "0x5DB9FA0", VA = "0x185DBABA0", Slot = "96")]
	public void BHONDBKKIPH(Vector3 ELOPNDOJDBP, Vector3 OMEKBFHJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB980", Offset = "0x5DBAD80", VA = "0x185DBB980", Slot = "97")]
	public void DHODHCKLIJJ(Vector3 HKJGAFDNPCB, Vector3 MADECJFHGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDF90", Offset = "0x5DBD390", VA = "0x185DBDF90", Slot = "98")]
	public void JOFPDCAHJDI(Vector3 AIHNFDGGKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE420", Offset = "0x5DBD820", VA = "0x185DBE420", Slot = "99")]
	public void LCLPMDJEHJP(IHAJHGLLODM NIMFHBNDLJE, Vector3 KFEGEPPHIAJ, float FMDJMILNIFE, float BGKJPFEMPDM = 8f, float NKDCMOIFBFO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5DBFE30", Offset = "0x5DBF230", VA = "0x185DBFE30", Slot = "100")]
	public void OLEJKMPDNHI(DCHGNBAICFJ IEOFODKJLHF, Vector3 MNNPNKKFOML, float APDOAPPOFCC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB790", Offset = "0x5DBAB90", VA = "0x185DBB790", Slot = "101")]
	[Obsolete]
	public void DFPHMCCPDCG(DCHGNBAICFJ IEOFODKJLHF, Vector3 FKJONOBDEOA, float NKDFOLBGEBG = 7f, float ONGDPDONLHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5DBFF30", Offset = "0x5DBF330", VA = "0x185DBFF30", Slot = "102")]
	public Vector3 OMEPCLINFOB(Vector3 EOEKGHMNIDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5DBFD40", Offset = "0x5DBF140", VA = "0x185DBFD40", Slot = "103")]
	public Vector3 OKAAEINDKGD(Vector3 EOEKGHMNIDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0450", Offset = "0x5DBF850", VA = "0x185DC0450", Slot = "104")]
	public void PPIMFLMMADH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB1C0", Offset = "0x5DBA5C0", VA = "0x185DBB1C0", Slot = "105")]
	public void CEIIFEDEPJD(HNCADDKEFCL CDAJNGFOAON, object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB160", Offset = "0x5DBA560", VA = "0x185DBB160", Slot = "106")]
	public void CDOMPAEOHGK(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5DBAD60", Offset = "0x5DBA160", VA = "0x185DBAD60", Slot = "44")]
	public void BKPAIKLAHNP((Quaternion rot, Vector3 moments) IMLBEEHPEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5DC01E0", Offset = "0x5DBF5E0", VA = "0x185DC01E0", Slot = "109")]
	public void PDJPGKOMEMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD830", Offset = "0x5DBCC30", VA = "0x185DBD830", Slot = "110")]
	public void IEHFPDAHNFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB500", Offset = "0x5DBA900", VA = "0x185DBB500", Slot = "111")]
	public void CONKKKNIKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDEA0", Offset = "0x5DBD2A0", VA = "0x185DBDEA0", Slot = "114")]
	public bool JGHPGIPHPGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDCE0", Offset = "0x5DBD0E0", VA = "0x185DBDCE0", Slot = "78")]
	public void JDFKOJKPINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5DBAB50", Offset = "0x5DB9F50", VA = "0x185DBAB50", Slot = "115")]
	public void BHMLJGCOHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD980", Offset = "0x5DBCD80", VA = "0x185DBD980", Slot = "120")]
	public IDisposable IJCEPKOJMCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0070", Offset = "0x5DBF470", VA = "0x185DC0070", Slot = "121")]
	public void OOFMCOFCPPI(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD120", Offset = "0x5DBC520", VA = "0x185DBD120", Slot = "122")]
	public void HDGPIOKEHKN(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5DBEAD0", Offset = "0x5DBDED0", VA = "0x185DBEAD0", Slot = "123")]
	public void MDBEAPEPGAK(object IJNLJGNNJFA, bool HLALGAMPNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF6C0", Offset = "0x5DBEAC0", VA = "0x185DBF6C0", Slot = "126")]
	public void NHAHEPBEJCP(Vector3 EMIPGJANDGN, Quaternion OHBIGCJPLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCBA0", Offset = "0x5DBBFA0", VA = "0x185DBCBA0", Slot = "127")]
	public void GINFNLJKKKF(Vector3 LGFAFJOBNGM, Quaternion OEIEMLHEENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE060", Offset = "0x5DBD460", VA = "0x185DBE060", Slot = "128")]
	public bool KCFGOGMKAPP(float LDKNCAHIPED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB4A0", Offset = "0x5DBA8A0", VA = "0x185DBB4A0", Slot = "129")]
	public void CMJLIFKFMLH(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCA40", Offset = "0x5DBBE40", VA = "0x185DBCA40", Slot = "130")]
	public void GELKKMEMHGK(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB6E0", Offset = "0x5DBAAE0", VA = "0x185DBB6E0", Slot = "131")]
	public void DFAGECHNENN(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC880", Offset = "0x5DBBC80", VA = "0x185DBC880", Slot = "132")]
	public void FOPJGGNMGEC(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA4E0", Offset = "0x5DB98E0", VA = "0x185DBA4E0")]
	public void ACMAJCMGMIC(object IJNLJGNNJFA, bool HEIAHJNMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB320", Offset = "0x5DBA720", VA = "0x185DBB320", Slot = "134")]
	public void CGIMEPNJNED(Vector3 BLLAAOPKLPH, ForceMode JIPBPFDLGAD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC930", Offset = "0x5DBBD30", VA = "0x185DBC930", Slot = "135")]
	public void GAMHPGDDCEC(Vector3 BLLAAOPKLPH, Vector3 FLBOBIODIJO, ForceMode JIPBPFDLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE790", Offset = "0x5DBDB90", VA = "0x185DBE790", Slot = "136")]
	public void LLJCDDNBOOL(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB550", Offset = "0x5DBA950", VA = "0x185DBB550", Slot = "137")]
	public void DCEOLPLPMFG(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5DBBFA0", Offset = "0x5DBB3A0", VA = "0x185DBBFA0", Slot = "138")]
	public bool EHNGMCAIOPF(Vector3 EPJPJGLJENE, out RaycastHit NFPNFECBHMA, float NCEKMHDDCCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE810", Offset = "0x5DBDC10", VA = "0x185DBE810", Slot = "139")]
	public void LMOFLFBKNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0560", Offset = "0x5DBF960", VA = "0x185DC0560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4C0", Offset = "0x5DBB8C0", VA = "0x185DBC4C0")]
	private void FMCPAGONAFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF8D0", Offset = "0x5DBECD0", VA = "0x185DBF8D0")]
	private void NJKCIJAKBOJ(HNCADDKEFCL MOHMMJFCOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA580", Offset = "0x5DB9980", VA = "0x185DBA580")]
	private void AGBIMHCOJLM(HNCADDKEFCL MOHMMJFCOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA910", Offset = "0x5DB9D10", VA = "0x185DBA910")]
	private void BCGNDLOABNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF4F0", Offset = "0x5DBE8F0", VA = "0x185DBF4F0")]
	private void NEJHHFPOCJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB3F0", Offset = "0x5DBA7F0", VA = "0x185DBB3F0")]
	private void CKLEJIMCPHM(HNCADDKEFCL FJLPEDHEFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB8A0", Offset = "0x5DBACA0", VA = "0x185DBB8A0")]
	private void DGJNFHBNFIF(HNCADDKEFCL MOHMMJFCOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC1D0", Offset = "0x5DBB5D0", VA = "0x185DBC1D0")]
	private void ELKBNPOFFKC(HNCADDKEFCL MOHMMJFCOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE2B0", Offset = "0x5DBD6B0", VA = "0x185DBE2B0")]
	private void KONHGJEMGLA(RigidbodyEx MOHMMJFCOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE860", Offset = "0x5DBDC60", VA = "0x185DBE860", Slot = "146")]
	protected virtual void LPHINDPMMCF(RigidbodyEx LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC0A0", Offset = "0x5DBB4A0", VA = "0x185DBC0A0")]
	[Conditional("UNITY_EDITOR")]
	private void EKMEKOADAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5DBEF10", Offset = "0x5DBE310", VA = "0x185DBEF10")]
	protected void MFODGJCAFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5DBEB40", Offset = "0x5DBDF40", VA = "0x185DBEB40")]
	protected void MDLHPGHHPIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal static class LBBLLHLPILA
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3EC0", Offset = "0x5DC32C0", VA = "0x185DC3EC0")]
	public static HNCADDKEFCL EGMHJKJGFBD(this HNCADDKEFCL LKJACCKKHID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3E40", Offset = "0x5DC3240", VA = "0x185DC3E40")]
	public static bool EBOJDNMBOEI(this HNCADDKEFCL LKJACCKKHID, HNCADDKEFCL KBCIAIEBDJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4040", Offset = "0x5DC3440", VA = "0x185DC4040")]
	public static bool OOEJANJCOAE(this HNCADDKEFCL LKJACCKKHID, HNCADDKEFCL KKPEAHKPPIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3FF0", Offset = "0x5DC33F0", VA = "0x185DC3FF0")]
	public static RigidbodyEx NBEPNPBGJOJ(this HNCADDKEFCL NCENENHCKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3F80", Offset = "0x5DC3380", VA = "0x185DC3F80")]
	public static IBFGKBDICBN HODNNFJBOJH(this HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DLEOKLGAEFK
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 FCENJNKLLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 PGCNAIKHOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float FLGPCIIOBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float KIMEKCFKEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 DPMPNPGFKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Quaternion IEOFMJCGDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event MIKHCFECODK HIGOEIJCCLB;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BKPAIKLAHNP((Quaternion rot, Vector3 moments) IMLBEEHPEDB);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IEHFPDAHNFI();

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PDJPGKOMEMH();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CONKKKNIKMG();

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GALMCDGHJPP(Rigidbody GFKPNFPKDAN);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LMOFLFBKNOE();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface GLNLPOCAHDN
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool CIKGJKFBIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HNCADDKEFCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Rigidbody ANMFOPKOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	RigidbodyEx NBEPNPBGJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	GameObject NKPLLMLEPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Transform LIOPMIPOJEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	IEnumerable<object> DBLEKOCAHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	HNCADDKEFCL GCKCFOBIHPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	IReadOnlyList<HNCADDKEFCL> MNOGMALHBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	HNCADDKEFCL GILDPEKDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool AMFPPNFBIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool LIPNNMGAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool POEKINHIMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	CLNMMGNFNHK LJFGAKJBGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	CIICDJONOMO AMPFADHGNMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	float MCGDKOEGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Vector3 JMEHDDALPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Vector3 DFOGIPNDFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Vector3 CCECFEDOHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 JCLOPKLIDGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool GEJCCHIKEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool CPNJCBJMDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool LANMDJKFPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool NFBJNCIJOAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Vector3 FEGMNDFJJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Vector3 CPPDMGIDLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Vector3 FCENJNKLLFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Vector3 PGCNAIKHOLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	float FLGPCIIOBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	float KIMEKCFKEGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Vector3 DPMPNPGFKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Quaternion IEOFMJCGDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	float HKLMIAEJNHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	float IJDPOHFHBBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool LFILBCFKBAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	POPMGKKDDGN ELOLKHBOKNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool EGICHPNLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	Transform ADDLMMKPJHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Transform ONBHBBGKOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 JFODMGHNGKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	float KNPPLOABHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	float NOHOOMPLHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Quaternion FIAPKFGJCNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	Vector3 EFLKGNHAIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Quaternion EPEMEPHGANB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	RigidbodyConstraints FHGJPBBDFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool KHGMFABOOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	CollisionDetectionMode FANAAAEAKLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool HHFNLAJOPDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool NPIOKLFPNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "129")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event MIKHCFECODK OOBNDOHGDCP;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event MIKHCFECODK KOKPFOIFDLJ;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event NNKKEOCOMJB IDJGLLKNKAI;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event MIKHCFECODK DLHBKIECPLO;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event MIKHCFECODK GKHIKMJMNAP;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event MIKHCFECODK GGMPDBAHIGG;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event Action<HKONAAAPIJN, HKONAAAPIJN> GBKHCJFHMEK;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event MIKHCFECODK BLLEHHOJICC;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event MIKHCFECODK DBJIIOMEEFJ;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void BKPAIKLAHNP((Quaternion rot, Vector3 moments) IMLBEEHPEDB);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void MKBEIIPNEIB();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void ECAGCNFHBMC();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void GPFGCELEJPL();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void JDFKOJKPINN();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void IBHAOAOIGOL();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "82")]
	void PPONGLALHNF(HNCADDKEFCL EOEKGHMNIDN, bool LAPMPFOBPLO = false);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void JIFCKNJDBDB(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void IFGJBFKAEIF(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "87")]
	Vector3 PNIDAHMAOMO(Vector3 MLIHKCLPMIC);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 NNBHMNHBLHK(Vector3 JONJDHHMABD);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void KAEOGPGNKCF();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void HNANFLOOICJ();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void AGJLHOENOJH();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void BHONDBKKIPH(Vector3 ELOPNDOJDBP, Vector3 OMEKBFHJPEL);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void DHODHCKLIJJ(Vector3 HKJGAFDNPCB, Vector3 MADECJFHGGC);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void JOFPDCAHJDI(Vector3 AIHNFDGGKBC);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void LCLPMDJEHJP(IHAJHGLLODM NIMFHBNDLJE, Vector3 KFEGEPPHIAJ, float FMDJMILNIFE, float BGKJPFEMPDM = 8f, float NKDCMOIFBFO = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void OLEJKMPDNHI(DCHGNBAICFJ IEOFODKJLHF, Vector3 MNNPNKKFOML, float APDOAPPOFCC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void DFPHMCCPDCG(DCHGNBAICFJ IEOFODKJLHF, Vector3 FKJONOBDEOA, float NKDFOLBGEBG = 7f, float ONGDPDONLHM = 1f);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 OMEPCLINFOB(Vector3 EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 OKAAEINDKGD(Vector3 EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void PPIMFLMMADH();

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void CEIIFEDEPJD(HNCADDKEFCL CDAJNGFOAON, object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void CDOMPAEOHGK(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void PDJPGKOMEMH();

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void IEHFPDAHNFI();

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void CONKKKNIKMG();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "110")]
	bool JGHPGIPHPGN();

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void BHMLJGCOHOK();

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "116")]
	IDisposable IJCEPKOJMCN();

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void OOFMCOFCPPI(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void HDGPIOKEHKN(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void MDBEAPEPGAK(object IJNLJGNNJFA, bool HLALGAMPNBK);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void NHAHEPBEJCP(Vector3 EMIPGJANDGN, Quaternion OHBIGCJPLNP);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void GINFNLJKKKF(Vector3 LGFAFJOBNGM, Quaternion OEIEMLHEENN);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "124")]
	bool KCFGOGMKAPP(float LDKNCAHIPED);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void CMJLIFKFMLH(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void GELKKMEMHGK(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void DFAGECHNENN(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void FOPJGGNMGEC(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void CGIMEPNJNED(Vector3 BLLAAOPKLPH, ForceMode JIPBPFDLGAD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void GAMHPGDDCEC(Vector3 BLLAAOPKLPH, Vector3 FLBOBIODIJO, ForceMode JIPBPFDLGAD);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void LLJCDDNBOOL(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void DCEOLPLPMFG(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool EHNGMCAIOPF(Vector3 EPJPJGLJENE, out RaycastHit NFPNFECBHMA, float NCEKMHDDCCP);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void LMOFLFBKNOE();

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BIFJOJANGIA
{
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGIMEPNJNED(Vector3 BLLAAOPKLPH, ForceMode JIPBPFDLGAD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAMHPGDDCEC(Vector3 BLLAAOPKLPH, Vector3 FLBOBIODIJO, ForceMode JIPBPFDLGAD);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLJCDDNBOOL(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DCEOLPLPMFG(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface CLNMMGNFNHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 GAHJBGFKPPA();

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 IJPLOEOEKLF();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CBPAJNHEOHG
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool JMHBFIDMOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	KGLFAPPIPIG KNNAMIKDJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKBEIIPNEIB();

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCAFBDAHCPJ(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKJAKPKOAHD(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AGNNJPCOBEL(HNCADDKEFCL LKJACCKKHID);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BDLGBLALMBG(HNCADDKEFCL LKJACCKKHID);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KKNGELFLGCL();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PPIJHNBKLMK : IDisposable, HPNPMHNBHJG
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	POPMGKKDDGN ELOLKHBOKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<HKONAAAPIJN, HKONAAAPIJN> GBKHCJFHMEK;

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MKBEIIPNEIB();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KAKAJECMEFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	IReadOnlyList<HNCADDKEFCL> MNOGMALHBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	HNCADDKEFCL GILDPEKDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	HNCADDKEFCL GCKCFOBIHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event MIKHCFECODK OOBNDOHGDCP;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event MIKHCFECODK KOKPFOIFDLJ;

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	event NNKKEOCOMJB IDJGLLKNKAI;

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	event Action GPDCKMBDJJN;

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	event Action FCEHNKNEBCN;

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	event Action<HNCADDKEFCL> BNAHCBHAJOK;

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	event Action<HNCADDKEFCL> CFNFBEKMOCG;

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	event Action IIHHCIPDGCF;

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	event Action<HNCADDKEFCL> HFPIBPICLHB;

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PPONGLALHNF(HNCADDKEFCL OFEIPHKKILF, bool LAPMPFOBPLO = false);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[GEDFJDPFIHC(FCAJHDGOHAJ.Application)]
public interface ACNLDECGDAI
{
	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KAKAJECMEFH MAFLDFMPBGL(HNCADDKEFCL NBHMCHHOJCP);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PNDBILPOCAL PBOHFIDDIHF(HNCADDKEFCL NBHMCHHOJCP);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OOOFALFOHIF LNIPLIIGKJH(HNCADDKEFCL NBHMCHHOJCP);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JHNGOMGDEDF GHJIMMFBNCH(HNCADDKEFCL NBHMCHHOJCP);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ABAMFAEIDNO EOOHFODGDME(HNCADDKEFCL NBHMCHHOJCP);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PPIJHNBKLMK OFENOFKEBFE(HNCADDKEFCL NBHMCHHOJCP);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BIKICKEFOFJ PAFFCILGION(HNCADDKEFCL NBHMCHHOJCP);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BIFJOJANGIA AOIJIMCDNHL(HNCADDKEFCL NBHMCHHOJCP);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FBHHEECMAOI INMNIJHIDBN(HNCADDKEFCL NBHMCHHOJCP);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MHLMOEPKKCN BCPDJOFALLA(HNCADDKEFCL NBHMCHHOJCP);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FIJNONMINBM DKOPFLAILKM(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GFMMGHEHOCP JCEMNEJKPJD(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CBPAJNHEOHG OCMIFDBNEBL(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DLEOKLGAEFK CDBAOOCICIC(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FKIFKCOAGDD NHHCIGFPOBB(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HNCADDKEFCL DBCPEBLAANN(RigidbodyEx LKJACCKKHID, JALLAOKICKK KOCKBILIHNN, JANPOADJHGO JMAEGHAGIPP);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface FKIFKCOAGDD
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool KHGMFABOOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool HJECKIFELBM
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	RigidbodyConstraints FHGJPBBDFOA
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
	void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GALMCDGHJPP(Rigidbody GFKPNFPKDAN);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CIICDJONOMO
{
	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNELBBFJMGD(Vector3 HGKMHIBMOEC);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMOFMAFLFJH(Vector3 IGPNCMNEFAG);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MELFAEDACFC(Vector3 HGKMHIBMOEC);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DCILAHHHPAN(Vector3 IGPNCMNEFAG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BIKICKEFOFJ
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool EGICHPNLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	IEnumerable<object> OMNDHIMBMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	event MIKHCFECODK BLLEHHOJICC;

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBPPLFAOFGI();

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OOFMCOFCPPI(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HDGPIOKEHKN(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MDBEAPEPGAK(object IJNLJGNNJFA, bool HLALGAMPNBK);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IDisposable IJCEPKOJMCN();

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HDGIJJBLDBO(Rigidbody OHFFPKCPFLA);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GALMCDGHJPP(Rigidbody GFKPNFPKDAN);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface FBHHEECMAOI
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	CollisionDetectionMode FANAAAEAKLM
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
	void MKBEIIPNEIB();

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PDMDJFGJIDK(bool LMHKIOMKPEP);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIPOGJKIAPI(bool LMHKIOMKPEP);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EHNGMCAIOPF(Vector3 EPJPJGLJENE, out RaycastHit NFPNFECBHMA, float NCEKMHDDCCP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface PNDBILPOCAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	CLNMMGNFNHK LJFGAKJBGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	CIICDJONOMO AMPFADHGNMC
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Vector3 CCECFEDOHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Vector3 JMEHDDALPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Vector3 JCLOPKLIDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	Vector3 DFOGIPNDFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	float MCGDKOEGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	bool NFBJNCIJOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MKBEIIPNEIB();

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HPDFJLGJJBB(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OLEJKMPDNHI(DCHGNBAICFJ IEOFODKJLHF, Vector3 MNNPNKKFOML, float APDOAPPOFCC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LCLPMDJEHJP(IHAJHGLLODM NIMFHBNDLJE, Vector3 KFEGEPPHIAJ, float FMDJMILNIFE, float BGKJPFEMPDM = 8f, float NKDCMOIFBFO = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DFPHMCCPDCG(DCHGNBAICFJ IEOFODKJLHF, Vector3 FKJONOBDEOA, float NKDFOLBGEBG = 7f, float ONGDPDONLHM = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AGJLHOENOJH();

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HNANFLOOICJ();

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PPIMFLMMADH();

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KAEOGPGNKCF();

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 OKAAEINDKGD(Vector3 IGPNCMNEFAG);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 OMEPCLINFOB(Vector3 CCEKBJKHCEP);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CDBGCPHCPHC(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JOFPDCAHJDI(Vector3 AIHNFDGGKBC);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DHODHCKLIJJ(Vector3 HKJGAFDNPCB, Vector3 MADECJFHGGC);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void BHONDBKKIPH(Vector3 ELOPNDOJDBP, Vector3 OMEKBFHJPEL);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 NNBHMNHBLHK(Vector3 JONJDHHMABD);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 PNIDAHMAOMO(Vector3 MLIHKCLPMIC);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface FIJNONMINBM
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	Rigidbody ANMFOPKOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	bool NPIOKLFPNGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKBEIIPNEIB();

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DFAGECHNENN(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOPJGGNMGEC(object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PKKAGCKLDLF();

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PFACLNMJOKC();

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NCCLGOADJKE();

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IBDKNHGDBBB();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface MHLMOEPKKCN
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	bool LFILBCFKBAN
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
	void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN);

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GALMCDGHJPP(Rigidbody GFKPNFPKDAN);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface ABAMFAEIDNO
{
	[Cpp2IlInjected.Token(Token = "0x14000029")]
	event MIKHCFECODK GGMPDBAHIGG;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKBEIIPNEIB();

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JGHPGIPHPGN();

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DHAKKDLFDJC();

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JDFKOJKPINN();

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PGAFCJHFMAC();

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BHMLJGCOHOK();

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CIKLEGPLEEN(bool LHPPABJMNEG);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DGOAMDMMJCP(typeof(PEIOEFKNMMN), new string[] { })]
public sealed class BENALDBPDFD : LCECMPMAFGI, PEIOEFKNMMN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[HIOFMIONOOD]
	private IIAPALOEFIB LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool OLOGLDMJOBK;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool LBFDKGPBIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x90D9A0", Offset = "0x90CDA0", VA = "0x18090D9A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2B90", Offset = "0x5DB1F90", VA = "0x185DB2B90", Slot = "4")]
	public void InitReferences(INPLDICFFFN LOBBJNOOMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DB28D0", Offset = "0x5DB1CD0", VA = "0x185DB28D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2FB0", Offset = "0x5DB23B0", VA = "0x185DB2FB0", Slot = "6")]
	public void PKPNLJEIMMF(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2BE0", Offset = "0x5DB1FE0", VA = "0x185DB2BE0", Slot = "7")]
	public void JLLAHAMEIHB(IMDEFFNCIAA IEFFONDNDLL, bool EFEAAJNAGCA, bool HLNJKMGKDBB, bool OJFCBHDINJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2900", Offset = "0x5DB1D00", VA = "0x185DB2900")]
	private bool EIOKGPNPPCJ(IMDEFFNCIAA IEFFONDNDLL, out LKDEPBFOBJJ NBHMCHHOJCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2E60", Offset = "0x5DB2260", VA = "0x185DB2E60")]
	private bool KEPKBJOEANK(IMDEFFNCIAA IEFFONDNDLL, out MBFHAKJPEIC BHNEDJJAJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2A40", Offset = "0x5DB1E40", VA = "0x185DB2A40")]
	private bool INGKPNNFONK(IMDEFFNCIAA IEFFONDNDLL, out AAEGOEDDOBH MEILKCLGDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public BENALDBPDFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class AAEGOEDDOBH : GIKDLPOMOCJ, DLEOKLGAEFK
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	[Obsolete]
	public Vector3 FCENJNKLLFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5DACE40", Offset = "0x5DAC240", VA = "0x185DACE40", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5DADDD0", Offset = "0x5DAD1D0", VA = "0x185DADDD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 JCBMCBDCKDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DADCA0", Offset = "0x5DAD0A0", VA = "0x185DADCA0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x5DADDD0", Offset = "0x5DAD1D0", VA = "0x185DADDD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 IAANNCFBPFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEE60", Offset = "0x5DAE260", VA = "0x185DAEE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	[Obsolete]
	public Vector3 PGCNAIKHOLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5DAECE0", Offset = "0x5DAE0E0", VA = "0x185DAECE0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete]
	public float FLGPCIIOBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE630", Offset = "0x5DADA30", VA = "0x185DAE630", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float HBBDGPHPOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE460", Offset = "0x5DAD860", VA = "0x185DAE460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public float KIMEKCFKEGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD120", Offset = "0x5DAC520", VA = "0x185DAD120", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD820", Offset = "0x5DACC20", VA = "0x185DAD820", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 DPMPNPGFKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF300", Offset = "0x5DAE700", VA = "0x185DAF300", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public Quaternion IEOFMJCGDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5DACF70", Offset = "0x5DAC370", VA = "0x185DACF70", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private Rigidbody ANMFOPKOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC230", Offset = "0x5DAB630", VA = "0x185DAC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event MIKHCFECODK HIGOEIJCCLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE3C0", Offset = "0x5DAD7C0", VA = "0x185DAE3C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5DACFA0", Offset = "0x5DAC3A0", VA = "0x185DACFA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB05D0", Offset = "0x5DAF9D0", VA = "0x185DB05D0")]
	public AAEGOEDDOBH(HNCADDKEFCL LKJACCKKHID, in JALLAOKICKK KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEC20", Offset = "0x5DAE020", VA = "0x185DAEC20")]
	public float3 MDKBLIKGAHA()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEF90", Offset = "0x5DAE390", VA = "0x185DAEF90")]
	public bool OOGMGIPEKCK(out float3 OIHKFKMAIKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE550", Offset = "0x5DAD950", VA = "0x185DAE550")]
	public void KECFIILIJLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DACAD0", Offset = "0x5DABED0", VA = "0x185DACAD0")]
	public bool ADJGEOEAPHG(out float KPNADFDDJOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DACBC0", Offset = "0x5DABFC0", VA = "0x185DACBC0", Slot = "14")]
	public void BKPAIKLAHNP((Quaternion rot, Vector3 moments) IMLBEEHPEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF080", Offset = "0x5DAE480", VA = "0x185DAF080", Slot = "16")]
	public void PDJPGKOMEMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DADE00", Offset = "0x5DAD200", VA = "0x185DADE00", Slot = "15")]
	public void IEHFPDAHNFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DADB50", Offset = "0x5DACF50", VA = "0x185DADB50", Slot = "18")]
	public void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD340", Offset = "0x5DAC740", VA = "0x185DAD340", Slot = "19")]
	public void GALMCDGHJPP(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD040", Offset = "0x5DAC440", VA = "0x185DAD040", Slot = "17")]
	public void CONKKKNIKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE710", Offset = "0x5DADB10", VA = "0x185DAE710", Slot = "20")]
	public void LMOFLFBKNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF330", Offset = "0x5DAE730", VA = "0x185DAF330")]
	public void PKGEJPNPCMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD200", Offset = "0x5DAC600", VA = "0x185DAD200")]
	private void EDKGHCKEJHI(Vector3 EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD6A0", Offset = "0x5DACAA0", VA = "0x185DAD6A0")]
	[Obsolete]
	private Vector3 GGIPBKJPIFH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD820", Offset = "0x5DACC20", VA = "0x185DAD820")]
	private void GLKEKOMJGFL(float EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE180", Offset = "0x5DAD580", VA = "0x185DAE180")]
	private Vector3 IKHHAAJKEMN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD920", Offset = "0x5DACD20", VA = "0x185DAD920")]
	private Quaternion GONALEBFKKA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF370", Offset = "0x5DAE770", VA = "0x185DAF370")]
	internal (float, Vector3) PKPNLJEIMMF(Rigidbody ICFHHNMIFIJ)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class OHPCFIKAFOB
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F58260", Offset = "0x6F57660", VA = "0x186F58260")]
	public static AAEGOEDDOBH PKCPJAGPDEI(this HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class MEGIFEABMHD : GIKDLPOMOCJ, PNDBILPOCAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public CLNMMGNFNHK LJFGAKJBGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x5DCB5D0", Offset = "0x5DCA9D0", VA = "0x185DCB5D0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5DCBF60", Offset = "0x5DCB360", VA = "0x185DCBF60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public CIICDJONOMO AMPFADHGNMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x5DCB9C0", Offset = "0x5DCADC0", VA = "0x185DCB9C0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x5DCC220", Offset = "0x5DCB620", VA = "0x185DCC220", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 CCECFEDOHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA9C0", Offset = "0x5DC9DC0", VA = "0x185DCA9C0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5DCC870", Offset = "0x5DCBC70", VA = "0x185DCC870", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 JMEHDDALPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x5DCBB40", Offset = "0x5DCAF40", VA = "0x185DCBB40", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x5DCAD20", Offset = "0x5DCA120", VA = "0x185DCAD20", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 JCLOPKLIDGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5DCB3B0", Offset = "0x5DCA7B0", VA = "0x185DCB3B0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x5DCAC60", Offset = "0x5DCA060", VA = "0x185DCAC60", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public Vector3 DFOGIPNDFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x5DCB5A0", Offset = "0x5DCA9A0", VA = "0x185DCB5A0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x5DCCC30", Offset = "0x5DCC030", VA = "0x185DCCC30", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float MCGDKOEGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x5DCC990", Offset = "0x5DCBD90", VA = "0x185DCC990", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x5DCBB30", Offset = "0x5DCAF30", VA = "0x185DCBB30", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool NFBJNCIJOAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5DCD680", Offset = "0x5DCCA80", VA = "0x185DCD680", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private BIFJOJANGIA PKAINGFEJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x26BD020", Offset = "0x26BC420", VA = "0x1826BD020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool CIKGJKFBIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7B30", Offset = "0x5DB6F30", VA = "0x185DB7B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DACA50", Offset = "0x5DABE50", VA = "0x185DACA50")]
	public MEGIFEABMHD(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBBB0", Offset = "0x5DCAFB0", VA = "0x185DCBBB0", Slot = "20")]
	public void HPDFJLGJJBB(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAD50", Offset = "0x5DCA150", VA = "0x185DCAD50", Slot = "31")]
	public void CDBGCPHCPHC(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC470", Offset = "0x5DCB870", VA = "0x185DCC470", Slot = "19")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB410", Offset = "0x5DCA810", VA = "0x185DCB410", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBAF0", Offset = "0x5DCAEF0", VA = "0x185DCBAF0", Slot = "28")]
	public void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD760", Offset = "0x5DCCB60", VA = "0x185DCD760", Slot = "36")]
	public Vector3 PNIDAHMAOMO(Vector3 MLIHKCLPMIC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCA70", Offset = "0x5DCBE70", VA = "0x185DCCA70", Slot = "35")]
	public Vector3 NNBHMNHBLHK(Vector3 JONJDHHMABD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC470", Offset = "0x5DCB870", VA = "0x185DCC470", Slot = "27")]
	public void KAEOGPGNKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBB70", Offset = "0x5DCAF70", VA = "0x185DCBB70", Slot = "25")]
	public void HNANFLOOICJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA540", Offset = "0x5DC9940", VA = "0x185DCA540", Slot = "24")]
	public void AGJLHOENOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAA20", Offset = "0x5DC9E20", VA = "0x185DCAA20", Slot = "34")]
	public void BHONDBKKIPH(Vector3 ELOPNDOJDBP, Vector3 OMEKBFHJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB290", Offset = "0x5DCA690", VA = "0x185DCB290", Slot = "33")]
	public void DHODHCKLIJJ(Vector3 HKJGAFDNPCB, Vector3 MADECJFHGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC310", Offset = "0x5DCB710", VA = "0x185DCC310", Slot = "32")]
	public void JOFPDCAHJDI(Vector3 AIHNFDGGKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC4E0", Offset = "0x5DCB8E0", VA = "0x185DCC4E0", Slot = "22")]
	public void LCLPMDJEHJP(IHAJHGLLODM NIMFHBNDLJE, Vector3 KFEGEPPHIAJ, float FMDJMILNIFE, float BGKJPFEMPDM = 8f, float NKDCMOIFBFO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD370", Offset = "0x5DCC770", VA = "0x185DCD370", Slot = "21")]
	public void OLEJKMPDNHI(DCHGNBAICFJ IEOFODKJLHF, Vector3 MNNPNKKFOML, float APDOAPPOFCC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAFA0", Offset = "0x5DCA3A0", VA = "0x185DCAFA0", Slot = "23")]
	[Obsolete]
	public void DFPHMCCPDCG(DCHGNBAICFJ IEOFODKJLHF, Vector3 FKJONOBDEOA, float NKDFOLBGEBG = 7f, float ONGDPDONLHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD5C0", Offset = "0x5DCC9C0", VA = "0x185DCD5C0", Slot = "30")]
	public Vector3 OMEPCLINFOB(Vector3 CCEKBJKHCEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCC60", Offset = "0x5DCC060", VA = "0x185DCCC60", Slot = "29")]
	public Vector3 OKAAEINDKGD(Vector3 IGPNCMNEFAG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD940", Offset = "0x5DCCD40", VA = "0x185DCD940", Slot = "26")]
	public void PPIMFLMMADH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC050", Offset = "0x5DCB450", VA = "0x185DCC050")]
	private void JDJLJMCCMGF(float EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAE40", Offset = "0x5DCA240", VA = "0x185DCAE40")]
	private void CJGPFAHAJEE(Vector3 MNNPNKKFOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB700", Offset = "0x5DCAB00", VA = "0x185DCB700")]
	private Vector3 GGPNKEEOKBO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA0F0", Offset = "0x5DC94F0", VA = "0x185DCA0F0")]
	private void ADMLNIOHPDA(Vector3 JONJDHHMABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBCA0", Offset = "0x5DCB0A0", VA = "0x185DCBCA0")]
	private Vector3 IJPLOEOEKLF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA580", Offset = "0x5DC9980", VA = "0x185DCA580")]
	private void AMOFMAFLFJH(Vector3 EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB540", Offset = "0x5DCA940", VA = "0x185DCB540")]
	private void FFBIIJHLDCO(Vector3 CCEKBJKHCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC930", Offset = "0x5DCBD30", VA = "0x185DCC930")]
	private void MBGOHJIKGGO(Vector3 IGPNCMNEFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCD60", Offset = "0x5DCC160", VA = "0x185DCCD60")]
	private void OKINCOCCDJC(string CJMKGEHAHPL, Vector3 EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB2F0", Offset = "0x5DCA6F0", VA = "0x185DCB2F0")]
	private void DOGLPLLIMEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class PIDDMNIFOMI : GIKDLPOMOCJ, JHNGOMGDEDF
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public float HKLMIAEJNHI
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B1D0", Offset = "0x6F5A5D0", VA = "0x186F5B1D0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B4A0", Offset = "0x6F5A8A0", VA = "0x186F5B4A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public float IJDPOHFHBBB
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B070", Offset = "0x6F5A470", VA = "0x186F5B070", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B610", Offset = "0x6F5AA10", VA = "0x186F5B610", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6F57DE0", Offset = "0x6F571E0", VA = "0x186F57DE0")]
	public PIDDMNIFOMI(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B2C0", Offset = "0x6F5A6C0", VA = "0x186F5B2C0", Slot = "8")]
	public void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B160", Offset = "0x6F5A560", VA = "0x186F5B160", Slot = "9")]
	public void GALMCDGHJPP(Rigidbody GFKPNFPKDAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[UnityEngine.Scripting.Preserve]
public sealed class NIGIGCDGHPO : HNCADDKEFCL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly NIGIGCDGHPO BGHJOACDLLH;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public Rigidbody ANMFOPKOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyEx NBEPNPBGJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public GameObject NKPLLMLEPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public Transform LIOPMIPOJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B00", Offset = "0x7F7F00", VA = "0x1807F8B00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public IEnumerable<object> DBLEKOCAHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public HNCADDKEFCL GCKCFOBIHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x7F83B0", Offset = "0x7F77B0", VA = "0x1807F83B0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x85D510", Offset = "0x85C910", VA = "0x18085D510", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IReadOnlyList<HNCADDKEFCL> MNOGMALHBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1740", Offset = "0x7F0B40", VA = "0x1807F1740", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public HNCADDKEFCL GILDPEKDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x809410", Offset = "0x808810", VA = "0x180809410", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool AMFPPNFBIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xF30160", Offset = "0xF2F560", VA = "0x180F30160", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool LIPNNMGAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x880E50", Offset = "0x880250", VA = "0x180880E50", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool POEKINHIMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xF301A0", Offset = "0xF2F5A0", VA = "0x180F301A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public CLNMMGNFNHK LJFGAKJBGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x854AB0", Offset = "0x853EB0", VA = "0x180854AB0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x89EBC0", Offset = "0x89DFC0", VA = "0x18089EBC0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public CIICDJONOMO AMPFADHGNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x89EC90", Offset = "0x89E090", VA = "0x18089EC90", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x89EBD0", Offset = "0x89DFD0", VA = "0x18089EBD0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public float MCGDKOEGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x1C1D0A0", Offset = "0x1C1C4A0", VA = "0x181C1D0A0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x14AA770", Offset = "0x14A9B70", VA = "0x1814AA770", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Vector3 JMEHDDALPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x30E0E30", Offset = "0x30E0230", VA = "0x1830E0E30", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x30E4640", Offset = "0x30E3A40", VA = "0x1830E4640", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Vector3 DFOGIPNDFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x23FE670", Offset = "0x23FDA70", VA = "0x1823FE670", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x23FA680", Offset = "0x23F9A80", VA = "0x1823FA680", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Vector3 CCECFEDOHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x23FE690", Offset = "0x23FDA90", VA = "0x1823FE690", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x23FAD60", Offset = "0x23FA160", VA = "0x1823FAD60", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 JCLOPKLIDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x7F70D0", Offset = "0x7F64D0", VA = "0x1807F70D0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool GEJCCHIKEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x101CA70", Offset = "0x101BE70", VA = "0x18101CA70", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public bool CPNJCBJMDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x1077160", Offset = "0x1076560", VA = "0x181077160", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool LANMDJKFPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x1077150", Offset = "0x1076550", VA = "0x181077150", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool NFBJNCIJOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xDED400", Offset = "0xDEC800", VA = "0x180DED400", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Vector3 FEGMNDFJJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x219AF10", Offset = "0x219A310", VA = "0x18219AF10", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Vector3 CPPDMGIDLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x23203A0", Offset = "0x231F7A0", VA = "0x1823203A0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 FCENJNKLLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7F70D0", Offset = "0x7F64D0", VA = "0x1807F70D0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 PGCNAIKHOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x2163FC0", Offset = "0x21633C0", VA = "0x182163FC0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public float FLGPCIIOBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x128A2E0", Offset = "0x12896E0", VA = "0x18128A2E0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public float KIMEKCFKEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x17D7030", Offset = "0x17D6430", VA = "0x1817D7030", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Vector3 DPMPNPGFKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7F70D0", Offset = "0x7F64D0", VA = "0x1807F70D0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public Quaternion IEOFMJCGDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CC0", Offset = "0x7F20C0", VA = "0x1807F2CC0", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public float HKLMIAEJNHI
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x17D7030", Offset = "0x17D6430", VA = "0x1817D7030", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public float IJDPOHFHBBB
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x17D7030", Offset = "0x17D6430", VA = "0x1817D7030", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool LFILBCFKBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool HMFCGFJBOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public POPMGKKDDGN ELOLKHBOKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "51")]
		get
		{
			return default(POPMGKKDDGN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool EGICHPNLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x3260EA0", Offset = "0x32602A0", VA = "0x183260EA0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public Transform ADDLMMKPJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xAA2C60", Offset = "0xAA2060", VA = "0x180AA2C60", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Transform ONBHBBGKOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA26E60", Offset = "0xA26260", VA = "0x180A26E60", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 JFODMGHNGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7F70D0", Offset = "0x7F64D0", VA = "0x1807F70D0", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public float KNPPLOABHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x17D7030", Offset = "0x17D6430", VA = "0x1817D7030", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public float NOHOOMPLHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x17D7030", Offset = "0x17D6430", VA = "0x1817D7030", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public Quaternion FIAPKFGJCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x1A3C720", Offset = "0x1A3BB20", VA = "0x181A3C720", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 EFLKGNHAIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7F70D0", Offset = "0x7F64D0", VA = "0x1807F70D0", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Quaternion EPEMEPHGANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1A3C720", Offset = "0x1A3BB20", VA = "0x181A3C720", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public RigidbodyConstraints FHGJPBBDFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7F1D90", Offset = "0x7F1190", VA = "0x1807F1D90", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool KHGMFABOOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public CollisionDetectionMode FANAAAEAKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1D90", Offset = "0x7F1190", VA = "0x1807F1D90", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool HHFNLAJOPDF
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1CAA7D0", Offset = "0x1CA9BD0", VA = "0x181CAA7D0", Slot = "74")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool NPIOKLFPNGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "133")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event MIKHCFECODK OOBNDOHGDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "80")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "81")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event MIKHCFECODK KOKPFOIFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event NNKKEOCOMJB IDJGLLKNKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "84")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "85")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event MIKHCFECODK DLHBKIECPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "87")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "88")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event MIKHCFECODK GKHIKMJMNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event MIKHCFECODK GGMPDBAHIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "112")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "113")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<HKONAAAPIJN, HKONAAAPIJN> GBKHCJFHMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "116")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "117")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event MIKHCFECODK BLLEHHOJICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "118")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "119")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event MIKHCFECODK DBJIIOMEEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "124")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "125")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "44")]
	public void BKPAIKLAHNP((Quaternion rot, Vector3 moments) IMLBEEHPEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "75")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "76")]
	public void ECAGCNFHBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "77")]
	public void GPFGCELEJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "78")]
	public void JDFKOJKPINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "79")]
	public void IBHAOAOIGOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "86")]
	public void PPONGLALHNF(HNCADDKEFCL EOEKGHMNIDN, bool LAPMPFOBPLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "89")]
	public void JIFCKNJDBDB(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "90")]
	public void IFGJBFKAEIF(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x7F70D0", Offset = "0x7F64D0", VA = "0x1807F70D0", Slot = "91")]
	public Vector3 PNIDAHMAOMO(Vector3 MLIHKCLPMIC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x7F70D0", Offset = "0x7F64D0", VA = "0x1807F70D0", Slot = "92")]
	public Vector3 NNBHMNHBLHK(Vector3 JONJDHHMABD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "93")]
	public void KAEOGPGNKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "94")]
	public void HNANFLOOICJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "95")]
	public void AGJLHOENOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "96")]
	public void BHONDBKKIPH(Vector3 ELOPNDOJDBP, Vector3 OMEKBFHJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "97")]
	public void DHODHCKLIJJ(Vector3 HKJGAFDNPCB, Vector3 MADECJFHGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "98")]
	public void JOFPDCAHJDI(Vector3 AIHNFDGGKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "99")]
	public void LCLPMDJEHJP(IHAJHGLLODM NIMFHBNDLJE, Vector3 KFEGEPPHIAJ, float FMDJMILNIFE, float BGKJPFEMPDM = 8f, float NKDCMOIFBFO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "100")]
	public void OLEJKMPDNHI(DCHGNBAICFJ IEOFODKJLHF, Vector3 MNNPNKKFOML, float APDOAPPOFCC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "101")]
	public void DFPHMCCPDCG(DCHGNBAICFJ IEOFODKJLHF, Vector3 FKJONOBDEOA, float NKDFOLBGEBG = 7f, float ONGDPDONLHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7F70D0", Offset = "0x7F64D0", VA = "0x1807F70D0", Slot = "102")]
	public Vector3 OMEPCLINFOB(Vector3 EOEKGHMNIDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x7F70D0", Offset = "0x7F64D0", VA = "0x1807F70D0", Slot = "103")]
	public Vector3 OKAAEINDKGD(Vector3 EOEKGHMNIDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "104")]
	public void PPIMFLMMADH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "105")]
	public void CEIIFEDEPJD(HNCADDKEFCL CDAJNGFOAON, object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "106")]
	public void CDOMPAEOHGK(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "109")]
	public void PDJPGKOMEMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "110")]
	public void IEHFPDAHNFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "111")]
	public void CONKKKNIKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "114")]
	public bool JGHPGIPHPGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "115")]
	public void BHMLJGCOHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D90", Offset = "0x7F1190", VA = "0x1807F1D90", Slot = "120")]
	public IDisposable IJCEPKOJMCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "121")]
	public void OOFMCOFCPPI(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "122")]
	public void HDGPIOKEHKN(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "123")]
	public void MDBEAPEPGAK(object IJNLJGNNJFA, bool HLALGAMPNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "126")]
	public void NHAHEPBEJCP(Vector3 EMIPGJANDGN, Quaternion OHBIGCJPLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "127")]
	public void GINFNLJKKKF(Vector3 LGFAFJOBNGM, Quaternion OEIEMLHEENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "128")]
	public bool KCFGOGMKAPP(float LDKNCAHIPED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "129")]
	public void CMJLIFKFMLH(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "130")]
	public void GELKKMEMHGK(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "131")]
	public void DFAGECHNENN(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "132")]
	public void FOPJGGNMGEC(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "134")]
	public void CGIMEPNJNED(Vector3 BLLAAOPKLPH, ForceMode JIPBPFDLGAD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "135")]
	public void GAMHPGDDCEC(Vector3 BLLAAOPKLPH, Vector3 FLBOBIODIJO, ForceMode JIPBPFDLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "136")]
	public void LLJCDDNBOOL(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "137")]
	public void DCEOLPLPMFG(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE230", Offset = "0x5DCD630", VA = "0x185DCE230", Slot = "138")]
	public bool EHNGMCAIOPF(Vector3 EPJPJGLJENE, out RaycastHit NFPNFECBHMA, float NCEKMHDDCCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "139")]
	public void LMOFLFBKNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public NIGIGCDGHPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class KLCBOIIEJPF : GIKDLPOMOCJ, OOOFALFOHIF
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 FEGMNDFJJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3500", Offset = "0x5DC2900", VA = "0x185DC3500", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 CPPDMGIDLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2CA0", Offset = "0x5DC20A0", VA = "0x185DC2CA0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private Vector3 CCECFEDOHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2BC0", Offset = "0x5DC1FC0", VA = "0x185DC2BC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private HNCADDKEFCL GJAGIJHOJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2EE0", Offset = "0x5DC22E0", VA = "0x185DC2EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5DACA50", Offset = "0x5DABE50", VA = "0x185DACA50")]
	public KLCBOIIEJPF(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3660", Offset = "0x5DC2A60", VA = "0x185DC3660", Slot = "6")]
	public void PLHPBOOBFBI(HNCADDKEFCL MOHMMJFCOKF, object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3530", Offset = "0x5DC2930", VA = "0x185DC3530")]
	private void PLHPBOOBFBI(LKDEPBFOBJJ MOHMMJFCOKF, object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3410", Offset = "0x5DC2810", VA = "0x185DC3410", Slot = "7")]
	public void NCAJDBMABBB(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3040", Offset = "0x5DC2440", VA = "0x185DC3040")]
	private Vector3 MHMPDHCFJFL()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class CCKEBJHDGMC
{
	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4620", Offset = "0x5DB3A20", VA = "0x185DB4620")]
	public static KLCBOIIEJPF LOBGLJJNGEN(this HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class NKLHHBOHKJD : GIKDLPOMOCJ, KAKAJECMEFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly NDPMEMNFALO OEMJHPENJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly OHHNLMJHLHH PCNFECANCCE;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private Transform LIOPMIPOJEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF030", Offset = "0x5DCE430", VA = "0x185DCF030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public IMDEFFNCIAA AJPDGAPFGNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF950", Offset = "0x5DCED50", VA = "0x185DCF950")]
		get
		{
			return default(IMDEFFNCIAA);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFCE0", Offset = "0x5DCF0E0", VA = "0x185DCFCE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public HNCADDKEFCL GCKCFOBIHPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE740", Offset = "0x5DCDB40", VA = "0x185DCE740", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5DCEF20", Offset = "0x5DCE320", VA = "0x185DCEF20", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public IMDEFFNCIAA DEBMEACPILB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5DCED80", Offset = "0x5DCE180", VA = "0x185DCED80")]
		get
		{
			return default(IMDEFFNCIAA);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5DCEC80", Offset = "0x5DCE080", VA = "0x185DCEC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public HNCADDKEFCL GILDPEKDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF910", Offset = "0x5DCED10", VA = "0x185DCF910", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public IReadOnlyList<HNCADDKEFCL> MNOGMALHBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x89EC90", Offset = "0x89E090", VA = "0x18089EC90", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event MIKHCFECODK OOBNDOHGDCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0340", Offset = "0x5DCF740", VA = "0x185DD0340", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE6A0", Offset = "0x5DCDAA0", VA = "0x185DCE6A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event MIKHCFECODK KOKPFOIFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x5DCEE80", Offset = "0x5DCE280", VA = "0x185DCEE80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5DCEB40", Offset = "0x5DCDF40", VA = "0x185DCEB40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event NNKKEOCOMJB IDJGLLKNKAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFBA0", Offset = "0x5DCEFA0", VA = "0x185DCFBA0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF870", Offset = "0x5DCEC70", VA = "0x185DCF870", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event Action GPDCKMBDJJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x5DD02A0", Offset = "0x5DCF6A0", VA = "0x185DD02A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5DCEF90", Offset = "0x5DCE390", VA = "0x185DCEF90", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event Action FCEHNKNEBCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFA50", Offset = "0x5DCEE50", VA = "0x185DCFA50", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF060", Offset = "0x5DCE460", VA = "0x185DCF060", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event Action<HNCADDKEFCL> BNAHCBHAJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE3A0", Offset = "0x5DCD7A0", VA = "0x185DCE3A0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x5DCEBE0", Offset = "0x5DCDFE0", VA = "0x185DCEBE0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event Action<HNCADDKEFCL> CFNFBEKMOCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFFA0", Offset = "0x5DCF3A0", VA = "0x185DCFFA0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0040", Offset = "0x5DCF440", VA = "0x185DD0040", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event Action IIHHCIPDGCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFC40", Offset = "0x5DCF040", VA = "0x185DCFC40", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF7D0", Offset = "0x5DCEBD0", VA = "0x185DCF7D0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event Action<HNCADDKEFCL> HFPIBPICLHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5DD04B0", Offset = "0x5DCF8B0", VA = "0x185DD04B0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF100", Offset = "0x5DCE500", VA = "0x185DCF100", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06D0", Offset = "0x5DCFAD0", VA = "0x185DD06D0")]
	public NKLHHBOHKJD(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE970", Offset = "0x5DCDD70", VA = "0x185DCE970", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0550", Offset = "0x5DCF950", VA = "0x185DD0550", Slot = "26")]
	public void PPONGLALHNF(HNCADDKEFCL OFEIPHKKILF, bool LAPMPFOBPLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DD05D0", Offset = "0x5DCF9D0", VA = "0x185DD05D0")]
	private void PPONGLALHNF(LKDEPBFOBJJ OFEIPHKKILF, bool LAPMPFOBPLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF1A0", Offset = "0x5DCE5A0", VA = "0x185DCF1A0")]
	private void IOFJEHBFGMF(LKDEPBFOBJJ OFEIPHKKILF, bool LAPMPFOBPLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DD00E0", Offset = "0x5DCF4E0", VA = "0x185DD00E0")]
	private void PAALPLFAFCK(LKDEPBFOBJJ FJLPEDHEFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFDE0", Offset = "0x5DCF1E0", VA = "0x185DCFDE0")]
	private void NJJKDNIJHMG(LKDEPBFOBJJ FJLPEDHEFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE780", Offset = "0x5DCDB80", VA = "0x185DCE780")]
	private void DMOFFMNEFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DD03E0", Offset = "0x5DCF7E0", VA = "0x185DD03E0")]
	private void PJHNJNGCBLL(LKDEPBFOBJJ FJLPEDHEFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFAF0", Offset = "0x5DCEEF0", VA = "0x185DCFAF0")]
	private void LDBNAEHNMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE570", Offset = "0x5DCD970", VA = "0x185DCE570")]
	private void CHLDIHBNOLG(LKDEPBFOBJJ LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE440", Offset = "0x5DCD840", VA = "0x185DCE440")]
	private void CCGGLNOKPGD(LKDEPBFOBJJ LKJACCKKHID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class NEGGOGANLAB
{
	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE1A0", Offset = "0x5DCD5A0", VA = "0x185DCE1A0")]
	public static NKLHHBOHKJD ENBFKHIFKEF(this HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class LKDEPBFOBJJ : IBFGKBDICBN, LBFGBCDJPKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	internal IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal IIAPALOEFIB ADJKCJGGGMA;

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9830", Offset = "0x5DC8C30", VA = "0x185DC9830")]
	public LKDEPBFOBJJ(GameObject NJMBJKHNCBN, RigidbodyEx MNBGODGICBO, JANPOADJHGO JMAEGHAGIPP, in JALLAOKICKK KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8FC0", Offset = "0x5DC83C0", VA = "0x185DC8FC0", Slot = "143")]
	protected override void GJHBAAFKCLC(JANPOADJHGO JMAEGHAGIPP, JALLAOKICKK KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8DD0", Offset = "0x5DC81D0", VA = "0x185DC8DD0", Slot = "144")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9300", Offset = "0x5DC8700", VA = "0x185DC9300", Slot = "147")]
	public void HHPFEEGCPKF(FIJFCEOMDOA CBANDKAJFBB, FIJFCEOMDOA MJGOBCMBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9240", Offset = "0x5DC8640", VA = "0x185DC9240", Slot = "148")]
	public void HBHGNJAKFGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9530", Offset = "0x5DC8930", VA = "0x185DC9530", Slot = "149")]
	public void NDNPNEGFCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8D70", Offset = "0x5DC8170", VA = "0x185DC8D70", Slot = "150")]
	public void CIKLEGPLEEN(bool LHPPABJMNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DC93D0", Offset = "0x5DC87D0", VA = "0x185DC93D0", Slot = "151")]
	public bool LHFCLFKIBCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8F60", Offset = "0x5DC8360", VA = "0x185DC8F60", Slot = "152")]
	public void FFPMNGAJEHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "146")]
	protected override void LPHINDPMMCF(RigidbodyEx OGBFKHOJHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DC95F0", Offset = "0x5DC89F0", VA = "0x185DC95F0")]
	private void PCAHPIKACPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "145")]
	public override void IBHAOAOIGOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class FABFEIHLODN
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5D90", Offset = "0x5DB5190", VA = "0x185DB5D90")]
	public static IBFGKBDICBN GBKCBEBDFBG(this HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class ACFBEMKHIJN : GIKDLPOMOCJ, CBPAJNHEOHG
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private const string CAAKGJMAGJJ = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool JMHBFIDMOLM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0CB0", Offset = "0x5DB00B0", VA = "0x185DB0CB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public KGLFAPPIPIG KNNAMIKDJCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0F20", Offset = "0x5DB0320", VA = "0x185DB0F20", Slot = "5")]
		get
		{
			return default(KGLFAPPIPIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private KGLFAPPIPIG MPEIJIJABHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0A00", Offset = "0x5DAFE00", VA = "0x185DB0A00")]
		get
		{
			return default(KGLFAPPIPIG);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1200", Offset = "0x5DB0600", VA = "0x185DB1200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DB12F0", Offset = "0x5DB06F0", VA = "0x185DB12F0")]
	public ACFBEMKHIJN(HNCADDKEFCL LKJACCKKHID, in JALLAOKICKK KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1040", Offset = "0x5DB0440", VA = "0x185DB1040", Slot = "6")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0D90", Offset = "0x5DB0190", VA = "0x185DB0D90")]
	private bool FIPLIOOOAJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1100", Offset = "0x5DB0500", VA = "0x185DB1100", Slot = "7")]
	public void NCAFBDAHCPJ(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0900", Offset = "0x5DAFD00", VA = "0x185DB0900", Slot = "8")]
	public void AKJAKPKOAHD(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0F30", Offset = "0x5DB0330", VA = "0x185DB0F30", Slot = "11")]
	public void KKNGELFLGCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0E30", Offset = "0x5DB0230", VA = "0x185DB0E30")]
	private void FPFJNKLGFAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0B20", Offset = "0x5DAFF20", VA = "0x185DB0B20")]
	private void DLCIDNENMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0AE0", Offset = "0x5DAFEE0", VA = "0x185DB0AE0", Slot = "10")]
	public void BDLGBLALMBG(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DB08C0", Offset = "0x5DAFCC0", VA = "0x185DB08C0", Slot = "9")]
	public void AGNNJPCOBEL(HNCADDKEFCL LKJACCKKHID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class AAAKHBLOHCG : GIKDLPOMOCJ, BIFJOJANGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private Rigidbody ANMFOPKOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC230", Offset = "0x5DAB630", VA = "0x185DAC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private bool EGICHPNLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5DABAB0", Offset = "0x5DAAEB0", VA = "0x185DABAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private bool AMFPPNFBIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC7A0", Offset = "0x5DABBA0", VA = "0x185DAC7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private HNCADDKEFCL GCKCFOBIHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC1D0", Offset = "0x5DAB5D0", VA = "0x185DAC1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DACA50", Offset = "0x5DABE50", VA = "0x185DACA50")]
	public AAAKHBLOHCG(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5DABB00", Offset = "0x5DAAF00", VA = "0x185DABB00", Slot = "4")]
	public void CGIMEPNJNED(Vector3 BLLAAOPKLPH, ForceMode JIPBPFDLGAD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5DABEE0", Offset = "0x5DAB2E0", VA = "0x185DABEE0")]
	private void DDCEPEMJDCE(Vector3 BLLAAOPKLPH, ForceMode JIPBPFDLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC280", Offset = "0x5DAB680", VA = "0x185DAC280", Slot = "5")]
	public void GAMHPGDDCEC(Vector3 BLLAAOPKLPH, Vector3 FLBOBIODIJO, ForceMode JIPBPFDLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC800", Offset = "0x5DABC00", VA = "0x185DAC800", Slot = "6")]
	public void LLJCDDNBOOL(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC520", Offset = "0x5DAB920", VA = "0x185DAC520")]
	private void GHJKLPCPEAM(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5DABC60", Offset = "0x5DAB060", VA = "0x185DABC60", Slot = "7")]
	public void DCEOLPLPMFG(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC960", Offset = "0x5DABD60", VA = "0x185DAC960")]
	private void OGCEGKIJJAP(string HGJOENLBDNH, UnityEngine.Object GEKPLLKAIKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class PLHNLBIMKIG : GIKDLPOMOCJ, FIJNONMINBM
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private const string KECGCNMANEA = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Rigidbody ANMFOPKOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x6F5BA10", Offset = "0x6F5AE10", VA = "0x186F5BA10", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5BC00", Offset = "0x6F5B000", VA = "0x186F5BC00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private bool AMFPPNFBIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x6F5BD00", Offset = "0x6F5B100", VA = "0x186F5BD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool NPIOKLFPNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x6F5BEB0", Offset = "0x6F5B2B0", VA = "0x186F5BEB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C6D0", Offset = "0x6F5BAD0", VA = "0x186F5C6D0")]
	public PLHNLBIMKIG(HNCADDKEFCL LKJACCKKHID, in JALLAOKICKK KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BFA0", Offset = "0x6F5B3A0", VA = "0x186F5BFA0", Slot = "5")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B910", Offset = "0x6F5AD10", VA = "0x186F5B910", Slot = "7")]
	public void DFAGECHNENN(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BB00", Offset = "0x6F5AF00", VA = "0x186F5BB00", Slot = "8")]
	public void FOPJGGNMGEC(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C480", Offset = "0x6F5B880", VA = "0x186F5C480", Slot = "9")]
	public void PKKAGCKLDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C220", Offset = "0x6F5B620", VA = "0x186F5C220", Slot = "10")]
	public void PFACLNMJOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C050", Offset = "0x6F5B450", VA = "0x186F5C050", Slot = "11")]
	public void NCCLGOADJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "12")]
	public void IBDKNHGDBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BD20", Offset = "0x6F5B120", VA = "0x186F5BD20")]
	private void LLKBNFPFADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B780", Offset = "0x6F5AB80", VA = "0x186F5B780")]
	private void BKCGAEKHDPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class MBFHAKJPEIC : GIKDLPOMOCJ, BIKICKEFOFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool EGICHPNLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9840", Offset = "0x5DC8C40", VA = "0x185DC9840", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public IEnumerable<object> OMNDHIMBMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9BA0", Offset = "0x5DC8FA0", VA = "0x185DC9BA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private bool EIBAMCOAGMK
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA000", Offset = "0x5DC9400", VA = "0x185DCA000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event MIKHCFECODK BLLEHHOJICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9E60", Offset = "0x5DC9260", VA = "0x185DC9E60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9920", Offset = "0x5DC8D20", VA = "0x185DC9920", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x5DACA50", Offset = "0x5DABE50", VA = "0x185DACA50")]
	public MBFHAKJPEIC(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9E00", Offset = "0x5DC9200", VA = "0x185DC9E00", Slot = "12")]
	public IDisposable IJCEPKOJMCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA0E0", Offset = "0x5DC94E0", VA = "0x185DCA0E0", Slot = "9")]
	public void OOFMCOFCPPI(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9DF0", Offset = "0x5DC91F0", VA = "0x185DC9DF0", Slot = "10")]
	public void HDGPIOKEHKN(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9F00", Offset = "0x5DC9300", VA = "0x185DC9F00", Slot = "11")]
	public void MDBEAPEPGAK(object IJNLJGNNJFA, bool HLALGAMPNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9C80", Offset = "0x5DC9080", VA = "0x185DC9C80", Slot = "13")]
	public void HDGIJJBLDBO(Rigidbody OHFFPKCPFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5DC99C0", Offset = "0x5DC8DC0", VA = "0x185DC99C0", Slot = "14")]
	public void GALMCDGHJPP(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF330", Offset = "0x5DAE730", VA = "0x185DAF330", Slot = "6")]
	public void IBPPLFAOFGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class DDNLHLPECNM : GIKDLPOMOCJ, FBHHEECMAOI
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private CollisionDetectionMode FEJEAJPBMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x5DB46B0", Offset = "0x5DB3AB0", VA = "0x185DB46B0")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4E50", Offset = "0x5DB4250", VA = "0x185DB4E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private Rigidbody ANMFOPKOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC230", Offset = "0x5DAB630", VA = "0x185DAC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public CollisionDetectionMode FANAAAEAKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4A20", Offset = "0x5DB3E20", VA = "0x185DB4A20", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4790", Offset = "0x5DB3B90", VA = "0x185DB4790", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5DACA50", Offset = "0x5DABE50", VA = "0x185DACA50")]
	public DDNLHLPECNM(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4B30", Offset = "0x5DB3F30", VA = "0x185DB4B30", Slot = "6")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4990", Offset = "0x5DB3D90", VA = "0x185DB4990", Slot = "9")]
	public void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4E40", Offset = "0x5DB4240", VA = "0x185DB4E40", Slot = "7")]
	public void PDMDJFGJIDK(bool LMHKIOMKPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4980", Offset = "0x5DB3D80", VA = "0x185DB4980", Slot = "8")]
	public void GIPOGJKIAPI(bool LMHKIOMKPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4810", Offset = "0x5DB3C10", VA = "0x185DB4810", Slot = "10")]
	public bool EHNGMCAIOPF(Vector3 EPJPJGLJENE, out RaycastHit NFPNFECBHMA, float NCEKMHDDCCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4C40", Offset = "0x5DB4040", VA = "0x185DB4C40")]
	private void OABHJNOBFAL(bool LMHKIOMKPEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public sealed class OHHNLMJHLHH : IReadOnlyList<HNCADDKEFCL>, IEnumerable<HNCADDKEFCL>, IEnumerable, IReadOnlyCollection<HNCADDKEFCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly IIAPALOEFIB EHCALDODJBD;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6F57FE0", Offset = "0x6F573E0", VA = "0x186F57FE0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public HNCADDKEFCL KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x6F580B0", Offset = "0x6F574B0", VA = "0x186F580B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x6F57F90", Offset = "0x6F57390", VA = "0x186F57F90")]
	public OHHNLMJHLHH(IMDEFFNCIAA DPIBKMGPGEE, IIAPALOEFIB EHCALDODJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6F57E00", Offset = "0x6F57200", VA = "0x186F57E00", Slot = "6")]
	public IEnumerator<HNCADDKEFCL> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6F57E00", Offset = "0x6F57200", VA = "0x186F57E00", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6F57DF0", Offset = "0x6F571F0", VA = "0x186F57DF0")]
	[CompilerGenerated]
	private HNCADDKEFCL DKNNMACDHOB(int GGGLLOBDBOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class BPOHPEAJGIJ : ACNLDECGDAI
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5DB42B0", Offset = "0x5DB36B0", VA = "0x185DB42B0", Slot = "4")]
	public KAKAJECMEFH MAFLDFMPBGL(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4580", Offset = "0x5DB3980", VA = "0x185DB4580", Slot = "5")]
	public PNDBILPOCAL PBOHFIDDIHF(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4210", Offset = "0x5DB3610", VA = "0x185DB4210", Slot = "6")]
	public OOOFALFOHIF LNIPLIIGKJH(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5DB40A0", Offset = "0x5DB34A0", VA = "0x185DB40A0", Slot = "7")]
	public JHNGOMGDEDF GHJIMMFBNCH(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4040", Offset = "0x5DB3440", VA = "0x185DB4040", Slot = "8")]
	public ABAMFAEIDNO EOOHFODGDME(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4480", Offset = "0x5DB3880", VA = "0x185DB4480", Slot = "9")]
	public PPIJHNBKLMK OFENOFKEBFE(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB44E0", Offset = "0x5DB38E0", VA = "0x185DB44E0", Slot = "10")]
	public BIKICKEFOFJ PAFFCILGION(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3BE0", Offset = "0x5DB2FE0", VA = "0x185DB3BE0", Slot = "11")]
	public BIFJOJANGIA AOIJIMCDNHL(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4100", Offset = "0x5DB3500", VA = "0x185DB4100", Slot = "12")]
	public FBHHEECMAOI INMNIJHIDBN(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3C80", Offset = "0x5DB3080", VA = "0x185DB3C80", Slot = "13")]
	public MHLMOEPKKCN BCPDJOFALLA(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3B70", Offset = "0x5DB2F70", VA = "0x185DB3B70")]
	public FIJNONMINBM DKOPFLAILKM(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5DB41A0", Offset = "0x5DB35A0", VA = "0x185DB41A0")]
	public GFMMGHEHOCP JCEMNEJKPJD(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3EB0", Offset = "0x5DB32B0", VA = "0x185DB3EB0")]
	public CBPAJNHEOHG OCMIFDBNEBL(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3D20", Offset = "0x5DB3120", VA = "0x185DB3D20")]
	public DLEOKLGAEFK CDBAOOCICIC(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3E40", Offset = "0x5DB3240", VA = "0x185DB3E40")]
	public FKIFKCOAGDD NHHCIGFPOBB(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3D90", Offset = "0x5DB3190", VA = "0x185DB3D90", Slot = "19")]
	public HNCADDKEFCL DBCPEBLAANN(RigidbodyEx LKJACCKKHID, JALLAOKICKK KOCKBILIHNN, JANPOADJHGO JMAEGHAGIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public BPOHPEAJGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3B70", Offset = "0x5DB2F70", VA = "0x185DB3B70", Slot = "14")]
	private FIJNONMINBM AMLPPDHAHAP(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5DB41A0", Offset = "0x5DB35A0", VA = "0x185DB41A0", Slot = "15")]
	private GFMMGHEHOCP PIEBDEPNFNK(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3EB0", Offset = "0x5DB32B0", VA = "0x185DB3EB0", Slot = "16")]
	private CBPAJNHEOHG EHPJLGOHLCP(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3D20", Offset = "0x5DB3120", VA = "0x185DB3D20", Slot = "17")]
	private DLEOKLGAEFK KPDFBBGLOPL(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3E40", Offset = "0x5DB3240", VA = "0x185DB3E40", Slot = "18")]
	private FKIFKCOAGDD EEEFCBJMMBA(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class GKOCIELNILB : GIKDLPOMOCJ, ABAMFAEIDNO
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public const int BHCNKPFPFCN = 10;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public const float FIPAJGOAFHO = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public const float LJACIMJODHF = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public const float MAFHBCMOIPH = 5f;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody ANMFOPKOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC230", Offset = "0x5DAB630", VA = "0x185DAC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private bool DGPFLCKMPND
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB85A0", Offset = "0x5DB79A0", VA = "0x185DB85A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private bool CIKGJKFBIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7B30", Offset = "0x5DB6F30", VA = "0x185DB7B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private HNCADDKEFCL GCKCFOBIHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7820", Offset = "0x5DB6C20", VA = "0x185DB7820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool AMFPPNFBIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7BF0", Offset = "0x5DB6FF0", VA = "0x185DB7BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool IELDCOMBEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7960", Offset = "0x5DB6D60", VA = "0x185DB7960")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8400", Offset = "0x5DB7800", VA = "0x185DB8400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool NFAELAAKELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7A50", Offset = "0x5DB6E50", VA = "0x185DB7A50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8070", Offset = "0x5DB7470", VA = "0x185DB8070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private int KPPPJOFJCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7880", Offset = "0x5DB6C80", VA = "0x185DB7880")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8310", Offset = "0x5DB7710", VA = "0x185DB8310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event MIKHCFECODK GGMPDBAHIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7B50", Offset = "0x5DB6F50", VA = "0x185DB7B50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB76D0", Offset = "0x5DB6AD0", VA = "0x185DB76D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8640", Offset = "0x5DB7A40", VA = "0x185DB8640")]
	public GKOCIELNILB(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB84F0", Offset = "0x5DB78F0", VA = "0x185DB84F0", Slot = "6")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7A40", Offset = "0x5DB6E40", VA = "0x185DB7A40", Slot = "8")]
	public void DHAKKDLFDJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7E50", Offset = "0x5DB7250", VA = "0x185DB7E50", Slot = "7")]
	public bool JGHPGIPHPGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7DA0", Offset = "0x5DB71A0", VA = "0x185DB7DA0", Slot = "9")]
	public void JDFKOJKPINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF330", Offset = "0x5DAE730", VA = "0x185DAF330", Slot = "12")]
	public void CIKLEGPLEEN(bool LHPPABJMNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7770", Offset = "0x5DB6B70", VA = "0x185DB7770", Slot = "11")]
	public void BHMLJGCOHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "10")]
	public void PGAFCJHFMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8160", Offset = "0x5DB7560", VA = "0x185DB8160")]
	private bool KNJNPLPGCNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7C50", Offset = "0x5DB7050", VA = "0x185DB7C50")]
	private void IONJPLKCNDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[DGOAMDMMJCP(typeof(ACNLDECGDAI), new string[] { })]
public class NMENKOCMJDF : ACNLDECGDAI, LCECMPMAFGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly ACNLDECGDAI JBMHFAMDOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly ACNLDECGDAI AFMDAKEBNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private PNEBECAEHNN KGFLHNMDGLK;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private ACNLDECGDAI BLJPMOJDMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x6F571D0", Offset = "0x6F565D0", VA = "0x186F571D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6F57370", Offset = "0x6F56770", VA = "0x186F57370", Slot = "20")]
	public void InitReferences(INPLDICFFFN LOBBJNOOMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6F57510", Offset = "0x6F56910", VA = "0x186F57510", Slot = "4")]
	public KAKAJECMEFH MAFLDFMPBGL(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6F576F0", Offset = "0x6F56AF0", VA = "0x186F576F0", Slot = "5")]
	public PNDBILPOCAL PBOHFIDDIHF(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6F57470", Offset = "0x6F56870", VA = "0x186F57470", Slot = "6")]
	public OOOFALFOHIF LNIPLIIGKJH(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6F57230", Offset = "0x6F56630", VA = "0x186F57230", Slot = "7")]
	public JHNGOMGDEDF GHJIMMFBNCH(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6F57130", Offset = "0x6F56530", VA = "0x186F57130", Slot = "8")]
	public ABAMFAEIDNO EOOHFODGDME(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6F575B0", Offset = "0x6F569B0", VA = "0x186F575B0", Slot = "9")]
	public PPIJHNBKLMK OFENOFKEBFE(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6F57650", Offset = "0x6F56A50", VA = "0x186F57650", Slot = "10")]
	public BIKICKEFOFJ PAFFCILGION(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6F56C90", Offset = "0x6F56090", VA = "0x186F56C90", Slot = "11")]
	public BIFJOJANGIA AOIJIMCDNHL(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6F572D0", Offset = "0x6F566D0", VA = "0x186F572D0", Slot = "12")]
	public FBHHEECMAOI INMNIJHIDBN(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6F56D30", Offset = "0x6F56130", VA = "0x186F56D30", Slot = "13")]
	public MHLMOEPKKCN BCPDJOFALLA(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6F56BE0", Offset = "0x6F55FE0", VA = "0x186F56BE0")]
	public FIJNONMINBM DKOPFLAILKM(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6F573C0", Offset = "0x6F567C0", VA = "0x186F573C0")]
	public GFMMGHEHOCP JCEMNEJKPJD(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6F57080", Offset = "0x6F56480", VA = "0x186F57080")]
	public CBPAJNHEOHG OCMIFDBNEBL(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6F56DD0", Offset = "0x6F561D0", VA = "0x186F56DD0")]
	public DLEOKLGAEFK CDBAOOCICIC(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6F56FD0", Offset = "0x6F563D0", VA = "0x186F56FD0")]
	public FKIFKCOAGDD NHHCIGFPOBB(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6F56E80", Offset = "0x6F56280", VA = "0x186F56E80", Slot = "19")]
	public HNCADDKEFCL DBCPEBLAANN(RigidbodyEx LKJACCKKHID, JALLAOKICKK KOCKBILIHNN, JANPOADJHGO JMAEGHAGIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6F57790", Offset = "0x6F56B90", VA = "0x186F57790")]
	public NMENKOCMJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6F56BE0", Offset = "0x6F55FE0", VA = "0x186F56BE0", Slot = "14")]
	private FIJNONMINBM AMLPPDHAHAP(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6F573C0", Offset = "0x6F567C0", VA = "0x186F573C0", Slot = "15")]
	private GFMMGHEHOCP PIEBDEPNFNK(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6F57080", Offset = "0x6F56480", VA = "0x186F57080", Slot = "16")]
	private CBPAJNHEOHG EHPJLGOHLCP(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6F56DD0", Offset = "0x6F561D0", VA = "0x186F56DD0", Slot = "17")]
	private DLEOKLGAEFK KPDFBBGLOPL(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6F56FD0", Offset = "0x6F563D0", VA = "0x186F56FD0", Slot = "18")]
	private FKIFKCOAGDD EEEFCBJMMBA(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class KEIGCJKPGDB : GIKDLPOMOCJ, MHLMOEPKKCN
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool LFILBCFKBAN
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x5DC24D0", Offset = "0x5DC18D0", VA = "0x185DC24D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x5DC26B0", Offset = "0x5DC1AB0", VA = "0x185DC26B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5DACA50", Offset = "0x5DABE50", VA = "0x185DACA50")]
	public KEIGCJKPGDB(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC25B0", Offset = "0x5DC19B0", VA = "0x185DC25B0", Slot = "6")]
	public void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA240", Offset = "0x5DB9640", VA = "0x185DBA240", Slot = "7")]
	public void GALMCDGHJPP(Rigidbody GFKPNFPKDAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class GIKDLPOMOCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	protected readonly LKDEPBFOBJJ LKJACCKKHID;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	protected IIAPALOEFIB AKHBMFINDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1018E20", Offset = "0x1018220", VA = "0x181018E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	protected IMDEFFNCIAA JDLIOANHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7580", Offset = "0x5DB6980", VA = "0x185DB7580")]
		get
		{
			return default(IMDEFFNCIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5DACA50", Offset = "0x5DABE50", VA = "0x185DACA50")]
	public GIKDLPOMOCJ(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5DB75B0", Offset = "0x5DB69B0", VA = "0x185DB75B0")]
	protected HNCADDKEFCL FIGAMECFCGI(IMDEFFNCIAA DPIBKMGPGEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class PEBHMFBFEAN : GIKDLPOMOCJ, GFMMGHEHOCP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private PhotonView EBGBBNEGBDC;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool LIPNNMGAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0CC0", Offset = "0x5DC00C0", VA = "0x185DC0CC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool POEKINHIMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6F58960", Offset = "0x6F57D60", VA = "0x186F58960", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event MIKHCFECODK DLHBKIECPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x6F58DD0", Offset = "0x6F581D0", VA = "0x186F58DD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6F582D0", Offset = "0x6F576D0", VA = "0x186F582D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x6F58F00", Offset = "0x6F58300", VA = "0x186F58F00")]
	public PEBHMFBFEAN(HNCADDKEFCL LKJACCKKHID, in JALLAOKICKK KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6F58C80", Offset = "0x6F58080", VA = "0x186F58C80", Slot = "8")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6F58600", Offset = "0x6F57A00", VA = "0x186F58600", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6F58490", Offset = "0x6F57890", VA = "0x186F58490", Slot = "9")]
	public void DGJNFHBNFIF(HNCADDKEFCL MOHMMJFCOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6F587F0", Offset = "0x6F57BF0", VA = "0x186F587F0", Slot = "10")]
	public void ELKBNPOFFKC(HNCADDKEFCL MOHMMJFCOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6F58370", Offset = "0x6F57770", VA = "0x186F58370")]
	private void CDJOJCHIDPD(PhotonView JGAHBMLPAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6F58E70", Offset = "0x6F58270", VA = "0x186F58E70")]
	private void PKDFACHPDBH(RigidbodyEx IFJJLEEFPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6F58AA0", Offset = "0x6F57EA0", VA = "0x186F58AA0")]
	private void MDDLBGKKKCD(PhotonView IMKNOOMMOOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class BPNNNAAPADN
{
	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3B10", Offset = "0x5DB2F10", VA = "0x185DB3B10")]
	public static PEBHMFBFEAN CNHBJJODPLC(this IBFGKBDICBN NBHMCHHOJCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class KCLNELBFKJN : GIKDLPOMOCJ, FKIFKCOAGDD
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool KHGMFABOOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x5DC1D00", Offset = "0x5DC1100", VA = "0x185DC1D00", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x5DC1FE0", Offset = "0x5DC13E0", VA = "0x185DC1FE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool HJECKIFELBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x5DC21B0", Offset = "0x5DC15B0", VA = "0x185DC21B0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x5DC1A10", Offset = "0x5DC0E10", VA = "0x185DC1A10")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public RigidbodyConstraints FHGJPBBDFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x5DC20D0", Offset = "0x5DC14D0", VA = "0x185DC20D0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x5DC1B00", Offset = "0x5DC0F00", VA = "0x185DC1B00", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2290", Offset = "0x5DC1690", VA = "0x185DC2290")]
	public KCLNELBFKJN(HNCADDKEFCL LKJACCKKHID, in JALLAOKICKK KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1EE0", Offset = "0x5DC12E0", VA = "0x185DC1EE0", Slot = "9")]
	public void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1DE0", Offset = "0x5DC11E0", VA = "0x185DC1DE0", Slot = "10")]
	public void GALMCDGHJPP(Rigidbody GFKPNFPKDAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class OHGNLLPJMHK : GIKDLPOMOCJ, PPIJHNBKLMK, IDisposable, HPNPMHNBHJG
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public POPMGKKDDGN GHEJCLOJKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6F57C90", Offset = "0x6F57090", VA = "0x186F57C90")]
		get
		{
			return default(POPMGKKDDGN);
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6F57960", Offset = "0x6F56D60", VA = "0x186F57960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public POPMGKKDDGN ELOLKHBOKNE
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6F57A60", Offset = "0x6F56E60", VA = "0x186F57A60", Slot = "6")]
		get
		{
			return default(POPMGKKDDGN);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F57960", Offset = "0x6F56D60", VA = "0x186F57960", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private Transform DCBILKMMPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1D90", Offset = "0x7F1190", VA = "0x1807F1D90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event Action<HKONAAAPIJN, HKONAAAPIJN> GBKHCJFHMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6F57BF0", Offset = "0x6F56FF0", VA = "0x186F57BF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6F578C0", Offset = "0x6F56CC0", VA = "0x186F578C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x6F57DE0", Offset = "0x6F571E0", VA = "0x186F57DE0")]
	public OHGNLLPJMHK(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F57D80", Offset = "0x6F57180", VA = "0x186F57D80", Slot = "11")]
	public void OnChangedDistanceBand(HKONAAAPIJN CBANDKAJFBB, HKONAAAPIJN MJGOBCMBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "12")]
	public void OnChangedVisibility(bool MNEHKJNNMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "8")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class BIHGCFPOEOO : PPIJHNBKLMK, IDisposable, HPNPMHNBHJG
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const int JIIJACMHPDI = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly IBFGKBDICBN LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private POPMGKKDDGN HCAFMNPKJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private EBIKKFJAMIG CHMPJCPHLHE;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public POPMGKKDDGN ELOLKHBOKNE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5DB31E0", Offset = "0x5DB25E0", VA = "0x185DB31E0", Slot = "6")]
		get
		{
			return default(POPMGKKDDGN);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3370", Offset = "0x5DB2770", VA = "0x185DB3370", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private Transform DCBILKMMPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3440", Offset = "0x5DB2840", VA = "0x185DB3440", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<HKONAAAPIJN, HKONAAAPIJN> GBKHCJFHMEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3460", Offset = "0x5DB2860", VA = "0x185DB3460", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3140", Offset = "0x5DB2540", VA = "0x185DB3140", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3840", Offset = "0x5DB2C40", VA = "0x185DB3840")]
	public BIHGCFPOEOO(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3560", Offset = "0x5DB2960", VA = "0x185DB3560", Slot = "8")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3320", Offset = "0x5DB2720", VA = "0x185DB3320", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3500", Offset = "0x5DB2900", VA = "0x185DB3500", Slot = "11")]
	private void KEIAKNDLJHL(HKONAAAPIJN JICNFOHOFNF, HKONAAAPIJN JOPGCOALMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "12")]
	private void GIKLMCMFOJD(bool MNEHKJNNMKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class IFGFMKBIJMH : DHJLBKFCHJP, GFMMGHEHOCP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly IBFGKBDICBN LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private PhotonView EBGBBNEGBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool BHBFGHDECCK;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public PhotonView KMPHCEHJKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool LIPNNMGAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0CC0", Offset = "0x5DC00C0", VA = "0x185DC0CC0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool POEKINHIMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xA5F540", Offset = "0xA5E940", VA = "0x180A5F540", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event MIKHCFECODK DLHBKIECPLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DC10C0", Offset = "0x5DC04C0", VA = "0x185DC10C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0670", Offset = "0x5DBFA70", VA = "0x185DC0670", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DC12D0", Offset = "0x5DC06D0", VA = "0x185DC12D0")]
	public IFGFMKBIJMH(HNCADDKEFCL LKJACCKKHID, in JALLAOKICKK KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0F70", Offset = "0x5DC0370", VA = "0x185DC0F70", Slot = "9")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0A20", Offset = "0x5DBFE20", VA = "0x185DC0A20", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0890", Offset = "0x5DBFC90", VA = "0x185DC0890", Slot = "10")]
	public void DGJNFHBNFIF(HNCADDKEFCL MOHMMJFCOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0B30", Offset = "0x5DBFF30", VA = "0x185DC0B30", Slot = "11")]
	public void ELKBNPOFFKC(HNCADDKEFCL MOHMMJFCOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0710", Offset = "0x5DBFB10", VA = "0x185DC0710")]
	private void CDJOJCHIDPD(PhotonView JGAHBMLPAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1160", Offset = "0x5DC0560", VA = "0x185DC1160")]
	private void PKDFACHPDBH(RigidbodyEx IFJJLEEFPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0CE0", Offset = "0x5DC00E0", VA = "0x185DC0CE0")]
	private void MDDLBGKKKCD(PhotonView IMKNOOMMOOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class JBFOPIDCJHJ
{
	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1950", Offset = "0x5DC0D50", VA = "0x185DC1950")]
	public static DHJLBKFCHJP CNHBJJODPLC(this HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class APAFNHPGMEJ : FIJNONMINBM
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const string KECGCNMANEA = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly IBFGKBDICBN LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly KBENAKLNOBE ADPAICPCBFN;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Rigidbody ANMFOPKOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x855AF0", Offset = "0x854EF0", VA = "0x180855AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private bool AMFPPNFBIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC7A0", Offset = "0x5DABBA0", VA = "0x185DAC7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool NPIOKLFPNGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x180BF20", Offset = "0x180B320", VA = "0x18180BF20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2450", Offset = "0x5DB1850", VA = "0x185DB2450")]
	public APAFNHPGMEJ(HNCADDKEFCL LKJACCKKHID, in JALLAOKICKK KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1CC0", Offset = "0x5DB10C0", VA = "0x185DB1CC0", Slot = "5")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1610", Offset = "0x5DB0A10", VA = "0x185DB1610", Slot = "7")]
	public void DFAGECHNENN(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1640", Offset = "0x5DB0A40", VA = "0x185DB1640", Slot = "8")]
	public void FOPJGGNMGEC(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB20F0", Offset = "0x5DB14F0", VA = "0x185DB20F0", Slot = "9")]
	public void PKKAGCKLDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1EF0", Offset = "0x5DB12F0", VA = "0x185DB1EF0", Slot = "10")]
	public void PFACLNMJOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1D70", Offset = "0x5DB1170", VA = "0x185DB1D70", Slot = "11")]
	public void NCCLGOADJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1670", Offset = "0x5DB0A70", VA = "0x185DB1670", Slot = "12")]
	public void IBDKNHGDBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1B10", Offset = "0x5DB0F10", VA = "0x185DB1B10")]
	private void LLKBNFPFADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1460", Offset = "0x5DB0860", VA = "0x185DB1460")]
	private void BKCGAEKHDPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class BKMDHNHHIMF : FKIFKCOAGDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly IBFGKBDICBN LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private RigidbodyConstraints PNEBODDKIIE;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool KHGMFABOOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x965410", Offset = "0x964810", VA = "0x180965410", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x965420", Offset = "0x964820", VA = "0x180965420", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool HJECKIFELBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x1120850", Offset = "0x111FC50", VA = "0x181120850", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x1120420", Offset = "0x111F820", VA = "0x181120420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public RigidbodyConstraints FHGJPBBDFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x856570", Offset = "0x855970", VA = "0x180856570", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB38D0", Offset = "0x5DB2CD0", VA = "0x185DB38D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3A70", Offset = "0x5DB2E70", VA = "0x185DB3A70")]
	public BKMDHNHHIMF(HNCADDKEFCL LKJACCKKHID, in JALLAOKICKK KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3A40", Offset = "0x5DB2E40", VA = "0x185DB3A40", Slot = "9")]
	public void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3A10", Offset = "0x5DB2E10", VA = "0x185DB3A10", Slot = "10")]
	public void GALMCDGHJPP(Rigidbody GFKPNFPKDAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class HFFBEPOMMIP : BIFJOJANGIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IBFGKBDICBN LKJACCKKHID;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private Rigidbody ANMFOPKOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC230", Offset = "0x5DAB630", VA = "0x185DAC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private bool EGICHPNLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DABAB0", Offset = "0x5DAAEB0", VA = "0x185DABAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private bool AMFPPNFBIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC7A0", Offset = "0x5DABBA0", VA = "0x185DAC7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private HNCADDKEFCL GCKCFOBIHPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9AD0", Offset = "0x5DB8ED0", VA = "0x185DB9AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA1B0", Offset = "0x5DB95B0", VA = "0x185DBA1B0")]
	public HFFBEPOMMIP(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9470", Offset = "0x5DB8870", VA = "0x185DB9470", Slot = "4")]
	public void CGIMEPNJNED(Vector3 BLLAAOPKLPH, ForceMode JIPBPFDLGAD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9850", Offset = "0x5DB8C50", VA = "0x185DB9850")]
	private void DDCEPEMJDCE(Vector3 BLLAAOPKLPH, ForceMode JIPBPFDLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9B30", Offset = "0x5DB8F30", VA = "0x185DB9B30", Slot = "5")]
	public void GAMHPGDDCEC(Vector3 BLLAAOPKLPH, Vector3 FLBOBIODIJO, ForceMode JIPBPFDLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA050", Offset = "0x5DB9450", VA = "0x185DBA050", Slot = "6")]
	public void LLJCDDNBOOL(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9DD0", Offset = "0x5DB91D0", VA = "0x185DB9DD0")]
	private void GHJKLPCPEAM(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DB95D0", Offset = "0x5DB89D0", VA = "0x185DB95D0", Slot = "7")]
	public void DCEOLPLPMFG(Vector3 KMGGMJOBJGB, ForceMode JIPBPFDLGAD = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class DJBMLLLEBIN : JDELEGAPDIL, OOOFALFOHIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IBFGKBDICBN LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly global::JEAOMHICMNN<HNCADDKEFCL> NAFEOHPCDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private bool JMDNIJKJGAI;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public global::JEAOMHICMNN<HNCADDKEFCL> CHPOPHINEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public Vector3 FEGMNDFJJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB59F0", Offset = "0x5DB4DF0", VA = "0x185DB59F0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public Vector3 CPPDMGIDLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5020", Offset = "0x5DB4420", VA = "0x185DB5020", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private Vector3 CCECFEDOHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4F40", Offset = "0x5DB4340", VA = "0x185DB4F40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public HNCADDKEFCL GJAGIJHOJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5590", Offset = "0x5DB4990", VA = "0x185DB5590", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5A90", Offset = "0x5DB4E90", VA = "0x185DB5A90")]
	public DJBMLLLEBIN(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5A20", Offset = "0x5DB4E20", VA = "0x185DB5A20", Slot = "8")]
	public void PLHPBOOBFBI(HNCADDKEFCL MOHMMJFCOKF, object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5990", Offset = "0x5DB4D90", VA = "0x185DB5990", Slot = "9")]
	public void NCAJDBMABBB(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5640", Offset = "0x5DB4A40", VA = "0x185DB5640")]
	private Vector3 MHMPDHCFJFL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB51F0", Offset = "0x5DB45F0", VA = "0x185DB51F0")]
	private void FBGINMJGAMO(HNCADDKEFCL GJAADEGNMKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class BABDAJEBKDE
{
	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2540", Offset = "0x5DB1940", VA = "0x185DB2540")]
	public static JDELEGAPDIL LOBGLJJNGEN(this HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class PHPBOMEJKCA : CGKLPIMODIO, DLEOKLGAEFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly IBFGKBDICBN LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly OverridableVector3 MGMPIIPBCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly OverridableVector3 GAPLELMOGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private float EMOEMFOPHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private float KPNADFDDJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Vector3 IAFPEAALBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Vector3? HIFIPMJFACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Quaternion? LACDOFNOLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool BMLLDFGCIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool CBOJBNGIODE;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Vector3 FCENJNKLLFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x4C0F740", Offset = "0x4C0EB40", VA = "0x184C0F740", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F59400", Offset = "0x6F58800", VA = "0x186F59400", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public Vector3 PGCNAIKHOLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A090", Offset = "0x6F59490", VA = "0x186F5A090", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public float FLGPCIIOBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xB1E990", Offset = "0xB1DD90", VA = "0x180B1E990", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F59FE0", Offset = "0x6F593E0", VA = "0x186F59FE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public float KIMEKCFKEGM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x19A93C0", Offset = "0x19A87C0", VA = "0x1819A93C0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F59730", Offset = "0x6F58B30", VA = "0x186F59730", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 DPMPNPGFKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A280", Offset = "0x6F59680", VA = "0x186F5A280", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Quaternion IEOFMJCGDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F590E0", Offset = "0x6F584E0", VA = "0x186F590E0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private Rigidbody ANMFOPKOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F59480", Offset = "0x6F58880", VA = "0x186F59480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event MIKHCFECODK HIGOEIJCCLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F59B20", Offset = "0x6F58F20", VA = "0x186F59B20", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F591F0", Offset = "0x6F585F0", VA = "0x186F591F0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F5AFC0", Offset = "0x6F5A3C0", VA = "0x186F5AFC0")]
	public PHPBOMEJKCA(HNCADDKEFCL LKJACCKKHID, in JALLAOKICKK KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A160", Offset = "0x6F59560", VA = "0x186F5A160", Slot = "17")]
	public void PDJPGKOMEMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F59930", Offset = "0x6F58D30", VA = "0x186F59930", Slot = "16")]
	public void IEHFPDAHNFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F598C0", Offset = "0x6F58CC0", VA = "0x186F598C0", Slot = "19")]
	public void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F594A0", Offset = "0x6F588A0", VA = "0x186F594A0", Slot = "20")]
	public void GALMCDGHJPP(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F59290", Offset = "0x6F58690", VA = "0x186F59290", Slot = "18")]
	public void CONKKKNIKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F59BC0", Offset = "0x6F58FC0", VA = "0x186F59BC0", Slot = "21")]
	public void LMOFLFBKNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F59400", Offset = "0x6F58800", VA = "0x186F59400")]
	private void DBFINFCLLAG(Vector3 EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F59660", Offset = "0x6F58A60", VA = "0x186F59660")]
	[Obsolete]
	private Vector3 GGIPBKJPIFH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x6F59FE0", Offset = "0x6F593E0", VA = "0x186F59FE0")]
	private void MCBLELNOLDN(float EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x6F59730", Offset = "0x6F58B30", VA = "0x186F59730")]
	private void GLKEKOMJGFL(float EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x6F59A10", Offset = "0x6F58E10", VA = "0x186F59A10")]
	private Vector3 IKHHAAJKEMN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x6F58F40", Offset = "0x6F58340", VA = "0x186F58F40", Slot = "15")]
	public void BKPAIKLAHNP((Quaternion rot, Vector3 moments) IMLBEEHPEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x6F597B0", Offset = "0x6F58BB0", VA = "0x186F597B0")]
	private Quaternion GONALEBFKKA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A390", Offset = "0x6F59790", VA = "0x186F5A390")]
	public void PKPNLJEIMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A470", Offset = "0x6F59870", VA = "0x186F5A470", Slot = "4")]
	public (float, Vector3) PKPNLJEIMMF(Rigidbody ICFHHNMIFIJ)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class ELPBOEPLKEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5CD0", Offset = "0x5DB50D0", VA = "0x185DB5CD0")]
	public static CGKLPIMODIO PKCPJAGPDEI(this HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface JDELEGAPDIL : OOOFALFOHIF
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	global::JEAOMHICMNN<HNCADDKEFCL> CHPOPHINEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	HNCADDKEFCL GJAGIJHOJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class LDLBNOPPFJL : PNDBILPOCAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly IBFGKBDICBN LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly KBENAKLNOBE JKBBICCGPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private float PDPJMKFDPHF;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public CLNMMGNFNHK LJFGAKJBGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B00", Offset = "0x7F7F00", VA = "0x1807F8B00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x80EE50", Offset = "0x80E250", VA = "0x18080EE50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public CIICDJONOMO AMPFADHGNMC
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x89EC00", Offset = "0x89E000", VA = "0x18089EC00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public Vector3 CCECFEDOHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x5DC4750", Offset = "0x5DC3B50", VA = "0x185DC4750", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x5DC64C0", Offset = "0x5DC58C0", VA = "0x185DC64C0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public Vector3 JMEHDDALPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x5DC5C90", Offset = "0x5DC5090", VA = "0x185DC5C90", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x5DC4B70", Offset = "0x5DC3F70", VA = "0x185DC4B70", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Vector3 JCLOPKLIDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x5DC50D0", Offset = "0x5DC44D0", VA = "0x185DC50D0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x5DC4AB0", Offset = "0x5DC3EB0", VA = "0x185DC4AB0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public Vector3 DFOGIPNDFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x5DC5860", Offset = "0x5DC4C60", VA = "0x185DC5860", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x5DC6740", Offset = "0x5DC5B40", VA = "0x185DC6740", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public float MCGDKOEGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xBBC3C0", Offset = "0xBBB7C0", VA = "0x180BBC3C0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x5DC5B70", Offset = "0x5DC4F70", VA = "0x185DC5B70", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool NFBJNCIJOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x18FC9C0", Offset = "0x18FBDC0", VA = "0x1818FC9C0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private BIFJOJANGIA PKAINGFEJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x26BD020", Offset = "0x26BC420", VA = "0x1826BD020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private bool CIKGJKFBIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7B30", Offset = "0x5DB6F30", VA = "0x185DB7B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6EA0", Offset = "0x5DC62A0", VA = "0x185DC6EA0")]
	public LDLBNOPPFJL(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6000", Offset = "0x5DC5400", VA = "0x185DC6000", Slot = "19")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5200", Offset = "0x5DC4600", VA = "0x185DC5200", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5A40", Offset = "0x5DC4E40", VA = "0x185DC5A40", Slot = "28")]
	public void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x18FBFD0", Offset = "0x18FB3D0", VA = "0x1818FBFD0", Slot = "20")]
	public void HPDFJLGJJBB(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x18FBF50", Offset = "0x18FB350", VA = "0x1818FBF50", Slot = "31")]
	public void CDBGCPHCPHC(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6B60", Offset = "0x5DC5F60", VA = "0x185DC6B60", Slot = "36")]
	public Vector3 PNIDAHMAOMO(Vector3 MLIHKCLPMIC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6580", Offset = "0x5DC5980", VA = "0x185DC6580", Slot = "35")]
	public Vector3 NNBHMNHBLHK(Vector3 JONJDHHMABD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6000", Offset = "0x5DC5400", VA = "0x185DC6000", Slot = "27")]
	public void KAEOGPGNKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5D80", Offset = "0x5DC5180", VA = "0x185DC5D80", Slot = "25")]
	public void HNANFLOOICJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x5DC43E0", Offset = "0x5DC37E0", VA = "0x185DC43E0", Slot = "24")]
	public void AGJLHOENOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4870", Offset = "0x5DC3C70", VA = "0x185DC4870", Slot = "34")]
	public void BHONDBKKIPH(Vector3 ELOPNDOJDBP, Vector3 OMEKBFHJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4FB0", Offset = "0x5DC43B0", VA = "0x185DC4FB0", Slot = "33")]
	public void DHODHCKLIJJ(Vector3 HKJGAFDNPCB, Vector3 MADECJFHGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5EC0", Offset = "0x5DC52C0", VA = "0x185DC5EC0", Slot = "32")]
	public void JOFPDCAHJDI(Vector3 AIHNFDGGKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6070", Offset = "0x5DC5470", VA = "0x185DC6070", Slot = "22")]
	public void LCLPMDJEHJP(IHAJHGLLODM NIMFHBNDLJE, Vector3 KFEGEPPHIAJ, float FMDJMILNIFE, float BGKJPFEMPDM = 8f, float NKDCMOIFBFO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6870", Offset = "0x5DC5C70", VA = "0x185DC6870", Slot = "21")]
	public void OLEJKMPDNHI(DCHGNBAICFJ IEOFODKJLHF, Vector3 MNNPNKKFOML, float APDOAPPOFCC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4CE0", Offset = "0x5DC40E0", VA = "0x185DC4CE0", Slot = "23")]
	[Obsolete]
	public void DFPHMCCPDCG(DCHGNBAICFJ IEOFODKJLHF, Vector3 FKJONOBDEOA, float NKDFOLBGEBG = 7f, float ONGDPDONLHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6AA0", Offset = "0x5DC5EA0", VA = "0x185DC6AA0", Slot = "30")]
	public Vector3 OMEPCLINFOB(Vector3 CCEKBJKHCEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6770", Offset = "0x5DC5B70", VA = "0x185DC6770", Slot = "29")]
	public Vector3 OKAAEINDKGD(Vector3 IGPNCMNEFAG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6D40", Offset = "0x5DC6140", VA = "0x185DC6D40", Slot = "26")]
	public void PPIMFLMMADH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5B70", Offset = "0x5DC4F70", VA = "0x185DC5B70")]
	private void JDJLJMCCMGF(float EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4BA0", Offset = "0x5DC3FA0", VA = "0x185DC4BA0")]
	private void CJGPFAHAJEE(Vector3 MNNPNKKFOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5950", Offset = "0x5DC4D50", VA = "0x185DC5950")]
	private Vector3 GGPNKEEOKBO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x5DC40C0", Offset = "0x5DC34C0", VA = "0x185DC40C0")]
	private void ADMLNIOHPDA(Vector3 JONJDHHMABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5DC0", Offset = "0x5DC51C0", VA = "0x185DC5DC0")]
	private Vector3 IJPLOEOEKLF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4420", Offset = "0x5DC3820", VA = "0x185DC4420")]
	private void AMOFMAFLFJH(Vector3 EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5260", Offset = "0x5DC4660", VA = "0x185DC5260")]
	private void FFBIIJHLDCO(Vector3 JONJDHHMABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5010", Offset = "0x5DC4410", VA = "0x185DC5010")]
	private void DOGLPLLIMEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class KPFOKADHENL : BIKICKEFOFJ
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private const string EGEDBBDBOLG = "IsKinematicByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly IBFGKBDICBN LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly KBENAKLNOBE GGPAOBPBHJD;

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool EGICHPNLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x5DC37F0", Offset = "0x5DC2BF0", VA = "0x185DC37F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public IEnumerable<object> OMNDHIMBMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3990", Offset = "0x5DC2D90", VA = "0x185DC3990", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event MIKHCFECODK BLLEHHOJICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3AE0", Offset = "0x5DC2EE0", VA = "0x185DC3AE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x5DC38C0", Offset = "0x5DC2CC0", VA = "0x185DC38C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3D60", Offset = "0x5DC3160", VA = "0x185DC3D60")]
	public KPFOKADHENL(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3A80", Offset = "0x5DC2E80", VA = "0x185DC3A80", Slot = "12")]
	public IDisposable IJCEPKOJMCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3C80", Offset = "0x5DC3080", VA = "0x185DC3C80", Slot = "9")]
	public void OOFMCOFCPPI(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3A30", Offset = "0x5DC2E30", VA = "0x185DC3A30", Slot = "10")]
	public void HDGPIOKEHKN(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3B80", Offset = "0x5DC2F80", VA = "0x185DC3B80", Slot = "11")]
	public void MDBEAPEPGAK(object IJNLJGNNJFA, bool HLALGAMPNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3A40", Offset = "0x5DC2E40", VA = "0x185DC3A40", Slot = "6")]
	public void IBPPLFAOFGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x5DC39B0", Offset = "0x5DC2DB0", VA = "0x185DC39B0", Slot = "13")]
	public void HDGIJJBLDBO(Rigidbody OHFFPKCPFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3960", Offset = "0x5DC2D60", VA = "0x185DC3960", Slot = "14")]
	public void GALMCDGHJPP(Rigidbody GFKPNFPKDAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class IOFMOIGJJMD : FBHHEECMAOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly IBFGKBDICBN LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private CollisionDetectionMode PJJLAHOHCHA;

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private Rigidbody ANMFOPKOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC230", Offset = "0x5DAB630", VA = "0x185DAC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public CollisionDetectionMode FANAAAEAKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x5DC15E0", Offset = "0x5DC09E0", VA = "0x185DC15E0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x5DC1370", Offset = "0x5DC0770", VA = "0x185DC1370", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA1B0", Offset = "0x5DB95B0", VA = "0x185DBA1B0")]
	public IOFMOIGJJMD(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x5DC16F0", Offset = "0x5DC0AF0", VA = "0x185DC16F0", Slot = "6")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1560", Offset = "0x5DC0960", VA = "0x185DC1560", Slot = "9")]
	public void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1940", Offset = "0x5DC0D40", VA = "0x185DC1940", Slot = "7")]
	public void PDMDJFGJIDK(bool LMHKIOMKPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1550", Offset = "0x5DC0950", VA = "0x185DC1550", Slot = "8")]
	public void GIPOGJKIAPI(bool LMHKIOMKPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC13E0", Offset = "0x5DC07E0", VA = "0x185DC13E0", Slot = "10")]
	public bool EHNGMCAIOPF(Vector3 EPJPJGLJENE, out RaycastHit NFPNFECBHMA, float NCEKMHDDCCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1810", Offset = "0x5DC0C10", VA = "0x185DC1810")]
	private void OABHJNOBFAL(bool LMHKIOMKPEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class FDGEKLHKNMG : ACNLDECGDAI
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6770", Offset = "0x5DB5B70", VA = "0x185DB6770", Slot = "4")]
	public KAKAJECMEFH MAFLDFMPBGL(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6A20", Offset = "0x5DB5E20", VA = "0x185DB6A20", Slot = "5")]
	public PNDBILPOCAL PBOHFIDDIHF(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6650", Offset = "0x5DB5A50", VA = "0x185DB6650", Slot = "6")]
	public OOOFALFOHIF LNIPLIIGKJH(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6460", Offset = "0x5DB5860", VA = "0x185DB6460", Slot = "7")]
	public JHNGOMGDEDF GHJIMMFBNCH(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6380", Offset = "0x5DB5780", VA = "0x185DB6380", Slot = "8")]
	public ABAMFAEIDNO EOOHFODGDME(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6860", Offset = "0x5DB5C60", VA = "0x185DB6860", Slot = "9")]
	public PPIJHNBKLMK OFENOFKEBFE(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6920", Offset = "0x5DB5D20", VA = "0x185DB6920", Slot = "10")]
	public BIKICKEFOFJ PAFFCILGION(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5F00", Offset = "0x5DB5300", VA = "0x185DB5F00", Slot = "11")]
	public BIFJOJANGIA AOIJIMCDNHL(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x5DB64D0", Offset = "0x5DB58D0", VA = "0x185DB64D0", Slot = "12")]
	public FBHHEECMAOI INMNIJHIDBN(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5FB0", Offset = "0x5DB53B0", VA = "0x185DB5FB0", Slot = "13")]
	public MHLMOEPKKCN BCPDJOFALLA(HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5DE0", Offset = "0x5DB51E0", VA = "0x185DB5DE0")]
	public FIJNONMINBM DKOPFLAILKM(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6580", Offset = "0x5DB5980", VA = "0x185DB6580")]
	public GFMMGHEHOCP JCEMNEJKPJD(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6260", Offset = "0x5DB5660", VA = "0x185DB6260")]
	public CBPAJNHEOHG OCMIFDBNEBL(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6070", Offset = "0x5DB5470", VA = "0x185DB6070")]
	public DLEOKLGAEFK CDBAOOCICIC(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6190", Offset = "0x5DB5590", VA = "0x185DB6190")]
	public FKIFKCOAGDD NHHCIGFPOBB(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB60E0", Offset = "0x5DB54E0", VA = "0x185DB60E0", Slot = "19")]
	public HNCADDKEFCL DBCPEBLAANN(RigidbodyEx LKJACCKKHID, JALLAOKICKK KOCKBILIHNN, JANPOADJHGO JMAEGHAGIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public FDGEKLHKNMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5DE0", Offset = "0x5DB51E0", VA = "0x185DB5DE0", Slot = "14")]
	private FIJNONMINBM AMLPPDHAHAP(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6580", Offset = "0x5DB5980", VA = "0x185DB6580", Slot = "15")]
	private GFMMGHEHOCP PIEBDEPNFNK(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6260", Offset = "0x5DB5660", VA = "0x185DB6260", Slot = "16")]
	private CBPAJNHEOHG EHPJLGOHLCP(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6070", Offset = "0x5DB5470", VA = "0x185DB6070", Slot = "17")]
	private DLEOKLGAEFK KPDFBBGLOPL(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6190", Offset = "0x5DB5590", VA = "0x185DB6190", Slot = "18")]
	private FKIFKCOAGDD EEEFCBJMMBA(HNCADDKEFCL NBHMCHHOJCP, in JALLAOKICKK KOCKBILIHNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class LJEKJJAKCEL : FGDNEDMDNLN, KAKAJECMEFH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly HNCADDKEFCL LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly List<HNCADDKEFCL> OAEDMJEOPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private HNCADDKEFCL PFMMNJCIGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HNCADDKEFCL MOHMMJFCOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Transform CJNLOHBMOID;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private Transform LIOPMIPOJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7690", Offset = "0x5DC6A90", VA = "0x185DC7690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public HNCADDKEFCL GCKCFOBIHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x86C280", Offset = "0x86B680", VA = "0x18086C280", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x5DC75E0", Offset = "0x5DC69E0", VA = "0x185DC75E0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public HNCADDKEFCL GILDPEKDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x89ED20", Offset = "0x89E120", VA = "0x18089ED20", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public IReadOnlyList<HNCADDKEFCL> MNOGMALHBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x89EC90", Offset = "0x89E090", VA = "0x18089EC90", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event MIKHCFECODK OOBNDOHGDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x5DC8590", Offset = "0x5DC7990", VA = "0x185DC8590", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7160", Offset = "0x5DC6560", VA = "0x185DC7160", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event MIKHCFECODK KOKPFOIFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7540", Offset = "0x5DC6940", VA = "0x185DC7540", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7400", Offset = "0x5DC6800", VA = "0x185DC7400", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event NNKKEOCOMJB IDJGLLKNKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7C70", Offset = "0x5DC7070", VA = "0x185DC7C70", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x5DC78D0", Offset = "0x5DC6CD0", VA = "0x185DC78D0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action GPDCKMBDJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5DC84F0", Offset = "0x5DC78F0", VA = "0x185DC84F0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x5DC75F0", Offset = "0x5DC69F0", VA = "0x185DC75F0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action FCEHNKNEBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7AA0", Offset = "0x5DC6EA0", VA = "0x185DC7AA0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x5DC76F0", Offset = "0x5DC6AF0", VA = "0x185DC76F0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<HNCADDKEFCL> BNAHCBHAJOK
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x5DC6F80", Offset = "0x5DC6380", VA = "0x185DC6F80", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x5DC74A0", Offset = "0x5DC68A0", VA = "0x185DC74A0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event Action<HNCADDKEFCL> CFNFBEKMOCG
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x5DC8160", Offset = "0x5DC7560", VA = "0x185DC8160", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x5DC8200", Offset = "0x5DC7600", VA = "0x185DC8200", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event Action IIHHCIPDGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7D10", Offset = "0x5DC7110", VA = "0x185DC7D10", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7830", Offset = "0x5DC6C30", VA = "0x185DC7830", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event Action<HNCADDKEFCL> HFPIBPICLHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x5DC8670", Offset = "0x5DC7A70", VA = "0x185DC8670", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7790", Offset = "0x5DC6B90", VA = "0x185DC7790", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8CB0", Offset = "0x5DC80B0", VA = "0x185DC8CB0")]
	public LJEKJJAKCEL(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7380", Offset = "0x5DC6780", VA = "0x185DC7380", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8710", Offset = "0x5DC7B10", VA = "0x185DC8710", Slot = "30")]
	public void PPONGLALHNF(HNCADDKEFCL OFEIPHKKILF, bool LAPMPFOBPLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC82A0", Offset = "0x5DC76A0", VA = "0x185DC82A0", Slot = "6")]
	public void PAALPLFAFCK(HNCADDKEFCL FJLPEDHEFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7F00", Offset = "0x5DC7300", VA = "0x185DC7F00", Slot = "7")]
	public void NJJKDNIJHMG(HNCADDKEFCL FJLPEDHEFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC70C0", Offset = "0x5DC64C0", VA = "0x185DC70C0", Slot = "4")]
	public void CHLDIHBNOLG(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7020", Offset = "0x5DC6420", VA = "0x185DC7020", Slot = "5")]
	public void CCGGLNOKPGD(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x5DC72F0", Offset = "0x5DC66F0", VA = "0x185DC72F0")]
	private void DMOFFMNEFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8630", Offset = "0x5DC7A30", VA = "0x185DC8630")]
	private void PJHNJNGCBLL(HNCADDKEFCL FJLPEDHEFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7DB0", Offset = "0x5DC71B0", VA = "0x185DC7DB0")]
	private void NAEFMAOBPMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7B40", Offset = "0x5DC6F40", VA = "0x185DC7B40")]
	private void LDBNAEHNMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7970", Offset = "0x5DC6D70", VA = "0x185DC7970")]
	private void JBACEIAEEJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7200", Offset = "0x5DC6600", VA = "0x185DC7200")]
	[CompilerGenerated]
	private object DLEKLOJMBJJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class GCDBJOPGFJD
{
	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6B30", Offset = "0x5DB5F30", VA = "0x185DB6B30")]
	public static FGDNEDMDNLN ENBFKHIFKEF(this HNCADDKEFCL NBHMCHHOJCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class NCMGKGPCNMO : CBPAJNHEOHG
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const string CAAKGJMAGJJ = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly IBFGKBDICBN LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly KBENAKLNOBE PEOFAANKJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly KGLFAPPIPIG NINHMIPGMFC;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool JMHBFIDMOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x180BF20", Offset = "0x180B320", VA = "0x18180BF20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public KGLFAPPIPIG KNNAMIKDJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x80EC90", Offset = "0x80E090", VA = "0x18080EC90", Slot = "5")]
		get
		{
			return default(KGLFAPPIPIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE0B0", Offset = "0x5DCD4B0", VA = "0x185DCE0B0")]
	public NCMGKGPCNMO(HNCADDKEFCL LKJACCKKHID, in JALLAOKICKK KOCKBILIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDFB0", Offset = "0x5DCD3B0", VA = "0x185DCDFB0", Slot = "6")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDCD0", Offset = "0x5DCD0D0", VA = "0x185DCDCD0")]
	private bool FIPLIOOOAJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE080", Offset = "0x5DCD480", VA = "0x185DCE080", Slot = "7")]
	public void NCAFBDAHCPJ(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDAE0", Offset = "0x5DCCEE0", VA = "0x185DCDAE0", Slot = "8")]
	public void AKJAKPKOAHD(object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDE80", Offset = "0x5DCD280", VA = "0x185DCDE80", Slot = "11")]
	public void KKNGELFLGCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDD70", Offset = "0x5DCD170", VA = "0x185DCDD70")]
	private void FPFJNKLGFAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDB50", Offset = "0x5DCCF50", VA = "0x185DCDB50")]
	private void DLCIDNENMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDB10", Offset = "0x5DCCF10", VA = "0x185DCDB10", Slot = "10")]
	public void BDLGBLALMBG(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDAA0", Offset = "0x5DCCEA0", VA = "0x185DCDAA0", Slot = "9")]
	public void AGNNJPCOBEL(HNCADDKEFCL LKJACCKKHID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface CGKLPIMODIO : DLEOKLGAEFK
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) PKPNLJEIMMF(Rigidbody ICFHHNMIFIJ);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface FGDNEDMDNLN : KAKAJECMEFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHLDIHBNOLG(HNCADDKEFCL LKJACCKKHID);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCGGLNOKPGD(HNCADDKEFCL LKJACCKKHID);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PAALPLFAFCK(HNCADDKEFCL FJLPEDHEFKP);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NJJKDNIJHMG(HNCADDKEFCL FJLPEDHEFKP);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class HIPHJDKFGGE : MHLMOEPKKCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly IBFGKBDICBN LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool IHAGPGDHADD;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool LFILBCFKBAN
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x90D9A0", Offset = "0x90CDA0", VA = "0x18090D9A0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA2E0", Offset = "0x5DB96E0", VA = "0x185DBA2E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA3F0", Offset = "0x5DB97F0", VA = "0x185DBA3F0")]
	public HIPHJDKFGGE(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA2B0", Offset = "0x5DB96B0", VA = "0x185DBA2B0", Slot = "6")]
	public void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA240", Offset = "0x5DB9640", VA = "0x185DBA240", Slot = "7")]
	public void GALMCDGHJPP(Rigidbody GFKPNFPKDAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class GOAOOMHKAGE : ABAMFAEIDNO
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int BHCNKPFPFCN = 10;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private const float FIPAJGOAFHO = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const float LJACIMJODHF = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const float MAFHBCMOIPH = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly IBFGKBDICBN LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private bool BDJANPECPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool ILDAICKCNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private int MBIIAAFDDMB;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private Rigidbody ANMFOPKOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8A30", Offset = "0x5DB7E30", VA = "0x185DB8A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private bool DGPFLCKMPND
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9320", Offset = "0x5DB8720", VA = "0x185DB9320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private bool CIKGJKFBIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8A80", Offset = "0x5DB7E80", VA = "0x185DB8A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private HNCADDKEFCL GCKCFOBIHPK
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x5DB89C0", Offset = "0x5DB7DC0", VA = "0x185DB89C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private bool AMFPPNFBIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8B40", Offset = "0x5DB7F40", VA = "0x185DB8B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event MIKHCFECODK GGMPDBAHIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8AA0", Offset = "0x5DB7EA0", VA = "0x185DB8AA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8840", Offset = "0x5DB7C40", VA = "0x185DB8840", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x5DB93C0", Offset = "0x5DB87C0", VA = "0x185DB93C0")]
	public GOAOOMHKAGE(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB90E0", Offset = "0x5DB84E0", VA = "0x185DB90E0", Slot = "6")]
	public void MKBEIIPNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8A20", Offset = "0x5DB7E20", VA = "0x185DB8A20", Slot = "8")]
	public void DHAKKDLFDJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8DD0", Offset = "0x5DB81D0", VA = "0x185DB8DD0", Slot = "7")]
	public bool JGHPGIPHPGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8D30", Offset = "0x5DB8130", VA = "0x185DB8D30", Slot = "9")]
	public void JDFKOJKPINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB88E0", Offset = "0x5DB7CE0", VA = "0x185DB88E0", Slot = "11")]
	public void BHMLJGCOHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8980", Offset = "0x5DB7D80", VA = "0x185DB8980", Slot = "12")]
	public void CIKLEGPLEEN(bool LHPPABJMNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9170", Offset = "0x5DB8570", VA = "0x185DB9170", Slot = "10")]
	public void PGAFCJHFMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8F30", Offset = "0x5DB8330", VA = "0x185DB8F30")]
	private bool KNJNPLPGCNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8BA0", Offset = "0x5DB7FA0", VA = "0x185DB8BA0")]
	private void IONJPLKCNDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class BEBFJPDKDNO : JHNGOMGDEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly HNCADDKEFCL LKJACCKKHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private float NCDJGJJIJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float LJAFCEJMHDM;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public float HKLMIAEJNHI
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xBBA3C0", Offset = "0xBB97C0", VA = "0x180BBA3C0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB26F0", Offset = "0x5DB1AF0", VA = "0x185DB26F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public float IJDPOHFHBBB
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xBBA3D0", Offset = "0xBB97D0", VA = "0x180BBA3D0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x5DB27C0", Offset = "0x5DB1BC0", VA = "0x185DB27C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2890", Offset = "0x5DB1C90", VA = "0x185DB2890")]
	public BEBFJPDKDNO(HNCADDKEFCL LKJACCKKHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DB26A0", Offset = "0x5DB1AA0", VA = "0x185DB26A0", Slot = "8")]
	public void HDGIJJBLDBO(Rigidbody GFKPNFPKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2600", Offset = "0x5DB1A00", VA = "0x185DB2600", Slot = "9")]
	public void GALMCDGHJPP(Rigidbody GFKPNFPKDAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface DHJLBKFCHJP : GFMMGHEHOCP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000175")]
	PhotonView KMPHCEHJKCP
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
	internal class _RRAssemblyIndex : NKAPIKLJHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F61D20", Offset = "0x6F61120", VA = "0x186F61D20", Slot = "6")]
		public sealed override void HMIKMLFKAMC(DNCOCLAAHJO JGHGBFJPJFD)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB0", Offset = "0x8C5FB0", VA = "0x1808C6BB0")]
	public static string NLHKAJNPDJN(byte[] AMGPPENALAL, byte[] DKDGFKIJFBC)
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
