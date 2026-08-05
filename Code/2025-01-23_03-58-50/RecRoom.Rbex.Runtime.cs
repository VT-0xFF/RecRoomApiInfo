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
	public class LogRegistrationIndex : GEPCMJPGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7627120", Offset = "0x7625920", VA = "0x187627120", Slot = "4")]
		public override void CCEDGNHHKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1A468A0", Offset = "0x1A450A0", VA = "0x181A468A0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x762E5D0", Offset = "0x762CDD0", VA = "0x18762E5D0")]
		private void HOKDCPPBEII(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x762E8D0", Offset = "0x762D0D0", VA = "0x18762E8D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x762E930", Offset = "0x762D130", VA = "0x18762E930")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, LDJJPBBNOHE, DLKJMFLDODE
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly FICDJCDJOAA DKJNDEJBHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool PMONCDGOLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private CLKDHEIJDPM ABHFKNDHMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[AMEMCNMOGMB(CPHBAPBBNNI.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[AMEMCNMOGMB(CPHBAPBBNNI.SelfAndParent, true, false, false)]
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
		private NEDCKNNIBBL physicsInterpolation;

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
		private Transform IKKMKFKIKKJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal CLKDHEIJDPM FNMDAPOIJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7629BF0", Offset = "0x76283F0", VA = "0x187629BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private CLKDHEIJDPM EJKIIGJLOJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int DKOJDBHPCKH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x762BAE0", Offset = "0x762A2E0", VA = "0x18762BAE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx KBIGLNIJJCB
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x762BE40", Offset = "0x762A640", VA = "0x18762BE40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx JJAKCGIGEEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x762BD80", Offset = "0x762A580", VA = "0x18762BD80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx NCCLECGLDAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x762CA40", Offset = "0x762B240", VA = "0x18762CA40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x762DF40", Offset = "0x762C740", VA = "0x18762DF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DALNJCHFIBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x75FA0D0", Offset = "0x75F88D0", VA = "0x1875FA0D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x75F9860", Offset = "0x75F8060", VA = "0x1875F9860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform NBEDBEKEEBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xE6A550", Offset = "0xE68D50", VA = "0x180E6A550", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform CDCCIGLIENM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xE6A550", Offset = "0xE68D50", VA = "0x180E6A550", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform KANCOIDCOHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xE6A550", Offset = "0xE68D50", VA = "0x180E6A550", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public FMLELDCHGMI FEGAPJIGNIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x762BB40", Offset = "0x762A340", VA = "0x18762BB40")]
			get
			{
				return default(FMLELDCHGMI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x762D6F0", Offset = "0x762BEF0", VA = "0x18762D6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool FCLMMMCPFMI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x762C150", Offset = "0x762A950", VA = "0x18762C150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool KFLDOLPOEJE
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x762BC60", Offset = "0x762A460", VA = "0x18762BC60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JBNIKIOLDLF KNCLLFKNBCG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x762C090", Offset = "0x762A890", VA = "0x18762C090")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x762D8B0", Offset = "0x762C0B0", VA = "0x18762D8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MBMIBMKAFBA OCKFMKMEPGD
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x762C030", Offset = "0x762A830", VA = "0x18762C030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x762D840", Offset = "0x762C040", VA = "0x18762D840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JOJNGDGIGFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x762BF80", Offset = "0x762A780", VA = "0x18762BF80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody HIPNKAOEIMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x762BFE0", Offset = "0x762A7E0", VA = "0x18762BFE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool OIDKFEONKAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x762BCC0", Offset = "0x762A4C0", VA = "0x18762BCC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x762D760", Offset = "0x762BF60", VA = "0x18762D760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PGPBGBKGLBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x72D3620", Offset = "0x72D1E20", VA = "0x1872D3620", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float KKCIEOHEGMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x762C9E0", Offset = "0x762B1E0", VA = "0x18762C9E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float FBJKNDPHEDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x762C980", Offset = "0x762B180", VA = "0x18762C980")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x762DED0", Offset = "0x762C6D0", VA = "0x18762DED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float IFDDAPCJLNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x762C3B0", Offset = "0x762ABB0", VA = "0x18762C3B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x762DB50", Offset = "0x762C350", VA = "0x18762DB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float GEIDIHCKBLF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x762C1B0", Offset = "0x762A9B0", VA = "0x18762C1B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x762D920", Offset = "0x762C120", VA = "0x18762D920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool GFPFECNLHAH
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x762CF90", Offset = "0x762B790", VA = "0x18762CF90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x762E480", Offset = "0x762CC80", VA = "0x18762E480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 OMPMONJIIPB
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x762C760", Offset = "0x762AF60", VA = "0x18762C760")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x762DCA0", Offset = "0x762C4A0", VA = "0x18762DCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 LCMDAFJDAHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x762D0D0", Offset = "0x762B8D0", VA = "0x18762D0D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode NAGMFKDEFCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x762C2F0", Offset = "0x762AAF0", VA = "0x18762C2F0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x762DA70", Offset = "0x762C270", VA = "0x18762DA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float MGBPLPCNCCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x762BD20", Offset = "0x762A520", VA = "0x18762BD20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x762D7D0", Offset = "0x762BFD0", VA = "0x18762D7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints LFOBAMAPEEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x762C350", Offset = "0x762AB50", VA = "0x18762C350")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x762DAE0", Offset = "0x762C2E0", VA = "0x18762DAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 EADBIBMBGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x762CB00", Offset = "0x762B300", VA = "0x18762CB00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 JAECGHDIHKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x762CB00", Offset = "0x762B300", VA = "0x18762CB00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x762E260", Offset = "0x762CA60", VA = "0x18762E260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float KDHKEEFDLKB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x762C840", Offset = "0x762B040", VA = "0x18762C840")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x762DD80", Offset = "0x762C580", VA = "0x18762DD80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float ICKNKGNMCCF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x762CF30", Offset = "0x762B730", VA = "0x18762CF30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x762E410", Offset = "0x762CC10", VA = "0x18762E410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion ENDAPGPOLFD
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x762CBE0", Offset = "0x762B3E0", VA = "0x18762CBE0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x762DFE0", Offset = "0x762C7E0", VA = "0x18762DFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion GPHHCIHDHJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x762CE60", Offset = "0x762B660", VA = "0x18762CE60")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x762E340", Offset = "0x762CB40", VA = "0x18762E340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 INLDALEEIMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x762CCB0", Offset = "0x762B4B0", VA = "0x18762CCB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x762E0B0", Offset = "0x762C8B0", VA = "0x18762E0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion HLDAONDCGBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x762CD90", Offset = "0x762B590", VA = "0x18762CD90")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x762E190", Offset = "0x762C990", VA = "0x18762E190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 KAHKKJLHEEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x762CFF0", Offset = "0x762B7F0", VA = "0x18762CFF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x762E4F0", Offset = "0x762CCF0", VA = "0x18762E4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 EPGELPCMLDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x762C8A0", Offset = "0x762B0A0", VA = "0x18762C8A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x762DDF0", Offset = "0x762C5F0", VA = "0x18762DDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 NAILJECMJDD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x762C210", Offset = "0x762AA10", VA = "0x18762C210")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x762D990", Offset = "0x762C190", VA = "0x18762D990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 HOPDBNLFMHO
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x762C680", Offset = "0x762AE80", VA = "0x18762C680")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x762DBC0", Offset = "0x762C3C0", VA = "0x18762DBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 OEHAFFDNIEG
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x762C540", Offset = "0x762AD40", VA = "0x18762C540")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion CCMEOENCNOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x762C470", Offset = "0x762AC70", VA = "0x18762C470")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 NEPNCLKCKBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x762D290", Offset = "0x762BA90", VA = "0x18762D290")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 MGCBHANKCFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x762D1B0", Offset = "0x762B9B0", VA = "0x18762D1B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool IBKNBDHPHIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x762C620", Offset = "0x762AE20", VA = "0x18762C620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CKJKIGBHOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x762C0F0", Offset = "0x762A8F0", VA = "0x18762C0F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool ABBIBHPHGKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x762BC00", Offset = "0x762A400", VA = "0x18762BC00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool JAAEGIACACE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x762BBA0", Offset = "0x762A3A0", VA = "0x18762BBA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool NCNOGIDJLCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x762BA80", Offset = "0x762A280", VA = "0x18762BA80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool PIIMEEJONOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x762C410", Offset = "0x762AC10", VA = "0x18762C410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool KNPGJHABEDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1CFB8F0", Offset = "0x1CFA0F0", VA = "0x181CFB8F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event LKNNFBAGKCD INEBKPHCMHG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x762B9A0", Offset = "0x762A1A0", VA = "0x18762B9A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x762D610", Offset = "0x762BE10", VA = "0x18762D610")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event KJOJIKKICPM AOADHMFLHHD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x762B710", Offset = "0x7629F10", VA = "0x18762B710")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x762D370", Offset = "0x762BB70", VA = "0x18762D370")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event KJOJIKKICPM GJBKPELNFGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x762B770", Offset = "0x7629F70", VA = "0x18762B770")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x762D3E0", Offset = "0x762BBE0", VA = "0x18762D3E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event KJOJIKKICPM HACMIDNDACF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x762B8C0", Offset = "0x762A0C0", VA = "0x18762B8C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x762D530", Offset = "0x762BD30", VA = "0x18762D530")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<HNNBIECDFEH, HNNBIECDFEH> PENDLLPMKAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x762B850", Offset = "0x762A050", VA = "0x18762B850")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x762D4C0", Offset = "0x762BCC0", VA = "0x18762D4C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event KJOJIKKICPM DBLDIEJJHBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x762B930", Offset = "0x762A130", VA = "0x18762B930")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x762D5A0", Offset = "0x762BDA0", VA = "0x18762D5A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event KJOJIKKICPM IFILMJHKELF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x762BA10", Offset = "0x762A210", VA = "0x18762BA10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x762D680", Offset = "0x762BE80", VA = "0x18762D680")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event KJOJIKKICPM ENNIKABMLLF
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x762B7E0", Offset = "0x7629FE0", VA = "0x18762B7E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x762D450", Offset = "0x762BC50", VA = "0x18762D450")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B51E0", Offset = "0x8B39E0", VA = "0x1808B51E0", Slot = "8")]
		private void DCHJHFONGIL(CLKDHEIJDPM CLCEHBDJMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x762A130", Offset = "0x7628930", VA = "0x18762A130")]
		internal void HGEDGEIADHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x762B430", Offset = "0x7629C30", VA = "0x18762B430")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody IJJCJMLBBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7629E80", Offset = "0x7628680", VA = "0x187629E80")]
		public LDJJPBBNOHE GetChild(int ECDOOAABOPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x762B090", Offset = "0x7629890", VA = "0x18762B090")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) GONNOPNNDDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7629B80", Offset = "0x7628380", VA = "0x187629B80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x762B320", Offset = "0x7629B20", VA = "0x18762B320")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7629BF0", Offset = "0x76283F0", VA = "0x187629BF0")]
		private CLKDHEIJDPM CNCBILGCOAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x762A420", Offset = "0x7628C20", VA = "0x18762A420")]
		private void LDJJIOLOFEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x762A860", Offset = "0x7629060", VA = "0x18762A860")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x762A7A0", Offset = "0x7628FA0", VA = "0x18762A7A0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x762A130", Offset = "0x7628930", VA = "0x18762A130")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x762A800", Offset = "0x7629000", VA = "0x18762A800")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x762A8C0", Offset = "0x76290C0", VA = "0x18762A8C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7629170", Offset = "0x7627970", VA = "0x187629170")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object DJIMHLGHFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x762A920", Offset = "0x7629120", VA = "0x18762A920")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object DJIMHLGHFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7629E20", Offset = "0x7628620", VA = "0x187629E20")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x762A740", Offset = "0x7628F40", VA = "0x18762A740")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x762B1F0", Offset = "0x76299F0", VA = "0x18762B1F0")]
		public void SetParent(RigidbodyEx INDENPJBLHO, bool NCJCCAJKLJN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x762AC30", Offset = "0x7629430", VA = "0x18762AC30")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x762A1C0", Offset = "0x76289C0", VA = "0x18762A1C0")]
		public bool IsRigidbodyAncestor(RigidbodyEx GDGOCIEACPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x762A2C0", Offset = "0x7628AC0", VA = "0x18762A2C0")]
		public bool IsRigidbodyDescendant(RigidbodyEx FCEAHKELPFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x76293E0", Offset = "0x7627BE0", VA = "0x1876293E0")]
		public void AddInterpolationRestriction(object DJIMHLGHFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x762A990", Offset = "0x7629190", VA = "0x18762A990")]
		public void RemoveInterpolationRestriction(object DJIMHLGHFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7629450", Offset = "0x7627C50", VA = "0x187629450")]
		public void AddKinematic(object DJIMHLGHFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x762AA00", Offset = "0x7629200", VA = "0x18762AA00")]
		public void RemoveKinematic(object DJIMHLGHFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x762B170", Offset = "0x7629970", VA = "0x18762B170")]
		public void SetKinematic(object DJIMHLGHFGI, bool NJPKHDOCLPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x762AF90", Offset = "0x7629790", VA = "0x18762AF90")]
		public void SetDiscontinuousPositionAndRotation(Vector3 MKBPBNELLML, Quaternion EIBNEKFAKNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x762AE90", Offset = "0x7629690", VA = "0x18762AE90")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 LNBFCBPPFCP, Quaternion PLHOLEPGJHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x762A020", Offset = "0x7628820", VA = "0x18762A020")]
		public Vector3 GetConstrainedVelocity(Vector3 KAHKKJLHEEJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7629F10", Offset = "0x7628710", VA = "0x187629F10")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 NAILJECMJDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x76292F0", Offset = "0x7627AF0", VA = "0x1876292F0")]
		public void AddForce(Vector3 KHDIFEIJFDB, ForceMode JJAPHGHHBJE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x76291E0", Offset = "0x76279E0", VA = "0x1876291E0")]
		public void AddForceAtPosition(Vector3 KHDIFEIJFDB, Vector3 BALIIBCILHH, ForceMode JJAPHGHHBJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7629620", Offset = "0x7627E20", VA = "0x187629620")]
		public void AddTorque(Vector3 OKFDNEPALDE, ForceMode JJAPHGHHBJE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x76294C0", Offset = "0x7627CC0", VA = "0x1876294C0")]
		public void AddRelativeTorque(Vector3 OKFDNEPALDE, ForceMode JJAPHGHHBJE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x762B500", Offset = "0x7629D00", VA = "0x18762B500")]
		public Vector3 WorldToLocalVelocity(Vector3 PCALFOEEPAF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x762A630", Offset = "0x7628E30", VA = "0x18762A630")]
		public Vector3 LocalToWorldVelocity(Vector3 EPGELPCMLDO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7629DC0", Offset = "0x76285C0", VA = "0x187629DC0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7629D60", Offset = "0x7628560", VA = "0x187629D60")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7629D00", Offset = "0x7628500", VA = "0x187629D00")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7629CA0", Offset = "0x76284A0", VA = "0x187629CA0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x762AD90", Offset = "0x7629590", VA = "0x18762AD90")]
		public void ResetVelocityWorldSpace(Vector3 EDONNCIELGP, Vector3 HCJLGMKALKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x762AC90", Offset = "0x7629490", VA = "0x18762AC90")]
		public void ResetVelocityLocalSpace(Vector3 LPLJFCLGJKM, Vector3 HOPDBNLFMHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x762AB50", Offset = "0x7629350", VA = "0x18762AB50")]
		public void ResetLinearVelocityLocalSpace(Vector3 LPLJFCLGJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x762B330", Offset = "0x7629B30", VA = "0x18762B330")]
		public bool SweepTest(Vector3 NGBCGJCGHJG, [Out] RaycastHit PFJHGCCOMGD, float HFFBJNAMAGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x762A3C0", Offset = "0x7628BC0", VA = "0x18762A3C0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x762B2C0", Offset = "0x7629AC0", VA = "0x18762B2C0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x762B4A0", Offset = "0x7629CA0", VA = "0x18762B4A0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x76295B0", Offset = "0x7627DB0", VA = "0x1876295B0")]
		public void AddShouldHaveUnityRigidbodyToken(object DJIMHLGHFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x762AA70", Offset = "0x7629270", VA = "0x18762AA70")]
		public void RemoveShouldHaveUnityRigidbodyToken(object DJIMHLGHFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x76299B0", Offset = "0x76281B0", VA = "0x1876299B0")]
		public void ApplyForceVelocityChange(CAGMBFKGEMC GHLELCMGNEE, Vector3 JPHOJJCHKHD, float KANLLIFFDJB, float NDNEEMGLJDD = 8f, float PEFEPHIPIEA = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x76298B0", Offset = "0x76280B0", VA = "0x1876298B0")]
		public void ApplyAngularVelocityChange(AOIBDNAKBNG INFBLAPINDA, Vector3 JDHNCLHOBJL, float JHKMJBBILBB = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7629A70", Offset = "0x7628270", VA = "0x187629A70")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(AOIBDNAKBNG INFBLAPINDA, Vector3 OJEGGOKKPLF, float MHNMFOIOAKI = 7f, float HGDNLAPNDME = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x76297E0", Offset = "0x7627FE0", VA = "0x1876297E0")]
		public bool AllowedScaleChange(float JIEAOBFDGBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7629710", Offset = "0x7627F10", VA = "0x187629710")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx BEHILLMJEKM, object DJIMHLGHFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x762AAE0", Offset = "0x76292E0", VA = "0x18762AAE0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object DJIMHLGHFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x762B6A0", Offset = "0x7629EA0", VA = "0x18762B6A0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD8B3B0", Offset = "0xD89BB0", VA = "0x180D8B3B0", Slot = "4")]
		private GameObject LGGBDILMGGN()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8E2910", Offset = "0x8E1110", VA = "0x1808E2910", Slot = "9")]
		private bool KPBLGHLFFCL()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class HDGDIHGPJAL
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7622DC0", Offset = "0x76215C0", VA = "0x187622DC0")]
	public static CLKDHEIJDPM FNMDAPOIJFD(this RigidbodyEx MDLECLEGCKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(CBHDAMNBEEK), new string[] { })]
public class GEKJOGDPCGE : CBHDAMNBEEK, NAFMJLPHDHE
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private KDOKNCAMHOF DDPODIECNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PABIKGNHBLB BIJBPNIFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private DEBILJDLBCD ECEBNENDHDM;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PABIKGNHBLB KOJHMMMMDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DEBILJDLBCD MGNDCMEKDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x761E740", Offset = "0x761CF40", VA = "0x18761E740", Slot = "7")]
	public void InitReferences(IMGHKCMNGFB AFLKPGNHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x761E640", Offset = "0x761CE40", VA = "0x18761E640", Slot = "6")]
	public CLKDHEIJDPM CDMGOOGOCFI(RigidbodyEx MDLECLEGCKN, AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public GEKJOGDPCGE()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static GCOJJNPJFGN UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int IFDOLPJFEIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int HEMPKCMEMCC;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7628FD0", Offset = "0x76277D0", VA = "0x187628FD0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7629010", Offset = "0x7627810", VA = "0x187629010")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7628FF0", Offset = "0x76277F0", VA = "0x187628FF0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string PJFOMDHJLBF, [Optional] UnityEngine.Object IKGPEBFFMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string PJFOMDHJLBF, [Optional] UnityEngine.Object IKGPEBFFMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7629120", Offset = "0x7627920", VA = "0x187629120")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PIFPLEPBBGP
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class IAFFIMJKMMJ : JBNIKIOLDLF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8C6860", Offset = "0x8C5060", VA = "0x1808C6860", Slot = "4")]
		public Vector3 JJKNIHHEPCM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8C6860", Offset = "0x8C5060", VA = "0x1808C6860", Slot = "5")]
		public Vector3 CBDLJKGGLHC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public IAFFIMJKMMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static JBNIKIOLDLF CLDJIMPLPPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7628F00", Offset = "0x7627700", VA = "0x187628F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CDBBMABFKIC
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode LNPCAGOAEAP
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
	void JNLOKBHKNIB();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NFPIELKJPMP(bool IBKNBDHPHIP);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KIOBEOGHIIK(bool IBKNBDHPHIP);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CGANLJFHJEG(Rigidbody JPHPMPANJGL);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DEDKHLCDJDI(Vector3 NGBCGJCGHJG, [Out] RaycastHit PFJHGCCOMGD, float HFFBJNAMAGI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JGKGPPGHLCD : IDisposable, OPLCNBEPAIK
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	FMLELDCHGMI FEGAPJIGNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<HNNBIECDFEH, HNNBIECDFEH> PENDLLPMKAO;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNLOKBHKNIB();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface DEBILJDLBCD
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PLABINPGACE PNOIDJHKGNL(CLKDHEIJDPM CLCEHBDJMEK);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EAFFNCAKEFP DKNHAABOBLA(CLKDHEIJDPM CLCEHBDJMEK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ABCGMCABKND BOJMCHLHJEG(CLKDHEIJDPM CLCEHBDJMEK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	POFFLBFPDEK GAOCCOLANBM(CLKDHEIJDPM CLCEHBDJMEK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ICJNBHPDIDE PBKAMEBECJF(CLKDHEIJDPM CLCEHBDJMEK);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JGKGPPGHLCD NJODIGHMNAN(CLKDHEIJDPM CLCEHBDJMEK);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LJBNAHGNIGF DFHNHPANIKJ(CLKDHEIJDPM CLCEHBDJMEK);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PAJGJMAMMPE LDGBDIIPJGI(CLKDHEIJDPM CLCEHBDJMEK);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CDBBMABFKIC KMHDINKCAAO(CLKDHEIJDPM CLCEHBDJMEK);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CFGOPLPHBCD FMPPOLAPBEA(CLKDHEIJDPM CLCEHBDJMEK);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IACBGDDNOPF FJEPFJEIOEF(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ONCGKNFNLKD LOOFENAFBPI(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OOAIEDLDNBE DIHMJPGINFA(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MPHKHPEPLND PLDHCNCGFOF(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GEHDLGLPDMH NHHKEFABNJB(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CLKDHEIJDPM CDMGOOGOCFI(RigidbodyEx MDLECLEGCKN, AHMFFPIAIMI EBNFOODJNOB, CBHDAMNBEEK JIPBFCNFKIF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PAJGJMAMMPE
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKAJMJMIOEI(Vector3 KHDIFEIJFDB, ForceMode JJAPHGHHBJE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJABKPPHMOK(Vector3 KHDIFEIJFDB, Vector3 BALIIBCILHH, ForceMode JJAPHGHHBJE);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCHPEGFCLNP(Vector3 OKFDNEPALDE, ForceMode JJAPHGHHBJE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFDDEEJOACG(Vector3 OKFDNEPALDE, ForceMode JJAPHGHHBJE = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CFGOPLPHBCD
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool FKDPMNMNENH
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
	void CGANLJFHJEG(Rigidbody JPHPMPANJGL);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void POJDBKFNNLH(Rigidbody JPHPMPANJGL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PLABINPGACE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<CLKDHEIJDPM> KMBJOCPEJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	CLKDHEIJDPM JJAKCGIGEEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	CLKDHEIJDPM MHMOKMJDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KJOJIKKICPM AOADHMFLHHD;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event KJOJIKKICPM GJBKPELNFGK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event LKNNFBAGKCD KGNLKJOGCPF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action KNBEMDILBFF;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action GBNPJDIEBAM;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<CLKDHEIJDPM> PIBJCODKOMF;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<CLKDHEIJDPM> CMJFEHONOPD;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action IAAKGCHDHBI;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<CLKDHEIJDPM> HPLIPKFMLOB;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DDCCBIGAKMA(CLKDHEIJDPM FABMJJHDKOA, bool NCJCCAJKLJN = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ABCGMCABKND
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 PCNPNEJGBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 GDDNELAPFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NIHMGDBGCFE(CLKDHEIJDPM NCCLECGLDAO, object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IPKDBAHAKIA(object DJIMHLGHFGI);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MPHKHPEPLND
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 BHGBHOLOBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 OCMLFPAFCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float OBICABEGEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float IKNNFHJBACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 PJNHHCLFIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion KLOLJBMEMDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event KJOJIKKICPM MLOFENAFKBJ;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LIEGMGMENOM((Quaternion rot, Vector3 moments) GONNOPNNDDD);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CNJBBDKPIKE();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LMHMCEKKFIL();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MJEMIAPJHGI();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CGANLJFHJEG(Rigidbody JPHPMPANJGL);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void POJDBKFNNLH(Rigidbody JPHPMPANJGL);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GFFDCONBCGL();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OOAIEDLDNBE
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNLOKBHKNIB();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALPACOOENCM(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCGKEAGMCGN(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GDCHIIMBBFP(CLKDHEIJDPM MDLECLEGCKN);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GFGNJDPIHOO(CLKDHEIJDPM MDLECLEGCKN);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KLCJHNMINBI();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LJBNAHGNIGF
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HBGLEDGEAAP
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event KJOJIKKICPM DKJPADICAID;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LHOMBJDILPL(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JECKHECCMHJ(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NGILCALIHMA(object DJIMHLGHFGI, bool NJPKHDOCLPC);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CGANLJFHJEG(Rigidbody PFJJBBEKFJA);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void POJDBKFNNLH(Rigidbody JPHPMPANJGL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ONCGKNFNLKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool FCLMMMCPFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool KFLDOLPOEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event KJOJIKKICPM KMAOLGOKLEH;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNLOKBHKNIB();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IKAKOOGGHFH(CLKDHEIJDPM NCCLECGLDAO);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EPNFOJIHOMG(CLKDHEIJDPM NCCLECGLDAO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GEHDLGLPDMH
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool OIDKFEONKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool KOJKNHJKKBN
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints DHEIMOODHNI
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
	void CGANLJFHJEG(Rigidbody JPHPMPANJGL);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void POJDBKFNNLH(Rigidbody JPHPMPANJGL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface POFFLBFPDEK
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float KNNCHAJPCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float MPDJELAGIJE
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
	void CGANLJFHJEG(Rigidbody JPHPMPANJGL);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void POJDBKFNNLH(Rigidbody JPHPMPANJGL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ICJNBHPDIDE
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	static bool DJFBPMNMJEH;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event KJOJIKKICPM AIDPNAIBMDN;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNLOKBHKNIB();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KJJAHCAGAMI();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HBFMEHMOEKG();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IGAKIOOAGHE();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GBLOBMLLBII();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool IOMAAPDMCGN();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DLONNFJPLNP(bool OHAPPNDMKIN);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OBKPNCKIMEG();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IACBGDDNOPF
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody HIPNKAOEIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool ADANHCHBNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNLOKBHKNIB();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ACNPMEFFPLJ(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOMEBGPDCMB(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HCBDEIJKBFA();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EAFFNCAKEFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	JBNIKIOLDLF KNCLLFKNBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	MBMIBMKAFBA OCKFMKMEPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 LBNNPBIDFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 KEJINJCIGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 DBHPKKICEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 EBKJJPKMODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float MGBPLPCNCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool JOJNGDGIGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JNLOKBHKNIB();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IABKNCINIIH(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IMIONDKKMCP(AOIBDNAKBNG INFBLAPINDA, Vector3 JDHNCLHOBJL, float JHKMJBBILBB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AABHOIJCEPE(CAGMBFKGEMC GHLELCMGNEE, Vector3 JPHOJJCHKHD, float KANLLIFFDJB, float NDNEEMGLJDD = 8f, float PEFEPHIPIEA = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NGPHDFNAKAB(AOIBDNAKBNG INFBLAPINDA, Vector3 OJEGGOKKPLF, float MHNMFOIOAKI = 7f, float HGDNLAPNDME = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EJCIOEBEFGN();

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DDMMBAMAOJB();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DFKCKFJCDJJ();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BIJGCPALBCB();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CGANLJFHJEG(Rigidbody JPHPMPANJGL);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 AFGFJFHNODC(Vector3 KAHKKJLHEEJ);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DCOIGLJGGBG(object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DIFBBCFEJIC(Vector3 JKCDJCOBNFD);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CCJJCFAJKPP(Vector3 LPLJFCLGJKM, Vector3 HOPDBNLFMHO);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DICCAJJNCPA(Vector3 EDONNCIELGP, Vector3 HCJLGMKALKF);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 JPABHDFFLJA(Vector3 EPGELPCMLDO);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 AHNJJDLLBIM(Vector3 PCALFOEEPAF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface PABIKGNHBLB
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool BLEBMFHFILD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIIMNDKLDGP(string JBBHONJKFOI);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OALBLFFNEIE(RigidbodyEx MDLECLEGCKN, Action ILIPDNLABEN);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EJEKKKILJCH HOFIHAHLICE(int MCEAJPKKKLO);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGBOPJDILGE(Vector3 LCMDAFJDAHA, float JDGBCMPEHFO, Color LCDEMOPFJEN);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface CBHDAMNBEEK
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	PABIKGNHBLB KOJHMMMMDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	DEBILJDLBCD MGNDCMEKDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CLKDHEIJDPM CDMGOOGOCFI(RigidbodyEx MDLECLEGCKN, AHMFFPIAIMI EBNFOODJNOB);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FCIHPCIEKBE : CLKDHEIJDPM, IDisposable, OLMGAELMFFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly CBHDAMNBEEK JIPBFCNFKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal PLABINPGACE NBHCIJIPGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal OOAIEDLDNBE BOIKMLENNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal ONCGKNFNLKD IPMJAHCHKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal EAFFNCAKEFP KAHKKJLHEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal ABCGMCABKND PDPIKJKGFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal MPHKHPEPLND MHNJDIEHINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal POFFLBFPDEK KMCCBIMBDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal CFGOPLPHBCD LKPHGNIANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal ICJNBHPDIDE MAFMEINFALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal JGKGPPGHLCD LDCCMNDPONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal LJBNAHGNIGF FCCDMPODDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal PAJGJMAMMPE KHDIFEIJFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal GEHDLGLPDMH DMAFEMGLELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal IACBGDDNOPF JPHPMPANJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal CDBBMABFKIC OAKMHOIOFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable NPFBNCHEBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool KPOCHHBMEOB;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public NLPICMPDONC IAKMOOCKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "22")]
		get
		{
			return default(NLPICMPDONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public LDJJPBBNOHE PNNDDMLJICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA7DF10", Offset = "0xA7C710", VA = "0x180A7DF10", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA7DEF0", Offset = "0xA7C6F0", VA = "0x180A7DEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject BOMBMPDPILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8C0C70", Offset = "0x8BF470", VA = "0x1808C0C70", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8C0C80", Offset = "0x8BF480", VA = "0x1808C0C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform KEKDMLOCEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x98AAD0", Offset = "0x9892D0", VA = "0x18098AAD0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA90070", Offset = "0xA8E870", VA = "0x180A90070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody HIPNKAOEIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x761CD90", Offset = "0x761B590", VA = "0x18761CD90", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public CLKDHEIJDPM MHMOKMJDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x761CBE0", Offset = "0x761B3E0", VA = "0x18761CBE0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x761D960", Offset = "0x761C160", VA = "0x18761D960", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int DKOJDBHPCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x761D000", Offset = "0x761B800", VA = "0x18761D000", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public CLKDHEIJDPM JJAKCGIGEEC
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x76189D0", Offset = "0x76171D0", VA = "0x1876189D0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool LGOLHEAHKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7619100", Offset = "0x7617900", VA = "0x187619100", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool FCLMMMCPFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x761D580", Offset = "0x761BD80", VA = "0x18761D580", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool KFLDOLPOEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7618630", Offset = "0x7616E30", VA = "0x187618630", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public JBNIKIOLDLF KNCLLFKNBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7618110", Offset = "0x7616910", VA = "0x187618110", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7618A60", Offset = "0x7617260", VA = "0x187618A60", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public MBMIBMKAFBA OCKFMKMEPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7617F10", Offset = "0x7616710", VA = "0x187617F10", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7619FB0", Offset = "0x76187B0", VA = "0x187619FB0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float MGBPLPCNCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x761D910", Offset = "0x761C110", VA = "0x18761D910", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7619A70", Offset = "0x7618270", VA = "0x187619A70", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 KEJINJCIGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7618CC0", Offset = "0x76174C0", VA = "0x187618CC0", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7618EF0", Offset = "0x76176F0", VA = "0x187618EF0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 EBKJJPKMODE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x761AD20", Offset = "0x7619520", VA = "0x18761AD20", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x761DDC0", Offset = "0x761C5C0", VA = "0x18761DDC0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 LBNNPBIDFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x761B3C0", Offset = "0x7619BC0", VA = "0x18761B3C0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x761AF40", Offset = "0x7619740", VA = "0x18761AF40", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 DBHPKKICEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x761C910", Offset = "0x761B110", VA = "0x18761C910", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x761BF50", Offset = "0x761A750", VA = "0x18761BF50", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool ABBIBHPHGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x761B310", Offset = "0x7619B10", VA = "0x18761B310", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool JAAEGIACACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x761AA90", Offset = "0x7619290", VA = "0x18761AA90", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool NCNOGIDJLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7618680", Offset = "0x7616E80", VA = "0x187618680", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool JOJNGDGIGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x761CAE0", Offset = "0x761B2E0", VA = "0x18761CAE0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 PCNPNEJGBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x761A980", Offset = "0x7619180", VA = "0x18761A980", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 GDDNELAPFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x761ABA0", Offset = "0x76193A0", VA = "0x18761ABA0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 BHGBHOLOBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x76188A0", Offset = "0x76170A0", VA = "0x1876188A0", Slot = "54")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x761DC80", Offset = "0x761C480", VA = "0x18761DC80", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 OCMLFPAFCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x761B550", Offset = "0x7619D50", VA = "0x18761B550", Slot = "56")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float OBICABEGEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x761ACD0", Offset = "0x76194D0", VA = "0x18761ACD0", Slot = "57")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float IKNNFHJBACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x761B8D0", Offset = "0x761A0D0", VA = "0x18761B8D0", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x761B020", Offset = "0x7619820", VA = "0x18761B020", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 PJNHHCLFIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x761E010", Offset = "0x761C810", VA = "0x18761E010", Slot = "60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion KLOLJBMEMDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7619030", Offset = "0x7617830", VA = "0x187619030", Slot = "61")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float KNNCHAJPCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x761AC80", Offset = "0x7619480", VA = "0x18761AC80", Slot = "63")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7618840", Offset = "0x7617040", VA = "0x187618840", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float MPDJELAGIJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x761C0B0", Offset = "0x761A8B0", VA = "0x18761C0B0", Slot = "65")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x761B4A0", Offset = "0x7619CA0", VA = "0x18761B4A0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool FKDPMNMNENH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x761CC90", Offset = "0x761B490", VA = "0x18761CC90", Slot = "67")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7618C60", Offset = "0x7617460", VA = "0x187618C60", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FMLELDCHGMI FEGAPJIGNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x761A450", Offset = "0x7618C50", VA = "0x18761A450", Slot = "69")]
		get
		{
			return default(FMLELDCHGMI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x761D9C0", Offset = "0x761C1C0", VA = "0x18761D9C0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool HBGLEDGEAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x761A620", Offset = "0x7618E20", VA = "0x18761A620", Slot = "71")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform KANCOIDCOHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x98AAD0", Offset = "0x9892D0", VA = "0x18098AAD0", Slot = "72")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 KANAGPKDKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x761E0F0", Offset = "0x761C8F0", VA = "0x18761E0F0", Slot = "73")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x761CB30", Offset = "0x761B330", VA = "0x18761CB30", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float MIHAIJGPNOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x761C9F0", Offset = "0x761B1F0", VA = "0x18761C9F0", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x761A5B0", Offset = "0x7618DB0", VA = "0x18761A5B0", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float FKDCOACEDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x761A5A0", Offset = "0x7618DA0", VA = "0x18761A5A0", Slot = "77")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x761DBA0", Offset = "0x761C3A0", VA = "0x18761DBA0", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion OCICAGHFMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x761DF70", Offset = "0x761C770", VA = "0x18761DF70", Slot = "79")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x761D320", Offset = "0x761BB20", VA = "0x18761D320", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 MAGAFCIBJGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x761A4A0", Offset = "0x7618CA0", VA = "0x18761A4A0", Slot = "81")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x761AA50", Offset = "0x7619250", VA = "0x18761AA50", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion HPCBIJNFAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7618A20", Offset = "0x7617220", VA = "0x187618A20", Slot = "83")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x761A0C0", Offset = "0x76188C0", VA = "0x18761A0C0", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints DHEIMOODHNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x761A930", Offset = "0x7619130", VA = "0x18761A930", Slot = "85")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x761B0D0", Offset = "0x76198D0", VA = "0x18761B0D0", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool OIDKFEONKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x761B080", Offset = "0x7619880", VA = "0x18761B080", Slot = "87")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7618FD0", Offset = "0x76177D0", VA = "0x187618FD0", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode LNPCAGOAEAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x761B920", Offset = "0x761A120", VA = "0x18761B920", Slot = "89")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x761AEE0", Offset = "0x76196E0", VA = "0x18761AEE0", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool PGLHKAPDGJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x761A6D0", Offset = "0x7618ED0", VA = "0x18761A6D0", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool CKJKIGBHOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x761D400", Offset = "0x761BC00", VA = "0x18761D400", Slot = "91")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event KJOJIKKICPM AOADHMFLHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7618DA0", Offset = "0x76175A0", VA = "0x187618DA0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x761BAD0", Offset = "0x761A2D0", VA = "0x18761BAD0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event KJOJIKKICPM GJBKPELNFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x761E200", Offset = "0x761CA00", VA = "0x18761E200", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x761AB40", Offset = "0x7619340", VA = "0x18761AB40", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event LKNNFBAGKCD KGNLKJOGCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7618390", Offset = "0x7616B90", VA = "0x187618390", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x761E450", Offset = "0x761CC50", VA = "0x18761E450", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event KJOJIKKICPM KMAOLGOKLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x761E4B0", Offset = "0x761CCB0", VA = "0x18761E4B0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x76184F0", Offset = "0x7616CF0", VA = "0x1876184F0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event KJOJIKKICPM HACMIDNDACF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x761C850", Offset = "0x761B050", VA = "0x18761C850", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x761DD60", Offset = "0x761C560", VA = "0x18761DD60", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event KJOJIKKICPM AIDPNAIBMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x761D270", Offset = "0x761BA70", VA = "0x18761D270", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7618C00", Offset = "0x7617400", VA = "0x187618C00", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<HNNBIECDFEH, HNNBIECDFEH> PENDLLPMKAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x761C8B0", Offset = "0x761B0B0", VA = "0x18761C8B0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x761B630", Offset = "0x7619E30", VA = "0x18761B630", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event KJOJIKKICPM DKJPADICAID
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x761A670", Offset = "0x7618E70", VA = "0x18761A670", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7619AD0", Offset = "0x76182D0", VA = "0x187619AD0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event KJOJIKKICPM ENNIKABMLLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x761A010", Offset = "0x7618810", VA = "0x18761A010", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7618B50", Offset = "0x7617350", VA = "0x187618B50", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x761E550", Offset = "0x761CD50", VA = "0x18761E550")]
	public FCIHPCIEKBE(GameObject PBJIFBOBIOP, RigidbodyEx MBOAOJPOLHA, CBHDAMNBEEK JIPBFCNFKIF, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x761D620", Offset = "0x761BE20", VA = "0x18761D620", Slot = "138")]
	protected virtual void MPCDFPFCNME(CBHDAMNBEEK JIPBFCNFKIF, AHMFFPIAIMI EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7619B30", Offset = "0x7618330", VA = "0x187619B30", Slot = "139")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x761C610", Offset = "0x761AE10", VA = "0x18761C610", Slot = "92")]
	public void JNLOKBHKNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x761CA00", Offset = "0x761B200", VA = "0x18761CA00", Slot = "93")]
	public void KJFJKFGHICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x761E260", Offset = "0x761CA60", VA = "0x18761E260", Slot = "94")]
	public void PCJCDGBEAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x761E2C0", Offset = "0x761CAC0", VA = "0x18761E2C0", Slot = "95")]
	public void PFLIEJBLKMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x76197F0", Offset = "0x7617FF0", VA = "0x1876197F0")]
	private void DLONNFJPLNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x761CDE0", Offset = "0x761B5E0", VA = "0x18761CDE0")]
	private void LHNPAKCAFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x761BA70", Offset = "0x761A270", VA = "0x18761BA70")]
	private void IOMAAPDMCGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x761C030", Offset = "0x761A830", VA = "0x18761C030", Slot = "30")]
	public CLKDHEIJDPM JFFBKLJCMHI(int ECDOOAABOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x76191B0", Offset = "0x76179B0", VA = "0x1876191B0", Slot = "97")]
	public void DDCCBIGAKMA(CLKDHEIJDPM INDENPJBLHO, bool NCJCCAJKLJN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x761B360", Offset = "0x7619B60", VA = "0x18761B360", Slot = "98")]
	public void IBNECMGCCBE(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x761CFA0", Offset = "0x761B7A0", VA = "0x18761CFA0", Slot = "99")]
	public void LJDAOBCCLCF(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x76183F0", Offset = "0x7616BF0", VA = "0x1876183F0", Slot = "100")]
	public Vector3 AHNJJDLLBIM(Vector3 PCALFOEEPAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x761C750", Offset = "0x761AF50", VA = "0x18761C750", Slot = "101")]
	public Vector3 JPABHDFFLJA(Vector3 EPGELPCMLDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7618980", Offset = "0x7617180", VA = "0x187618980", Slot = "102")]
	public void BIJGCPALBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7619220", Offset = "0x7617A20", VA = "0x187619220", Slot = "103")]
	public void DDMMBAMAOJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x761A550", Offset = "0x7618D50", VA = "0x18761A550", Slot = "104")]
	public void EJCIOEBEFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x76193C0", Offset = "0x7617BC0", VA = "0x1876193C0", Slot = "105")]
	public void DICCAJJNCPA(Vector3 EDONNCIELGP, Vector3 HCJLGMKALKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7618E00", Offset = "0x7617600", VA = "0x187618E00", Slot = "106")]
	public void CCJJCFAJKPP(Vector3 LPLJFCLGJKM, Vector3 HOPDBNLFMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x76194B0", Offset = "0x7617CB0", VA = "0x1876194B0", Slot = "107")]
	public void DIFBBCFEJIC(Vector3 JKCDJCOBNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7617E50", Offset = "0x7616650", VA = "0x187617E50", Slot = "108")]
	public void AABHOIJCEPE(CAGMBFKGEMC GHLELCMGNEE, Vector3 JPHOJJCHKHD, float KANLLIFFDJB, float NDNEEMGLJDD = 8f, float PEFEPHIPIEA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x761B970", Offset = "0x761A170", VA = "0x18761B970", Slot = "109")]
	public void IMIONDKKMCP(AOIBDNAKBNG INFBLAPINDA, Vector3 JDHNCLHOBJL, float JHKMJBBILBB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x761DA90", Offset = "0x761C290", VA = "0x18761DA90", Slot = "110")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void NGPHDFNAKAB(AOIBDNAKBNG INFBLAPINDA, Vector3 OJEGGOKKPLF, float MHNMFOIOAKI = 7f, float HGDNLAPNDME = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7618160", Offset = "0x7616960", VA = "0x187618160", Slot = "111")]
	public Vector3 AFGFJFHNODC(Vector3 INDENPJBLHO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x761BC40", Offset = "0x761A440", VA = "0x18761BC40", Slot = "112")]
	public Vector3 JAOOJPDJKOH(Vector3 INDENPJBLHO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7619370", Offset = "0x7617B70", VA = "0x187619370", Slot = "113")]
	public void DFKCKFJCDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x761A4E0", Offset = "0x7618CE0", VA = "0x18761A4E0", Slot = "114")]
	public void EJANDGAIOFJ(CLKDHEIJDPM BEHILLMJEKM, object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x761B870", Offset = "0x761A070", VA = "0x18761B870", Slot = "115")]
	public void IKFAIMJLCIK(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x761CEC0", Offset = "0x761B6C0", VA = "0x18761CEC0", Slot = "62")]
	public void LIEGMGMENOM((Quaternion rot, Vector3 moments) GONNOPNNDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x761D2D0", Offset = "0x761BAD0", VA = "0x18761D2D0", Slot = "116")]
	public void LMHMCEKKFIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7619160", Offset = "0x7617960", VA = "0x187619160", Slot = "117")]
	public void CNJBBDKPIKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x761D5D0", Offset = "0x761BDD0", VA = "0x18761D5D0", Slot = "118")]
	public void MJEMIAPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x761CA90", Offset = "0x761B290", VA = "0x18761CA90", Slot = "119")]
	public bool KJJAHCAGAMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x761B500", Offset = "0x7619D00", VA = "0x18761B500", Slot = "96")]
	public void IGAKIOOAGHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x761DF00", Offset = "0x761C700", VA = "0x18761DF00", Slot = "120")]
	public void OBKPNCKIMEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x761CE60", Offset = "0x761B660", VA = "0x18761CE60", Slot = "121")]
	public void LHOMBJDILPL(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x761BD40", Offset = "0x761A540", VA = "0x18761BD40", Slot = "122")]
	public void JECKHECCMHJ(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x761DA20", Offset = "0x761C220", VA = "0x18761DA20", Slot = "123")]
	public void NGILCALIHMA(object DJIMHLGHFGI, bool NJPKHDOCLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x761D070", Offset = "0x761B870", VA = "0x18761D070", Slot = "124")]
	public void LKJFLEHIDOC(Vector3 MKBPBNELLML, Quaternion EIBNEKFAKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7618260", Offset = "0x7616A60", VA = "0x187618260", Slot = "125")]
	public void AFLDKBAHLKF(Vector3 LNBFCBPPFCP, Quaternion PLHOLEPGJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x761A8E0", Offset = "0x76190E0", VA = "0x18761A8E0", Slot = "126")]
	public bool FDJLAEKLHCK(float JIEAOBFDGBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x761E1A0", Offset = "0x761C9A0", VA = "0x18761E1A0", Slot = "127")]
	public void OLJBAKLMDEG(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x761CC30", Offset = "0x761B430", VA = "0x18761CC30", Slot = "128")]
	public void LCJDHNFNHBD(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7617F60", Offset = "0x7616760", VA = "0x187617F60", Slot = "129")]
	public void ACNPMEFFPLJ(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x761DEA0", Offset = "0x761C6A0", VA = "0x18761DEA0", Slot = "130")]
	public void NOMEBGPDCMB(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7618550", Offset = "0x7616D50", VA = "0x187618550", Slot = "131")]
	public void AKAJMJMIOEI(Vector3 KHDIFEIJFDB, ForceMode JJAPHGHHBJE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x761B690", Offset = "0x7619E90", VA = "0x18761B690", Slot = "132")]
	public void IJABKPPHMOK(Vector3 KHDIFEIJFDB, Vector3 BALIIBCILHH, ForceMode JJAPHGHHBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7618760", Offset = "0x7616F60", VA = "0x187618760", Slot = "133")]
	public void BCHPEGFCLNP(Vector3 OKFDNEPALDE, ForceMode JJAPHGHHBJE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x761AE00", Offset = "0x7619600", VA = "0x18761AE00", Slot = "134")]
	public void HFDDEEJOACG(Vector3 OKFDNEPALDE, ForceMode JJAPHGHHBJE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7619270", Offset = "0x7617A70", VA = "0x187619270", Slot = "135")]
	public bool DEDKHLCDJDI(Vector3 NGBCGJCGHJG, [Out] RaycastHit PFJHGCCOMGD, float HFFBJNAMAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x761AAF0", Offset = "0x76192F0", VA = "0x18761AAF0", Slot = "136")]
	public void GFFDCONBCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x761E510", Offset = "0x761CD10", VA = "0x18761E510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x761C540", Offset = "0x761AD40", VA = "0x18761C540")]
	private void JMJOLDJCCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x761BB30", Offset = "0x761A330", VA = "0x18761BB30")]
	private void JACJCMBGINB(CLKDHEIJDPM NCCLECGLDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x761B130", Offset = "0x7619930", VA = "0x18761B130")]
	private void HOLFJKLJIBO(CLKDHEIJDPM NCCLECGLDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x761CCE0", Offset = "0x761B4E0", VA = "0x18761CCE0")]
	private void LEGEKEINAMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7619590", Offset = "0x7617D90", VA = "0x187619590")]
	private void DKLHFLEMECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x761BDA0", Offset = "0x761A5A0", VA = "0x18761BDA0")]
	private void JEHAMOHKPOH(CLKDHEIJDPM KACFHLBGDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x761B7A0", Offset = "0x7619FA0", VA = "0x18761B7A0")]
	private void IKAKOOGGHFH(CLKDHEIJDPM NCCLECGLDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x761A810", Offset = "0x7619010", VA = "0x18761A810")]
	private void EPNFOJIHOMG(CLKDHEIJDPM NCCLECGLDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7617FC0", Offset = "0x76167C0", VA = "0x187617FC0")]
	private void ACOBPFOPBFE(LDJJPBBNOHE NCCLECGLDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x761C100", Offset = "0x761A900", VA = "0x18761C100", Slot = "142")]
	protected virtual void JKKNNANMGPG(LDJJPBBNOHE MDLECLEGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x761A0F0", Offset = "0x76188F0", VA = "0x18761A0F0")]
	protected void EFBKLCJPKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7619C30", Offset = "0x7618430", VA = "0x187619C30")]
	protected void EAONFPGLMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x76196C0", Offset = "0x7617EC0", VA = "0x1876196C0")]
	private void DKOLGEGBLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x761E2E0", Offset = "0x761CAE0", VA = "0x18761E2E0")]
	private void PHHOAHHPBNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class HGDIJDBNNCJ
{
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7622EA0", Offset = "0x76216A0", VA = "0x187622EA0")]
	public static CLKDHEIJDPM HHPLGHGOCIN(this CLKDHEIJDPM MDLECLEGCKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7622F60", Offset = "0x7621760", VA = "0x187622F60")]
	public static bool IBNJCMDMNGN(this CLKDHEIJDPM MDLECLEGCKN, CLKDHEIJDPM GDGOCIEACPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7623050", Offset = "0x7621850", VA = "0x187623050")]
	public static bool POIACMNENBL(this CLKDHEIJDPM MDLECLEGCKN, CLKDHEIJDPM FCEAHKELPFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7623000", Offset = "0x7621800", VA = "0x187623000")]
	public static LDJJPBBNOHE MOCDPAJKOPP(this CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7622E30", Offset = "0x7621630", VA = "0x187622E30")]
	public static FCIHPCIEKBE DJDIPGHGGMA(this CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BHOHJOAJCHO : DEBILJDLBCD
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7614E30", Offset = "0x7613630", VA = "0x187614E30", Slot = "19")]
	public CLKDHEIJDPM CDMGOOGOCFI(RigidbodyEx MDLECLEGCKN, AHMFFPIAIMI EBNFOODJNOB, CBHDAMNBEEK JIPBFCNFKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "4")]
	public PLABINPGACE PNOIDJHKGNL(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "5")]
	public EAFFNCAKEFP DKNHAABOBLA(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "6")]
	public ABCGMCABKND BOJMCHLHJEG(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "7")]
	public POFFLBFPDEK GAOCCOLANBM(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "8")]
	public ICJNBHPDIDE PBKAMEBECJF(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "9")]
	public JGKGPPGHLCD NJODIGHMNAN(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "10")]
	public LJBNAHGNIGF DFHNHPANIKJ(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "11")]
	public PAJGJMAMMPE LDGBDIIPJGI(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "12")]
	public CDBBMABFKIC KMHDINKCAAO(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "13")]
	public CFGOPLPHBCD FMPPOLAPBEA(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0")]
	public IACBGDDNOPF FJEPFJEIOEF(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0")]
	public ONCGKNFNLKD LOOFENAFBPI(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0")]
	public OOAIEDLDNBE DIHMJPGINFA(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0")]
	public MPHKHPEPLND PLDHCNCGFOF(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0")]
	public GEHDLGLPDMH NHHKEFABNJB(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public BHOHJOAJCHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "14")]
	private IACBGDDNOPF IICFKMNLIHM(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "15")]
	private ONCGKNFNLKD GNPOAFEBCNB(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "16")]
	private OOAIEDLDNBE NKAKMEEJIKD(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "17")]
	private MPHKHPEPLND JEGNMKNCCGE(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "18")]
	private GEHDLGLPDMH CMDCDPKMMCF(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(DEBILJDLBCD), new string[] { })]
public class ADIDEPBCBBB : DEBILJDLBCD, NAFMJLPHDHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly DEBILJDLBCD JNDNNKAGDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly DEBILJDLBCD AGPEMLNJJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private KDOKNCAMHOF DDPODIECNPH;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private DEBILJDLBCD MGNDCMEKDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x76125A0", Offset = "0x7610DA0", VA = "0x1876125A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7612A90", Offset = "0x7611290", VA = "0x187612A90", Slot = "20")]
	public void InitReferences(IMGHKCMNGFB AFLKPGNHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7612E10", Offset = "0x7611610", VA = "0x187612E10", Slot = "4")]
	public PLABINPGACE PNOIDJHKGNL(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7612750", Offset = "0x7610F50", VA = "0x187612750", Slot = "5")]
	public EAFFNCAKEFP DKNHAABOBLA(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7612300", Offset = "0x7610B00", VA = "0x187612300", Slot = "6")]
	public ABCGMCABKND BOJMCHLHJEG(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7612940", Offset = "0x7611140", VA = "0x187612940", Slot = "7")]
	public POFFLBFPDEK GAOCCOLANBM(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7612D70", Offset = "0x7611570", VA = "0x187612D70", Slot = "8")]
	public ICJNBHPDIDE PBKAMEBECJF(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7612CD0", Offset = "0x76114D0", VA = "0x187612CD0", Slot = "9")]
	public JGKGPPGHLCD NJODIGHMNAN(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7612600", Offset = "0x7610E00", VA = "0x187612600", Slot = "10")]
	public LJBNAHGNIGF DFHNHPANIKJ(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7612C30", Offset = "0x7611430", VA = "0x187612C30", Slot = "11")]
	public PAJGJMAMMPE LDGBDIIPJGI(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7612B90", Offset = "0x7611390", VA = "0x187612B90", Slot = "12")]
	public CDBBMABFKIC KMHDINKCAAO(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x76128A0", Offset = "0x76110A0", VA = "0x1876128A0", Slot = "13")]
	public CFGOPLPHBCD FMPPOLAPBEA(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x76127F0", Offset = "0x7610FF0", VA = "0x1876127F0")]
	public IACBGDDNOPF FJEPFJEIOEF(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x76129E0", Offset = "0x76111E0", VA = "0x1876129E0")]
	public ONCGKNFNLKD LOOFENAFBPI(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x76126A0", Offset = "0x7610EA0", VA = "0x1876126A0")]
	public OOAIEDLDNBE DIHMJPGINFA(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7612AE0", Offset = "0x76112E0", VA = "0x187612AE0")]
	public MPHKHPEPLND PLDHCNCGFOF(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x76124F0", Offset = "0x7610CF0", VA = "0x1876124F0")]
	public GEHDLGLPDMH NHHKEFABNJB(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x76123A0", Offset = "0x7610BA0", VA = "0x1876123A0", Slot = "19")]
	public CLKDHEIJDPM CDMGOOGOCFI(RigidbodyEx MDLECLEGCKN, AHMFFPIAIMI EBNFOODJNOB, CBHDAMNBEEK JIPBFCNFKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7612EB0", Offset = "0x76116B0", VA = "0x187612EB0")]
	public ADIDEPBCBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x76127F0", Offset = "0x7610FF0", VA = "0x1876127F0", Slot = "14")]
	private IACBGDDNOPF IICFKMNLIHM(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x76129E0", Offset = "0x76111E0", VA = "0x1876129E0", Slot = "15")]
	private ONCGKNFNLKD GNPOAFEBCNB(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x76126A0", Offset = "0x7610EA0", VA = "0x1876126A0", Slot = "16")]
	private OOAIEDLDNBE NKAKMEEJIKD(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7612AE0", Offset = "0x76112E0", VA = "0x187612AE0", Slot = "17")]
	private MPHKHPEPLND JEGNMKNCCGE(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x76124F0", Offset = "0x7610CF0", VA = "0x1876124F0", Slot = "18")]
	private GEHDLGLPDMH CMDCDPKMMCF(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HDBDLJMJLPM : PLABINPGACE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKLHNGDLCJI(CLKDHEIJDPM MDLECLEGCKN);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNBAPNNPFJG(CLKDHEIJDPM MDLECLEGCKN);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMAPMAGFAHI(CLKDHEIJDPM KACFHLBGDBO);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LPPIMNALFPP(CLKDHEIJDPM KACFHLBGDBO);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NILBNDPOGFK : ABCGMCABKND
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	EFAGCHENKHK<CLKDHEIJDPM> DFBPKIGDPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	CLKDHEIJDPM CMIEDBKEKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BKCKIDPNKNF : MPHKHPEPLND
{
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) LBKGCOHJHDO(Rigidbody LEAHMGMBDPL);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface GDNLGLAODJE : ONCGKNFNLKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PhotonView CKPICBEOPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class PDKKJBLAIAJ : CDBBMABFKIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly FCIHPCIEKBE MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode JEFBMJDDAGA;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody HIPNKAOEIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7628840", Offset = "0x7627040", VA = "0x187628840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode LNPCAGOAEAP
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7628AE0", Offset = "0x76272E0", VA = "0x187628AE0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7628A70", Offset = "0x7627270", VA = "0x187628A70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7627AA0", Offset = "0x76262A0", VA = "0x187627AA0")]
	public PDKKJBLAIAJ(CLKDHEIJDPM MDLECLEGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7628BF0", Offset = "0x76273F0", VA = "0x187628BF0", Slot = "6")]
	public void JNLOKBHKNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x7628890", Offset = "0x7627090", VA = "0x187628890", Slot = "9")]
	public void CGANLJFHJEG(Rigidbody JPHPMPANJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7628E30", Offset = "0x7627630", VA = "0x187628E30", Slot = "7")]
	public void NFPIELKJPMP(bool IBKNBDHPHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7628D00", Offset = "0x7627500", VA = "0x187628D00", Slot = "8")]
	public void KIOBEOGHIIK(bool IBKNBDHPHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7628910", Offset = "0x7627110", VA = "0x187628910", Slot = "10")]
	public bool DEDKHLCDJDI(Vector3 NGBCGJCGHJG, [Out] RaycastHit PFJHGCCOMGD, float HFFBJNAMAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7628D10", Offset = "0x7627510", VA = "0x187628D10")]
	private void NCHLNFEHPPI(bool IBKNBDHPHIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NCOIHABHNLD : JGKGPPGHLCD, IDisposable, OPLCNBEPAIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FCIHPCIEKBE MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private FMLELDCHGMI HACGNDBBBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EJEKKKILJCH BPPOAOLJAFG;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public FMLELDCHGMI FEGAPJIGNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7627280", Offset = "0x7625A80", VA = "0x187627280", Slot = "6")]
		get
		{
			return default(FMLELDCHGMI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7627790", Offset = "0x7625F90", VA = "0x187627790", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform CFJPOHLNGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x21BFFD0", Offset = "0x21BE7D0", VA = "0x1821BFFD0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<HNNBIECDFEH, HNNBIECDFEH> PENDLLPMKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x76276E0", Offset = "0x7625EE0", VA = "0x1876276E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x76273C0", Offset = "0x7625BC0", VA = "0x1876273C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7627860", Offset = "0x7626060", VA = "0x187627860")]
	public NCOIHABHNLD(CLKDHEIJDPM MDLECLEGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7627470", Offset = "0x7625C70", VA = "0x187627470", Slot = "8")]
	public void JNLOKBHKNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7627230", Offset = "0x7625A30", VA = "0x187627230", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0xD48F70", Offset = "0xD47770", VA = "0x180D48F70", Slot = "11")]
	private void NBCMEJDJNHK(HNNBIECDFEH HGJGJDCJCFP, HNNBIECDFEH AAHIGDGBAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "12")]
	private void MIJIFBJNEBI(bool EMGABJHBLDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LJBBBGEBKDC : DEBILJDLBCD
{
	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7627030", Offset = "0x7625830", VA = "0x187627030", Slot = "4")]
	public PLABINPGACE PNOIDJHKGNL(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7626650", Offset = "0x7624E50", VA = "0x187626650", Slot = "5")]
	public EAFFNCAKEFP DKNHAABOBLA(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x76260A0", Offset = "0x76248A0", VA = "0x1876260A0", Slot = "6")]
	public ABCGMCABKND BOJMCHLHJEG(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7626970", Offset = "0x7625170", VA = "0x187626970", Slot = "7")]
	public POFFLBFPDEK GAOCCOLANBM(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7626F60", Offset = "0x7625760", VA = "0x187626F60", Slot = "8")]
	public ICJNBHPDIDE PBKAMEBECJF(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7626E90", Offset = "0x7625690", VA = "0x187626E90", Slot = "9")]
	public JGKGPPGHLCD NJODIGHMNAN(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7626400", Offset = "0x7624C00", VA = "0x187626400", Slot = "10")]
	public LJBNAHGNIGF DFHNHPANIKJ(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7626DD0", Offset = "0x76255D0", VA = "0x187626DD0", Slot = "11")]
	public PAJGJMAMMPE LDGBDIIPJGI(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7626D10", Offset = "0x7625510", VA = "0x187626D10", Slot = "12")]
	public CDBBMABFKIC KMHDINKCAAO(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x76268B0", Offset = "0x76250B0", VA = "0x1876268B0", Slot = "13")]
	public CFGOPLPHBCD FMPPOLAPBEA(CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7626770", Offset = "0x7624F70", VA = "0x187626770")]
	public IACBGDDNOPF FJEPFJEIOEF(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x76269F0", Offset = "0x76251F0", VA = "0x1876269F0")]
	public ONCGKNFNLKD LOOFENAFBPI(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7626520", Offset = "0x7624D20", VA = "0x187626520")]
	public OOAIEDLDNBE DIHMJPGINFA(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7626B80", Offset = "0x7625380", VA = "0x187626B80")]
	public MPHKHPEPLND PLDHCNCGFOF(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7626320", Offset = "0x7624B20", VA = "0x187626320")]
	public GEHDLGLPDMH NHHKEFABNJB(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x76261D0", Offset = "0x76249D0", VA = "0x1876261D0", Slot = "19")]
	public CLKDHEIJDPM CDMGOOGOCFI(RigidbodyEx MDLECLEGCKN, AHMFFPIAIMI EBNFOODJNOB, CBHDAMNBEEK JIPBFCNFKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public LJBBBGEBKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7626770", Offset = "0x7624F70", VA = "0x187626770", Slot = "14")]
	private IACBGDDNOPF IICFKMNLIHM(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x76269F0", Offset = "0x76251F0", VA = "0x1876269F0", Slot = "15")]
	private ONCGKNFNLKD GNPOAFEBCNB(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7626520", Offset = "0x7624D20", VA = "0x187626520", Slot = "16")]
	private OOAIEDLDNBE NKAKMEEJIKD(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7626B80", Offset = "0x7625380", VA = "0x187626B80", Slot = "17")]
	private MPHKHPEPLND JEGNMKNCCGE(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7626320", Offset = "0x7624B20", VA = "0x187626320", Slot = "18")]
	private GEHDLGLPDMH CMDCDPKMMCF(CLKDHEIJDPM CLCEHBDJMEK, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class PCBFABDBCPB : PAJGJMAMMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly FCIHPCIEKBE MDLECLEGCKN;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody HIPNKAOEIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7628840", Offset = "0x7627040", VA = "0x187628840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool HBGLEDGEAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7628050", Offset = "0x7626850", VA = "0x187628050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool LGOLHEAHKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7614F00", Offset = "0x7613700", VA = "0x187614F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private CLKDHEIJDPM MHMOKMJDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x76287E0", Offset = "0x7626FE0", VA = "0x1876287E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7627AA0", Offset = "0x76262A0", VA = "0x187627AA0")]
	public PCBFABDBCPB(CLKDHEIJDPM MDLECLEGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x7627B30", Offset = "0x7626330", VA = "0x187627B30", Slot = "4")]
	public void AKAJMJMIOEI(Vector3 KHDIFEIJFDB, ForceMode JJAPHGHHBJE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x7628580", Offset = "0x7626D80", VA = "0x187628580")]
	private void KFGICPCHCNL(Vector3 KHDIFEIJFDB, ForceMode JJAPHGHHBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7628300", Offset = "0x7626B00", VA = "0x187628300", Slot = "5")]
	public void IJABKPPHMOK(Vector3 KHDIFEIJFDB, Vector3 BALIIBCILHH, ForceMode JJAPHGHHBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7627C90", Offset = "0x7626490", VA = "0x187627C90", Slot = "6")]
	public void BCHPEGFCLNP(Vector3 OKFDNEPALDE, ForceMode JJAPHGHHBJE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7627DF0", Offset = "0x76265F0", VA = "0x187627DF0")]
	private void ENKJIAPCIGL(Vector3 OKFDNEPALDE, ForceMode JJAPHGHHBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x76280A0", Offset = "0x76268A0", VA = "0x1876280A0", Slot = "7")]
	public void HFDDEEJOACG(Vector3 OKFDNEPALDE, ForceMode JJAPHGHHBJE = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class OOGGBHOPAFH : CFGOPLPHBCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly FCIHPCIEKBE MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool GFPFECNLHAH;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool FKDPMNMNENH
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9575D0", Offset = "0x955DD0", VA = "0x1809575D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x76278F0", Offset = "0x76260F0", VA = "0x1876278F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7627AA0", Offset = "0x76262A0", VA = "0x187627AA0")]
	public OOGGBHOPAFH(CLKDHEIJDPM MDLECLEGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7627A00", Offset = "0x7626200", VA = "0x187627A00", Slot = "6")]
	public void CGANLJFHJEG(Rigidbody JPHPMPANJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7627A30", Offset = "0x7626230", VA = "0x187627A30", Slot = "7")]
	public void POJDBKFNNLH(Rigidbody JPHPMPANJGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class BAKGFIGHJKF : HDBDLJMJLPM, PLABINPGACE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly CLKDHEIJDPM MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<CLKDHEIJDPM> CAJGHKGIDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private CLKDHEIJDPM KAMAKIBPPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private CLKDHEIJDPM NCCLECGLDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform BOIKOFHAIGN;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform KEKDMLOCEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x76147D0", Offset = "0x7612FD0", VA = "0x1876147D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public CLKDHEIJDPM MHMOKMJDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8B7580", Offset = "0x8B5D80", VA = "0x1808B7580", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x76145C0", Offset = "0x7612DC0", VA = "0x1876145C0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public CLKDHEIJDPM JJAKCGIGEEC
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7530", Offset = "0x8B5D30", VA = "0x1808B7530", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<CLKDHEIJDPM> KMBJOCPEJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7560", Offset = "0x8B5D60", VA = "0x1808B7560", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event KJOJIKKICPM AOADHMFLHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7613150", Offset = "0x7611950", VA = "0x187613150", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x76142A0", Offset = "0x7612AA0", VA = "0x1876142A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event KJOJIKKICPM GJBKPELNFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7614870", Offset = "0x7613070", VA = "0x187614870", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7613C50", Offset = "0x7612450", VA = "0x187613C50", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event LKNNFBAGKCD KGNLKJOGCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7612F60", Offset = "0x7611760", VA = "0x187612F60", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x76149C0", Offset = "0x76131C0", VA = "0x1876149C0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action KNBEMDILBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7613950", Offset = "0x7612150", VA = "0x187613950", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7613B00", Offset = "0x7612300", VA = "0x187613B00", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action GBNPJDIEBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7613000", Offset = "0x7611800", VA = "0x187613000", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x76131F0", Offset = "0x76119F0", VA = "0x1876131F0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<CLKDHEIJDPM> PIBJCODKOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7614680", Offset = "0x7612E80", VA = "0x187614680", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x76130A0", Offset = "0x76118A0", VA = "0x1876130A0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<CLKDHEIJDPM> CMJFEHONOPD
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7613D90", Offset = "0x7612590", VA = "0x187613D90", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7613BA0", Offset = "0x76123A0", VA = "0x187613BA0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action IAAKGCHDHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7614A60", Offset = "0x7613260", VA = "0x187614A60", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7613810", Offset = "0x7612010", VA = "0x187613810", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<CLKDHEIJDPM> HPLIPKFMLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7614910", Offset = "0x7613110", VA = "0x187614910", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x76145D0", Offset = "0x7612DD0", VA = "0x1876145D0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x7614D70", Offset = "0x7613570", VA = "0x187614D70")]
	public BAKGFIGHJKF(CLKDHEIJDPM MDLECLEGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x76138B0", Offset = "0x76120B0", VA = "0x1876138B0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7613290", Offset = "0x7611A90", VA = "0x187613290", Slot = "30")]
	public void DDCCBIGAKMA(CLKDHEIJDPM FABMJJHDKOA, bool NCJCCAJKLJN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x7614B00", Offset = "0x7613300", VA = "0x187614B00", Slot = "6")]
	public void PMAPMAGFAHI(CLKDHEIJDPM KACFHLBGDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7614340", Offset = "0x7612B40", VA = "0x187614340", Slot = "7")]
	public void LPPIMNALFPP(CLKDHEIJDPM KACFHLBGDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x76139F0", Offset = "0x76121F0", VA = "0x1876139F0", Slot = "4")]
	public void EKLHNGDLCJI(CLKDHEIJDPM MDLECLEGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7614730", Offset = "0x7612F30", VA = "0x187614730", Slot = "5")]
	public void NNBAPNNPFJG(CLKDHEIJDPM MDLECLEGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7613CF0", Offset = "0x76124F0", VA = "0x187613CF0")]
	private void GPGBGCECJBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7614830", Offset = "0x7613030", VA = "0x187614830")]
	private void OLOBBONFAKC(CLKDHEIJDPM KACFHLBGDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7614160", Offset = "0x7612960", VA = "0x187614160")]
	private void ICPBKIENDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7613E40", Offset = "0x7612640", VA = "0x187613E40")]
	private void HDCBPLEPLOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7613F70", Offset = "0x7612770", VA = "0x187613F70")]
	private void HHFLOPDPMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x76140A0", Offset = "0x76128A0", VA = "0x1876140A0")]
	[CompilerGenerated]
	private object HMBHICEMJJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class IGBLMPLAOMB
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7625A20", Offset = "0x7624220", VA = "0x187625A20")]
	public static HDBDLJMJLPM FLDCGOPMPGN(this CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class GINNPKPINCP : NILBNDPOGFK, ABCGMCABKND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly FCIHPCIEKBE MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly EFAGCHENKHK<CLKDHEIJDPM> DFGBGKCNOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool LDMIHJHMDFE;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public EFAGCHENKHK<CLKDHEIJDPM> DFBPKIGDPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 PCNPNEJGBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x761E860", Offset = "0x761D060", VA = "0x18761E860", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 GDDNELAPFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x761E890", Offset = "0x761D090", VA = "0x18761E890", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 LBNNPBIDFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x761EB90", Offset = "0x761D390", VA = "0x18761EB90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public CLKDHEIJDPM CMIEDBKEKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x761F470", Offset = "0x761DC70", VA = "0x18761F470", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x761F520", Offset = "0x761DD20", VA = "0x18761F520")]
	public GINNPKPINCP(CLKDHEIJDPM MDLECLEGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x761F060", Offset = "0x761D860", VA = "0x18761F060", Slot = "8")]
	public void NIHMGDBGCFE(CLKDHEIJDPM NCCLECGLDAO, object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x761EC70", Offset = "0x761D470", VA = "0x18761EC70", Slot = "9")]
	public void IPKDBAHAKIA(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x761F0D0", Offset = "0x761D8D0", VA = "0x18761F0D0")]
	private Vector3 PCEMFPJGPLD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x761ECD0", Offset = "0x761D4D0", VA = "0x18761ECD0")]
	private void KGPJIBDCCGK(CLKDHEIJDPM JDEKIMLILMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class PFAHJPHMGPA
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7628E40", Offset = "0x7627640", VA = "0x187628E40")]
	public static NILBNDPOGFK PPHGKOOPLFG(this CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class HKMDDAJCHHP : BKCKIDPNKNF, MPHKHPEPLND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly FCIHPCIEKBE MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 IFKGFAGLFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 HEHDOAGPNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float FBJKNDPHEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float KKCIEOHEGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 OMPMONJIIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? OEHAFFDNIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? CCMEOENCNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool FDILODGLGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool GHAGKDADEON;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 BHGBHOLOBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x114A520", Offset = "0x1148D20", VA = "0x18114A520", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x76240B0", Offset = "0x76228B0", VA = "0x1876240B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 OCMLFPAFCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7623E20", Offset = "0x7622620", VA = "0x187623E20", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float OBICABEGEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x924CE0", Offset = "0x9234E0", VA = "0x180924CE0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7623430", Offset = "0x7621C30", VA = "0x187623430")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float IKNNFHJBACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x924CA0", Offset = "0x9234A0", VA = "0x180924CA0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7623D70", Offset = "0x7622570", VA = "0x187623D70", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 PJNHHCLFIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7625550", Offset = "0x7623D50", VA = "0x187625550", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion KLOLJBMEMDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x76231D0", Offset = "0x76219D0", VA = "0x1876231D0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody HIPNKAOEIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7617BA0", Offset = "0x76163A0", VA = "0x187617BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event KJOJIKKICPM MLOFENAFKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x76235E0", Offset = "0x7621DE0", VA = "0x1876235E0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7623540", Offset = "0x7621D40", VA = "0x187623540", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x76258C0", Offset = "0x76240C0", VA = "0x1876258C0")]
	public HKMDDAJCHHP(CLKDHEIJDPM MDLECLEGCKN, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7625200", Offset = "0x7623A00", VA = "0x187625200", Slot = "17")]
	public void LMHMCEKKFIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7623350", Offset = "0x7621B50", VA = "0x187623350", Slot = "16")]
	public void CNJBBDKPIKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x76230F0", Offset = "0x76218F0", VA = "0x1876230F0", Slot = "19")]
	public void CGANLJFHJEG(Rigidbody JPHPMPANJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x76256E0", Offset = "0x7623EE0", VA = "0x1876256E0", Slot = "20")]
	public void POJDBKFNNLH(Rigidbody JPHPMPANJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x76253B0", Offset = "0x7623BB0", VA = "0x1876253B0", Slot = "18")]
	public void MJEMIAPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7623680", Offset = "0x7621E80", VA = "0x187623680", Slot = "21")]
	public void GFFDCONBCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x76240B0", Offset = "0x76228B0", VA = "0x1876240B0")]
	private void KDNEBKDJIHP(Vector3 INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7623C80", Offset = "0x7622480", VA = "0x187623C80")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 GMMOMDLMDBA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7623430", Offset = "0x7621C30", VA = "0x187623430")]
	private void COJILDNFABN(float INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7623D70", Offset = "0x7622570", VA = "0x187623D70")]
	private void PIEMCJBMNHF(float INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7623F10", Offset = "0x7622710", VA = "0x187623F10")]
	private Vector3 IOPCPFPPMGN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7624FD0", Offset = "0x76237D0", VA = "0x187624FD0", Slot = "15")]
	public void LIEGMGMENOM((Quaternion rot, Vector3 moments) GONNOPNNDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7623B00", Offset = "0x7622300", VA = "0x187623B00")]
	private Quaternion GKMMMKIOOIG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7624F00", Offset = "0x7623700", VA = "0x187624F00")]
	public void LBKGCOHJHDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7624160", Offset = "0x7622960", VA = "0x187624160", Slot = "4")]
	public (float, Vector3) LBKGCOHJHDO(Rigidbody LEAHMGMBDPL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class KPKLNNNGEFO
{
	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7625FE0", Offset = "0x76247E0", VA = "0x187625FE0")]
	public static BKCKIDPNKNF ACOEIOMKCDM(this CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class DKHBEBOCHAE : OOAIEDLDNBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly FCIHPCIEKBE MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly COKMJHAKPPF EGNKKLHDDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly NEDCKNNIBBL FHHJIDAFGDE;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool HDPILLNPAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x12E9560", Offset = "0x12E7D60", VA = "0x1812E9560", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public NEDCKNNIBBL BKHKCOOPHAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x958980", Offset = "0x957180", VA = "0x180958980", Slot = "11")]
		get
		{
			return default(NEDCKNNIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7616B00", Offset = "0x7615300", VA = "0x187616B00")]
	public DKHBEBOCHAE(CLKDHEIJDPM MDLECLEGCKN, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7616730", Offset = "0x7614F30", VA = "0x187616730", Slot = "4")]
	public void JNLOKBHKNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7616A60", Offset = "0x7615260", VA = "0x187616A60")]
	private bool PCNOIIGBANE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x76164D0", Offset = "0x7614CD0", VA = "0x1876164D0", Slot = "5")]
	public void ALPACOOENCM(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7616500", Offset = "0x7614D00", VA = "0x187616500", Slot = "6")]
	public void CCGKEAGMCGN(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7616920", Offset = "0x7615120", VA = "0x187616920", Slot = "9")]
	public void KLCJHNMINBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7616800", Offset = "0x7615000", VA = "0x187616800")]
	private void KHJJFCKDGHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x76165B0", Offset = "0x7614DB0", VA = "0x1876165B0")]
	private void JMHFFFPNOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7616570", Offset = "0x7614D70", VA = "0x187616570", Slot = "8")]
	public void GFGNJDPIHOO(CLKDHEIJDPM MDLECLEGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7616530", Offset = "0x7614D30", VA = "0x187616530", Slot = "7")]
	public void GDCHIIMBBFP(CLKDHEIJDPM MDLECLEGCKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class EBKHJMKFDIH : LJBNAHGNIGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly FCIHPCIEKBE MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly COKMJHAKPPF MAFMMPMHPCM;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool HBGLEDGEAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7616D20", Offset = "0x7615520", VA = "0x187616D20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event KJOJIKKICPM DKJPADICAID
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7616DD0", Offset = "0x76155D0", VA = "0x187616DD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7616C80", Offset = "0x7615480", VA = "0x187616C80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7617010", Offset = "0x7615810", VA = "0x187617010")]
	public EBKHJMKFDIH(CLKDHEIJDPM MDLECLEGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7616E80", Offset = "0x7615680", VA = "0x187616E80", Slot = "7")]
	public void LHOMBJDILPL(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x7616E70", Offset = "0x7615670", VA = "0x187616E70", Slot = "8")]
	public void JECKHECCMHJ(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7616E90", Offset = "0x7615690", VA = "0x187616E90", Slot = "9")]
	public void NGILCALIHMA(object DJIMHLGHFGI, bool NJPKHDOCLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7616FA0", Offset = "0x76157A0", VA = "0x187616FA0", Slot = "12")]
	public void OBFFLOCBMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7616C00", Offset = "0x7615400", VA = "0x187616C00", Slot = "10")]
	public void CGANLJFHJEG(Rigidbody PFJJBBEKFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7616FE0", Offset = "0x76157E0", VA = "0x187616FE0", Slot = "11")]
	public void POJDBKFNNLH(Rigidbody JPHPMPANJGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class DCLFEGPAFNA : GDNLGLAODJE, ONCGKNFNLKD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly FCIHPCIEKBE MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PhotonView BKKJPNGFNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool CAKCGFKLGJF;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView CKPICBEOPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool FCLMMMCPFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7615F00", Offset = "0x7614700", VA = "0x187615F00", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool KFLDOLPOEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA02A00", Offset = "0xA01200", VA = "0x180A02A00", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event KJOJIKKICPM KMAOLGOKLEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x76162E0", Offset = "0x7614AE0", VA = "0x1876162E0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x76157E0", Offset = "0x7613FE0", VA = "0x1876157E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7616380", Offset = "0x7614B80", VA = "0x187616380")]
	public DCLFEGPAFNA(CLKDHEIJDPM MDLECLEGCKN, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7615DD0", Offset = "0x76145D0", VA = "0x187615DD0", Slot = "9")]
	public void JNLOKBHKNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7615880", Offset = "0x7614080", VA = "0x187615880", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7615C60", Offset = "0x7614460", VA = "0x187615C60", Slot = "10")]
	public void IKAKOOGGHFH(CLKDHEIJDPM NCCLECGLDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7615980", Offset = "0x7614180", VA = "0x187615980", Slot = "11")]
	public void EPNFOJIHOMG(CLKDHEIJDPM NCCLECGLDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7615AF0", Offset = "0x76142F0", VA = "0x187615AF0")]
	private void IABFCKJMHCC(PhotonView LIJBNEKNEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7616190", Offset = "0x7614990", VA = "0x187616190")]
	private void NJHAPOJNAPG(LDJJPBBNOHE JEABHGDDCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7615F20", Offset = "0x7614720", VA = "0x187615F20")]
	private void NCBONHHIDHL(PhotonView PMAHJPGGPLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class EMFMFCIOJFH
{
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7617100", Offset = "0x7615900", VA = "0x187617100")]
	public static GDNLGLAODJE ELCGNCOMPFE(this CLKDHEIJDPM CLCEHBDJMEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class IKNGJGNHLEJ : GEHDLGLPDMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly FCIHPCIEKBE MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints LFOBAMAPEEO;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool OIDKFEONKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x95C5E0", Offset = "0x95ADE0", VA = "0x18095C5E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x95CF30", Offset = "0x95B730", VA = "0x18095CF30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool KOJKNHJKKBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x95CC30", Offset = "0x95B430", VA = "0x18095CC30", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x95CC20", Offset = "0x95B420", VA = "0x18095CC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints DHEIMOODHNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BC040", Offset = "0x8BA840", VA = "0x1808BC040", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7625DE0", Offset = "0x76245E0", VA = "0x187625DE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7625F40", Offset = "0x7624740", VA = "0x187625F40")]
	public IKNGJGNHLEJ(CLKDHEIJDPM MDLECLEGCKN, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7625DB0", Offset = "0x76245B0", VA = "0x187625DB0", Slot = "9")]
	public void CGANLJFHJEG(Rigidbody JPHPMPANJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7625F10", Offset = "0x7624710", VA = "0x187625F10", Slot = "10")]
	public void POJDBKFNNLH(Rigidbody JPHPMPANJGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class IGOCODMIEAB : POFFLBFPDEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly CLKDHEIJDPM MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float IFDDAPCJLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float GEIDIHCKBLF;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float KNNCHAJPCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xB07540", Offset = "0xB05D40", VA = "0x180B07540", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7625AE0", Offset = "0x76242E0", VA = "0x187625AE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float MPDJELAGIJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x96C580", Offset = "0x96AD80", VA = "0x18096C580", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7625C00", Offset = "0x7624400", VA = "0x187625C00", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7625D70", Offset = "0x7624570", VA = "0x187625D70")]
	public IGOCODMIEAB(CLKDHEIJDPM MDLECLEGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7625BB0", Offset = "0x76243B0", VA = "0x187625BB0", Slot = "8")]
	public void CGANLJFHJEG(Rigidbody JPHPMPANJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7625CD0", Offset = "0x76244D0", VA = "0x187625CD0", Slot = "9")]
	public void POJDBKFNNLH(Rigidbody JPHPMPANJGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class FBDOKCADPHC : ICJNBHPDIDE
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly FICDJCDJOAA MNJPNIAMOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly FCIHPCIEKBE MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool ODLDCOGFFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool FHKKODAHLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int FOMFIFJDKID;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody HIPNKAOEIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7617BA0", Offset = "0x76163A0", VA = "0x187617BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool PGLHKAPDGJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7617580", Offset = "0x7615D80", VA = "0x187617580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CLKDHEIJDPM MHMOKMJDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7617B40", Offset = "0x7616340", VA = "0x187617B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool LGOLHEAHKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7617260", Offset = "0x7615A60", VA = "0x187617260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event KJOJIKKICPM AIDPNAIBMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7617BF0", Offset = "0x76163F0", VA = "0x187617BF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x76171C0", Offset = "0x76159C0", VA = "0x1876171C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7617DC0", Offset = "0x76165C0", VA = "0x187617DC0")]
	public FBDOKCADPHC(CLKDHEIJDPM MDLECLEGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7617960", Offset = "0x7616160", VA = "0x187617960", Slot = "6")]
	public void JNLOKBHKNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x76177F0", Offset = "0x7615FF0", VA = "0x1876177F0", Slot = "8")]
	public void HBFMEHMOEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x76179F0", Offset = "0x76161F0", VA = "0x1876179F0", Slot = "7")]
	public bool KJJAHCAGAMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7617800", Offset = "0x7616000", VA = "0x187617800", Slot = "9")]
	public void IGAKIOOAGHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7617C90", Offset = "0x7616490", VA = "0x187617C90", Slot = "13")]
	public void OBKPNCKIMEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x76172C0", Offset = "0x7615AC0", VA = "0x1876172C0", Slot = "12")]
	public void DLONNFJPLNP(bool OHAPPNDMKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7617780", Offset = "0x7615F80", VA = "0x187617780", Slot = "10")]
	public bool GBLOBMLLBII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x76178A0", Offset = "0x76160A0", VA = "0x1876178A0", Slot = "11")]
	public bool IOMAAPDMCGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x76175A0", Offset = "0x7615DA0", VA = "0x1876175A0")]
	private bool FIGHPGFLECI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x76173F0", Offset = "0x7615BF0", VA = "0x1876173F0")]
	private void EOLFBHCBHFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class CBMFMINOOGF : IACBGDDNOPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly FCIHPCIEKBE MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly COKMJHAKPPF NAEFLFFBEII;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody HIPNKAOEIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8B51E0", Offset = "0x8B39E0", VA = "0x1808B51E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool LGOLHEAHKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7614F00", Offset = "0x7613700", VA = "0x187614F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool ADANHCHBNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x12E9560", Offset = "0x12E7D60", VA = "0x1812E9560", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x76156D0", Offset = "0x7613ED0", VA = "0x1876156D0")]
	public CBMFMINOOGF(CLKDHEIJDPM MDLECLEGCKN, [In] AHMFFPIAIMI EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7615480", Offset = "0x7613C80", VA = "0x187615480", Slot = "5")]
	public void JNLOKBHKNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7614ED0", Offset = "0x76136D0", VA = "0x187614ED0", Slot = "7")]
	public void ACNPMEFFPLJ(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x76156A0", Offset = "0x7613EA0", VA = "0x1876156A0", Slot = "8")]
	public void NOMEBGPDCMB(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7615150", Offset = "0x7613950", VA = "0x187615150", Slot = "9")]
	public void HCBDEIJKBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7614F60", Offset = "0x7613760", VA = "0x187614F60", Slot = "10")]
	public void GEDCNFGPJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7615520", Offset = "0x7613D20", VA = "0x187615520", Slot = "11")]
	public void NLBMGJEFMJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class GNGKACNNNMG : EAFFNCAKEFP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly FCIHPCIEKBE MDLECLEGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly COKMJHAKPPF CGLMEICEDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float HFILCMMNBNC;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public JBNIKIOLDLF KNCLLFKNBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8BE300", Offset = "0x8BCB00", VA = "0x1808BE300", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public MBMIBMKAFBA OCKFMKMEPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8BE310", Offset = "0x8BCB10", VA = "0x1808BE310", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 LBNNPBIDFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x7621960", Offset = "0x7620160", VA = "0x187621960", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x76218A0", Offset = "0x76200A0", VA = "0x1876218A0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 KEJINJCIGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x76201F0", Offset = "0x761E9F0", VA = "0x1876201F0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x76203D0", Offset = "0x761EBD0", VA = "0x1876203D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 DBHPKKICEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7622270", Offset = "0x7620A70", VA = "0x187622270", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7621DA0", Offset = "0x76205A0", VA = "0x187621DA0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 EBKJJPKMODE
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7621170", Offset = "0x761F970", VA = "0x187621170", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7622820", Offset = "0x7621020", VA = "0x187622820", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float MGBPLPCNCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xC155F0", Offset = "0xC13DF0", VA = "0x180C155F0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7620F80", Offset = "0x761F780", VA = "0x187620F80", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool JOJNGDGIGFH
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1C572B0", Offset = "0x1C55AB0", VA = "0x181C572B0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private PAJGJMAMMPE GCFINJKHCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D540", Offset = "0x6D6BD40", VA = "0x186D6D540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool PGLHKAPDGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7621150", Offset = "0x761F950", VA = "0x187621150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7622CD0", Offset = "0x76214D0", VA = "0x187622CD0")]
	public GNGKACNNNMG(CLKDHEIJDPM MDLECLEGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x761FFB0", Offset = "0x761E7B0", VA = "0x18761FFB0", Slot = "19")]
	public void JNLOKBHKNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7621090", Offset = "0x761F890", VA = "0x187621090", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7620400", Offset = "0x761EC00", VA = "0x187620400", Slot = "28")]
	public void CGANLJFHJEG(Rigidbody JPHPMPANJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x10FC0E0", Offset = "0x10FA8E0", VA = "0x1810FC0E0", Slot = "20")]
	public void IABKNCINIIH(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x10FC2D0", Offset = "0x10FAAD0", VA = "0x1810FC2D0", Slot = "30")]
	public void DCOIGLJGGBG(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x761FDD0", Offset = "0x761E5D0", VA = "0x18761FDD0", Slot = "35")]
	public Vector3 AHNJJDLLBIM(Vector3 PCALFOEEPAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7622000", Offset = "0x7620800", VA = "0x187622000", Slot = "34")]
	public Vector3 JPABHDFFLJA(Vector3 EPGELPCMLDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x761FFB0", Offset = "0x761E7B0", VA = "0x18761FFB0", Slot = "27")]
	public void BIJGCPALBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7620530", Offset = "0x761ED30", VA = "0x187620530", Slot = "25")]
	public void DDMMBAMAOJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x76210F0", Offset = "0x761F8F0", VA = "0x1876210F0", Slot = "24")]
	public void EJCIOEBEFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7620720", Offset = "0x761EF20", VA = "0x187620720", Slot = "33")]
	public void DICCAJJNCPA(Vector3 EDONNCIELGP, Vector3 HCJLGMKALKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7620370", Offset = "0x761EB70", VA = "0x187620370", Slot = "32")]
	public void CCJJCFAJKPP(Vector3 LPLJFCLGJKM, Vector3 HOPDBNLFMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7620960", Offset = "0x761F160", VA = "0x187620960", Slot = "31")]
	public void DIFBBCFEJIC(Vector3 JKCDJCOBNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x761F620", Offset = "0x761DE20", VA = "0x18761F620", Slot = "22")]
	public void AABHOIJCEPE(CAGMBFKGEMC GHLELCMGNEE, Vector3 JPHOJJCHKHD, float KANLLIFFDJB, float NDNEEMGLJDD = 8f, float PEFEPHIPIEA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7621B20", Offset = "0x7620320", VA = "0x187621B20", Slot = "21")]
	public void IMIONDKKMCP(AOIBDNAKBNG INFBLAPINDA, Vector3 JDHNCLHOBJL, float JHKMJBBILBB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7622430", Offset = "0x7620C30", VA = "0x187622430", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void NGPHDFNAKAB(AOIBDNAKBNG INFBLAPINDA, Vector3 OJEGGOKKPLF, float MHNMFOIOAKI = 7f, float HGDNLAPNDME = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x122A990", Offset = "0x1229190", VA = "0x18122A990")]
	private static void KBAMIFLCHMM(Vector3 KAHKKJLHEEJ, Vector3 LHHMNOGMEMF, [Out] Vector3 PMADHGODOOJ, [Out] Vector3 OMCHKDBHGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x761FCF0", Offset = "0x761E4F0", VA = "0x18761FCF0", Slot = "29")]
	public Vector3 AFGFJFHNODC(Vector3 KAHKKJLHEEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7620590", Offset = "0x761ED90", VA = "0x187620590", Slot = "26")]
	public void DFKCKFJCDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7620F80", Offset = "0x761F780", VA = "0x187620F80")]
	private void HKEFCFJBFBH(float INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7621E60", Offset = "0x7620660", VA = "0x187621E60")]
	private void JFPLAFFCHOA(Vector3 JDHNCLHOBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x761FB70", Offset = "0x761E370", VA = "0x18761FB70")]
	private Vector3 ADNNHKBPLHG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7620B00", Offset = "0x761F300", VA = "0x187620B00")]
	private void DMMJAHEBPMO(Vector3 EPGELPCMLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7620060", Offset = "0x761E860", VA = "0x187620060")]
	private Vector3 CBDLJKGGLHC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7622850", Offset = "0x7621050", VA = "0x187622850")]
	private void OCCMPMJEFLH(Vector3 INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7621300", Offset = "0x761FB00", VA = "0x187621300")]
	private void HIFCFMBFGNC(Vector3 EPGELPCMLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x76221C0", Offset = "0x76209C0", VA = "0x1876221C0")]
	private void KDBIMPBNEDI()
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
