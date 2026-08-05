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
	public class LogRegistrationIndex : IGKFPLMKJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72E5DA0", Offset = "0x72E49A0", VA = "0x1872E5DA0", Slot = "4")]
		public override void PEGPHNFMEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
			[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x17502F0", Offset = "0x174EEF0", VA = "0x1817502F0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72F1460", Offset = "0x72F0060", VA = "0x1872F1460")]
		private void MNIOJKDAHNG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72F1770", Offset = "0x72F0370", VA = "0x1872F1770", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72F17D0", Offset = "0x72F03D0", VA = "0x1872F17D0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, FKDGABLNLMI, PJNLDGODMKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly BNHLDIHMNLF JJEAGKLBDJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool MNJBPNKKFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private DFINIIBCCEP BJLEJGMIJDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[KMGHLJENBIC(KOFDDAAAPEO.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[KMGHLJENBIC(KOFDDAAAPEO.SelfAndParent, true, false, false)]
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
		private EGPFJKHDCKA physicsInterpolation;

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
		private Transform EHGNFGDCBEP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal DFINIIBCCEP CKILFKBLILK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x72ECEA0", Offset = "0x72EBAA0", VA = "0x1872ECEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private DFINIIBCCEP OBELFAHGHJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MHCECFLHJPP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x72EE930", Offset = "0x72ED530", VA = "0x1872EE930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx HHMLIFCHKIA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x72EEC90", Offset = "0x72ED890", VA = "0x1872EEC90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx JAFALLCEFOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x72EEBD0", Offset = "0x72ED7D0", VA = "0x1872EEBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx CDBGCEIGNJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x72EF8A0", Offset = "0x72EE4A0", VA = "0x1872EF8A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x72F0DD0", Offset = "0x72EF9D0", VA = "0x1872F0DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool LEOLOCPNFLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x72CEB40", Offset = "0x72CD740", VA = "0x1872CEB40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x72D1130", Offset = "0x72CFD30", VA = "0x1872D1130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform OHCKGBMFMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xC65ED0", Offset = "0xC64AD0", VA = "0x180C65ED0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform DJPOCOPOLLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xC65ED0", Offset = "0xC64AD0", VA = "0x180C65ED0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform NJNJPMCLAND
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xC65ED0", Offset = "0xC64AD0", VA = "0x180C65ED0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MJNMIJLCBLF KDPJGJPBIBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x72EE990", Offset = "0x72ED590", VA = "0x1872EE990")]
			get
			{
				return default(MJNMIJLCBLF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x72F0580", Offset = "0x72EF180", VA = "0x1872F0580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool AIPMNIELNMO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x72EEFA0", Offset = "0x72EDBA0", VA = "0x1872EEFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool JGIANDHMAAI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x72EEAB0", Offset = "0x72ED6B0", VA = "0x1872EEAB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HFNNNBLDCNA GIGBCDDIFFI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x72EEEE0", Offset = "0x72EDAE0", VA = "0x1872EEEE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x72F0740", Offset = "0x72EF340", VA = "0x1872F0740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NHFCKNCOFHL BNJCKKMAIEN
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x72EEE80", Offset = "0x72EDA80", VA = "0x1872EEE80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x72F06D0", Offset = "0x72EF2D0", VA = "0x1872F06D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JHLECMNIDHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x72EEDD0", Offset = "0x72ED9D0", VA = "0x1872EEDD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody NFEIAPALFII
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x72EEE30", Offset = "0x72EDA30", VA = "0x1872EEE30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool BEFLOIPKEOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x72EEB10", Offset = "0x72ED710", VA = "0x1872EEB10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x72F05F0", Offset = "0x72EF1F0", VA = "0x1872F05F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool LPEIBOEKGCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6FBEEB0", Offset = "0x6FBDAB0", VA = "0x186FBEEB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float MDJNHCCIINA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x72EF840", Offset = "0x72EE440", VA = "0x1872EF840")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float MCMCPAMEIAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x72EF7E0", Offset = "0x72EE3E0", VA = "0x1872EF7E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x72F0D60", Offset = "0x72EF960", VA = "0x1872F0D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float DILIKGMIDNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x72EF200", Offset = "0x72EDE00", VA = "0x1872EF200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x72F09E0", Offset = "0x72EF5E0", VA = "0x1872F09E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float HODFGNLOPME
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x72EF000", Offset = "0x72EDC00", VA = "0x1872EF000")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x72F07B0", Offset = "0x72EF3B0", VA = "0x1872F07B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool ADAFLIKLKPA
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x72EFE20", Offset = "0x72EEA20", VA = "0x1872EFE20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x72F1310", Offset = "0x72EFF10", VA = "0x1872F1310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 PKMEJPDIAIB
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x72EF5C0", Offset = "0x72EE1C0", VA = "0x1872EF5C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x72F0B30", Offset = "0x72EF730", VA = "0x1872F0B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 IHEHJKACFMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x72EFF60", Offset = "0x72EEB60", VA = "0x1872EFF60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode AKGALHBCNKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x72EF140", Offset = "0x72EDD40", VA = "0x1872EF140")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x72F0900", Offset = "0x72EF500", VA = "0x1872F0900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float PGLPJNKMDCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x72EEB70", Offset = "0x72ED770", VA = "0x1872EEB70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x72F0660", Offset = "0x72EF260", VA = "0x1872F0660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints AINIPHMCKCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x72EF1A0", Offset = "0x72EDDA0", VA = "0x1872EF1A0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x72F0970", Offset = "0x72EF570", VA = "0x1872F0970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 MDDDJHLJFED
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x72EF960", Offset = "0x72EE560", VA = "0x1872EF960")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 DKAIGPODKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x72EF960", Offset = "0x72EE560", VA = "0x1872EF960")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x72F10F0", Offset = "0x72EFCF0", VA = "0x1872F10F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float OHFKKMGCGEN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x72EF6A0", Offset = "0x72EE2A0", VA = "0x1872EF6A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x72F0C10", Offset = "0x72EF810", VA = "0x1872F0C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float ADCIGCKCJLG
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x72EFDC0", Offset = "0x72EE9C0", VA = "0x1872EFDC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x72F12A0", Offset = "0x72EFEA0", VA = "0x1872F12A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion CPJGJMNLIKE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x72EFA40", Offset = "0x72EE640", VA = "0x1872EFA40")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x72F0E70", Offset = "0x72EFA70", VA = "0x1872F0E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion IDPJGBGADPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x72EFCE0", Offset = "0x72EE8E0", VA = "0x1872EFCE0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x72F11D0", Offset = "0x72EFDD0", VA = "0x1872F11D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 NPFENBAPFPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x72EFB20", Offset = "0x72EE720", VA = "0x1872EFB20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x72F0F40", Offset = "0x72EFB40", VA = "0x1872F0F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion BKLMCNMPBJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x72EFC00", Offset = "0x72EE800", VA = "0x1872EFC00")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x72F1020", Offset = "0x72EFC20", VA = "0x1872F1020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 MDMLBPNGPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x72EFE80", Offset = "0x72EEA80", VA = "0x1872EFE80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x72F1380", Offset = "0x72EFF80", VA = "0x1872F1380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 BMFLMHGGHPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x72EF700", Offset = "0x72EE300", VA = "0x1872EF700")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x72F0C80", Offset = "0x72EF880", VA = "0x1872F0C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 CMHJKMGAIPO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x72EF060", Offset = "0x72EDC60", VA = "0x1872EF060")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x72F0820", Offset = "0x72EF420", VA = "0x1872F0820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 LPPLMKNAGEI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x72EF4E0", Offset = "0x72EE0E0", VA = "0x1872EF4E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x72F0A50", Offset = "0x72EF650", VA = "0x1872F0A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 ELANOGBCBLD
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x72EF3A0", Offset = "0x72EDFA0", VA = "0x1872EF3A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion HFEAOFBGEKL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x72EF2C0", Offset = "0x72EDEC0", VA = "0x1872EF2C0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 BFIFKHEICKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x72F0120", Offset = "0x72EED20", VA = "0x1872F0120")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 GCPFLFAMHDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x72F0040", Offset = "0x72EEC40", VA = "0x1872F0040")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool PHPLIMHIOLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x72EF480", Offset = "0x72EE080", VA = "0x1872EF480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool DALLNAJDKLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x72EEF40", Offset = "0x72EDB40", VA = "0x1872EEF40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool JEGCDELHGPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x72EEA50", Offset = "0x72ED650", VA = "0x1872EEA50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool NIBOLDAIGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x72EE9F0", Offset = "0x72ED5F0", VA = "0x1872EE9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool IJLNEEJPJDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x72EE8D0", Offset = "0x72ED4D0", VA = "0x1872EE8D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool MBKNGBLCIDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x72EF260", Offset = "0x72EDE60", VA = "0x1872EF260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool LNEBBFIJLFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x19E1CC0", Offset = "0x19E08C0", VA = "0x1819E1CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event BEKLGGOJFJM BKDDOACKPBB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x72EE7F0", Offset = "0x72ED3F0", VA = "0x1872EE7F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x72F04A0", Offset = "0x72EF0A0", VA = "0x1872F04A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event FANCDFLCCOJ IPMBNNJCPFO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x72EE560", Offset = "0x72ED160", VA = "0x1872EE560")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x72F0200", Offset = "0x72EEE00", VA = "0x1872F0200")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event FANCDFLCCOJ HJHJLJPPEMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x72EE5C0", Offset = "0x72ED1C0", VA = "0x1872EE5C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x72F0270", Offset = "0x72EEE70", VA = "0x1872F0270")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event FANCDFLCCOJ ONOKKABJEHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x72EE710", Offset = "0x72ED310", VA = "0x1872EE710")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x72F03C0", Offset = "0x72EEFC0", VA = "0x1872F03C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<PFKPGFLKLMF, PFKPGFLKLMF> DLMOGLDMCON
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x72EE6A0", Offset = "0x72ED2A0", VA = "0x1872EE6A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x72F0350", Offset = "0x72EEF50", VA = "0x1872F0350")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event FANCDFLCCOJ GDAJJMALGBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x72EE780", Offset = "0x72ED380", VA = "0x1872EE780")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x72F0430", Offset = "0x72EF030", VA = "0x1872F0430")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event FANCDFLCCOJ EFPDLCAMENA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x72EE860", Offset = "0x72ED460", VA = "0x1872EE860")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x72F0510", Offset = "0x72EF110", VA = "0x1872F0510")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event FANCDFLCCOJ OEGJNEFKFHC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x72EE630", Offset = "0x72ED230", VA = "0x1872EE630")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72F02E0", Offset = "0x72EEEE0", VA = "0x1872F02E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x888260", Offset = "0x886E60", VA = "0x180888260", Slot = "8")]
		private void PJCPHKHIJLN(DFINIIBCCEP GMBKDDMMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72ED5D0", Offset = "0x72EC1D0", VA = "0x1872ED5D0")]
		internal void NEIENIENIGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72EE290", Offset = "0x72ECE90", VA = "0x1872EE290")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody IEBPINDGGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72ECF50", Offset = "0x72EBB50", VA = "0x1872ECF50")]
		public FKDGABLNLMI GetChild(int MFJLAMOCOBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x72EDF50", Offset = "0x72ECB50", VA = "0x1872EDF50")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) GEGLIBHENMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72ECA30", Offset = "0x72EB630", VA = "0x1872ECA30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72EE1E0", Offset = "0x72ECDE0", VA = "0x1872EE1E0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x72ECEA0", Offset = "0x72EBAA0", VA = "0x1872ECEA0")]
		private DFINIIBCCEP PAPHFEKAPFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x72ECAA0", Offset = "0x72EB6A0", VA = "0x1872ECAA0")]
		private void CIBOHFMOAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x72ED720", Offset = "0x72EC320", VA = "0x1872ED720")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x72ED660", Offset = "0x72EC260", VA = "0x1872ED660")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x72ED5D0", Offset = "0x72EC1D0", VA = "0x1872ED5D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x72ED6C0", Offset = "0x72EC2C0", VA = "0x1872ED6C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x72ED780", Offset = "0x72EC380", VA = "0x1872ED780")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x72EC0E0", Offset = "0x72EACE0", VA = "0x1872EC0E0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object DGGGDIFONNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x72ED7E0", Offset = "0x72EC3E0", VA = "0x1872ED7E0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object DGGGDIFONNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x72ECE40", Offset = "0x72EBA40", VA = "0x1872ECE40")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x72ED570", Offset = "0x72EC170", VA = "0x1872ED570")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x72EE0B0", Offset = "0x72ECCB0", VA = "0x1872EE0B0")]
		public void SetParent(RigidbodyEx CABLCDOIFFL, bool IHBDDDGGBPK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x72EDAF0", Offset = "0x72EC6F0", VA = "0x1872EDAF0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x72ED200", Offset = "0x72EBE00", VA = "0x1872ED200")]
		public bool IsRigidbodyAncestor(RigidbodyEx CKEJCMKFPGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x72ED300", Offset = "0x72EBF00", VA = "0x1872ED300")]
		public bool IsRigidbodyDescendant(RigidbodyEx JIFKDAPLLGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x72EC350", Offset = "0x72EAF50", VA = "0x1872EC350")]
		public void AddInterpolationRestriction(object DGGGDIFONNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x72ED850", Offset = "0x72EC450", VA = "0x1872ED850")]
		public void RemoveInterpolationRestriction(object DGGGDIFONNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x72EC3C0", Offset = "0x72EAFC0", VA = "0x1872EC3C0")]
		public void AddKinematic(object DGGGDIFONNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x72ED8C0", Offset = "0x72EC4C0", VA = "0x1872ED8C0")]
		public void RemoveKinematic(object DGGGDIFONNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x72EE030", Offset = "0x72ECC30", VA = "0x1872EE030")]
		public void SetKinematic(object DGGGDIFONNG, bool EHIEEFMLLHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x72EDE50", Offset = "0x72ECA50", VA = "0x1872EDE50")]
		public void SetDiscontinuousPositionAndRotation(Vector3 AOLGKMLAGGH, Quaternion ANBJFHCHGMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x72EDD50", Offset = "0x72EC950", VA = "0x1872EDD50")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 FLGJCLBGIEO, Quaternion OGPBFADONDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x72ED0F0", Offset = "0x72EBCF0", VA = "0x1872ED0F0")]
		public Vector3 GetConstrainedVelocity(Vector3 MDMLBPNGPMJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x72ECFE0", Offset = "0x72EBBE0", VA = "0x1872ECFE0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 CMHJKMGAIPO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x72EC260", Offset = "0x72EAE60", VA = "0x1872EC260")]
		public void AddForce(Vector3 KHODILEOPHB, ForceMode PLAPFKADIEB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x72EC150", Offset = "0x72EAD50", VA = "0x1872EC150")]
		public void AddForceAtPosition(Vector3 KHODILEOPHB, Vector3 GKJAMFFKDLE, ForceMode PLAPFKADIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x72EC590", Offset = "0x72EB190", VA = "0x1872EC590")]
		public void AddTorque(Vector3 NJKHALGKIBP, ForceMode PLAPFKADIEB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x72EC430", Offset = "0x72EB030", VA = "0x1872EC430")]
		public void AddRelativeTorque(Vector3 NJKHALGKIBP, ForceMode PLAPFKADIEB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x72EE360", Offset = "0x72ECF60", VA = "0x1872EE360")]
		public Vector3 WorldToLocalVelocity(Vector3 HFNEPAGLJGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x72ED460", Offset = "0x72EC060", VA = "0x1872ED460")]
		public Vector3 LocalToWorldVelocity(Vector3 BMFLMHGGHPH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x72ECDE0", Offset = "0x72EB9E0", VA = "0x1872ECDE0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x72ECD80", Offset = "0x72EB980", VA = "0x1872ECD80")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x72ECD20", Offset = "0x72EB920", VA = "0x1872ECD20")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x72ECCC0", Offset = "0x72EB8C0", VA = "0x1872ECCC0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x72EDC50", Offset = "0x72EC850", VA = "0x1872EDC50")]
		public void ResetVelocityWorldSpace(Vector3 NMOGPAJJGNL, Vector3 ACFFMBMNFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x72EDB50", Offset = "0x72EC750", VA = "0x1872EDB50")]
		public void ResetVelocityLocalSpace(Vector3 DNLPADGICAN, Vector3 LPPLMKNAGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x72EDA10", Offset = "0x72EC610", VA = "0x1872EDA10")]
		public void ResetLinearVelocityLocalSpace(Vector3 DNLPADGICAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x72EE1F0", Offset = "0x72ECDF0", VA = "0x1872EE1F0")]
		public bool SweepTest(Vector3 EJOHIEANBFL, [Out] RaycastHit IEALDBEJJDA, float GHBEHFGEGMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x72ED400", Offset = "0x72EC000", VA = "0x1872ED400")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x72EE180", Offset = "0x72ECD80", VA = "0x1872EE180")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x72EE300", Offset = "0x72ECF00", VA = "0x1872EE300")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x72EC520", Offset = "0x72EB120", VA = "0x1872EC520")]
		public void AddShouldHaveUnityRigidbodyToken(object DGGGDIFONNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x72ED930", Offset = "0x72EC530", VA = "0x1872ED930")]
		public void RemoveShouldHaveUnityRigidbodyToken(object DGGGDIFONNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72EC8C0", Offset = "0x72EB4C0", VA = "0x1872EC8C0")]
		public void ApplyForceVelocityChange(MFONMFNDNGL IDGIIMMBCIL, Vector3 PKIIFMCPGDK, float LIOFPKPIJFM, float CIIBCKHLCED = 8f, float JPLEKJHIBBE = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x72EC820", Offset = "0x72EB420", VA = "0x1872EC820")]
		public void ApplyAngularVelocityChange(MILNJDMBAGC ANAPHKLDGNK, Vector3 PMMICEJDCDH, float EGOPDCFEMMN = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x72EC980", Offset = "0x72EB580", VA = "0x1872EC980")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(MILNJDMBAGC ANAPHKLDGNK, Vector3 EAGKGJHHIJH, float LGJEAIELNIF = 7f, float ANDNDMFDKEN = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x72EC750", Offset = "0x72EB350", VA = "0x1872EC750")]
		public bool AllowedScaleChange(float GBKOKFCKMOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x72EC680", Offset = "0x72EB280", VA = "0x1872EC680")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx MHEFINEMHCE, object DGGGDIFONNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x72ED9A0", Offset = "0x72EC5A0", VA = "0x1872ED9A0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object DGGGDIFONNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x72EE4F0", Offset = "0x72ED0F0", VA = "0x1872EE4F0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xB83E00", Offset = "0xB82A00", VA = "0x180B83E00", Slot = "4")]
		private GameObject PDDNIILIPKH()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B57E0", Offset = "0x8B43E0", VA = "0x1808B57E0", Slot = "9")]
		private bool OHGACKONIMH()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class KMAKKJNNCPE
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x72E40A0", Offset = "0x72E2CA0", VA = "0x1872E40A0")]
	public static DFINIIBCCEP CKILFKBLILK(this RigidbodyEx OMKKPDAIFOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(JFFPDFPAHFI), new string[] { })]
public class DDJCDDNBDBA : JFFPDFPAHFI, PFAELLKIJHO
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private OEHHMGGELGC KPPPCHNHKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private LKKGGKEFLNP CPKOIOKIGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private AELOKBLHNHB LOFGGFFANCC;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public LKKGGKEFLNP CBJAIPHNNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public AELOKBLHNHB ABIOBKGJJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x72DC1D0", Offset = "0x72DADD0", VA = "0x1872DC1D0", Slot = "7")]
	public void InitReferences(JHKOPLPKGAC AOJEPPFAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x72DC140", Offset = "0x72DAD40", VA = "0x1872DC140", Slot = "6")]
	public DFINIIBCCEP FDJLCEOBNOP(RigidbodyEx OMKKPDAIFOD, JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public DDJCDDNBDBA()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static DBHLBOFDKDO UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static DBHLBOFDKDO AfterSyncTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int OBOBDKGCCHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int NKGFHGNDMNB;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x72EBEB0", Offset = "0x72EAAB0", VA = "0x1872EBEB0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x72EBF50", Offset = "0x72EAB50", VA = "0x1872EBF50")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x72EBED0", Offset = "0x72EAAD0", VA = "0x1872EBED0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string LFKIGNHCOID, [Optional] UnityEngine.Object PDMONEGPHPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string LFKIGNHCOID, [Optional] UnityEngine.Object PDMONEGPHPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x72EC090", Offset = "0x72EAC90", VA = "0x1872EC090")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PDCJCKIPNEA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class GLFONABMKMI : HFNNNBLDCNA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x898880", Offset = "0x897480", VA = "0x180898880", Slot = "4")]
		public Vector3 MGBBHMOGKLB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x898880", Offset = "0x897480", VA = "0x180898880", Slot = "5")]
		public Vector3 PFGLLJFDDNB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public GLFONABMKMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static HFNNNBLDCNA CECPEDODGHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x72EB0D0", Offset = "0x72E9CD0", VA = "0x1872EB0D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PNNAPPCPBJK
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode NNAIEJLLLNM
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
	void OJANEOIFOLO();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELOGOHEOMOL(bool PHPLIMHIOLI);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IKDBDDKEIOH(bool PHPLIMHIOLI);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPFBDJKNHMK(Rigidbody JOOPKCJCOGP);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FNHJPILPKGF(Vector3 EJOHIEANBFL, [Out] RaycastHit IEALDBEJJDA, float GHBEHFGEGMI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EOMKILLKHBM : IDisposable, OKBBFGNKAGE
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	MJNMIJLCBLF KDPJGJPBIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<PFKPGFLKLMF, PFKPGFLKLMF> DLMOGLDMCON;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJANEOIFOLO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface AELOKBLHNHB
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LKDONNFDJPB OGJAANBMCAB(DFINIIBCCEP GMBKDDMMMLD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ALOBINMGIGI MBCDFFBICIB(DFINIIBCCEP GMBKDDMMMLD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NEOPDJPHIEJ LPAPIFDPNMK(DFINIIBCCEP GMBKDDMMMLD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CLAOAFKHALL NACJNBAPMIE(DFINIIBCCEP GMBKDDMMMLD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PJDMDAEDOMI LJNANOIHGEA(DFINIIBCCEP GMBKDDMMMLD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EOMKILLKHBM CCBBIGJKLJN(DFINIIBCCEP GMBKDDMMMLD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LKGLKAPLEGP DEGGHDKPMDA(DFINIIBCCEP GMBKDDMMMLD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NIJEAICJDJK KMBIOKHEKPH(DFINIIBCCEP GMBKDDMMMLD);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PNNAPPCPBJK GKKBNEBFJLG(DFINIIBCCEP GMBKDDMMMLD);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MOLEHALHAJM HHJCIBJMJGD(DFINIIBCCEP GMBKDDMMMLD);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MNMFDKGGPKO HEDNIECONPO(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GPCMOFNAMKH IMBKJMMBHIM(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	AFHKGLACOGL LMELBLGKBPP(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DILPHPPPNFK GIMAGAECIFM(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MBKEHAAMEEN NOJFJBLANNP(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DFINIIBCCEP FDJLCEOBNOP(RigidbodyEx OMKKPDAIFOD, JAEAHDCMHEL BFLLAIFBMAJ, JFFPDFPAHFI IGEADGIGICG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NIJEAICJDJK
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MONAJLCLIKD(Vector3 KHODILEOPHB, ForceMode PLAPFKADIEB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNILPEAKOIE(Vector3 KHODILEOPHB, Vector3 GKJAMFFKDLE, ForceMode PLAPFKADIEB);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMDHJLIKGOB(Vector3 NJKHALGKIBP, ForceMode PLAPFKADIEB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PLNPLANPAFP(Vector3 NJKHALGKIBP, ForceMode PLAPFKADIEB = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MOLEHALHAJM
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool PFADAKEGFLN
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
	void JPFBDJKNHMK(Rigidbody JOOPKCJCOGP);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EBOCOPFFCBG(Rigidbody JOOPKCJCOGP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LKDONNFDJPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<DFINIIBCCEP> BPNOAFLHNMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	DFINIIBCCEP JAFALLCEFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	DFINIIBCCEP GGAFGBKJIIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FANCDFLCCOJ IPMBNNJCPFO;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event FANCDFLCCOJ HJHJLJPPEMH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event BEKLGGOJFJM AKPBGIBNKIL;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action PCGCBGJGLEB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action MLMFANJAOAB;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<DFINIIBCCEP> OPCDIIBPFAE;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<DFINIIBCCEP> LGFJCOKEHNG;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action LOAPAIIJAJJ;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<DFINIIBCCEP> JAGBHFOGBPG;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EOIGELPPMDL(DFINIIBCCEP NDJJLBGHFGF, bool IHBDDDGGBPK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NEOPDJPHIEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 NCKIOCCKCLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 KAPPNMLNCME
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBEKNKMBJEK(DFINIIBCCEP CDBGCEIGNJC, object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHLLICELNHA(object DGGGDIFONNG);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DILPHPPPNFK
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 EHEFDHIKAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 KBNEBOGPGBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float BIFIDJPGNNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float MBNFAEGAHNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 ECPEKKJNEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion LCBDHCOEPDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event FANCDFLCCOJ BFKBNHCNOAG;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JLEFIBPFBOG((Quaternion rot, Vector3 moments) GEGLIBHENMO);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GIOFKEMGBKM();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KDNJNMKPHPE();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BCCMDDNHIFD();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JPFBDJKNHMK(Rigidbody JOOPKCJCOGP);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EBOCOPFFCBG(Rigidbody JOOPKCJCOGP);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NEGIONHHPPM();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AFHKGLACOGL
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJANEOIFOLO();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIPGHMJFJIG(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJCPOLGELFA(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PAANNFGFPPC(DFINIIBCCEP OMKKPDAIFOD);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NGGAMCKLKKG(DFINIIBCCEP OMKKPDAIFOD);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EEAJDJFFGJA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LKGLKAPLEGP
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool DPJLPEODCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event FANCDFLCCOJ OBIKLCHEHLF;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HIGHALKIHHK(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GKNIEJKJCLG(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DFCKPHMJEFG(object DGGGDIFONNG, bool EHIEEFMLLHN);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JPFBDJKNHMK(Rigidbody DOMJNFIKOOO);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EBOCOPFFCBG(Rigidbody JOOPKCJCOGP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GPCMOFNAMKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool AIPMNIELNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool JGIANDHMAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event FANCDFLCCOJ OAGEABIHGLM;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJANEOIFOLO();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHCFDCHPJKH(DFINIIBCCEP CDBGCEIGNJC);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PJGJNEBBGHP(DFINIIBCCEP CDBGCEIGNJC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MBKEHAAMEEN
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool BEFLOIPKEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool IMFIBCNPEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints HGFMKNEOENL
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
	void JPFBDJKNHMK(Rigidbody JOOPKCJCOGP);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EBOCOPFFCBG(Rigidbody JOOPKCJCOGP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CLAOAFKHALL
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float HIIPFEDIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float OBKAELLMFAH
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
	void JPFBDJKNHMK(Rigidbody JOOPKCJCOGP);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EBOCOPFFCBG(Rigidbody JOOPKCJCOGP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PJDMDAEDOMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	static bool OFFHEODEBKC;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event FANCDFLCCOJ ABDHGDHAPNC;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJANEOIFOLO();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IKCEGMJLJMH();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHHCLFAFDJP();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GCGKNLEBBGH();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NAAPIOEAHOL();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LMFGJOCMIGO();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DKKBEPGDAMG(bool LKIOELBHPNO);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OMGKNMJGCFG();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MNMFDKGGPKO
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody NFEIAPALFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool PFEJGNGOCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJANEOIFOLO();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KCIMDBGEJEP(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLNDOGCHDLJ(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NMMAHFBLAEN();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ALOBINMGIGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	HFNNNBLDCNA GIGBCDDIFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	NHFCKNCOFHL BNJCKKMAIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 EOAIJNEBOIA
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 CMDPGAKIAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 JOPLOAMFBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 JKOEHFPKHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float PGLPJNKMDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool JHLECMNIDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OJANEOIFOLO();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JBLAMDMJFHF(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EJOGIOHDDPJ(MILNJDMBAGC ANAPHKLDGNK, Vector3 PMMICEJDCDH, float EGOPDCFEMMN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EMABLOKJGCM(MFONMFNDNGL IDGIIMMBCIL, Vector3 PKIIFMCPGDK, float LIOFPKPIJFM, float CIIBCKHLCED = 8f, float JPLEKJHIBBE = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LHGIJKKBMAH(MILNJDMBAGC ANAPHKLDGNK, Vector3 EAGKGJHHIJH, float LGJEAIELNIF = 7f, float ANDNDMFDKEN = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NLMJJHCEFAK();

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LPNDIEIGBLF();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JJNOPMIDNNN();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GGOKAJCLLAN();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JPFBDJKNHMK(Rigidbody JOOPKCJCOGP);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 APMIFMPDGIC(Vector3 MDMLBPNGPMJ);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LDGCDKIEHHO(object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DEBLGFDAICC(Vector3 JDDIPPFHEHC);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KOOFMIMPJDP(Vector3 DNLPADGICAN, Vector3 LPPLMKNAGEI);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KGCMLBIIHEF(Vector3 NMOGPAJJGNL, Vector3 ACFFMBMNFIL);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 IHMLDBIKGFH(Vector3 BMFLMHGGHPH);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 IHELIJDHFPA(Vector3 HFNEPAGLJGM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface LKKGGKEFLNP
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool AFHMDPBDDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOBKKDFNNOF(string IHNODDPNJFM);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LDOGCFDNGKH(RigidbodyEx OMKKPDAIFOD, Action FNGNLBJEBKM);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CPHKHNFBFLI LGBHAECEEPB(int GNECMCDAHAC);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OKJEFILAOCJ(Vector3 IHEHJKACFMP, float BNCPBJKGAGI, Color NKKLIFIFGAP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface JFFPDFPAHFI
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	LKKGGKEFLNP CBJAIPHNNMA
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	AELOKBLHNHB ABIOBKGJJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DFINIIBCCEP FDJLCEOBNOP(RigidbodyEx OMKKPDAIFOD, JAEAHDCMHEL BFLLAIFBMAJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DAHMKODHKBA : DFINIIBCCEP, IDisposable, HKLOAHDEIDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly JFFPDFPAHFI IGEADGIGICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal LKDONNFDJPB OAPHHHCNFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal AFHKGLACOGL EFCPODGFDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal GPCMOFNAMKH NKABENGFCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal ALOBINMGIGI MDMLBPNGPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal NEOPDJPHIEJ MOBHOHNBIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal DILPHPPPNFK IEJALLPFDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal CLAOAFKHALL OGLJDLJHBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal MOLEHALHAJM MBNGLBGGBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal PJDMDAEDOMI JKMMLFDAHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal EOMKILLKHBM ECJAECHKAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal LKGLKAPLEGP IEEPBNDDJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal NIJEAICJDJK KHODILEOPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal MBKEHAAMEEN NLLFNBPHENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal MNMFDKGGPKO JOOPKCJCOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal PNNAPPCPBJK MJBFGDMCGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal IDisposable HEPFHKMJMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool GKLDACHGGDA;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public JBKDGFJKCIL HJEOCMEBKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "22")]
		get
		{
			return default(JBKDGFJKCIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public FKDGABLNLMI ANCPPECAGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x94DF30", Offset = "0x94CB30", VA = "0x18094DF30", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDD0", Offset = "0xD0E9D0", VA = "0x180D0FDD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject MNEKHEHNFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8963B0", Offset = "0x894FB0", VA = "0x1808963B0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x896370", Offset = "0x894F70", VA = "0x180896370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform DJCNFDBJOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA4D290", Offset = "0xA4BE90", VA = "0x180A4D290", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xBE9840", Offset = "0xBE8440", VA = "0x180BE9840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody NFEIAPALFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x72D60C0", Offset = "0x72D4CC0", VA = "0x1872D60C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public DFINIIBCCEP GGAFGBKJIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x72DA1A0", Offset = "0x72D8DA0", VA = "0x1872DA1A0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x72D5A00", Offset = "0x72D4600", VA = "0x1872D5A00", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int MHCECFLHJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x72D9F20", Offset = "0x72D8B20", VA = "0x1872D9F20", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public DFINIIBCCEP JAFALLCEFOE
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x72DAAC0", Offset = "0x72D96C0", VA = "0x1872DAAC0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool CIIKKBJHNAF
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x72DAC10", Offset = "0x72D9810", VA = "0x1872DAC10", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool AIPMNIELNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x72D6110", Offset = "0x72D4D10", VA = "0x1872D6110", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool JGIANDHMAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x72DB510", Offset = "0x72DA110", VA = "0x1872DB510", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public HFNNNBLDCNA GIGBCDDIFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x72D7030", Offset = "0x72D5C30", VA = "0x1872D7030", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x72DB2F0", Offset = "0x72D9EF0", VA = "0x1872DB2F0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public NHFCKNCOFHL BNJCKKMAIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x72D7BE0", Offset = "0x72D67E0", VA = "0x1872D7BE0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x72D7370", Offset = "0x72D5F70", VA = "0x1872D7370", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float PGLPJNKMDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x72D9570", Offset = "0x72D8170", VA = "0x1872D9570", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x72D86B0", Offset = "0x72D72B0", VA = "0x1872D86B0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 CMDPGAKIAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x72D5A60", Offset = "0x72D4660", VA = "0x1872D5A60", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x72DA3C0", Offset = "0x72D8FC0", VA = "0x1872DA3C0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 JKOEHFPKHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x72DADF0", Offset = "0x72D99F0", VA = "0x1872DADF0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x72D82E0", Offset = "0x72D6EE0", VA = "0x1872D82E0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 EOAIJNEBOIA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x72DB430", Offset = "0x72DA030", VA = "0x1872DB430", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x72D6F50", Offset = "0x72D5B50", VA = "0x1872D6F50", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 JOPLOAMFBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x72D9DF0", Offset = "0x72D89F0", VA = "0x1872D9DF0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x72DB040", Offset = "0x72D9C40", VA = "0x1872DB040", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool JEGCDELHGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x72D73D0", Offset = "0x72D5FD0", VA = "0x1872D73D0", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool NIBOLDAIGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x72DBB90", Offset = "0x72DA790", VA = "0x1872DBB90", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool IJLNEEJPJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x72D85D0", Offset = "0x72D71D0", VA = "0x1872D85D0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool JHLECMNIDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x72DADA0", Offset = "0x72D99A0", VA = "0x1872DADA0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 NCKIOCCKCLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x72D8210", Offset = "0x72D6E10", VA = "0x1872D8210", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 KAPPNMLNCME
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x72DA4E0", Offset = "0x72D90E0", VA = "0x1872DA4E0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 EHEFDHIKAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x72D9A90", Offset = "0x72D8690", VA = "0x1872D9A90", Slot = "54")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x72D6810", Offset = "0x72D5410", VA = "0x1872D6810", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 KBNEBOGPGBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x72DB990", Offset = "0x72DA590", VA = "0x1872DB990", Slot = "56")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float BIFIDJPGNNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x72DB5F0", Offset = "0x72DA1F0", VA = "0x1872DB5F0", Slot = "57")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float MBNFAEGAHNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x72D8F50", Offset = "0x72D7B50", VA = "0x1872D8F50", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x72D8150", Offset = "0x72D6D50", VA = "0x1872D8150", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 ECPEKKJNEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x72DB700", Offset = "0x72DA300", VA = "0x1872DB700", Slot = "60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion LCBDHCOEPDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x72D7CD0", Offset = "0x72D68D0", VA = "0x1872D7CD0", Slot = "61")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float HIIPFEDIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x72D7830", Offset = "0x72D6430", VA = "0x1872D7830", Slot = "63")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x72D6290", Offset = "0x72D4E90", VA = "0x1872D6290", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float OBKAELLMFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x72DBB40", Offset = "0x72DA740", VA = "0x1872DBB40", Slot = "65")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x72DB6A0", Offset = "0x72DA2A0", VA = "0x1872DB6A0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool PFADAKEGFLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x72DAB70", Offset = "0x72D9770", VA = "0x1872DAB70", Slot = "67")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x72D7310", Offset = "0x72D5F10", VA = "0x1872D7310", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public MJNMIJLCBLF KDPJGJPBIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x72DB250", Offset = "0x72D9E50", VA = "0x1872DB250", Slot = "69")]
		get
		{
			return default(MJNMIJLCBLF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x72D9D30", Offset = "0x72D8930", VA = "0x1872D9D30", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool DPJLPEODCNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x72D6BB0", Offset = "0x72D57B0", VA = "0x1872D6BB0", Slot = "71")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform NJNJPMCLAND
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA4D290", Offset = "0xA4BE90", VA = "0x180A4D290", Slot = "72")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 LHMPEBNIPEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x72D8790", Offset = "0x72D7390", VA = "0x1872D8790", Slot = "73")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x72D9C80", Offset = "0x72D8880", VA = "0x1872D9C80", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float AFFFNIPBCOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x72D7880", Offset = "0x72D6480", VA = "0x1872D7880", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x72D61C0", Offset = "0x72D4DC0", VA = "0x1872D61C0", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float NMKIACJKDCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x72D59F0", Offset = "0x72D45F0", VA = "0x1872D59F0", Slot = "77")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x72D5FE0", Offset = "0x72D4BE0", VA = "0x1872D5FE0", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion ODLFLANDFNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x72D9200", Offset = "0x72D7E00", VA = "0x1872D9200", Slot = "79")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x72DA2E0", Offset = "0x72D8EE0", VA = "0x1872DA2E0", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 LDMDDCKKDNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x72D6550", Offset = "0x72D5150", VA = "0x1872D6550", Slot = "81")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x72DA4A0", Offset = "0x72D90A0", VA = "0x1872DA4A0", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion ACHKOFDELKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x72DB000", Offset = "0x72D9C00", VA = "0x1872DB000", Slot = "83")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x72D9B70", Offset = "0x72D8770", VA = "0x1872D9B70", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints HGFMKNEOENL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x72D6710", Offset = "0x72D5310", VA = "0x1872D6710", Slot = "85")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x72D77D0", Offset = "0x72D63D0", VA = "0x1872D77D0", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool BEFLOIPKEOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x72D5C80", Offset = "0x72D4880", VA = "0x1872D5C80", Slot = "87")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x72D8730", Offset = "0x72D7330", VA = "0x1872D8730", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode NNAIEJLLLNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x72D67C0", Offset = "0x72D53C0", VA = "0x1872D67C0", Slot = "89")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x72DB640", Offset = "0x72DA240", VA = "0x1872DB640", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool NCJPKDPPCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x72D5B40", Offset = "0x72D4740", VA = "0x1872D5B40", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool DALLNAJDKLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x72D6590", Offset = "0x72D5190", VA = "0x1872D6590", Slot = "91")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event FANCDFLCCOJ IPMBNNJCPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x72D5F80", Offset = "0x72D4B80", VA = "0x1872D5F80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x72D6C70", Offset = "0x72D5870", VA = "0x1872D6C70", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event FANCDFLCCOJ HJHJLJPPEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x72D95C0", Offset = "0x72D81C0", VA = "0x1872D95C0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x72D8510", Offset = "0x72D7110", VA = "0x1872D8510", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event BEKLGGOJFJM AKPBGIBNKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x72D7B80", Offset = "0x72D6780", VA = "0x1872D7B80", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x72D8570", Offset = "0x72D7170", VA = "0x1872D8570", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event FANCDFLCCOJ OAGEABIHGLM
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x72D81B0", Offset = "0x72D6DB0", VA = "0x1872D81B0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x72D9400", Offset = "0x72D8000", VA = "0x1872D9400", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event FANCDFLCCOJ ONOKKABJEHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x72D90A0", Offset = "0x72D7CA0", VA = "0x1872D90A0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x72D9680", Offset = "0x72D8280", VA = "0x1872D9680", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event FANCDFLCCOJ ABDHGDHAPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x72DAC70", Offset = "0x72D9870", VA = "0x1872DAC70", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x72D8EF0", Offset = "0x72D7AF0", VA = "0x1872D8EF0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<PFKPGFLKLMF, PFKPGFLKLMF> DLMOGLDMCON
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x72D6760", Offset = "0x72D5360", VA = "0x1872D6760", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x72D6230", Offset = "0x72D4E30", VA = "0x1872D6230", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event FANCDFLCCOJ OBIKLCHEHLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x72D5990", Offset = "0x72D4590", VA = "0x1872D5990", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x72DBAE0", Offset = "0x72DA6E0", VA = "0x1872DBAE0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event FANCDFLCCOJ OEGJNEFKFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x72D5E80", Offset = "0x72D4A80", VA = "0x1872D5E80", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x72D5CD0", Offset = "0x72D48D0", VA = "0x1872D5CD0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x72DBF90", Offset = "0x72DAB90", VA = "0x1872DBF90")]
	public DAHMKODHKBA(GameObject DKOODDCANLH, RigidbodyEx ANMGBAOFAII, JFFPDFPAHFI IGEADGIGICG, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x72D7890", Offset = "0x72D6490", VA = "0x1872D7890", Slot = "138")]
	protected virtual void FJFBCPHCMDF(JFFPDFPAHFI IGEADGIGICG, JAEAHDCMHEL BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x72D71F0", Offset = "0x72D5DF0", VA = "0x1872D71F0", Slot = "139")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x72DB7E0", Offset = "0x72DA3E0", VA = "0x1872DB7E0", Slot = "92")]
	public void OJANEOIFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x72DB560", Offset = "0x72DA160", VA = "0x1872DB560", Slot = "93")]
	public void OEALLKICOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x72D9620", Offset = "0x72D8220", VA = "0x1872D9620", Slot = "94")]
	public void JAAAEOBJNFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x72D8710", Offset = "0x72D7310", VA = "0x1872D8710", Slot = "95")]
	public void HDMFOLCNGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x72D6CD0", Offset = "0x72D58D0", VA = "0x1872D6CD0")]
	private void DKKBEPGDAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x72D7680", Offset = "0x72D6280", VA = "0x1872D7680")]
	private void EOBEIKEFNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x72DAB10", Offset = "0x72D9710", VA = "0x1872DAB10")]
	private void LMFGJOCMIGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x72D8D60", Offset = "0x72D7960", VA = "0x1872D8D60", Slot = "30")]
	public DFINIIBCCEP HMNNJDALHAG(int MFJLAMOCOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x72D7700", Offset = "0x72D6300", VA = "0x1872D7700", Slot = "97")]
	public void EOIGELPPMDL(DFINIIBCCEP CABLCDOIFFL, bool IHBDDDGGBPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x72D8BC0", Offset = "0x72D77C0", VA = "0x1872D8BC0", Slot = "98")]
	public void HHEBINPCIHG(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x72D7F10", Offset = "0x72D6B10", VA = "0x1872D7F10", Slot = "99")]
	public void GHLNLPKHEON(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x72D8FA0", Offset = "0x72D7BA0", VA = "0x1872D8FA0", Slot = "100")]
	public Vector3 IHELIJDHFPA(Vector3 HFNEPAGLJGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x72D9100", Offset = "0x72D7D00", VA = "0x1872D9100", Slot = "101")]
	public Vector3 IHMLDBIKGFH(Vector3 BMFLMHGGHPH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x72D7EC0", Offset = "0x72D6AC0", VA = "0x1872D7EC0", Slot = "102")]
	public void GGOKAJCLLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x72DABC0", Offset = "0x72D97C0", VA = "0x1872DABC0", Slot = "103")]
	public void LPNDIEIGBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x72DB3E0", Offset = "0x72D9FE0", VA = "0x1872DB3E0", Slot = "104")]
	public void NLMJJHCEFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x72D9F90", Offset = "0x72D8B90", VA = "0x1872D9F90", Slot = "105")]
	public void KGCMLBIIHEF(Vector3 NMOGPAJJGNL, Vector3 ACFFMBMNFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x72DA1F0", Offset = "0x72D8DF0", VA = "0x1872DA1F0", Slot = "106")]
	public void KOOFMIMPJDP(Vector3 DNLPADGICAN, Vector3 LPPLMKNAGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x72D68F0", Offset = "0x72D54F0", VA = "0x1872D68F0", Slot = "107")]
	public void DEBLGFDAICC(Vector3 JDDIPPFHEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x72D75C0", Offset = "0x72D61C0", VA = "0x1872D75C0", Slot = "108")]
	public void EMABLOKJGCM(MFONMFNDNGL IDGIIMMBCIL, Vector3 PKIIFMCPGDK, float LIOFPKPIJFM, float CIIBCKHLCED = 8f, float JPLEKJHIBBE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x72D7520", Offset = "0x72D6120", VA = "0x1872D7520", Slot = "109")]
	public void EJOGIOHDDPJ(MILNJDMBAGC ANAPHKLDGNK, Vector3 PMMICEJDCDH, float EGOPDCFEMMN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x72DAA10", Offset = "0x72D9610", VA = "0x1872DAA10", Slot = "110")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LHGIJKKBMAH(MILNJDMBAGC ANAPHKLDGNK, Vector3 EAGKGJHHIJH, float LGJEAIELNIF = 7f, float ANDNDMFDKEN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x72D5D80", Offset = "0x72D4980", VA = "0x1872D5D80", Slot = "111")]
	public Vector3 APMIFMPDGIC(Vector3 CABLCDOIFFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x72D7420", Offset = "0x72D6020", VA = "0x1872D7420", Slot = "112")]
	public Vector3 EICKODAIFLO(Vector3 CABLCDOIFFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x72D9A40", Offset = "0x72D8640", VA = "0x1872D9A40", Slot = "113")]
	public void JJNOPMIDNNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x72DB920", Offset = "0x72DA520", VA = "0x1872DB920", Slot = "114")]
	public void OJJMBMADKDP(DFINIIBCCEP MHEFINEMHCE, object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x72D7770", Offset = "0x72D6370", VA = "0x1872D7770", Slot = "115")]
	public void EONINJDAFNJ(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x72D9BA0", Offset = "0x72D87A0", VA = "0x1872D9BA0", Slot = "62")]
	public void JLEFIBPFBOG((Quaternion rot, Vector3 moments) GEGLIBHENMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x72D9ED0", Offset = "0x72D8AD0", VA = "0x1872D9ED0", Slot = "116")]
	public void KDNJNMKPHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x72D80A0", Offset = "0x72D6CA0", VA = "0x1872D80A0", Slot = "117")]
	public void GIOFKEMGBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x72D5F30", Offset = "0x72D4B30", VA = "0x1872D5F30", Slot = "118")]
	public void BCCMDDNHIFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x72D93B0", Offset = "0x72D7FB0", VA = "0x1872D93B0", Slot = "119")]
	public bool IKCEGMJLJMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x72D7DA0", Offset = "0x72D69A0", VA = "0x1872D7DA0", Slot = "96")]
	public void GCGKNLEBBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x72DBA70", Offset = "0x72DA670", VA = "0x1872DBA70", Slot = "120")]
	public void OMGKNMJGCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x72D8C20", Offset = "0x72D7820", VA = "0x1872D8C20", Slot = "121")]
	public void HIGHALKIHHK(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x72D80F0", Offset = "0x72D6CF0", VA = "0x1872D80F0", Slot = "122")]
	public void GKNIEJKJCLG(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x72D6C00", Offset = "0x72D5800", VA = "0x1872D6C00", Slot = "123")]
	public void DFCKPHMJEFG(object DGGGDIFONNG, bool EHIEEFMLLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x72D62F0", Offset = "0x72D4EF0", VA = "0x1872D62F0", Slot = "124")]
	public void CKKGGKNEILD(Vector3 AOLGKMLAGGH, Quaternion ANBJFHCHGMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x72DB120", Offset = "0x72D9D20", VA = "0x1872DB120", Slot = "125")]
	public void NBBIPCKBAJB(Vector3 FLGJCLBGIEO, Quaternion OGPBFADONDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x72DAED0", Offset = "0x72D9AD0", VA = "0x1872DAED0", Slot = "126")]
	public bool MMIIIFJDFNI(float GBKOKFCKMOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x72D64F0", Offset = "0x72D50F0", VA = "0x1872D64F0", Slot = "127")]
	public void CLLMJPMEJOH(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x72D9510", Offset = "0x72D8110", VA = "0x1872D9510", Slot = "128")]
	public void IODCBJEEJJA(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x72D9D90", Offset = "0x72D8990", VA = "0x1872D9D90", Slot = "129")]
	public void KCIMDBGEJEP(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x72D6160", Offset = "0x72D4D60", VA = "0x1872D6160", Slot = "130")]
	public void BLNDOGCHDLJ(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x72DAF20", Offset = "0x72D9B20", VA = "0x1872DAF20", Slot = "131")]
	public void MONAJLCLIKD(Vector3 KHODILEOPHB, ForceMode PLAPFKADIEB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x72D8DE0", Offset = "0x72D79E0", VA = "0x1872D8DE0", Slot = "132")]
	public void HNILPEAKOIE(Vector3 KHODILEOPHB, Vector3 GKJAMFFKDLE, ForceMode PLAPFKADIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x72D8C80", Offset = "0x72D7880", VA = "0x1872D8C80", Slot = "133")]
	public void HMDHJLIKGOB(Vector3 NJKHALGKIBP, ForceMode PLAPFKADIEB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x72DBE70", Offset = "0x72DAA70", VA = "0x1872DBE70", Slot = "134")]
	public void PLNPLANPAFP(Vector3 NJKHALGKIBP, ForceMode PLAPFKADIEB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x72D7C30", Offset = "0x72D6830", VA = "0x1872D7C30", Slot = "135")]
	public bool FNHJPILPKGF(Vector3 EJOHIEANBFL, [Out] RaycastHit IEALDBEJJDA, float GHBEHFGEGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x72DB2A0", Offset = "0x72D9EA0", VA = "0x1872DB2A0", Slot = "136")]
	public void NEGIONHHPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x72DBF50", Offset = "0x72DAB50", VA = "0x1872DBF50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x72D7DF0", Offset = "0x72D69F0", VA = "0x1872D7DF0")]
	private void GGBGIBHPAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x72D92A0", Offset = "0x72D7EA0", VA = "0x1872D92A0")]
	private void IJFINHLLMPI(DFINIIBCCEP CDBGCEIGNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x72D69D0", Offset = "0x72D55D0", VA = "0x1872D69D0")]
	private void DECDIJBMAHP(DFINIIBCCEP CDBGCEIGNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x72D9460", Offset = "0x72D8060", VA = "0x1872D9460")]
	private void IMJHKPMCDMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x72DA080", Offset = "0x72D8C80", VA = "0x1872DA080")]
	private void KGHIBIAELGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x72DBCC0", Offset = "0x72DA8C0", VA = "0x1872DBCC0")]
	private void PLCAFAMOCLG(DFINIIBCCEP ABLLBFFMFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x72DACD0", Offset = "0x72D98D0", VA = "0x1872DACD0")]
	private void MHCFDCHPJKH(DFINIIBCCEP CDBGCEIGNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x72DBBF0", Offset = "0x72DA7F0", VA = "0x1872DBBF0")]
	private void PJGJNEBBGHP(DFINIIBCCEP CDBGCEIGNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x72D83C0", Offset = "0x72D6FC0", VA = "0x1872D83C0")]
	private void HAMDPGKGNLE(FKDGABLNLMI CDBGCEIGNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x72DA5C0", Offset = "0x72D91C0", VA = "0x1872DA5C0", Slot = "142")]
	protected virtual void LFOIGLLFBEA(FKDGABLNLMI OMKKPDAIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x72D96E0", Offset = "0x72D82E0", VA = "0x1872D96E0")]
	protected void JFIMCKBGPOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x72D8840", Offset = "0x72D7440", VA = "0x1872D8840")]
	protected void HHDLPIPIEBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x72D7F70", Offset = "0x72D6B70", VA = "0x1872D7F70")]
	private void GIKHFAJBBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x72D7080", Offset = "0x72D5C80", VA = "0x1872D7080")]
	private void DMAPEEAINIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class OAJCEALBNPK
{
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x72EA2D0", Offset = "0x72E8ED0", VA = "0x1872EA2D0")]
	public static DFINIIBCCEP HGCNNDLOGPJ(this DFINIIBCCEP OMKKPDAIFOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x72EA120", Offset = "0x72E8D20", VA = "0x1872EA120")]
	public static bool CJNJFOIACJJ(this DFINIIBCCEP OMKKPDAIFOD, DFINIIBCCEP CKEJCMKFPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x72EA230", Offset = "0x72E8E30", VA = "0x1872EA230")]
	public static bool DJHIBDPJCHG(this DFINIIBCCEP OMKKPDAIFOD, DFINIIBCCEP JIFKDAPLLGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x72EA390", Offset = "0x72E8F90", VA = "0x1872EA390")]
	public static FKDGABLNLMI LCJIPBGJOKA(this DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x72EA1C0", Offset = "0x72E8DC0", VA = "0x1872EA1C0")]
	public static DAHMKODHKBA CNJFHAFLCHF(this DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DDJDMCNGFBH : AELOKBLHNHB
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x72DC2E0", Offset = "0x72DAEE0", VA = "0x1872DC2E0", Slot = "19")]
	public DFINIIBCCEP FDJLCEOBNOP(RigidbodyEx OMKKPDAIFOD, JAEAHDCMHEL BFLLAIFBMAJ, JFFPDFPAHFI IGEADGIGICG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "4")]
	public LKDONNFDJPB OGJAANBMCAB(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "5")]
	public ALOBINMGIGI MBCDFFBICIB(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "6")]
	public NEOPDJPHIEJ LPAPIFDPNMK(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "7")]
	public CLAOAFKHALL NACJNBAPMIE(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "8")]
	public PJDMDAEDOMI LJNANOIHGEA(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "9")]
	public EOMKILLKHBM CCBBIGJKLJN(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "10")]
	public LKGLKAPLEGP DEGGHDKPMDA(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "11")]
	public NIJEAICJDJK KMBIOKHEKPH(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "12")]
	public PNNAPPCPBJK GKKBNEBFJLG(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "13")]
	public MOLEHALHAJM HHJCIBJMJGD(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150")]
	public MNMFDKGGPKO HEDNIECONPO(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150")]
	public GPCMOFNAMKH IMBKJMMBHIM(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150")]
	public AFHKGLACOGL LMELBLGKBPP(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150")]
	public DILPHPPPNFK GIMAGAECIFM(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150")]
	public MBKEHAAMEEN NOJFJBLANNP(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public DDJDMCNGFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "14")]
	private MNMFDKGGPKO CPGGMJEJJHB(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "15")]
	private GPCMOFNAMKH BIJFGIANDNH(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "16")]
	private AFHKGLACOGL OOEIMINPJEC(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "17")]
	private DILPHPPPNFK IDPDGLNECLA(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "18")]
	private MBKEHAAMEEN MLDKJLMMICG(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(AELOKBLHNHB), new string[] { })]
public class IGOONHPOFJK : AELOKBLHNHB, PFAELLKIJHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly AELOKBLHNHB IEOHMMDMACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly AELOKBLHNHB FNKLNABHFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private OEHHMGGELGC KPPPCHNHKMA;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private AELOKBLHNHB ABIOBKGJJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x72E2A60", Offset = "0x72E1660", VA = "0x1872E2A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x72E2CB0", Offset = "0x72E18B0", VA = "0x1872E2CB0", Slot = "20")]
	public void InitReferences(JHKOPLPKGAC AOJEPPFAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x72E3180", Offset = "0x72E1D80", VA = "0x1872E3180", Slot = "4")]
	public LKDONNFDJPB OGJAANBMCAB(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x72E2F90", Offset = "0x72E1B90", VA = "0x1872E2F90", Slot = "5")]
	public ALOBINMGIGI MBCDFFBICIB(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x72E2EF0", Offset = "0x72E1AF0", VA = "0x1872E2EF0", Slot = "6")]
	public NEOPDJPHIEJ LPAPIFDPNMK(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x72E30E0", Offset = "0x72E1CE0", VA = "0x1872E30E0", Slot = "7")]
	public CLAOAFKHALL NACJNBAPMIE(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x72E2DA0", Offset = "0x72E19A0", VA = "0x1872E2DA0", Slot = "8")]
	public PJDMDAEDOMI LJNANOIHGEA(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x72E2790", Offset = "0x72E1390", VA = "0x1872E2790", Slot = "9")]
	public EOMKILLKHBM CCBBIGJKLJN(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x72E28E0", Offset = "0x72E14E0", VA = "0x1872E28E0", Slot = "10")]
	public LKGLKAPLEGP DEGGHDKPMDA(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x72E2D00", Offset = "0x72E1900", VA = "0x1872E2D00", Slot = "11")]
	public NIJEAICJDJK KMBIOKHEKPH(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x72E2B70", Offset = "0x72E1770", VA = "0x1872E2B70", Slot = "12")]
	public PNNAPPCPBJK GKKBNEBFJLG(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x72E2C10", Offset = "0x72E1810", VA = "0x1872E2C10", Slot = "13")]
	public MOLEHALHAJM HHJCIBJMJGD(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x72E2830", Offset = "0x72E1430", VA = "0x1872E2830")]
	public MNMFDKGGPKO HEDNIECONPO(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x72E26E0", Offset = "0x72E12E0", VA = "0x1872E26E0")]
	public GPCMOFNAMKH IMBKJMMBHIM(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x72E2E40", Offset = "0x72E1A40", VA = "0x1872E2E40")]
	public AFHKGLACOGL LMELBLGKBPP(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x72E2AC0", Offset = "0x72E16C0", VA = "0x1872E2AC0")]
	public DILPHPPPNFK GIMAGAECIFM(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x72E3030", Offset = "0x72E1C30", VA = "0x1872E3030")]
	public MBKEHAAMEEN NOJFJBLANNP(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x72E2980", Offset = "0x72E1580", VA = "0x1872E2980", Slot = "19")]
	public DFINIIBCCEP FDJLCEOBNOP(RigidbodyEx OMKKPDAIFOD, JAEAHDCMHEL BFLLAIFBMAJ, JFFPDFPAHFI IGEADGIGICG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x72E3220", Offset = "0x72E1E20", VA = "0x1872E3220")]
	public IGOONHPOFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x72E2830", Offset = "0x72E1430", VA = "0x1872E2830", Slot = "14")]
	private MNMFDKGGPKO CPGGMJEJJHB(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x72E26E0", Offset = "0x72E12E0", VA = "0x1872E26E0", Slot = "15")]
	private GPCMOFNAMKH BIJFGIANDNH(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x72E2E40", Offset = "0x72E1A40", VA = "0x1872E2E40", Slot = "16")]
	private AFHKGLACOGL OOEIMINPJEC(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x72E2AC0", Offset = "0x72E16C0", VA = "0x1872E2AC0", Slot = "17")]
	private DILPHPPPNFK IDPDGLNECLA(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x72E3030", Offset = "0x72E1C30", VA = "0x1872E3030", Slot = "18")]
	private MBKEHAAMEEN MLDKJLMMICG(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JHEPFPAELHM : LKDONNFDJPB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KICAOPFBPDO(DFINIIBCCEP OMKKPDAIFOD);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALDLMNKMDLP(DFINIIBCCEP OMKKPDAIFOD);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HJJMOBBKINI(DFINIIBCCEP ABLLBFFMFIH);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OPMAIMBNLJG(DFINIIBCCEP ABLLBFFMFIH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CAGKEHKABDE : NEOPDJPHIEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	FNCCECNEFBI<DFINIIBCCEP> DBMHPPAGPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	DFINIIBCCEP IFILIODCBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FJHCBJPPFBL : DILPHPPPNFK
{
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) JIJFBIJDDLC(Rigidbody JADHDHCIIDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface EHBBOCPJBBN : GPCMOFNAMKH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PhotonView NJAHCCFPDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class FEIMCMGGNNP : PNNAPPCPBJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly DAHMKODHKBA OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private CollisionDetectionMode HIEDGHNFCPL;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody NFEIAPALFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x72DFFD0", Offset = "0x72DEBD0", VA = "0x1872DFFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode NNAIEJLLLNM
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x72E0020", Offset = "0x72DEC20", VA = "0x1872E0020", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x72E0450", Offset = "0x72DF050", VA = "0x1872E0450", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x72E05D0", Offset = "0x72DF1D0", VA = "0x1872E05D0")]
	public FEIMCMGGNNP(DFINIIBCCEP OMKKPDAIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x72E04C0", Offset = "0x72DF0C0", VA = "0x1872E04C0", Slot = "6")]
	public void OJANEOIFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x72E03D0", Offset = "0x72DEFD0", VA = "0x1872E03D0", Slot = "9")]
	public void JPFBDJKNHMK(Rigidbody JOOPKCJCOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x72E0130", Offset = "0x72DED30", VA = "0x1872E0130", Slot = "7")]
	public void ELOGOHEOMOL(bool PHPLIMHIOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x72E03C0", Offset = "0x72DEFC0", VA = "0x1872E03C0", Slot = "8")]
	public void IKDBDDKEIOH(bool PHPLIMHIOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x72E0260", Offset = "0x72DEE60", VA = "0x1872E0260", Slot = "10")]
	public bool FNHJPILPKGF(Vector3 EJOHIEANBFL, [Out] RaycastHit IEALDBEJJDA, float GHBEHFGEGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x72E0140", Offset = "0x72DED40", VA = "0x1872E0140")]
	private void EMHMCCJMPEJ(bool PHPLIMHIOLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class JNNLJJAFNPH : EOMKILLKHBM, IDisposable, OKBBFGNKAGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly DAHMKODHKBA OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private MJNMIJLCBLF KEJEAAKEEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private CPHKHNFBFLI BEFJOFIPGFI;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public MJNMIJLCBLF KDPJGJPBIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x72E3C60", Offset = "0x72E2860", VA = "0x1872E3C60", Slot = "6")]
		get
		{
			return default(MJNMIJLCBLF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x72E3B90", Offset = "0x72E2790", VA = "0x1872E3B90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform HCFFJCJIHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1E49FD0", Offset = "0x1E48BD0", VA = "0x181E49FD0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<PFKPGFLKLMF, PFKPGFLKLMF> DLMOGLDMCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x72E3A90", Offset = "0x72E2690", VA = "0x1872E3A90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x72E39E0", Offset = "0x72E25E0", VA = "0x1872E39E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x72E4010", Offset = "0x72E2C10", VA = "0x1872E4010")]
	public JNNLJJAFNPH(DFINIIBCCEP OMKKPDAIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x72E3DA0", Offset = "0x72E29A0", VA = "0x1872E3DA0", Slot = "8")]
	public void OJANEOIFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x72E3B40", Offset = "0x72E2740", VA = "0x1872E3B40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0xB373A0", Offset = "0xB35FA0", VA = "0x180B373A0", Slot = "11")]
	private void KCCNMLKLFCD(PFKPGFLKLMF KHDFLEEHMMA, PFKPGFLKLMF KMLDFOBGIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "12")]
	private void COIJEABMJDG(bool GJPNLIHNAHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class ECBFOCECFMG : AELOKBLHNHB
{
	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x72DD310", Offset = "0x72DBF10", VA = "0x1872DD310", Slot = "4")]
	public LKDONNFDJPB OGJAANBMCAB(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x72DD090", Offset = "0x72DBC90", VA = "0x1872DD090", Slot = "5")]
	public ALOBINMGIGI MBCDFFBICIB(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x72DCF60", Offset = "0x72DBB60", VA = "0x1872DCF60", Slot = "6")]
	public NEOPDJPHIEJ LPAPIFDPNMK(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x72DD290", Offset = "0x72DBE90", VA = "0x1872DD290", Slot = "7")]
	public CLAOAFKHALL NACJNBAPMIE(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x72DCD60", Offset = "0x72DB960", VA = "0x1872DCD60", Slot = "8")]
	public PJDMDAEDOMI LJNANOIHGEA(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x72DC510", Offset = "0x72DB110", VA = "0x1872DC510", Slot = "9")]
	public EOMKILLKHBM CCBBIGJKLJN(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x72DC720", Offset = "0x72DB320", VA = "0x1872DC720", Slot = "10")]
	public LKGLKAPLEGP DEGGHDKPMDA(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x72DCCA0", Offset = "0x72DB8A0", VA = "0x1872DCCA0", Slot = "11")]
	public NIJEAICJDJK KMBIOKHEKPH(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x72DCB20", Offset = "0x72DB720", VA = "0x1872DCB20", Slot = "12")]
	public PNNAPPCPBJK GKKBNEBFJLG(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x72DCBE0", Offset = "0x72DB7E0", VA = "0x1872DCBE0", Slot = "13")]
	public MOLEHALHAJM HHJCIBJMJGD(DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x72DC5E0", Offset = "0x72DB1E0", VA = "0x1872DC5E0")]
	public MNMFDKGGPKO HEDNIECONPO(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x72DC380", Offset = "0x72DAF80", VA = "0x1872DC380")]
	public GPCMOFNAMKH IMBKJMMBHIM(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x72DCE30", Offset = "0x72DBA30", VA = "0x1872DCE30")]
	public AFHKGLACOGL LMELBLGKBPP(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x72DC990", Offset = "0x72DB590", VA = "0x1872DC990")]
	public DILPHPPPNFK GIMAGAECIFM(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x72DD1B0", Offset = "0x72DBDB0", VA = "0x1872DD1B0")]
	public MBKEHAAMEEN NOJFJBLANNP(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x72DC840", Offset = "0x72DB440", VA = "0x1872DC840", Slot = "19")]
	public DFINIIBCCEP FDJLCEOBNOP(RigidbodyEx OMKKPDAIFOD, JAEAHDCMHEL BFLLAIFBMAJ, JFFPDFPAHFI IGEADGIGICG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public ECBFOCECFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x72DC5E0", Offset = "0x72DB1E0", VA = "0x1872DC5E0", Slot = "14")]
	private MNMFDKGGPKO CPGGMJEJJHB(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x72DC380", Offset = "0x72DAF80", VA = "0x1872DC380", Slot = "15")]
	private GPCMOFNAMKH BIJFGIANDNH(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x72DCE30", Offset = "0x72DBA30", VA = "0x1872DCE30", Slot = "16")]
	private AFHKGLACOGL OOEIMINPJEC(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x72DC990", Offset = "0x72DB590", VA = "0x1872DC990", Slot = "17")]
	private DILPHPPPNFK IDPDGLNECLA(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x72DD1B0", Offset = "0x72DBDB0", VA = "0x1872DD1B0", Slot = "18")]
	private MBKEHAAMEEN MLDKJLMMICG(DFINIIBCCEP GMBKDDMMMLD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class PJJJPOBLELD : NIJEAICJDJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly DAHMKODHKBA OMKKPDAIFOD;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody NFEIAPALFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x72DFFD0", Offset = "0x72DEBD0", VA = "0x1872DFFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool DPJLPEODCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x72EB1A0", Offset = "0x72E9DA0", VA = "0x1872EB1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool CIIKKBJHNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x72E9BE0", Offset = "0x72E87E0", VA = "0x1872E9BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private DFINIIBCCEP GGAFGBKJIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x72EB830", Offset = "0x72EA430", VA = "0x1872EB830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x72E05D0", Offset = "0x72DF1D0", VA = "0x1872E05D0")]
	public PJJJPOBLELD(DFINIIBCCEP OMKKPDAIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x72EBAF0", Offset = "0x72EA6F0", VA = "0x1872EBAF0", Slot = "4")]
	public void MONAJLCLIKD(Vector3 KHODILEOPHB, ForceMode PLAPFKADIEB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x72EB1F0", Offset = "0x72E9DF0", VA = "0x1872EB1F0")]
	private void GBNEDHIOKEC(Vector3 KHODILEOPHB, ForceMode PLAPFKADIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x72EB5B0", Offset = "0x72EA1B0", VA = "0x1872EB5B0", Slot = "5")]
	public void HNILPEAKOIE(Vector3 KHODILEOPHB, Vector3 GKJAMFFKDLE, ForceMode PLAPFKADIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x72EB450", Offset = "0x72EA050", VA = "0x1872EB450", Slot = "6")]
	public void HMDHJLIKGOB(Vector3 NJKHALGKIBP, ForceMode PLAPFKADIEB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x72EB890", Offset = "0x72EA490", VA = "0x1872EB890")]
	private void MBOODGAMAFD(Vector3 NJKHALGKIBP, ForceMode PLAPFKADIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x72EBC50", Offset = "0x72EA850", VA = "0x1872EBC50", Slot = "7")]
	public void PLNPLANPAFP(Vector3 NJKHALGKIBP, ForceMode PLAPFKADIEB = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class GPNKKHEALMG : MOLEHALHAJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly DAHMKODHKBA OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool ADAFLIKLKPA;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool PFADAKEGFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA22440", Offset = "0xA21040", VA = "0x180A22440", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x72E06D0", Offset = "0x72DF2D0", VA = "0x1872E06D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x72E05D0", Offset = "0x72DF1D0", VA = "0x1872E05D0")]
	public GPNKKHEALMG(DFINIIBCCEP OMKKPDAIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x72E07E0", Offset = "0x72DF3E0", VA = "0x1872E07E0", Slot = "6")]
	public void JPFBDJKNHMK(Rigidbody JOOPKCJCOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x72E0660", Offset = "0x72DF260", VA = "0x1872E0660", Slot = "7")]
	public void EBOCOPFFCBG(Rigidbody JOOPKCJCOGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class HGHFGKPBMIN : JHEPFPAELHM, LKDONNFDJPB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly DFINIIBCCEP OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<DFINIIBCCEP> MOCPBBBMMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private DFINIIBCCEP AHFIDHNOIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private DFINIIBCCEP CDBGCEIGNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private Transform IEHMFOJAIOK;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform DJCNFDBJOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x72E21B0", Offset = "0x72E0DB0", VA = "0x1872E21B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public DFINIIBCCEP GGAFGBKJIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x88C490", Offset = "0x88B090", VA = "0x18088C490", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x72E08B0", Offset = "0x72DF4B0", VA = "0x1872E08B0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public DFINIIBCCEP JAFALLCEFOE
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x88C610", Offset = "0x88B210", VA = "0x18088C610", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<DFINIIBCCEP> BPNOAFLHNMF
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x88D710", Offset = "0x88C310", VA = "0x18088D710", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event FANCDFLCCOJ IPMBNNJCPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x72E0C90", Offset = "0x72DF890", VA = "0x1872E0C90", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x72E0FA0", Offset = "0x72DFBA0", VA = "0x1872E0FA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event FANCDFLCCOJ HJHJLJPPEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x72E1D70", Offset = "0x72E0970", VA = "0x1872E1D70", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x72E1870", Offset = "0x72E0470", VA = "0x1872E1870", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event BEKLGGOJFJM AKPBGIBNKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x72E1710", Offset = "0x72E0310", VA = "0x1872E1710", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x72E1910", Offset = "0x72E0510", VA = "0x1872E1910", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action PCGCBGJGLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x72E0810", Offset = "0x72DF410", VA = "0x1872E0810", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x72E0F00", Offset = "0x72DFB00", VA = "0x1872E0F00", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action MLMFANJAOAB
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x72E0970", Offset = "0x72DF570", VA = "0x1872E0970", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x72E1CD0", Offset = "0x72E08D0", VA = "0x1872E1CD0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<DFINIIBCCEP> OPCDIIBPFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x72E0A10", Offset = "0x72DF610", VA = "0x1872E0A10", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x72E08C0", Offset = "0x72DF4C0", VA = "0x1872E08C0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<DFINIIBCCEP> LGFJCOKEHNG
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x72E1C20", Offset = "0x72E0820", VA = "0x1872E1C20", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x72E2060", Offset = "0x72E0C60", VA = "0x1872E2060", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action LOAPAIIJAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x72E0E60", Offset = "0x72DFA60", VA = "0x1872E0E60", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x72E2110", Offset = "0x72E0D10", VA = "0x1872E2110", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<DFINIIBCCEP> JAGBHFOGBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x72E1040", Offset = "0x72DFC40", VA = "0x1872E1040", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x72E2210", Offset = "0x72E0E10", VA = "0x1872E2210", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x72E2620", Offset = "0x72E1220", VA = "0x1872E2620")]
	public HGHFGKPBMIN(DFINIIBCCEP OMKKPDAIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x72E10F0", Offset = "0x72DFCF0", VA = "0x1872E10F0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x72E1190", Offset = "0x72DFD90", VA = "0x1872E1190", Slot = "30")]
	public void EOIGELPPMDL(DFINIIBCCEP NDJJLBGHFGF, bool IHBDDDGGBPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x72E19B0", Offset = "0x72E05B0", VA = "0x1872E19B0", Slot = "6")]
	public void HJJMOBBKINI(DFINIIBCCEP ABLLBFFMFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x72E2300", Offset = "0x72E0F00", VA = "0x1872E2300", Slot = "7")]
	public void OPMAIMBNLJG(DFINIIBCCEP ABLLBFFMFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x72E1F50", Offset = "0x72E0B50", VA = "0x1872E1F50", Slot = "4")]
	public void KICAOPFBPDO(DFINIIBCCEP OMKKPDAIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x72E0AC0", Offset = "0x72DF6C0", VA = "0x1872E0AC0", Slot = "5")]
	public void ALDLMNKMDLP(DFINIIBCCEP OMKKPDAIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x72E2580", Offset = "0x72E1180", VA = "0x1872E2580")]
	private void PEONJHHMIDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x72E22C0", Offset = "0x72E0EC0", VA = "0x1872E22C0")]
	private void OMAJLEAEDME(DFINIIBCCEP ABLLBFFMFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x72E1E10", Offset = "0x72E0A10", VA = "0x1872E1E10")]
	private void JGKCPNJPAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x72E0D30", Offset = "0x72DF930", VA = "0x1872E0D30")]
	private void BNLOENDOMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x72E0B60", Offset = "0x72DF760", VA = "0x1872E0B60")]
	private void BFPHNKBAEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x72E17B0", Offset = "0x72E03B0", VA = "0x1872E17B0")]
	[CompilerGenerated]
	private object GNDIBOAJGNN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class DDEGIPLABCG
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x72DC080", Offset = "0x72DAC80", VA = "0x1872DC080")]
	public static JHEPFPAELHM APFJABBJNFN(this DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class LPBMFCGLHAF : CAGKEHKABDE, NEOPDJPHIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly DAHMKODHKBA OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly FNCCECNEFBI<DFINIIBCCEP> GGCCMIGDCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private bool KEONKGKCALD;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public FNCCECNEFBI<DFINIIBCCEP> DBMHPPAGPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 NCKIOCCKCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x72E54A0", Offset = "0x72E40A0", VA = "0x1872E54A0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 KAPPNMLNCME
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x72E5650", Offset = "0x72E4250", VA = "0x1872E5650", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 EOAIJNEBOIA
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x72E5810", Offset = "0x72E4410", VA = "0x1872E5810")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public DFINIIBCCEP IFILIODCBLG
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x72E54D0", Offset = "0x72E40D0", VA = "0x1872E54D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x72E5CA0", Offset = "0x72E48A0", VA = "0x1872E5CA0")]
	public LPBMFCGLHAF(DFINIIBCCEP OMKKPDAIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x72E55E0", Offset = "0x72E41E0", VA = "0x1872E55E0", Slot = "8")]
	public void LBEKNKMBJEK(DFINIIBCCEP CDBGCEIGNJC, object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x72E5580", Offset = "0x72E4180", VA = "0x1872E5580", Slot = "9")]
	public void KHLLICELNHA(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x72E5900", Offset = "0x72E4500", VA = "0x1872E5900")]
	private Vector3 OKKJAMGHEHF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x72E5110", Offset = "0x72E3D10", VA = "0x1872E5110")]
	private void GODEBBCOGAC(DFINIIBCCEP NHGOMKKONHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class COLGAPIOHOG
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x72D58D0", Offset = "0x72D44D0", VA = "0x1872D58D0")]
	public static CAGKEHKABDE HGJOIJKNMMJ(this DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class FCNJLEMGDCK : FJHCBJPPFBL, DILPHPPPNFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly DAHMKODHKBA OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 LIEOAJBFBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly OverridableVector3 IIEDKJMDIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float MCMCPAMEIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float MDJNHCCIINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3 PKMEJPDIAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Vector3? ELANOGBCBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private Quaternion? HFEAOFBGEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool AIIPEOLIPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool AFJMGDLFOIN;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 EHEFDHIKAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xF47AB0", Offset = "0xF466B0", VA = "0x180F47AB0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x72DDA60", Offset = "0x72DC660", VA = "0x1872DDA60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 KBNEBOGPGBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x72DFBE0", Offset = "0x72DE7E0", VA = "0x1872DFBE0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float BIFIDJPGNNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA22460", Offset = "0xA21060", VA = "0x180A22460", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x72DDCF0", Offset = "0x72DC8F0", VA = "0x1872DDCF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float MBNFAEGAHNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xA22450", Offset = "0xA21050", VA = "0x180A22450", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x72DD9B0", Offset = "0x72DC5B0", VA = "0x1872DD9B0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 ECPEKKJNEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x72DFA50", Offset = "0x72DE650", VA = "0x1872DFA50", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion LCBDHCOEPDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x72DDE00", Offset = "0x72DCA00", VA = "0x1872DDE00", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody NFEIAPALFII
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x72DD960", Offset = "0x72DC560", VA = "0x1872DD960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event FANCDFLCCOJ BFKBNHCNOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x72DF9B0", Offset = "0x72DE5B0", VA = "0x1872DF9B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x72DDF80", Offset = "0x72DCB80", VA = "0x1872DDF80", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x72DFE70", Offset = "0x72DEA70", VA = "0x1872DFE70")]
	public FCNJLEMGDCK(DFINIIBCCEP OMKKPDAIFOD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x72DF370", Offset = "0x72DDF70", VA = "0x1872DF370", Slot = "17")]
	public void KDNJNMKPHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x72DE020", Offset = "0x72DCC20", VA = "0x1872DE020", Slot = "16")]
	public void GIOFKEMGBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x72DF290", Offset = "0x72DDE90", VA = "0x1872DF290", Slot = "19")]
	public void JPFBDJKNHMK(Rigidbody JOOPKCJCOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x72DDB10", Offset = "0x72DC710", VA = "0x1872DDB10", Slot = "20")]
	public void EBOCOPFFCBG(Rigidbody JOOPKCJCOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x72DD7B0", Offset = "0x72DC3B0", VA = "0x1872DD7B0", Slot = "18")]
	public void BCCMDDNHIFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x72DF520", Offset = "0x72DE120", VA = "0x1872DF520", Slot = "21")]
	public void NEGIONHHPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x72DDA60", Offset = "0x72DC660", VA = "0x1872DDA60")]
	private void OPIMJIDKAHB(Vector3 CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x72DE100", Offset = "0x72DCD00", VA = "0x1872DE100")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 GMADOJEILCG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x72DDCF0", Offset = "0x72DC8F0", VA = "0x1872DDCF0")]
	private void ENBOLJEEIOH(float CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x72DD9B0", Offset = "0x72DC5B0", VA = "0x1872DD9B0")]
	private void CKPBDGCNALK(float CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x72DFCD0", Offset = "0x72DE8D0", VA = "0x1872DFCD0")]
	private Vector3 PCPKEBKBLEL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x72DF060", Offset = "0x72DDC60", VA = "0x1872DF060", Slot = "15")]
	public void JLEFIBPFBOG((Quaternion rot, Vector3 moments) GEGLIBHENMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x72DD630", Offset = "0x72DC230", VA = "0x1872DD630")]
	private Quaternion AOKDDMJJDFE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x72DE1F0", Offset = "0x72DCDF0", VA = "0x1872DE1F0")]
	public void JIJFBIJDDLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x72DE2C0", Offset = "0x72DCEC0", VA = "0x1872DE2C0", Slot = "4")]
	public (float, Vector3) JIJFBIJDDLC(Rigidbody JADHDHCIIDJ)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class AOKKEEDKPPE
{
	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x72D5310", Offset = "0x72D3F10", VA = "0x1872D5310")]
	public static FJHCBJPPFBL HODJNDLCENK(this DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class JFLKOAHLIEM : AFHKGLACOGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly DAHMKODHKBA OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly GFFNOHKJGNM JFJFMANPFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly EGPFJKHDCKA GGPFMEACCMA;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool HHMDMDCGPBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x10DDEE0", Offset = "0x10DCAE0", VA = "0x1810DDEE0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public EGPFJKHDCKA OGMJHMCEPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FA0", Offset = "0x8E8BA0", VA = "0x1808E9FA0", Slot = "11")]
		get
		{
			return default(EGPFJKHDCKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x72E38E0", Offset = "0x72E24E0", VA = "0x1872E38E0")]
	public JFLKOAHLIEM(DFINIIBCCEP OMKKPDAIFOD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x72E37D0", Offset = "0x72E23D0", VA = "0x1872E37D0", Slot = "4")]
	public void OJANEOIFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x72E3570", Offset = "0x72E2170", VA = "0x1872E3570")]
	private bool HKIOCFPKOEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x72E3540", Offset = "0x72E2140", VA = "0x1872E3540", Slot = "5")]
	public void HIPGHMJFJIG(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x72E32D0", Offset = "0x72E1ED0", VA = "0x1872E32D0", Slot = "6")]
	public void BJCPOLGELFA(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x72E3410", Offset = "0x72E2010", VA = "0x1872E3410", Slot = "9")]
	public void EEAJDJFFGJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x72E3300", Offset = "0x72E1F00", VA = "0x1872E3300")]
	private void DLABKDIJIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x72E3610", Offset = "0x72E2210", VA = "0x1872E3610")]
	private void IFABHKJDJFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x72E3790", Offset = "0x72E2390", VA = "0x1872E3790", Slot = "8")]
	public void NGGAMCKLKKG(DFINIIBCCEP OMKKPDAIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x72E38A0", Offset = "0x72E24A0", VA = "0x1872E38A0", Slot = "7")]
	public void PAANNFGFPPC(DFINIIBCCEP OMKKPDAIFOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class CJFBEJNAIHJ : LKGLKAPLEGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly DAHMKODHKBA OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly GFFNOHKJGNM OEFDNNKOKBI;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool DPJLPEODCNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x72D5470", Offset = "0x72D4070", VA = "0x1872D5470", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event FANCDFLCCOJ OBIKLCHEHLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x72D53D0", Offset = "0x72D3FD0", VA = "0x1872D53D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x72D5740", Offset = "0x72D4340", VA = "0x1872D5740", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x72D57E0", Offset = "0x72D43E0", VA = "0x1872D57E0")]
	public CJFBEJNAIHJ(DFINIIBCCEP OMKKPDAIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x72D5670", Offset = "0x72D4270", VA = "0x1872D5670", Slot = "7")]
	public void HIGHALKIHHK(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x72D5660", Offset = "0x72D4260", VA = "0x1872D5660", Slot = "8")]
	public void GKNIEJKJCLG(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x72D5520", Offset = "0x72D4120", VA = "0x1872D5520", Slot = "9")]
	public void DFCKPHMJEFG(object DGGGDIFONNG, bool EHIEEFMLLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x72D5680", Offset = "0x72D4280", VA = "0x1872D5680", Slot = "12")]
	public void HJOJHNACFMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x72D56C0", Offset = "0x72D42C0", VA = "0x1872D56C0", Slot = "10")]
	public void JPFBDJKNHMK(Rigidbody DOMJNFIKOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x72D5630", Offset = "0x72D4230", VA = "0x1872D5630", Slot = "11")]
	public void EBOCOPFFCBG(Rigidbody JOOPKCJCOGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class OIBHBAFOOIN : EHBBOCPJBBN, GPCMOFNAMKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly DAHMKODHKBA OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private PhotonView ALIHIEOGJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool PBJGENMBOKH;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView NJAHCCFPDGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool AIPMNIELNMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x72EA650", Offset = "0x72E9250", VA = "0x1872EA650", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool JGIANDHMAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x9157C0", Offset = "0x9143C0", VA = "0x1809157C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event FANCDFLCCOJ OAGEABIHGLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x72EA8E0", Offset = "0x72E94E0", VA = "0x1872EA8E0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x72EA980", Offset = "0x72E9580", VA = "0x1872EA980", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x72EAF80", Offset = "0x72E9B80", VA = "0x1872EAF80")]
	public OIBHBAFOOIN(DFINIIBCCEP OMKKPDAIFOD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x72EAB90", Offset = "0x72E9790", VA = "0x1872EAB90", Slot = "9")]
	public void OJANEOIFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x72EA7E0", Offset = "0x72E93E0", VA = "0x1872EA7E0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x72EAA20", Offset = "0x72E9620", VA = "0x1872EAA20", Slot = "10")]
	public void MHCFDCHPJKH(DFINIIBCCEP CDBGCEIGNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x72EAE10", Offset = "0x72E9A10", VA = "0x1872EAE10", Slot = "11")]
	public void PJGJNEBBGHP(DFINIIBCCEP CDBGCEIGNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x72EA670", Offset = "0x72E9270", VA = "0x1872EA670")]
	private void DGHPDNEENKH(PhotonView FBLPHFDKJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x72EACC0", Offset = "0x72E98C0", VA = "0x1872EACC0")]
	private void OKLJEDLGGBC(FKDGABLNLMI GFALBMGOGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x72EA3E0", Offset = "0x72E8FE0", VA = "0x1872EA3E0")]
	private void BEKHJJICHAB(PhotonView MICIHDJBBJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class ANMIDOFAPIA
{
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x72D5250", Offset = "0x72D3E50", VA = "0x1872D5250")]
	public static EHBBOCPJBBN AOAIFEKKGOC(this DFINIIBCCEP GMBKDDMMMLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class EFGJOHEABFC : MBKEHAAMEEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly DAHMKODHKBA OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private RigidbodyConstraints AINIPHMCKCE;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool BEFLOIPKEOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA223E0", Offset = "0xA20FE0", VA = "0x180A223E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x1EA68D0", Offset = "0x1EA54D0", VA = "0x181EA68D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool IMFIBCNPEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA223F0", Offset = "0xA20FF0", VA = "0x180A223F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x1EA61E0", Offset = "0x1EA4DE0", VA = "0x181EA61E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints HGFMKNEOENL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8866B0", VA = "0x180887AB0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x72DD430", Offset = "0x72DC030", VA = "0x1872DD430", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x72DD590", Offset = "0x72DC190", VA = "0x1872DD590")]
	public EFGJOHEABFC(DFINIIBCCEP OMKKPDAIFOD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x72DD560", Offset = "0x72DC160", VA = "0x1872DD560", Slot = "9")]
	public void JPFBDJKNHMK(Rigidbody JOOPKCJCOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x72DD400", Offset = "0x72DC000", VA = "0x1872DD400", Slot = "10")]
	public void EBOCOPFFCBG(Rigidbody JOOPKCJCOGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class MAKPBMDDFHG : CLAOAFKHALL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly DFINIIBCCEP OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float DILIKGMIDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private float HODFGNLOPME;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float HIIPFEDIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x918F20", Offset = "0x917B20", VA = "0x180918F20", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x72E5EB0", Offset = "0x72E4AB0", VA = "0x1872E5EB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float OBKAELLMFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA622D0", Offset = "0xA60ED0", VA = "0x180A622D0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x72E6070", Offset = "0x72E4C70", VA = "0x1872E6070", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x72E6140", Offset = "0x72E4D40", VA = "0x1872E6140")]
	public MAKPBMDDFHG(DFINIIBCCEP OMKKPDAIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x72E6020", Offset = "0x72E4C20", VA = "0x1872E6020", Slot = "8")]
	public void JPFBDJKNHMK(Rigidbody JOOPKCJCOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x72E5F80", Offset = "0x72E4B80", VA = "0x1872E5F80", Slot = "9")]
	public void EBOCOPFFCBG(Rigidbody JOOPKCJCOGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class LOHKBJKKHIM : PJDMDAEDOMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly BNHLDIHMNLF LDKDLPMMLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private GBDAFNIGKIP MHGDJMNNKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly DAHMKODHKBA OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private bool FKENHBGEFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private bool NPNEDDKHJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int PGAOIFFPKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool MFIADPEPAME;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody NFEIAPALFII
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x72E4130", Offset = "0x72E2D30", VA = "0x1872E4130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool NCJPKDPPCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x72E4110", Offset = "0x72E2D10", VA = "0x1872E4110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private DFINIIBCCEP GGAFGBKJIIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x72E4850", Offset = "0x72E3450", VA = "0x1872E4850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool CIIKKBJHNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x72E4AA0", Offset = "0x72E36A0", VA = "0x1872E4AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event FANCDFLCCOJ ABDHGDHAPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x72E4B00", Offset = "0x72E3700", VA = "0x1872E4B00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x72E4650", Offset = "0x72E3250", VA = "0x1872E4650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x72E5080", Offset = "0x72E3C80", VA = "0x1872E5080")]
	public LOHKBJKKHIM(DFINIIBCCEP OMKKPDAIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x72E4DA0", Offset = "0x72E39A0", VA = "0x1872E4DA0", Slot = "6")]
	public void OJANEOIFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x72E42A0", Offset = "0x72E2EA0", VA = "0x1872E42A0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x72E4840", Offset = "0x72E3440", VA = "0x1872E4840", Slot = "8")]
	public void JHHCLFAFDJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x72E46F0", Offset = "0x72E32F0", VA = "0x1872E46F0", Slot = "7")]
	public bool IKCEGMJLJMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x72E4380", Offset = "0x72E2F80", VA = "0x1872E4380", Slot = "9")]
	public void GCGKNLEBBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x72E48B0", Offset = "0x72E34B0", VA = "0x1872E48B0")]
	private void LKHPACMAECK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x72E4F60", Offset = "0x72E3B60", VA = "0x1872E4F60", Slot = "13")]
	public void OMGKNMJGCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x72E4180", Offset = "0x72E2D80", VA = "0x1872E4180", Slot = "12")]
	public void DKKBEPGDAMG(bool LKIOELBHPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x72E4BA0", Offset = "0x72E37A0", VA = "0x1872E4BA0", Slot = "10")]
	public bool NAAPIOEAHOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x72E4970", Offset = "0x72E3570", VA = "0x1872E4970", Slot = "11")]
	public bool LMFGJOCMIGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x72E4470", Offset = "0x72E3070", VA = "0x1872E4470")]
	private bool GHGJLFMNACC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x72E4C10", Offset = "0x72E3810", VA = "0x1872E4C10")]
	private void OBMFOBMNLJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class NBLOBACHHIJ : MNMFDKGGPKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly DAHMKODHKBA OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly GFFNOHKJGNM HKABPAMJJBA;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody NFEIAPALFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x888260", Offset = "0x886E60", VA = "0x180888260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool CIIKKBJHNAF
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x72E9BE0", Offset = "0x72E87E0", VA = "0x1872E9BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool PFEJGNGOCEG
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x10DDEE0", Offset = "0x10DCAE0", VA = "0x1810DDEE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x72EA010", Offset = "0x72E8C10", VA = "0x1872EA010")]
	public NBLOBACHHIJ(DFINIIBCCEP OMKKPDAIFOD, [In] JAEAHDCMHEL BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x72E9F70", Offset = "0x72E8B70", VA = "0x1872E9F70", Slot = "5")]
	public void OJANEOIFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x72E9A30", Offset = "0x72E8630", VA = "0x1872E9A30", Slot = "7")]
	public void KCIMDBGEJEP(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x72E9810", Offset = "0x72E8410", VA = "0x1872E9810", Slot = "8")]
	public void BLNDOGCHDLJ(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x72E9C40", Offset = "0x72E8840", VA = "0x1872E9C40", Slot = "9")]
	public void NMMAHFBLAEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x72E9840", Offset = "0x72E8440", VA = "0x1872E9840", Slot = "10")]
	public void DLLDDAHLPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x72E9A60", Offset = "0x72E8660", VA = "0x1872E9A60", Slot = "11")]
	public void KJFDDDLBGBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class MMAJEDKNEBF : ALOBINMGIGI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly DAHMKODHKBA OMKKPDAIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly GFFNOHKJGNM IOEIMGNIBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private float POLCFGAGAIO;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public HFNNNBLDCNA GIGBCDDIFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x88ABC0", Offset = "0x8897C0", VA = "0x18088ABC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public NHFCKNCOFHL BNJCKKMAIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x887AE0", Offset = "0x8866E0", VA = "0x180887AE0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 EOAIJNEBOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x72E94B0", Offset = "0x72E80B0", VA = "0x1872E94B0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x72E6E40", Offset = "0x72E5A40", VA = "0x1872E6E40", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 CMDPGAKIAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x72E6180", Offset = "0x72E4D80", VA = "0x1872E6180", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x72E8CB0", Offset = "0x72E78B0", VA = "0x1872E8CB0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 JOPLOAMFBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x72E8320", Offset = "0x72E6F20", VA = "0x1872E8320", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x72E9390", Offset = "0x72E7F90", VA = "0x1872E9390", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 JKOEHFPKHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x72E9270", Offset = "0x72E7E70", VA = "0x1872E9270", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x72E7A70", Offset = "0x72E6670", VA = "0x1872E7A70", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float PGLPJNKMDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA22470", Offset = "0xA21070", VA = "0x180A22470", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x72E7AA0", Offset = "0x72E66A0", VA = "0x1872E7AA0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool JHLECMNIDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x1AA6F60", Offset = "0x1AA5B60", VA = "0x181AA6F60", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private NIJEAICJDJK GDFPPGBNEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6A79840", Offset = "0x6A78440", VA = "0x186A79840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool NCJPKDPPCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x72E62A0", Offset = "0x72E4EA0", VA = "0x1872E62A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x72E9720", Offset = "0x72E8320", VA = "0x1872E9720")]
	public MMAJEDKNEBF(DFINIIBCCEP OMKKPDAIFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x72E79D0", Offset = "0x72E65D0", VA = "0x1872E79D0", Slot = "19")]
	public void OJANEOIFOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x72E6F00", Offset = "0x72E5B00", VA = "0x1872E6F00", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x72E81F0", Offset = "0x72E6DF0", VA = "0x1872E81F0", Slot = "28")]
	public void JPFBDJKNHMK(Rigidbody JOOPKCJCOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0xEFC320", Offset = "0xEFAF20", VA = "0x180EFC320", Slot = "20")]
	public void JBLAMDMJFHF(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xEFB4A0", Offset = "0xEFA0A0", VA = "0x180EFB4A0", Slot = "30")]
	public void LDGCDKIEHHO(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x72E7CC0", Offset = "0x72E68C0", VA = "0x1872E7CC0", Slot = "35")]
	public Vector3 IHELIJDHFPA(Vector3 HFNEPAGLJGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x72E7EA0", Offset = "0x72E6AA0", VA = "0x1872E7EA0", Slot = "34")]
	public Vector3 IHMLDBIKGFH(Vector3 BMFLMHGGHPH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x72E79D0", Offset = "0x72E65D0", VA = "0x1872E79D0", Slot = "27")]
	public void GGOKAJCLLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x72E9160", Offset = "0x72E7D60", VA = "0x1872E9160", Slot = "25")]
	public void LPNDIEIGBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x72E9450", Offset = "0x72E8050", VA = "0x1872E9450", Slot = "24")]
	public void NLMJJHCEFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x72E8470", Offset = "0x72E7070", VA = "0x1872E8470", Slot = "33")]
	public void KGCMLBIIHEF(Vector3 NMOGPAJJGNL, Vector3 ACFFMBMNFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x72E86B0", Offset = "0x72E72B0", VA = "0x1872E86B0", Slot = "32")]
	public void KOOFMIMPJDP(Vector3 DNLPADGICAN, Vector3 LPPLMKNAGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x72E6820", Offset = "0x72E5420", VA = "0x1872E6820", Slot = "31")]
	public void DEBLGFDAICC(Vector3 JDDIPPFHEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x72E71E0", Offset = "0x72E5DE0", VA = "0x1872E71E0", Slot = "22")]
	public void EMABLOKJGCM(MFONMFNDNGL IDGIIMMBCIL, Vector3 PKIIFMCPGDK, float LIOFPKPIJFM, float CIIBCKHLCED = 8f, float JPLEKJHIBBE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x72E6F60", Offset = "0x72E5B60", VA = "0x1872E6F60", Slot = "21")]
	public void EJOGIOHDDPJ(MILNJDMBAGC ANAPHKLDGNK, Vector3 PMMICEJDCDH, float EGOPDCFEMMN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x72E8CE0", Offset = "0x72E78E0", VA = "0x1872E8CE0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LHGIJKKBMAH(MILNJDMBAGC ANAPHKLDGNK, Vector3 EAGKGJHHIJH, float LGJEAIELNIF = 7f, float ANDNDMFDKEN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x102B890", Offset = "0x102A490", VA = "0x18102B890")]
	private static void EAMINPFJILN(Vector3 MDMLBPNGPMJ, Vector3 DJCDKMIHKHG, [Out] Vector3 DGCFMLGHEKO, [Out] Vector3 JPPOPGHCCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x72E62C0", Offset = "0x72E4EC0", VA = "0x1872E62C0", Slot = "29")]
	public Vector3 APMIFMPDGIC(Vector3 MDMLBPNGPMJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x72E8060", Offset = "0x72E6C60", VA = "0x1872E8060", Slot = "26")]
	public void JJNOPMIDNNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x72E7AA0", Offset = "0x72E66A0", VA = "0x1872E7AA0")]
	private void LHFDFFJFFHO(float CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x72E7830", Offset = "0x72E6430", VA = "0x1872E7830")]
	private void FKKBJBOBCIB(Vector3 PMMICEJDCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x72E7BB0", Offset = "0x72E67B0", VA = "0x1872E7BB0")]
	private Vector3 ICLNNMMMIDE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x72E63A0", Offset = "0x72E4FA0", VA = "0x1872E63A0")]
	private void DEAFLGKLABC(Vector3 BMFLMHGGHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x72E9600", Offset = "0x72E8200", VA = "0x1872E9600")]
	private Vector3 PFGLLJFDDNB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x72E69C0", Offset = "0x72E55C0", VA = "0x1872E69C0")]
	private void DFMHMFNCEEJ(Vector3 CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x72E8710", Offset = "0x72E7310", VA = "0x1872E8710")]
	private void KPMPNHDGIHM(Vector3 BMFLMHGGHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x72E91C0", Offset = "0x72E7DC0", VA = "0x1872E91C0")]
	private void MAGLKKFJNLC()
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
