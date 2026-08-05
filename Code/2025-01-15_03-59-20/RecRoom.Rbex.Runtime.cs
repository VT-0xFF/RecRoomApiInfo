using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : IMPGLFODBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x76BDA60", Offset = "0x76BCE60", VA = "0x1876BDA60", Slot = "4")]
		public override void EMOBGIHOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1A51480", Offset = "0x1A50880", VA = "0x181A51480", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x76C6FE0", Offset = "0x76C63E0", VA = "0x1876C6FE0")]
		private void PKLDHDIFILK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x76C72E0", Offset = "0x76C66E0", VA = "0x1876C72E0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76C7340", Offset = "0x76C6740", VA = "0x1876C7340")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, JBMMKMCLEMD, FAMNLLOHBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly GKOKEEMOOFG HNFHNFHPGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool EPMGGCENIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private EAMPMJFIPDM OFIBFBAADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[KHGLLLAOHAN(PGGKFLBMAKK.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[KHGLLLAOHAN(PGGKFLBMAKK.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private KBLCCMMKFLK physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Transform NOBMIEKHLON;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal EAMPMJFIPDM NKEGKDFAIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x76C3110", Offset = "0x76C2510", VA = "0x1876C3110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private EAMPMJFIPDM HJOKGBNEDCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int AEJELDFABBC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x76C44F0", Offset = "0x76C38F0", VA = "0x1876C44F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx BKGMECBHOIF
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x76C4850", Offset = "0x76C3C50", VA = "0x1876C4850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx FFIKGEIEAOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x76C4790", Offset = "0x76C3B90", VA = "0x1876C4790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx AMMKPAGCALK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x76C5450", Offset = "0x76C4850", VA = "0x1876C5450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x76C6950", Offset = "0x76C5D50", VA = "0x1876C6950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BBLEIKONDCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x769B4B0", Offset = "0x769A8B0", VA = "0x18769B4B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x769DAF0", Offset = "0x769CEF0", VA = "0x18769DAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform KELFOJAPBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xE75400", Offset = "0xE74800", VA = "0x180E75400", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform NKINGEPPCIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xE75400", Offset = "0xE74800", VA = "0x180E75400", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform CDNEFHIOENJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xE75400", Offset = "0xE74800", VA = "0x180E75400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NCPKOJCDALC LNHAPLKLDDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x76C4550", Offset = "0x76C3950", VA = "0x1876C4550")]
			get
			{
				return default(NCPKOJCDALC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x76C6100", Offset = "0x76C5500", VA = "0x1876C6100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool GAJIHPBLAFA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B60", Offset = "0x76C3F60", VA = "0x1876C4B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool JKNAGOPJNNK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x76C4670", Offset = "0x76C3A70", VA = "0x1876C4670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GKJILOLAJBC ACBBEGKAPJK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x76C4AA0", Offset = "0x76C3EA0", VA = "0x1876C4AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x76C62C0", Offset = "0x76C56C0", VA = "0x1876C62C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public EFFPCFBOJKN FEMJDGKAHCK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x76C4A40", Offset = "0x76C3E40", VA = "0x1876C4A40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x76C6250", Offset = "0x76C5650", VA = "0x1876C6250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NGNHIINCLMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x76C4990", Offset = "0x76C3D90", VA = "0x1876C4990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody EFNNEKIHFHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x76C49F0", Offset = "0x76C3DF0", VA = "0x1876C49F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PBGGBENBKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x76C46D0", Offset = "0x76C3AD0", VA = "0x1876C46D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x76C6170", Offset = "0x76C5570", VA = "0x1876C6170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool FGHCJCNLNEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x737A770", Offset = "0x7379B70", VA = "0x18737A770", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float JAMAFNFFOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x76C53F0", Offset = "0x76C47F0", VA = "0x1876C53F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float LDBELGFFKNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x76C5390", Offset = "0x76C4790", VA = "0x1876C5390")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x76C68E0", Offset = "0x76C5CE0", VA = "0x1876C68E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float NOPCKONEOHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x76C4DC0", Offset = "0x76C41C0", VA = "0x1876C4DC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x76C6560", Offset = "0x76C5960", VA = "0x1876C6560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float AICNDFBFCHA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x76C4BC0", Offset = "0x76C3FC0", VA = "0x1876C4BC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x76C6330", Offset = "0x76C5730", VA = "0x1876C6330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool EBGCDIADLNI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x76C59A0", Offset = "0x76C4DA0", VA = "0x1876C59A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x76C6E90", Offset = "0x76C6290", VA = "0x1876C6E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 FGOIBMEBPPD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x76C5170", Offset = "0x76C4570", VA = "0x1876C5170")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x76C66B0", Offset = "0x76C5AB0", VA = "0x1876C66B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 BPPAELFAMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x76C5AE0", Offset = "0x76C4EE0", VA = "0x1876C5AE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode GAKANPFHJPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x76C4D00", Offset = "0x76C4100", VA = "0x1876C4D00")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x76C6480", Offset = "0x76C5880", VA = "0x1876C6480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float KCCMLPPMEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x76C4730", Offset = "0x76C3B30", VA = "0x1876C4730")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x76C61E0", Offset = "0x76C55E0", VA = "0x1876C61E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints OEKAOCMFPIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x76C4D60", Offset = "0x76C4160", VA = "0x1876C4D60")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x76C64F0", Offset = "0x76C58F0", VA = "0x1876C64F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 BLLEMCGPNAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x76C5510", Offset = "0x76C4910", VA = "0x1876C5510")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 OAJNABNKEKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x76C5510", Offset = "0x76C4910", VA = "0x1876C5510")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x76C6C70", Offset = "0x76C6070", VA = "0x1876C6C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float KFDBLNFGAEG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x76C5250", Offset = "0x76C4650", VA = "0x1876C5250")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x76C6790", Offset = "0x76C5B90", VA = "0x1876C6790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float JMNBJEJNDJF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x76C5940", Offset = "0x76C4D40", VA = "0x1876C5940")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x76C6E20", Offset = "0x76C6220", VA = "0x1876C6E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion CHJLAAMAHGE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x76C55F0", Offset = "0x76C49F0", VA = "0x1876C55F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x76C69F0", Offset = "0x76C5DF0", VA = "0x1876C69F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion BPMBEAOBAND
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x76C5870", Offset = "0x76C4C70", VA = "0x1876C5870")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x76C6D50", Offset = "0x76C6150", VA = "0x1876C6D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 IJGPBJEMIED
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x76C56C0", Offset = "0x76C4AC0", VA = "0x1876C56C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x76C6AC0", Offset = "0x76C5EC0", VA = "0x1876C6AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion HBIOJEAKFHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x76C57A0", Offset = "0x76C4BA0", VA = "0x1876C57A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x76C6BA0", Offset = "0x76C5FA0", VA = "0x1876C6BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 KLNNEIDEPKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x76C5A00", Offset = "0x76C4E00", VA = "0x1876C5A00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x76C6F00", Offset = "0x76C6300", VA = "0x1876C6F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 MJJIJGEDDJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x76C52B0", Offset = "0x76C46B0", VA = "0x1876C52B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x76C6800", Offset = "0x76C5C00", VA = "0x1876C6800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 KFMFAILJFNK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x76C4C20", Offset = "0x76C4020", VA = "0x1876C4C20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x76C63A0", Offset = "0x76C57A0", VA = "0x1876C63A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 JMPPLOEFJOG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x76C5090", Offset = "0x76C4490", VA = "0x1876C5090")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x76C65D0", Offset = "0x76C59D0", VA = "0x1876C65D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 FGCLICEBIDE
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x76C4F50", Offset = "0x76C4350", VA = "0x1876C4F50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion EGPIJFFLEJF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x76C4E80", Offset = "0x76C4280", VA = "0x1876C4E80")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 AJMJAEBKDFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x76C5CA0", Offset = "0x76C50A0", VA = "0x1876C5CA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 IOPDCLLEPII
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x76C5BC0", Offset = "0x76C4FC0", VA = "0x1876C5BC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool NPEMCMBJGFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x76C5030", Offset = "0x76C4430", VA = "0x1876C5030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NMPAHBDOMCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B00", Offset = "0x76C3F00", VA = "0x1876C4B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool HBDOMFCGLCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x76C4610", Offset = "0x76C3A10", VA = "0x1876C4610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool HOJJKJEOJCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x76C45B0", Offset = "0x76C39B0", VA = "0x1876C45B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool ADDDOEGEEMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x76C4490", Offset = "0x76C3890", VA = "0x1876C4490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool EFADPOEIIIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x76C4E20", Offset = "0x76C4220", VA = "0x1876C4E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool MAIEPNIBMOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1D08CB0", Offset = "0x1D080B0", VA = "0x181D08CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event BLIFDFFFFCN MHBBLPAGIMM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x76C43B0", Offset = "0x76C37B0", VA = "0x1876C43B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x76C6020", Offset = "0x76C5420", VA = "0x1876C6020")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event NNNLLNDCCPA KFLEHKABKMN
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x76C4120", Offset = "0x76C3520", VA = "0x1876C4120")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x76C5D80", Offset = "0x76C5180", VA = "0x1876C5D80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event NNNLLNDCCPA CIMNDIFFJNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x76C4180", Offset = "0x76C3580", VA = "0x1876C4180")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x76C5DF0", Offset = "0x76C51F0", VA = "0x1876C5DF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event NNNLLNDCCPA IDKNKMIALCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x76C42D0", Offset = "0x76C36D0", VA = "0x1876C42D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x76C5F40", Offset = "0x76C5340", VA = "0x1876C5F40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<HODEOENILDN, HODEOENILDN> GEGDOIBPJAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x76C4260", Offset = "0x76C3660", VA = "0x1876C4260")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x76C5ED0", Offset = "0x76C52D0", VA = "0x1876C5ED0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event NNNLLNDCCPA DMIMMGIFLNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x76C4340", Offset = "0x76C3740", VA = "0x1876C4340")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x76C5FB0", Offset = "0x76C53B0", VA = "0x1876C5FB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event NNNLLNDCCPA EAFIDAJPIJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x76C4420", Offset = "0x76C3820", VA = "0x1876C4420")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x76C6090", Offset = "0x76C5490", VA = "0x1876C6090")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event NNNLLNDCCPA KNEGNLFJNMA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x76C41F0", Offset = "0x76C35F0", VA = "0x1876C41F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x76C5E60", Offset = "0x76C5260", VA = "0x1876C5E60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C7990", Offset = "0x8C6D90", VA = "0x1808C7990", Slot = "8")]
		private void EALBCJOMGKB(EAMPMJFIPDM HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x76C3020", Offset = "0x76C2420", VA = "0x1876C3020")]
		internal void MEIDKLKPHAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76C3E50", Offset = "0x76C3250", VA = "0x1876C3E50")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody MFFABEIIKCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x76C27F0", Offset = "0x76C1BF0", VA = "0x1876C27F0")]
		public JBMMKMCLEMD GetChild(int IIACLAMOIEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x76C3AB0", Offset = "0x76C2EB0", VA = "0x1876C3AB0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) ILJHDCDBMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x76C25A0", Offset = "0x76C19A0", VA = "0x1876C25A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x76C3D40", Offset = "0x76C3140", VA = "0x1876C3D40")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x76C3110", Offset = "0x76C2510", VA = "0x1876C3110")]
		private EAMPMJFIPDM PLADNHOGINH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x76C2D00", Offset = "0x76C2100", VA = "0x1876C2D00")]
		private void LKOIGPCFEMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x76C3280", Offset = "0x76C2680", VA = "0x1876C3280")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x76C31C0", Offset = "0x76C25C0", VA = "0x1876C31C0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x76C3020", Offset = "0x76C2420", VA = "0x1876C3020")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x76C3220", Offset = "0x76C2620", VA = "0x1876C3220")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x76C32E0", Offset = "0x76C26E0", VA = "0x1876C32E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x76C1B90", Offset = "0x76C0F90", VA = "0x1876C1B90")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object CMNJCPJBHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x76C3340", Offset = "0x76C2740", VA = "0x1876C3340")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object CMNJCPJBHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x76C2790", Offset = "0x76C1B90", VA = "0x1876C2790")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x76C30B0", Offset = "0x76C24B0", VA = "0x1876C30B0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x76C3C10", Offset = "0x76C3010", VA = "0x1876C3C10")]
		public void SetParent(RigidbodyEx HCPAOILCJCB, bool JAMKBEGAKKK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x76C3650", Offset = "0x76C2A50", VA = "0x1876C3650")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x76C2AA0", Offset = "0x76C1EA0", VA = "0x1876C2AA0")]
		public bool IsRigidbodyAncestor(RigidbodyEx HDOFBIJLBJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x76C2BA0", Offset = "0x76C1FA0", VA = "0x1876C2BA0")]
		public bool IsRigidbodyDescendant(RigidbodyEx ODBBCIGBLIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x76C1E00", Offset = "0x76C1200", VA = "0x1876C1E00")]
		public void AddInterpolationRestriction(object CMNJCPJBHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x76C33B0", Offset = "0x76C27B0", VA = "0x1876C33B0")]
		public void RemoveInterpolationRestriction(object CMNJCPJBHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x76C1E70", Offset = "0x76C1270", VA = "0x1876C1E70")]
		public void AddKinematic(object CMNJCPJBHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x76C3420", Offset = "0x76C2820", VA = "0x1876C3420")]
		public void RemoveKinematic(object CMNJCPJBHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x76C3B90", Offset = "0x76C2F90", VA = "0x1876C3B90")]
		public void SetKinematic(object CMNJCPJBHGE, bool CKPMADLDOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x76C39B0", Offset = "0x76C2DB0", VA = "0x1876C39B0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 NAHFOOFADAD, Quaternion FDEFNOBEGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x76C38B0", Offset = "0x76C2CB0", VA = "0x1876C38B0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 IIBFNIDFABP, Quaternion OEKHKEJMIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x76C2990", Offset = "0x76C1D90", VA = "0x1876C2990")]
		public Vector3 GetConstrainedVelocity(Vector3 KLNNEIDEPKF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x76C2880", Offset = "0x76C1C80", VA = "0x1876C2880")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 KFMFAILJFNK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x76C1D10", Offset = "0x76C1110", VA = "0x1876C1D10")]
		public void AddForce(Vector3 MKNFMGNFODH, ForceMode KKGJDJKIGAK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x76C1C00", Offset = "0x76C1000", VA = "0x1876C1C00")]
		public void AddForceAtPosition(Vector3 MKNFMGNFODH, Vector3 CPGMOBFHDAC, ForceMode KKGJDJKIGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x76C2040", Offset = "0x76C1440", VA = "0x1876C2040")]
		public void AddTorque(Vector3 FLGIFKEJPMG, ForceMode KKGJDJKIGAK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x76C1EE0", Offset = "0x76C12E0", VA = "0x1876C1EE0")]
		public void AddRelativeTorque(Vector3 FLGIFKEJPMG, ForceMode KKGJDJKIGAK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x76C3F20", Offset = "0x76C3320", VA = "0x1876C3F20")]
		public Vector3 WorldToLocalVelocity(Vector3 FPGFMPILIAN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x76C2F10", Offset = "0x76C2310", VA = "0x1876C2F10")]
		public Vector3 LocalToWorldVelocity(Vector3 MJJIJGEDDJO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x76C2730", Offset = "0x76C1B30", VA = "0x1876C2730")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x76C26D0", Offset = "0x76C1AD0", VA = "0x1876C26D0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x76C2670", Offset = "0x76C1A70", VA = "0x1876C2670")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x76C2610", Offset = "0x76C1A10", VA = "0x1876C2610")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x76C37B0", Offset = "0x76C2BB0", VA = "0x1876C37B0")]
		public void ResetVelocityWorldSpace(Vector3 IIPCJAOLCGL, Vector3 JDEICCDPEBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x76C36B0", Offset = "0x76C2AB0", VA = "0x1876C36B0")]
		public void ResetVelocityLocalSpace(Vector3 MODOOLGGFMH, Vector3 JMPPLOEFJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x76C3570", Offset = "0x76C2970", VA = "0x1876C3570")]
		public void ResetLinearVelocityLocalSpace(Vector3 MODOOLGGFMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x76C3D50", Offset = "0x76C3150", VA = "0x1876C3D50")]
		public bool SweepTest(Vector3 LIDLBHGKPBN, [Out] RaycastHit OEFCPHKEKMJ, float KIECEDCFNCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x76C2CA0", Offset = "0x76C20A0", VA = "0x1876C2CA0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x76C3CE0", Offset = "0x76C30E0", VA = "0x1876C3CE0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x76C3EC0", Offset = "0x76C32C0", VA = "0x1876C3EC0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x76C1FD0", Offset = "0x76C13D0", VA = "0x1876C1FD0")]
		public void AddShouldHaveUnityRigidbodyToken(object CMNJCPJBHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x76C3490", Offset = "0x76C2890", VA = "0x1876C3490")]
		public void RemoveShouldHaveUnityRigidbodyToken(object CMNJCPJBHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x76C23D0", Offset = "0x76C17D0", VA = "0x1876C23D0")]
		public void ApplyForceVelocityChange(CHDHBDHLHKI BIEBDPIGOMG, Vector3 ONIFOJGMGJC, float LIIJBIKPANP, float GCHLECDEBPI = 8f, float LADGMJOCDMA = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x76C22D0", Offset = "0x76C16D0", VA = "0x1876C22D0")]
		public void ApplyAngularVelocityChange(MFDGILLPOIO FLOMCHMPOIC, Vector3 JJADDKAGGLG, float GIIMKAIGAJH = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x76C2490", Offset = "0x76C1890", VA = "0x1876C2490")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(MFDGILLPOIO FLOMCHMPOIC, Vector3 CBCAIPELAJP, float AMJKNOLCIOF = 7f, float LHJIPGKFCBJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x76C2200", Offset = "0x76C1600", VA = "0x1876C2200")]
		public bool AllowedScaleChange(float MPACBOHCOML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x76C2130", Offset = "0x76C1530", VA = "0x1876C2130")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx IBDEDNMMKKK, object CMNJCPJBHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x76C3500", Offset = "0x76C2900", VA = "0x1876C3500")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object CMNJCPJBHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x76C40B0", Offset = "0x76C34B0", VA = "0x1876C40B0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD98400", Offset = "0xD97800", VA = "0x180D98400", Slot = "4")]
		private GameObject COFKHHHDBDI()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8F2B70", Offset = "0x8F1F70", VA = "0x1808F2B70", Slot = "9")]
		private bool HKCAABAJPPK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class CEOCFIJIPCJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x76AEDD0", Offset = "0x76AE1D0", VA = "0x1876AEDD0")]
	public static EAMPMJFIPDM NKEGKDFAIEK(this RigidbodyEx EBMLJFOEMMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(EBPOEAENCPP), new string[] { })]
public class CHBNJHILIPJ : EBPOEAENCPP, DMLBGGHLGCD
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private DEIPDBHMECK KJPBBFANAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CFALCOAJONO IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private FLEIJAHHFJE IIEHNAGOKNN;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public CFALCOAJONO EEGJAFGKABI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public FLEIJAHHFJE EOGCHCFJJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x76AEF40", Offset = "0x76AE340", VA = "0x1876AEF40", Slot = "7")]
	public void InitReferences(PBPBPCOFCDM LAACHEAGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x76AEE40", Offset = "0x76AE240", VA = "0x1876AEE40", Slot = "6")]
	public EAMPMJFIPDM ADFMNCLFDHL(RigidbodyEx EBMLJFOEMMC, LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public CHBNJHILIPJ()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static MIPKPFFHABJ UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int GEHOCFNBPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int LHJKIDDEIFN;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x76C1A10", Offset = "0x76C0E10", VA = "0x1876C1A10")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x76C1A50", Offset = "0x76C0E50", VA = "0x1876C1A50")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x76C1A30", Offset = "0x76C0E30", VA = "0x1876C1A30")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string LNICHECHJFC, [Optional] UnityEngine.Object NOIHGGNEIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string LNICHECHJFC, [Optional] UnityEngine.Object NOIHGGNEIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x76C1B40", Offset = "0x76C0F40", VA = "0x1876C1B40")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FIGDMLJBEBO
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class DKMJIIDGLCN : GKJILOLAJBC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8D6850", Offset = "0x8D5C50", VA = "0x1808D6850", Slot = "4")]
		public Vector3 ANPMKOPFKEF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8D6850", Offset = "0x8D5C50", VA = "0x1808D6850", Slot = "5")]
		public Vector3 PPMEFKCFOJA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public DKMJIIDGLCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static GKJILOLAJBC CDEONJCEPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x76B04C0", Offset = "0x76AF8C0", VA = "0x1876B04C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CECACCLHBNP
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode DMJBAPBDLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCFCMPGINLD();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNAGAICLHIL(bool NPEMCMBJGFD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ENAGIICHGOA(bool NPEMCMBJGFD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CEOFAKPPGEF(Rigidbody JKGEPDGLGMF);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool APFBDCMHMKJ(Vector3 LIDLBHGKPBN, [Out] RaycastHit OEFCPHKEKMJ, float KIECEDCFNCJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BEKEFNANCPN : IDisposable, NKAHIGEFOEF
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	NCPKOJCDALC LNHAPLKLDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<HODEOENILDN, HODEOENILDN> GEGDOIBPJAD;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCFCMPGINLD();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface FLEIJAHHFJE
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OKGLDOCFPGP GLBBLFOFCID(EAMPMJFIPDM HKNABNLJGOH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JAIOOHLDJGA GIJNFBCFACI(EAMPMJFIPDM HKNABNLJGOH);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JLBAOFIMFPA DABGDAIPDMM(EAMPMJFIPDM HKNABNLJGOH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MOCPIJFKDBC GDAMOIIDBBF(EAMPMJFIPDM HKNABNLJGOH);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JHOKKOPKHIM AABLIJOCAIP(EAMPMJFIPDM HKNABNLJGOH);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BEKEFNANCPN GCGAGICDLNO(EAMPMJFIPDM HKNABNLJGOH);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FMHANGAHEAH ODDJHCKGLKI(EAMPMJFIPDM HKNABNLJGOH);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LHFHNOBGFPC HOOHEJDACDL(EAMPMJFIPDM HKNABNLJGOH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CECACCLHBNP INMBMOGLDAE(EAMPMJFIPDM HKNABNLJGOH);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AGAOEAHAKKH ONDFDNGEIJI(EAMPMJFIPDM HKNABNLJGOH);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NDODJONNKFG IINLBMBBLOH(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MIAENNBGOLJ EJICNKHDELM(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JCHCJJOHIHG NJEHHLCOCDP(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HDMALIPKHHC ICPFHLLLHED(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KJHAOHOLDGI DKJHGLHIKAG(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EAMPMJFIPDM ADFMNCLFDHL(RigidbodyEx EBMLJFOEMMC, LFGJEKNLFEG JGCOLLOOLHL, EBPOEAENCPP KCLPDCIIPCH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LHFHNOBGFPC
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPGCMNFKCPM(Vector3 MKNFMGNFODH, ForceMode KKGJDJKIGAK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFPGKIIIKOP(Vector3 MKNFMGNFODH, Vector3 CPGMOBFHDAC, ForceMode KKGJDJKIGAK);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONGDOCOALPF(Vector3 FLGIFKEJPMG, ForceMode KKGJDJKIGAK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MLNNFBLMKJP(Vector3 FLGIFKEJPMG, ForceMode KKGJDJKIGAK = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AGAOEAHAKKH
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool HBECIGFHCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CEOFAKPPGEF(Rigidbody JKGEPDGLGMF);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IIFBFPMNKMD(Rigidbody JKGEPDGLGMF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OKGLDOCFPGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<EAMPMJFIPDM> FBKBEPCCCOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	EAMPMJFIPDM FFIKGEIEAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	EAMPMJFIPDM HOBMCFDJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event NNNLLNDCCPA KFLEHKABKMN;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event NNNLLNDCCPA CIMNDIFFJNI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event BLIFDFFFFCN NGKAACAMJAP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action APDECBJKDMG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action LAPFHJMHJMI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<EAMPMJFIPDM> EKHHGKGOKNI;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<EAMPMJFIPDM> KKLILFNLOJN;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action APADEALJFBA;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<EAMPMJFIPDM> NDEHEEIHENP;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KAPGKFEMBMB(EAMPMJFIPDM NBJNONHAKJK, bool JAMKBEGAKKK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JLBAOFIMFPA
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 EJOMKAGJDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 LNMMMMLPDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LIOFBCAACAC(EAMPMJFIPDM AMMKPAGCALK, object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IGAFJGFJOCF(object CMNJCPJBHGE);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HDMALIPKHHC
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 CEDOOBMGJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 BFDJIOFJCDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float EOKGHAGPAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float HAEFLDKLGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 PCPJCDMIJKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion GFOFBGIDMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event NNNLLNDCCPA OPCKNAFPGKM;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BPCKPJIFJPJ((Quaternion rot, Vector3 moments) ILJHDCDBMMG);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EHMNKDGDHDM();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KPAFAJAOCIK();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PPMKFKODDLE();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CEOFAKPPGEF(Rigidbody JKGEPDGLGMF);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IIFBFPMNKMD(Rigidbody JKGEPDGLGMF);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MKGHIBCBAHN();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JCHCJJOHIHG
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCFCMPGINLD();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJLIOBLAOFA(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void INLFCHNPJEC(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GBGAAPHGMGA(EAMPMJFIPDM EBMLJFOEMMC);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPKEKAFOHBP(EAMPMJFIPDM EBMLJFOEMMC);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDLPOJHBENN();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FMHANGAHEAH
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool PPIIAABHJCO
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event NNNLLNDCCPA BMKCHOEGHLB;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PPBAIDPEJJJ(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CDFDHFNFKHE(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GKPAEPIOIOB(object CMNJCPJBHGE, bool CKPMADLDOMI);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CEOFAKPPGEF(Rigidbody LAANDEEMEGN);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IIFBFPMNKMD(Rigidbody JKGEPDGLGMF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MIAENNBGOLJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool GAJIHPBLAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool JKNAGOPJNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event NNNLLNDCCPA LPPJOENHEKM;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCFCMPGINLD();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BLKPFNJHPFC(EAMPMJFIPDM AMMKPAGCALK);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ODKBLHFLNKJ(EAMPMJFIPDM AMMKPAGCALK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KJHAOHOLDGI
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool PBGGBENBKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool DBDLMJFABHI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints HOIEFHNEJFE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CEOFAKPPGEF(Rigidbody JKGEPDGLGMF);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IIFBFPMNKMD(Rigidbody JKGEPDGLGMF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MOCPIJFKDBC
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float ILOEMAEECMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float CFNILIBNGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CEOFAKPPGEF(Rigidbody JKGEPDGLGMF);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IIFBFPMNKMD(Rigidbody JKGEPDGLGMF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JHOKKOPKHIM
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	static bool AFHOEAIDPKA;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event NNNLLNDCCPA CEFJFMIMOJO;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCFCMPGINLD();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DDLEPECEOGG();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HEGGPJKKGNG();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BIGDJFKKKCB();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CNPIHLDFBJP();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LNBLEKEAFNI();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EHEKJALHEAN(bool GGECBBHOKCJ);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OADFMMHPIPB();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NDODJONNKFG
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody EFNNEKIHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool BLEGLEABHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCFCMPGINLD();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHMLNINGDIN(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGLMCCCILMF(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GAEIPGJCMNN();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JAIOOHLDJGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	GKJILOLAJBC ACBBEGKAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	EFFPCFBOJKN FEMJDGKAHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 KIAHBPMMAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 JMPOGBANHHL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 HCAJPFEACIM
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 JLENKFHPDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float KCCMLPPMEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool NGNHIINCLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OCFCMPGINLD();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MJGMGBCHMJF(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CBHLPJNCLIG(MFDGILLPOIO FLOMCHMPOIC, Vector3 JJADDKAGGLG, float GIIMKAIGAJH = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ADHGKABNEOE(CHDHBDHLHKI BIEBDPIGOMG, Vector3 ONIFOJGMGJC, float LIIJBIKPANP, float GCHLECDEBPI = 8f, float LADGMJOCDMA = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MCHDDMAIDLM(MFDGILLPOIO FLOMCHMPOIC, Vector3 CBCAIPELAJP, float AMJKNOLCIOF = 7f, float LHJIPGKFCBJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LMHEOLDAMJG();

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AMIBEBEGNNE();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MLIIOPEGDCK();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void JFELHGOGIML();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CEOFAKPPGEF(Rigidbody JKGEPDGLGMF);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 PLFHMGDBJLF(Vector3 KLNNEIDEPKF);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JOCLFILHMAD(object CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DGLHGNBFKOA(Vector3 KBBOLBHAJEC);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LLMECHIHOOJ(Vector3 MODOOLGGFMH, Vector3 JMPPLOEFJOG);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MFPPKFIOGGP(Vector3 IIPCJAOLCGL, Vector3 JDEICCDPEBF);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 FEKDHJGMJJI(Vector3 MJJIJGEDDJO);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 BHCPJLJFLBG(Vector3 FPGFMPILIAN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface CFALCOAJONO
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool ABJJPKGPIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KIBHLOBANJA(string PLAICKAFAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FJIMPPCIHBM(RigidbodyEx EBMLJFOEMMC, Action OLHFOBIBHCJ);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	POJBILGPAFB KGAIKPDFJAO(int KKNCBAHJOKH);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OEHMMHPHMNC(Vector3 BPPAELFAMPG, float DMKPOJJCMHC, Color IGJDLCJEHCH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface EBPOEAENCPP
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	CFALCOAJONO EEGJAFGKABI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	FLEIJAHHFJE EOGCHCFJJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EAMPMJFIPDM ADFMNCLFDHL(RigidbodyEx EBMLJFOEMMC, LFGJEKNLFEG JGCOLLOOLHL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JDNONKLFDEO : EAMPMJFIPDM, IDisposable, HJCLDLDAPKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly EBPOEAENCPP KCLPDCIIPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal OKGLDOCFPGP BDGKALLONKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal JCHCJJOHIHG KFPHFGGKEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal MIAENNBGOLJ CNFDHFPDHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal JAIOOHLDJGA KLNNEIDEPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal JLBAOFIMFPA KCNGBNCEGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal HDMALIPKHHC PLOAGCMLAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal MOCPIJFKDBC GAJMPNJFBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal AGAOEAHAKKH AHNBJPLKFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal JHOKKOPKHIM FGJLCDFDMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal BEKEFNANCPN EICCLKKOALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal FMHANGAHEAH EDEKLJOOLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal LHFHNOBGFPC MKNFMGNFODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal KJHAOHOLDGI BCINKIJEAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal NDODJONNKFG JKGEPDGLGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal CECACCLHBNP DABDCBAGJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable JCJOMJPFOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool PJHBLPLEBDB;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public AOMADBOBEAJ HAFIFOLIHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "22")]
		get
		{
			return default(AOMADBOBEAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public JBMMKMCLEMD PFNMMGCNFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA8C290", Offset = "0xA8B690", VA = "0x180A8C290", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA8BFE0", Offset = "0xA8B3E0", VA = "0x180A8BFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject ILKBGMGJJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8CDCD0", Offset = "0x8CD0D0", VA = "0x1808CDCD0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD20", Offset = "0x8CD120", VA = "0x1808CDD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform DCIPDEOFAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x99A220", Offset = "0x999620", VA = "0x18099A220", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA9C280", Offset = "0xA9B680", VA = "0x180A9C280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody EFNNEKIHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x76B2590", Offset = "0x76B1990", VA = "0x1876B2590", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public EAMPMJFIPDM HOBMCFDJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x76B82E0", Offset = "0x76B76E0", VA = "0x1876B82E0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x76B63B0", Offset = "0x76B57B0", VA = "0x1876B63B0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int AEJELDFABBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x76B4810", Offset = "0x76B3C10", VA = "0x1876B4810", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public EAMPMJFIPDM FFIKGEIEAOE
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x76B6900", Offset = "0x76B5D00", VA = "0x1876B6900", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool HIBADHJGNMI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x76B39F0", Offset = "0x76B2DF0", VA = "0x1876B39F0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool GAJIHPBLAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x76B5100", Offset = "0x76B4500", VA = "0x1876B5100", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool JKNAGOPJNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x76B6E10", Offset = "0x76B6210", VA = "0x1876B6E10", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public GKJILOLAJBC ACBBEGKAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x76B48F0", Offset = "0x76B3CF0", VA = "0x1876B48F0", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x76B6E60", Offset = "0x76B6260", VA = "0x1876B6E60", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public EFFPCFBOJKN FEMJDGKAHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x76B5440", Offset = "0x76B4840", VA = "0x1876B5440", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x76B47B0", Offset = "0x76B3BB0", VA = "0x1876B47B0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float KCCMLPPMEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x76B5D80", Offset = "0x76B5180", VA = "0x1876B5D80", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x76B4940", Offset = "0x76B3D40", VA = "0x1876B4940", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 JMPOGBANHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x76B6220", Offset = "0x76B5620", VA = "0x1876B6220", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x76B7930", Offset = "0x76B6D30", VA = "0x1876B7930", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 JLENKFHPDOO
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x76B6CE0", Offset = "0x76B60E0", VA = "0x1876B6CE0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x76B7560", Offset = "0x76B6960", VA = "0x1876B7560", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 KIAHBPMMAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x76B5300", Offset = "0x76B4700", VA = "0x1876B5300", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x76B5EF0", Offset = "0x76B52F0", VA = "0x1876B5EF0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 HCAJPFEACIM
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x76B5FD0", Offset = "0x76B53D0", VA = "0x1876B5FD0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x76B7640", Offset = "0x76B6A40", VA = "0x1876B7640", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool HBDOMFCGLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x76B21E0", Offset = "0x76B15E0", VA = "0x1876B21E0", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool HOJJKJEOJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x76B2FD0", Offset = "0x76B23D0", VA = "0x1876B2FD0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool ADDDOEGEEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x76B3C20", Offset = "0x76B3020", VA = "0x1876B3C20", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool NGNHIINCLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x76B5C10", Offset = "0x76B5010", VA = "0x1876B5C10", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 EJOMKAGJDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x76B55A0", Offset = "0x76B49A0", VA = "0x1876B55A0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 LNMMMMLPDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x76B4FC0", Offset = "0x76B43C0", VA = "0x1876B4FC0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 CEDOOBMGJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x76B5150", Offset = "0x76B4550", VA = "0x1876B5150", Slot = "54")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x76B1F50", Offset = "0x76B1350", VA = "0x1876B1F50", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 BFDJIOFJCDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x76B36E0", Offset = "0x76B2AE0", VA = "0x1876B36E0", Slot = "56")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float EOKGHAGPAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x76B2EF0", Offset = "0x76B22F0", VA = "0x1876B2EF0", Slot = "57")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float HAEFLDKLGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x76B2F80", Offset = "0x76B2380", VA = "0x1876B2F80", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x76B8280", Offset = "0x76B7680", VA = "0x1876B8280", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 PCPJCDMIJKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x76B4070", Offset = "0x76B3470", VA = "0x1876B4070", Slot = "60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion GFOFBGIDMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x76B3920", Offset = "0x76B2D20", VA = "0x1876B3920", Slot = "61")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float ILOEMAEECMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x76B3A50", Offset = "0x76B2E50", VA = "0x1876B3A50", Slot = "63")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x76B49A0", Offset = "0x76B3DA0", VA = "0x1876B49A0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float CFNILIBNGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x76B3AA0", Offset = "0x76B2EA0", VA = "0x1876B3AA0", Slot = "65")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x76B66D0", Offset = "0x76B5AD0", VA = "0x1876B66D0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool HBECIGFHCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x76B6DC0", Offset = "0x76B61C0", VA = "0x1876B6DC0", Slot = "67")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x76B5540", Offset = "0x76B4940", VA = "0x1876B5540", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public NCPKOJCDALC LNHAPLKLDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x76B5E50", Offset = "0x76B5250", VA = "0x1876B5E50", Slot = "69")]
		get
		{
			return default(NCPKOJCDALC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x76B5BB0", Offset = "0x76B4FB0", VA = "0x1876B5BB0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool PPIIAABHJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x76B5DD0", Offset = "0x76B51D0", VA = "0x1876B5DD0", Slot = "71")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform CDNEFHIOENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x99A220", Offset = "0x999620", VA = "0x18099A220", Slot = "72")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 KFAAPGELFJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x76B4700", Offset = "0x76B3B00", VA = "0x1876B4700", Slot = "73")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x76B6F50", Offset = "0x76B6350", VA = "0x1876B6F50", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float IMHJPFNFNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x76B8170", Offset = "0x76B7570", VA = "0x1876B8170", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x76B4230", Offset = "0x76B3630", VA = "0x1876B4230", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float NHIEPKPONDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x76B3FD0", Offset = "0x76B33D0", VA = "0x1876B3FD0", Slot = "77")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x76B43D0", Offset = "0x76B37D0", VA = "0x1876B43D0", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion GDDACFGNJEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x76B5670", Offset = "0x76B4A70", VA = "0x1876B5670", Slot = "79")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x76B4150", Offset = "0x76B3550", VA = "0x1876B4150", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 JOKDPLOFCPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B00", Offset = "0x76B4F00", VA = "0x1876B5B00", Slot = "81")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x76B3FE0", Offset = "0x76B33E0", VA = "0x1876B3FE0", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion LIEFADIIOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x76B2F40", Offset = "0x76B2340", VA = "0x1876B2F40", Slot = "83")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x76B5E20", Offset = "0x76B5220", VA = "0x1876B5E20", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints HOIEFHNEJFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x76B3690", Offset = "0x76B2A90", VA = "0x1876B3690", Slot = "85")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x76B7430", Offset = "0x76B6830", VA = "0x1876B7430", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool PBGGBENBKEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x76B4020", Offset = "0x76B3420", VA = "0x1876B4020", Slot = "87")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x76B2820", Offset = "0x76B1C20", VA = "0x1876B2820", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode DMJBAPBDLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x76B6360", Offset = "0x76B5760", VA = "0x1876B6360", Slot = "89")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x76B52A0", Offset = "0x76B46A0", VA = "0x1876B52A0", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool JFAEAJDNHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x76B7FD0", Offset = "0x76B73D0", VA = "0x1876B7FD0", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool NMPAHBDOMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x76B6410", Offset = "0x76B5810", VA = "0x1876B6410", Slot = "91")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event NNNLLNDCCPA KFLEHKABKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x76B4E40", Offset = "0x76B4240", VA = "0x1876B4E40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x76B3630", Offset = "0x76B2A30", VA = "0x1876B3630", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event NNNLLNDCCPA CIMNDIFFJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x76B5D20", Offset = "0x76B5120", VA = "0x1876B5D20", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x76B30E0", Offset = "0x76B24E0", VA = "0x1876B30E0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event BLIFDFFFFCN NGKAACAMJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x76B37C0", Offset = "0x76B2BC0", VA = "0x1876B37C0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x76B8110", Offset = "0x76B7510", VA = "0x1876B8110", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event NNNLLNDCCPA LPPJOENHEKM
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x76B5C60", Offset = "0x76B5060", VA = "0x1876B5C60", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x76B6A40", Offset = "0x76B5E40", VA = "0x1876B6A40", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event NNNLLNDCCPA IDKNKMIALCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x76B7490", Offset = "0x76B6890", VA = "0x1876B7490", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x76B6AA0", Offset = "0x76B5EA0", VA = "0x1876B6AA0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event NNNLLNDCCPA CEFJFMIMOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x76B5CC0", Offset = "0x76B50C0", VA = "0x1876B5CC0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x76B53E0", Offset = "0x76B47E0", VA = "0x1876B53E0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<HODEOENILDN, HODEOENILDN> GEGDOIBPJAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x76B6300", Offset = "0x76B5700", VA = "0x1876B6300", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x76B3030", Offset = "0x76B2430", VA = "0x1876B3030", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event NNNLLNDCCPA BMKCHOEGHLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x76B6730", Offset = "0x76B5B30", VA = "0x1876B6730", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x76B60B0", Offset = "0x76B54B0", VA = "0x1876B60B0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event NNNLLNDCCPA KNEGNLFJNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x76B7000", Offset = "0x76B6400", VA = "0x1876B7000", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x76B7A10", Offset = "0x76B6E10", VA = "0x1876B7A10", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x76B8420", Offset = "0x76B7820", VA = "0x1876B8420")]
	public JDNONKLFDEO(GameObject MCCIFMIMANN, RigidbodyEx ADFPJBPFNDM, EBPOEAENCPP KCLPDCIIPCH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x76B2A40", Offset = "0x76B1E40", VA = "0x1876B2A40", Slot = "138")]
	protected virtual void CACPNPPNOLN(EBPOEAENCPP KCLPDCIIPCH, LFGJEKNLFEG JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x76B3820", Offset = "0x76B2C20", VA = "0x1876B3820", Slot = "139")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x76B7720", Offset = "0x76B6B20", VA = "0x1876B7720", Slot = "92")]
	public void OCFCMPGINLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x76B5A70", Offset = "0x76B4E70", VA = "0x1876B5A70", Slot = "93")]
	public void JNCFIEEAJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x76B1D30", Offset = "0x76B1130", VA = "0x1876B1D30", Slot = "94")]
	public void ACEAJHFJPJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x76B4660", Offset = "0x76B3A60", VA = "0x1876B4660", Slot = "95")]
	public void FMGABLBNPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x76B3D00", Offset = "0x76B3100", VA = "0x1876B3D00")]
	private void EHEKJALHEAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x76B7CF0", Offset = "0x76B70F0", VA = "0x1876B7CF0")]
	private void ONKBEGDNIMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x76B6790", Offset = "0x76B5B90", VA = "0x1876B6790")]
	private void LNBLEKEAFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x76B4680", Offset = "0x76B3A80", VA = "0x1876B4680", Slot = "30")]
	public EAMPMJFIPDM FPHHEOEFCOH(int IIACLAMOIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x76B5B40", Offset = "0x76B4F40", VA = "0x1876B5B40", Slot = "97")]
	public void KAPGKFEMBMB(EAMPMJFIPDM HCPAOILCJCB, bool JAMKBEGAKKK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x76B2180", Offset = "0x76B1580", VA = "0x1876B2180", Slot = "98")]
	public void BDMJEDOPIAF(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x76B6C80", Offset = "0x76B6080", VA = "0x1876B6C80", Slot = "99")]
	public void MMLMFKMCNPK(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x76B2230", Offset = "0x76B1630", VA = "0x1876B2230", Slot = "100")]
	public Vector3 BHCPJLJFLBG(Vector3 FPGFMPILIAN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x76B44B0", Offset = "0x76B38B0", VA = "0x1876B44B0", Slot = "101")]
	public Vector3 FEKDHJGMJJI(Vector3 MJJIJGEDDJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x76B5490", Offset = "0x76B4890", VA = "0x1876B5490", Slot = "102")]
	public void JFELHGOGIML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x76B2030", Offset = "0x76B1430", VA = "0x1876B2030", Slot = "103")]
	public void AMIBEBEGNNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x76B6680", Offset = "0x76B5A80", VA = "0x1876B6680", Slot = "104")]
	public void LMHEOLDAMJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x76B6950", Offset = "0x76B5D50", VA = "0x1876B6950", Slot = "105")]
	public void MFPPKFIOGGP(Vector3 IIPCJAOLCGL, Vector3 JDEICCDPEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x76B6590", Offset = "0x76B5990", VA = "0x1876B6590", Slot = "106")]
	public void LLMECHIHOOJ(Vector3 MODOOLGGFMH, Vector3 JMPPLOEFJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x76B3550", Offset = "0x76B2950", VA = "0x1876B3550", Slot = "107")]
	public void DGLHGNBFKOA(Vector3 KBBOLBHAJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x76B1D90", Offset = "0x76B1190", VA = "0x1876B1D90", Slot = "108")]
	public void ADHGKABNEOE(CHDHBDHLHKI BIEBDPIGOMG, Vector3 ONIFOJGMGJC, float LIIJBIKPANP, float GCHLECDEBPI = 8f, float LADGMJOCDMA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x76B2D30", Offset = "0x76B2130", VA = "0x1876B2D30", Slot = "109")]
	public void CBHLPJNCLIG(MFDGILLPOIO FLOMCHMPOIC, Vector3 JJADDKAGGLG, float GIIMKAIGAJH = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x76B67F0", Offset = "0x76B5BF0", VA = "0x1876B67F0", Slot = "110")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void MCHDDMAIDLM(MFDGILLPOIO FLOMCHMPOIC, Vector3 CBCAIPELAJP, float AMJKNOLCIOF = 7f, float LHJIPGKFCBJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x76B8180", Offset = "0x76B7580", VA = "0x1876B8180", Slot = "111")]
	public Vector3 PLFHMGDBJLF(Vector3 HCPAOILCJCB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x76B1E50", Offset = "0x76B1250", VA = "0x1876B1E50", Slot = "112")]
	public Vector3 AEFADFHLLLF(Vector3 HCPAOILCJCB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x76B6B50", Offset = "0x76B5F50", VA = "0x1876B6B50", Slot = "113")]
	public void MLIIOPEGDCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x76B5230", Offset = "0x76B4630", VA = "0x1876B5230", Slot = "114")]
	public void IJHCNDAPDLI(EAMPMJFIPDM IBDEDNMMKKK, object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x76B50A0", Offset = "0x76B44A0", VA = "0x1876B50A0", Slot = "115")]
	public void IBFMELFFPJL(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x76B2880", Offset = "0x76B1C80", VA = "0x1876B2880", Slot = "62")]
	public void BPCKPJIFJPJ((Quaternion rot, Vector3 moments) ILJHDCDBMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x76B5EA0", Offset = "0x76B52A0", VA = "0x1876B5EA0", Slot = "116")]
	public void KPAFAJAOCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x76B3F80", Offset = "0x76B3380", VA = "0x1876B3F80", Slot = "117")]
	public void EHMNKDGDHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x76B8390", Offset = "0x76B7790", VA = "0x1876B8390", Slot = "118")]
	public void PPMKFKODDLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x76B3090", Offset = "0x76B2490", VA = "0x1876B3090", Slot = "119")]
	public bool DDLEPECEOGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x76B2390", Offset = "0x76B1790", VA = "0x1876B2390", Slot = "96")]
	public void BIGDJFKKKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x76B74F0", Offset = "0x76B68F0", VA = "0x1876B74F0", Slot = "120")]
	public void OADFMMHPIPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x76B8330", Offset = "0x76B7730", VA = "0x1876B8330", Slot = "121")]
	public void PPBAIDPEJJJ(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x76B2E30", Offset = "0x76B2230", VA = "0x1876B2E30", Slot = "122")]
	public void CDFDHFNFKHE(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x76B4880", Offset = "0x76B3C80", VA = "0x1876B4880", Slot = "123")]
	public void GKPAEPIOIOB(object CMNJCPJBHGE, bool CKPMADLDOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x76B7D70", Offset = "0x76B7170", VA = "0x1876B7D70", Slot = "124")]
	public void OPBJAAGMMIH(Vector3 NAHFOOFADAD, Quaternion FDEFNOBEGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x76B42A0", Offset = "0x76B36A0", VA = "0x1876B42A0", Slot = "125")]
	public void FCGPHNLBIID(Vector3 IIBFNIDFABP, Quaternion OEKHKEJMIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x76B4F70", Offset = "0x76B4370", VA = "0x1876B4F70", Slot = "126")]
	public bool HOCFMFENHCD(float MPACBOHCOML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x76B7F70", Offset = "0x76B7370", VA = "0x1876B7F70", Slot = "127")]
	public void PAFCIIEJBEB(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x76B2330", Offset = "0x76B1730", VA = "0x1876B2330", Slot = "128")]
	public void BHIGFJOMPMH(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x76B2E90", Offset = "0x76B2290", VA = "0x1876B2E90", Slot = "129")]
	public void CHMLNINGDIN(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x76B54E0", Offset = "0x76B48E0", VA = "0x1876B54E0", Slot = "130")]
	public void JGLMCCCILMF(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x76B2960", Offset = "0x76B1D60", VA = "0x1876B2960", Slot = "131")]
	public void BPGCMNFKCPM(Vector3 MKNFMGNFODH, ForceMode KKGJDJKIGAK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x76B3140", Offset = "0x76B2540", VA = "0x1876B3140", Slot = "132")]
	public void DFPGKIIIKOP(Vector3 MKNFMGNFODH, Vector3 CPGMOBFHDAC, ForceMode KKGJDJKIGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x76B7C10", Offset = "0x76B7010", VA = "0x1876B7C10", Slot = "133")]
	public void ONGDOCOALPF(Vector3 FLGIFKEJPMG, ForceMode KKGJDJKIGAK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x76B6BA0", Offset = "0x76B5FA0", VA = "0x1876B6BA0", Slot = "134")]
	public void MLNNFBLMKJP(Vector3 FLGIFKEJPMG, ForceMode KKGJDJKIGAK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x76B2080", Offset = "0x76B1480", VA = "0x1876B2080", Slot = "135")]
	public bool APFBDCMHMKJ(Vector3 LIDLBHGKPBN, [Out] RaycastHit OEFCPHKEKMJ, float KIECEDCFNCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x76B6B00", Offset = "0x76B5F00", VA = "0x1876B6B00", Slot = "136")]
	public void MKGHIBCBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x76B83E0", Offset = "0x76B77E0", VA = "0x1876B83E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x76B4EA0", Offset = "0x76B42A0", VA = "0x1876B4EA0")]
	private void HLLKNFFJBPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x76B6110", Offset = "0x76B5510", VA = "0x1876B6110")]
	private void LJDANDDPIKG(EAMPMJFIPDM AMMKPAGCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x76B3370", Offset = "0x76B2770", VA = "0x1876B3370")]
	private void DGJNOFKKBAK(EAMPMJFIPDM AMMKPAGCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x76B45B0", Offset = "0x76B39B0", VA = "0x1876B45B0")]
	private void FGELPOCCDGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x76B3250", Offset = "0x76B2650", VA = "0x1876B3250")]
	private void DGGBIFINAFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x76B23E0", Offset = "0x76B17E0", VA = "0x1876B23E0")]
	private void BKNABPCNMPC(EAMPMJFIPDM NFMMNJIBIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x76B25E0", Offset = "0x76B19E0", VA = "0x1876B25E0")]
	private void BLKPFNJHPFC(EAMPMJFIPDM AMMKPAGCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x76B7860", Offset = "0x76B6C60", VA = "0x1876B7860")]
	private void ODKBLHFLNKJ(EAMPMJFIPDM AMMKPAGCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x76B7AC0", Offset = "0x76B6EC0", VA = "0x1876B7AC0")]
	private void OJABLAJLLHL(JBMMKMCLEMD AMMKPAGCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x76B4A00", Offset = "0x76B3E00", VA = "0x1876B4A00", Slot = "142")]
	protected virtual void HKHEMNBHCCB(JBMMKMCLEMD EBMLJFOEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x76B5710", Offset = "0x76B4B10", VA = "0x1876B5710")]
	protected void JLFOEPOPIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x76B70B0", Offset = "0x76B64B0", VA = "0x1876B70B0")]
	protected void NJPAKDBJHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x76B3AF0", Offset = "0x76B2EF0", VA = "0x1876B3AF0")]
	private void EFPKFGAGCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x76B26B0", Offset = "0x76B1AB0", VA = "0x1876B26B0")]
	private void BMJFMCNACGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class BJLJPMMBGAM
{
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x76AEC00", Offset = "0x76AE000", VA = "0x1876AEC00")]
	public static EAMPMJFIPDM HEHMPBCCNAG(this EAMPMJFIPDM EBMLJFOEMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x76AEB60", Offset = "0x76ADF60", VA = "0x1876AEB60")]
	public static bool GGMJFPHLPKB(this EAMPMJFIPDM EBMLJFOEMMC, EAMPMJFIPDM HDOFBIJLBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x76AEA50", Offset = "0x76ADE50", VA = "0x1876AEA50")]
	public static bool DKKLGGODGHN(this EAMPMJFIPDM EBMLJFOEMMC, EAMPMJFIPDM ODBBCIGBLIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x76AECC0", Offset = "0x76AE0C0", VA = "0x1876AECC0")]
	public static JBMMKMCLEMD OGKKKFJMHIL(this EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x76AEAF0", Offset = "0x76ADEF0", VA = "0x1876AEAF0")]
	public static JDNONKLFDEO DLPMIFOGBPE(this EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KJOAPELLJFC : FLEIJAHHFJE
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x76BBDC0", Offset = "0x76BB1C0", VA = "0x1876BBDC0", Slot = "19")]
	public EAMPMJFIPDM ADFMNCLFDHL(RigidbodyEx EBMLJFOEMMC, LFGJEKNLFEG JGCOLLOOLHL, EBPOEAENCPP KCLPDCIIPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "4")]
	public OKGLDOCFPGP GLBBLFOFCID(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "5")]
	public JAIOOHLDJGA GIJNFBCFACI(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "6")]
	public JLBAOFIMFPA DABGDAIPDMM(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "7")]
	public MOCPIJFKDBC GDAMOIIDBBF(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "8")]
	public JHOKKOPKHIM AABLIJOCAIP(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "9")]
	public BEKEFNANCPN GCGAGICDLNO(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "10")]
	public FMHANGAHEAH ODDJHCKGLKI(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "11")]
	public LHFHNOBGFPC HOOHEJDACDL(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "12")]
	public CECACCLHBNP INMBMOGLDAE(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "13")]
	public AGAOEAHAKKH ONDFDNGEIJI(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90")]
	public NDODJONNKFG IINLBMBBLOH(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90")]
	public MIAENNBGOLJ EJICNKHDELM(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90")]
	public JCHCJJOHIHG NJEHHLCOCDP(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90")]
	public HDMALIPKHHC ICPFHLLLHED(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90")]
	public KJHAOHOLDGI DKJHGLHIKAG(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public KJOAPELLJFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "14")]
	private NDODJONNKFG NNGHCCNNKNL(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "15")]
	private MIAENNBGOLJ BEHMHILAPPN(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "16")]
	private JCHCJJOHIHG GJMMKCOONDM(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "17")]
	private HDMALIPKHHC PNEEGEDPFKE(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "18")]
	private KJHAOHOLDGI FJEKAIJCBDG(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(FLEIJAHHFJE), new string[] { })]
public class PCCBLOHONOC : FLEIJAHHFJE, DMLBGGHLGCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly FLEIJAHHFJE AFAFJCDHFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly FLEIJAHHFJE JEJDEADNJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private DEIPDBHMECK KJPBBFANAPK;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private FLEIJAHHFJE EOGCHCFJJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x76C1700", Offset = "0x76C0B00", VA = "0x1876C1700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x76C16B0", Offset = "0x76C0AB0", VA = "0x1876C16B0", Slot = "20")]
	public void InitReferences(PBPBPCOFCDM LAACHEAGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x76C1370", Offset = "0x76C0770", VA = "0x1876C1370", Slot = "4")]
	public OKGLDOCFPGP GLBBLFOFCID(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x76C1220", Offset = "0x76C0620", VA = "0x1876C1220", Slot = "5")]
	public JAIOOHLDJGA GIJNFBCFACI(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x76C0F90", Offset = "0x76C0390", VA = "0x1876C0F90", Slot = "6")]
	public JLBAOFIMFPA DABGDAIPDMM(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x76C1180", Offset = "0x76C0580", VA = "0x1876C1180", Slot = "7")]
	public MOCPIJFKDBC GDAMOIIDBBF(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x76C0CF0", Offset = "0x76C00F0", VA = "0x1876C0CF0", Slot = "8")]
	public JHOKKOPKHIM AABLIJOCAIP(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x76C10E0", Offset = "0x76C04E0", VA = "0x1876C10E0", Slot = "9")]
	public BEKEFNANCPN GCGAGICDLNO(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x76C1760", Offset = "0x76C0B60", VA = "0x1876C1760", Slot = "10")]
	public FMHANGAHEAH ODDJHCKGLKI(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x76C1410", Offset = "0x76C0810", VA = "0x1876C1410", Slot = "11")]
	public LHFHNOBGFPC HOOHEJDACDL(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x76C1610", Offset = "0x76C0A10", VA = "0x1876C1610", Slot = "12")]
	public CECACCLHBNP INMBMOGLDAE(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x76C1800", Offset = "0x76C0C00", VA = "0x1876C1800", Slot = "13")]
	public AGAOEAHAKKH ONDFDNGEIJI(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x76C1560", Offset = "0x76C0960", VA = "0x1876C1560")]
	public NDODJONNKFG IINLBMBBLOH(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x76C0EE0", Offset = "0x76C02E0", VA = "0x1876C0EE0")]
	public MIAENNBGOLJ EJICNKHDELM(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x76C12C0", Offset = "0x76C06C0", VA = "0x1876C12C0")]
	public JCHCJJOHIHG NJEHHLCOCDP(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x76C14B0", Offset = "0x76C08B0", VA = "0x1876C14B0")]
	public HDMALIPKHHC ICPFHLLLHED(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x76C1030", Offset = "0x76C0430", VA = "0x1876C1030")]
	public KJHAOHOLDGI DKJHGLHIKAG(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x76C0D90", Offset = "0x76C0190", VA = "0x1876C0D90", Slot = "19")]
	public EAMPMJFIPDM ADFMNCLFDHL(RigidbodyEx EBMLJFOEMMC, LFGJEKNLFEG JGCOLLOOLHL, EBPOEAENCPP KCLPDCIIPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x76C18A0", Offset = "0x76C0CA0", VA = "0x1876C18A0")]
	public PCCBLOHONOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x76C1560", Offset = "0x76C0960", VA = "0x1876C1560", Slot = "14")]
	private NDODJONNKFG NNGHCCNNKNL(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x76C0EE0", Offset = "0x76C02E0", VA = "0x1876C0EE0", Slot = "15")]
	private MIAENNBGOLJ BEHMHILAPPN(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x76C12C0", Offset = "0x76C06C0", VA = "0x1876C12C0", Slot = "16")]
	private JCHCJJOHIHG GJMMKCOONDM(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x76C14B0", Offset = "0x76C08B0", VA = "0x1876C14B0", Slot = "17")]
	private HDMALIPKHHC PNEEGEDPFKE(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x76C1030", Offset = "0x76C0430", VA = "0x1876C1030", Slot = "18")]
	private KJHAOHOLDGI FJEKAIJCBDG(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface OPPINACLEBN : OKGLDOCFPGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJNGPMHDKCP(EAMPMJFIPDM EBMLJFOEMMC);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODKJMPDFDBB(EAMPMJFIPDM EBMLJFOEMMC);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DOPBLMCBNGA(EAMPMJFIPDM NFMMNJIBIAP);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PBDFICDELKF(EAMPMJFIPDM NFMMNJIBIAP);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JCBKIENGPPL : JLBAOFIMFPA
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	GFOECDEFAOP<EAMPMJFIPDM> OFHJBKAHPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	EAMPMJFIPDM BBOBKKHCECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KOIKLBPKGFN : HDMALIPKHHC
{
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) NFLIGFICBFH(Rigidbody KFBDBJDJBIE);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface GMMOIICMLOK : MIAENNBGOLJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PhotonView PJFENDJJJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class ACFFHLLHFIF : CECACCLHBNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly JDNONKLFDEO EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode HJEKCNOGAEP;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody EFNNEKIHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x76AAEB0", Offset = "0x76AA2B0", VA = "0x1876AAEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode DMJBAPBDLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x76AB130", Offset = "0x76AA530", VA = "0x1876AB130", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x76AB0C0", Offset = "0x76AA4C0", VA = "0x1876AB0C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x76AB350", Offset = "0x76AA750", VA = "0x1876AB350")]
	public ACFFHLLHFIF(EAMPMJFIPDM EBMLJFOEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x76AB240", Offset = "0x76AA640", VA = "0x1876AB240", Slot = "6")]
	public void OCFCMPGINLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x76AAF00", Offset = "0x76AA300", VA = "0x1876AAF00", Slot = "9")]
	public void CEOFAKPPGEF(Rigidbody JKGEPDGLGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x76AB0B0", Offset = "0x76AA4B0", VA = "0x1876AB0B0", Slot = "7")]
	public void HNAGAICLHIL(bool NPEMCMBJGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x76AB0A0", Offset = "0x76AA4A0", VA = "0x1876AB0A0", Slot = "8")]
	public void ENAGIICHGOA(bool NPEMCMBJGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x76AAD50", Offset = "0x76AA150", VA = "0x1876AAD50", Slot = "10")]
	public bool APFBDCMHMKJ(Vector3 LIDLBHGKPBN, [Out] RaycastHit OEFCPHKEKMJ, float KIECEDCFNCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x76AAF80", Offset = "0x76AA380", VA = "0x1876AAF80")]
	private void EEMNCOIHMKI(bool NPEMCMBJGFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FPDCLJLGOCG : BEKEFNANCPN, IDisposable, NKAHIGEFOEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JDNONKLFDEO EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private NCPKOJCDALC GFPBHJIEOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private POJBILGPAFB KILBODCGJFJ;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public NCPKOJCDALC LNHAPLKLDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x76B0760", Offset = "0x76AFB60", VA = "0x1876B0760", Slot = "6")]
		get
		{
			return default(NCPKOJCDALC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x76B0690", Offset = "0x76AFA90", VA = "0x1876B0690", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform CPBNAGGFNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x21CD1E0", Offset = "0x21CC5E0", VA = "0x1821CD1E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<HODEOENILDN, HODEOENILDN> GEGDOIBPJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x76B08A0", Offset = "0x76AFCA0", VA = "0x1876B08A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x76B0590", Offset = "0x76AF990", VA = "0x1876B0590", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x76B0BC0", Offset = "0x76AFFC0", VA = "0x1876B0BC0")]
	public FPDCLJLGOCG(EAMPMJFIPDM EBMLJFOEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x76B0950", Offset = "0x76AFD50", VA = "0x1876B0950", Slot = "8")]
	public void OCFCMPGINLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x76B0640", Offset = "0x76AFA40", VA = "0x1876B0640", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0xD495F0", Offset = "0xD489F0", VA = "0x180D495F0", Slot = "11")]
	private void KAHLDGOIIAB(HODEOENILDN LJCAHCOMFIN, HODEOENILDN PHBLAEIFEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "12")]
	private void ECJLFADBPIL(bool GMHKIAOJLFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MDKBCDMLAPI : FLEIJAHHFJE
{
	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x76BE4D0", Offset = "0x76BD8D0", VA = "0x1876BE4D0", Slot = "4")]
	public OKGLDOCFPGP GLBBLFOFCID(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x76BE280", Offset = "0x76BD680", VA = "0x1876BE280", Slot = "5")]
	public JAIOOHLDJGA GIJNFBCFACI(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x76BDF20", Offset = "0x76BD320", VA = "0x1876BDF20", Slot = "6")]
	public JLBAOFIMFPA DABGDAIPDMM(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x76BE200", Offset = "0x76BD600", VA = "0x1876BE200", Slot = "7")]
	public MOCPIJFKDBC GDAMOIIDBBF(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x76BDB70", Offset = "0x76BCF70", VA = "0x1876BDB70", Slot = "8")]
	public JHOKKOPKHIM AABLIJOCAIP(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x76BE130", Offset = "0x76BD530", VA = "0x1876BE130", Slot = "9")]
	public BEKEFNANCPN GCGAGICDLNO(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x76BEA10", Offset = "0x76BDE10", VA = "0x1876BEA10", Slot = "10")]
	public FMHANGAHEAH ODDJHCKGLKI(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x76BE5C0", Offset = "0x76BD9C0", VA = "0x1876BE5C0", Slot = "11")]
	public LHFHNOBGFPC HOOHEJDACDL(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x76BE950", Offset = "0x76BDD50", VA = "0x1876BE950", Slot = "12")]
	public CECACCLHBNP INMBMOGLDAE(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x76BEB30", Offset = "0x76BDF30", VA = "0x1876BEB30", Slot = "13")]
	public AGAOEAHAKKH ONDFDNGEIJI(EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x76BE810", Offset = "0x76BDC10", VA = "0x1876BE810")]
	public NDODJONNKFG IINLBMBBLOH(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x76BDD90", Offset = "0x76BD190", VA = "0x1876BDD90")]
	public MIAENNBGOLJ EJICNKHDELM(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x76BE3A0", Offset = "0x76BD7A0", VA = "0x1876BE3A0")]
	public JCHCJJOHIHG NJEHHLCOCDP(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x76BE680", Offset = "0x76BDA80", VA = "0x1876BE680")]
	public HDMALIPKHHC ICPFHLLLHED(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x76BE050", Offset = "0x76BD450", VA = "0x1876BE050")]
	public KJHAOHOLDGI DKJHGLHIKAG(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x76BDC40", Offset = "0x76BD040", VA = "0x1876BDC40", Slot = "19")]
	public EAMPMJFIPDM ADFMNCLFDHL(RigidbodyEx EBMLJFOEMMC, LFGJEKNLFEG JGCOLLOOLHL, EBPOEAENCPP KCLPDCIIPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public MDKBCDMLAPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x76BE810", Offset = "0x76BDC10", VA = "0x1876BE810", Slot = "14")]
	private NDODJONNKFG NNGHCCNNKNL(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x76BDD90", Offset = "0x76BD190", VA = "0x1876BDD90", Slot = "15")]
	private MIAENNBGOLJ BEHMHILAPPN(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x76BE3A0", Offset = "0x76BD7A0", VA = "0x1876BE3A0", Slot = "16")]
	private JCHCJJOHIHG GJMMKCOONDM(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x76BE680", Offset = "0x76BDA80", VA = "0x1876BE680", Slot = "17")]
	private HDMALIPKHHC PNEEGEDPFKE(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x76BE050", Offset = "0x76BD450", VA = "0x1876BE050", Slot = "18")]
	private KJHAOHOLDGI FJEKAIJCBDG(EAMPMJFIPDM HKNABNLJGOH, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class LNOIOCCFBBA : LHFHNOBGFPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly JDNONKLFDEO EBMLJFOEMMC;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody EFNNEKIHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x76AAEB0", Offset = "0x76AA2B0", VA = "0x1876AAEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool PPIIAABHJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x76BC770", Offset = "0x76BBB70", VA = "0x1876BC770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool HIBADHJGNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x76B1390", Offset = "0x76B0790", VA = "0x1876B1390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private EAMPMJFIPDM HOBMCFDJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x76BCDE0", Offset = "0x76BC1E0", VA = "0x1876BCDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x76AB350", Offset = "0x76AA750", VA = "0x1876AB350")]
	public LNOIOCCFBBA(EAMPMJFIPDM EBMLJFOEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x76BC130", Offset = "0x76BB530", VA = "0x1876BC130", Slot = "4")]
	public void BPGCMNFKCPM(Vector3 MKNFMGNFODH, ForceMode KKGJDJKIGAK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x76BC7C0", Offset = "0x76BBBC0", VA = "0x1876BC7C0")]
	private void KMLJIGLHIIN(Vector3 MKNFMGNFODH, ForceMode KKGJDJKIGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x76BC290", Offset = "0x76BB690", VA = "0x1876BC290", Slot = "5")]
	public void DFPGKIIIKOP(Vector3 MKNFMGNFODH, Vector3 CPGMOBFHDAC, ForceMode KKGJDJKIGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x76BCC80", Offset = "0x76BC080", VA = "0x1876BCC80", Slot = "6")]
	public void ONGDOCOALPF(Vector3 FLGIFKEJPMG, ForceMode KKGJDJKIGAK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x76BC510", Offset = "0x76BB910", VA = "0x1876BC510")]
	private void EKNLCCGLOLA(Vector3 FLGIFKEJPMG, ForceMode KKGJDJKIGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x76BCA20", Offset = "0x76BBE20", VA = "0x1876BCA20", Slot = "7")]
	public void MLNNFBLMKJP(Vector3 FLGIFKEJPMG, ForceMode KKGJDJKIGAK = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class EBOPMFMPHNL : AGAOEAHAKKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly JDNONKLFDEO EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool EBGCDIADLNI;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool HBECIGFHCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x96F330", Offset = "0x96E730", VA = "0x18096F330", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x76AF5F0", Offset = "0x76AE9F0", VA = "0x1876AF5F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x76AB350", Offset = "0x76AA750", VA = "0x1876AB350")]
	public EBOPMFMPHNL(EAMPMJFIPDM EBMLJFOEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x76AF550", Offset = "0x76AE950", VA = "0x1876AF550", Slot = "6")]
	public void CEOFAKPPGEF(Rigidbody JKGEPDGLGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x76AF580", Offset = "0x76AE980", VA = "0x1876AF580", Slot = "7")]
	public void IIFBFPMNKMD(Rigidbody JKGEPDGLGMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class ODLGINBEBEN : OPPINACLEBN, OKGLDOCFPGP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly EAMPMJFIPDM EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<EAMPMJFIPDM> BJLHBCBIKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EAMPMJFIPDM NIMLNKDMKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EAMPMJFIPDM AMMKPAGCALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform ILHEOKHHBJJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform DCIPDEOFAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x76C0B20", Offset = "0x76BFF20", VA = "0x1876C0B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public EAMPMJFIPDM HOBMCFDJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF20", Offset = "0x8CA320", VA = "0x1808CAF20", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x76C0340", Offset = "0x76BF740", VA = "0x1876C0340", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public EAMPMJFIPDM FFIKGEIEAOE
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF00", Offset = "0x8CA300", VA = "0x1808CAF00", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<EAMPMJFIPDM> FBKBEPCCCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8CAEE0", Offset = "0x8CA2E0", VA = "0x1808CAEE0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event NNNLLNDCCPA KFLEHKABKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x76BF660", Offset = "0x76BEA60", VA = "0x1876BF660", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x76BF090", Offset = "0x76BE490", VA = "0x1876BF090", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event NNNLLNDCCPA CIMNDIFFJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x76C0160", Offset = "0x76BF560", VA = "0x1876C0160", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x76BEFF0", Offset = "0x76BE3F0", VA = "0x1876BEFF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event BLIFDFFFFCN NGKAACAMJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x76BF3A0", Offset = "0x76BE7A0", VA = "0x1876BF3A0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x76C0A80", Offset = "0x76BFE80", VA = "0x1876C0A80", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action APDECBJKDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x76BEF50", Offset = "0x76BE350", VA = "0x1876BEF50", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x76C03F0", Offset = "0x76BF7F0", VA = "0x1876C03F0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action LAPFHJMHJMI
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x76BF580", Offset = "0x76BE980", VA = "0x1876BF580", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x76BF4E0", Offset = "0x76BE8E0", VA = "0x1876BF4E0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<EAMPMJFIPDM> EKHHGKGOKNI
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x76BF8E0", Offset = "0x76BECE0", VA = "0x1876BF8E0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x76C0490", Offset = "0x76BF890", VA = "0x1876C0490", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<EAMPMJFIPDM> KKLILFNLOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x76BF700", Offset = "0x76BEB00", VA = "0x1876BF700", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x76C0750", Offset = "0x76BFB50", VA = "0x1876C0750", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action APADEALJFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x76BF990", Offset = "0x76BED90", VA = "0x1876BF990", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x76C0350", Offset = "0x76BF750", VA = "0x1876C0350", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<EAMPMJFIPDM> NDEHEEIHENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x76C0B80", Offset = "0x76BFF80", VA = "0x1876C0B80", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x76C0540", Offset = "0x76BF940", VA = "0x1876C0540", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x76C0C30", Offset = "0x76C0030", VA = "0x1876C0C30")]
	public ODLGINBEBEN(EAMPMJFIPDM EBMLJFOEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x76BF440", Offset = "0x76BE840", VA = "0x1876BF440", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x76BFB40", Offset = "0x76BEF40", VA = "0x1876BFB40", Slot = "30")]
	public void KAPGKFEMBMB(EAMPMJFIPDM NBJNONHAKJK, bool JAMKBEGAKKK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x76BF130", Offset = "0x76BE530", VA = "0x1876BF130", Slot = "6")]
	public void DOPBLMCBNGA(EAMPMJFIPDM NFMMNJIBIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x76C0800", Offset = "0x76BFC00", VA = "0x1876C0800", Slot = "7")]
	public void PBDFICDELKF(EAMPMJFIPDM NFMMNJIBIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x76BFA30", Offset = "0x76BEE30", VA = "0x1876BFA30", Slot = "4")]
	public void JJNGPMHDKCP(EAMPMJFIPDM EBMLJFOEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x76C06B0", Offset = "0x76BFAB0", VA = "0x1876C06B0", Slot = "5")]
	public void ODKJMPDFDBB(EAMPMJFIPDM EBMLJFOEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x76C00C0", Offset = "0x76BF4C0", VA = "0x1876C00C0")]
	private void KGHINHONDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x76BF620", Offset = "0x76BEA20", VA = "0x1876BF620")]
	private void GLPDNACGFDN(EAMPMJFIPDM NFMMNJIBIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x76C0200", Offset = "0x76BF600", VA = "0x1876C0200")]
	private void KLIBAHDEHMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x76BF7B0", Offset = "0x76BEBB0", VA = "0x1876BF7B0")]
	private void IIDFHLECKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x76BEE20", Offset = "0x76BE220", VA = "0x1876BEE20")]
	private void AIHODJGGAMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x76C05F0", Offset = "0x76BF9F0", VA = "0x1876C05F0")]
	[CompilerGenerated]
	private object NMOFBOHFKND()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class BJOBEDDHGID
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x76AED10", Offset = "0x76AE110", VA = "0x1876AED10")]
	public static OPPINACLEBN DPGHFLOOKGB(this EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class FEPGKHBBCKB : JCBKIENGPPL, JLBAOFIMFPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly JDNONKLFDEO EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly GFOECDEFAOP<EAMPMJFIPDM> BJOFALENNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool DHGJLNNKJGN;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public GFOECDEFAOP<EAMPMJFIPDM> OFHJBKAHPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 EJOMKAGJDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x76AFB40", Offset = "0x76AEF40", VA = "0x1876AFB40", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 LNMMMMLPDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x76AF700", Offset = "0x76AEB00", VA = "0x1876AF700", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 KIAHBPMMAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x76AFA60", Offset = "0x76AEE60", VA = "0x1876AFA60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public EAMPMJFIPDM BBOBKKHCECK
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x76AFF70", Offset = "0x76AF370", VA = "0x1876AFF70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x76B03C0", Offset = "0x76AF7C0", VA = "0x1876B03C0")]
	public FEPGKHBBCKB(EAMPMJFIPDM EBMLJFOEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x76AFF00", Offset = "0x76AF300", VA = "0x1876AFF00", Slot = "8")]
	public void LIOFBCAACAC(EAMPMJFIPDM AMMKPAGCALK, object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x76AFA00", Offset = "0x76AEE00", VA = "0x1876AFA00", Slot = "9")]
	public void IGAFJGFJOCF(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x76B0020", Offset = "0x76AF420", VA = "0x1876B0020")]
	private Vector3 MOLGEODEGFF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x76AFB70", Offset = "0x76AEF70", VA = "0x1876AFB70")]
	private void LAPGDHGHKMP(EAMPMJFIPDM OIIOEOGJJCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class IILNFFPCNEI
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x76B1C70", Offset = "0x76B1070", VA = "0x1876B1C70")]
	public static JCBKIENGPPL HHMGKPGIGFG(this EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class ADHJIJLONOA : KOIKLBPKGFN, HDMALIPKHHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly JDNONKLFDEO EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 EDDMEOFJKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 JEBAPEFGHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float LDBELGFFKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float JAMAFNFFOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 FGOIBMEBPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? FGCLICEBIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? EGPIJFFLEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool DFFFHFNJJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool MDGMPMGABAJ;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 CEDOOBMGJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1153700", Offset = "0x1152B00", VA = "0x181153700", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x76AB3E0", Offset = "0x76AA7E0", VA = "0x1876AB3E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 BFDJIOFJCDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x76ABA20", Offset = "0x76AAE20", VA = "0x1876ABA20", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float EOKGHAGPAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x933CE0", Offset = "0x9330E0", VA = "0x180933CE0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x76AD950", Offset = "0x76ACD50", VA = "0x1876AD950")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float HAEFLDKLGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x933CA0", Offset = "0x9330A0", VA = "0x180933CA0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x76AB7F0", Offset = "0x76AABF0", VA = "0x1876AB7F0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 PCPJCDMIJKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x76ABD70", Offset = "0x76AB170", VA = "0x1876ABD70", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion GFOFBGIDMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x76ABB10", Offset = "0x76AAF10", VA = "0x1876ABB10", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody EFNNEKIHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x76AB490", Offset = "0x76AA890", VA = "0x1876AB490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event NNNLLNDCCPA OPCKNAFPGKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x76AC370", Offset = "0x76AB770", VA = "0x1876AC370", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x76AC5C0", Offset = "0x76AB9C0", VA = "0x1876AC5C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x76ADC00", Offset = "0x76AD000", VA = "0x1876ADC00")]
	public ADHJIJLONOA(EAMPMJFIPDM EBMLJFOEMMC, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x76AC410", Offset = "0x76AB810", VA = "0x1876AC410", Slot = "17")]
	public void KPAFAJAOCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x76ABC90", Offset = "0x76AB090", VA = "0x1876ABC90", Slot = "16")]
	public void EHMNKDGDHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x76AB710", Offset = "0x76AAB10", VA = "0x1876AB710", Slot = "19")]
	public void CEOFAKPPGEF(Rigidbody JKGEPDGLGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x76ABF00", Offset = "0x76AB300", VA = "0x1876ABF00", Slot = "20")]
	public void IIFBFPMNKMD(Rigidbody JKGEPDGLGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x76ADA60", Offset = "0x76ACE60", VA = "0x1876ADA60", Slot = "18")]
	public void PPMKFKODDLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x76AC660", Offset = "0x76ABA60", VA = "0x1876AC660", Slot = "21")]
	public void MKGHIBCBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x76AB3E0", Offset = "0x76AA7E0", VA = "0x1876AB3E0")]
	private void AKDGEABIFPK(Vector3 HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x76AC280", Offset = "0x76AB680", VA = "0x1876AC280")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 JPOEBNIFHCL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x76AD950", Offset = "0x76ACD50", VA = "0x1876AD950")]
	private void OLNCEDGFKOC(float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x76AB7F0", Offset = "0x76AABF0", VA = "0x1876AB7F0")]
	private void CPAGMOAOANL(float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x76AC0E0", Offset = "0x76AB4E0", VA = "0x1876AC0E0")]
	private Vector3 JNIGKCDDMLH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x76AB4E0", Offset = "0x76AA8E0", VA = "0x1876AB4E0", Slot = "15")]
	public void BPCKPJIFJPJ((Quaternion rot, Vector3 moments) ILJHDCDBMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x76AB8A0", Offset = "0x76AACA0", VA = "0x1876AB8A0")]
	private Quaternion DBELGCOPMLN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x76ACAE0", Offset = "0x76ABEE0", VA = "0x1876ACAE0")]
	public void NFLIGFICBFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x76ACBB0", Offset = "0x76ABFB0", VA = "0x1876ACBB0", Slot = "4")]
	public (float, Vector3) NFLIGFICBFH(Rigidbody KFBDBJDJBIE)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class KDBIJPLEJBF
{
	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x76B8510", Offset = "0x76B7910", VA = "0x1876B8510")]
	public static KOIKLBPKGFN DJOMHPBAGHK(this EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class FPKFDOAAIJH : JCHCJJOHIHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly JDNONKLFDEO EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly MFGPGCPLCOD LGDPKGFAJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly KBLCCMMKFLK ACMAJJOJKEO;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool PDEOPPHCFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x12FA090", Offset = "0x12F9490", VA = "0x1812FA090", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public KBLCCMMKFLK ODMFPAOABLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x968260", Offset = "0x967660", VA = "0x180968260", Slot = "11")]
		get
		{
			return default(KBLCCMMKFLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x76B1260", Offset = "0x76B0660", VA = "0x1876B1260")]
	public FPKFDOAAIJH(EAMPMJFIPDM EBMLJFOEMMC, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x76B1160", Offset = "0x76B0560", VA = "0x1876B1160", Slot = "4")]
	public void OCFCMPGINLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x76B0F90", Offset = "0x76B0390", VA = "0x1876B0F90")]
	private bool KCMJPMILHFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x76B1230", Offset = "0x76B0630", VA = "0x1876B1230", Slot = "5")]
	public void OJLIOBLAOFA(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x76B0F20", Offset = "0x76B0320", VA = "0x1876B0F20", Slot = "6")]
	public void INLFCHNPJEC(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x76B1030", Offset = "0x76B0430", VA = "0x1876B1030", Slot = "9")]
	public void NDLPOJHBENN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x76B0DD0", Offset = "0x76B01D0", VA = "0x1876B0DD0")]
	private void DBHIIJCHJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x76B0C50", Offset = "0x76B0050", VA = "0x1876B0C50")]
	private void CCEJEEJPHNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x76B0F50", Offset = "0x76B0350", VA = "0x1876B0F50", Slot = "8")]
	public void IPKEKAFOHBP(EAMPMJFIPDM EBMLJFOEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x76B0EE0", Offset = "0x76B02E0", VA = "0x1876B0EE0", Slot = "7")]
	public void GBGAAPHGMGA(EAMPMJFIPDM EBMLJFOEMMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class DHLOFNBMALD : FMHANGAHEAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly JDNONKLFDEO EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly MFGPGCPLCOD PJKNAHHLPBJ;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool PPIIAABHJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x76AF220", Offset = "0x76AE620", VA = "0x1876AF220", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event NNNLLNDCCPA BMKCHOEGHLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x76AF370", Offset = "0x76AE770", VA = "0x1876AF370", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x76AF2D0", Offset = "0x76AE6D0", VA = "0x1876AF2D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x76AF460", Offset = "0x76AE860", VA = "0x1876AF460")]
	public DHLOFNBMALD(EAMPMJFIPDM EBMLJFOEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x76AF450", Offset = "0x76AE850", VA = "0x1876AF450", Slot = "7")]
	public void PPBAIDPEJJJ(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x76AF050", Offset = "0x76AE450", VA = "0x1876AF050", Slot = "8")]
	public void CDFDHFNFKHE(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x76AF0E0", Offset = "0x76AE4E0", VA = "0x1876AF0E0", Slot = "9")]
	public void GKPAEPIOIOB(object CMNJCPJBHGE, bool CKPMADLDOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x76AF410", Offset = "0x76AE810", VA = "0x1876AF410", Slot = "12")]
	public void NDIMJBCPAPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x76AF060", Offset = "0x76AE460", VA = "0x1876AF060", Slot = "10")]
	public void CEOFAKPPGEF(Rigidbody LAANDEEMEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x76AF1F0", Offset = "0x76AE5F0", VA = "0x1876AF1F0", Slot = "11")]
	public void IIFBFPMNKMD(Rigidbody JKGEPDGLGMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class BIGOCPFADMB : GMMOIICMLOK, MIAENNBGOLJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly JDNONKLFDEO EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PhotonView IAENBOLPMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool JOPMHCDBLFP;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView PJFENDJJJJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool GAJIHPBLAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x76ADFD0", Offset = "0x76AD3D0", VA = "0x1876ADFD0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool JKNAGOPJNNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA02880", Offset = "0xA01C80", VA = "0x180A02880", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event NNNLLNDCCPA LPPJOENHEKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x76ADFF0", Offset = "0x76AD3F0", VA = "0x1876ADFF0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x76AE5C0", Offset = "0x76AD9C0", VA = "0x1876AE5C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x76AE900", Offset = "0x76ADD00", VA = "0x1876AE900")]
	public BIGOCPFADMB(EAMPMJFIPDM EBMLJFOEMMC, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x76AE660", Offset = "0x76ADA60", VA = "0x1876AE660", Slot = "9")]
	public void OCFCMPGINLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x76ADED0", Offset = "0x76AD2D0", VA = "0x1876ADED0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x76ADD60", Offset = "0x76AD160", VA = "0x1876ADD60", Slot = "10")]
	public void BLKPFNJHPFC(EAMPMJFIPDM AMMKPAGCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x76AE790", Offset = "0x76ADB90", VA = "0x1876AE790", Slot = "11")]
	public void ODKBLHFLNKJ(EAMPMJFIPDM AMMKPAGCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x76AE090", Offset = "0x76AD490", VA = "0x1876AE090")]
	private void KDOGMPCPHPJ(PhotonView NGLJKMMFLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x76AE470", Offset = "0x76AD870", VA = "0x1876AE470")]
	private void MIPBDKBKLGE(JBMMKMCLEMD MJDGOKIAGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x76AE200", Offset = "0x76AD600", VA = "0x1876AE200")]
	private void LOHCCFPPEGO(PhotonView EHKCNJFALOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class PKFKNLGBEGH
{
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x76C1950", Offset = "0x76C0D50", VA = "0x1876C1950")]
	public static GMMOIICMLOK KHDFBKMDMJD(this EAMPMJFIPDM HKNABNLJGOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class MEKBBKMFHHC : KJHAOHOLDGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly JDNONKLFDEO EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints OEKAOCMFPIA;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool PBGGBENBKEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x96F830", Offset = "0x96EC30", VA = "0x18096F830", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x96FD30", Offset = "0x96F130", VA = "0x18096FD30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool DBDLMJFABHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x96F940", Offset = "0x96ED40", VA = "0x18096F940", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x96FE30", Offset = "0x96F230", VA = "0x18096FE30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints HOIEFHNEJFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8C93C0", Offset = "0x8C87C0", VA = "0x1808C93C0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x76BEC50", Offset = "0x76BE050", VA = "0x1876BEC50", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x76BED80", Offset = "0x76BE180", VA = "0x1876BED80")]
	public MEKBBKMFHHC(EAMPMJFIPDM EBMLJFOEMMC, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x76BEBF0", Offset = "0x76BDFF0", VA = "0x1876BEBF0", Slot = "9")]
	public void CEOFAKPPGEF(Rigidbody JKGEPDGLGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x76BEC20", Offset = "0x76BE020", VA = "0x1876BEC20", Slot = "10")]
	public void IIFBFPMNKMD(Rigidbody JKGEPDGLGMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KKFJIFKIPLE : MOCPIJFKDBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly EAMPMJFIPDM EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float NOPCKONEOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float AICNDFBFCHA;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float ILOEMAEECMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xB05EB0", Offset = "0xB052B0", VA = "0x180B05EB0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x76BBEB0", Offset = "0x76BB2B0", VA = "0x1876BBEB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float CFNILIBNGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x97B440", Offset = "0x97A840", VA = "0x18097B440", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x76BC020", Offset = "0x76BB420", VA = "0x1876BC020", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x76BC0F0", Offset = "0x76BB4F0", VA = "0x1876BC0F0")]
	public KKFJIFKIPLE(EAMPMJFIPDM EBMLJFOEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x76BBE60", Offset = "0x76BB260", VA = "0x1876BBE60", Slot = "8")]
	public void CEOFAKPPGEF(Rigidbody JKGEPDGLGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x76BBF80", Offset = "0x76BB380", VA = "0x1876BBF80", Slot = "9")]
	public void IIFBFPMNKMD(Rigidbody JKGEPDGLGMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class LNPHCHPFHMG : JHOKKOPKHIM
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly GKOKEEMOOFG OOLNEIIMDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly JDNONKLFDEO EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool IIDFAIMCIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool KEJBMIPPOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int KEOJDPANDED;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody EFNNEKIHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x76AB490", Offset = "0x76AA890", VA = "0x1876AB490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool JFAEAJDNHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x76BD8D0", Offset = "0x76BCCD0", VA = "0x1876BD8D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private EAMPMJFIPDM HOBMCFDJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x76BD8F0", Offset = "0x76BCCF0", VA = "0x1876BD8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool HIBADHJGNMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x76BD230", Offset = "0x76BC630", VA = "0x1876BD230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event NNNLLNDCCPA CEFJFMIMOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x76BD460", Offset = "0x76BC860", VA = "0x1876BD460", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x76BD3C0", Offset = "0x76BC7C0", VA = "0x1876BD3C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x76BD9D0", Offset = "0x76BCDD0", VA = "0x1876BD9D0")]
	public LNPHCHPFHMG(EAMPMJFIPDM EBMLJFOEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x76BD840", Offset = "0x76BCC40", VA = "0x1876BD840", Slot = "6")]
	public void OCFCMPGINLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x76BD3B0", Offset = "0x76BC7B0", VA = "0x1876BD3B0", Slot = "8")]
	public void HEGGPJKKGNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x76BD0E0", Offset = "0x76BC4E0", VA = "0x1876BD0E0", Slot = "7")]
	public bool DDLEPECEOGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x76BCE40", Offset = "0x76BC240", VA = "0x1876BCE40", Slot = "9")]
	public void BIGDJFKKKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x76BD7A0", Offset = "0x76BCBA0", VA = "0x1876BD7A0", Slot = "13")]
	public void OADFMMHPIPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x76BD290", Offset = "0x76BC690", VA = "0x1876BD290", Slot = "12")]
	public void EHEKJALHEAN(bool GGECBBHOKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x76BD070", Offset = "0x76BC470", VA = "0x1876BD070", Slot = "10")]
	public bool CNPIHLDFBJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x76BD6E0", Offset = "0x76BCAE0", VA = "0x1876BD6E0", Slot = "11")]
	public bool LNBLEKEAFNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x76BD500", Offset = "0x76BC900", VA = "0x1876BD500")]
	private bool KLMIGEKLPED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x76BCEE0", Offset = "0x76BC2E0", VA = "0x1876BCEE0")]
	private void CBELAEPFOGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class GOKDNGIPHMJ : NDODJONNKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly JDNONKLFDEO EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MFGPGCPLCOD AKFFGMDFBIL;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody EFNNEKIHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8C7990", Offset = "0x8C6D90", VA = "0x1808C7990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool HIBADHJGNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x76B1390", Offset = "0x76B0790", VA = "0x1876B1390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool BLEGLEABHOH
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x12FA090", Offset = "0x12F9490", VA = "0x1812FA090", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x76B1B60", Offset = "0x76B0F60", VA = "0x1876B1B60")]
	public GOKDNGIPHMJ(EAMPMJFIPDM EBMLJFOEMMC, [In] LFGJEKNLFEG JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x76B1AC0", Offset = "0x76B0EC0", VA = "0x1876B1AC0", Slot = "5")]
	public void OCFCMPGINLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x76B1360", Offset = "0x76B0760", VA = "0x1876B1360", Slot = "7")]
	public void CHMLNINGDIN(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x76B1720", Offset = "0x76B0B20", VA = "0x1876B1720", Slot = "8")]
	public void JGLMCCCILMF(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x76B13F0", Offset = "0x76B07F0", VA = "0x1876B13F0", Slot = "9")]
	public void GAEIPGJCMNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x76B1750", Offset = "0x76B0B50", VA = "0x1876B1750", Slot = "10")]
	public void MBADIOCJOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x76B1940", Offset = "0x76B0D40", VA = "0x1876B1940", Slot = "11")]
	public void OBPHMMDLADE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class KIAAPMMPEGH : JAIOOHLDJGA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly JDNONKLFDEO EBMLJFOEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly MFGPGCPLCOD NNKKPOAPIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float GCLKEGNCDBE;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public GKJILOLAJBC ACBBEGKAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DD0", Offset = "0x8C71D0", VA = "0x1808C7DD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public EFFPCFBOJKN FEMJDGKAHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C80", Offset = "0x8C8080", VA = "0x1808C8C80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 KIAHBPMMAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x76BA290", Offset = "0x76B9690", VA = "0x1876BA290", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x76BA4E0", Offset = "0x76B98E0", VA = "0x1876BA4E0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 JMPOGBANHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x76BA760", Offset = "0x76B9B60", VA = "0x1876BA760", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x76BBA10", Offset = "0x76BAE10", VA = "0x1876BBA10", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 HCAJPFEACIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x76BA5A0", Offset = "0x76B99A0", VA = "0x1876BA5A0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x76BB950", Offset = "0x76BAD50", VA = "0x1876BB950", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 JLENKFHPDOO
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x76BB790", Offset = "0x76BAB90", VA = "0x1876BB790", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x76BB920", Offset = "0x76BAD20", VA = "0x1876BB920", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float KCCMLPPMEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xC1C800", Offset = "0xC1BC00", VA = "0x180C1C800", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x76BA180", Offset = "0x76B9580", VA = "0x1876BA180", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool NGNHIINCLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1C63C20", Offset = "0x1C63020", VA = "0x181C63C20", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private LHFHNOBGFPC OABGGMGGNAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6E11B30", Offset = "0x6E10F30", VA = "0x186E11B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool JFAEAJDNHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x76BBA40", Offset = "0x76BAE40", VA = "0x1876BBA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x76BBCD0", Offset = "0x76BB0D0", VA = "0x1876BBCD0")]
	public KIAAPMMPEGH(EAMPMJFIPDM EBMLJFOEMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x76BA440", Offset = "0x76B9840", VA = "0x1876BA440", Slot = "19")]
	public void OCFCMPGINLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x76B94C0", Offset = "0x76B88C0", VA = "0x1876B94C0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x76B91F0", Offset = "0x76B85F0", VA = "0x1876B91F0", Slot = "28")]
	public void CEOFAKPPGEF(Rigidbody JKGEPDGLGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x10FF400", Offset = "0x10FE800", VA = "0x1810FF400", Slot = "20")]
	public void MJGMGBCHMJF(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x10FE2A0", Offset = "0x10FD6A0", VA = "0x1810FE2A0", Slot = "30")]
	public void JOCLFILHMAD(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x76B8D90", Offset = "0x76B8190", VA = "0x1876B8D90", Slot = "35")]
	public Vector3 BHCPJLJFLBG(Vector3 FPGFMPILIAN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x76B9520", Offset = "0x76B8920", VA = "0x1876B9520", Slot = "34")]
	public Vector3 FEKDHJGMJJI(Vector3 MJJIJGEDDJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x76BA440", Offset = "0x76B9840", VA = "0x1876BA440", Slot = "27")]
	public void JFELHGOGIML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x76B8C80", Offset = "0x76B8080", VA = "0x1876B8C80", Slot = "25")]
	public void AMIBEBEGNNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x76BA940", Offset = "0x76B9D40", VA = "0x1876BA940", Slot = "24")]
	public void LMHEOLDAMJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x76BB3C0", Offset = "0x76BA7C0", VA = "0x1876BB3C0", Slot = "33")]
	public void MFPPKFIOGGP(Vector3 IIPCJAOLCGL, Vector3 JDEICCDPEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x76BA8E0", Offset = "0x76B9CE0", VA = "0x1876BA8E0", Slot = "32")]
	public void LLMECHIHOOJ(Vector3 MODOOLGGFMH, Vector3 JMPPLOEFJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x76B9320", Offset = "0x76B8720", VA = "0x1876B9320", Slot = "31")]
	public void DGLHGNBFKOA(Vector3 KBBOLBHAJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x76B85D0", Offset = "0x76B79D0", VA = "0x1876B85D0", Slot = "22")]
	public void ADHGKABNEOE(CHDHBDHLHKI BIEBDPIGOMG, Vector3 ONIFOJGMGJC, float LIIJBIKPANP, float GCHLECDEBPI = 8f, float LADGMJOCDMA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x76B8F70", Offset = "0x76B8370", VA = "0x1876B8F70", Slot = "21")]
	public void CBHLPJNCLIG(MFDGILLPOIO FLOMCHMPOIC, Vector3 JJADDKAGGLG, float GIIMKAIGAJH = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x76BA9A0", Offset = "0x76B9DA0", VA = "0x1876BA9A0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void MCHDDMAIDLM(MFDGILLPOIO FLOMCHMPOIC, Vector3 CBCAIPELAJP, float AMJKNOLCIOF = 7f, float LHJIPGKFCBJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x1238A30", Offset = "0x1237E30", VA = "0x181238A30")]
	private static void MJCKCEDKJAI(Vector3 KLNNEIDEPKF, Vector3 ADDIIGBEIBA, [Out] Vector3 NKBILJIPAFC, [Out] Vector3 KGLHOBDOHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x76BBA60", Offset = "0x76BAE60", VA = "0x1876BBA60", Slot = "29")]
	public Vector3 PLFHMGDBJLF(Vector3 KLNNEIDEPKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x76BB600", Offset = "0x76BAA00", VA = "0x1876BB600", Slot = "26")]
	public void MLIIOPEGDCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x76BA180", Offset = "0x76B9580", VA = "0x1876BA180")]
	private void HKNFMFAJJMH(float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x76B9B60", Offset = "0x76B8F60", VA = "0x1876B9B60")]
	private void GLLCBIHGGDN(Vector3 JJADDKAGGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x76B8B00", Offset = "0x76B7F00", VA = "0x1876B8B00")]
	private Vector3 AKONHIKOMCC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x76B96E0", Offset = "0x76B8AE0", VA = "0x1876B96E0")]
	private void GKDDFGKFJLK(Vector3 MJJIJGEDDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x76BBB40", Offset = "0x76BAF40", VA = "0x1876BBB40")]
	private Vector3 PPMEFKCFOJA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x76B9D00", Offset = "0x76B9100", VA = "0x1876B9D00")]
	private void GNIFPHFPHBF(Vector3 HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x76BAE20", Offset = "0x76BA220", VA = "0x1876BAE20")]
	private void MFMPHFIOHPG(Vector3 MJJIJGEDDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x76B8CE0", Offset = "0x76B80E0", VA = "0x1876B8CE0")]
	private void APMAIOBGCIM()
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
