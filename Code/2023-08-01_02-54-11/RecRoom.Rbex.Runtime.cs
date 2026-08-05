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
		public static MONMJFCKPLO UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int NMOHLHGLEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int NDLOOBMGNII;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x71E1690", Offset = "0x71E0690", VA = "0x1871E1690")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71E16D0", Offset = "0x71E06D0", VA = "0x1871E16D0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x71E16B0", Offset = "0x71E06B0", VA = "0x1871E16B0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string FANKIHBOOPE, [Optional] UnityEngine.Object HBLIBBFCHOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string FANKIHBOOPE, [Optional] UnityEngine.Object HBLIBBFCHOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71E17C0", Offset = "0x71E07C0", VA = "0x1871E17C0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JGJLBGFFONM
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class HGPNPFNNDPG : INMIHNLNEJO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xF00BA0", Offset = "0xEFFBA0", VA = "0x180F00BA0", Slot = "4")]
		public Vector3 OMOBMEMDMPD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xF00BA0", Offset = "0xEFFBA0", VA = "0x180F00BA0", Slot = "5")]
		public Vector3 EMJIOMJCDMD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HGPNPFNNDPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static INMIHNLNEJO ABDKNKGOHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5753150", Offset = "0x5752150", VA = "0x185753150")]
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
		private static readonly FACALIAHOGE NOHGLOODJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool MEFLPICAOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private PGOKKAHHEHO KPPPNKNDMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[ODLINMJGOAE(FEMKOOHMMFH.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[ODLINMJGOAE(FEMKOOHMMFH.SelfAndParent, true, false, false)]
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
		private OPPPJCICLFD physicsInterpolation;

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
		internal PGOKKAHHEHO FOCDIDELANI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x71E2890", Offset = "0x71E1890", VA = "0x1871E2890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> JFOFPJFPFIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x962CB0", Offset = "0x961CB0", VA = "0x180962CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9629F0", Offset = "0x9619F0", VA = "0x1809629F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx NNHKCDBFLHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x71E4420", Offset = "0x71E3420", VA = "0x1871E4420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx EDABIFLHHKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x71E43C0", Offset = "0x71E33C0", VA = "0x1871E43C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx AGFCJPGACCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x71E4F70", Offset = "0x71E3F70", VA = "0x1871E4F70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x71E6430", Offset = "0x71E5430", VA = "0x1871E6430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform KMNEBMCNEAN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xC65850", Offset = "0xC64850", VA = "0x180C65850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform NCPLCNGEEFM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xC65850", Offset = "0xC64850", VA = "0x180C65850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public HAKHCLDIGMM CCODFDCKKMO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x71E4120", Offset = "0x71E3120", VA = "0x1871E4120")]
			get
			{
				return default(HAKHCLDIGMM);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x71E5BD0", Offset = "0x71E4BD0", VA = "0x1871E5BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool NCEMACJLKCK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x71E4680", Offset = "0x71E3680", VA = "0x1871E4680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KPLBGMFCADF
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x71E42A0", Offset = "0x71E32A0", VA = "0x1871E42A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public INMIHNLNEJO DEEIHGOOGBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x71E45C0", Offset = "0x71E35C0", VA = "0x1871E45C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x71E5DE0", Offset = "0x71E4DE0", VA = "0x1871E5DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public GGOGJGFNOFN GHAKLGHCKIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x71E4560", Offset = "0x71E3560", VA = "0x1871E4560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x71E5D70", Offset = "0x71E4D70", VA = "0x1871E5D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IBJABDCLBGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x71E4450", Offset = "0x71E3450", VA = "0x1871E4450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody JAMLFHMHJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x71E44B0", Offset = "0x71E34B0", VA = "0x1871E44B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LAHGANIGJCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x71E4300", Offset = "0x71E3300", VA = "0x1871E4300")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x71E5C90", Offset = "0x71E4C90", VA = "0x1871E5C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool PLNILEGALKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x145C130", Offset = "0x145B130", VA = "0x18145C130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2F71050", Offset = "0x2F70050", VA = "0x182F71050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float AJCOFMJAECD
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x71E4F10", Offset = "0x71E3F10", VA = "0x1871E4F10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float EFBPONPEOGH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x71E4EB0", Offset = "0x71E3EB0", VA = "0x1871E4EB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x71E63C0", Offset = "0x71E53C0", VA = "0x1871E63C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float EDFALHBEIGB
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x71E48D0", Offset = "0x71E38D0", VA = "0x1871E48D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x71E6070", Offset = "0x71E5070", VA = "0x1871E6070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float FLKBMIKJIIM
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x71E46E0", Offset = "0x71E36E0", VA = "0x1871E46E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x71E5E50", Offset = "0x71E4E50", VA = "0x1871E5E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool EOFLFJEGAJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x71E5440", Offset = "0x71E4440", VA = "0x1871E5440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x71E6920", Offset = "0x71E5920", VA = "0x1871E6920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 HEFJDNOKMBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x71E4CB0", Offset = "0x71E3CB0", VA = "0x1871E4CB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x71E61B0", Offset = "0x71E51B0", VA = "0x1871E61B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 PABLOLAHCNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x71E5570", Offset = "0x71E4570", VA = "0x1871E5570")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode DBGGDAJAMCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x71E4810", Offset = "0x71E3810", VA = "0x1871E4810")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x71E5F90", Offset = "0x71E4F90", VA = "0x1871E5F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float AKIPAEFKPHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x71E4360", Offset = "0x71E3360", VA = "0x1871E4360")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x71E5D00", Offset = "0x71E4D00", VA = "0x1871E5D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints ANNCKJLMEDI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x71E4870", Offset = "0x71E3870", VA = "0x1871E4870")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x71E6000", Offset = "0x71E5000", VA = "0x1871E6000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 BBNEIOFPBJP
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x71E4FD0", Offset = "0x71E3FD0", VA = "0x1871E4FD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 IHEDJDBCLGP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x71E4FD0", Offset = "0x71E3FD0", VA = "0x1871E4FD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x71E6710", Offset = "0x71E5710", VA = "0x1871E6710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float LJJLDLLDOBN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x71E4D80", Offset = "0x71E3D80", VA = "0x1871E4D80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x71E6280", Offset = "0x71E5280", VA = "0x1871E6280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float PEBHLHJKGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x71E53E0", Offset = "0x71E43E0", VA = "0x1871E53E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x71E68B0", Offset = "0x71E58B0", VA = "0x1871E68B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion FIKPKDFAFME
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x71E50A0", Offset = "0x71E40A0", VA = "0x1871E50A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x71E64A0", Offset = "0x71E54A0", VA = "0x1871E64A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion DCELKKEIGIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x71E5310", Offset = "0x71E4310", VA = "0x1871E5310")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x71E67E0", Offset = "0x71E57E0", VA = "0x1871E67E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 HKFMKKFGHBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x71E5170", Offset = "0x71E4170", VA = "0x1871E5170")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x71E6570", Offset = "0x71E5570", VA = "0x1871E6570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion NOBLKBKAEMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x71E5240", Offset = "0x71E4240", VA = "0x1871E5240")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x71E6640", Offset = "0x71E5640", VA = "0x1871E6640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 CBPBBILDPPH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x71E54A0", Offset = "0x71E44A0", VA = "0x1871E54A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x71E6990", Offset = "0x71E5990", VA = "0x1871E6990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 PECLNPLFMIH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x71E4DE0", Offset = "0x71E3DE0", VA = "0x1871E4DE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x71E62F0", Offset = "0x71E52F0", VA = "0x1871E62F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 NJBJCPFKCBL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x71E4740", Offset = "0x71E3740", VA = "0x1871E4740")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x71E5EC0", Offset = "0x71E4EC0", VA = "0x1871E5EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 PFMLKPNBNHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x71E4BE0", Offset = "0x71E3BE0", VA = "0x1871E4BE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x71E60E0", Offset = "0x71E50E0", VA = "0x1871E60E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 IFDEEDKEFMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x71E4AB0", Offset = "0x71E3AB0", VA = "0x1871E4AB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion EBDBPGIPHNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x71E49E0", Offset = "0x71E39E0", VA = "0x1871E49E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 ICHKJNFOAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x71E5710", Offset = "0x71E4710", VA = "0x1871E5710")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 JPLKFDOKBJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x71E5640", Offset = "0x71E4640", VA = "0x1871E5640")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool LFKOLODLPAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x71E4B80", Offset = "0x71E3B80", VA = "0x1871E4B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool OJPJLJHGGJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x71E4620", Offset = "0x71E3620", VA = "0x1871E4620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool EICCNFFNODM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x71E4240", Offset = "0x71E3240", VA = "0x1871E4240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool BBPJKLAMKPO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x71E41E0", Offset = "0x71E31E0", VA = "0x1871E41E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NKKJGCMCCIB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x71E40C0", Offset = "0x71E30C0", VA = "0x1871E40C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool JBNJBEIONJD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x71E4930", Offset = "0x71E3930", VA = "0x1871E4930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool HFIGPCOJDMM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x211DE40", Offset = "0x211CE40", VA = "0x18211DE40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event NAEAPBAINIJ ELAEEEABCNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x71E3FE0", Offset = "0x71E2FE0", VA = "0x1871E3FE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x71E5AF0", Offset = "0x71E4AF0", VA = "0x1871E5AF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OOOCOIFCPAN IMEEFLKMDIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x71E3F70", Offset = "0x71E2F70", VA = "0x1871E3F70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x71E5A80", Offset = "0x71E4A80", VA = "0x1871E5A80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event NAEAPBAINIJ OPNOJLLMOJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x71E3CD0", Offset = "0x71E2CD0", VA = "0x1871E3CD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x71E57E0", Offset = "0x71E47E0", VA = "0x1871E57E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event NAEAPBAINIJ PMBDNOEKOAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x71E3D40", Offset = "0x71E2D40", VA = "0x1871E3D40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x71E5850", Offset = "0x71E4850", VA = "0x1871E5850")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event NAEAPBAINIJ NAOMFIIDBJM
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x71E3E90", Offset = "0x71E2E90", VA = "0x1871E3E90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x71E59A0", Offset = "0x71E49A0", VA = "0x1871E59A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<BHPPPFLNDLP, BHPPPFLNDLP> PDDABMIIDFO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x71E3E20", Offset = "0x71E2E20", VA = "0x1871E3E20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x71E5930", Offset = "0x71E4930", VA = "0x1871E5930")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event NAEAPBAINIJ MINJMNKMKAM
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x71E3F00", Offset = "0x71E2F00", VA = "0x1871E3F00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x71E5A10", Offset = "0x71E4A10", VA = "0x1871E5A10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event NAEAPBAINIJ NELHHHIOIPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x71E4050", Offset = "0x71E3050", VA = "0x1871E4050")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x71E5B60", Offset = "0x71E4B60", VA = "0x1871E5B60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event NAEAPBAINIJ KPLEICBNMED
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x71E3DB0", Offset = "0x71E2DB0", VA = "0x1871E3DB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x71E58C0", Offset = "0x71E48C0", VA = "0x1871E58C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x93A6D0", Offset = "0x9396D0", VA = "0x18093A6D0")]
		internal void NGMKEMLHOHB(PGOKKAHHEHO DAHEHNAMFLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x71E2C20", Offset = "0x71E1C20", VA = "0x1871E2C20")]
		internal void JFKGJCNFDPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71E39C0", Offset = "0x71E29C0", VA = "0x1871E39C0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody FHGFJFLOJOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x71E3680", Offset = "0x71E2680", VA = "0x1871E3680")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) DJHFDNAEBGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x71E2250", Offset = "0x71E1250", VA = "0x1871E2250")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x71E2890", Offset = "0x71E1890", VA = "0x1871E2890")]
		private PGOKKAHHEHO MHEMPOIKEMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x71E2500", Offset = "0x71E1500", VA = "0x1871E2500")]
		private void GFIIBDBEKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x71E2E70", Offset = "0x71E1E70", VA = "0x1871E2E70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x71E2C20", Offset = "0x71E1C20", VA = "0x1871E2C20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x71E2E10", Offset = "0x71E1E10", VA = "0x1871E2E10")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x71E2ED0", Offset = "0x71E1ED0", VA = "0x1871E2ED0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x71E1810", Offset = "0x71E0810", VA = "0x1871E1810")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x71E2F40", Offset = "0x71E1F40", VA = "0x1871E2F40")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x71E24A0", Offset = "0x71E14A0", VA = "0x1871E24A0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x71E2DB0", Offset = "0x71E1DB0", VA = "0x1871E2DB0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x71E37E0", Offset = "0x71E27E0", VA = "0x1871E37E0")]
		public void SetParent(RigidbodyEx CKMKMNKGMMC, bool BHOCINAFNLF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x71E3240", Offset = "0x71E2240", VA = "0x1871E3240")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x71E2B40", Offset = "0x71E1B40", VA = "0x1871E2B40")]
		public bool IsRigidbodyAncestor(RigidbodyEx OLDACADPMCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x71E2B80", Offset = "0x71E1B80", VA = "0x1871E2B80")]
		public bool IsRigidbodyDescendant(RigidbodyEx FDGCNGELLJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x71E1A80", Offset = "0x71E0A80", VA = "0x1871E1A80")]
		public void AddInterpolationRestriction(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x71E2FB0", Offset = "0x71E1FB0", VA = "0x1871E2FB0")]
		public void RemoveInterpolationRestriction(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x71E22C0", Offset = "0x71E12C0", VA = "0x1871E22C0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x71E1AF0", Offset = "0x71E0AF0", VA = "0x1871E1AF0")]
		public void AddKinematic(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x71E3020", Offset = "0x71E2020", VA = "0x1871E3020")]
		public void RemoveKinematic(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x71E3760", Offset = "0x71E2760", VA = "0x1871E3760")]
		public void SetKinematic(object DMHDKAFNNAC, bool CLCDDMLICOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x71E3590", Offset = "0x71E2590", VA = "0x1871E3590")]
		public void SetDiscontinuousPositionAndRotation(Vector3 ECLJOKGPADO, Quaternion ODAOAJLFHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x71E34A0", Offset = "0x71E24A0", VA = "0x1871E34A0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JOIOANBLCDC, Quaternion IKEPFBIAAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x71E2A40", Offset = "0x71E1A40", VA = "0x1871E2A40")]
		public Vector3 GetConstrainedVelocity(Vector3 CBPBBILDPPH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x71E2940", Offset = "0x71E1940", VA = "0x1871E2940")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 NJBJCPFKCBL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x71E1990", Offset = "0x71E0990", VA = "0x1871E1990")]
		public void AddForce(Vector3 CAMEGMHBOIN, ForceMode CNNCDLOEBGE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x71E1880", Offset = "0x71E0880", VA = "0x1871E1880")]
		public void AddForceAtPosition(Vector3 CAMEGMHBOIN, Vector3 EDEGPGKBEGA, ForceMode CNNCDLOEBGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x71E1CC0", Offset = "0x71E0CC0", VA = "0x1871E1CC0")]
		public void AddTorque(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x71E1B60", Offset = "0x71E0B60", VA = "0x1871E1B60")]
		public void AddRelativeTorque(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x71E3AA0", Offset = "0x71E2AA0", VA = "0x1871E3AA0")]
		public Vector3 WorldToLocalVelocity(Vector3 CLHHPAFJIIP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x71E2CB0", Offset = "0x71E1CB0", VA = "0x1871E2CB0")]
		public Vector3 LocalToWorldVelocity(Vector3 PECLNPLFMIH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x71E2440", Offset = "0x71E1440", VA = "0x1871E2440")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x71E23E0", Offset = "0x71E13E0", VA = "0x1871E23E0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x71E2380", Offset = "0x71E1380", VA = "0x1871E2380")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x71E2320", Offset = "0x71E1320", VA = "0x1871E2320")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x71E33A0", Offset = "0x71E23A0", VA = "0x1871E33A0")]
		public void ResetVelocityWorldSpace(Vector3 KBONMJFJLJN, Vector3 HGFKCPDNNFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x71E32A0", Offset = "0x71E22A0", VA = "0x1871E32A0")]
		public void ResetVelocityLocalSpace(Vector3 HFEPHLDDIBH, Vector3 PFMLKPNBNHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x71E3170", Offset = "0x71E2170", VA = "0x1871E3170")]
		public void ResetLinearVelocityLocalSpace(Vector3 HFEPHLDDIBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x71E38D0", Offset = "0x71E28D0", VA = "0x1871E38D0")]
		public bool SweepTest(Vector3 HAMNFFBEFHD, out RaycastHit GOKLGMJIOLJ, float OLGGKIEPHEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x71E2BC0", Offset = "0x71E1BC0", VA = "0x1871E2BC0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x71E3870", Offset = "0x71E2870", VA = "0x1871E3870")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x71E3A40", Offset = "0x71E2A40", VA = "0x1871E3A40")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x71E1C50", Offset = "0x71E0C50", VA = "0x1871E1C50")]
		public void AddShouldHaveUnityRigidbodyToken(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x71E3090", Offset = "0x71E2090", VA = "0x1871E3090")]
		public void RemoveShouldHaveUnityRigidbodyToken(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x71E2040", Offset = "0x71E1040", VA = "0x1871E2040")]
		public void ApplyForceVelocityChange(DPIEBFJEGAP GBLKMOHBIIA, Vector3 FJDPGKKBPBE, float CLIOGCOFNBL, float KAMLIANHMOM = 8f, float MCEOKHIBPEH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x71E1F50", Offset = "0x71E0F50", VA = "0x1871E1F50")]
		public void ApplyAngularVelocityChange(MGLJIFAIKHI IODJFNIOCBH, Vector3 FDGCBNNCCHO, float CLOFJPCBILA = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x71E2150", Offset = "0x71E1150", VA = "0x1871E2150")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(MGLJIFAIKHI IODJFNIOCBH, Vector3 DEANJFCCEBG, float GGAABPHIDIK = 7f, float GIFLLGIECLE = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x71E1E90", Offset = "0x71E0E90", VA = "0x1871E1E90")]
		public bool AllowedScaleChange(float BMIGADDGEGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x71E1DB0", Offset = "0x71E0DB0", VA = "0x1871E1DB0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx JBMPHMAENDC, object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x71E3100", Offset = "0x71E2100", VA = "0x1871E3100")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x71E3C30", Offset = "0x71E2C30", VA = "0x1871E3C30")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class DOFKMEHKDFN
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5744E20", Offset = "0x5743E20", VA = "0x185744E20")]
	public static PGOKKAHHEHO FOCDIDELANI(this RigidbodyEx LKIOOPNDJED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void NAEAPBAINIJ(RigidbodyEx IADKAJMLLAB);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JAOEOHPGDII : PICBEADEGJE
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int KICEPIGFOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int HAFBJCFNJOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9A6670", Offset = "0x9A5670", VA = "0x1809A6670", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x84F960", Offset = "0x84E960", VA = "0x18084F960", Slot = "6")]
	public BHPPPFLNDLP LDFDEAOODLK(float KOCGFDLBEIL)
	{
		return default(BHPPPFLNDLP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "7")]
	public void KKDPLFKFCJN(NJOPGCEFCAJ DCGPCJKHCOO, float CADELOLNNHN, HAKHCLDIGMM FDDOOJDLNAH = HAKHCLDIGMM.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "8")]
	public void KKDPLFKFCJN(NJOPGCEFCAJ DCGPCJKHCOO, Transform JJCAGHLDGKF, float CADELOLNNHN, HAKHCLDIGMM FDDOOJDLNAH = HAKHCLDIGMM.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "9")]
	public void NJFDPFPCJPB(NJOPGCEFCAJ DCGPCJKHCOO, [Optional] float? CADELOLNNHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "10")]
	public void HBPDDHHFGHN(NJOPGCEFCAJ HDGCJANEEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x84F960", Offset = "0x84E960", VA = "0x18084F960", Slot = "11")]
	public BHPPPFLNDLP BCBMFIOJFPI(NJOPGCEFCAJ DCGPCJKHCOO)
	{
		return default(BHPPPFLNDLP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8401F0", Offset = "0x83F1F0", VA = "0x1808401F0", Slot = "12")]
	public bool EBJNIFLGNJD(NJOPGCEFCAJ DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "13")]
	public void AHOLOPBOHDB(NJOPGCEFCAJ DCGPCJKHCOO, HAKHCLDIGMM GJDNNICEICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public JAOEOHPGDII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum OPPPJCICLFD
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum MGLJIFAIKHI
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AJHPHPODBKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody JGFIHJJNFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView GOOLNMHKODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 PPIHEANOMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 DHOGHOAHABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public OPPPJCICLFD DJKIFAPPBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool OOHOPJANODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool NBNLNEFEPML;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void OOOCOIFCPAN(RigidbodyEx IADKAJMLLAB, bool BHOCINAFNLF = false);
[Cpp2IlInjected.Token(Token = "0x200000E")]
[JMPMNEIJKCM(typeof(AEADNFNPPOL), new string[] { "Ignore", "Mock" })]
public class FAMDOCOIDDO : AEADNFNPPOL
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool OHPEEDCDJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8401D0", Offset = "0x83F1D0", VA = "0x1808401D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
	public void EIFGPCLHAOO(string NAFECGLLOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "6")]
	public void EMJCGJIECDC(RigidbodyEx LKIOOPNDJED, Action NPNCNABHINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x84F100", Offset = "0x84E100", VA = "0x18084F100", Slot = "7")]
	public PICBEADEGJE BJFBCACEKCF(int DACKCINKBHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "8")]
	public void LJFILGFNOGG(Vector3 PABLOLAHCNH, float JEOPNFDANPP, Color OAIMCLIJEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FAMDOCOIDDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[JMPMNEIJKCM(typeof(FELONCPAKLL), new string[] { })]
public class JNLMILOLOFJ : FELONCPAKLL, DOIBDCNJEIO
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IBIIHCPLHGH KEIKJGHJHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private AEADNFNPPOL JJLHNLMGEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private FKHLLDHDGHI FONPNHLPGCK;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool KMJKBECFLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x57555B0", Offset = "0x57545B0", VA = "0x1857555B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public AEADNFNPPOL FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public FKHLLDHDGHI FIMHDINELGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5755520", Offset = "0x5754520", VA = "0x185755520", Slot = "12")]
	public void InitReferences(MPJBMBNDNGN JHDIKLLGIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5754F70", Offset = "0x5753F70", VA = "0x185754F70", Slot = "7")]
	public KBHBMCLJPDE AGGLMCKEPKC(RigidbodyEx LKIOOPNDJED)
	{
		return default(KBHBMCLJPDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5754E80", Offset = "0x5753E80", VA = "0x185754E80")]
	private static KBHBMCLJPDE AFKNHEDMLBK(RigidbodyEx LKIOOPNDJED)
	{
		return default(KBHBMCLJPDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5755260", Offset = "0x5754260", VA = "0x185755260", Slot = "8")]
	public PGOKKAHHEHO BLGFCJFNMEF(RigidbodyEx LKIOOPNDJED, AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5755450", Offset = "0x5754450", VA = "0x185755450", Slot = "11")]
	private RigidbodyEx IMNGGGECFIA(GameObject IADMJGHOCPL, AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5755600", Offset = "0x5754600", VA = "0x185755600", Slot = "9")]
	public void NEBICCFELML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5755300", Offset = "0x5754300", VA = "0x185755300", Slot = "10")]
	public void GIJKHBPDLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public JNLMILOLOFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class KBCMACFIPCB
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const float BCKBJLLFDFD = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const float CHDBFAJIMKB = 0f;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const float KNEBCNBIEGC = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public KBCMACFIPCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HACJBAFPDMN
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5749E50", Offset = "0x5748E50", VA = "0x185749E50")]
	public static void NEOJLNKLKNO(this Rigidbody FHGFJFLOJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5749FA0", Offset = "0x5748FA0", VA = "0x185749FA0")]
	public static void NEOJLNKLKNO(this Rigidbody FHGFJFLOJOF, Vector3 BNMJFGLNHLE, Quaternion EBDBPGIPHNB, Vector3 CLDFCFBJAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1B82C60", Offset = "0x1B81C60", VA = "0x181B82C60")]
	public static void KODOEPABLLG(Vector3 CBPBBILDPPH, Vector3 MJKKHJFHAJH, out Vector3 LNPHBNGCPLB, out Vector3 MGNCIHGCJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum DPIEBFJEGAP
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DBBLNEJGBIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool NCEMACJLKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool KPLBGMFCADF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event NAEAPBAINIJ JHKGPLGOHDI;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FFBPBJPAOIH();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IIBDJHFLHGI(PGOKKAHHEHO AGFCJPGACCB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOMFHIBHGKD(PGOKKAHHEHO AGFCJPGACCB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KNLDOFJBJFF
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	float LEJJNDENKDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	float DBJKOMDHGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KADDKNGPFNM(Rigidbody JGFIHJJNFEL);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface AEADNFNPPOL
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool OHPEEDCDJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIFGPCLHAOO(string NAFECGLLOCD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMJCGJIECDC(RigidbodyEx LKIOOPNDJED, Action NPNCNABHINE);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PICBEADEGJE BJFBCACEKCF(int DACKCINKBHF);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LJFILGFNOGG(Vector3 PABLOLAHCNH, float JEOPNFDANPP, Color OAIMCLIJEAP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface FELONCPAKLL
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	AEADNFNPPOL FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	FKHLLDHDGHI FIMHDINELGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool KMJKBECFLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KBHBMCLJPDE AGGLMCKEPKC(RigidbodyEx LKIOOPNDJED);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PGOKKAHHEHO BLGFCJFNMEF(RigidbodyEx LKIOOPNDJED, AJHPHPODBKK HCKNMLENIIG);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NEBICCFELML();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GIJKHBPDLMJ();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx AEMDDBNDOIP(GameObject IADMJGHOCPL, [Optional] AJHPHPODBKK HCKNMLENIIG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OEHMLPDIKOF
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx OKBGPHKOCOD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DHALLCIHMFI
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 PDKKMCNOPML
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 BOPECJAMOPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LAMLJEBPIKJ(PGOKKAHHEHO AGFCJPGACCB, object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NPNLGGMOAPA(object DMHDKAFNNAC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal class DPJECINPFIK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly HFMANEIGDON LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool LOOPOECADGB;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5744F00", Offset = "0x5743F00", VA = "0x185744F00")]
	public DPJECINPFIK(HFMANEIGDON LGPLIEDGINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5744EA0", Offset = "0x5743EA0", VA = "0x185744EA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HFMANEIGDON : PGOKKAHHEHO, IDisposable, HHGGFOFDAPI
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const string KKFDKHGLBDI = "HasUnityRigidbodyByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly FELONCPAKLL NKHIMAEJAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal DIGKBAFHJGN OBGGONOGPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal IPHGGGNEIKB CMCFIPOCLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal DBBLNEJGBIA GEAGPMHMJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal INKDAFLPOEI CBPBBILDPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal DHALLCIHMFI AAKKHBLAMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal CFOJAFEIKGD MFFJPDNAEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal KNLDOFJBJFF LOAKNMHIOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal BEIFEOFFBLE EFLMMOMGMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal JEKHLEEDNNE HLLBLKCGCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal CPEOJDCENCO ILCIAAEEEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal JJAPFDMEHGJ MHNNKPKGGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal ANGMHCIONKP CAMEGMHBOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal AJAIBHCMOBA OGEAGHIIJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal JKMKJMODKDA JGFIHJJNFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal EDPGOHNHHHB GCKJHMKKNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal IDisposable HHDFGNMGDBK;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public RigidbodyEx PJOBMDAKLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x842FB0", Offset = "0x841FB0", VA = "0x180842FB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x842EA0", Offset = "0x841EA0", VA = "0x180842EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public GameObject MECJAJFFGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xBEC0C0", Offset = "0xBEB0C0", VA = "0x180BEC0C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xBEC280", Offset = "0xBEB280", VA = "0x180BEC280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Transform NLACIKINHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x574DC60", Offset = "0x574CC60", VA = "0x18574DC60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public IEnumerable<object> PFFMLFEPJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x574E280", Offset = "0x574D280", VA = "0x18574E280", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Rigidbody JAMLFHMHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x574AED0", Offset = "0x5749ED0", VA = "0x18574AED0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public PGOKKAHHEHO PFNKNMFEFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x574F080", Offset = "0x574E080", VA = "0x18574F080", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5750570", Offset = "0x574F570", VA = "0x185750570", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IReadOnlyList<PGOKKAHHEHO> EHLHGICFHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x574BEA0", Offset = "0x574AEA0", VA = "0x18574BEA0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public PGOKKAHHEHO EDABIFLHHKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5750260", Offset = "0x574F260", VA = "0x185750260", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool MMMBPNNCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x574EDF0", Offset = "0x574DDF0", VA = "0x18574EDF0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool NCEMACJLKCK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x574B8F0", Offset = "0x574A8F0", VA = "0x18574B8F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool KPLBGMFCADF
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x574AC10", Offset = "0x5749C10", VA = "0x18574AC10", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public INMIHNLNEJO DEEIHGOOGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x574F6B0", Offset = "0x574E6B0", VA = "0x18574F6B0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x574E910", Offset = "0x574D910", VA = "0x18574E910", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public GGOGJGFNOFN GHAKLGHCKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x574BC30", Offset = "0x574AC30", VA = "0x18574BC30", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x574D160", Offset = "0x574C160", VA = "0x18574D160", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float AKIPAEFKPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x574CEF0", Offset = "0x574BEF0", VA = "0x18574CEF0", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x574D6B0", Offset = "0x574C6B0", VA = "0x18574D6B0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector3 KEIHGAEJKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x574C930", Offset = "0x574B930", VA = "0x18574C930", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x574A850", Offset = "0x5749850", VA = "0x18574A850", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Vector3 OHCDEIMNFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x574BC80", Offset = "0x574AC80", VA = "0x18574BC80", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5750450", Offset = "0x574F450", VA = "0x185750450", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector3 KMIFICDBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x574EAA0", Offset = "0x574DAA0", VA = "0x18574EAA0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x574EE50", Offset = "0x574DE50", VA = "0x18574EE50", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Vector3 JDGPGHDFHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x574EB70", Offset = "0x574DB70", VA = "0x18574EB70", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x574E690", Offset = "0x574D690", VA = "0x18574E690", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool EICCNFFNODM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x574CF40", Offset = "0x574BF40", VA = "0x18574CF40", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool BBPJKLAMKPO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x574ED30", Offset = "0x574DD30", VA = "0x18574ED30", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool NKKJGCMCCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x574AAC0", Offset = "0x5749AC0", VA = "0x18574AAC0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool IBJABDCLBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5750780", Offset = "0x574F780", VA = "0x185750780", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector3 PDKKMCNOPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x574C0A0", Offset = "0x574B0A0", VA = "0x18574C0A0", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 BOPECJAMOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x574FB20", Offset = "0x574EB20", VA = "0x18574FB20", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 FANAKJBNAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x574E160", Offset = "0x574D160", VA = "0x18574E160", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x574F530", Offset = "0x574E530", VA = "0x18574F530", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 HICENODMKJC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x574D990", Offset = "0x574C990", VA = "0x18574D990", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float KDIHEJKAJGN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5750930", Offset = "0x574F930", VA = "0x185750930", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public float FAJFPKHICDI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5750210", Offset = "0x574F210", VA = "0x185750210", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x574DEA0", Offset = "0x574CEA0", VA = "0x18574DEA0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Vector3 JOMNABGJAPG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x574DA60", Offset = "0x574CA60", VA = "0x18574DA60", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Quaternion KLJPCCCHPHG
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x574B0D0", Offset = "0x574A0D0", VA = "0x18574B0D0", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public float LEJJNDENKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x574D810", Offset = "0x574C810", VA = "0x18574D810", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x574E3C0", Offset = "0x574D3C0", VA = "0x18574E3C0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float DBJKOMDHGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x574B5B0", Offset = "0x574A5B0", VA = "0x18574B5B0", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x574B070", Offset = "0x574A070", VA = "0x18574B070", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool KDNLHMAOJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x574B840", Offset = "0x574A840", VA = "0x18574B840", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x574B940", Offset = "0x574A940", VA = "0x18574B940", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public OOPINJNCOHE CCODFDCKKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x574A920", Offset = "0x5749920", VA = "0x18574A920", Slot = "51")]
		get
		{
			return default(OOPINJNCOHE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x574F700", Offset = "0x574E700", VA = "0x18574F700", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool CKANPFJAFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x574B9A0", Offset = "0x574A9A0", VA = "0x18574B9A0", Slot = "53")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Transform KMNEBMCNEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x574B740", Offset = "0x574A740", VA = "0x18574B740", Slot = "54")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Transform NCPLCNGEEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x574B740", Offset = "0x574A740", VA = "0x18574B740", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 AONAJNGLCAI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x57505D0", Offset = "0x574F5D0", VA = "0x1857505D0", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x574E0B0", Offset = "0x574D0B0", VA = "0x18574E0B0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float LKJEGOPOJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x574BC10", Offset = "0x574AC10", VA = "0x18574BC10", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x574B3B0", Offset = "0x574A3B0", VA = "0x18574B3B0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public float KJPOFMHJMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x574BE80", Offset = "0x574AE80", VA = "0x18574BE80", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x574D050", Offset = "0x574C050", VA = "0x18574D050", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Quaternion GIJEMHCFPBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x574F600", Offset = "0x574E600", VA = "0x18574F600", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x574E2D0", Offset = "0x574D2D0", VA = "0x18574E2D0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 FOEBOOGHHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5750520", Offset = "0x574F520", VA = "0x185750520", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x574BAF0", Offset = "0x574AAF0", VA = "0x18574BAF0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Quaternion IMGIAOBGANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x574BA50", Offset = "0x574AA50", VA = "0x18574BA50", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x574FBF0", Offset = "0x574EBF0", VA = "0x18574FBF0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public RigidbodyConstraints CGILPJHJLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x574DE50", Offset = "0x574CE50", VA = "0x18574DE50", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x574B200", Offset = "0x574A200", VA = "0x18574B200", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool LAHGANIGJCO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x57507D0", Offset = "0x574F7D0", VA = "0x1857507D0", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x574D760", Offset = "0x574C760", VA = "0x18574D760", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool LFPNLEAKJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x574DC10", Offset = "0x574CC10", VA = "0x18574DC10", Slot = "132")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CollisionDetectionMode OFODBABDMPD
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x574E230", Offset = "0x574D230", VA = "0x18574E230", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x57509E0", Offset = "0x574F9E0", VA = "0x1857509E0", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool LLEPCFMHOAO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x574F9D0", Offset = "0x574E9D0", VA = "0x18574F9D0", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public bool OJPJLJHGGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x574B420", Offset = "0x574A420", VA = "0x18574B420", Slot = "74")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool NMLIEAEMDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x57503A0", Offset = "0x574F3A0", VA = "0x1857503A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool LJCMPDIPIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x574BE40", Offset = "0x574AE40", VA = "0x18574BE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event NAEAPBAINIJ OPNOJLLMOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x57508D0", Offset = "0x574F8D0", VA = "0x1857508D0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x574E760", Offset = "0x574D760", VA = "0x18574E760", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event NAEAPBAINIJ PMBDNOEKOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x574B350", Offset = "0x574A350", VA = "0x18574B350", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x574B1A0", Offset = "0x574A1A0", VA = "0x18574B1A0", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event OOOCOIFCPAN HKAKBOHPJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x574F7C0", Offset = "0x574E7C0", VA = "0x18574F7C0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x574A7F0", Offset = "0x57497F0", VA = "0x18574A7F0", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event NAEAPBAINIJ JHKGPLGOHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x574F970", Offset = "0x574E970", VA = "0x18574F970", Slot = "86")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x574F820", Offset = "0x574E820", VA = "0x18574F820", Slot = "87")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event NAEAPBAINIJ NAOMFIIDBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x574E7C0", Offset = "0x574D7C0", VA = "0x18574E7C0", Slot = "106")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x574CF90", Offset = "0x574BF90", VA = "0x18574CF90", Slot = "107")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event NAEAPBAINIJ GHLEIGCIOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x574BA90", Offset = "0x574AA90", VA = "0x18574BA90", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x574B6E0", Offset = "0x574A6E0", VA = "0x18574B6E0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<BHPPPFLNDLP, BHPPPFLNDLP> PDDABMIIDFO
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5750A40", Offset = "0x574FA40", VA = "0x185750A40", Slot = "115")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x574AC60", Offset = "0x5749C60", VA = "0x18574AC60", Slot = "116")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event NAEAPBAINIJ ENNFPKIDCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x574D860", Offset = "0x574C860", VA = "0x18574D860", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x574CFF0", Offset = "0x574BFF0", VA = "0x18574CFF0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event NAEAPBAINIJ KPLEICBNMED
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x574BDA0", Offset = "0x574ADA0", VA = "0x18574BDA0", Slot = "123")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x574C550", Offset = "0x574B550", VA = "0x18574C550", Slot = "124")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5750C10", Offset = "0x574FC10", VA = "0x185750C10")]
	public HFMANEIGDON(GameObject IHNGPGNCBCG, RigidbodyEx JIGNMEKGFID, FELONCPAKLL NKHIMAEJAFL, in AJHPHPODBKK HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x574F180", Offset = "0x574E180", VA = "0x18574F180", Slot = "142")]
	protected virtual void LOJJMKNMIBI(FELONCPAKLL NKHIMAEJAFL, AJHPHPODBKK HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x574BB40", Offset = "0x574AB40", VA = "0x18574BB40", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x574C610", Offset = "0x574B610", VA = "0x18574C610", Slot = "75")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x574B020", Offset = "0x574A020", VA = "0x18574B020", Slot = "76")]
	public void LFLKHHIPBKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x574C5F0", Offset = "0x574B5F0", VA = "0x18574C5F0", Slot = "77")]
	public void FCHBKGHJNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x574CA50", Offset = "0x574BA50", VA = "0x18574CA50")]
	private void FKCLEOPDOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x574F010", Offset = "0x574E010", VA = "0x18574F010", Slot = "85")]
	public void LMENPCDIGEL(PGOKKAHHEHO CKMKMNKGMMC, bool BHOCINAFNLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x574B9F0", Offset = "0x574A9F0", VA = "0x18574B9F0", Slot = "88")]
	public void DFGPMLEBMJJ(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x574B890", Offset = "0x574A890", VA = "0x18574B890", Slot = "89")]
	public void CJCDHBCKLGP(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5750690", Offset = "0x574F690", VA = "0x185750690", Slot = "90")]
	public Vector3 ONJAKBBCCOC(Vector3 CLHHPAFJIIP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x574B750", Offset = "0x574A750", VA = "0x18574B750", Slot = "91")]
	public Vector3 CIKMBONDBGE(Vector3 PECLNPLFMIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x574B020", Offset = "0x574A020", VA = "0x18574B020", Slot = "92")]
	public void BCJLHNGAJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5750B80", Offset = "0x574FB80", VA = "0x185750B80", Slot = "93")]
	public void PPDOFFGMEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x574ACC0", Offset = "0x5749CC0", VA = "0x18574ACC0", Slot = "94")]
	public void AOCAHOFFDPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x574F880", Offset = "0x574E880", VA = "0x18574F880", Slot = "95")]
	public void MKIIGHBCAHE(Vector3 KBONMJFJLJN, Vector3 HGFKCPDNNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x574A970", Offset = "0x5749970", VA = "0x18574A970", Slot = "96")]
	public void ADLAMFEDDPP(Vector3 HFEPHLDDIBH, Vector3 PFMLKPNBNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x574E970", Offset = "0x574D970", VA = "0x18574E970", Slot = "97")]
	public void KHDCIDOGGHM(Vector3 LHJMJCLHHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5750100", Offset = "0x574F100", VA = "0x185750100", Slot = "98")]
	public void NMIDMGEDAJO(DPIEBFJEGAP GBLKMOHBIIA, Vector3 FJDPGKKBPBE, float CLIOGCOFNBL, float KAMLIANHMOM = 8f, float MCEOKHIBPEH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x574ADE0", Offset = "0x5749DE0", VA = "0x18574ADE0", Slot = "99")]
	public void APICAINOGOA(MGLJIFAIKHI IODJFNIOCBH, Vector3 FDGCBNNCCHO, float CLOFJPCBILA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x574FE10", Offset = "0x574EE10", VA = "0x18574FE10", Slot = "100")]
	[Obsolete]
	public void NHIKFAIIBFN(MGLJIFAIKHI IODJFNIOCBH, Vector3 DEANJFCCEBG, float GGAABPHIDIK = 7f, float GIFLLGIECLE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x574E820", Offset = "0x574D820", VA = "0x18574E820", Slot = "101")]
	public Vector3 KENOPHFFKMB(Vector3 CKMKMNKGMMC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x574EF20", Offset = "0x574DF20", VA = "0x18574EF20", Slot = "102")]
	public Vector3 LIBLGGNHIIC(Vector3 CKMKMNKGMMC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x574DE00", Offset = "0x574CE00", VA = "0x18574DE00", Slot = "103")]
	public void JCNGJHGPHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x574FF10", Offset = "0x574EF10", VA = "0x18574FF10", Slot = "104")]
	public void NIHKPNJMEPO(PGOKKAHHEHO JBMPHMAENDC, object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5750870", Offset = "0x574F870", VA = "0x185750870", Slot = "105")]
	public void PFMJNOHCDPN(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5750AA0", Offset = "0x574FAA0", VA = "0x185750AA0", Slot = "44")]
	public void PNFOHBMEGIE((Quaternion rot, Vector3 moments) DJHFDNAEBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x574B260", Offset = "0x574A260", VA = "0x18574B260", Slot = "108")]
	public void BKDFAKEJMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x574D580", Offset = "0x574C580", VA = "0x18574D580", Slot = "109")]
	public void HMNJMGPIBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x574CA00", Offset = "0x574BA00", VA = "0x18574CA00", Slot = "110")]
	public void FIKLNLECMNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x574D7C0", Offset = "0x574C7C0", VA = "0x18574D7C0", Slot = "113")]
	public bool IEGPOINMBNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x574BD50", Offset = "0x574AD50", VA = "0x18574BD50", Slot = "78")]
	public void EJHKPCBFHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x574E370", Offset = "0x574D370", VA = "0x18574E370", Slot = "114")]
	public void JLGCCFNGGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5750820", Offset = "0x574F820", VA = "0x185750820", Slot = "119")]
	public IDisposable PFBIGGEBPLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x574ABB0", Offset = "0x5749BB0", VA = "0x18574ABB0", Slot = "120")]
	public void AJCGMBJNPHE(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5750980", Offset = "0x574F980", VA = "0x185750980", Slot = "121")]
	public void PMHMAKBGFHM(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x574D220", Offset = "0x574C220", VA = "0x18574D220", Slot = "122")]
	public void HLAJEEHODPC(object DMHDKAFNNAC, bool CLCDDMLICOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x574E420", Offset = "0x574D420", VA = "0x18574E420", Slot = "125")]
	public void KBDEKKAEHBE(Vector3 ECLJOKGPADO, Quaternion ODAOAJLFHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x574BEF0", Offset = "0x574AEF0", VA = "0x18574BEF0", Slot = "126")]
	public void EOFKEOHKDCO(Vector3 JOIOANBLCDC, Quaternion IKEPFBIAAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x574D1C0", Offset = "0x574C1C0", VA = "0x18574D1C0", Slot = "127")]
	public bool HCEGGNLAINK(float BMIGADDGEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x574EC40", Offset = "0x574DC40", VA = "0x18574EC40", Slot = "128")]
	public void LAODGHJPBMD(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x574AA60", Offset = "0x5749A60", VA = "0x18574AA60", Slot = "129")]
	public void AGKEMDFOHFA(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x574EA40", Offset = "0x574DA40", VA = "0x18574EA40", Slot = "130")]
	public void KHFFFCKDFKC(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x574ED90", Offset = "0x574DD90", VA = "0x18574ED90", Slot = "131")]
	public void LEPHDJGCOHN(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x574B2B0", Offset = "0x574A2B0", VA = "0x18574B2B0")]
	public void BKNDHAMJEMM(object DMHDKAFNNAC, bool LOAKNOKOKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x574B600", Offset = "0x574A600", VA = "0x18574B600", Slot = "133")]
	public void CFFCBFDJPAE(Vector3 CAMEGMHBOIN, ForceMode CNNCDLOEBGE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x574DCF0", Offset = "0x574CCF0", VA = "0x18574DCF0", Slot = "134")]
	public void JCKNNNFADKD(Vector3 CAMEGMHBOIN, Vector3 EDEGPGKBEGA, ForceMode CNNCDLOEBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x574D5D0", Offset = "0x574C5D0", VA = "0x18574D5D0", Slot = "135")]
	public void HOJGAPDCCAI(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x574DB30", Offset = "0x574CB30", VA = "0x18574DB30", Slot = "136")]
	public void IPEBCCKLCEG(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x57502B0", Offset = "0x574F2B0", VA = "0x1857502B0", Slot = "137")]
	public bool NPINOOHNIBD(Vector3 HAMNFFBEFHD, out RaycastHit GOKLGMJIOLJ, float OLGGKIEPHEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x574D710", Offset = "0x574C710", VA = "0x18574D710", Slot = "138")]
	public void IDGGELLJBNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5750BD0", Offset = "0x574FBD0", VA = "0x185750BD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x574AD10", Offset = "0x5749D10", VA = "0x18574AD10")]
	private void APEFBHOGPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x574DF00", Offset = "0x574CF00", VA = "0x18574DF00")]
	private void JGKAMHPJBBK(PGOKKAHHEHO AGFCJPGACCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x574C750", Offset = "0x574B750", VA = "0x18574C750")]
	private void FFDECJPCFOI(PGOKKAHHEHO AGFCJPGACCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x574F0D0", Offset = "0x574E0D0", VA = "0x18574F0D0")]
	private void LNJFGGAOFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x574AF20", Offset = "0x5749F20", VA = "0x18574AF20")]
	private void BBKECCHMDBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x574FC30", Offset = "0x574EC30", VA = "0x18574FC30")]
	private void NGPFBNDBLOO(PGOKKAHHEHO GAOHEHNIPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x574D8C0", Offset = "0x574C8C0", VA = "0x18574D8C0")]
	private void IIBDJHFLHGI(PGOKKAHHEHO AGFCJPGACCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x574F460", Offset = "0x574E460", VA = "0x18574F460")]
	private void LOMFHIBHGKD(PGOKKAHHEHO AGFCJPGACCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x574CD80", Offset = "0x574BD80", VA = "0x18574CD80")]
	private void GDFGFOKLJMG(RigidbodyEx AGFCJPGACCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x574CB00", Offset = "0x574BB00", VA = "0x18574CB00", Slot = "144")]
	protected virtual void FPHHHBILNKM(RigidbodyEx LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x574FFD0", Offset = "0x574EFD0", VA = "0x18574FFD0")]
	[Conditional("UNITY_EDITOR")]
	private void NIIIADJNCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x574D290", Offset = "0x574C290", VA = "0x18574D290")]
	protected void HLCGIMEJKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x574C170", Offset = "0x574B170", VA = "0x18574C170")]
	protected void EPNFJFHMEPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x574ECA0", Offset = "0x574DCA0", VA = "0x18574ECA0", Slot = "145")]
	protected virtual IDisposable LCADNKNIGFD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal static class KENCLOEAGBC
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5755870", Offset = "0x5754870", VA = "0x185755870")]
	public static PGOKKAHHEHO JJCCGBIGJDC(this PGOKKAHHEHO LKIOOPNDJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5755930", Offset = "0x5754930", VA = "0x185755930")]
	public static bool KMGPJBMFOJD(this PGOKKAHHEHO LKIOOPNDJED, PGOKKAHHEHO OLDACADPMCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x57557F0", Offset = "0x57547F0", VA = "0x1857557F0")]
	public static bool GBALPINKILD(this PGOKKAHHEHO LKIOOPNDJED, PGOKKAHHEHO FDGCNGELLJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x57559B0", Offset = "0x57549B0", VA = "0x1857559B0")]
	public static RigidbodyEx PJOBMDAKLAG(this PGOKKAHHEHO FOCDIDELANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5755780", Offset = "0x5754780", VA = "0x185755780")]
	public static HFMANEIGDON EBJCBMKLLCL(this PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface CFOJAFEIKGD
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 FANAKJBNAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 HICENODMKJC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float KDIHEJKAJGN
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float FAJFPKHICDI
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 JOMNABGJAPG
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Quaternion KLJPCCCHPHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event NAEAPBAINIJ BDPFCIBLIED;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PNFOHBMEGIE((Quaternion rot, Vector3 moments) DJHFDNAEBGF);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HMNJMGPIBNK();

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BKDFAKEJMBB();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FIKLNLECMNC();

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KADDKNGPFNM(Rigidbody JGFIHJJNFEL);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IDGGELLJBNJ();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface HHGGFOFDAPI
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool LLEPCFMHOAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PGOKKAHHEHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Rigidbody JAMLFHMHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	RigidbodyEx PJOBMDAKLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	GameObject MECJAJFFGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Transform NLACIKINHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	IEnumerable<object> PFFMLFEPJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	PGOKKAHHEHO PFNKNMFEFND
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	IReadOnlyList<PGOKKAHHEHO> EHLHGICFHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	PGOKKAHHEHO EDABIFLHHKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool MMMBPNNCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool NCEMACJLKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool KPLBGMFCADF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	INMIHNLNEJO DEEIHGOOGBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	GGOGJGFNOFN GHAKLGHCKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	float AKIPAEFKPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Vector3 KEIHGAEJKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Vector3 OHCDEIMNFIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Vector3 KMIFICDBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 JDGPGHDFHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool EICCNFFNODM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool BBPJKLAMKPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool NKKJGCMCCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool IBJABDCLBGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Vector3 PDKKMCNOPML
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Vector3 BOPECJAMOPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Vector3 FANAKJBNAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Vector3 HICENODMKJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	float KDIHEJKAJGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	float FAJFPKHICDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Vector3 JOMNABGJAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Quaternion KLJPCCCHPHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	float LEJJNDENKDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	float DBJKOMDHGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool KDNLHMAOJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	OOPINJNCOHE CCODFDCKKMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool CKANPFJAFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	Transform KMNEBMCNEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Transform NCPLCNGEEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 AONAJNGLCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	float LKJEGOPOJPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	float KJPOFMHJMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Quaternion GIJEMHCFPBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	Vector3 FOEBOOGHHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Quaternion IMGIAOBGANG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	RigidbodyConstraints CGILPJHJLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool LAHGANIGJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	CollisionDetectionMode OFODBABDMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool OJPJLJHGGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool LFPNLEAKJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(Slot = "128")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event NAEAPBAINIJ OPNOJLLMOJI;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event NAEAPBAINIJ PMBDNOEKOAB;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event OOOCOIFCPAN HKAKBOHPJCD;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event NAEAPBAINIJ JHKGPLGOHDI;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event NAEAPBAINIJ NAOMFIIDBJM;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event NAEAPBAINIJ GHLEIGCIOGD;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event Action<BHPPPFLNDLP, BHPPPFLNDLP> PDDABMIIDFO;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event NAEAPBAINIJ ENNFPKIDCJI;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event NAEAPBAINIJ KPLEICBNMED;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void PNFOHBMEGIE((Quaternion rot, Vector3 moments) DJHFDNAEBGF);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void FFBPBJPAOIH();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void LFLKHHIPBKP();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void FCHBKGHJNKE();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void EJHKPCBFHFD();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void LMENPCDIGEL(PGOKKAHHEHO CKMKMNKGMMC, bool BHOCINAFNLF = false);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void DFGPMLEBMJJ(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void CJCDHBCKLGP(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "86")]
	Vector3 ONJAKBBCCOC(Vector3 CLHHPAFJIIP);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "87")]
	Vector3 CIKMBONDBGE(Vector3 PECLNPLFMIH);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void BCJLHNGAJNG();

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void PPDOFFGMEKA();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void AOCAHOFFDPO();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void MKIIGHBCAHE(Vector3 KBONMJFJLJN, Vector3 HGFKCPDNNFO);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void ADLAMFEDDPP(Vector3 HFEPHLDDIBH, Vector3 PFMLKPNBNHP);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void KHDCIDOGGHM(Vector3 LHJMJCLHHMC);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void NMIDMGEDAJO(DPIEBFJEGAP GBLKMOHBIIA, Vector3 FJDPGKKBPBE, float CLIOGCOFNBL, float KAMLIANHMOM = 8f, float MCEOKHIBPEH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void APICAINOGOA(MGLJIFAIKHI IODJFNIOCBH, Vector3 FDGCBNNCCHO, float CLOFJPCBILA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void NHIKFAIIBFN(MGLJIFAIKHI IODJFNIOCBH, Vector3 DEANJFCCEBG, float GGAABPHIDIK = 7f, float GIFLLGIECLE = 1f);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 KENOPHFFKMB(Vector3 CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 LIBLGGNHIIC(Vector3 CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void JCNGJHGPHGB();

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void NIHKPNJMEPO(PGOKKAHHEHO JBMPHMAENDC, object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void PFMJNOHCDPN(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void BKDFAKEJMBB();

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void HMNJMGPIBNK();

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void FIKLNLECMNC();

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "109")]
	bool IEGPOINMBNK();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void JLGCCFNGGOO();

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "115")]
	IDisposable PFBIGGEBPLP();

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void AJCGMBJNPHE(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void PMHMAKBGFHM(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void HLAJEEHODPC(object DMHDKAFNNAC, bool CLCDDMLICOJ);

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void KBDEKKAEHBE(Vector3 ECLJOKGPADO, Quaternion ODAOAJLFHCD);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void EOFKEOHKDCO(Vector3 JOIOANBLCDC, Quaternion IKEPFBIAAPE);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool HCEGGNLAINK(float BMIGADDGEGN);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void LAODGHJPBMD(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void AGKEMDFOHFA(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void KHFFFCKDFKC(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void LEPHDJGCOHN(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void CFFCBFDJPAE(Vector3 CAMEGMHBOIN, ForceMode CNNCDLOEBGE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void JCKNNNFADKD(Vector3 CAMEGMHBOIN, Vector3 EDEGPGKBEGA, ForceMode CNNCDLOEBGE);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void HOJGAPDCCAI(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void IPEBCCKLCEG(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "133")]
	bool NPINOOHNIBD(Vector3 HAMNFFBEFHD, out RaycastHit GOKLGMJIOLJ, float OLGGKIEPHEF);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "134")]
	void IDGGELLJBNJ();

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "135")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface ANGMHCIONKP
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFFCBFDJPAE(Vector3 CAMEGMHBOIN, ForceMode CNNCDLOEBGE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCKNNNFADKD(Vector3 CAMEGMHBOIN, Vector3 EDEGPGKBEGA, ForceMode CNNCDLOEBGE);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HOJGAPDCCAI(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IPEBCCKLCEG(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface INMIHNLNEJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 OMOBMEMDMPD();

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 EMJIOMJCDMD();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IPHGGGNEIKB
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool IENMIFAEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	HLLHIAHOMMI JMCLDIIMPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFBPBJPAOIH();

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KGFJABCJONK(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OACKPDFEEIO(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void APLNENFJNBG(PGOKKAHHEHO LKIOOPNDJED);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EGKLFNLNAFN(PGOKKAHHEHO LKIOOPNDJED);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LLDANDPGOOE();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface CPEOJDCENCO : IDisposable, NJOPGCEFCAJ
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	OOPINJNCOHE CCODFDCKKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<BHPPPFLNDLP, BHPPPFLNDLP> PDDABMIIDFO;

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FFBPBJPAOIH();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DIGKBAFHJGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	IReadOnlyList<PGOKKAHHEHO> EHLHGICFHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	PGOKKAHHEHO EDABIFLHHKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	PGOKKAHHEHO PFNKNMFEFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event NAEAPBAINIJ OPNOJLLMOJI;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event NAEAPBAINIJ PMBDNOEKOAB;

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	event OOOCOIFCPAN HKAKBOHPJCD;

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	event Action CNMNJJFJOFE;

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	event Action CNPNDJMFLPN;

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	event Action<PGOKKAHHEHO> HKHCEAKLADN;

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	event Action<PGOKKAHHEHO> KLPLJJFKLOD;

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	event Action EPGJDKNBLNJ;

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	event Action<PGOKKAHHEHO> DLEGFCOPGAC;

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LMENPCDIGEL(PGOKKAHHEHO COLDPDBGEPD, bool BHOCINAFNLF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface FKHLLDHDGHI
{
	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DIGKBAFHJGN AJMFIKCABLJ(PGOKKAHHEHO DAHEHNAMFLD);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	INKDAFLPOEI KNJHGOEKNDM(PGOKKAHHEHO DAHEHNAMFLD);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DHALLCIHMFI BHINEDMILHG(PGOKKAHHEHO DAHEHNAMFLD);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KNLDOFJBJFF HMBBKDFCHDC(PGOKKAHHEHO DAHEHNAMFLD);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JEKHLEEDNNE IDJFFPLDNJC(PGOKKAHHEHO DAHEHNAMFLD);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CPEOJDCENCO FGHFIKDAOEJ(PGOKKAHHEHO DAHEHNAMFLD);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JJAPFDMEHGJ CJNHGOAJOHH(PGOKKAHHEHO DAHEHNAMFLD);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ANGMHCIONKP FKDCBIFNEDD(PGOKKAHHEHO DAHEHNAMFLD);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EDPGOHNHHHB JDLEBPLBDCJ(PGOKKAHHEHO DAHEHNAMFLD);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BEIFEOFFBLE DIGPIOBGMIG(PGOKKAHHEHO DAHEHNAMFLD);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JKMKJMODKDA PLEMCLILPDM(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DBBLNEJGBIA BCDKNDPILEF(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IPHGGGNEIKB IPBNIGFILLG(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CFOJAFEIKGD LHAKMEPKBKI(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AJAIBHCMOBA MOIMPCLBEPM(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PGOKKAHHEHO BLGFCJFNMEF(RigidbodyEx LKIOOPNDJED, AJHPHPODBKK HCKNMLENIIG, FELONCPAKLL NKHIMAEJAFL);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface AJAIBHCMOBA
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool LAHGANIGJCO
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool FHIMOODIBAG
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	RigidbodyConstraints CGILPJHJLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KADDKNGPFNM(Rigidbody JGFIHJJNFEL);

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GGOGJGFNOFN
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBPPBEDMEGH(Vector3 CBIFKKDOJKG);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KEEABBBDKCH(Vector3 NJBJCPFKCBL);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCAHHGJHELB(Vector3 CBIFKKDOJKG);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELEFENNOLPM(Vector3 NJBJCPFKCBL);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface JJAPFDMEHGJ
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool CKANPFJAFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	IEnumerable<object> IMCBDIIHPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	event NAEAPBAINIJ ENNFPKIDCJI;

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EAOHNEHNLDF();

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AJCGMBJNPHE(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PMHMAKBGFHM(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HLAJEEHODPC(object DMHDKAFNNAC, bool CLCDDMLICOJ);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IDisposable PFBIGGEBPLP();

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KADDKNGPFNM(Rigidbody GMKHAHOBJGG);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface EDPGOHNHHHB
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	CollisionDetectionMode OFODBABDMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFBPBJPAOIH();

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JLDFKKEAHIF(bool LFKOLODLPAO);

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EEKLGJDOJHC(bool LFKOLODLPAO);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KADDKNGPFNM(Rigidbody JGFIHJJNFEL);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NPINOOHNIBD(Vector3 HAMNFFBEFHD, out RaycastHit GOKLGMJIOLJ, float OLGGKIEPHEF);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface INKDAFLPOEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	INMIHNLNEJO DEEIHGOOGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	GGOGJGFNOFN GHAKLGHCKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Vector3 KMIFICDBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Vector3 KEIHGAEJKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Vector3 JDGPGHDFHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	Vector3 OHCDEIMNFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	float AKIPAEFKPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	bool IBJABDCLBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FFBPBJPAOIH();

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MGMNJDCIKFP(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void APICAINOGOA(MGLJIFAIKHI IODJFNIOCBH, Vector3 FDGCBNNCCHO, float CLOFJPCBILA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NMIDMGEDAJO(DPIEBFJEGAP GBLKMOHBIIA, Vector3 FJDPGKKBPBE, float CLIOGCOFNBL, float KAMLIANHMOM = 8f, float MCEOKHIBPEH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NHIKFAIIBFN(MGLJIFAIKHI IODJFNIOCBH, Vector3 DEANJFCCEBG, float GGAABPHIDIK = 7f, float GIFLLGIECLE = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AOCAHOFFDPO();

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PPDOFFGMEKA();

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JCNGJHGPHGB();

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BCJLHNGAJNG();

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KADDKNGPFNM(Rigidbody JGFIHJJNFEL);

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 LIBLGGNHIIC(Vector3 NJBJCPFKCBL);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 KENOPHFFKMB(Vector3 CBPBBILDPPH);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KGBJMFHCBKK(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KHDCIDOGGHM(Vector3 LHJMJCLHHMC);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void ADLAMFEDDPP(Vector3 HFEPHLDDIBH, Vector3 PFMLKPNBNHP);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MKIIGHBCAHE(Vector3 KBONMJFJLJN, Vector3 HGFKCPDNNFO);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 CIKMBONDBGE(Vector3 PECLNPLFMIH);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 ONJAKBBCCOC(Vector3 CLHHPAFJIIP);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface JKMKJMODKDA
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	Rigidbody JAMLFHMHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	bool LFPNLEAKJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFBPBJPAOIH();

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHFFFCKDFKC(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LEPHDJGCOHN(object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ICFEOPJKFOG();

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KNNKGJDHBMC();

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IDEBJNDGGJF();

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MLPJEJECGHH();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BEIFEOFFBLE
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	bool KDNLHMAOJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KADDKNGPFNM(Rigidbody JGFIHJJNFEL);

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JEKHLEEDNNE
{
	[Cpp2IlInjected.Token(Token = "0x14000029")]
	event NAEAPBAINIJ GHLEIGCIOGD;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFBPBJPAOIH();

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IEGPOINMBNK();

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KKEIJCIPBPF();

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EJHKPCBFHFD();

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KBPBCMDNJJN();

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JLGCCFNGGOO();

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OCLBMPFKCPH(bool FNJGCLCOPHG);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[JMPMNEIJKCM(typeof(FLMCOMAFMDP), new string[] { })]
public sealed class FFGBCAKGKMK : DOIBDCNJEIO, FLMCOMAFMDP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[GHKGLEOFKBF]
	private GJAFPLOBCJA LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool LOOPOECADGB;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool BLPCIPDEODE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x979400", Offset = "0x978400", VA = "0x180979400", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5745780", Offset = "0x5744780", VA = "0x185745780", Slot = "4")]
	public void InitReferences(MPJBMBNDNGN JHDIKLLGIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x57451F0", Offset = "0x57441F0", VA = "0x1857451F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5745220", Offset = "0x5744220", VA = "0x185745220", Slot = "6")]
	public void FJOEOCBDDOD(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x57453A0", Offset = "0x57443A0", VA = "0x1857453A0", Slot = "7")]
	public void FKODKJCDMNN(KBHBMCLJPDE AAGHLALAEIJ, bool PFOBFJJHOLK, bool KGOPIKFEEBM, bool DGFAACNGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x57450C0", Offset = "0x57440C0", VA = "0x1857450C0")]
	private bool DFEJNAEDHNO(KBHBMCLJPDE AAGHLALAEIJ, out JHFFHCFJIAF DAHEHNAMFLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5745620", Offset = "0x5744620", VA = "0x185745620")]
	private bool GENDAHNLCJG(KBHBMCLJPDE AAGHLALAEIJ, out ALJKOBDKAMF MILCNAMNFON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x57457D0", Offset = "0x57447D0", VA = "0x1857457D0")]
	private bool JIHMDKMGCEK(KBHBMCLJPDE AAGHLALAEIJ, out CNGEBLLDGOM JNKFHIHDLKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FFGBCAKGKMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class CNGEBLLDGOM : GBIHHFPOGOE, CFOJAFEIKGD
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	[Obsolete]
	public Vector3 FANAKJBNAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x57421F0", Offset = "0x57411F0", VA = "0x1857421F0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x573FE70", Offset = "0x573EE70", VA = "0x18573FE70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 MALEDKBPAEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x573F520", Offset = "0x573E520", VA = "0x18573F520")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x573FE70", Offset = "0x573EE70", VA = "0x18573FE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 ANFCNDOLNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x573FEA0", Offset = "0x573EEA0", VA = "0x18573FEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	[Obsolete]
	public Vector3 HICENODMKJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5741EB0", Offset = "0x5740EB0", VA = "0x185741EB0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete]
	public float KDIHEJKAJGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5742BA0", Offset = "0x5741BA0", VA = "0x185742BA0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float CAMFFBBDOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x573F980", Offset = "0x573E980", VA = "0x18573F980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public float FAJFPKHICDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x5742610", Offset = "0x5741610", VA = "0x185742610", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x573F880", Offset = "0x573E880", VA = "0x18573F880", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 JOMNABGJAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x5742120", Offset = "0x5741120", VA = "0x185742120", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public Quaternion KLJPCCCHPHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x573FBB0", Offset = "0x573EBB0", VA = "0x18573FBB0", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private Rigidbody JAMLFHMHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5738C90", Offset = "0x5737C90", VA = "0x185738C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event NAEAPBAINIJ BDPFCIBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x57414B0", Offset = "0x57404B0", VA = "0x1857414B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5742150", Offset = "0x5741150", VA = "0x185742150", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x5742EE0", Offset = "0x5741EE0", VA = "0x185742EE0")]
	public CNGEBLLDGOM(PGOKKAHHEHO LKIOOPNDJED, in AJHPHPODBKK HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x57418D0", Offset = "0x57408D0", VA = "0x1857418D0")]
	public float3 HOICDJKOIAE()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x5742030", Offset = "0x5741030", VA = "0x185742030")]
	public bool IJMKJMJKCJN(out float3 PABLOLAHCNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5742450", Offset = "0x5741450", VA = "0x185742450")]
	public void KBPDJNJKOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5742520", Offset = "0x5741520", VA = "0x185742520")]
	public bool LDNBHHJNCBC(out float AJCOFMJAECD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x5742C70", Offset = "0x5741C70", VA = "0x185742C70", Slot = "14")]
	public void PNFOHBMEGIE((Quaternion rot, Vector3 moments) DJHFDNAEBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x573FBE0", Offset = "0x573EBE0", VA = "0x18573FBE0", Slot = "16")]
	public void BKDFAKEJMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5741550", Offset = "0x5740550", VA = "0x185741550", Slot = "15")]
	public void HMNJMGPIBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5742310", Offset = "0x5741310", VA = "0x185742310", Slot = "18")]
	public void KADDKNGPFNM(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x57426E0", Offset = "0x57416E0", VA = "0x1857426E0", Slot = "19")]
	public void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x573FFD0", Offset = "0x573EFD0", VA = "0x18573FFD0", Slot = "17")]
	public void FIKLNLECMNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5741990", Offset = "0x5740990", VA = "0x185741990", Slot = "20")]
	public void IDGGELLJBNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5736040", Offset = "0x5735040", VA = "0x185736040")]
	public void LFFFOAPCMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x573FA70", Offset = "0x573EA70", VA = "0x18573FA70")]
	private void BAIHNMBNODH(Vector3 CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5742A30", Offset = "0x5741A30", VA = "0x185742A30")]
	[Obsolete]
	private Vector3 PAMJJKECFKP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x573F880", Offset = "0x573E880", VA = "0x18573F880")]
	private void AGNBCADBCOP(float CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x573F640", Offset = "0x573E640", VA = "0x18573F640")]
	private Vector3 ACKCLLFIAPG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5741280", Offset = "0x5740280", VA = "0x185741280")]
	private Quaternion GDELILPLAAN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x57400A0", Offset = "0x573F0A0", VA = "0x1857400A0")]
	internal (float, Vector3) FJOEOCBDDOD(Rigidbody DINFEDLPKCI)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class BIDGGMENMBH
{
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5739560", Offset = "0x5738560", VA = "0x185739560")]
	public static CNGEBLLDGOM DPDLIPKABGI(this PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class LBCCPHDCJDF : GBIHHFPOGOE, INKDAFLPOEI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public INMIHNLNEJO DEEIHGOOGBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x575AB20", Offset = "0x5759B20", VA = "0x18575AB20", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x575A4F0", Offset = "0x57594F0", VA = "0x18575A4F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public GGOGJGFNOFN GHAKLGHCKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5759370", Offset = "0x5758370", VA = "0x185759370", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x5759A50", Offset = "0x5758A50", VA = "0x185759A50", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 KMIFICDBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x575A8A0", Offset = "0x57598A0", VA = "0x18575A8A0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x575A960", Offset = "0x5759960", VA = "0x18575A960", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 KEIHGAEJKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5759950", Offset = "0x5758950", VA = "0x185759950", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x57585D0", Offset = "0x57575D0", VA = "0x1857585D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 JDGPGHDFHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x575A900", Offset = "0x5759900", VA = "0x18575A900", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5759EC0", Offset = "0x5758EC0", VA = "0x185759EC0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public Vector3 OHCDEIMNFIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x57594A0", Offset = "0x57584A0", VA = "0x1857594A0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x575BB20", Offset = "0x575AB20", VA = "0x18575BB20", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float AKIPAEFKPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x5759980", Offset = "0x5758980", VA = "0x185759980", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x5759B40", Offset = "0x5758B40", VA = "0x185759B40", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool IBJABDCLBGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x575BD30", Offset = "0x575AD30", VA = "0x18575BD30", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private ANGMHCIONKP JCMFPPOFCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x21AF4A0", Offset = "0x21AE4A0", VA = "0x1821AF4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool LLEPCFMHOAO
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x573D390", Offset = "0x573C390", VA = "0x18573D390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5734D80", Offset = "0x5733D80", VA = "0x185734D80")]
	public LBCCPHDCJDF(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x575AC50", Offset = "0x5759C50", VA = "0x18575AC50", Slot = "20")]
	public void MGMNJDCIKFP(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x575A5E0", Offset = "0x57595E0", VA = "0x18575A5E0", Slot = "31")]
	public void KGBJMFHCBKK(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x57588E0", Offset = "0x57578E0", VA = "0x1857588E0", Slot = "19")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5759240", Offset = "0x5758240", VA = "0x185759240", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5759E80", Offset = "0x5758E80", VA = "0x185759E80", Slot = "28")]
	public void KADDKNGPFNM(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x575BB50", Offset = "0x575AB50", VA = "0x18575BB50", Slot = "36")]
	public Vector3 ONJAKBBCCOC(Vector3 CLHHPAFJIIP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5759020", Offset = "0x5758020", VA = "0x185759020", Slot = "35")]
	public Vector3 CIKMBONDBGE(Vector3 PECLNPLFMIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x57588E0", Offset = "0x57578E0", VA = "0x1857588E0", Slot = "27")]
	public void BCJLHNGAJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x575BE10", Offset = "0x575AE10", VA = "0x18575BE10", Slot = "25")]
	public void PPDOFFGMEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5758660", Offset = "0x5757660", VA = "0x185758660", Slot = "24")]
	public void AOCAHOFFDPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x575AD40", Offset = "0x5759D40", VA = "0x18575AD40", Slot = "34")]
	public void MKIIGHBCAHE(Vector3 KBONMJFJLJN, Vector3 HGFKCPDNNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5758600", Offset = "0x5757600", VA = "0x185758600", Slot = "33")]
	public void ADLAMFEDDPP(Vector3 HFEPHLDDIBH, Vector3 PFMLKPNBNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x575A6D0", Offset = "0x57596D0", VA = "0x18575A6D0", Slot = "32")]
	public void KHDCIDOGGHM(Vector3 LHJMJCLHHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x575B700", Offset = "0x575A700", VA = "0x18575B700", Slot = "22")]
	public void NMIDMGEDAJO(DPIEBFJEGAP GBLKMOHBIIA, Vector3 FJDPGKKBPBE, float CLIOGCOFNBL, float KAMLIANHMOM = 8f, float MCEOKHIBPEH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x57586A0", Offset = "0x57576A0", VA = "0x1857586A0", Slot = "21")]
	public void APICAINOGOA(MGLJIFAIKHI IODJFNIOCBH, Vector3 FDGCBNNCCHO, float CLOFJPCBILA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x575B3E0", Offset = "0x575A3E0", VA = "0x18575B3E0", Slot = "23")]
	[Obsolete]
	public void NHIKFAIIBFN(MGLJIFAIKHI IODJFNIOCBH, Vector3 DEANJFCCEBG, float GGAABPHIDIK = 7f, float GIFLLGIECLE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x575A430", Offset = "0x5759430", VA = "0x18575A430", Slot = "30")]
	public Vector3 KENOPHFFKMB(Vector3 CBPBBILDPPH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x575AA20", Offset = "0x5759A20", VA = "0x18575AA20", Slot = "29")]
	public Vector3 LIBLGGNHIIC(Vector3 NJBJCPFKCBL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5759D20", Offset = "0x5758D20", VA = "0x185759D20", Slot = "26")]
	public void JCNGJHGPHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5759B50", Offset = "0x5758B50", VA = "0x185759B50")]
	private void IOEAJNBGOAE(float CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5759780", Offset = "0x5758780", VA = "0x185759780")]
	private void FGEBPECINON(Vector3 FDGCBNNCCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x575BE50", Offset = "0x575AE50", VA = "0x18575BE50")]
	private Vector3 PPFDOKCLBHJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x575AF80", Offset = "0x5759F80", VA = "0x18575AF80")]
	private void NGKEPMLDOBD(Vector3 PECLNPLFMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x57594D0", Offset = "0x57584D0", VA = "0x1857594D0")]
	private Vector3 EMJIOMJCDMD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x5759FE0", Offset = "0x5758FE0", VA = "0x185759FE0")]
	private void KEEABBBDKCH(Vector3 CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x5759F80", Offset = "0x5758F80", VA = "0x185759F80")]
	private void KCMLELDKCEO(Vector3 CBPBBILDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x57591E0", Offset = "0x57581E0", VA = "0x1857591E0")]
	private void CNFMBFIAELA(Vector3 NJBJCPFKCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5758950", Offset = "0x5757950", VA = "0x185758950")]
	private void BJCKMPJGJKM(string GFCOOODCAAI, Vector3 CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5758F60", Offset = "0x5757F60", VA = "0x185758F60")]
	private void BNMAJHGICDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class ILEOFMFPLGB : GBIHHFPOGOE, KNLDOFJBJFF
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public float LEJJNDENKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x5751E60", Offset = "0x5750E60", VA = "0x185751E60", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x57520F0", Offset = "0x57510F0", VA = "0x1857520F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public float DBJKOMDHGOF
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x5751D90", Offset = "0x5750D90", VA = "0x185751D90", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5751BC0", Offset = "0x5750BC0", VA = "0x185751BC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x5734D80", Offset = "0x5733D80", VA = "0x185734D80")]
	public ILEOFMFPLGB(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x5751F30", Offset = "0x5750F30", VA = "0x185751F30", Slot = "8")]
	public void KADDKNGPFNM(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x57522C0", Offset = "0x57512C0", VA = "0x1857522C0", Slot = "9")]
	public void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[UnityEngine.Scripting.Preserve]
public sealed class COAMANIDOCP : PGOKKAHHEHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly COAMANIDOCP PCFKPPACGDB;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public Rigidbody JAMLFHMHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyEx PJOBMDAKLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public GameObject MECJAJFFGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public Transform NLACIKINHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x91FD50", Offset = "0x91ED50", VA = "0x18091FD50", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public IEnumerable<object> PFFMLFEPJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public PGOKKAHHEHO PFNKNMFEFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x944E10", Offset = "0x943E10", VA = "0x180944E10", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x960880", Offset = "0x95F880", VA = "0x180960880", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IReadOnlyList<PGOKKAHHEHO> EHLHGICFHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x944E20", Offset = "0x943E20", VA = "0x180944E20", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public PGOKKAHHEHO EDABIFLHHKC
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x94B760", Offset = "0x94A760", VA = "0x18094B760", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool MMMBPNNCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xB9A5E0", Offset = "0xB995E0", VA = "0x180B9A5E0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool NCEMACJLKCK
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xB9A570", Offset = "0xB99570", VA = "0x180B9A570", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool KPLBGMFCADF
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xB9A5D0", Offset = "0xB995D0", VA = "0x180B9A5D0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public INMIHNLNEJO DEEIHGOOGBG
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x92FA50", Offset = "0x92EA50", VA = "0x18092FA50", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x92FC50", Offset = "0x92EC50", VA = "0x18092FC50", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public GGOGJGFNOFN GHAKLGHCKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x962CB0", Offset = "0x961CB0", VA = "0x180962CB0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x9629F0", Offset = "0x9619F0", VA = "0x1809629F0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public float AKIPAEFKPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xDE7B50", Offset = "0xDE6B50", VA = "0x180DE7B50", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xDE6E30", Offset = "0xDE5E30", VA = "0x180DE6E30", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Vector3 KEIHGAEJKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2905640", Offset = "0x2904640", VA = "0x182905640", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2905DA0", Offset = "0x2904DA0", VA = "0x182905DA0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Vector3 OHCDEIMNFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x17CEAC0", Offset = "0x17CDAC0", VA = "0x1817CEAC0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x17CCBB0", Offset = "0x17CBBB0", VA = "0x1817CCBB0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Vector3 KMIFICDBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x17CEAE0", Offset = "0x17CDAE0", VA = "0x1817CEAE0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x17CAB10", Offset = "0x17C9B10", VA = "0x1817CAB10", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 JDGPGHDFHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xDF92A0", Offset = "0xDF82A0", VA = "0x180DF92A0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool EICCNFFNODM
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xACD330", Offset = "0xACC330", VA = "0x180ACD330", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public bool BBPJKLAMKPO
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xE75070", Offset = "0xE74070", VA = "0x180E75070", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool NKKJGCMCCIB
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x1D220A0", Offset = "0x1D210A0", VA = "0x181D220A0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool IBJABDCLBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x1D220D0", Offset = "0x1D210D0", VA = "0x181D220D0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Vector3 PDKKMCNOPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xEFC360", Offset = "0xEFB360", VA = "0x180EFC360", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Vector3 BOPECJAMOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x1BB2540", Offset = "0x1BB1540", VA = "0x181BB2540", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 FANAKJBNAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xDF92A0", Offset = "0xDF82A0", VA = "0x180DF92A0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 HICENODMKJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x148C3F0", Offset = "0x148B3F0", VA = "0x18148C3F0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public float KDIHEJKAJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1B8E290", Offset = "0x1B8D290", VA = "0x181B8E290", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public float FAJFPKHICDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xC23890", Offset = "0xC22890", VA = "0x180C23890", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Vector3 JOMNABGJAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xDF92A0", Offset = "0xDF82A0", VA = "0x180DF92A0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public Quaternion KLJPCCCHPHG
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x1393870", Offset = "0x1392870", VA = "0x181393870", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public float LEJJNDENKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xC23890", Offset = "0xC22890", VA = "0x180C23890", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public float DBJKOMDHGOF
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xC23890", Offset = "0xC22890", VA = "0x180C23890", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool KDNLHMAOJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool JHMBLKKAMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public OOPINJNCOHE CCODFDCKKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "51")]
		get
		{
			return default(OOPINJNCOHE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool CKANPFJAFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x240FC60", Offset = "0x240EC60", VA = "0x18240FC60", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public Transform KMNEBMCNEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xE8C420", Offset = "0xE8B420", VA = "0x180E8C420", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Transform NCPLCNGEEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x9950C0", Offset = "0x9940C0", VA = "0x1809950C0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 AONAJNGLCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xDF92A0", Offset = "0xDF82A0", VA = "0x180DF92A0", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public float LKJEGOPOJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xC23890", Offset = "0xC22890", VA = "0x180C23890", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public float KJPOFMHJMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xC23890", Offset = "0xC22890", VA = "0x180C23890", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public Quaternion GIJEMHCFPBG
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xBAE340", Offset = "0xBAD340", VA = "0x180BAE340", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 FOEBOOGHHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xDF92A0", Offset = "0xDF82A0", VA = "0x180DF92A0", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Quaternion IMGIAOBGANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xBAE340", Offset = "0xBAD340", VA = "0x180BAE340", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public RigidbodyConstraints CGILPJHJLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x84F960", Offset = "0x84E960", VA = "0x18084F960", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool LAHGANIGJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public CollisionDetectionMode OFODBABDMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x84F960", Offset = "0x84E960", VA = "0x18084F960", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool OJPJLJHGGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xAE97B0", Offset = "0xAE87B0", VA = "0x180AE97B0", Slot = "74")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool LFPNLEAKJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "132")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event NAEAPBAINIJ OPNOJLLMOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event NAEAPBAINIJ PMBDNOEKOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event OOOCOIFCPAN HKAKBOHPJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event NAEAPBAINIJ JHKGPLGOHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "86")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "87")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event NAEAPBAINIJ NAOMFIIDBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "106")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "107")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event NAEAPBAINIJ GHLEIGCIOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<BHPPPFLNDLP, BHPPPFLNDLP> PDDABMIIDFO
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "115")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "116")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event NAEAPBAINIJ ENNFPKIDCJI
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event NAEAPBAINIJ KPLEICBNMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "123")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "124")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "44")]
	public void PNFOHBMEGIE((Quaternion rot, Vector3 moments) DJHFDNAEBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "75")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "76")]
	public void LFLKHHIPBKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "77")]
	public void FCHBKGHJNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "78")]
	public void EJHKPCBFHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "140")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "85")]
	public void LMENPCDIGEL(PGOKKAHHEHO CKMKMNKGMMC, bool BHOCINAFNLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "88")]
	public void DFGPMLEBMJJ(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "89")]
	public void CJCDHBCKLGP(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0xDF92A0", Offset = "0xDF82A0", VA = "0x180DF92A0", Slot = "90")]
	public Vector3 ONJAKBBCCOC(Vector3 CLHHPAFJIIP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0xDF92A0", Offset = "0xDF82A0", VA = "0x180DF92A0", Slot = "91")]
	public Vector3 CIKMBONDBGE(Vector3 PECLNPLFMIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "92")]
	public void BCJLHNGAJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "93")]
	public void PPDOFFGMEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "94")]
	public void AOCAHOFFDPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "95")]
	public void MKIIGHBCAHE(Vector3 KBONMJFJLJN, Vector3 HGFKCPDNNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "96")]
	public void ADLAMFEDDPP(Vector3 HFEPHLDDIBH, Vector3 PFMLKPNBNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "97")]
	public void KHDCIDOGGHM(Vector3 LHJMJCLHHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "98")]
	public void NMIDMGEDAJO(DPIEBFJEGAP GBLKMOHBIIA, Vector3 FJDPGKKBPBE, float CLIOGCOFNBL, float KAMLIANHMOM = 8f, float MCEOKHIBPEH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "99")]
	public void APICAINOGOA(MGLJIFAIKHI IODJFNIOCBH, Vector3 FDGCBNNCCHO, float CLOFJPCBILA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "100")]
	public void NHIKFAIIBFN(MGLJIFAIKHI IODJFNIOCBH, Vector3 DEANJFCCEBG, float GGAABPHIDIK = 7f, float GIFLLGIECLE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0xDF92A0", Offset = "0xDF82A0", VA = "0x180DF92A0", Slot = "101")]
	public Vector3 KENOPHFFKMB(Vector3 CKMKMNKGMMC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0xDF92A0", Offset = "0xDF82A0", VA = "0x180DF92A0", Slot = "102")]
	public Vector3 LIBLGGNHIIC(Vector3 CKMKMNKGMMC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "103")]
	public void JCNGJHGPHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "104")]
	public void NIHKPNJMEPO(PGOKKAHHEHO JBMPHMAENDC, object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "105")]
	public void PFMJNOHCDPN(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "108")]
	public void BKDFAKEJMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "109")]
	public void HMNJMGPIBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "110")]
	public void FIKLNLECMNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "113")]
	public bool IEGPOINMBNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "114")]
	public void JLGCCFNGGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x84F960", Offset = "0x84E960", VA = "0x18084F960", Slot = "119")]
	public IDisposable PFBIGGEBPLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "120")]
	public void AJCGMBJNPHE(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "121")]
	public void PMHMAKBGFHM(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "122")]
	public void HLAJEEHODPC(object DMHDKAFNNAC, bool CLCDDMLICOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "125")]
	public void KBDEKKAEHBE(Vector3 ECLJOKGPADO, Quaternion ODAOAJLFHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "126")]
	public void EOFKEOHKDCO(Vector3 JOIOANBLCDC, Quaternion IKEPFBIAAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "127")]
	public bool HCEGGNLAINK(float BMIGADDGEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "128")]
	public void LAODGHJPBMD(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "129")]
	public void AGKEMDFOHFA(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "130")]
	public void KHFFFCKDFKC(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "131")]
	public void LEPHDJGCOHN(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "133")]
	public void CFFCBFDJPAE(Vector3 CAMEGMHBOIN, ForceMode CNNCDLOEBGE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "134")]
	public void JCKNNNFADKD(Vector3 CAMEGMHBOIN, Vector3 EDEGPGKBEGA, ForceMode CNNCDLOEBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "135")]
	public void HOJGAPDCCAI(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "136")]
	public void IPEBCCKLCEG(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x57431D0", Offset = "0x57421D0", VA = "0x1857431D0", Slot = "137")]
	public bool NPINOOHNIBD(Vector3 HAMNFFBEFHD, out RaycastHit GOKLGMJIOLJ, float OLGGKIEPHEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "138")]
	public void IDGGELLJBNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public COAMANIDOCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class AEECCCGOPHJ : GBIHHFPOGOE, DHALLCIHMFI
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 PDKKMCNOPML
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x57346E0", Offset = "0x57336E0", VA = "0x1857346E0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 BOPECJAMOPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x5734A90", Offset = "0x5733A90", VA = "0x185734A90", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private Vector3 KMIFICDBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x5734710", Offset = "0x5733710", VA = "0x185734710")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private PGOKKAHHEHO DCJKADKGIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x5734580", Offset = "0x5733580", VA = "0x185734580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5734D80", Offset = "0x5733D80", VA = "0x185734D80")]
	public AEECCCGOPHJ(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x57347F0", Offset = "0x57337F0", VA = "0x1857347F0", Slot = "6")]
	public void LAMLJEBPIKJ(PGOKKAHHEHO AGFCJPGACCB, object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5734970", Offset = "0x5733970", VA = "0x185734970")]
	private void LAMLJEBPIKJ(JHFFHCFJIAF AGFCJPGACCB, object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5734C90", Offset = "0x5733C90", VA = "0x185734C90", Slot = "7")]
	public void NPNLGGMOAPA(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x57341D0", Offset = "0x57331D0", VA = "0x1857341D0")]
	private Vector3 DKHFIBONEGM()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class HIFEMDOMOCN
{
	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5750F20", Offset = "0x574FF20", VA = "0x185750F20")]
	public static AEECCCGOPHJ GDJAJDNENHO(this PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class ANPGKCDFAHH : GBIHHFPOGOE, DIGKBAFHJGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly FACALIAHOGE LPEJGAIMDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly HFFLECNKOAM IPPGJHJBMIP;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private Transform NLACIKINHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5737B20", Offset = "0x5736B20", VA = "0x185737B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public KBHBMCLJPDE IDBAAPPOINP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x5737A20", Offset = "0x5736A20", VA = "0x185737A20")]
		get
		{
			return default(KBHBMCLJPDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x57385D0", Offset = "0x57375D0", VA = "0x1857385D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public PGOKKAHHEHO PFNKNMFEFND
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5738200", Offset = "0x5737200", VA = "0x185738200", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x57386D0", Offset = "0x57376D0", VA = "0x1857386D0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public KBHBMCLJPDE OEBEDODIGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5737C90", Offset = "0x5736C90", VA = "0x185737C90")]
		get
		{
			return default(KBHBMCLJPDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x57377D0", Offset = "0x57367D0", VA = "0x1857377D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public PGOKKAHHEHO EDABIFLHHKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5738590", Offset = "0x5737590", VA = "0x185738590", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public IReadOnlyList<PGOKKAHHEHO> EHLHGICFHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x962CB0", Offset = "0x961CB0", VA = "0x180962CB0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event NAEAPBAINIJ OPNOJLLMOJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x57389B0", Offset = "0x57379B0", VA = "0x1857389B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x5737B50", Offset = "0x5736B50", VA = "0x185737B50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event NAEAPBAINIJ PMBDNOEKOAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5737140", Offset = "0x5736140", VA = "0x185737140", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x57370A0", Offset = "0x57360A0", VA = "0x1857370A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event OOOCOIFCPAN HKAKBOHPJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x5738380", Offset = "0x5737380", VA = "0x185738380", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5736810", Offset = "0x5735810", VA = "0x185736810", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event Action CNMNJJFJOFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5737280", Offset = "0x5736280", VA = "0x185737280", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5737D90", Offset = "0x5736D90", VA = "0x185737D90", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event Action CNPNDJMFLPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x5737BF0", Offset = "0x5736BF0", VA = "0x185737BF0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5738740", Offset = "0x5737740", VA = "0x185738740", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event Action<PGOKKAHHEHO> HKHCEAKLADN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x5738420", Offset = "0x5737420", VA = "0x185738420", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5737E30", Offset = "0x5736E30", VA = "0x185737E30", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event Action<PGOKKAHHEHO> KLPLJJFKLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x57371E0", Offset = "0x57361E0", VA = "0x1857371E0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x57382E0", Offset = "0x57372E0", VA = "0x1857382E0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event Action EPGJDKNBLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5738240", Offset = "0x5737240", VA = "0x185738240", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x5738160", Offset = "0x5737160", VA = "0x185738160", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event Action<PGOKKAHHEHO> DLEGFCOPGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x57387E0", Offset = "0x57377E0", VA = "0x1857387E0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x5737980", Offset = "0x5736980", VA = "0x185737980", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5738AE0", Offset = "0x5737AE0", VA = "0x185738AE0")]
	public ANPGKCDFAHH(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x57375F0", Offset = "0x57365F0", VA = "0x1857375F0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5737ED0", Offset = "0x5736ED0", VA = "0x185737ED0", Slot = "26")]
	public void LMENPCDIGEL(PGOKKAHHEHO COLDPDBGEPD, bool BHOCINAFNLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5737F50", Offset = "0x5736F50", VA = "0x185737F50")]
	private void LMENPCDIGEL(JHFFHCFJIAF COLDPDBGEPD, bool BHOCINAFNLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x57368B0", Offset = "0x57358B0", VA = "0x1857368B0")]
	private void ACBHIFFNJAK(JHFFHCFJIAF COLDPDBGEPD, bool BHOCINAFNLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5737FC0", Offset = "0x5736FC0", VA = "0x185737FC0")]
	private void LMHBCFMLBFD(JHFFHCFJIAF GAOHEHNIPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5737450", Offset = "0x5736450", VA = "0x185737450")]
	private void DKCOKEJBIPP(JHFFHCFJIAF GAOHEHNIPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5736EE0", Offset = "0x5735EE0", VA = "0x185736EE0")]
	private void ANACLDHAPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x57384C0", Offset = "0x57374C0", VA = "0x1857384C0")]
	private void NGDNACJDLLN(JHFFHCFJIAF GAOHEHNIPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x57378D0", Offset = "0x57368D0", VA = "0x1857378D0")]
	private void HPHIKKOKLLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5737320", Offset = "0x5736320", VA = "0x185737320")]
	private void DCILHALKLLL(JHFFHCFJIAF LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5738880", Offset = "0x5737880", VA = "0x185738880")]
	private void PHHBPNCHAMJ(JHFFHCFJIAF LKIOOPNDJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class EAJIPBMHHHM
{
	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5744F90", Offset = "0x5743F90", VA = "0x185744F90")]
	public static ANPGKCDFAHH AOPFCIHOLLN(this PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class JHFFHCFJIAF : HFMANEIGDON, PIJECNBFEGJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal GJAFPLOBCJA PIAKOHEJIGE;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5754E70", Offset = "0x5753E70", VA = "0x185754E70")]
	public JHFFHCFJIAF(GameObject IHNGPGNCBCG, RigidbodyEx JIGNMEKGFID, FELONCPAKLL NKHIMAEJAFL, in AJHPHPODBKK HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5754840", Offset = "0x5753840", VA = "0x185754840", Slot = "142")]
	protected override void LOJJMKNMIBI(FELONCPAKLL NKHIMAEJAFL, AJHPHPODBKK HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x84F100", Offset = "0x84E100", VA = "0x18084F100", Slot = "145")]
	protected override IDisposable LCADNKNIGFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5754350", Offset = "0x5753350", VA = "0x185754350", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5754DB0", Offset = "0x5753DB0", VA = "0x185754DB0", Slot = "146")]
	public void PAOFEMLCLGH(DKOCFDNDBNP LPGJFKDBDFN, DKOCFDNDBNP AHNDJFCGOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5754CF0", Offset = "0x5753CF0", VA = "0x185754CF0", Slot = "147")]
	public void OIMGPKIDKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5754540", Offset = "0x5753540", VA = "0x185754540", Slot = "148")]
	public void HHFEGPKFEOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5754C90", Offset = "0x5753C90", VA = "0x185754C90", Slot = "149")]
	public void OCLBMPFKCPH(bool FNJGCLCOPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5754B20", Offset = "0x5753B20", VA = "0x185754B20", Slot = "150")]
	public bool MEPMOOFMMLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x57544E0", Offset = "0x57534E0", VA = "0x1857544E0", Slot = "151")]
	public void HACKKNNBCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "144")]
	protected override void FPHHHBILNKM(RigidbodyEx OHNCPAPBFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5754600", Offset = "0x5753600", VA = "0x185754600")]
	private void HPAMBNGEILH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class MFEMFAOMFBH
{
	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x71DED50", Offset = "0x71DDD50", VA = "0x1871DED50")]
	public static HFMANEIGDON FCMCFLPIOPM(this PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class MAKPNIKKKCF : GBIHHFPOGOE, IPHGGGNEIKB
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private const string MGLMKCLPKPO = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool IENMIFAEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x71DE360", Offset = "0x71DD360", VA = "0x1871DE360", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public HLLHIAHOMMI JMCLDIIMPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x71DE640", Offset = "0x71DD640", VA = "0x1871DE640", Slot = "5")]
		get
		{
			return default(HLLHIAHOMMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private HLLHIAHOMMI KMGPOBADLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x71DEAF0", Offset = "0x71DDAF0", VA = "0x1871DEAF0")]
		get
		{
			return default(HLLHIAHOMMI);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x71DEA00", Offset = "0x71DDA00", VA = "0x1871DEA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x71DEBD0", Offset = "0x71DDBD0", VA = "0x1871DEBD0")]
	public MAKPNIKKKCF(PGOKKAHHEHO LKIOOPNDJED, in AJHPHPODBKK HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x71DE480", Offset = "0x71DD480", VA = "0x1871DE480", Slot = "6")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x71DE650", Offset = "0x71DD650", VA = "0x1871DE650")]
	private bool GPHDOGJCIJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x71DE6F0", Offset = "0x71DD6F0", VA = "0x1871DE6F0", Slot = "7")]
	public void KGFJABCJONK(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x71DE900", Offset = "0x71DD900", VA = "0x1871DE900", Slot = "8")]
	public void OACKPDFEEIO(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x71DE7F0", Offset = "0x71DD7F0", VA = "0x1871DE7F0", Slot = "11")]
	public void LLDANDPGOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x71DE230", Offset = "0x71DD230", VA = "0x1871DE230")]
	private void AKMJFKMPMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x71DE540", Offset = "0x71DD540", VA = "0x1871DE540")]
	private void GDDADMBEBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x71DE440", Offset = "0x71DD440", VA = "0x1871DE440", Slot = "10")]
	public void EGKLFNLNAFN(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x71DE320", Offset = "0x71DD320", VA = "0x1871DE320", Slot = "9")]
	public void APLNENFJNBG(PGOKKAHHEHO LKIOOPNDJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class GMBMJDCPJAJ : GBIHHFPOGOE, ANGMHCIONKP
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private Rigidbody JAMLFHMHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x5738C90", Offset = "0x5737C90", VA = "0x185738C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private bool CKANPFJAFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x57436F0", Offset = "0x57426F0", VA = "0x1857436F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private bool MMMBPNNCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5735DA0", Offset = "0x5734DA0", VA = "0x185735DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private PGOKKAHHEHO PFNKNMFEFND
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5748F30", Offset = "0x5747F30", VA = "0x185748F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x5734D80", Offset = "0x5733D80", VA = "0x185734D80")]
	public GMBMJDCPJAJ(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x57480F0", Offset = "0x57470F0", VA = "0x1857480F0", Slot = "4")]
	public void CFFCBFDJPAE(Vector3 CAMEGMHBOIN, ForceMode CNNCDLOEBGE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x5748250", Offset = "0x5747250", VA = "0x185748250")]
	private void CPBGMCLEHPK(Vector3 CAMEGMHBOIN, ForceMode CNNCDLOEBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5748A10", Offset = "0x5747A10", VA = "0x185748A10", Slot = "5")]
	public void JCKNNNFADKD(Vector3 CAMEGMHBOIN, Vector3 EDEGPGKBEGA, ForceMode CNNCDLOEBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5748630", Offset = "0x5747630", VA = "0x185748630", Slot = "6")]
	public void HOJGAPDCCAI(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5748CB0", Offset = "0x5747CB0", VA = "0x185748CB0")]
	private void KIDEFKEIKGF(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5748790", Offset = "0x5747790", VA = "0x185748790", Slot = "7")]
	public void IPEBCCKLCEG(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5748540", Offset = "0x5747540", VA = "0x185748540")]
	private void EBBBCGBJAMD(string FANKIHBOOPE, UnityEngine.Object HBLIBBFCHOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class AJMGOHLEAGB : GBIHHFPOGOE, JKMKJMODKDA
{
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private const string GDNAMAPAPJM = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Rigidbody JAMLFHMHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x5734E00", Offset = "0x5733E00", VA = "0x185734E00", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x5735090", Offset = "0x5734090", VA = "0x185735090")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private bool MMMBPNNCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5735DA0", Offset = "0x5734DA0", VA = "0x185735DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool LFPNLEAKJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5735870", Offset = "0x5734870", VA = "0x185735870", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5735E00", Offset = "0x5734E00", VA = "0x185735E00")]
	public AJMGOHLEAGB(PGOKKAHHEHO LKIOOPNDJED, in AJHPHPODBKK HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x5735180", Offset = "0x5734180", VA = "0x185735180", Slot = "5")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5735940", Offset = "0x5734940", VA = "0x185735940", Slot = "7")]
	public void KHFFFCKDFKC(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5735CA0", Offset = "0x5734CA0", VA = "0x185735CA0", Slot = "8")]
	public void LEPHDJGCOHN(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x57353F0", Offset = "0x57343F0", VA = "0x1857353F0", Slot = "9")]
	public void ICFEOPJKFOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5735A40", Offset = "0x5734A40", VA = "0x185735A40", Slot = "10")]
	public void KNNKGJDHBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x57356A0", Offset = "0x57346A0", VA = "0x1857356A0", Slot = "11")]
	public void IDEBJNDGGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "12")]
	public void MLPJEJECGHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5734ED0", Offset = "0x5733ED0", VA = "0x185734ED0")]
	private void DMGBEJAOPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5735230", Offset = "0x5734230", VA = "0x185735230")]
	private void FMOPHCPKAND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class ALJKOBDKAMF : GBIHHFPOGOE, JJAPFDMEHGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool CKANPFJAFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x5735EA0", Offset = "0x5734EA0", VA = "0x185735EA0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public IEnumerable<object> IMCBDIIHPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5735F70", Offset = "0x5734F70", VA = "0x185735F70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private bool PKJFGHNGANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5736490", Offset = "0x5735490", VA = "0x185736490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event NAEAPBAINIJ ENNFPKIDCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5736220", Offset = "0x5735220", VA = "0x185736220", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x5736080", Offset = "0x5735080", VA = "0x185736080", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x5734D80", Offset = "0x5733D80", VA = "0x185734D80")]
	public ALJKOBDKAMF(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x5736740", Offset = "0x5735740", VA = "0x185736740", Slot = "12")]
	public IDisposable PFBIGGEBPLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x5735E90", Offset = "0x5734E90", VA = "0x185735E90", Slot = "9")]
	public void AJCGMBJNPHE(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5736800", Offset = "0x5735800", VA = "0x185736800", Slot = "10")]
	public void PMHMAKBGFHM(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5736120", Offset = "0x5735120", VA = "0x185736120", Slot = "11")]
	public void HLAJEEHODPC(object DMHDKAFNNAC, bool CLCDDMLICOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x57362C0", Offset = "0x57352C0", VA = "0x1857362C0", Slot = "13")]
	public void KADDKNGPFNM(Rigidbody GMKHAHOBJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5736560", Offset = "0x5735560", VA = "0x185736560", Slot = "14")]
	public void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5736040", Offset = "0x5735040", VA = "0x185736040", Slot = "6")]
	public void EAOHNEHNLDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class AOJLJOHLGAE : GBIHHFPOGOE, EDPGOHNHHHB
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private CollisionDetectionMode PHBNGFPMDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x5738E00", Offset = "0x5737E00", VA = "0x185738E00")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x57393F0", Offset = "0x57383F0", VA = "0x1857393F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private Rigidbody JAMLFHMHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x5738C90", Offset = "0x5737C90", VA = "0x185738C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public CollisionDetectionMode OFODBABDMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x57390D0", Offset = "0x57380D0", VA = "0x1857390D0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x57394E0", Offset = "0x57384E0", VA = "0x1857394E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5734D80", Offset = "0x5733D80", VA = "0x185734D80")]
	public AOJLJOHLGAE(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5738CF0", Offset = "0x5737CF0", VA = "0x185738CF0", Slot = "6")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x57391F0", Offset = "0x57381F0", VA = "0x1857391F0", Slot = "9")]
	public void KADDKNGPFNM(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x57391E0", Offset = "0x57381E0", VA = "0x1857391E0", Slot = "7")]
	public void JLDFKKEAHIF(bool LFKOLODLPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x5738CE0", Offset = "0x5737CE0", VA = "0x185738CE0", Slot = "8")]
	public void EEKLGJDOJHC(bool LFKOLODLPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x5739280", Offset = "0x5738280", VA = "0x185739280", Slot = "10")]
	public bool NPINOOHNIBD(Vector3 HAMNFFBEFHD, out RaycastHit GOKLGMJIOLJ, float OLGGKIEPHEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x5738ED0", Offset = "0x5737ED0", VA = "0x185738ED0")]
	private void HMICENAOJCA(bool LFKOLODLPAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public sealed class HFFLECNKOAM : IReadOnlyList<PGOKKAHHEHO>, IEnumerable<PGOKKAHHEHO>, IEnumerable, IReadOnlyCollection<PGOKKAHHEHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly GJAFPLOBCJA LABDKOGKHJC;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x574A570", Offset = "0x5749570", VA = "0x18574A570", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public PGOKKAHHEHO IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x574A640", Offset = "0x5749640", VA = "0x18574A640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x574A520", Offset = "0x5749520", VA = "0x18574A520")]
	public HFFLECNKOAM(KBHBMCLJPDE ABAAGAOADBF, GJAFPLOBCJA LABDKOGKHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x574A380", Offset = "0x5749380", VA = "0x18574A380", Slot = "6")]
	public IEnumerator<PGOKKAHHEHO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x574A380", Offset = "0x5749380", VA = "0x18574A380", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x574A510", Offset = "0x5749510", VA = "0x18574A510")]
	[CompilerGenerated]
	private PGOKKAHHEHO KCNOFMIOIMO(int MBMAEEFDADD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class CLIBMAJKGLD : FKHLLDHDGHI
{
	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x573EA70", Offset = "0x573DA70", VA = "0x18573EA70", Slot = "4")]
	public DIGKBAFHJGN AJMFIKCABLJ(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x573F410", Offset = "0x573E410", VA = "0x18573F410", Slot = "5")]
	public INKDAFLPOEI KNJHGOEKNDM(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x573ED00", Offset = "0x573DD00", VA = "0x18573ED00", Slot = "6")]
	public DHALLCIHMFI BHINEDMILHG(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x573F200", Offset = "0x573E200", VA = "0x18573F200", Slot = "7")]
	public KNLDOFJBJFF HMBBKDFCHDC(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x573F2A0", Offset = "0x573E2A0", VA = "0x18573F2A0", Slot = "8")]
	public JEKHLEEDNNE IDJFFPLDNJC(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x573F000", Offset = "0x573E000", VA = "0x18573F000", Slot = "9")]
	public CPEOJDCENCO FGHFIKDAOEJ(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x573EE50", Offset = "0x573DE50", VA = "0x18573EE50", Slot = "10")]
	public JJAPFDMEHGJ CJNHGOAJOHH(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x573F0A0", Offset = "0x573E0A0", VA = "0x18573F0A0", Slot = "11")]
	public ANGMHCIONKP FKDCBIFNEDD(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x573F370", Offset = "0x573E370", VA = "0x18573F370", Slot = "12")]
	public EDPGOHNHHHB JDLEBPLBDCJ(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x573EEF0", Offset = "0x573DEF0", VA = "0x18573EEF0", Slot = "13")]
	public BEIFEOFFBLE DIGPIOBGMIG(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x573F140", Offset = "0x573E140", VA = "0x18573F140")]
	public JKMKJMODKDA PLEMCLILPDM(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x573EC40", Offset = "0x573DC40", VA = "0x18573EC40")]
	public DBBLNEJGBIA BCDKNDPILEF(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x573EF90", Offset = "0x573DF90", VA = "0x18573EF90")]
	public IPHGGGNEIKB IPBNIGFILLG(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x573F4B0", Offset = "0x573E4B0", VA = "0x18573F4B0")]
	public CFOJAFEIKGD LHAKMEPKBKI(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x573F300", Offset = "0x573E300", VA = "0x18573F300")]
	public AJAIBHCMOBA MOIMPCLBEPM(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x573EDA0", Offset = "0x573DDA0", VA = "0x18573EDA0", Slot = "19")]
	public PGOKKAHHEHO BLGFCJFNMEF(RigidbodyEx LKIOOPNDJED, AJHPHPODBKK HCKNMLENIIG, FELONCPAKLL NKHIMAEJAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public CLIBMAJKGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x573F140", Offset = "0x573E140", VA = "0x18573F140", Slot = "14")]
	private JKMKJMODKDA GNHKHLKBKHI(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x573EC40", Offset = "0x573DC40", VA = "0x18573EC40", Slot = "15")]
	private DBBLNEJGBIA DOGKLEMILAK(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x573EF90", Offset = "0x573DF90", VA = "0x18573EF90", Slot = "16")]
	private IPHGGGNEIKB FFPFMHAODHJ(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x573F4B0", Offset = "0x573E4B0", VA = "0x18573F4B0", Slot = "17")]
	private CFOJAFEIKGD MCLEPCMNHHK(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x573F300", Offset = "0x573E300", VA = "0x18573F300", Slot = "18")]
	private AJAIBHCMOBA IPPALBCIDOE(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class JHEBMMEJDIE : GBIHHFPOGOE, JEKHLEEDNNE
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public const int OBGBPGBBNED = 10;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public const float FEKIADNJNOK = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public const float KMAKOIPCDKJ = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public const float MDCEKPPBCJF = 5f;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody JAMLFHMHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x5738C90", Offset = "0x5737C90", VA = "0x185738C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private bool GOCBCBOEBCD
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x57532C0", Offset = "0x57522C0", VA = "0x1857532C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private bool LLEPCFMHOAO
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x573D390", Offset = "0x573C390", VA = "0x18573D390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private PGOKKAHHEHO PFNKNMFEFND
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x5753EB0", Offset = "0x5752EB0", VA = "0x185753EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool MMMBPNNCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x5753E50", Offset = "0x5752E50", VA = "0x185753E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool KBKMPNOHPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x5753BF0", Offset = "0x5752BF0", VA = "0x185753BF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x5753F10", Offset = "0x5752F10", VA = "0x185753F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool POBJCIOANJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x5753D80", Offset = "0x5752D80", VA = "0x185753D80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x5753810", Offset = "0x5752810", VA = "0x185753810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private int PBJONGMDHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x5753900", Offset = "0x5752900", VA = "0x185753900")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x5753670", Offset = "0x5752670", VA = "0x185753670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event NAEAPBAINIJ GHLEIGCIOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x5753360", Offset = "0x5752360", VA = "0x185753360", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x5753220", Offset = "0x5752220", VA = "0x185753220", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x5754160", Offset = "0x5753160", VA = "0x185754160")]
	public JHEBMMEJDIE(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x5753760", Offset = "0x5752760", VA = "0x185753760", Slot = "6")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5753D70", Offset = "0x5752D70", VA = "0x185753D70", Slot = "8")]
	public void KKEIJCIPBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x57539D0", Offset = "0x57529D0", VA = "0x1857539D0", Slot = "7")]
	public bool IEGPOINMBNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x57535C0", Offset = "0x57525C0", VA = "0x1857535C0", Slot = "9")]
	public void EJHKPCBFHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5736040", Offset = "0x5735040", VA = "0x185736040", Slot = "12")]
	public void OCLBMPFKCPH(bool FNJGCLCOPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5753CC0", Offset = "0x5752CC0", VA = "0x185753CC0", Slot = "11")]
	public void JLGCCFNGGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "10")]
	public void KBPBCMDNJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5753400", Offset = "0x5752400", VA = "0x185753400")]
	private bool EEFELNCFMMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5754000", Offset = "0x5753000", VA = "0x185754000")]
	private void OJGGMEMCJCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[JMPMNEIJKCM(typeof(FKHLLDHDGHI), new string[] { })]
public class FGKIEAPOKAI : FKHLLDHDGHI, DOIBDCNJEIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly FKHLLDHDGHI OCJGJMADPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly FKHLLDHDGHI DKKCDCHOOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private IBIIHCPLHGH KEIKJGHJHLM;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private FKHLLDHDGHI FIMHDINELGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x5745FF0", Offset = "0x5744FF0", VA = "0x185745FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5746240", Offset = "0x5745240", VA = "0x185746240", Slot = "20")]
	public void InitReferences(MPJBMBNDNGN JHDIKLLGIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5745930", Offset = "0x5744930", VA = "0x185745930", Slot = "4")]
	public DIGKBAFHJGN AJMFIKCABLJ(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5746330", Offset = "0x5745330", VA = "0x185746330", Slot = "5")]
	public INKDAFLPOEI KNJHGOEKNDM(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x5745A80", Offset = "0x5744A80", VA = "0x185745A80", Slot = "6")]
	public DHALLCIHMFI BHINEDMILHG(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x5746050", Offset = "0x5745050", VA = "0x185746050", Slot = "7")]
	public KNLDOFJBJFF HMBBKDFCHDC(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x57460F0", Offset = "0x57450F0", VA = "0x1857460F0", Slot = "8")]
	public JEKHLEEDNNE IDJFFPLDNJC(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x5745E00", Offset = "0x5744E00", VA = "0x185745E00", Slot = "9")]
	public CPEOJDCENCO FGHFIKDAOEJ(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x5745C10", Offset = "0x5744C10", VA = "0x185745C10", Slot = "10")]
	public JJAPFDMEHGJ CJNHGOAJOHH(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x5745EA0", Offset = "0x5744EA0", VA = "0x185745EA0", Slot = "11")]
	public ANGMHCIONKP FKDCBIFNEDD(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x5746290", Offset = "0x5745290", VA = "0x185746290", Slot = "12")]
	public EDPGOHNHHHB JDLEBPLBDCJ(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x5745CB0", Offset = "0x5744CB0", VA = "0x185745CB0", Slot = "13")]
	public BEIFEOFFBLE DIGPIOBGMIG(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x5745F40", Offset = "0x5744F40", VA = "0x185745F40")]
	public JKMKJMODKDA PLEMCLILPDM(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x57459D0", Offset = "0x57449D0", VA = "0x1857459D0")]
	public DBBLNEJGBIA BCDKNDPILEF(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x5745D50", Offset = "0x5744D50", VA = "0x185745D50")]
	public IPHGGGNEIKB IPBNIGFILLG(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x57463D0", Offset = "0x57453D0", VA = "0x1857463D0")]
	public CFOJAFEIKGD LHAKMEPKBKI(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x5746190", Offset = "0x5745190", VA = "0x185746190")]
	public AJAIBHCMOBA MOIMPCLBEPM(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5745B20", Offset = "0x5744B20", VA = "0x185745B20", Slot = "19")]
	public PGOKKAHHEHO BLGFCJFNMEF(RigidbodyEx LKIOOPNDJED, AJHPHPODBKK HCKNMLENIIG, FELONCPAKLL NKHIMAEJAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x5746480", Offset = "0x5745480", VA = "0x185746480")]
	public FGKIEAPOKAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x5745F40", Offset = "0x5744F40", VA = "0x185745F40", Slot = "14")]
	private JKMKJMODKDA GNHKHLKBKHI(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x57459D0", Offset = "0x57449D0", VA = "0x1857459D0", Slot = "15")]
	private DBBLNEJGBIA DOGKLEMILAK(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x5745D50", Offset = "0x5744D50", VA = "0x185745D50", Slot = "16")]
	private IPHGGGNEIKB FFPFMHAODHJ(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x57463D0", Offset = "0x57453D0", VA = "0x1857463D0", Slot = "17")]
	private CFOJAFEIKGD MCLEPCMNHHK(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x5746190", Offset = "0x5745190", VA = "0x185746190", Slot = "18")]
	private AJAIBHCMOBA IPPALBCIDOE(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class FIGGOILAKHA : GBIHHFPOGOE, BEIFEOFFBLE
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool KDNLHMAOJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x5746520", Offset = "0x5745520", VA = "0x185746520", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x57465F0", Offset = "0x57455F0", VA = "0x1857465F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x5734D80", Offset = "0x5733D80", VA = "0x185734D80")]
	public FIGGOILAKHA(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x57467C0", Offset = "0x57457C0", VA = "0x1857467C0", Slot = "6")]
	public void KADDKNGPFNM(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x57468C0", Offset = "0x57458C0", VA = "0x1857468C0", Slot = "7")]
	public void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class GBIHHFPOGOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	protected readonly JHFFHCFJIAF LKIOOPNDJED;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	protected GJAFPLOBCJA PIJECIDDGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x5747B60", Offset = "0x5746B60", VA = "0x185747B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	protected KBHBMCLJPDE GBHCEBOJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x5747A10", Offset = "0x5746A10", VA = "0x185747A10")]
		get
		{
			return default(KBHBMCLJPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5734D80", Offset = "0x5733D80", VA = "0x185734D80")]
	public GBIHHFPOGOE(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5747A40", Offset = "0x5746A40", VA = "0x185747A40")]
	protected PGOKKAHHEHO MHBAJHPEPPP(KBHBMCLJPDE ABAAGAOADBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class GOBPNHEFLNL : GBIHHFPOGOE, DBBLNEJGBIA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private PhotonView GOOLNMHKODD;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool NCEMACJLKCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x57443C0", Offset = "0x57433C0", VA = "0x1857443C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool KPLBGMFCADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x5748F90", Offset = "0x5747F90", VA = "0x185748F90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event NAEAPBAINIJ JHKGPLGOHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x5749B70", Offset = "0x5748B70", VA = "0x185749B70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x5749AD0", Offset = "0x5748AD0", VA = "0x185749AD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x5749DC0", Offset = "0x5748DC0", VA = "0x185749DC0")]
	public GOBPNHEFLNL(PGOKKAHHEHO LKIOOPNDJED, in AJHPHPODBKK HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5749420", Offset = "0x5748420", VA = "0x185749420", Slot = "8")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5749230", Offset = "0x5748230", VA = "0x185749230", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5749750", Offset = "0x5748750", VA = "0x185749750", Slot = "9")]
	public void IIBDJHFLHGI(PGOKKAHHEHO AGFCJPGACCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5749910", Offset = "0x5748910", VA = "0x185749910", Slot = "10")]
	public void LOMFHIBHGKD(PGOKKAHHEHO AGFCJPGACCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5749570", Offset = "0x5748570", VA = "0x185749570")]
	private void FLBNNFINECH(PhotonView CPDEKEKMJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x5749C10", Offset = "0x5748C10", VA = "0x185749C10")]
	private void PDHAMHJLPJB(RigidbodyEx OJAKFJLECKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x57490B0", Offset = "0x57480B0", VA = "0x1857490B0")]
	private void CJAANFBEELE(PhotonView BDLBNJJDFFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class PANGINFKNLD
{
	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x71E1630", Offset = "0x71E0630", VA = "0x1871E1630")]
	public static GOBPNHEFLNL KDIHCLAHPAK(this HFMANEIGDON DAHEHNAMFLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class NJJEHIBMABJ : GBIHHFPOGOE, AJAIBHCMOBA
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool LAHGANIGJCO
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x71E0ED0", Offset = "0x71DFED0", VA = "0x1871E0ED0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x71E0AD0", Offset = "0x71DFAD0", VA = "0x1871E0AD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool FHIMOODIBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x71E0750", Offset = "0x71DF750", VA = "0x1871E0750", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x71E09D0", Offset = "0x71DF9D0", VA = "0x1871E09D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public RigidbodyConstraints CGILPJHJLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x71E0BD0", Offset = "0x71DFBD0", VA = "0x1871E0BD0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x71E0830", Offset = "0x71DF830", VA = "0x1871E0830", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x71E0FB0", Offset = "0x71DFFB0", VA = "0x1871E0FB0")]
	public NJJEHIBMABJ(PGOKKAHHEHO LKIOOPNDJED, in AJHPHPODBKK HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x71E0CB0", Offset = "0x71DFCB0", VA = "0x1871E0CB0", Slot = "9")]
	public void KADDKNGPFNM(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x71E0DC0", Offset = "0x71DFDC0", VA = "0x1871E0DC0", Slot = "10")]
	public void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class GICCCLNLKPH : GBIHHFPOGOE, CPEOJDCENCO, IDisposable, NJOPGCEFCAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public OOPINJNCOHE LLJGAMNIGGB
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5747E30", Offset = "0x5746E30", VA = "0x185747E30")]
		get
		{
			return default(OOPINJNCOHE);
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x5747F00", Offset = "0x5746F00", VA = "0x185747F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public OOPINJNCOHE CCODFDCKKMO
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x5747B80", Offset = "0x5746B80", VA = "0x185747B80", Slot = "6")]
		get
		{
			return default(OOPINJNCOHE);
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5747F00", Offset = "0x5746F00", VA = "0x185747F00", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private Transform EFCDIBHFMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x84F960", Offset = "0x84E960", VA = "0x18084F960", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event Action<BHPPPFLNDLP, BHPPPFLNDLP> PDDABMIIDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x5748050", Offset = "0x5747050", VA = "0x185748050", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x5747D90", Offset = "0x5746D90", VA = "0x185747D90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x5734D80", Offset = "0x5733D80", VA = "0x185734D80")]
	public GICCCLNLKPH(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x5747FF0", Offset = "0x5746FF0", VA = "0x185747FF0", Slot = "11")]
	public void OnChangedDistanceBand(BHPPPFLNDLP LPGJFKDBDFN, BHPPPFLNDLP AHNDJFCGOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "12")]
	public void OnChangedVisibility(bool JDNEHCPJFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "8")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class CFOBLFHHAJA : CPEOJDCENCO, IDisposable, NJOPGCEFCAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public const int BJCHGCGLENB = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly HFMANEIGDON LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private OOPINJNCOHE FJLHALGKCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private PICBEADEGJE MGMAOIJGFPF;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public OOPINJNCOHE CCODFDCKKMO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x573E2E0", Offset = "0x573D2E0", VA = "0x18573E2E0", Slot = "6")]
		get
		{
			return default(OOPINJNCOHE);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x573E870", Offset = "0x573D870", VA = "0x18573E870", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private Transform EFCDIBHFMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x573E4C0", Offset = "0x573D4C0", VA = "0x18573E4C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<BHPPPFLNDLP, BHPPPFLNDLP> PDDABMIIDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x573E940", Offset = "0x573D940", VA = "0x18573E940", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x573E420", Offset = "0x573D420", VA = "0x18573E420", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x573E9E0", Offset = "0x573D9E0", VA = "0x18573E9E0")]
	public CFOBLFHHAJA(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x573E590", Offset = "0x573D590", VA = "0x18573E590", Slot = "8")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x573E4E0", Offset = "0x573D4E0", VA = "0x18573E4E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x573E530", Offset = "0x573D530", VA = "0x18573E530", Slot = "11")]
	private void EMLGDMBHDOL(BHPPPFLNDLP INJACMHELLA, BHPPPFLNDLP MKKPHOFOEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "12")]
	private void GJJHGJIIPJH(bool JDNEHCPJFKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class DNLPNFPHBCM : KNGHIFLPEFH, DBBLNEJGBIA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly HFMANEIGDON LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private PhotonView GOOLNMHKODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool IKDGLEKCJIC;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public PhotonView MHGOBIKHNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool NCEMACJLKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x57443C0", Offset = "0x57433C0", VA = "0x1857443C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool KPLBGMFCADF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x944220", Offset = "0x943220", VA = "0x180944220", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event NAEAPBAINIJ JHKGPLGOHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x5744B60", Offset = "0x5743B60", VA = "0x185744B60", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x5744AC0", Offset = "0x5743AC0", VA = "0x185744AC0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x5744D80", Offset = "0x5743D80", VA = "0x185744D80")]
	public DNLPNFPHBCM(PGOKKAHHEHO LKIOOPNDJED, in AJHPHPODBKK HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x57444F0", Offset = "0x57434F0", VA = "0x1857444F0", Slot = "9")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x57443E0", Offset = "0x57433E0", VA = "0x1857443E0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x57447C0", Offset = "0x57437C0", VA = "0x1857447C0", Slot = "10")]
	public void IIBDJHFLHGI(PGOKKAHHEHO AGFCJPGACCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x5744940", Offset = "0x5743940", VA = "0x185744940", Slot = "11")]
	public void LOMFHIBHGKD(PGOKKAHHEHO AGFCJPGACCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x5744640", Offset = "0x5743640", VA = "0x185744640")]
	private void FLBNNFINECH(PhotonView CPDEKEKMJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x5744C00", Offset = "0x5743C00", VA = "0x185744C00")]
	private void PDHAMHJLPJB(RigidbodyEx OJAKFJLECKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x5744130", Offset = "0x5743130", VA = "0x185744130")]
	private void CJAANFBEELE(PhotonView BDLBNJJDFFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class EPBLGHOLNMO
{
	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5745000", Offset = "0x5744000", VA = "0x185745000")]
	public static KNGHIFLPEFH KDIHCLAHPAK(this PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class FLLIHNNMPME : JKMKJMODKDA
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const string GDNAMAPAPJM = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly HFMANEIGDON LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly OEMFJNEEEFM GOLPEIGBKLE;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Rigidbody JAMLFHMHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x93A6D0", Offset = "0x9396D0", VA = "0x18093A6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private bool MMMBPNNCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x5735DA0", Offset = "0x5734DA0", VA = "0x185735DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool LFPNLEAKJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xB37860", Offset = "0xB36860", VA = "0x180B37860", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x5747920", Offset = "0x5746920", VA = "0x185747920")]
	public FLLIHNNMPME(PGOKKAHHEHO LKIOOPNDJED, in AJHPHPODBKK HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x5746AE0", Offset = "0x5745AE0", VA = "0x185746AE0", Slot = "5")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x5747220", Offset = "0x5746220", VA = "0x185747220", Slot = "7")]
	public void KHFFFCKDFKC(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x5747450", Offset = "0x5746450", VA = "0x185747450", Slot = "8")]
	public void LEPHDJGCOHN(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x5746D40", Offset = "0x5745D40", VA = "0x185746D40", Slot = "9")]
	public void ICFEOPJKFOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x5747250", Offset = "0x5746250", VA = "0x185747250", Slot = "10")]
	public void KNNKGJDHBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x57470A0", Offset = "0x57460A0", VA = "0x1857470A0", Slot = "11")]
	public void IDEBJNDGGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x5747480", Offset = "0x5746480", VA = "0x185747480", Slot = "12")]
	public void MLPJEJECGHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x5746930", Offset = "0x5745930", VA = "0x185746930")]
	private void DMGBEJAOPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5746B90", Offset = "0x5745B90", VA = "0x185746B90")]
	private void FMOPHCPKAND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class HGLPMKNGJNH : AJAIBHCMOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly HFMANEIGDON LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private RigidbodyConstraints ANNCKJLMEDI;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool LAHGANIGJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8350", VA = "0x180AA9350", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x1F5B630", Offset = "0x1F5A630", VA = "0x181F5B630", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool FHIMOODIBAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x1F5B620", Offset = "0x1F5A620", VA = "0x181F5B620", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x1F5B610", Offset = "0x1F5A610", VA = "0x181F5B610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public RigidbodyConstraints CGILPJHJLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x999690", Offset = "0x998690", VA = "0x180999690", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x5750CE0", Offset = "0x574FCE0", VA = "0x185750CE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x5750E80", Offset = "0x574FE80", VA = "0x185750E80")]
	public HGLPMKNGJNH(PGOKKAHHEHO LKIOOPNDJED, in AJHPHPODBKK HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x5750E20", Offset = "0x574FE20", VA = "0x185750E20", Slot = "9")]
	public void KADDKNGPFNM(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x5750E50", Offset = "0x574FE50", VA = "0x185750E50", Slot = "10")]
	public void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class DMABEPLKBFP : ANGMHCIONKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly HFMANEIGDON LKIOOPNDJED;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private Rigidbody JAMLFHMHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x5738C90", Offset = "0x5737C90", VA = "0x185738C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private bool CKANPFJAFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x57436F0", Offset = "0x57426F0", VA = "0x1857436F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private bool MMMBPNNCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x5735DA0", Offset = "0x5734DA0", VA = "0x185735DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private PGOKKAHHEHO PFNKNMFEFND
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x5744040", Offset = "0x5743040", VA = "0x185744040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x57440A0", Offset = "0x57430A0", VA = "0x1857440A0")]
	public DMABEPLKBFP(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x5743310", Offset = "0x5742310", VA = "0x185743310", Slot = "4")]
	public void CFFCBFDJPAE(Vector3 CAMEGMHBOIN, ForceMode CNNCDLOEBGE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5743470", Offset = "0x5742470", VA = "0x185743470")]
	private void CPBGMCLEHPK(Vector3 CAMEGMHBOIN, ForceMode CNNCDLOEBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x5743B20", Offset = "0x5742B20", VA = "0x185743B20", Slot = "5")]
	public void JCKNNNFADKD(Vector3 CAMEGMHBOIN, Vector3 EDEGPGKBEGA, ForceMode CNNCDLOEBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x5743740", Offset = "0x5742740", VA = "0x185743740", Slot = "6")]
	public void HOJGAPDCCAI(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x5743DC0", Offset = "0x5742DC0", VA = "0x185743DC0")]
	private void KIDEFKEIKGF(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x57438A0", Offset = "0x57428A0", VA = "0x1857438A0", Slot = "7")]
	public void IPEBCCKLCEG(Vector3 DLLGKMLCKLC, ForceMode CNNCDLOEBGE = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class ICMICJPEEDC : EIIICLEDNHO, DHALLCIHMFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly HFMANEIGDON LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly LGMECHOHFEB<PGOKKAHHEHO> KAPJLHACAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool CPCNINFAOKF;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public LGMECHOHFEB<PGOKKAHHEHO> KOJCCBANOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public Vector3 PDKKMCNOPML
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x5751370", Offset = "0x5750370", VA = "0x185751370", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public Vector3 BOPECJAMOPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x57518A0", Offset = "0x57508A0", VA = "0x1857518A0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private Vector3 KMIFICDBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x57513A0", Offset = "0x57503A0", VA = "0x1857513A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public PGOKKAHHEHO DCJKADKGIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x57512C0", Offset = "0x57502C0", VA = "0x1857512C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x5751AD0", Offset = "0x5750AD0", VA = "0x185751AD0")]
	public ICMICJPEEDC(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x5751480", Offset = "0x5750480", VA = "0x185751480", Slot = "8")]
	public void LAMLJEBPIKJ(PGOKKAHHEHO AGFCJPGACCB, object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x5751A70", Offset = "0x5750A70", VA = "0x185751A70", Slot = "9")]
	public void NPNLGGMOAPA(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x5750F90", Offset = "0x574FF90", VA = "0x185750F90")]
	private Vector3 DKHFIBONEGM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x57514F0", Offset = "0x57504F0", VA = "0x1857514F0")]
	private void LDJIMGGLCDN(PGOKKAHHEHO BOGLINGGBIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class KPKFGNPGJHH
{
	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5758510", Offset = "0x5757510", VA = "0x185758510")]
	public static EIIICLEDNHO GDJAJDNENHO(this PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class KGLMKFHGBLE : FBFGNCIBFDJ, CFOJAFEIKGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly HFMANEIGDON LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly OverridableVector3 PPIHEANOMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly OverridableVector3 DHOGHOAHABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private float EFBPONPEOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private float AJCOFMJAECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Vector3 HEFJDNOKMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Vector3? IFDEEDKEFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Quaternion? EBDBPGIPHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool FDCCAMKNFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool ELLFEPCNOJG;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Vector3 FANAKJBNAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x16B6990", Offset = "0x16B5990", VA = "0x1816B6990", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x5755FB0", Offset = "0x5754FB0", VA = "0x185755FB0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public Vector3 HICENODMKJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x5757950", Offset = "0x5756950", VA = "0x185757950", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public float KDIHEJKAJGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xF9FE40", Offset = "0xF9EE40", VA = "0x180F9FE40", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x5757D50", Offset = "0x5756D50", VA = "0x185757D50")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public float FAJFPKHICDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xBA7CB0", Offset = "0xBA6CB0", VA = "0x180BA7CB0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x5755B70", Offset = "0x5754B70", VA = "0x185755B70", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 JOMNABGJAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x5757A60", Offset = "0x5756A60", VA = "0x185757A60", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Quaternion KLJPCCCHPHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x5755C70", Offset = "0x5754C70", VA = "0x185755C70", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private Rigidbody JAMLFHMHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x5755C20", Offset = "0x5754C20", VA = "0x185755C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event NAEAPBAINIJ BDPFCIBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x57572D0", Offset = "0x57562D0", VA = "0x1857572D0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x5757BD0", Offset = "0x5756BD0", VA = "0x185757BD0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x5758410", Offset = "0x5757410", VA = "0x185758410")]
	public KGLMKFHGBLE(PGOKKAHHEHO LKIOOPNDJED, in AJHPHPODBKK HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x5755DE0", Offset = "0x5754DE0", VA = "0x185755DE0", Slot = "17")]
	public void BKDFAKEJMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x5757370", Offset = "0x5756370", VA = "0x185757370", Slot = "16")]
	public void HMNJMGPIBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5757C70", Offset = "0x5756C70", VA = "0x185757C70", Slot = "19")]
	public void KADDKNGPFNM(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5757E70", Offset = "0x5756E70", VA = "0x185757E70", Slot = "20")]
	public void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x5756060", Offset = "0x5755060", VA = "0x185756060", Slot = "18")]
	public void FIKLNLECMNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5757490", Offset = "0x5756490", VA = "0x185757490", Slot = "21")]
	public void IDGGELLJBNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5755FB0", Offset = "0x5754FB0", VA = "0x185755FB0")]
	private void DNPBFMLNAFG(Vector3 CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x57580C0", Offset = "0x57570C0", VA = "0x1857580C0")]
	[Obsolete]
	private Vector3 PAMJJKECFKP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5757D50", Offset = "0x5756D50", VA = "0x185757D50")]
	private void KGJHDPLAAEG(float CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5755B70", Offset = "0x5754B70", VA = "0x185755B70")]
	private void AGNBCADBCOP(float CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x5755A00", Offset = "0x5754A00", VA = "0x185755A00")]
	private Vector3 ACKCLLFIAPG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x57581D0", Offset = "0x57571D0", VA = "0x1857581D0", Slot = "15")]
	public void PNFOHBMEGIE((Quaternion rot, Vector3 moments) DJHFDNAEBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5757160", Offset = "0x5756160", VA = "0x185757160")]
	private Quaternion GDELILPLAAN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x5757080", Offset = "0x5756080", VA = "0x185757080")]
	public void FJOEOCBDDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x57561C0", Offset = "0x57551C0", VA = "0x1857561C0", Slot = "4")]
	public (float, Vector3) FJOEOCBDDOD(Rigidbody DINFEDLPKCI)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class DLIDIOAHGMG
{
	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5743250", Offset = "0x5742250", VA = "0x185743250")]
	public static FBFGNCIBFDJ DPDLIPKABGI(this PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface EIIICLEDNHO : DHALLCIHMFI
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	LGMECHOHFEB<PGOKKAHHEHO> KOJCCBANOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	PGOKKAHHEHO DCJKADKGIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class CEDBGHJOFFF : INKDAFLPOEI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly HFMANEIGDON LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly OEMFJNEEEFM GAEDOLGMEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private float BFEAFJDLOBC;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public INMIHNLNEJO DEEIHGOOGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x91FD50", Offset = "0x91ED50", VA = "0x18091FD50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x93A760", Offset = "0x939760", VA = "0x18093A760", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public GGOGJGFNOFN GHAKLGHCKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x9F7120", Offset = "0x9F6120", VA = "0x1809F7120", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public Vector3 KMIFICDBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x573CD40", Offset = "0x573BD40", VA = "0x18573CD40", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x573CF90", Offset = "0x573BF90", VA = "0x18573CF90", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public Vector3 KEIHGAEJKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x573BC50", Offset = "0x573AC50", VA = "0x18573BC50", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x573B270", Offset = "0x573A270", VA = "0x18573B270", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Vector3 JDGPGHDFHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x573CE60", Offset = "0x573BE60", VA = "0x18573CE60", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x573C0F0", Offset = "0x573B0F0", VA = "0x18573C0F0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public Vector3 OHCDEIMNFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x573B8C0", Offset = "0x573A8C0", VA = "0x18573B8C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x573DEC0", Offset = "0x573CEC0", VA = "0x18573DEC0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public float AKIPAEFKPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x9877A0", Offset = "0x9867A0", VA = "0x1809877A0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x573BD40", Offset = "0x573AD40", VA = "0x18573BD40", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool IBJABDCLBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x995E50", Offset = "0x994E50", VA = "0x180995E50", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private ANGMHCIONKP JCMFPPOFCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x21AF4A0", Offset = "0x21AE4A0", VA = "0x1821AF4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private bool LLEPCFMHOAO
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x573D390", Offset = "0x573C390", VA = "0x18573D390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x573E200", Offset = "0x573D200", VA = "0x18573E200")]
	public CEDBGHJOFFF(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x573B570", Offset = "0x573A570", VA = "0x18573B570", Slot = "19")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x573B860", Offset = "0x573A860", VA = "0x18573B860", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x573BFC0", Offset = "0x573AFC0", VA = "0x18573BFC0", Slot = "28")]
	public void KADDKNGPFNM(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x9952A0", Offset = "0x9942A0", VA = "0x1809952A0", Slot = "20")]
	public void MGMNJDCIKFP(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x9953A0", Offset = "0x9943A0", VA = "0x1809953A0", Slot = "31")]
	public void KGBJMFHCBKK(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x573DEF0", Offset = "0x573CEF0", VA = "0x18573DEF0", Slot = "36")]
	public Vector3 ONJAKBBCCOC(Vector3 CLHHPAFJIIP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x573B6A0", Offset = "0x573A6A0", VA = "0x18573B6A0", Slot = "35")]
	public Vector3 CIKMBONDBGE(Vector3 PECLNPLFMIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x573B570", Offset = "0x573A570", VA = "0x18573B570", Slot = "27")]
	public void BCJLHNGAJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x573E0D0", Offset = "0x573D0D0", VA = "0x18573E0D0", Slot = "25")]
	public void PPDOFFGMEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x573B300", Offset = "0x573A300", VA = "0x18573B300", Slot = "24")]
	public void AOCAHOFFDPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x573D150", Offset = "0x573C150", VA = "0x18573D150", Slot = "34")]
	public void MKIIGHBCAHE(Vector3 KBONMJFJLJN, Vector3 HGFKCPDNNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x573B2A0", Offset = "0x573A2A0", VA = "0x18573B2A0", Slot = "33")]
	public void ADLAMFEDDPP(Vector3 HFEPHLDDIBH, Vector3 PFMLKPNBNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x573CBA0", Offset = "0x573BBA0", VA = "0x18573CBA0", Slot = "32")]
	public void KHDCIDOGGHM(Vector3 LHJMJCLHHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x573D9D0", Offset = "0x573C9D0", VA = "0x18573D9D0", Slot = "22")]
	public void NMIDMGEDAJO(DPIEBFJEGAP GBLKMOHBIIA, Vector3 FJDPGKKBPBE, float CLIOGCOFNBL, float KAMLIANHMOM = 8f, float MCEOKHIBPEH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x573B340", Offset = "0x573A340", VA = "0x18573B340", Slot = "21")]
	public void APICAINOGOA(MGLJIFAIKHI IODJFNIOCBH, Vector3 FDGCBNNCCHO, float CLOFJPCBILA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x573D6D0", Offset = "0x573C6D0", VA = "0x18573D6D0", Slot = "23")]
	[Obsolete]
	public void NHIKFAIIBFN(MGLJIFAIKHI IODJFNIOCBH, Vector3 DEANJFCCEBG, float GGAABPHIDIK = 7f, float GIFLLGIECLE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x573CAE0", Offset = "0x573BAE0", VA = "0x18573CAE0", Slot = "30")]
	public Vector3 KENOPHFFKMB(Vector3 CBPBBILDPPH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x573D050", Offset = "0x573C050", VA = "0x18573D050", Slot = "29")]
	public Vector3 LIBLGGNHIIC(Vector3 NJBJCPFKCBL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x573BE60", Offset = "0x573AE60", VA = "0x18573BE60", Slot = "26")]
	public void JCNGJHGPHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x573BD40", Offset = "0x573AD40", VA = "0x18573BD40")]
	private void IOEAJNBGOAE(float CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x573BAB0", Offset = "0x573AAB0", VA = "0x18573BAB0")]
	private void FGEBPECINON(Vector3 FDGCBNNCCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x573E110", Offset = "0x573D110", VA = "0x18573E110")]
	private Vector3 PPFDOKCLBHJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x573D3B0", Offset = "0x573C3B0", VA = "0x18573D3B0")]
	private void NGKEPMLDOBD(Vector3 PECLNPLFMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x573B9B0", Offset = "0x573A9B0", VA = "0x18573B9B0")]
	private Vector3 EMJIOMJCDMD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x573C7B0", Offset = "0x573B7B0", VA = "0x18573C7B0")]
	private void KEEABBBDKCH(Vector3 CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x573C1B0", Offset = "0x573B1B0", VA = "0x18573C1B0")]
	private void KCMLELDKCEO(Vector3 PECLNPLFMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x573B5E0", Offset = "0x573A5E0", VA = "0x18573B5E0")]
	private void BNMAJHGICDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class NFHAOGHBPAL : JJAPFDMEHGJ
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private const string MIPGDHNEEBN = "IsKinematicByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly HFMANEIGDON LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly OEMFJNEEEFM JBMDJLBDAIM;

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool CKANPFJAFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x71DFE20", Offset = "0x71DEE20", VA = "0x1871DFE20", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public IEnumerable<object> IMCBDIIHPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x71DFEC0", Offset = "0x71DEEC0", VA = "0x1871DFEC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event NAEAPBAINIJ ENNFPKIDCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x71E00C0", Offset = "0x71DF0C0", VA = "0x1871E00C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x71DFF20", Offset = "0x71DEF20", VA = "0x1871DFF20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x71E0280", Offset = "0x71DF280", VA = "0x1871E0280")]
	public NFHAOGHBPAL(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x71E0210", Offset = "0x71DF210", VA = "0x1871E0210", Slot = "12")]
	public IDisposable PFBIGGEBPLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x71DFE10", Offset = "0x71DEE10", VA = "0x1871DFE10", Slot = "9")]
	public void AJCGMBJNPHE(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x71E0270", Offset = "0x71DF270", VA = "0x1871E0270", Slot = "10")]
	public void PMHMAKBGFHM(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x71DFFC0", Offset = "0x71DEFC0", VA = "0x1871DFFC0", Slot = "11")]
	public void HLAJEEHODPC(object DMHDKAFNNAC, bool CLCDDMLICOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x71DFEE0", Offset = "0x71DEEE0", VA = "0x1871DFEE0", Slot = "6")]
	public void EAOHNEHNLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x71E0160", Offset = "0x71DF160", VA = "0x1871E0160", Slot = "13")]
	public void KADDKNGPFNM(Rigidbody GMKHAHOBJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x71E01E0", Offset = "0x71DF1E0", VA = "0x1871E01E0", Slot = "14")]
	public void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class NHHPDBHLOOI : EDPGOHNHHHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly HFMANEIGDON LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private CollisionDetectionMode KPBMIMCKOBP;

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private Rigidbody JAMLFHMHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x71E0310", Offset = "0x71DF310", VA = "0x1871E0310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public CollisionDetectionMode OFODBABDMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x71E04C0", Offset = "0x71DF4C0", VA = "0x1871E04C0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x71E06D0", Offset = "0x71DF6D0", VA = "0x1871E06D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x71E0710", Offset = "0x71DF710", VA = "0x1871E0710")]
	public NHHPDBHLOOI(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x71E0340", Offset = "0x71DF340", VA = "0x1871E0340", Slot = "6")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x71E0580", Offset = "0x71DF580", VA = "0x1871E0580", Slot = "9")]
	public void KADDKNGPFNM(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x71E0570", Offset = "0x71DF570", VA = "0x1871E0570", Slot = "7")]
	public void JLDFKKEAHIF(bool LFKOLODLPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x71E0330", Offset = "0x71DF330", VA = "0x1871E0330", Slot = "8")]
	public void EEKLGJDOJHC(bool LFKOLODLPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x71E05D0", Offset = "0x71DF5D0", VA = "0x1871E05D0", Slot = "10")]
	public bool NPINOOHNIBD(Vector3 HAMNFFBEFHD, out RaycastHit GOKLGMJIOLJ, float OLGGKIEPHEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x71E03F0", Offset = "0x71DF3F0", VA = "0x1871E03F0")]
	private void HMICENAOJCA(bool LFKOLODLPAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class JCHECBEACJN : FKHLLDHDGHI
{
	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5752390", Offset = "0x5751390", VA = "0x185752390", Slot = "4")]
	public DIGKBAFHJGN AJMFIKCABLJ(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5752D40", Offset = "0x5751D40", VA = "0x185752D40", Slot = "5")]
	public INKDAFLPOEI KNJHGOEKNDM(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5752550", Offset = "0x5751550", VA = "0x185752550", Slot = "6")]
	public DHALLCIHMFI BHINEDMILHG(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5752B40", Offset = "0x5751B40", VA = "0x185752B40", Slot = "7")]
	public KNLDOFJBJFF HMBBKDFCHDC(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x5752BB0", Offset = "0x5751BB0", VA = "0x185752BB0", Slot = "8")]
	public JEKHLEEDNNE IDJFFPLDNJC(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x57528B0", Offset = "0x57518B0", VA = "0x1857528B0", Slot = "9")]
	public CPEOJDCENCO FGHFIKDAOEJ(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5752720", Offset = "0x5751720", VA = "0x185752720", Slot = "10")]
	public JJAPFDMEHGJ CJNHGOAJOHH(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5752970", Offset = "0x5751970", VA = "0x185752970", Slot = "11")]
	public ANGMHCIONKP FKDCBIFNEDD(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5752CE0", Offset = "0x5751CE0", VA = "0x185752CE0", Slot = "12")]
	public EDPGOHNHHHB JDLEBPLBDCJ(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5752780", Offset = "0x5751780", VA = "0x185752780", Slot = "13")]
	public BEIFEOFFBLE DIGPIOBGMIG(PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x5752A20", Offset = "0x5751A20", VA = "0x185752A20")]
	public JKMKJMODKDA PLEMCLILPDM(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x5752480", Offset = "0x5751480", VA = "0x185752480")]
	public DBBLNEJGBIA BCDKNDPILEF(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x5752840", Offset = "0x5751840", VA = "0x185752840")]
	public IPHGGGNEIKB IPBNIGFILLG(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5752E50", Offset = "0x5751E50", VA = "0x185752E50")]
	public CFOJAFEIKGD LHAKMEPKBKI(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5752C10", Offset = "0x5751C10", VA = "0x185752C10")]
	public AJAIBHCMOBA MOIMPCLBEPM(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5752670", Offset = "0x5751670", VA = "0x185752670", Slot = "19")]
	public PGOKKAHHEHO BLGFCJFNMEF(RigidbodyEx LKIOOPNDJED, AJHPHPODBKK HCKNMLENIIG, FELONCPAKLL NKHIMAEJAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public JCHECBEACJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x5752A20", Offset = "0x5751A20", VA = "0x185752A20", Slot = "14")]
	private JKMKJMODKDA GNHKHLKBKHI(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x5752480", Offset = "0x5751480", VA = "0x185752480", Slot = "15")]
	private DBBLNEJGBIA DOGKLEMILAK(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x5752840", Offset = "0x5751840", VA = "0x185752840", Slot = "16")]
	private IPHGGGNEIKB FFPFMHAODHJ(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5752E50", Offset = "0x5751E50", VA = "0x185752E50", Slot = "17")]
	private CFOJAFEIKGD MCLEPCMNHHK(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5752C10", Offset = "0x5751C10", VA = "0x185752C10", Slot = "18")]
	private AJAIBHCMOBA IPPALBCIDOE(PGOKKAHHEHO DAHEHNAMFLD, in AJHPHPODBKK HCKNMLENIIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class BPHEPEPDAMC : IMCMDAAMHGF, DIGKBAFHJGN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly PGOKKAHHEHO LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<PGOKKAHHEHO> JAMNLICJHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private PGOKKAHHEHO FMNCHFNIOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private PGOKKAHHEHO AGFCJPGACCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Transform ABMHKIBONJP;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private Transform NLACIKINHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x573A0B0", Offset = "0x57390B0", VA = "0x18573A0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public PGOKKAHHEHO PFNKNMFEFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x94AC50", Offset = "0x949C50", VA = "0x18094AC50", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x573AF20", Offset = "0x5739F20", VA = "0x18573AF20", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public PGOKKAHHEHO EDABIFLHHKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x848B60", Offset = "0x847B60", VA = "0x180848B60", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public IReadOnlyList<PGOKKAHHEHO> EHLHGICFHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x962CB0", Offset = "0x961CB0", VA = "0x180962CB0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event NAEAPBAINIJ OPNOJLLMOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x573B110", Offset = "0x573A110", VA = "0x18573B110", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x573A200", Offset = "0x5739200", VA = "0x18573A200", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event NAEAPBAINIJ PMBDNOEKOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x57397A0", Offset = "0x57387A0", VA = "0x1857397A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x5739700", Offset = "0x5738700", VA = "0x185739700", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event OOOCOIFCPAN HKAKBOHPJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x573ADA0", Offset = "0x5739DA0", VA = "0x18573ADA0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x57395D0", Offset = "0x57385D0", VA = "0x1857395D0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action CNMNJJFJOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x57398E0", Offset = "0x57388E0", VA = "0x1857398E0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x573A340", Offset = "0x5739340", VA = "0x18573A340", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action CNPNDJMFLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x573A2A0", Offset = "0x57392A0", VA = "0x18573A2A0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x573AF30", Offset = "0x5739F30", VA = "0x18573AF30", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<PGOKKAHHEHO> HKHCEAKLADN
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x573AE40", Offset = "0x5739E40", VA = "0x18573AE40", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x573A3E0", Offset = "0x57393E0", VA = "0x18573A3E0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event Action<PGOKKAHHEHO> KLPLJJFKLOD
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x5739840", Offset = "0x5738840", VA = "0x185739840", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x573AD00", Offset = "0x5739D00", VA = "0x18573AD00", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event Action EPGJDKNBLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x573AC60", Offset = "0x5739C60", VA = "0x18573AC60", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x573ABC0", Offset = "0x5739BC0", VA = "0x18573ABC0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event Action<PGOKKAHHEHO> DLEGFCOPGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x573AFD0", Offset = "0x5739FD0", VA = "0x18573AFD0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x573A010", Offset = "0x5739010", VA = "0x18573A010", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x573B1B0", Offset = "0x573A1B0", VA = "0x18573B1B0")]
	public BPHEPEPDAMC(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x5739BE0", Offset = "0x5738BE0", VA = "0x185739BE0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x573A480", Offset = "0x5739480", VA = "0x18573A480", Slot = "30")]
	public void LMENPCDIGEL(PGOKKAHHEHO COLDPDBGEPD, bool BHOCINAFNLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x573AA10", Offset = "0x5739A10", VA = "0x18573AA10", Slot = "6")]
	public void LMHBCFMLBFD(PGOKKAHHEHO GAOHEHNIPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5739A20", Offset = "0x5738A20", VA = "0x185739A20", Slot = "7")]
	public void DKCOKEJBIPP(PGOKKAHHEHO GAOHEHNIPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5739980", Offset = "0x5738980", VA = "0x185739980", Slot = "4")]
	public void DCILHALKLLL(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x573B070", Offset = "0x573A070", VA = "0x18573B070", Slot = "5")]
	public void PHHBPNCHAMJ(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5739670", Offset = "0x5738670", VA = "0x185739670")]
	private void ANACLDHAPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x573AEE0", Offset = "0x5739EE0", VA = "0x18573AEE0")]
	private void NGDNACJDLLN(PGOKKAHHEHO GAOHEHNIPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x5739D90", Offset = "0x5738D90", VA = "0x185739D90")]
	private void FKAEMJJFFPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5739EE0", Offset = "0x5738EE0", VA = "0x185739EE0")]
	private void HPHIKKOKLLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5739C60", Offset = "0x5738C60", VA = "0x185739C60")]
	private void EECHLLHDFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x573A110", Offset = "0x5739110", VA = "0x18573A110")]
	[CompilerGenerated]
	private object JHAONDBPCGK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class MBPIGHOKAPL
{
	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x71DECD0", Offset = "0x71DDCD0", VA = "0x1871DECD0")]
	public static IMCMDAAMHGF AOPFCIHOLLN(this PGOKKAHHEHO DAHEHNAMFLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class MODKNJHAIEN : IPHGGGNEIKB
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const string MGLMKCLPKPO = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly HFMANEIGDON LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly OEMFJNEEEFM GLPKMFEHOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly HLLHIAHOMMI DJKIFAPPBPA;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool IENMIFAEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xB37860", Offset = "0xB36860", VA = "0x180B37860", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public HLLHIAHOMMI JMCLDIIMPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xA74E00", Offset = "0xA73E00", VA = "0x180A74E00", Slot = "5")]
		get
		{
			return default(HLLHIAHOMMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x71DFD70", Offset = "0x71DED70", VA = "0x1871DFD70")]
	public MODKNJHAIEN(PGOKKAHHEHO LKIOOPNDJED, in AJHPHPODBKK HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x71DF990", Offset = "0x71DE990", VA = "0x1871DF990", Slot = "6")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x71DFB40", Offset = "0x71DEB40", VA = "0x1871DFB40")]
	private bool GPHDOGJCIJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x71DFBE0", Offset = "0x71DEBE0", VA = "0x1871DFBE0", Slot = "7")]
	public void KGFJABCJONK(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x71DFD40", Offset = "0x71DED40", VA = "0x1871DFD40", Slot = "8")]
	public void OACKPDFEEIO(object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x71DFC10", Offset = "0x71DEC10", VA = "0x1871DFC10", Slot = "11")]
	public void LLDANDPGOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x71DF800", Offset = "0x71DE800", VA = "0x1871DF800")]
	private void AKMJFKMPMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x71DFA60", Offset = "0x71DEA60", VA = "0x1871DFA60")]
	private void GDDADMBEBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x71DF950", Offset = "0x71DE950", VA = "0x1871DF950", Slot = "10")]
	public void EGKLFNLNAFN(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x71DF910", Offset = "0x71DE910", VA = "0x1871DF910", Slot = "9")]
	public void APLNENFJNBG(PGOKKAHHEHO LKIOOPNDJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface FBFGNCIBFDJ : CFOJAFEIKGD
{
	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) FJOEOCBDDOD(Rigidbody DINFEDLPKCI);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface IMCMDAAMHGF : DIGKBAFHJGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCILHALKLLL(PGOKKAHHEHO LKIOOPNDJED);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHHBPNCHAMJ(PGOKKAHHEHO LKIOOPNDJED);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMHBCFMLBFD(PGOKKAHHEHO GAOHEHNIPGL);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DKCOKEJBIPP(PGOKKAHHEHO GAOHEHNIPGL);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class JEIMPIGGIJF : BEIFEOFFBLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly HFMANEIGDON LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool EOFLFJEGAJL;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool KDNLHMAOJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x979400", Offset = "0x978400", VA = "0x180979400", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x5752F80", Offset = "0x5751F80", VA = "0x185752F80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x57530C0", Offset = "0x57520C0", VA = "0x1857530C0")]
	public JEIMPIGGIJF(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x5753090", Offset = "0x5752090", VA = "0x185753090", Slot = "6")]
	public void KADDKNGPFNM(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x57468C0", Offset = "0x57458C0", VA = "0x1857468C0", Slot = "7")]
	public void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class MHECLKEHHOI : JEKHLEEDNNE
{
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private const int OBGBPGBBNED = 10;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const float FEKIADNJNOK = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const float KMAKOIPCDKJ = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private const float MDCEKPPBCJF = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly HFMANEIGDON LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool BNDMDAEMGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool LANPPIEEFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private int LGKLCIEJGMN;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private Rigidbody JAMLFHMHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x71DEDA0", Offset = "0x71DDDA0", VA = "0x1871DEDA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private bool GOCBCBOEBCD
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x71DEE60", Offset = "0x71DDE60", VA = "0x1871DEE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private bool LLEPCFMHOAO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x71DF5F0", Offset = "0x71DE5F0", VA = "0x1871DF5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private PGOKKAHHEHO PFNKNMFEFND
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x71DF590", Offset = "0x71DE590", VA = "0x1871DF590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private bool MMMBPNNCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x71DF530", Offset = "0x71DE530", VA = "0x1871DF530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event NAEAPBAINIJ GHLEIGCIOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x71DEED0", Offset = "0x71DDED0", VA = "0x1871DEED0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x71DEDC0", Offset = "0x71DDDC0", VA = "0x1871DEDC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x71DF7A0", Offset = "0x71DE7A0", VA = "0x1871DF7A0")]
	public MHECLKEHHOI(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x71DF100", Offset = "0x71DE100", VA = "0x1871DF100", Slot = "6")]
	public void FFBPBJPAOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x71DF520", Offset = "0x71DE520", VA = "0x1871DF520", Slot = "8")]
	public void KKEIJCIPBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x71DF160", Offset = "0x71DE160", VA = "0x1871DF160", Slot = "7")]
	public bool IEGPOINMBNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x71DF090", Offset = "0x71DE090", VA = "0x1871DF090", Slot = "9")]
	public void EJHKPCBFHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x71DF280", Offset = "0x71DE280", VA = "0x1871DF280", Slot = "11")]
	public void JLGCCFNGGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x71DF610", Offset = "0x71DE610", VA = "0x1871DF610", Slot = "12")]
	public void OCLBMPFKCPH(bool FNJGCLCOPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x71DF2E0", Offset = "0x71DE2E0", VA = "0x1871DF2E0", Slot = "10")]
	public void KBPBCMDNJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x71DEF70", Offset = "0x71DDF70", VA = "0x1871DEF70")]
	private bool EEFELNCFMMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x71DF650", Offset = "0x71DE650", VA = "0x1871DF650")]
	private void OJGGMEMCJCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class HAKABGHPAKI : KNLDOFJBJFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly PGOKKAHHEHO LKIOOPNDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float EDFALHBEIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private float FLKBMIKJIIM;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public float LEJJNDENKDK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x9877B0", Offset = "0x9867B0", VA = "0x1809877B0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x574A1D0", Offset = "0x57491D0", VA = "0x18574A1D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public float DBJKOMDHGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x987830", Offset = "0x986830", VA = "0x180987830", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x574A0B0", Offset = "0x57490B0", VA = "0x18574A0B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x574A340", Offset = "0x5749340", VA = "0x18574A340")]
	public HAKABGHPAKI(PGOKKAHHEHO LKIOOPNDJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x574A180", Offset = "0x5749180", VA = "0x18574A180", Slot = "8")]
	public void KADDKNGPFNM(Rigidbody JGFIHJJNFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x574A2A0", Offset = "0x57492A0", VA = "0x18574A2A0", Slot = "9")]
	public void PAGOPPAEGPL(Rigidbody JGFIHJJNFEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface KNGHIFLPEFH : DBBLNEJGBIA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000175")]
	PhotonView MHGOBIKHNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : NLFOBMPCEOI
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x8484E0", Offset = "0x8474E0", VA = "0x1808484E0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x71E6B70", Offset = "0x71E5B70", VA = "0x1871E6B70", Slot = "6")]
		public sealed override void OFPHNFJKOMA(PPNFHEMOJEH PAFCNGJPIGM)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x12847F0", Offset = "0x12837F0", VA = "0x1812847F0")]
	public static string PBLDHIKHPMH(byte[] IHGCJCCJPMA, byte[] NBKBACBBOJK)
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
