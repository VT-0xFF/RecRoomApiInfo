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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x828DE90", Offset = "0x828C690", VA = "0x18828DE90", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2025EF0", Offset = "0x20246F0", VA = "0x182025EF0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x829A1C0", Offset = "0x82989C0", VA = "0x18829A1C0")]
		private void BEJJPGDKNLF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x829A4C0", Offset = "0x8298CC0", VA = "0x18829A4C0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x829A520", Offset = "0x8298D20", VA = "0x18829A520")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, PHIEGKANMEI, BBHLBLBMBEP, FHPNLFOOILK
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly LLPKKNNAIAE PKHLIFABFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool LOKKPDCJIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private GDKBCAGCEIA CDBLFAPBJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[FCBJLJFBGGB(HNCMILCNFNF.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[FCBJLJFBGGB(HNCMILCNFNF.SelfAndParent, true, false, false)]
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
		private LBIAHMGKBGM physicsInterpolation;

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
		private Transform KACHHHIDHKG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal GDKBCAGCEIA PEBAEBIABCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x82957E0", Offset = "0x8293FE0", VA = "0x1882957E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private GDKBCAGCEIA CCFFBAGJPBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int LKGPMNCFJNH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x82976D0", Offset = "0x8295ED0", VA = "0x1882976D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx DOLIPPDPAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8297A30", Offset = "0x8296230", VA = "0x188297A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx DFJAHCLMMPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8297970", Offset = "0x8296170", VA = "0x188297970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx DFPCBMGPBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8298630", Offset = "0x8296E30", VA = "0x188298630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8299B30", Offset = "0x8298330", VA = "0x188299B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool GJDHMDIAJII
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7EFFE20", Offset = "0x7EFE620", VA = "0x187EFFE20", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7F005E0", Offset = "0x7EFEDE0", VA = "0x187F005E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform POFBAOBKAGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1E5D660", Offset = "0x1E5BE60", VA = "0x181E5D660", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform LINHCOLMAGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1E5D660", Offset = "0x1E5BE60", VA = "0x181E5D660", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform IGFDKOONDGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1E5D660", Offset = "0x1E5BE60", VA = "0x181E5D660", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LDLKAPLIJLM EOGPKINPGDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8297730", Offset = "0x8295F30", VA = "0x188297730")]
			get
			{
				return default(LDLKAPLIJLM);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x82992E0", Offset = "0x8297AE0", VA = "0x1882992E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool JAPKJEKLGAB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8297D40", Offset = "0x8296540", VA = "0x188297D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool CCLBBOJOHDE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8297850", Offset = "0x8296050", VA = "0x188297850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CHJDOPIOJPF DJGPCKEJFPP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8297C80", Offset = "0x8296480", VA = "0x188297C80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x82994A0", Offset = "0x8297CA0", VA = "0x1882994A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MDAEMGHHEEI IFOLNHGDNCK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8297C20", Offset = "0x8296420", VA = "0x188297C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8299430", Offset = "0x8297C30", VA = "0x188299430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool PPODHFIDBLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8297B70", Offset = "0x8296370", VA = "0x188297B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody OPNCMGGOPLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8297BD0", Offset = "0x82963D0", VA = "0x188297BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NKBIAPCOCPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x82978B0", Offset = "0x82960B0", VA = "0x1882978B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8299350", Offset = "0x8297B50", VA = "0x188299350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool ECLCJLCFKBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1658990", Offset = "0x1657190", VA = "0x181658990", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float CHBBDIPLMJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x82985D0", Offset = "0x8296DD0", VA = "0x1882985D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float GJPHIKFMONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8298570", Offset = "0x8296D70", VA = "0x188298570")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8299AC0", Offset = "0x82982C0", VA = "0x188299AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float AEBFBCIHNGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8297FA0", Offset = "0x82967A0", VA = "0x188297FA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8299740", Offset = "0x8297F40", VA = "0x188299740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float LBEAICOAIPK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8297DA0", Offset = "0x82965A0", VA = "0x188297DA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8299510", Offset = "0x8297D10", VA = "0x188299510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool OJMIMAIHEBH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8298B80", Offset = "0x8297380", VA = "0x188298B80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x829A070", Offset = "0x8298870", VA = "0x18829A070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 FLAEDOBGOKB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8298350", Offset = "0x8296B50", VA = "0x188298350")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8299890", Offset = "0x8298090", VA = "0x188299890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 IJCKPIOEOJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8298CC0", Offset = "0x82974C0", VA = "0x188298CC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode CKLCKPMLJIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8297EE0", Offset = "0x82966E0", VA = "0x188297EE0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8299660", Offset = "0x8297E60", VA = "0x188299660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float MKNFODOJMGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8297910", Offset = "0x8296110", VA = "0x188297910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x82993C0", Offset = "0x8297BC0", VA = "0x1882993C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints KLIMCHMEJBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8297F40", Offset = "0x8296740", VA = "0x188297F40")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x82996D0", Offset = "0x8297ED0", VA = "0x1882996D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 IPHBEAAOGAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x82986F0", Offset = "0x8296EF0", VA = "0x1882986F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 EBIMAMOBAJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x82986F0", Offset = "0x8296EF0", VA = "0x1882986F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8299E50", Offset = "0x8298650", VA = "0x188299E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float EIKFDBNGDHM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8298430", Offset = "0x8296C30", VA = "0x188298430")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8299970", Offset = "0x8298170", VA = "0x188299970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float PNEIFHHIHCF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8298B20", Offset = "0x8297320", VA = "0x188298B20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x829A000", Offset = "0x8298800", VA = "0x18829A000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion PFLPAKANMGB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x82987D0", Offset = "0x8296FD0", VA = "0x1882987D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8299BD0", Offset = "0x82983D0", VA = "0x188299BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion OHFFPKACAED
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8298A50", Offset = "0x8297250", VA = "0x188298A50")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8299F30", Offset = "0x8298730", VA = "0x188299F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 ENHPOIFLOOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x82988A0", Offset = "0x82970A0", VA = "0x1882988A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8299CA0", Offset = "0x82984A0", VA = "0x188299CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion OLODNDJPNLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8298980", Offset = "0x8297180", VA = "0x188298980")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8299D80", Offset = "0x8298580", VA = "0x188299D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 CPDFCHMENBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8298BE0", Offset = "0x82973E0", VA = "0x188298BE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x829A0E0", Offset = "0x82988E0", VA = "0x18829A0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 AJKHHBKHKFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8298490", Offset = "0x8296C90", VA = "0x188298490")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x82999E0", Offset = "0x82981E0", VA = "0x1882999E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 PMKMNPODBEH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8297E00", Offset = "0x8296600", VA = "0x188297E00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8299580", Offset = "0x8297D80", VA = "0x188299580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 FHCAMOOFEPF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8298270", Offset = "0x8296A70", VA = "0x188298270")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x82997B0", Offset = "0x8297FB0", VA = "0x1882997B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 JDBICJJCEJM
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8298130", Offset = "0x8296930", VA = "0x188298130")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion PHAGKHNDLGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8298060", Offset = "0x8296860", VA = "0x188298060")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 INKKLAOADEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8298E80", Offset = "0x8297680", VA = "0x188298E80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 COPKABDPDPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8298DA0", Offset = "0x82975A0", VA = "0x188298DA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool PIMLLNPGCPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8298210", Offset = "0x8296A10", VA = "0x188298210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool FDPGOPGHNPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8297CE0", Offset = "0x82964E0", VA = "0x188297CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool INADBBBPAOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x82977F0", Offset = "0x8295FF0", VA = "0x1882977F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool EBEGBNALIFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8297790", Offset = "0x8295F90", VA = "0x188297790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool BFMNHDHEHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8297670", Offset = "0x8295E70", VA = "0x188297670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool MBNFMCFLJED
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8298000", Offset = "0x8296800", VA = "0x188298000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool ABPKKBNEOIA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2330E20", Offset = "0x232F620", VA = "0x182330E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event NDDIPIPMLIO EIKFGEHJDBF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8297590", Offset = "0x8295D90", VA = "0x188297590")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8299200", Offset = "0x8297A00", VA = "0x188299200")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event FNDIPFLKNAB MCDJNNMAMAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8297300", Offset = "0x8295B00", VA = "0x188297300")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8298F60", Offset = "0x8297760", VA = "0x188298F60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event FNDIPFLKNAB EFLOAFEPOOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8297360", Offset = "0x8295B60", VA = "0x188297360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8298FD0", Offset = "0x82977D0", VA = "0x188298FD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event FNDIPFLKNAB EDKPLACGCKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x82974B0", Offset = "0x8295CB0", VA = "0x1882974B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8299120", Offset = "0x8297920", VA = "0x188299120")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<GLBLJMJHHNB, GLBLJMJHHNB> HPCPGOPELBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8297440", Offset = "0x8295C40", VA = "0x188297440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x82990B0", Offset = "0x82978B0", VA = "0x1882990B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event FNDIPFLKNAB GEAMFANHFJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8297520", Offset = "0x8295D20", VA = "0x188297520")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8299190", Offset = "0x8297990", VA = "0x188299190")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event FNDIPFLKNAB PHGJCHJDABK
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8297600", Offset = "0x8295E00", VA = "0x188297600")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8299270", Offset = "0x8297A70", VA = "0x188299270")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event FNDIPFLKNAB HPCMGAOPDNG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x82973D0", Offset = "0x8295BD0", VA = "0x1882973D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8299040", Offset = "0x8297840", VA = "0x188299040")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740", Slot = "8")]
		private void GLHFNEGDOFE(GDKBCAGCEIA JLPKBNIJDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8295D20", Offset = "0x8294520", VA = "0x188295D20", Slot = "9")]
		public MBPKKAEDNLN GetData()
		{
			return default(MBPKKAEDNLN);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82961A0", Offset = "0x82949A0", VA = "0x1882961A0")]
		internal void KNADBHCNJEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8297030", Offset = "0x8295830", VA = "0x188297030")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody JPDCKBNMJLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8295A70", Offset = "0x8294270", VA = "0x188295A70")]
		public PHIEGKANMEI GetChild(int FPEOONOJHML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8296C90", Offset = "0x8295490", VA = "0x188296C90")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) ADLDOCGHNOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8295610", Offset = "0x8293E10", VA = "0x188295610")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8296F20", Offset = "0x8295720", VA = "0x188296F20")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x82957E0", Offset = "0x8293FE0", VA = "0x1882957E0")]
		private GDKBCAGCEIA MJNACDGKIDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8295DB0", Offset = "0x82945B0", VA = "0x188295DB0")]
		private void ILJHHMHPGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8296460", Offset = "0x8294C60", VA = "0x188296460")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x82963A0", Offset = "0x8294BA0", VA = "0x1882963A0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x82961A0", Offset = "0x82949A0", VA = "0x1882961A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8296400", Offset = "0x8294C00", VA = "0x188296400")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x82964C0", Offset = "0x8294CC0", VA = "0x1882964C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8294C00", Offset = "0x8293400", VA = "0x188294C00")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object JILOCOLKOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8296520", Offset = "0x8294D20", VA = "0x188296520")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object JILOCOLKOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8295A10", Offset = "0x8294210", VA = "0x188295A10")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8296340", Offset = "0x8294B40", VA = "0x188296340")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8296DF0", Offset = "0x82955F0", VA = "0x188296DF0")]
		public void SetParent(RigidbodyEx OPMIAMEJKDH, bool NHEENLIEFAC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8296830", Offset = "0x8295030", VA = "0x188296830")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8295F30", Offset = "0x8294730", VA = "0x188295F30")]
		public bool IsRigidbodyAncestor(RigidbodyEx BILFPHLBMLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8296030", Offset = "0x8294830", VA = "0x188296030")]
		public bool IsRigidbodyDescendant(RigidbodyEx EGIEHCMABAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8294E70", Offset = "0x8293670", VA = "0x188294E70")]
		public void AddInterpolationRestriction(object JILOCOLKOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8296590", Offset = "0x8294D90", VA = "0x188296590")]
		public void RemoveInterpolationRestriction(object JILOCOLKOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8294EE0", Offset = "0x82936E0", VA = "0x188294EE0")]
		public void AddKinematic(object JILOCOLKOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8296600", Offset = "0x8294E00", VA = "0x188296600")]
		public void RemoveKinematic(object JILOCOLKOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8296D70", Offset = "0x8295570", VA = "0x188296D70")]
		public void SetKinematic(object JILOCOLKOMJ, bool LAKEKLDFPHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8296B90", Offset = "0x8295390", VA = "0x188296B90")]
		public void SetDiscontinuousPositionAndRotation(Vector3 DIHBKEFFCBA, Quaternion CIDCNDIBGFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8296A90", Offset = "0x8295290", VA = "0x188296A90")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 FGKEFLJBKKJ, Quaternion BDAPMPGJHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8295C10", Offset = "0x8294410", VA = "0x188295C10")]
		public Vector3 GetConstrainedVelocity(Vector3 CPDFCHMENBI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8295B00", Offset = "0x8294300", VA = "0x188295B00")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 PMKMNPODBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8294D80", Offset = "0x8293580", VA = "0x188294D80")]
		public void AddForce(Vector3 IOHDICMKADP, ForceMode KKMLBMDBNEE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8294C70", Offset = "0x8293470", VA = "0x188294C70")]
		public void AddForceAtPosition(Vector3 IOHDICMKADP, Vector3 NCGKJMOKFAF, ForceMode KKMLBMDBNEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x82950B0", Offset = "0x82938B0", VA = "0x1882950B0")]
		public void AddTorque(Vector3 FKMHBOJEDEG, ForceMode KKMLBMDBNEE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8294F50", Offset = "0x8293750", VA = "0x188294F50")]
		public void AddRelativeTorque(Vector3 FKMHBOJEDEG, ForceMode KKMLBMDBNEE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8297100", Offset = "0x8295900", VA = "0x188297100")]
		public Vector3 WorldToLocalVelocity(Vector3 DIPBPPFCBBL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8296230", Offset = "0x8294A30", VA = "0x188296230")]
		public Vector3 LocalToWorldVelocity(Vector3 AJKHHBKHKFM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x82959B0", Offset = "0x82941B0", VA = "0x1882959B0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8295950", Offset = "0x8294150", VA = "0x188295950")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x82958F0", Offset = "0x82940F0", VA = "0x1882958F0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8295890", Offset = "0x8294090", VA = "0x188295890")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8296990", Offset = "0x8295190", VA = "0x188296990")]
		public void ResetVelocityWorldSpace(Vector3 ADFNPAHJJPN, Vector3 EFJBLAGMOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8296890", Offset = "0x8295090", VA = "0x188296890")]
		public void ResetVelocityLocalSpace(Vector3 JCNJOFMBACI, Vector3 FHCAMOOFEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8296750", Offset = "0x8294F50", VA = "0x188296750")]
		public void ResetLinearVelocityLocalSpace(Vector3 JCNJOFMBACI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8296F30", Offset = "0x8295730", VA = "0x188296F30")]
		public bool SweepTest(Vector3 ELEEIMOLKDP, [Out] RaycastHit CHIFGMMDKPM, float ECLNGJKMDDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8296130", Offset = "0x8294930", VA = "0x188296130")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8296EC0", Offset = "0x82956C0", VA = "0x188296EC0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x82970A0", Offset = "0x82958A0", VA = "0x1882970A0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8295040", Offset = "0x8293840", VA = "0x188295040")]
		public void AddShouldHaveUnityRigidbodyToken(object JILOCOLKOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8296670", Offset = "0x8294E70", VA = "0x188296670")]
		public void RemoveShouldHaveUnityRigidbodyToken(object JILOCOLKOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8295440", Offset = "0x8293C40", VA = "0x188295440")]
		public void ApplyForceVelocityChange(BEKOKAGGBFN INGIIIHLDGC, Vector3 PPKNLPOPFLE, float GBPBCCOFJFK, float MDBPJKOKEGF = 8f, float AOJEEBFLHCB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8295340", Offset = "0x8293B40", VA = "0x188295340")]
		public void ApplyAngularVelocityChange(FBDAOBLHIEH GMLICJILPOE, Vector3 IFMNFMEAKID, float NCNCGHGIJLC = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8295500", Offset = "0x8293D00", VA = "0x188295500")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(FBDAOBLHIEH GMLICJILPOE, Vector3 PMHMEKBKJJA, float OLCPAEAGNDC = 7f, float KIJDFDGNDME = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8295270", Offset = "0x8293A70", VA = "0x188295270")]
		public bool AllowedScaleChange(float PPDPODCGICD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x82951A0", Offset = "0x82939A0", VA = "0x1882951A0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx CCNOJOKDHHE, object JILOCOLKOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x82966E0", Offset = "0x8294EE0", VA = "0x1882966E0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object JILOCOLKOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8296190", Offset = "0x8294990", VA = "0x188296190", Slot = "12")]
		private void KGINFPEHBFH(EKBDCGJJOMD KLNHOILIBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8297290", Offset = "0x8295A90", VA = "0x188297290")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB7AD80", Offset = "0xB79580", VA = "0x180B7AD80", Slot = "4")]
		private GameObject CEGMFOIDIFF()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A8D0", Offset = "0xA090D0", VA = "0x180A0A8D0", Slot = "10")]
		private bool CCGJAFGIMCA()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class EDBFKIODPPI
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8288EB0", Offset = "0x82876B0", VA = "0x188288EB0")]
	public static GDKBCAGCEIA PEBAEBIABCE(this RigidbodyEx MHNKLADFOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(HKDLEKPKHHB), new string[] { })]
public class OHKMJIHOCPC : HKDLEKPKHHB, JOGFKELELCN
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private LALDNLGOMFA LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private KPMMGPIKJNM FFCCIPHALKA;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public LALDNLGOMFA PILJEFNINPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public KPMMGPIKJNM HNHMCLFGMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8294990", Offset = "0x8293190", VA = "0x188294990", Slot = "7")]
	public void InitReferences(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x82947C0", Offset = "0x8292FC0", VA = "0x1882947C0", Slot = "6")]
	public GDKBCAGCEIA AOHFFINJJMN(RigidbodyEx MHNKLADFOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public OHKMJIHOCPC()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static FIEKIAHLEMJ UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int GFOEECNFJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int BMCEJKCDNCL;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8294A80", Offset = "0x8293280", VA = "0x188294A80")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8294AC0", Offset = "0x82932C0", VA = "0x188294AC0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8294AA0", Offset = "0x82932A0", VA = "0x188294AA0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string NJAAPDELBNN, [Optional] UnityEngine.Object KLNHOILIBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string NJAAPDELBNN, [Optional] UnityEngine.Object KLNHOILIBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8294BB0", Offset = "0x82933B0", VA = "0x188294BB0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NABHNMGHPCD
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class BKFOOKEOCFE : CHJDOPIOJPF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9EE860", Offset = "0x9ED060", VA = "0x1809EE860", Slot = "4")]
		public Vector3 HAIJHMDKMBI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9EE860", Offset = "0x9ED060", VA = "0x1809EE860", Slot = "5")]
		public Vector3 JKLPDPMGFPG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "6")]
		public bool POKDEKOGNKC(float DKAILJIMLKA, float HBHGMKKFOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BKFOOKEOCFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static CHJDOPIOJPF HCAJMBNOELP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x828DFA0", Offset = "0x828C7A0", VA = "0x18828DFA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LAPABDNBKEL
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode BMKFHFJKBKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEBHHIOLPOG();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHOODOJMHCE(bool PIMLLNPGCPM);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CCJLLNFELGE(bool PIMLLNPGCPM);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BCHLLKEGJIC(Rigidbody NMOLGGIPLAG);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool POLHEFCBKCM(Vector3 ELEEIMOLKDP, [Out] RaycastHit CHIFGMMDKPM, float ECLNGJKMDDA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MEPPGBOMDON : IDisposable, BNDCELMPOLP
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	LDLKAPLIJLM EOGPKINPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<GLBLJMJHHNB, GLBLJMJHHNB> HPCPGOPELBG;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AEBHHIOLPOG();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface KPMMGPIKJNM
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OFLIAFKELJJ JLCFNEJEHPD(GDKBCAGCEIA JLPKBNIJDEI);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EPAEGNHFMMA AGAIJKIHOGG(GDKBCAGCEIA JLPKBNIJDEI);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KKJLLKMBFHB AMDIMLDDMCD(GDKBCAGCEIA JLPKBNIJDEI);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ANKDFHDMFPN NGAEGNAEOGK(GDKBCAGCEIA JLPKBNIJDEI);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IJCDKAKCJEK AJKJNNJEAHE(GDKBCAGCEIA JLPKBNIJDEI);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MEPPGBOMDON BPOHAFHEBKG(GDKBCAGCEIA JLPKBNIJDEI);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	APCIKJKOFFA AJANBKBPNLG(GDKBCAGCEIA JLPKBNIJDEI);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IPMBCDCODNO HJNCPJOFGLH(GDKBCAGCEIA JLPKBNIJDEI);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LAPABDNBKEL AFOJAIKJLPP(GDKBCAGCEIA JLPKBNIJDEI);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JODNIHJBOHE FFFJGMLCDHN(GDKBCAGCEIA JLPKBNIJDEI);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DAEKEHIIKPF HFKOBJNFOOF(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DCGJNNGHHLI AAPILGGKCLG(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IKAKBIOMPDF JDHJOPADKDN(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LHEJJKMLCIH IJNNDFKMFBK(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HLPEKNPGDKB IIDDANJKEMC(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GDKBCAGCEIA AOHFFINJJMN(RigidbodyEx MHNKLADFOHL, MBPKKAEDNLN NFNBKNAJBPN, HKDLEKPKHHB IPKPNIAEJDE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IPMBCDCODNO
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKLLLLHCDGJ(Vector3 IOHDICMKADP, ForceMode KKMLBMDBNEE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMMOLDDCHNA(Vector3 IOHDICMKADP, Vector3 NCGKJMOKFAF, ForceMode KKMLBMDBNEE);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCCJDFOICJN(Vector3 FKMHBOJEDEG, ForceMode KKMLBMDBNEE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHKODDGEHFK(Vector3 FKMHBOJEDEG, ForceMode KKMLBMDBNEE = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JODNIHJBOHE
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool MODDEKJEOHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCHLLKEGJIC(Rigidbody NMOLGGIPLAG);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PLMEKNKGJKP(Rigidbody NMOLGGIPLAG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OFLIAFKELJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<GDKBCAGCEIA> HFHBKLMMJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	GDKBCAGCEIA DFJAHCLMMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	GDKBCAGCEIA BKMKKMCIDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FNDIPFLKNAB MCDJNNMAMAF;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event FNDIPFLKNAB EFLOAFEPOOM;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event NDDIPIPMLIO DOGMIKHPCAE;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action HCCDFFKMACI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action HECPBIHLHLC;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<GDKBCAGCEIA> JJLGHCICCKF;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<GDKBCAGCEIA> IIPKFBPGAGI;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action MCOOKKHAOCG;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<GDKBCAGCEIA> IBILBCCPLGG;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GDNIECKCIEP(GDKBCAGCEIA GPDOCAJDCGI, bool NHEENLIEFAC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KKJLLKMBFHB
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 AOFPKPBCAPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 FDLOOIMHJJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEIGCOPIPAK(GDKBCAGCEIA DFPCBMGPBFO, object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LBICDEMEAHP(object JILOCOLKOMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LHEJJKMLCIH
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 MJDHBOMHLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 GFEIFHPPKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float OKBOIFJHIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float LCGEHHPDACH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 GBLDNHNDBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion HNBPIOHMHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event FNDIPFLKNAB EAGMDIDGBMO;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ODEPOCEJIHB((Quaternion rot, Vector3 moments) ADLDOCGHNOD);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FCGMCLAFHII();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AOPHHMAEJCC();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CFPHIACOOHA();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BCHLLKEGJIC(Rigidbody NMOLGGIPLAG);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PLMEKNKGJKP(Rigidbody NMOLGGIPLAG);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FIKBBIPHFKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IKAKBIOMPDF
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AEBHHIOLPOG();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOKEJFFGOJM(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMFMFILOLFL(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CLGEJGBPIMG(GDKBCAGCEIA MHNKLADFOHL);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PHJOFHMFNCE(GDKBCAGCEIA MHNKLADFOHL);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EILFJIGKADI();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface APCIKJKOFFA
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool MBOANJLCFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event FNDIPFLKNAB KJDBBLBEOGB;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHODPBBNBAJ(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KMNNOCLBOAB(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BGOPPMHIIOA(object JILOCOLKOMJ, bool LAKEKLDFPHG);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BCHLLKEGJIC(Rigidbody DNDBHALNMFA);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PLMEKNKGJKP(Rigidbody NMOLGGIPLAG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DCGJNNGHHLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool JAPKJEKLGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool CCLBBOJOHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event FNDIPFLKNAB AGMDLEMNFKM;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AEBHHIOLPOG();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCIFDLCFGCA(GDKBCAGCEIA DFPCBMGPBFO);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOIHEAFKNCE(GDKBCAGCEIA DFPCBMGPBFO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HLPEKNPGDKB
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool NKBIAPCOCPG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool ELIKOKFENLC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints EKHJBHKHECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BCHLLKEGJIC(Rigidbody NMOLGGIPLAG);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PLMEKNKGJKP(Rigidbody NMOLGGIPLAG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ANKDFHDMFPN
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float ANELGFOKONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float PJKJFEBLNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BCHLLKEGJIC(Rigidbody NMOLGGIPLAG);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PLMEKNKGJKP(Rigidbody NMOLGGIPLAG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IJCDKAKCJEK
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool BBDBGIFIEIP;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event FNDIPFLKNAB JGIIEHNDEEM;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEBHHIOLPOG();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EJBOBEPMKHL();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BNEDNOMIGHF();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void POODEKDDHKA();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HGADFJBECFH();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KGPKIABBODF();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DAKKDCGFKFB(bool ALNHEFKPHLI);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OKGHPCCIHAC();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DAEKEHIIKPF
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody OPNCMGGOPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool MCJJADGECMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEBHHIOLPOG();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AICDEMPEFDP(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JIKJAMIHJAA(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IEBDGHKIJMM();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EPAEGNHFMMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	CHJDOPIOJPF DJGPCKEJFPP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	MDAEMGHHEEI IFOLNHGDNCK
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 KNJCODDIFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 PNALLFEIODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 KCFLMICDHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 OPLKOCLBGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float MKNFODOJMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool PPODHFIDBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AEBHHIOLPOG();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KFOGNMFNIPD(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EJAHPKKMCPJ(FBDAOBLHIEH GMLICJILPOE, Vector3 IFMNFMEAKID, float NCNCGHGIJLC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EKLPHNIANMH(BEKOKAGGBFN INGIIIHLDGC, Vector3 PPKNLPOPFLE, float GBPBCCOFJFK, float MDBPJKOKEGF = 8f, float AOJEEBFLHCB = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KCKBDILFFOO(FBDAOBLHIEH GMLICJILPOE, Vector3 PMHMEKBKJJA, float OLCPAEAGNDC = 7f, float KIJDFDGNDME = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LPJCCGPGAKO();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BDHEJHPCKND();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EEJKMNNJIJI();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EOJNKAGEINB();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BCHLLKEGJIC(Rigidbody NMOLGGIPLAG);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 FHCGODLNJHA(Vector3 CPDFCHMENBI);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JFADBLGNNHB(object JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FGJKGGCGJIE(Vector3 LJIHODIHHNH);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GGBDGHLCOHD(Vector3 JCNJOFMBACI, Vector3 FHCAMOOFEPF);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FOMOFHDHOLK(Vector3 ADFNPAHJJPN, Vector3 EFJBLAGMOBF);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 AAGLFKAIHBB(Vector3 AJKHHBKHKFM);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 DCDLPLHNFEJ(Vector3 DIPBPPFCBBL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface LALDNLGOMFA
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool EICENHJGIAM
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHCDHGNKPIP(string LKNKJJBHDKO);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HDCIPICPMDC(RigidbodyEx MHNKLADFOHL, Action GFMBHCHPLDH);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MKOALGGHCAA KDCNIINAHGD(int DDAKEKGCCDJ);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PODGGFIEHDM(Vector3 IJCKPIOEOJF, float LCOGFOJGAHI, Color AGNHOOELDII);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface HKDLEKPKHHB
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	LALDNLGOMFA PILJEFNINPM
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	KPMMGPIKJNM HNHMCLFGMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GDKBCAGCEIA AOHFFINJJMN(RigidbodyEx MHNKLADFOHL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EBCHAJDEHHB : GDKBCAGCEIA, IDisposable, DJCCIDBLCMI
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool PJMNFDCDIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly HKDLEKPKHHB IPKPNIAEJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal OFLIAFKELJJ MDDANENBEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal IKAKBIOMPDF PBJKOHIPMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal DCGJNNGHHLI CABJNEPNBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal EPAEGNHFMMA CPDFCHMENBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal KKJLLKMBFHB LMBAFBEKANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal LHEJJKMLCIH FHHJNNHNMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal ANKDFHDMFPN CEEAFEAEJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal JODNIHJBOHE NDDHBPAOFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal IJCDKAKCJEK DFDJCPOIHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal MEPPGBOMDON NDHJKKIJKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal APCIKJKOFFA BFMPDFFAPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal IPMBCDCODNO IOHDICMKADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal HLPEKNPGDKB NPGOFINJGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal DAEKEHIIKPF NMOLGGIPLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal LAPABDNBKEL KKJJNLIPHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable EEMLFBMMJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool IOKKNNJFFMG;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public FGFPKLDJIEL NCLIMIOPNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "22")]
		get
		{
			return default(FGFPKLDJIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public PHIEGKANMEI IGDDOKKFMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xCAB0D0", Offset = "0xCA98D0", VA = "0x180CAB0D0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xE18B30", Offset = "0xE17330", VA = "0x180E18B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject KHPLFMGJOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9E71A0", Offset = "0x9E59A0", VA = "0x1809E71A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9E7180", Offset = "0x9E5980", VA = "0x1809E7180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform FCHHAJKLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xBF9060", Offset = "0xBF7860", VA = "0x180BF9060", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xE28C10", Offset = "0xE27410", VA = "0x180E28C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody OPNCMGGOPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x82870C0", Offset = "0x82858C0", VA = "0x1882870C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public GDKBCAGCEIA BKMKKMCIDFM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8285010", Offset = "0x8283810", VA = "0x188285010", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x82826F0", Offset = "0x8280EF0", VA = "0x1882826F0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int LKGPMNCFJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8285B00", Offset = "0x8284300", VA = "0x188285B00", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public GDKBCAGCEIA DFJAHCLMMPD
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8287070", Offset = "0x8285870", VA = "0x188287070", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool EEIMJJONDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8288990", Offset = "0x8287190", VA = "0x188288990", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool JAPKJEKLGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x82873C0", Offset = "0x8285BC0", VA = "0x1882873C0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool CCLBBOJOHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8285950", Offset = "0x8284150", VA = "0x188285950", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public CHJDOPIOJPF DJGPCKEJFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8286C30", Offset = "0x8285430", VA = "0x188286C30", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8284E60", Offset = "0x8283660", VA = "0x188284E60", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public MDAEMGHHEEI IFOLNHGDNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x82872C0", Offset = "0x8285AC0", VA = "0x1882872C0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8287540", Offset = "0x8285D40", VA = "0x188287540", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float MKNFODOJMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8282950", Offset = "0x8281150", VA = "0x188282950", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8285F00", Offset = "0x8284700", VA = "0x188285F00", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 PNALLFEIODC
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x82862C0", Offset = "0x8284AC0", VA = "0x1882862C0", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8287460", Offset = "0x8285C60", VA = "0x188287460", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 OPLKOCLBGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8284010", Offset = "0x8282810", VA = "0x188284010", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x82882F0", Offset = "0x8286AF0", VA = "0x1882882F0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 KNJCODDIFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8282C70", Offset = "0x8281470", VA = "0x188282C70", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8283050", Offset = "0x8281850", VA = "0x188283050", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 KCFLMICDHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8287710", Offset = "0x8285F10", VA = "0x188287710", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8285DC0", Offset = "0x82845C0", VA = "0x188285DC0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool INADBBBPAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8288490", Offset = "0x8286C90", VA = "0x188288490", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool EBEGBNALIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8282A00", Offset = "0x8281200", VA = "0x188282A00", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool BFMNHDHEHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8286A80", Offset = "0x8285280", VA = "0x188286A80", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool PPODHFIDBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8287370", Offset = "0x8285B70", VA = "0x188287370", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 AOFPKPBCAPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8285120", Offset = "0x8283920", VA = "0x188285120", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 FDLOOIMHJJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8286C80", Offset = "0x8285480", VA = "0x188286C80", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 MJDHBOMHLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8285BD0", Offset = "0x82843D0", VA = "0x188285BD0", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8283190", Offset = "0x8281990", VA = "0x188283190", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 GFEIFHPPKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8282A60", Offset = "0x8281260", VA = "0x188282A60", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float OKBOIFJHIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8287410", Offset = "0x8285C10", VA = "0x188287410", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float LCGEHHPDACH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8288440", Offset = "0x8286C40", VA = "0x188288440", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8283720", Offset = "0x8281F20", VA = "0x188283720", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 GBLDNHNDBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8284CC0", Offset = "0x82834C0", VA = "0x188284CC0", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion HNBPIOHMHKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x82833B0", Offset = "0x8281BB0", VA = "0x1882833B0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float ANELGFOKONF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8283D10", Offset = "0x8282510", VA = "0x188283D10", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8283780", Offset = "0x8281F80", VA = "0x188283780", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float PJKJFEBLNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x82877F0", Offset = "0x8285FF0", VA = "0x1882877F0", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x82832C0", Offset = "0x8281AC0", VA = "0x1882832C0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool MODDEKJEOHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8284AB0", Offset = "0x82832B0", VA = "0x188284AB0", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8284E00", Offset = "0x8283600", VA = "0x188284E00", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public LDLKAPLIJLM EOGPKINPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8282750", Offset = "0x8280F50", VA = "0x188282750", Slot = "70")]
		get
		{
			return default(LDLKAPLIJLM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8282550", Offset = "0x8280D50", VA = "0x188282550", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool MBOANJLCFCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x82851F0", Offset = "0x82839F0", VA = "0x1882851F0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform IGFDKOONDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xBF9060", Offset = "0xBF7860", VA = "0x180BF9060", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 GLHOKEIGHFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8284590", Offset = "0x8282D90", VA = "0x188284590", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8285240", Offset = "0x8283A40", VA = "0x188285240", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float CAHFINAIIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8283CA0", Offset = "0x82824A0", VA = "0x188283CA0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8283320", Offset = "0x8281B20", VA = "0x188283320", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float DFEDMDDOOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8283910", Offset = "0x8282110", VA = "0x188283910", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8282850", Offset = "0x8281050", VA = "0x188282850", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion IMPNJHKBDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8288250", Offset = "0x8286A50", VA = "0x188288250", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8285350", Offset = "0x8283B50", VA = "0x188285350", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 CHPCAADKHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8286BF0", Offset = "0x82853F0", VA = "0x188286BF0", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x82876D0", Offset = "0x8285ED0", VA = "0x1882876D0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion OIHKBFCJFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8283D60", Offset = "0x8282560", VA = "0x188283D60", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8287C20", Offset = "0x8286420", VA = "0x188287C20", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints EKHJBHKHECD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8285790", Offset = "0x8283F90", VA = "0x188285790", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8283130", Offset = "0x8281930", VA = "0x188283130", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool NKBIAPCOCPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8283270", Offset = "0x8281A70", VA = "0x188283270", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8285060", Offset = "0x8283860", VA = "0x188285060", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode BMKFHFJKBKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8284910", Offset = "0x8283110", VA = "0x188284910", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8283DA0", Offset = "0x82825A0", VA = "0x188283DA0", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool ABMMJEEEPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8288650", Offset = "0x8286E50", VA = "0x188288650", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool FDPGOPGHNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8283550", Offset = "0x8281D50", VA = "0x188283550", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event FNDIPFLKNAB MCDJNNMAMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x82850C0", Offset = "0x82838C0", VA = "0x1882850C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8285F60", Offset = "0x8284760", VA = "0x188285F60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event FNDIPFLKNAB EFLOAFEPOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8282F10", Offset = "0x8281710", VA = "0x188282F10", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x82884E0", Offset = "0x8286CE0", VA = "0x1882884E0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event NDDIPIPMLIO DOGMIKHPCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x82858F0", Offset = "0x82840F0", VA = "0x1882858F0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8282B90", Offset = "0x8281390", VA = "0x188282B90", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event FNDIPFLKNAB AGMDLEMNFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8287BC0", Offset = "0x82863C0", VA = "0x188287BC0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8283FB0", Offset = "0x82827B0", VA = "0x188283FB0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event FNDIPFLKNAB EDKPLACGCKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8284DA0", Offset = "0x82835A0", VA = "0x188284DA0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8285FC0", Offset = "0x82847C0", VA = "0x188285FC0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event FNDIPFLKNAB JGIIEHNDEEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8284F50", Offset = "0x8283750", VA = "0x188284F50", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8284B00", Offset = "0x8283300", VA = "0x188284B00", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<GLBLJMJHHNB, GLBLJMJHHNB> HPCPGOPELBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8286510", Offset = "0x8284D10", VA = "0x188286510", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8283E00", Offset = "0x8282600", VA = "0x188283E00", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event FNDIPFLKNAB KJDBBLBEOGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x82852F0", Offset = "0x8283AF0", VA = "0x1882852F0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8287310", Offset = "0x8285B10", VA = "0x188287310", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event FNDIPFLKNAB HPCMGAOPDNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x82827A0", Offset = "0x8280FA0", VA = "0x1882827A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8283860", Offset = "0x8282060", VA = "0x188283860", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8288B80", Offset = "0x8287380", VA = "0x188288B80")]
	public EBCHAJDEHHB(GameObject KJMBGAPFJAM, RigidbodyEx OOLFAOOHKOL, HKDLEKPKHHB IPKPNIAEJDE, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x82854A0", Offset = "0x8283CA0", VA = "0x1882854A0", Slot = "139")]
	protected virtual void IFCFPCKAODJ(HKDLEKPKHHB IPKPNIAEJDE, MBPKKAEDNLN NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8283E60", Offset = "0x8282660", VA = "0x188283E60", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x82825B0", Offset = "0x8280DB0", VA = "0x1882825B0", Slot = "93")]
	public void AEBHHIOLPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8286B60", Offset = "0x8285360", VA = "0x188286B60", Slot = "94")]
	public void LFPKMPBIEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8284A50", Offset = "0x8283250", VA = "0x188284A50", Slot = "95")]
	public void FPHEFBGHLOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8284570", Offset = "0x8282D70", VA = "0x188284570", Slot = "96")]
	public void EKMOEIKANHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8283920", Offset = "0x8282120", VA = "0x188283920")]
	private void DAKKDCGFKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8282BF0", Offset = "0x82813F0", VA = "0x188282BF0")]
	private void APOMNICEPAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8286020", Offset = "0x8284820", VA = "0x188286020")]
	private void KGPKIABBODF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x82837E0", Offset = "0x8281FE0", VA = "0x1882837E0", Slot = "30")]
	public GDKBCAGCEIA CMOFFOOHDIE(int FPEOONOJHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8284B60", Offset = "0x8283360", VA = "0x188284B60", Slot = "98")]
	public void GDNIECKCIEP(GDKBCAGCEIA OPMIAMEJKDH, bool NHEENLIEFAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8285EA0", Offset = "0x82846A0", VA = "0x188285EA0", Slot = "99")]
	public void KDFHBOFOEFL(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8284FB0", Offset = "0x82837B0", VA = "0x188284FB0", Slot = "100")]
	public void HBAECMBAOIC(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8283BA0", Offset = "0x82823A0", VA = "0x188283BA0", Slot = "101")]
	public Vector3 DCDLPLHNFEJ(Vector3 DIPBPPFCBBL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8282450", Offset = "0x8280C50", VA = "0x188282450", Slot = "102")]
	public Vector3 AAGLFKAIHBB(Vector3 AJKHHBKHKFM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8284640", Offset = "0x8282E40", VA = "0x188284640", Slot = "103")]
	public void EOJNKAGEINB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8282D50", Offset = "0x8281550", VA = "0x188282D50", Slot = "104")]
	public void BDHEJHPCKND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8287020", Offset = "0x8285820", VA = "0x188287020", Slot = "105")]
	public void LPJCCGPGAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8284960", Offset = "0x8283160", VA = "0x188284960", Slot = "106")]
	public void FOMOFHDHOLK(Vector3 ADFNPAHJJPN, Vector3 EFJBLAGMOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8284BD0", Offset = "0x82833D0", VA = "0x188284BD0", Slot = "107")]
	public void GGBDGHLCOHD(Vector3 JCNJOFMBACI, Vector3 FHCAMOOFEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x82846E0", Offset = "0x8282EE0", VA = "0x1882846E0", Slot = "108")]
	public void FGJKGGCGJIE(Vector3 LJIHODIHHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x82844B0", Offset = "0x8282CB0", VA = "0x1882844B0", Slot = "109")]
	public void EKLPHNIANMH(BEKOKAGGBFN INGIIIHLDGC, Vector3 PPKNLPOPFLE, float GBPBCCOFJFK, float MDBPJKOKEGF = 8f, float AOJEEBFLHCB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8284360", Offset = "0x8282B60", VA = "0x188284360", Slot = "110")]
	public void EJAHPKKMCPJ(FBDAOBLHIEH GMLICJILPOE, Vector3 IFMNFMEAKID, float NCNCGHGIJLC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8285CB0", Offset = "0x82844B0", VA = "0x188285CB0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void KCKBDILFFOO(FBDAOBLHIEH GMLICJILPOE, Vector3 PMHMEKBKJJA, float OLCPAEAGNDC = 7f, float KIJDFDGNDME = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x82847C0", Offset = "0x8282FC0", VA = "0x1882847C0", Slot = "112")]
	public Vector3 FHCGODLNJHA(Vector3 OPMIAMEJKDH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8282E10", Offset = "0x8281610", VA = "0x188282E10", Slot = "113")]
	public Vector3 BJGHADGMPFA(Vector3 OPMIAMEJKDH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8283F60", Offset = "0x8282760", VA = "0x188283F60", Slot = "114")]
	public void EEJKMNNJIJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8285430", Offset = "0x8283C30", VA = "0x188285430", Slot = "115")]
	public void ICLGNMJGIAI(GDKBCAGCEIA CCNOJOKDHHE, object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8283CB0", Offset = "0x82824B0", VA = "0x188283CB0", Slot = "116")]
	public void DFLDCLEGEAB(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8288170", Offset = "0x8286970", VA = "0x188288170", Slot = "63")]
	public void ODEPOCEJIHB((Quaternion rot, Vector3 moments) ADLDOCGHNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8282B40", Offset = "0x8281340", VA = "0x188282B40", Slot = "117")]
	public void AOPHHMAEJCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8284690", Offset = "0x8282E90", VA = "0x188284690", Slot = "118")]
	public void FCGMCLAFHII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x82836D0", Offset = "0x8281ED0", VA = "0x1882836D0", Slot = "119")]
	public void CFPHIACOOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8284460", Offset = "0x8282C60", VA = "0x188284460", Slot = "120")]
	public bool EJBOBEPMKHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8288AF0", Offset = "0x82872F0", VA = "0x188288AF0", Slot = "97")]
	public void POODEKDDHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x82883D0", Offset = "0x8286BD0", VA = "0x1882883D0", Slot = "121")]
	public void OKGHPCCIHAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x82841D0", Offset = "0x82829D0", VA = "0x1882841D0", Slot = "122")]
	public void EHODPBBNBAJ(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8286080", Offset = "0x8284880", VA = "0x188286080", Slot = "123")]
	public void KMNNOCLBOAB(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8282DA0", Offset = "0x82815A0", VA = "0x188282DA0", Slot = "124")]
	public void BGOPPMHIIOA(object JILOCOLKOMJ, bool LAKEKLDFPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8288790", Offset = "0x8286F90", VA = "0x188288790", Slot = "125")]
	public void PJEICJBPJLN(Vector3 DIHBKEFFCBA, Quaternion CIDCNDIBGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x82875A0", Offset = "0x8285DA0", VA = "0x1882875A0", Slot = "126")]
	public void NNAJHGIIEJI(Vector3 FGKEFLJBKKJ, Quaternion BDAPMPGJHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8285A00", Offset = "0x8284200", VA = "0x188285A00", Slot = "127")]
	public bool JJBIBHDGGBN(float PPDPODCGICD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8287260", Offset = "0x8285A60", VA = "0x188287260", Slot = "128")]
	public void MEOIPAMNEDF(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8285B70", Offset = "0x8284370", VA = "0x188285B70", Slot = "129")]
	public void KAOMHMJAELC(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x82829A0", Offset = "0x82811A0", VA = "0x1882829A0", Slot = "130")]
	public void AICDEMPEFDP(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x82859A0", Offset = "0x82841A0", VA = "0x1882859A0", Slot = "131")]
	public void JIKJAMIHJAA(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8282F70", Offset = "0x8281770", VA = "0x188282F70", Slot = "132")]
	public void BKLLLLHCDGJ(Vector3 IOHDICMKADP, ForceMode KKMLBMDBNEE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x82857E0", Offset = "0x8283FE0", VA = "0x1882857E0", Slot = "133")]
	public void IMMOLDDCHNA(Vector3 IOHDICMKADP, Vector3 NCGKJMOKFAF, ForceMode KKMLBMDBNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8287C50", Offset = "0x8286450", VA = "0x188287C50", Slot = "134")]
	public void OCCJDFOICJN(Vector3 FKMHBOJEDEG, ForceMode KKMLBMDBNEE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x82840F0", Offset = "0x82828F0", VA = "0x1882840F0", Slot = "135")]
	public void EHKODDGEHFK(Vector3 FKMHBOJEDEG, ForceMode KKMLBMDBNEE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x82889F0", Offset = "0x82871F0", VA = "0x1882889F0", Slot = "136")]
	public bool POLHEFCBKCM(Vector3 ELEEIMOLKDP, [Out] RaycastHit CHIFGMMDKPM, float ECLNGJKMDDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x82848C0", Offset = "0x82830C0", VA = "0x1882848C0", Slot = "137")]
	public void FIKBBIPHFKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8288B40", Offset = "0x8287340", VA = "0x188288B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8286E80", Offset = "0x8285680", VA = "0x188286E80")]
	private void LNMBDOONNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8288540", Offset = "0x8286D40", VA = "0x188288540")]
	private void PEAJMMOBHEB(GDKBCAGCEIA DFPCBMGPBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x82860E0", Offset = "0x82848E0", VA = "0x1882860E0")]
	private void KNDALOEGFDG(GDKBCAGCEIA DFPCBMGPBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8285A50", Offset = "0x8284250", VA = "0x188285A50")]
	private void JKNNLADAIEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8286D60", Offset = "0x8285560", VA = "0x188286D60")]
	private void LNLGOBIABNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8286570", Offset = "0x8284D70", VA = "0x188286570")]
	private void LACHLCMFFOK(GDKBCAGCEIA DFMIOKFFOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8283480", Offset = "0x8281C80", VA = "0x188283480")]
	private void CCIFDLCFGCA(GDKBCAGCEIA DFPCBMGPBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8286F50", Offset = "0x8285750", VA = "0x188286F50")]
	private void LOIHEAFKNCE(GDKBCAGCEIA DFPCBMGPBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8287110", Offset = "0x8285910", VA = "0x188287110")]
	private void MAMOCJKKOBG(PHIEGKANMEI DFPCBMGPBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8287D30", Offset = "0x8286530", VA = "0x188287D30", Slot = "142")]
	protected virtual void OCKNKKHIMGK(PHIEGKANMEI MHNKLADFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8286720", Offset = "0x8284F20", VA = "0x188286720")]
	protected void LFHKGBHACOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8287840", Offset = "0x8286040", VA = "0x188287840")]
	protected void NPFGKHLKABM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8284230", Offset = "0x8282A30", VA = "0x188284230")]
	private void EIDFBIEDINK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x82863A0", Offset = "0x8284BA0", VA = "0x1882863A0")]
	private void KOPBMCDFECF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class LJDIBKIJKHI
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x828D020", Offset = "0x828B820", VA = "0x18828D020")]
	public static GDKBCAGCEIA ENKDPPFKFBJ(this GDKBCAGCEIA MHNKLADFOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x828CF10", Offset = "0x828B710", VA = "0x18828CF10")]
	public static bool BMKDENOBPBN(this GDKBCAGCEIA MHNKLADFOHL, GDKBCAGCEIA BILFPHLBMLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x828D0E0", Offset = "0x828B8E0", VA = "0x18828D0E0")]
	public static bool KPJHGFJJMPD(this GDKBCAGCEIA MHNKLADFOHL, GDKBCAGCEIA EGIEHCMABAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x828CEC0", Offset = "0x828B6C0", VA = "0x18828CEC0")]
	public static PHIEGKANMEI AEJGBMIEKJC(this GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x828CFB0", Offset = "0x828B7B0", VA = "0x18828CFB0")]
	public static EBCHAJDEHHB CDHBFCAKPFI(this GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HHKCEENKGLJ : KPMMGPIKJNM
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x828C260", Offset = "0x828AA60", VA = "0x18828C260", Slot = "19")]
	public GDKBCAGCEIA AOHFFINJJMN(RigidbodyEx MHNKLADFOHL, MBPKKAEDNLN NFNBKNAJBPN, HKDLEKPKHHB IPKPNIAEJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "4")]
	public OFLIAFKELJJ JLCFNEJEHPD(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "5")]
	public EPAEGNHFMMA AGAIJKIHOGG(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "6")]
	public KKJLLKMBFHB AMDIMLDDMCD(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "7")]
	public ANKDFHDMFPN NGAEGNAEOGK(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "8")]
	public IJCDKAKCJEK AJKJNNJEAHE(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "9")]
	public MEPPGBOMDON BPOHAFHEBKG(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "10")]
	public APCIKJKOFFA AJANBKBPNLG(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "11")]
	public IPMBCDCODNO HJNCPJOFGLH(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "12")]
	public LAPABDNBKEL AFOJAIKJLPP(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "13")]
	public JODNIHJBOHE FFFJGMLCDHN(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0")]
	public DAEKEHIIKPF HFKOBJNFOOF(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0")]
	public DCGJNNGHHLI AAPILGGKCLG(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0")]
	public IKAKBIOMPDF JDHJOPADKDN(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0")]
	public LHEJJKMLCIH IJNNDFKMFBK(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0")]
	public HLPEKNPGDKB IIDDANJKEMC(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public HHKCEENKGLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "14")]
	private DAEKEHIIKPF ECFCPPKOBEG(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "15")]
	private DCGJNNGHHLI NKIPNLNHHNM(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "16")]
	private IKAKBIOMPDF BMCAJLLDOIA(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "17")]
	private LHEJJKMLCIH PENNPFFMMIM(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "18")]
	private HLPEKNPGDKB IGEFLLNJEID(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(KPMMGPIKJNM), new string[] { })]
public class EGDOIDNPMIK : KPMMGPIKJNM, JOGFKELELCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly KPMMGPIKJNM OJDLEEKJJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly KPMMGPIKJNM MJEJPGIMDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CGIJAKAAGPG IMOCJIJLNFC;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private KPMMGPIKJNM HNHMCLFGMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8289440", Offset = "0x8287C40", VA = "0x188289440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8289940", Offset = "0x8288140", VA = "0x188289940", Slot = "20")]
	public void InitReferences(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8289990", Offset = "0x8288190", VA = "0x188289990", Slot = "4")]
	public OFLIAFKELJJ JLCFNEJEHPD(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8289070", Offset = "0x8287870", VA = "0x188289070", Slot = "5")]
	public EPAEGNHFMMA AGAIJKIHOGG(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8289250", Offset = "0x8287A50", VA = "0x188289250", Slot = "6")]
	public KKJLLKMBFHB AMDIMLDDMCD(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8289A30", Offset = "0x8288230", VA = "0x188289A30", Slot = "7")]
	public ANKDFHDMFPN NGAEGNAEOGK(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x82891B0", Offset = "0x82879B0", VA = "0x1882891B0", Slot = "8")]
	public IJCDKAKCJEK AJKJNNJEAHE(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8289550", Offset = "0x8287D50", VA = "0x188289550", Slot = "9")]
	public MEPPGBOMDON BPOHAFHEBKG(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8289110", Offset = "0x8287910", VA = "0x188289110", Slot = "10")]
	public APCIKJKOFFA AJANBKBPNLG(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8289740", Offset = "0x8287F40", VA = "0x188289740", Slot = "11")]
	public IPMBCDCODNO HJNCPJOFGLH(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8288FD0", Offset = "0x82877D0", VA = "0x188288FD0", Slot = "12")]
	public LAPABDNBKEL AFOJAIKJLPP(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x82896A0", Offset = "0x8287EA0", VA = "0x1882896A0", Slot = "13")]
	public JODNIHJBOHE FFFJGMLCDHN(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x82895F0", Offset = "0x8287DF0", VA = "0x1882895F0")]
	public DAEKEHIIKPF HFKOBJNFOOF(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8288F20", Offset = "0x8287720", VA = "0x188288F20")]
	public DCGJNNGHHLI AAPILGGKCLG(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x82894A0", Offset = "0x8287CA0", VA = "0x1882894A0")]
	public IKAKBIOMPDF JDHJOPADKDN(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8289890", Offset = "0x8288090", VA = "0x188289890")]
	public LHEJJKMLCIH IJNNDFKMFBK(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x82897E0", Offset = "0x8287FE0", VA = "0x1882897E0")]
	public HLPEKNPGDKB IIDDANJKEMC(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x82892F0", Offset = "0x8287AF0", VA = "0x1882892F0", Slot = "19")]
	public GDKBCAGCEIA AOHFFINJJMN(RigidbodyEx MHNKLADFOHL, MBPKKAEDNLN NFNBKNAJBPN, HKDLEKPKHHB IPKPNIAEJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8289AD0", Offset = "0x82882D0", VA = "0x188289AD0")]
	public EGDOIDNPMIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x82895F0", Offset = "0x8287DF0", VA = "0x1882895F0", Slot = "14")]
	private DAEKEHIIKPF ECFCPPKOBEG(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8288F20", Offset = "0x8287720", VA = "0x188288F20", Slot = "15")]
	private DCGJNNGHHLI NKIPNLNHHNM(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x82894A0", Offset = "0x8287CA0", VA = "0x1882894A0", Slot = "16")]
	private IKAKBIOMPDF BMCAJLLDOIA(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8289890", Offset = "0x8288090", VA = "0x188289890", Slot = "17")]
	private LHEJJKMLCIH PENNPFFMMIM(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x82897E0", Offset = "0x8287FE0", VA = "0x1882897E0", Slot = "18")]
	private HLPEKNPGDKB IGEFLLNJEID(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BCPIJAEFEKP : OFLIAFKELJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFLMNIPCHGD(GDKBCAGCEIA MHNKLADFOHL);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMBFIEHHGPA(GDKBCAGCEIA MHNKLADFOHL);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGLKNFKMGJF(GDKBCAGCEIA DFMIOKFFOEB);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ENDJLPJJGDI(GDKBCAGCEIA DFMIOKFFOEB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ENJPJLFMPFM : KKJLLKMBFHB
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	GBGBLMPKPFA<GDKBCAGCEIA> FCCOJNBAECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	GDKBCAGCEIA LCDIIDHLIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface OKAPINGJKJA : LHEJJKMLCIH
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) DMMJFGAHJPE(Rigidbody BNJCJEAMKFM);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface FCJBHFFLEEC : DCGJNNGHHLI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PhotonView BMPKGEDPAGI
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class KCOLHPLHEIH : LAPABDNBKEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly EBCHAJDEHHB MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode CCNBDBCLHLE;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody OPNCMGGOPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x828C900", Offset = "0x828B100", VA = "0x18828C900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode BMKFHFJKBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x828C7E0", Offset = "0x828AFE0", VA = "0x18828C7E0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x828C770", Offset = "0x828AF70", VA = "0x18828C770", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x8288E20", Offset = "0x8287620", VA = "0x188288E20")]
	public KCOLHPLHEIH(GDKBCAGCEIA MHNKLADFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x828C5D0", Offset = "0x828ADD0", VA = "0x18828C5D0", Slot = "6")]
	public void AEBHHIOLPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x828C6E0", Offset = "0x828AEE0", VA = "0x18828C6E0", Slot = "9")]
	public void BCHLLKEGJIC(Rigidbody NMOLGGIPLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x828C8F0", Offset = "0x828B0F0", VA = "0x18828C8F0", Slot = "7")]
	public void KHOODOJMHCE(bool PIMLLNPGCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x828C760", Offset = "0x828AF60", VA = "0x18828C760", Slot = "8")]
	public void CCJLLNFELGE(bool PIMLLNPGCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x828CA70", Offset = "0x828B270", VA = "0x18828CA70", Slot = "10")]
	public bool POLHEFCBKCM(Vector3 ELEEIMOLKDP, [Out] RaycastHit CHIFGMMDKPM, float ECLNGJKMDDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x828C950", Offset = "0x828B150", VA = "0x18828C950")]
	private void OCIJIEEFDHF(bool PIMLLNPGCPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DEMLCLPFNFK : MEPPGBOMDON, IDisposable, BNDCELMPOLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EBCHAJDEHHB MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private LDLKAPLIJLM KNCHKLBJGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private MKOALGGHCAA DGMCDJLIEMB;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public LDLKAPLIJLM EOGPKINPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8281350", Offset = "0x827FB50", VA = "0x188281350", Slot = "6")]
		get
		{
			return default(LDLKAPLIJLM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8281010", Offset = "0x827F810", VA = "0x188281010", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform GPHNAIDLOGK
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xC93810", Offset = "0xC92010", VA = "0x180C93810", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<GLBLJMJHHNB, GLBLJMJHHNB> HPCPGOPELBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8281590", Offset = "0x827FD90", VA = "0x188281590", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8281490", Offset = "0x827FC90", VA = "0x188281490", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8281640", Offset = "0x827FE40", VA = "0x188281640")]
	public DEMLCLPFNFK(GDKBCAGCEIA MHNKLADFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x82810E0", Offset = "0x827F8E0", VA = "0x1882810E0", Slot = "8")]
	public void AEBHHIOLPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x8281540", Offset = "0x827FD40", VA = "0x188281540", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x116E150", Offset = "0x116C950", VA = "0x18116E150", Slot = "11")]
	private void GPKFPKHOLAF(GLBLJMJHHNB FHGCLIBHLLA, GLBLJMJHHNB OLMOEHOBPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "12")]
	private void CJKAKCIAIJA(bool POJMALAACLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HHFJKHMIPKG : KPMMGPIKJNM
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x828C0F0", Offset = "0x828A8F0", VA = "0x18828C0F0", Slot = "4")]
	public OFLIAFKELJJ JLCFNEJEHPD(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x828B430", Offset = "0x8289C30", VA = "0x18828B430", Slot = "5")]
	public EPAEGNHFMMA AGAIJKIHOGG(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x828B740", Offset = "0x8289F40", VA = "0x18828B740", Slot = "6")]
	public KKJLLKMBFHB AMDIMLDDMCD(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x828C1E0", Offset = "0x828A9E0", VA = "0x18828C1E0", Slot = "7")]
	public ANKDFHDMFPN NGAEGNAEOGK(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x828B670", Offset = "0x8289E70", VA = "0x18828B670", Slot = "8")]
	public IJCDKAKCJEK AJKJNNJEAHE(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x828BAF0", Offset = "0x828A2F0", VA = "0x18828BAF0", Slot = "9")]
	public MEPPGBOMDON BPOHAFHEBKG(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x828B550", Offset = "0x8289D50", VA = "0x18828B550", Slot = "10")]
	public APCIKJKOFFA AJANBKBPNLG(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x828BDC0", Offset = "0x828A5C0", VA = "0x18828BDC0", Slot = "11")]
	public IPMBCDCODNO HJNCPJOFGLH(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x828B370", Offset = "0x8289B70", VA = "0x18828B370", Slot = "12")]
	public LAPABDNBKEL AFOJAIKJLPP(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x828BD00", Offset = "0x828A500", VA = "0x18828BD00", Slot = "13")]
	public JODNIHJBOHE FFFJGMLCDHN(GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x828BBC0", Offset = "0x828A3C0", VA = "0x18828BBC0")]
	public DAEKEHIIKPF HFKOBJNFOOF(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x828B1E0", Offset = "0x82899E0", VA = "0x18828B1E0")]
	public DCGJNNGHHLI AAPILGGKCLG(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x828B9C0", Offset = "0x828A1C0", VA = "0x18828B9C0")]
	public IKAKBIOMPDF JDHJOPADKDN(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x828BF60", Offset = "0x828A760", VA = "0x18828BF60")]
	public LHEJJKMLCIH IJNNDFKMFBK(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x828BE80", Offset = "0x828A680", VA = "0x18828BE80")]
	public HLPEKNPGDKB IIDDANJKEMC(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x828B870", Offset = "0x828A070", VA = "0x18828B870", Slot = "19")]
	public GDKBCAGCEIA AOHFFINJJMN(RigidbodyEx MHNKLADFOHL, MBPKKAEDNLN NFNBKNAJBPN, HKDLEKPKHHB IPKPNIAEJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public HHFJKHMIPKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x828BBC0", Offset = "0x828A3C0", VA = "0x18828BBC0", Slot = "14")]
	private DAEKEHIIKPF ECFCPPKOBEG(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x828B1E0", Offset = "0x82899E0", VA = "0x18828B1E0", Slot = "15")]
	private DCGJNNGHHLI NKIPNLNHHNM(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x828B9C0", Offset = "0x828A1C0", VA = "0x18828B9C0", Slot = "16")]
	private IKAKBIOMPDF BMCAJLLDOIA(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x828BF60", Offset = "0x828A760", VA = "0x18828BF60", Slot = "17")]
	private LHEJJKMLCIH PENNPFFMMIM(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x828BE80", Offset = "0x828A680", VA = "0x18828BE80", Slot = "18")]
	private HLPEKNPGDKB IGEFLLNJEID(GDKBCAGCEIA JLPKBNIJDEI, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class LOFGHGOAIDC : IPMBCDCODNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly EBCHAJDEHHB MHNKLADFOHL;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody OPNCMGGOPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x828C900", Offset = "0x828B100", VA = "0x18828C900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool MBOANJLCFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x828D5A0", Offset = "0x828BDA0", VA = "0x18828D5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool EEIMJJONDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x828AFB0", Offset = "0x82897B0", VA = "0x18828AFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private GDKBCAGCEIA BKMKKMCIDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x828D540", Offset = "0x828BD40", VA = "0x18828D540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8288E20", Offset = "0x8287620", VA = "0x188288E20")]
	public LOFGHGOAIDC(GDKBCAGCEIA MHNKLADFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x828D180", Offset = "0x828B980", VA = "0x18828D180", Slot = "4")]
	public void BKLLLLHCDGJ(Vector3 IOHDICMKADP, ForceMode KKMLBMDBNEE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x828D870", Offset = "0x828C070", VA = "0x18828D870")]
	private void LDEEAKEFGNM(Vector3 IOHDICMKADP, ForceMode KKMLBMDBNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x828D5F0", Offset = "0x828BDF0", VA = "0x18828D5F0", Slot = "5")]
	public void IMMOLDDCHNA(Vector3 IOHDICMKADP, Vector3 NCGKJMOKFAF, ForceMode KKMLBMDBNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x828DAD0", Offset = "0x828C2D0", VA = "0x18828DAD0", Slot = "6")]
	public void OCCJDFOICJN(Vector3 FKMHBOJEDEG, ForceMode KKMLBMDBNEE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x828DC30", Offset = "0x828C430", VA = "0x18828DC30")]
	private void OEMNMGKBOCK(Vector3 FKMHBOJEDEG, ForceMode KKMLBMDBNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x828D2E0", Offset = "0x828BAE0", VA = "0x18828D2E0", Slot = "7")]
	public void EHKODDGEHFK(Vector3 FKMHBOJEDEG, ForceMode KKMLBMDBNEE = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class ECJEEGJDIGG : JODNIHJBOHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly EBCHAJDEHHB MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool OJMIMAIHEBH;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool MODDEKJEOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA85410", Offset = "0xA83C10", VA = "0x180A85410", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8288CA0", Offset = "0x82874A0", VA = "0x188288CA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8288E20", Offset = "0x8287620", VA = "0x188288E20")]
	public ECJEEGJDIGG(GDKBCAGCEIA MHNKLADFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8288C70", Offset = "0x8287470", VA = "0x188288C70", Slot = "6")]
	public void BCHLLKEGJIC(Rigidbody NMOLGGIPLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8288DB0", Offset = "0x82875B0", VA = "0x188288DB0", Slot = "7")]
	public void PLMEKNKGJKP(Rigidbody NMOLGGIPLAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class OALCDIKEDNO : BCPIJAEFEKP, OFLIAFKELJJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly GDKBCAGCEIA MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<GDKBCAGCEIA> KONOHDNOGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private GDKBCAGCEIA PNDCHGJLEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private GDKBCAGCEIA DFPCBMGPBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform LMGPCCGHPHJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform FCHHAJKLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8293170", Offset = "0x8291970", VA = "0x188293170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public GDKBCAGCEIA BKMKKMCIDFM
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1F0", Offset = "0x9DB9F0", VA = "0x1809DD1F0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x82929A0", Offset = "0x82911A0", VA = "0x1882929A0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GDKBCAGCEIA DFJAHCLMMPD
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1C0", Offset = "0x9DB9C0", VA = "0x1809DD1C0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<GDKBCAGCEIA> HFHBKLMMJNI
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD210", Offset = "0x9DBA10", VA = "0x1809DD210", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event FNDIPFLKNAB MCDJNNMAMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8293970", Offset = "0x8292170", VA = "0x188293970", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8294030", Offset = "0x8292830", VA = "0x188294030", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event FNDIPFLKNAB EFLOAFEPOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8292AF0", Offset = "0x82912F0", VA = "0x188292AF0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8294490", Offset = "0x8292C90", VA = "0x188294490", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event NDDIPIPMLIO DOGMIKHPCAE
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8293D20", Offset = "0x8292520", VA = "0x188293D20", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x82929B0", Offset = "0x82911B0", VA = "0x1882929B0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action HCCDFFKMACI
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8293A10", Offset = "0x8292210", VA = "0x188293A10", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8294530", Offset = "0x8292D30", VA = "0x188294530", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action HECPBIHLHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8293090", Offset = "0x8291890", VA = "0x188293090", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x82943F0", Offset = "0x8292BF0", VA = "0x1882943F0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<GDKBCAGCEIA> JJLGHCICCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8294170", Offset = "0x8292970", VA = "0x188294170", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x82938C0", Offset = "0x82920C0", VA = "0x1882938C0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<GDKBCAGCEIA> IIPKFBPGAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x82928F0", Offset = "0x82910F0", VA = "0x1882928F0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8293DC0", Offset = "0x82925C0", VA = "0x188293DC0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action MCOOKKHAOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x82940D0", Offset = "0x82928D0", VA = "0x1882940D0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8294220", Offset = "0x8292A20", VA = "0x188294220", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<GDKBCAGCEIA> IBILBCCPLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8293F80", Offset = "0x8292780", VA = "0x188293F80", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8293290", Offset = "0x8291A90", VA = "0x188293290", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8294700", Offset = "0x8292F00", VA = "0x188294700")]
	public OALCDIKEDNO(GDKBCAGCEIA MHNKLADFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8292C30", Offset = "0x8291430", VA = "0x188292C30", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x8293340", Offset = "0x8291B40", VA = "0x188293340", Slot = "30")]
	public void GDNIECKCIEP(GDKBCAGCEIA GPDOCAJDCGI, bool NHEENLIEFAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8293AB0", Offset = "0x82922B0", VA = "0x188293AB0", Slot = "6")]
	public void IGLKNFKMGJF(GDKBCAGCEIA DFMIOKFFOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8292E10", Offset = "0x8291610", VA = "0x188292E10", Slot = "7")]
	public void ENDJLPJJGDI(GDKBCAGCEIA DFMIOKFFOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8293E70", Offset = "0x8292670", VA = "0x188293E70", Slot = "4")]
	public void JFLMNIPCHGD(GDKBCAGCEIA MHNKLADFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8292B90", Offset = "0x8291390", VA = "0x188292B90", Slot = "5")]
	public void BMBFIEHHGPA(GDKBCAGCEIA MHNKLADFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8292A50", Offset = "0x8291250", VA = "0x188292A50")]
	private void BCJLNEGODED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8293130", Offset = "0x8291930", VA = "0x188293130")]
	private void FDOHDCMPFNC(GDKBCAGCEIA DFMIOKFFOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8292CD0", Offset = "0x82914D0", VA = "0x188292CD0")]
	private void EBBLIMAEHEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x82945D0", Offset = "0x8292DD0", VA = "0x1882945D0")]
	private void PHNEFFGOOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x82942C0", Offset = "0x8292AC0", VA = "0x1882942C0")]
	private void NNMMDMKEJMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x82931D0", Offset = "0x82919D0", VA = "0x1882931D0")]
	[CompilerGenerated]
	private object FFGLFMCGMOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class AGCBCDIIFKO
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x827E640", Offset = "0x827CE40", VA = "0x18827E640")]
	public static BCPIJAEFEKP GIKNDILAGGF(this GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class GAOICEOHAJL : ENJPJLFMPFM, KKJLLKMBFHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly EBCHAJDEHHB MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly GBGBLMPKPFA<GDKBCAGCEIA> EGHGLPFBJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool ECPFIPEDOGD;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public GBGBLMPKPFA<GDKBCAGCEIA> FCCOJNBAECC
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 AOFPKPBCAPC
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x828A000", Offset = "0x8288800", VA = "0x18828A000", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 FDLOOIMHJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x828A430", Offset = "0x8288C30", VA = "0x18828A430", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 KNJCODDIFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8289B80", Offset = "0x8288380", VA = "0x188289B80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public GDKBCAGCEIA LCDIIDHLIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x828A660", Offset = "0x8288E60", VA = "0x18828A660", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x828A710", Offset = "0x8288F10", VA = "0x18828A710")]
	public GAOICEOHAJL(GDKBCAGCEIA MHNKLADFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x828A5F0", Offset = "0x8288DF0", VA = "0x18828A5F0", Slot = "8")]
	public void PEIGCOPIPAK(GDKBCAGCEIA DFPCBMGPBFO, object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x828A3D0", Offset = "0x8288BD0", VA = "0x18828A3D0", Slot = "9")]
	public void LBICDEMEAHP(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x828A030", Offset = "0x8288830", VA = "0x18828A030")]
	private Vector3 KNHJBPCJPIJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8289C70", Offset = "0x8288470", VA = "0x188289C70")]
	private void BEDACGMPGHO(GDKBCAGCEIA LDKLJMAHDNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class DLLAONOHHJE
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8282390", Offset = "0x8280B90", VA = "0x188282390")]
	public static ENJPJLFMPFM BDBEOAOCBNF(this GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class AMFBDFKMDBO : OKAPINGJKJA, LHEJJKMLCIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly EBCHAJDEHHB MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 DMHCFGBDPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 CIBHNMHOCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float GJPHIKFMONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float CHBBDIPLMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 FLAEDOBGOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? JDBICJJCEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? PHAGKHNDLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool IIPAENHKGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool PFCEECKKGJP;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 MJDHBOMHLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x15D57B0", Offset = "0x15D3FB0", VA = "0x1815D57B0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x827EA90", Offset = "0x827D290", VA = "0x18827EA90", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 GFEIFHPPKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x827E7A0", Offset = "0x827CFA0", VA = "0x18827E7A0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float OKBOIFJHIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xCBABF0", Offset = "0xCB93F0", VA = "0x180CBABF0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x827FD90", Offset = "0x827E590", VA = "0x18827FD90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float LCGEHHPDACH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xBD7EF0", Offset = "0xBD66F0", VA = "0x180BD7EF0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x827EE70", Offset = "0x827D670", VA = "0x18827EE70", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 GBLDNHNDBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8280410", Offset = "0x827EC10", VA = "0x188280410", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion HNBPIOHMHKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x827EB40", Offset = "0x827D340", VA = "0x18827EB40", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody OPNCMGGOPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x82809B0", Offset = "0x827F1B0", VA = "0x1882809B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event FNDIPFLKNAB EAGMDIDGBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8280C30", Offset = "0x827F430", VA = "0x188280C30", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x827E700", Offset = "0x827CF00", VA = "0x18827E700", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8280EB0", Offset = "0x827F6B0", VA = "0x188280EB0")]
	public AMFBDFKMDBO(GDKBCAGCEIA MHNKLADFOHL, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x827E890", Offset = "0x827D090", VA = "0x18827E890", Slot = "17")]
	public void AOPHHMAEJCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x827FEA0", Offset = "0x827E6A0", VA = "0x18827FEA0", Slot = "16")]
	public void FCGMCLAFHII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x827E9B0", Offset = "0x827D1B0", VA = "0x18827E9B0", Slot = "19")]
	public void BCHLLKEGJIC(Rigidbody NMOLGGIPLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8280CD0", Offset = "0x827F4D0", VA = "0x188280CD0", Slot = "20")]
	public void PLMEKNKGJKP(Rigidbody NMOLGGIPLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x827ECC0", Offset = "0x827D4C0", VA = "0x18827ECC0", Slot = "18")]
	public void CFPHIACOOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x827FF80", Offset = "0x827E780", VA = "0x18827FF80", Slot = "21")]
	public void FIKBBIPHFKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x827EA90", Offset = "0x827D290", VA = "0x18827EA90")]
	private void KHEJBKEJPNO(Vector3 OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x82808C0", Offset = "0x827F0C0", VA = "0x1882808C0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 LCMAJCJFLCI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x827FD90", Offset = "0x827E590", VA = "0x18827FD90")]
	private void FBHAKNKKNCB(float OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x827EE70", Offset = "0x827D670", VA = "0x18827EE70")]
	private void HNFFCDHMJPH(float OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8280720", Offset = "0x827EF20", VA = "0x188280720")]
	private Vector3 GNNCMBNGPEA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8280A00", Offset = "0x827F200", VA = "0x188280A00", Slot = "15")]
	public void ODEPOCEJIHB((Quaternion rot, Vector3 moments) ADLDOCGHNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x82805A0", Offset = "0x827EDA0", VA = "0x1882805A0")]
	private Quaternion GLDHHNDBIJM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x827FCC0", Offset = "0x827E4C0", VA = "0x18827FCC0")]
	public void DMMJFGAHJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x827EF20", Offset = "0x827D720", VA = "0x18827EF20", Slot = "4")]
	public (float, Vector3) DMMJFGAHJPE(Rigidbody BNJCJEAMKFM)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class GNNNCPPHCNF
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x828B120", Offset = "0x8289920", VA = "0x18828B120")]
	public static OKAPINGJKJA DKEHNGDPJNA(this GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class ABMAOHFIGPD : IKAKBIOMPDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly EBCHAJDEHHB MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly FLJKJAPOKJM OHOMNGCCLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LBIAHMGKBGM CMBPKLECODO;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool AHCHPLIFMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1770AA0", Offset = "0x176F2A0", VA = "0x181770AA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public LBIAHMGKBGM POPKGEDJDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0", Slot = "11")]
		get
		{
			return default(LBIAHMGKBGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x827E540", Offset = "0x827CD40", VA = "0x18827E540")]
	public ABMAOHFIGPD(GDKBCAGCEIA MHNKLADFOHL, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x827DF30", Offset = "0x827C730", VA = "0x18827DF30", Slot = "4")]
	public void AEBHHIOLPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x827E1D0", Offset = "0x827C9D0", VA = "0x18827E1D0")]
	private bool GMOHLLKJNAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x827E000", Offset = "0x827C800", VA = "0x18827E000", Slot = "5")]
	public void AOKEJFFGOJM(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x827E1A0", Offset = "0x827C9A0", VA = "0x18827E1A0", Slot = "6")]
	public void GMFMFILOLFL(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x827E070", Offset = "0x827C870", VA = "0x18827E070", Slot = "9")]
	public void EILFJIGKADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x827E3F0", Offset = "0x827CBF0", VA = "0x18827E3F0")]
	private void OAAJHJIHHKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x827E270", Offset = "0x827CA70", VA = "0x18827E270")]
	private void NMPOIMLCGID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x827E500", Offset = "0x827CD00", VA = "0x18827E500", Slot = "8")]
	public void PHJOFHMFNCE(GDKBCAGCEIA MHNKLADFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x827E030", Offset = "0x827C830", VA = "0x18827E030", Slot = "7")]
	public void CLGEJGBPIMG(GDKBCAGCEIA MHNKLADFOHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class NACEBGEFLIE : APCIKJKOFFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly EBCHAJDEHHB MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly FLJKJAPOKJM DBJPBPPFLNB;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool MBOANJLCFCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x828E210", Offset = "0x828CA10", VA = "0x18828E210", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event FNDIPFLKNAB KJDBBLBEOGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x828E2C0", Offset = "0x828CAC0", VA = "0x18828E2C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x828E3B0", Offset = "0x828CBB0", VA = "0x18828E3B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x828E480", Offset = "0x828CC80", VA = "0x18828E480")]
	public NACEBGEFLIE(GDKBCAGCEIA MHNKLADFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x828E200", Offset = "0x828CA00", VA = "0x18828E200", Slot = "7")]
	public void EHODPBBNBAJ(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x828E3A0", Offset = "0x828CBA0", VA = "0x18828E3A0", Slot = "8")]
	public void KMNNOCLBOAB(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x828E0F0", Offset = "0x828C8F0", VA = "0x18828E0F0", Slot = "9")]
	public void BGOPPMHIIOA(object JILOCOLKOMJ, bool LAKEKLDFPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x828E360", Offset = "0x828CB60", VA = "0x18828E360", Slot = "12")]
	public void KBPOPOOAPNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x828E070", Offset = "0x828C870", VA = "0x18828E070", Slot = "10")]
	public void BCHLLKEGJIC(Rigidbody DNDBHALNMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x828E450", Offset = "0x828CC50", VA = "0x18828E450", Slot = "11")]
	public void PLMEKNKGJKP(Rigidbody NMOLGGIPLAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class NGMCKLPAMNE : FCJBHFFLEEC, DCGJNNGHHLI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly EBCHAJDEHHB MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PhotonView ANFLHMAADCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool FHKOPCAAOPN;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView BMPKGEDPAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool JAPKJEKLGAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x828EEE0", Offset = "0x828D6E0", VA = "0x18828EEE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool CCLBBOJOHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xD83850", Offset = "0xD82050", VA = "0x180D83850", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event FNDIPFLKNAB AGMDLEMNFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x828EF00", Offset = "0x828D700", VA = "0x18828EF00", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x828EA60", Offset = "0x828D260", VA = "0x18828EA60", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x828F110", Offset = "0x828D910", VA = "0x18828F110")]
	public NGMCKLPAMNE(GDKBCAGCEIA MHNKLADFOHL, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x828E570", Offset = "0x828CD70", VA = "0x18828E570", Slot = "9")]
	public void AEBHHIOLPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x828E960", Offset = "0x828D160", VA = "0x18828E960", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x828E7F0", Offset = "0x828CFF0", VA = "0x18828E7F0", Slot = "10")]
	public void CCIFDLCFGCA(GDKBCAGCEIA DFPCBMGPBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x828ED70", Offset = "0x828D570", VA = "0x18828ED70", Slot = "11")]
	public void LOIHEAFKNCE(GDKBCAGCEIA DFPCBMGPBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x828EFA0", Offset = "0x828D7A0", VA = "0x18828EFA0")]
	private void OJDEBGNAFLF(PhotonView OBBGJOFDPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x828E6A0", Offset = "0x828CEA0", VA = "0x18828E6A0")]
	private void BKPPFIFDODN(PHIEGKANMEI LAPPPFKLALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x828EB00", Offset = "0x828D300", VA = "0x18828EB00")]
	private void LBAKFFEDMBA(PhotonView KPJPBKHBECO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class KPGFDCBDNLF
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x828CBD0", Offset = "0x828B3D0", VA = "0x18828CBD0")]
	public static FCJBHFFLEEC LOEKGKDPOAO(this GDKBCAGCEIA JLPKBNIJDEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class LFJIOBOGMCJ : HLPEKNPGDKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly EBCHAJDEHHB MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints KLIMCHMEJBB;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool NKBIAPCOCPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xCE8D70", Offset = "0xCE7570", VA = "0x180CE8D70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool ELIKOKFENLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xCE8C60", Offset = "0xCE7460", VA = "0x180CE8C60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xCE83E0", Offset = "0xCE6BE0", VA = "0x180CE83E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints EKHJBHKHECD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x828CCC0", Offset = "0x828B4C0", VA = "0x18828CCC0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x828CE20", Offset = "0x828B620", VA = "0x18828CE20")]
	public LFJIOBOGMCJ(GDKBCAGCEIA MHNKLADFOHL, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x828CC90", Offset = "0x828B490", VA = "0x18828CC90", Slot = "9")]
	public void BCHLLKEGJIC(Rigidbody NMOLGGIPLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x828CDF0", Offset = "0x828B5F0", VA = "0x18828CDF0", Slot = "10")]
	public void PLMEKNKGJKP(Rigidbody NMOLGGIPLAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class HJLAEPIPHGD : ANKDFHDMFPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly GDKBCAGCEIA MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float AEBFBCIHNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float LBEAICOAIPK;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float ANELGFOKONF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xEB6410", Offset = "0xEB4C10", VA = "0x180EB6410", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x828C420", Offset = "0x828AC20", VA = "0x18828C420", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float PJKJFEBLNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xD03120", Offset = "0xD01920", VA = "0x180D03120", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x828C350", Offset = "0x828AB50", VA = "0x18828C350", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x828C590", Offset = "0x828AD90", VA = "0x18828C590")]
	public HJLAEPIPHGD(GDKBCAGCEIA MHNKLADFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x828C300", Offset = "0x828AB00", VA = "0x18828C300", Slot = "8")]
	public void BCHLLKEGJIC(Rigidbody NMOLGGIPLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x828C4F0", Offset = "0x828ACF0", VA = "0x18828C4F0", Slot = "9")]
	public void PLMEKNKGJKP(Rigidbody NMOLGGIPLAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class DGBFOIMGNKD : IJCDKAKCJEK
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly LLPKKNNAIAE NAECKOGBKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly EBCHAJDEHHB MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool KLFEMEPACMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool AJPOMIJGGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int EFFDDNLJFPG;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody OPNCMGGOPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x82809B0", Offset = "0x827F1B0", VA = "0x1882809B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool ABMMJEEEPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8282160", Offset = "0x8280960", VA = "0x188282160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private GDKBCAGCEIA BKMKKMCIDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8281DA0", Offset = "0x82805A0", VA = "0x188281DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool EEIMJJONDNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8282180", Offset = "0x8280980", VA = "0x188282180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event FNDIPFLKNAB JGIIEHNDEEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8281D00", Offset = "0x8280500", VA = "0x188281D00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8281C60", Offset = "0x8280460", VA = "0x188281C60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8282300", Offset = "0x8280B00", VA = "0x188282300")]
	public DGBFOIMGNKD(GDKBCAGCEIA MHNKLADFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x82816D0", Offset = "0x827FED0", VA = "0x1882816D0", Slot = "6")]
	public void AEBHHIOLPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8281760", Offset = "0x827FF60", VA = "0x188281760", Slot = "8")]
	public void BNEDNOMIGHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8281B10", Offset = "0x8280310", VA = "0x188281B10", Slot = "7")]
	public bool EJBOBEPMKHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x82821E0", Offset = "0x82809E0", VA = "0x1882821E0", Slot = "9")]
	public void POODEKDDHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x82820C0", Offset = "0x82808C0", VA = "0x1882820C0", Slot = "13")]
	public void OKGHPCCIHAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x82819F0", Offset = "0x82801F0", VA = "0x1882819F0", Slot = "12")]
	public void DAKKDCGFKFB(bool ALNHEFKPHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8281E00", Offset = "0x8280600", VA = "0x188281E00", Slot = "10")]
	public bool HGADFJBECFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8282000", Offset = "0x8280800", VA = "0x188282000", Slot = "11")]
	public bool KGPKIABBODF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8281770", Offset = "0x827FF70", VA = "0x188281770")]
	private bool CBECELIFICC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8281E70", Offset = "0x8280670", VA = "0x188281E70")]
	private void JJACIOIBHFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class GGLGCMAGDID : DAEKEHIIKPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly EBCHAJDEHHB MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly FLJKJAPOKJM OKEBJMKPENP;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody OPNCMGGOPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool EEIMJJONDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x828AFB0", Offset = "0x82897B0", VA = "0x18828AFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool MCJJADGECMA
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1770AA0", Offset = "0x176F2A0", VA = "0x181770AA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x828B010", Offset = "0x8289810", VA = "0x18828B010")]
	public GGLGCMAGDID(GDKBCAGCEIA MHNKLADFOHL, [In] MBPKKAEDNLN NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x828A810", Offset = "0x8289010", VA = "0x18828A810", Slot = "5")]
	public void AEBHHIOLPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x828A8B0", Offset = "0x82890B0", VA = "0x18828A8B0", Slot = "7")]
	public void AICDEMPEFDP(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x828AC10", Offset = "0x8289410", VA = "0x18828AC10", Slot = "8")]
	public void JIKJAMIHJAA(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x828A8E0", Offset = "0x82890E0", VA = "0x18828A8E0", Slot = "9")]
	public void IEBDGHKIJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x828AC40", Offset = "0x8289440", VA = "0x18828AC40", Slot = "10")]
	public void MOIEDLCCMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x828AE30", Offset = "0x8289630", VA = "0x18828AE30", Slot = "11")]
	public void PIFGBKHLKAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class NNAJOFFFOFJ : EPAEGNHFMMA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly EBCHAJDEHHB MHNKLADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly FLJKJAPOKJM IPOGMLCLNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float CHHPBJDEEKK;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public CHJDOPIOJPF DJGPCKEJFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public MDAEMGHHEEI IFOLNHGDNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 KNJCODDIFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x828F4C0", Offset = "0x828DCC0", VA = "0x18828F4C0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x828F7A0", Offset = "0x828DFA0", VA = "0x18828F7A0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 PNALLFEIODC
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x82923A0", Offset = "0x8290BA0", VA = "0x1882923A0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8292520", Offset = "0x8290D20", VA = "0x188292520", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 KCFLMICDHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8292550", Offset = "0x8290D50", VA = "0x188292550", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8291930", Offset = "0x8290130", VA = "0x188291930", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 OPLKOCLBGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x828FC30", Offset = "0x828E430", VA = "0x18828FC30", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x82926A0", Offset = "0x8290EA0", VA = "0x1882926A0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float MKNFODOJMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xEB9D60", Offset = "0xEB8560", VA = "0x180EB9D60", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x82907C0", Offset = "0x828EFC0", VA = "0x1882907C0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool PPODHFIDBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x20AC760", Offset = "0x20AAF60", VA = "0x1820AC760", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private IPMBCDCODNO EBGKKOBIMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x78C1050", Offset = "0x78BF850", VA = "0x1878C1050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool ABMMJEEEPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x82926D0", Offset = "0x8290ED0", VA = "0x1882926D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8292800", Offset = "0x8291000", VA = "0x188292800")]
	public NNAJOFFFOFJ(GDKBCAGCEIA MHNKLADFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x828F420", Offset = "0x828DC20", VA = "0x18828F420", Slot = "19")]
	public void AEBHHIOLPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x828FA40", Offset = "0x828E240", VA = "0x18828FA40", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x828F610", Offset = "0x828DE10", VA = "0x18828F610", Slot = "28")]
	public void BCHLLKEGJIC(Rigidbody NMOLGGIPLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x1595960", Offset = "0x1594160", VA = "0x181595960", Slot = "20")]
	public void KFOGNMFNIPD(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x1595EE0", Offset = "0x15946E0", VA = "0x181595EE0", Slot = "30")]
	public void JFADBLGNNHB(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x828F860", Offset = "0x828E060", VA = "0x18828F860", Slot = "35")]
	public Vector3 DCDLPLHNFEJ(Vector3 DIPBPPFCBBL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x828F260", Offset = "0x828DA60", VA = "0x18828F260", Slot = "34")]
	public Vector3 AAGLFKAIHBB(Vector3 AJKHHBKHKFM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x828F420", Offset = "0x828DC20", VA = "0x18828F420", Slot = "27")]
	public void EOJNKAGEINB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x828F740", Offset = "0x828DF40", VA = "0x18828F740", Slot = "25")]
	public void BDHEJHPCKND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x82924C0", Offset = "0x8290CC0", VA = "0x1882924C0", Slot = "24")]
	public void LPJCCGPGAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x82909B0", Offset = "0x828F1B0", VA = "0x1882909B0", Slot = "33")]
	public void FOMOFHDHOLK(Vector3 ADFNPAHJJPN, Vector3 EFJBLAGMOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8290D90", Offset = "0x828F590", VA = "0x188290D90", Slot = "32")]
	public void GGBDGHLCOHD(Vector3 JCNJOFMBACI, Vector3 FHCAMOOFEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8290620", Offset = "0x828EE20", VA = "0x188290620", Slot = "31")]
	public void FGJKGGCGJIE(Vector3 LJIHODIHHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x828FFD0", Offset = "0x828E7D0", VA = "0x18828FFD0", Slot = "22")]
	public void EKLPHNIANMH(BEKOKAGGBFN INGIIIHLDGC, Vector3 PPKNLPOPFLE, float GBPBCCOFJFK, float MDBPJKOKEGF = 8f, float AOJEEBFLHCB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x828FD50", Offset = "0x828E550", VA = "0x18828FD50", Slot = "21")]
	public void EJAHPKKMCPJ(FBDAOBLHIEH GMLICJILPOE, Vector3 IFMNFMEAKID, float NCNCGHGIJLC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x82914B0", Offset = "0x828FCB0", VA = "0x1882914B0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void KCKBDILFFOO(FBDAOBLHIEH GMLICJILPOE, Vector3 PMHMEKBKJJA, float OLCPAEAGNDC = 7f, float KIJDFDGNDME = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x16A37D0", Offset = "0x16A1FD0", VA = "0x1816A37D0")]
	private static void BMHPIOOKMLL(Vector3 CPDFCHMENBI, Vector3 GLANACDLEOF, [Out] Vector3 KMNKKOMOJNN, [Out] Vector3 JAICIFPEKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x82908D0", Offset = "0x828F0D0", VA = "0x1882908D0", Slot = "29")]
	public Vector3 FHCGODLNJHA(Vector3 CPDFCHMENBI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x828FAA0", Offset = "0x828E2A0", VA = "0x18828FAA0", Slot = "26")]
	public void EEJKMNNJIJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x82907C0", Offset = "0x828EFC0", VA = "0x1882907C0")]
	private void FHBILNMNEKL(float OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8290BF0", Offset = "0x828F3F0", VA = "0x188290BF0")]
	private void FPPLHONLPBJ(Vector3 IFMNFMEAKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x82926F0", Offset = "0x8290EF0", VA = "0x1882926F0")]
	private Vector3 PJKCCOIHLFP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x82919F0", Offset = "0x82901F0", VA = "0x1882919F0")]
	private void KDJELEMFMCK(Vector3 AJKHHBKHKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8291390", Offset = "0x828FB90", VA = "0x188291390")]
	private Vector3 JKLPDPMGFPG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8291F20", Offset = "0x8290720", VA = "0x188291F20")]
	private void KNEKDFLAHIH(Vector3 OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8290DF0", Offset = "0x828F5F0", VA = "0x188290DF0")]
	private void IDIJOFDALAB(Vector3 AJKHHBKHKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8291E70", Offset = "0x8290670", VA = "0x188291E70")]
	private void KLCBDGKPEMF()
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
