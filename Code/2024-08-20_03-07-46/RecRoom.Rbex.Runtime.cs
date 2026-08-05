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
using RecRoom.Logging.Attributes;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : AGBKNAFJGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FDD660", Offset = "0x6FDC660", VA = "0x186FDD660", Slot = "4")]
		public override void GGLLICMBJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
	public class _AssemblyIndex : HPGCOLCGLFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private JCHPKCLPDGD bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x15E63F0", Offset = "0x15E53F0", VA = "0x1815E63F0", Slot = "5")]
		public override void JGHHFPAAFIK(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4F80", Offset = "0x6FE3F80", VA = "0x186FE4F80")]
		private void JFFKPLCLODI(LBEKBNOBNBA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4F20", Offset = "0x6FE3F20", VA = "0x186FE4F20", Slot = "6")]
		public override void AKPNBKINMBO(LBEKBNOBNBA registry, [In] ACFLJKIEOHM filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "9")]
		public override void EGOKAKAMEDC(MIBLFBDCCLC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5280", Offset = "0x6FE4280", VA = "0x186FE5280")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, FKKFNKHOOAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly PHLKHBEJKKB NLLCGHPADOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool DLNEGKCDFGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private DFKFCELAIFJ GCPNEJOPCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[FIHOJOMCNEF(JFBJMOOHBCL.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[FIHOJOMCNEF(JFBJMOOHBCL.SelfAndParent, true, false, false)]
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
		private JMHIAMIADEH physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		[SerializeField]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal DFKFCELAIFJ FOIAGJPPEFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6FE0FB0", Offset = "0x6FDFFB0", VA = "0x186FE0FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private DFKFCELAIFJ EKMFKJIDOLK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int OJEOKFFHDBD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2390", Offset = "0x6FE1390", VA = "0x186FE2390")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx OKGOBKLBOBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6FE26F0", Offset = "0x6FE16F0", VA = "0x186FE26F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx KILMHGFMJMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2630", Offset = "0x6FE1630", VA = "0x186FE2630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx EMOKCJBMKOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3390", Offset = "0x6FE2390", VA = "0x186FE3390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4890", Offset = "0x6FE3890", VA = "0x186FE4890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform FOIBFFPMEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x87B000", Offset = "0x87A000", VA = "0x18087B000", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform LAPFKIMJCIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x87B000", Offset = "0x87A000", VA = "0x18087B000", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OIAPKHBMKCC EEMHNCNBDKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6FE23F0", Offset = "0x6FE13F0", VA = "0x186FE23F0")]
			get
			{
				return default(OIAPKHBMKCC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4040", Offset = "0x6FE3040", VA = "0x186FE4040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LLPBCOPOAND
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2A00", Offset = "0x6FE1A00", VA = "0x186FE2A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool HIGNAPNNMIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2510", Offset = "0x6FE1510", VA = "0x186FE2510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public GHKLKADMCLK MAOOOBLDOPL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2940", Offset = "0x6FE1940", VA = "0x186FE2940")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4200", Offset = "0x6FE3200", VA = "0x186FE4200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public JLDEAACPJLG OIKNHNOABJE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6FE28E0", Offset = "0x6FE18E0", VA = "0x186FE28E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4190", Offset = "0x6FE3190", VA = "0x186FE4190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DLGMMAHDEFA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2830", Offset = "0x6FE1830", VA = "0x186FE2830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody MIEMDJAPKBC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2890", Offset = "0x6FE1890", VA = "0x186FE2890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HBBNKPPIMBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2570", Offset = "0x6FE1570", VA = "0x186FE2570")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6FE40B0", Offset = "0x6FE30B0", VA = "0x186FE40B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IAGFDAGEIND
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6CA5030", Offset = "0x6CA4030", VA = "0x186CA5030", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float HHIIADIOGAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3330", Offset = "0x6FE2330", VA = "0x186FE3330")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float PMFOALBFFLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6FE32D0", Offset = "0x6FE22D0", VA = "0x186FE32D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4820", Offset = "0x6FE3820", VA = "0x186FE4820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float GKAKHGCNJLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2C60", Offset = "0x6FE1C60", VA = "0x186FE2C60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6FE44A0", Offset = "0x6FE34A0", VA = "0x186FE44A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float CLPMHAMDMMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2A60", Offset = "0x6FE1A60", VA = "0x186FE2A60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4270", Offset = "0x6FE3270", VA = "0x186FE4270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool DDHKBGIPDHE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6FE38E0", Offset = "0x6FE28E0", VA = "0x186FE38E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4DD0", Offset = "0x6FE3DD0", VA = "0x186FE4DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 KKFPJBJFJOB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6FE30B0", Offset = "0x6FE20B0", VA = "0x186FE30B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6FE45F0", Offset = "0x6FE35F0", VA = "0x186FE45F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 FMEBEEBLELG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3A20", Offset = "0x6FE2A20", VA = "0x186FE3A20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode DONBDMCJPPG
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2BA0", Offset = "0x6FE1BA0", VA = "0x186FE2BA0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6FE43C0", Offset = "0x6FE33C0", VA = "0x186FE43C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float LDIJOKADLGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6FE25D0", Offset = "0x6FE15D0", VA = "0x186FE25D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4120", Offset = "0x6FE3120", VA = "0x186FE4120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints KDMHMPJFOPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2C00", Offset = "0x6FE1C00", VA = "0x186FE2C00")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4430", Offset = "0x6FE3430", VA = "0x186FE4430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 EOBFDOMAGPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3450", Offset = "0x6FE2450", VA = "0x186FE3450")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 AHJADIFNCEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3450", Offset = "0x6FE2450", VA = "0x186FE3450")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4BB0", Offset = "0x6FE3BB0", VA = "0x186FE4BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float FNEHDJDKKGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3190", Offset = "0x6FE2190", VA = "0x186FE3190")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6FE46D0", Offset = "0x6FE36D0", VA = "0x186FE46D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float PIHKOHECKPM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3880", Offset = "0x6FE2880", VA = "0x186FE3880")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4D60", Offset = "0x6FE3D60", VA = "0x186FE4D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion OGLADLCELKF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3530", Offset = "0x6FE2530", VA = "0x186FE3530")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4930", Offset = "0x6FE3930", VA = "0x186FE4930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion PPFBGCFBPGO
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6FE37B0", Offset = "0x6FE27B0", VA = "0x186FE37B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4C90", Offset = "0x6FE3C90", VA = "0x186FE4C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 CILCBNIMHMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3600", Offset = "0x6FE2600", VA = "0x186FE3600")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4A00", Offset = "0x6FE3A00", VA = "0x186FE4A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion JAKFJFEFFKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6FE36E0", Offset = "0x6FE26E0", VA = "0x186FE36E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4AE0", Offset = "0x6FE3AE0", VA = "0x186FE4AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 LKAKKODKGLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3940", Offset = "0x6FE2940", VA = "0x186FE3940")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4E40", Offset = "0x6FE3E40", VA = "0x186FE4E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 CCMFHJLEKOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6FE31F0", Offset = "0x6FE21F0", VA = "0x186FE31F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4740", Offset = "0x6FE3740", VA = "0x186FE4740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 IFMDAJCPKED
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2AC0", Offset = "0x6FE1AC0", VA = "0x186FE2AC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6FE42E0", Offset = "0x6FE32E0", VA = "0x186FE42E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 AMMNBNBOHHD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2FD0", Offset = "0x6FE1FD0", VA = "0x186FE2FD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6FE4510", Offset = "0x6FE3510", VA = "0x186FE4510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 HLMANMMDAEK
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2E90", Offset = "0x6FE1E90", VA = "0x186FE2E90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion LEMMBFDPBCM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2DC0", Offset = "0x6FE1DC0", VA = "0x186FE2DC0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 MBACBKIJMHN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3BE0", Offset = "0x6FE2BE0", VA = "0x186FE3BE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 HCKFGGCCPKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3B00", Offset = "0x6FE2B00", VA = "0x186FE3B00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool GPNAEJAOCBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2F70", Offset = "0x6FE1F70", VA = "0x186FE2F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool LNEJAIMOMMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6FE29A0", Offset = "0x6FE19A0", VA = "0x186FE29A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool PNBMHBCLLEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6FE24B0", Offset = "0x6FE14B0", VA = "0x186FE24B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MKCIOKCMEML
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2450", Offset = "0x6FE1450", VA = "0x186FE2450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool IFCCNAKJLMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2330", Offset = "0x6FE1330", VA = "0x186FE2330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool HIJCLBHGEME
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2CC0", Offset = "0x6FE1CC0", VA = "0x186FE2CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool EFBLDNCDHCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x184E8B0", Offset = "0x184D8B0", VA = "0x18184E8B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event ILNJNDCGDOB EELAINEGDPK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2250", Offset = "0x6FE1250", VA = "0x186FE2250")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3F60", Offset = "0x6FE2F60", VA = "0x186FE3F60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event JMLNINKIFHA IGFHFJKFGJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6FE1FC0", Offset = "0x6FE0FC0", VA = "0x186FE1FC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3CC0", Offset = "0x6FE2CC0", VA = "0x186FE3CC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event JMLNINKIFHA DDAMOFBGOLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2020", Offset = "0x6FE1020", VA = "0x186FE2020")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3D30", Offset = "0x6FE2D30", VA = "0x186FE3D30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event JMLNINKIFHA KAHCDMPJAFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2170", Offset = "0x6FE1170", VA = "0x186FE2170")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3E80", Offset = "0x6FE2E80", VA = "0x186FE3E80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<OOGOAJCGPNN, OOGOAJCGPNN> JACGAKDPIAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2100", Offset = "0x6FE1100", VA = "0x186FE2100")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3E10", Offset = "0x6FE2E10", VA = "0x186FE3E10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event JMLNINKIFHA LBOCLKKMEOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6FE21E0", Offset = "0x6FE11E0", VA = "0x186FE21E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3EF0", Offset = "0x6FE2EF0", VA = "0x186FE3EF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event JMLNINKIFHA IJJKJJCNNML
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6FE22C0", Offset = "0x6FE12C0", VA = "0x186FE22C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3FD0", Offset = "0x6FE2FD0", VA = "0x186FE3FD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event JMLNINKIFHA IBBFENNFMDH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6FE2090", Offset = "0x6FE1090", VA = "0x186FE2090")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6FE3DA0", Offset = "0x6FE2DA0", VA = "0x186FE3DA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650", Slot = "8")]
		private void ILAFHKPNPIE(DFKFCELAIFJ OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0E10", Offset = "0x6FDFE10", VA = "0x186FE0E10")]
		internal void JMOMPJFPJJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1CE0", Offset = "0x6FE0CE0", VA = "0x186FE1CE0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody KNDCHPBBGMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0940", Offset = "0x6FDF940", VA = "0x186FE0940")]
		public FKKFNKHOOAA GetChild(int HCALFJOJKJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1950", Offset = "0x6FE0950", VA = "0x186FE1950")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) FGEFCHPKOHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6FE04D0", Offset = "0x6FDF4D0", VA = "0x186FE04D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0FB0", Offset = "0x6FDFFB0", VA = "0x186FE0FB0")]
		private DFKFCELAIFJ MPKPMKDNOAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0540", Offset = "0x6FDF540", VA = "0x186FE0540")]
		private void BEDHOPCKIAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1120", Offset = "0x6FE0120", VA = "0x186FE1120")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0E10", Offset = "0x6FDFE10", VA = "0x186FE0E10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE10C0", Offset = "0x6FE00C0", VA = "0x186FE10C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1180", Offset = "0x6FE0180", VA = "0x186FE1180")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6FDFAC0", Offset = "0x6FDEAC0", VA = "0x186FDFAC0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object DJIBMMAIGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6FE11E0", Offset = "0x6FE01E0", VA = "0x186FE11E0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object DJIBMMAIGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6FE08E0", Offset = "0x6FDF8E0", VA = "0x186FE08E0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1060", Offset = "0x6FE0060", VA = "0x186FE1060")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1AB0", Offset = "0x6FE0AB0", VA = "0x186FE1AB0")]
		public void SetParent(RigidbodyEx JJCEIJMGOAB, bool PANBHGCACAL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6FE14F0", Offset = "0x6FE04F0", VA = "0x186FE14F0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0BF0", Offset = "0x6FDFBF0", VA = "0x186FE0BF0")]
		public bool IsRigidbodyAncestor(RigidbodyEx GGGCGCLCNPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0CD0", Offset = "0x6FDFCD0", VA = "0x186FE0CD0")]
		public bool IsRigidbodyDescendant(RigidbodyEx MACLNOOMCKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6FDFD30", Offset = "0x6FDED30", VA = "0x186FDFD30")]
		public void AddInterpolationRestriction(object DJIBMMAIGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1250", Offset = "0x6FE0250", VA = "0x186FE1250")]
		public void RemoveInterpolationRestriction(object DJIBMMAIGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6FDFDA0", Offset = "0x6FDEDA0", VA = "0x186FDFDA0")]
		public void AddKinematic(object DJIBMMAIGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE12C0", Offset = "0x6FE02C0", VA = "0x186FE12C0")]
		public void RemoveKinematic(object DJIBMMAIGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1A30", Offset = "0x6FE0A30", VA = "0x186FE1A30")]
		public void SetKinematic(object DJIBMMAIGPE, bool NMJDAPPHKKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1850", Offset = "0x6FE0850", VA = "0x186FE1850")]
		public void SetDiscontinuousPositionAndRotation(Vector3 OJPBAJPHPBB, Quaternion HCIAOOMDBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1750", Offset = "0x6FE0750", VA = "0x186FE1750")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 COLCOHHOFKK, Quaternion ODBILIAIDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0AE0", Offset = "0x6FDFAE0", VA = "0x186FE0AE0")]
		public Vector3 GetConstrainedVelocity(Vector3 LKAKKODKGLB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6FE09D0", Offset = "0x6FDF9D0", VA = "0x186FE09D0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 IFMDAJCPKED)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6FDFC40", Offset = "0x6FDEC40", VA = "0x186FDFC40")]
		public void AddForce(Vector3 HPJKELEMMFE, ForceMode FEOIDGGLIEB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6FDFB30", Offset = "0x6FDEB30", VA = "0x186FDFB30")]
		public void AddForceAtPosition(Vector3 HPJKELEMMFE, Vector3 LLLHNMGEKPM, ForceMode FEOIDGGLIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6FDFF70", Offset = "0x6FDEF70", VA = "0x186FDFF70")]
		public void AddTorque(Vector3 BGMBOOCPFBE, ForceMode FEOIDGGLIEB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6FDFE10", Offset = "0x6FDEE10", VA = "0x186FDFE10")]
		public void AddRelativeTorque(Vector3 BGMBOOCPFBE, ForceMode FEOIDGGLIEB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1DB0", Offset = "0x6FE0DB0", VA = "0x186FE1DB0")]
		public Vector3 WorldToLocalVelocity(Vector3 NKDCMJAIHCA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0EA0", Offset = "0x6FDFEA0", VA = "0x186FE0EA0")]
		public Vector3 LocalToWorldVelocity(Vector3 CCMFHJLEKOG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0880", Offset = "0x6FDF880", VA = "0x186FE0880")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0820", Offset = "0x6FDF820", VA = "0x186FE0820")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6FE07C0", Offset = "0x6FDF7C0", VA = "0x186FE07C0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0760", Offset = "0x6FDF760", VA = "0x186FE0760")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1650", Offset = "0x6FE0650", VA = "0x186FE1650")]
		public void ResetVelocityWorldSpace(Vector3 KBJBGEBKDGD, Vector3 DGLIDJNFFDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1550", Offset = "0x6FE0550", VA = "0x186FE1550")]
		public void ResetVelocityLocalSpace(Vector3 NIDALEFHFGP, Vector3 AMMNBNBOHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1410", Offset = "0x6FE0410", VA = "0x186FE1410")]
		public void ResetLinearVelocityLocalSpace(Vector3 NIDALEFHFGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1BE0", Offset = "0x6FE0BE0", VA = "0x186FE1BE0")]
		public bool SweepTest(Vector3 DJAIHLPIJBH, [Out] RaycastHit IJJOILIEHOI, float BIJEBEJFKBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0DB0", Offset = "0x6FDFDB0", VA = "0x186FE0DB0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1B80", Offset = "0x6FE0B80", VA = "0x186FE1B80")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1D50", Offset = "0x6FE0D50", VA = "0x186FE1D50")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6FDFF00", Offset = "0x6FDEF00", VA = "0x186FDFF00")]
		public void AddShouldHaveUnityRigidbodyToken(object DJIBMMAIGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1330", Offset = "0x6FE0330", VA = "0x186FE1330")]
		public void RemoveShouldHaveUnityRigidbodyToken(object DJIBMMAIGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0300", Offset = "0x6FDF300", VA = "0x186FE0300")]
		public void ApplyForceVelocityChange(PINDDEBDGAN LJHIOLBCCLM, Vector3 CHJCBNCKLNJ, float PENDKPMEBEM, float IHDHJOHPOID = 8f, float CPJCMINNEPA = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0200", Offset = "0x6FDF200", VA = "0x186FE0200")]
		public void ApplyAngularVelocityChange(IMFKBKBHMKC BPMCIHAHBEP, Vector3 PKAILENOOIF, float HKJPMNKBPCD = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6FE03C0", Offset = "0x6FDF3C0", VA = "0x186FE03C0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(IMFKBKBHMKC BPMCIHAHBEP, Vector3 BCKIPOGEHOJ, float BCBOHKMEOIN = 7f, float CBILEDLNPGP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0130", Offset = "0x6FDF130", VA = "0x186FE0130")]
		public bool AllowedScaleChange(float JOGFACAPCBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0060", Offset = "0x6FDF060", VA = "0x186FE0060")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx ILALMEILOHO, object DJIBMMAIGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6FE13A0", Offset = "0x6FE03A0", VA = "0x186FE13A0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object DJIBMMAIGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1F50", Offset = "0x6FE0F50", VA = "0x186FE1F50")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAB4310", Offset = "0xAB3310", VA = "0x180AB4310", Slot = "4")]
		private GameObject EGPEMOGFNDM()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x87B000", Offset = "0x87A000", VA = "0x18087B000", Slot = "5")]
		private Transform IDGNEEEJJMP()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class KPLDFPPELNC
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCAA0", Offset = "0x6FDBAA0", VA = "0x186FDCAA0")]
	public static DFKFCELAIFJ FOIAGJPPEFL(this RigidbodyEx DFDEBBEGAOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NCOAPLINBMC(typeof(GBMCAGCNMFD), new string[] { })]
public class FECMHILAOPH : GBMCAGCNMFD, IIGBGGHKDKO
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LOGKBMOJLKJ LNEOHCELBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private NLJKDKGFKCJ LCGMLIBOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private OMFCOBGAIAH AMLABONLIGH;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NLJKDKGFKCJ POFCPOIIAOI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public OMFCOBGAIAH DNFDFEAPBDA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FD12F0", Offset = "0x6FD02F0", VA = "0x186FD12F0", Slot = "7")]
	public void InitReferences(APGMJOIFDDC NDICMFPNNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1380", Offset = "0x6FD0380", VA = "0x186FD1380", Slot = "6")]
	public DFKFCELAIFJ NBDDDGBOOFM(RigidbodyEx DFDEBBEGAOA, KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public FECMHILAOPH()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static PEHINEDJEEO UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int GMFIJBCBIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int AAPDIADPCIP;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF920", Offset = "0x6FDE920", VA = "0x186FDF920")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF960", Offset = "0x6FDE960", VA = "0x186FDF960")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF940", Offset = "0x6FDE940", VA = "0x186FDF940")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string KKHEHGHPOAA, [Optional] UnityEngine.Object PDLLDMABKGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string KKHEHGHPOAA, [Optional] UnityEngine.Object PDLLDMABKGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6FDFA70", Offset = "0x6FDEA70", VA = "0x186FDFA70")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class AIMNPFEMNNL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class JPACGDIMPFN : GHKLKADMCLK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x861CF0", Offset = "0x860CF0", VA = "0x180861CF0", Slot = "4")]
		public Vector3 CJFHHLDPLKI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x861CF0", Offset = "0x860CF0", VA = "0x180861CF0", Slot = "5")]
		public Vector3 JJNIEMKEABP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JPACGDIMPFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static GHKLKADMCLK MDKCCJKECMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA5E0", Offset = "0x6FC95E0", VA = "0x186FCA5E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DBLDEGJNGJC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode MKJGANAAIBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HKPMLCIOMID();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FOFNCBJBJJK(bool GPNAEJAOCBA);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCOKMGFLBOO(bool GPNAEJAOCBA);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MCBEHMNHFPL(Rigidbody KHNFKMKPMNG);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BOLPAFLMHKH(Vector3 DJAIHLPIJBH, [Out] RaycastHit IJJOILIEHOI, float BIJEBEJFKBC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GHOHNLBIOEJ : IDisposable, HEJCMDHONJD
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	OIAPKHBMKCC EEMHNCNBDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<OOGOAJCGPNN, OOGOAJCGPNN> JACGAKDPIAP;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKPMLCIOMID();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface OMFCOBGAIAH
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKGCEIFHHMN GCCELBBIGKP(DFKFCELAIFJ OEFGKJLECGH);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IFPIILLFAMG PHFHPNAAJAL(DFKFCELAIFJ OEFGKJLECGH);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BNKEGDFMOIA EFBLAHJGHBD(DFKFCELAIFJ OEFGKJLECGH);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AJEJDLJNOLE ACIADDIFJLI(DFKFCELAIFJ OEFGKJLECGH);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BFGGNDAFJPJ OJHOCBFDIAD(DFKFCELAIFJ OEFGKJLECGH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GHOHNLBIOEJ ELBNDIOAJAI(DFKFCELAIFJ OEFGKJLECGH);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FOAGNFAIEJA MKJABANPILO(DFKFCELAIFJ OEFGKJLECGH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KMCAEKBOLKK LGICGMENPEN(DFKFCELAIFJ OEFGKJLECGH);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DBLDEGJNGJC KDCNHGIJNEN(DFKFCELAIFJ OEFGKJLECGH);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HLLPPLMFENG OMIHANAAOKE(DFKFCELAIFJ OEFGKJLECGH);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AAIAPCIMDND ICFKOBKDOCJ(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DGEDFPLAJKI KMFKHCBKGNO(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PACNDENCNOF LLHODGFMABL(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AEDOMBFKMMB CJHJLDGDFIA(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CBLFLACPMLA ILOHLCDEAAC(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DFKFCELAIFJ NBDDDGBOOFM(RigidbodyEx DFDEBBEGAOA, KFNPMFNDCGH AHGAPHMJDIB, GBMCAGCNMFD HADKCEDAMNP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KMCAEKBOLKK
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPPFCGBENNC(Vector3 HPJKELEMMFE, ForceMode FEOIDGGLIEB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFLICFLBDJG(Vector3 HPJKELEMMFE, Vector3 LLLHNMGEKPM, ForceMode FEOIDGGLIEB);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMPIHOIHHMG(Vector3 BGMBOOCPFBE, ForceMode FEOIDGGLIEB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JLGLLONLHNO(Vector3 BGMBOOCPFBE, ForceMode FEOIDGGLIEB = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HLLPPLMFENG
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool LPOAFHJMOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MCBEHMNHFPL(Rigidbody KHNFKMKPMNG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DAILHFDMBCP(Rigidbody KHNFKMKPMNG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NKGCEIFHHMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<DFKFCELAIFJ> BJIGDHFOKJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	DFKFCELAIFJ KILMHGFMJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	DFKFCELAIFJ EOBHJDGKNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event JMLNINKIFHA IGFHFJKFGJF;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event JMLNINKIFHA DDAMOFBGOLC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event ILNJNDCGDOB COGNAEOHMBE;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action HCLMLIEDFPL;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action MMOCFPGEJOG;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<DFKFCELAIFJ> AHPHOFJCCCP;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<DFKFCELAIFJ> NFEJOPJJJBB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action OBKICNCLENO;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<DFKFCELAIFJ> HCONIEMGGEA;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MLPLIFGNEGJ(DFKFCELAIFJ MECDJMBEHCP, bool PANBHGCACAL = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BNKEGDFMOIA
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 PBFJHAANDHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 NIMMPMMFIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KAOGBFCNPNB(DFKFCELAIFJ EMOKCJBMKOL, object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BAOOJLNFEEC(object DJIBMMAIGPE);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AEDOMBFKMMB
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 IAKOELCOBDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 OBEIAONFNHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float GBGMHHELEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float EJFLHGNKANJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 AAHHOMEFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion MCHGPDENHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event JMLNINKIFHA OFAEKNFHDNE;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IGJDLHBDBKE((Quaternion rot, Vector3 moments) FGEFCHPKOHN);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CGFDKPKFDKM();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DJJBEGFPKFN();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DCMCPIBNEPN();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MCBEHMNHFPL(Rigidbody KHNFKMKPMNG);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DAILHFDMBCP(Rigidbody KHNFKMKPMNG);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MGAKKCHNFAK();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PACNDENCNOF
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKPMLCIOMID();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAHCELNLDAN(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDECIABKNNC(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KIABAJLPADP(DFKFCELAIFJ DFDEBBEGAOA);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OGEJJODIBEN(DFKFCELAIFJ DFDEBBEGAOA);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OFDOCLJGHPK();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FOAGNFAIEJA
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool FECJGCKLHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event JMLNINKIFHA CNAFCFDIHHM;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLNGBDGGJDB(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NMDIMOEGJIM(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GCKPKKDAKDO(object DJIBMMAIGPE, bool NMJDAPPHKKG);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MCBEHMNHFPL(Rigidbody MEADPIPLGKG);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DAILHFDMBCP(Rigidbody KHNFKMKPMNG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DGEDFPLAJKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool LLPBCOPOAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HIGNAPNNMIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event JMLNINKIFHA JLECKOCGJCJ;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKPMLCIOMID();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OMFIJJAJDAO(DFKFCELAIFJ EMOKCJBMKOL);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GFHHPBMEDLF(DFKFCELAIFJ EMOKCJBMKOL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CBLFLACPMLA
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool HBBNKPPIMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool PLKOKHFHLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints ENOOHPAIPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MCBEHMNHFPL(Rigidbody KHNFKMKPMNG);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DAILHFDMBCP(Rigidbody KHNFKMKPMNG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AJEJDLJNOLE
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float IGBCDKAFKFD
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float NCMDNGFEPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MCBEHMNHFPL(Rigidbody KHNFKMKPMNG);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DAILHFDMBCP(Rigidbody KHNFKMKPMNG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BFGGNDAFJPJ
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event JMLNINKIFHA CDLFDNALIHG;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HKPMLCIOMID();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FIMHINPOPMB();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOPCPNOMMNG();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NCGLFOBFHHE();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IFKBGELHDNI();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FKAKBCDENJE();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface AAIAPCIMDND
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody MIEMDJAPKBC
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool LCCAELECGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKPMLCIOMID();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CGAAOOCFJLO(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BEDABBIDNKK(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CNHLLGOJLCE();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IFPIILLFAMG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	GHKLKADMCLK MAOOOBLDOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	JLDEAACPJLG OIKNHNOABJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 BLLHMKAKHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 BPFENOHBMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 HKHJELDKBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 HCOGDBJHCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float LDIJOKADLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool DLGMMAHDEFA
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HKPMLCIOMID();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BAEAPPBKNOE(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MEMDAICICEL(IMFKBKBHMKC BPMCIHAHBEP, Vector3 PKAILENOOIF, float HKJPMNKBPCD = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ELKLHMOPGNC(PINDDEBDGAN LJHIOLBCCLM, Vector3 CHJCBNCKLNJ, float PENDKPMEBEM, float IHDHJOHPOID = 8f, float CPJCMINNEPA = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JNNKCEADNND(IMFKBKBHMKC BPMCIHAHBEP, Vector3 BCKIPOGEHOJ, float BCBOHKMEOIN = 7f, float CBILEDLNPGP = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IBFPMPLPMAI();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CEECMIGGMDF();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JFAINLNIDHF();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BACIIGGFLGE();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MCBEHMNHFPL(Rigidbody KHNFKMKPMNG);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 IGCHDLIAKLN(Vector3 LKAKKODKGLB);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JDAGOFDGDMI(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CLIGPBPPJPB(Vector3 CGJNBPCMBLF);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JPHIHPPKNEJ(Vector3 NIDALEFHFGP, Vector3 AMMNBNBOHHD);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void ENBDCHCJMNC(Vector3 KBJBGEBKDGD, Vector3 DGLIDJNFFDG);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 MMAAAIDDKKN(Vector3 CCMFHJLEKOG);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 KEKMJGLJNJP(Vector3 NKDCMJAIHCA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface NLJKDKGFKCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool CKHAKNIFJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOFDACBANBB(string EHELKEOJPOO);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDHKIHNPFBE(RigidbodyEx DFDEBBEGAOA, Action JFOAFIPDIOA);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MMAMIIEJECJ HKJDNJHOLFN(int IONGNHDJAJE);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LFFNKOAOKAD(Vector3 FMEBEEBLELG, float NEJKEAEAJJP, Color NHCEIDKGILJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface GBMCAGCNMFD
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	NLJKDKGFKCJ POFCPOIIAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	OMFCOBGAIAH DNFDFEAPBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DFKFCELAIFJ NBDDDGBOOFM(RigidbodyEx DFDEBBEGAOA, KFNPMFNDCGH AHGAPHMJDIB);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class INPEPHPGFEC : DFKFCELAIFJ, IDisposable, GGNJCIKMKJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly GBMCAGCNMFD HADKCEDAMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal NKGCEIFHHMN DAEHHHGOBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal PACNDENCNOF ILFKGNIODNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal DGEDFPLAJKI ANHAGJCBJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal IFPIILLFAMG LKAKKODKGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal BNKEGDFMOIA CJJLMODFOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal AEDOMBFKMMB HCHDKACFEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal AJEJDLJNOLE PAHIMEAPGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal HLLPPLMFENG PFMHBAFPBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal BFGGNDAFJPJ FCLPGFMFMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal GHOHNLBIOEJ DGLLFEHAMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal FOAGNFAIEJA EDNHNHLFKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal KMCAEKBOLKK HPJKELEMMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal CBLFLACPMLA ELDCNJCIKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal AAIAPCIMDND KHNFKMKPMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal DBLDEGJNGJC FNMPFKKDCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable PLKIPHNFMAM;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "22")]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public FKKFNKHOOAA INAHDPOKPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x85FBD0", Offset = "0x85EBD0", VA = "0x18085FBD0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x85FBE0", Offset = "0x85EBE0", VA = "0x18085FBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject AKFNNOMHACD
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xB266F0", Offset = "0xB256F0", VA = "0x180B266F0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xABCA80", Offset = "0xABBA80", VA = "0x180ABCA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform EALAKNFEFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x85D2D0", Offset = "0x85C2D0", VA = "0x18085D2D0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x85D330", Offset = "0x85C330", VA = "0x18085D330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody MIEMDJAPKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA260", Offset = "0x6FD9260", VA = "0x186FDA260", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public DFKFCELAIFJ EOBHJDGKNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5E30", Offset = "0x6FD4E30", VA = "0x186FD5E30", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6FDBBD0", Offset = "0x6FDABD0", VA = "0x186FDBBD0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int OJEOKFFHDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8730", Offset = "0x6FD7730", VA = "0x186FD8730", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public DFKFCELAIFJ KILMHGFMJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6FD65B0", Offset = "0x6FD55B0", VA = "0x186FD65B0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool OHHGFHHHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA0A0", Offset = "0x6FD90A0", VA = "0x186FDA0A0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool LLPBCOPOAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9E20", Offset = "0x6FD8E20", VA = "0x186FD9E20", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool HIGNAPNNMIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6FD72B0", Offset = "0x6FD62B0", VA = "0x186FD72B0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public GHKLKADMCLK MAOOOBLDOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6FD78B0", Offset = "0x6FD68B0", VA = "0x186FD78B0", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD71F0", Offset = "0x6FD61F0", VA = "0x186FD71F0", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public JLDEAACPJLG OIKNHNOABJE
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8850", Offset = "0x6FD7850", VA = "0x186FD8850", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9090", Offset = "0x6FD8090", VA = "0x186FD9090", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float LDIJOKADLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9A30", Offset = "0x6FD8A30", VA = "0x186FD9A30", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD86D0", Offset = "0x6FD76D0", VA = "0x186FD86D0", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 BPFENOHBMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6F30", Offset = "0x6FD5F30", VA = "0x186FD6F30", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7350", Offset = "0x6FD6350", VA = "0x186FD7350", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 HCOGDBJHCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9320", Offset = "0x6FD8320", VA = "0x186FD9320", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA410", Offset = "0x6FD9410", VA = "0x186FDA410", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 BLLHMKAKHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9850", Offset = "0x6FD8850", VA = "0x186FD9850", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA6A0", Offset = "0x6FD96A0", VA = "0x186FDA6A0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 HKHJELDKBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6670", Offset = "0x6FD5670", VA = "0x186FD6670", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6750", Offset = "0x6FD5750", VA = "0x186FD6750", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool PNBMHBCLLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5F80", Offset = "0x6FD4F80", VA = "0x186FD5F80", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool MKCIOKCMEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9F90", Offset = "0x6FD8F90", VA = "0x186FD9F90", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool IFCCNAKJLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6FD75B0", Offset = "0x6FD65B0", VA = "0x186FD75B0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool DLGMMAHDEFA
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD90F0", Offset = "0x6FD80F0", VA = "0x186FD90F0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 PBFJHAANDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6150", Offset = "0x6FD5150", VA = "0x186FD6150", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 NIMMPMMFIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD82D0", Offset = "0x6FD72D0", VA = "0x186FD82D0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 IAKOELCOBDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FDAF40", Offset = "0x6FD9F40", VA = "0x186FDAF40", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8D60", Offset = "0x6FD7D60", VA = "0x186FD8D60", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 OBEIAONFNHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7B90", Offset = "0x6FD6B90", VA = "0x186FD7B90", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float GBGMHHELEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6EE0", Offset = "0x6FD5EE0", VA = "0x186FD6EE0", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float EJFLHGNKANJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8B70", Offset = "0x6FD7B70", VA = "0x186FD8B70", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8400", Offset = "0x6FD7400", VA = "0x186FD8400", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 AAHHOMEFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8590", Offset = "0x6FD7590", VA = "0x186FD8590", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion MCHGPDENHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7490", Offset = "0x6FD6490", VA = "0x186FD7490", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float IGBCDKAFKFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FD71A0", Offset = "0x6FD61A0", VA = "0x186FD71A0", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8670", Offset = "0x6FD7670", VA = "0x186FD8670", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float NCMDNGFEPNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6510", Offset = "0x6FD5510", VA = "0x186FD6510", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA840", Offset = "0x6FD9840", VA = "0x186FDA840", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool LPOAFHJMOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9BE0", Offset = "0x6FD8BE0", VA = "0x186FD9BE0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FD94B0", Offset = "0x6FD84B0", VA = "0x186FD94B0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public OIAPKHBMKCC EEMHNCNBDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7560", Offset = "0x6FD6560", VA = "0x186FD7560", Slot = "68")]
		get
		{
			return default(OIAPKHBMKCC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FD68B0", Offset = "0x6FD58B0", VA = "0x186FD68B0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool FECJGCKLHED
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB470", Offset = "0x6FDA470", VA = "0x186FDB470", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform LAPFKIMJCIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x85D2D0", Offset = "0x85C2D0", VA = "0x18085D2D0", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 DCAOJBAHOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9FF0", Offset = "0x6FD8FF0", VA = "0x186FD9FF0", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9EE0", Offset = "0x6FD8EE0", VA = "0x186FD9EE0", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float MAMICFLBBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB800", Offset = "0x6FDA800", VA = "0x186FDB800", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9E70", Offset = "0x6FD8E70", VA = "0x186FD9E70", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float IMINBOBANMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7F00", Offset = "0x6FD6F00", VA = "0x186FD7F00", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7E20", Offset = "0x6FD6E20", VA = "0x186FD7E20", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion FLFGHMPBLPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7740", Offset = "0x6FD6740", VA = "0x186FD7740", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB390", Offset = "0x6FDA390", VA = "0x186FDB390", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 OFOBIKFANPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8810", Offset = "0x6FD7810", VA = "0x186FD8810", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA4F0", Offset = "0x6FD94F0", VA = "0x186FDA4F0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion IMOOEMJKGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7960", Offset = "0x6FD6960", VA = "0x186FD7960", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB4C0", Offset = "0x6FDA4C0", VA = "0x186FDB4C0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints ENOOHPAIPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6FD79A0", Offset = "0x6FD69A0", VA = "0x186FD79A0", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8530", Offset = "0x6FD7530", VA = "0x186FD8530", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool HBBNKPPIMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA2B0", Offset = "0x6FD92B0", VA = "0x186FDA2B0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9400", Offset = "0x6FD8400", VA = "0x186FD9400", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode MKJGANAAIBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9AE0", Offset = "0x6FD8AE0", VA = "0x186FD9AE0", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9A80", Offset = "0x6FD8A80", VA = "0x186FD9A80", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool DHBNIHIBKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8C20", Offset = "0x6FD7C20", VA = "0x186FD8C20", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool LNEJAIMOMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5FD0", Offset = "0x6FD4FD0", VA = "0x186FD5FD0", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event JMLNINKIFHA IGFHFJKFGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7250", Offset = "0x6FD6250", VA = "0x186FD7250", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA100", Offset = "0x6FD9100", VA = "0x186FDA100", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event JMLNINKIFHA DDAMOFBGOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6FDAAC0", Offset = "0x6FD9AC0", VA = "0x186FDAAC0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5DD0", Offset = "0x6FD4DD0", VA = "0x186FD5DD0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event ILNJNDCGDOB COGNAEOHMBE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA780", Offset = "0x6FD9780", VA = "0x186FDA780", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA7E0", Offset = "0x6FD97E0", VA = "0x186FDA7E0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event JMLNINKIFHA JLECKOCGJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6FD79F0", Offset = "0x6FD69F0", VA = "0x186FD79F0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7430", Offset = "0x6FD6430", VA = "0x186FD7430", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event JMLNINKIFHA KAHCDMPJAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA9B0", Offset = "0x6FD99B0", VA = "0x186FDA9B0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9510", Offset = "0x6FD8510", VA = "0x186FD9510", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event JMLNINKIFHA CDLFDNALIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8FE0", Offset = "0x6FD7FE0", VA = "0x186FD8FE0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7900", Offset = "0x6FD6900", VA = "0x186FD7900", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<OOGOAJCGPNN, OOGOAJCGPNN> JACGAKDPIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FD76E0", Offset = "0x6FD66E0", VA = "0x186FD76E0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FDAA60", Offset = "0x6FD9A60", VA = "0x186FDAA60", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event JMLNINKIFHA CNAFCFDIHHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB7A0", Offset = "0x6FDA7A0", VA = "0x186FDB7A0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6220", Offset = "0x6FD5220", VA = "0x186FD6220", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event JMLNINKIFHA IBBFENNFMDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6460", Offset = "0x6FD5460", VA = "0x186FD6460", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA900", Offset = "0x6FD9900", VA = "0x186FDA900", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6FDBD30", Offset = "0x6FDAD30", VA = "0x186FDBD30")]
	public INPEPHPGFEC(GameObject IDHOMJBMFPB, RigidbodyEx PNEIHPCJIKN, GBMCAGCNMFD HADKCEDAMNP, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6FDABF0", Offset = "0x6FD9BF0", VA = "0x186FDABF0", Slot = "136")]
	protected virtual void NHEJLGKJMHE(GBMCAGCNMFD HADKCEDAMNP, KFNPMFNDCGH AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6FD77E0", Offset = "0x6FD67E0", VA = "0x186FD77E0", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8E40", Offset = "0x6FD7E40", VA = "0x186FD8E40", Slot = "91")]
	public void HKPMLCIOMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6560", Offset = "0x6FD5560", VA = "0x186FD6560", Slot = "92")]
	public void DDONIAFOEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6890", Offset = "0x6FD5890", VA = "0x186FD6890", Slot = "93")]
	public void BHBBAJEBOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8460", Offset = "0x6FD7460", VA = "0x186FD8460")]
	private void FKADPNLKBOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB4F0", Offset = "0x6FDA4F0", VA = "0x186FDB4F0", Slot = "30")]
	public DFKFCELAIFJ OLACCODENNC(int HCALFJOJKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6FDA530", Offset = "0x6FD9530", VA = "0x186FDA530", Slot = "95")]
	public void MLPLIFGNEGJ(DFKFCELAIFJ JJCEIJMGOAB, bool PANBHGCACAL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8F80", Offset = "0x6FD7F80", VA = "0x186FD8F80", Slot = "96")]
	public void HLNALJAOEID(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6FDA8A0", Offset = "0x6FD98A0", VA = "0x186FDA8A0", Slot = "97")]
	public void MPCACKOBFFM(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9930", Offset = "0x6FD8930", VA = "0x186FD9930", Slot = "98")]
	public Vector3 KEKMJGLJNJP(Vector3 NKDCMJAIHCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6FDA5A0", Offset = "0x6FD95A0", VA = "0x186FDA5A0", Slot = "99")]
	public Vector3 MMAAAIDDKKN(Vector3 CCMFHJLEKOG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6560", Offset = "0x6FD5560", VA = "0x186FD6560", Slot = "100")]
	public void BACIIGGFLGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6E90", Offset = "0x6FD5E90", VA = "0x186FD6E90", Slot = "101")]
	public void CEECMIGGMDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9040", Offset = "0x6FD8040", VA = "0x186FD9040", Slot = "102")]
	public void IBFPMPLPMAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7D30", Offset = "0x6FD6D30", VA = "0x186FD7D30", Slot = "103")]
	public void ENBDCHCJMNC(Vector3 KBJBGEBKDGD, Vector3 DGLIDJNFFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9760", Offset = "0x6FD8760", VA = "0x186FD9760", Slot = "104")]
	public void JPHIHPPKNEJ(Vector3 NIDALEFHFGP, Vector3 AMMNBNBOHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6FD70C0", Offset = "0x6FD60C0", VA = "0x186FD70C0", Slot = "105")]
	public void CLIGPBPPJPB(Vector3 CGJNBPCMBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7C70", Offset = "0x6FD6C70", VA = "0x186FD7C70", Slot = "106")]
	public void ELKLHMOPGNC(PINDDEBDGAN LJHIOLBCCLM, Vector3 CHJCBNCKLNJ, float PENDKPMEBEM, float IHDHJOHPOID = 8f, float CPJCMINNEPA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6FDA160", Offset = "0x6FD9160", VA = "0x186FDA160", Slot = "107")]
	public void MEMDAICICEL(IMFKBKBHMKC BPMCIHAHBEP, Vector3 PKAILENOOIF, float HKJPMNKBPCD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9650", Offset = "0x6FD8650", VA = "0x186FD9650", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JNNKCEADNND(IMFKBKBHMKC BPMCIHAHBEP, Vector3 BCKIPOGEHOJ, float BCBOHKMEOIN = 7f, float CBILEDLNPGP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9140", Offset = "0x6FD8140", VA = "0x186FD9140", Slot = "109")]
	public Vector3 IGCHDLIAKLN(Vector3 JJCEIJMGOAB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5E80", Offset = "0x6FD4E80", VA = "0x186FD5E80", Slot = "110")]
	public Vector3 AEEMBIJBBMG(Vector3 JJCEIJMGOAB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9460", Offset = "0x6FD8460", VA = "0x186FD9460", Slot = "111")]
	public void JFAINLNIDHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6600", Offset = "0x6FD5600", VA = "0x186FD6600", Slot = "112")]
	public void BCIPOJDCHAJ(DFKFCELAIFJ ILALMEILOHO, object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6FDA350", Offset = "0x6FD9350", VA = "0x186FDA350", Slot = "113")]
	public void MJDECCJNCCG(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9240", Offset = "0x6FD8240", VA = "0x186FD9240", Slot = "61")]
	public void IGJDLHBDBKE((Quaternion rot, Vector3 moments) FGEFCHPKOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7690", Offset = "0x6FD6690", VA = "0x186FD7690", Slot = "114")]
	public void DJJBEGFPKFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7070", Offset = "0x6FD6070", VA = "0x186FD7070", Slot = "115")]
	public void CGFDKPKFDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7300", Offset = "0x6FD6300", VA = "0x186FD7300", Slot = "116")]
	public void DCMCPIBNEPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6FD83B0", Offset = "0x6FD73B0", VA = "0x186FD83B0", Slot = "117")]
	public bool FIMHINPOPMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6FDAA10", Offset = "0x6FD9A10", VA = "0x186FDAA10", Slot = "94")]
	public void NCGLFOBFHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6FD84E0", Offset = "0x6FD74E0", VA = "0x186FD84E0", Slot = "118")]
	public void FKAKBCDENJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6A10", Offset = "0x6FD5A10", VA = "0x186FD6A10", Slot = "119")]
	public void BLNGBDGGJDB(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FDAEE0", Offset = "0x6FD9EE0", VA = "0x186FDAEE0", Slot = "120")]
	public void NMDIMOEGJIM(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6FD87A0", Offset = "0x6FD77A0", VA = "0x186FD87A0", Slot = "121")]
	public void GCKPKKDAKDO(object DJIBMMAIGPE, bool NMJDAPPHKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8970", Offset = "0x6FD7970", VA = "0x186FD8970", Slot = "122")]
	public void GGIJNBBCPOA(Vector3 OJPBAJPHPBB, Quaternion HCIAOOMDBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7A50", Offset = "0x6FD6A50", VA = "0x186FD7A50", Slot = "123")]
	public void EJFMOCIPCID(Vector3 COLCOHHOFKK, Quaternion ODBILIAIDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6FDBB80", Offset = "0x6FDAB80", VA = "0x186FDBB80", Slot = "124")]
	public bool PCOLKMDAJHA(float JOGFACAPCBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FDA3B0", Offset = "0x6FD93B0", VA = "0x186FDA3B0", Slot = "125")]
	public void MJELHKNAIJI(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8BC0", Offset = "0x6FD7BC0", VA = "0x186FD8BC0", Slot = "126")]
	public void HDDPGLGIPOI(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7010", Offset = "0x6FD6010", VA = "0x186FD7010", Slot = "127")]
	public void CGAAOOCFJLO(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6830", Offset = "0x6FD5830", VA = "0x186FD6830", Slot = "128")]
	public void BEDABBIDNKK(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB020", Offset = "0x6FDA020", VA = "0x186FDB020", Slot = "129")]
	public void NPPFCGBENNC(Vector3 HPJKELEMMFE, ForceMode FEOIDGGLIEB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB280", Offset = "0x6FDA280", VA = "0x186FDB280", Slot = "130")]
	public void OFLICFLBDJG(Vector3 HPJKELEMMFE, Vector3 LLLHNMGEKPM, ForceMode FEOIDGGLIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9C30", Offset = "0x6FD8C30", VA = "0x186FD9C30", Slot = "131")]
	public void KMPIHOIHHMG(Vector3 BGMBOOCPFBE, ForceMode FEOIDGGLIEB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9570", Offset = "0x6FD8570", VA = "0x186FD9570", Slot = "132")]
	public void JLGLLONLHNO(Vector3 BGMBOOCPFBE, ForceMode FEOIDGGLIEB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6A70", Offset = "0x6FD5A70", VA = "0x186FD6A70", Slot = "133")]
	public bool BOLPAFLMHKH(Vector3 DJAIHLPIJBH, [Out] RaycastHit IJJOILIEHOI, float BIJEBEJFKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FDA300", Offset = "0x6FD9300", VA = "0x186FDA300", Slot = "134")]
	public void MGAKKCHNFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FDBCF0", Offset = "0x6FDACF0", VA = "0x186FDBCF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FDAB20", Offset = "0x6FD9B20", VA = "0x186FDAB20")]
	private void NFDJNCDEPAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9D10", Offset = "0x6FD8D10", VA = "0x186FD9D10")]
	private void KPBCNOMNJKN(DFKFCELAIFJ EMOKCJBMKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6280", Offset = "0x6FD5280", VA = "0x186FD6280")]
	private void AJAAGIDAMJJ(DFKFCELAIFJ EMOKCJBMKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9B30", Offset = "0x6FD8B30", VA = "0x186FD9B30")]
	private void KJMMOJPBOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6910", Offset = "0x6FD5910", VA = "0x186FD6910")]
	private void BJOELAKMBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB100", Offset = "0x6FDA100", VA = "0x186FDB100")]
	private void OENNKHMLGAH(DFKFCELAIFJ NHBKNIAECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB6D0", Offset = "0x6FDA6D0", VA = "0x186FDB6D0")]
	private void OMFIJJAJDAO(DFKFCELAIFJ EMOKCJBMKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6FD88A0", Offset = "0x6FD78A0", VA = "0x186FD88A0")]
	private void GFHHPBMEDLF(DFKFCELAIFJ EMOKCJBMKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB570", Offset = "0x6FDA570", VA = "0x186FDB570")]
	private void OLNMOPABDLL(FKKFNKHOOAA EMOKCJBMKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7F10", Offset = "0x6FD6F10", VA = "0x186FD7F10", Slot = "141")]
	protected virtual void FBFBALIFNIE(FKKFNKHOOAA DFDEBBEGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6B70", Offset = "0x6FD5B70", VA = "0x186FD6B70")]
	protected void CAKENCMMBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB810", Offset = "0x6FDA810", VA = "0x186FDB810")]
	protected void PCEIIIAKJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6FDBC30", Offset = "0x6FDAC30", VA = "0x186FDBC30", Slot = "142")]
	protected virtual IDisposable PJBPKKELFMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class BGIPKILDHEL
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA780", Offset = "0x6FC9780", VA = "0x186FCA780")]
	public static DFKFCELAIFJ KEMHOIPHKFB(this DFKFCELAIFJ DFDEBBEGAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA6B0", Offset = "0x6FC96B0", VA = "0x186FCA6B0")]
	public static bool BHALIDOBBMM(this DFKFCELAIFJ DFDEBBEGAOA, DFKFCELAIFJ GGGCGCLCNPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA840", Offset = "0x6FC9840", VA = "0x186FCA840")]
	public static bool KJPDCCMIOFK(this DFKFCELAIFJ DFDEBBEGAOA, DFKFCELAIFJ MACLNOOMCKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA730", Offset = "0x6FC9730", VA = "0x186FCA730")]
	public static FKKFNKHOOAA ECDJJGFPFFK(this DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA8C0", Offset = "0x6FC98C0", VA = "0x186FCA8C0")]
	public static INPEPHPGFEC MMCJJCGEDIM(this DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LCKNPKFOLPM : OMFCOBGAIAH
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCB10", Offset = "0x6FDBB10", VA = "0x186FDCB10", Slot = "19")]
	public DFKFCELAIFJ NBDDDGBOOFM(RigidbodyEx DFDEBBEGAOA, KFNPMFNDCGH AHGAPHMJDIB, GBMCAGCNMFD HADKCEDAMNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "4")]
	public NKGCEIFHHMN GCCELBBIGKP(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "5")]
	public IFPIILLFAMG PHFHPNAAJAL(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "6")]
	public BNKEGDFMOIA EFBLAHJGHBD(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "7")]
	public AJEJDLJNOLE ACIADDIFJLI(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "8")]
	public BFGGNDAFJPJ OJHOCBFDIAD(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "9")]
	public GHOHNLBIOEJ ELBNDIOAJAI(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "10")]
	public FOAGNFAIEJA MKJABANPILO(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "11")]
	public KMCAEKBOLKK LGICGMENPEN(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "12")]
	public DBLDEGJNGJC KDCNHGIJNEN(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "13")]
	public HLLPPLMFENG OMIHANAAOKE(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960")]
	public AAIAPCIMDND ICFKOBKDOCJ(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960")]
	public DGEDFPLAJKI KMFKHCBKGNO(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960")]
	public PACNDENCNOF LLHODGFMABL(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960")]
	public AEDOMBFKMMB CJHJLDGDFIA(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960")]
	public CBLFLACPMLA ILOHLCDEAAC(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public LCKNPKFOLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "14")]
	private AAIAPCIMDND KMBJONBGKOL(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "15")]
	private DGEDFPLAJKI MANDKCCLKLC(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "16")]
	private PACNDENCNOF MIFFKCCKFGP(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "17")]
	private AEDOMBFKMMB OMHNHNELGCE(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "18")]
	private CBLFLACPMLA EKMDLAKKKOJ(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[NCOAPLINBMC(typeof(OMFCOBGAIAH), new string[] { })]
public class PCFALGFNNHG : OMFCOBGAIAH, IIGBGGHKDKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly OMFCOBGAIAH DJHGIFDPPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly OMFCOBGAIAH MNPAGBNGECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private LOGKBMOJLKJ LNEOHCELBPF;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private OMFCOBGAIAH DNFDFEAPBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6FDEAF0", Offset = "0x6FDDAF0", VA = "0x186FDEAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEC00", Offset = "0x6FDDC00", VA = "0x186FDEC00", Slot = "20")]
	public void InitReferences(APGMJOIFDDC NDICMFPNNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEA50", Offset = "0x6FDDA50", VA = "0x186FDEA50", Slot = "4")]
	public NKGCEIFHHMN GCCELBBIGKP(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF220", Offset = "0x6FDE220", VA = "0x186FDF220", Slot = "5")]
	public IFPIILLFAMG PHFHPNAAJAL(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE860", Offset = "0x6FDD860", VA = "0x186FDE860", Slot = "6")]
	public BNKEGDFMOIA EFBLAHJGHBD(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE710", Offset = "0x6FDD710", VA = "0x186FDE710", Slot = "7")]
	public AJEJDLJNOLE ACIADDIFJLI(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF0E0", Offset = "0x6FDE0E0", VA = "0x186FDF0E0", Slot = "8")]
	public BFGGNDAFJPJ OJHOCBFDIAD(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE9B0", Offset = "0x6FDD9B0", VA = "0x186FDE9B0", Slot = "9")]
	public GHOHNLBIOEJ ELBNDIOAJAI(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEEF0", Offset = "0x6FDDEF0", VA = "0x186FDEEF0", Slot = "10")]
	public FOAGNFAIEJA MKJABANPILO(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEDA0", Offset = "0x6FDDDA0", VA = "0x186FDEDA0", Slot = "11")]
	public KMCAEKBOLKK LGICGMENPEN(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEC50", Offset = "0x6FDDC50", VA = "0x186FDEC50", Slot = "12")]
	public DBLDEGJNGJC KDCNHGIJNEN(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF180", Offset = "0x6FDE180", VA = "0x186FDF180", Slot = "13")]
	public HLLPPLMFENG OMIHANAAOKE(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEB50", Offset = "0x6FDDB50", VA = "0x186FDEB50")]
	public AAIAPCIMDND ICFKOBKDOCJ(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6FDECF0", Offset = "0x6FDDCF0", VA = "0x186FDECF0")]
	public DGEDFPLAJKI KMFKHCBKGNO(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEE40", Offset = "0x6FDDE40", VA = "0x186FDEE40")]
	public PACNDENCNOF LLHODGFMABL(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE7B0", Offset = "0x6FDD7B0", VA = "0x186FDE7B0")]
	public AEDOMBFKMMB CJHJLDGDFIA(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE900", Offset = "0x6FDD900", VA = "0x186FDE900")]
	public CBLFLACPMLA ILOHLCDEAAC(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEF90", Offset = "0x6FDDF90", VA = "0x186FDEF90", Slot = "19")]
	public DFKFCELAIFJ NBDDDGBOOFM(RigidbodyEx DFDEBBEGAOA, KFNPMFNDCGH AHGAPHMJDIB, GBMCAGCNMFD HADKCEDAMNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF2C0", Offset = "0x6FDE2C0", VA = "0x186FDF2C0")]
	public PCFALGFNNHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEB50", Offset = "0x6FDDB50", VA = "0x186FDEB50", Slot = "14")]
	private AAIAPCIMDND KMBJONBGKOL(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6FDECF0", Offset = "0x6FDDCF0", VA = "0x186FDECF0", Slot = "15")]
	private DGEDFPLAJKI MANDKCCLKLC(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEE40", Offset = "0x6FDDE40", VA = "0x186FDEE40", Slot = "16")]
	private PACNDENCNOF MIFFKCCKFGP(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE7B0", Offset = "0x6FDD7B0", VA = "0x186FDE7B0", Slot = "17")]
	private AEDOMBFKMMB OMHNHNELGCE(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE900", Offset = "0x6FDD900", VA = "0x186FDE900", Slot = "18")]
	private CBLFLACPMLA EKMDLAKKKOJ(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface DHBDDLNFFKD : NKGCEIFHHMN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MOFEODPEIPI(DFKFCELAIFJ DFDEBBEGAOA);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JMPGGDOEONM(DFKFCELAIFJ DFDEBBEGAOA);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPINKIAMIAF(DFKFCELAIFJ NHBKNIAECDE);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBCACFMKOMH(DFKFCELAIFJ NHBKNIAECDE);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MPOJMMHFLJO : BNKEGDFMOIA
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	LNHMKNJPHJE<DFKFCELAIFJ> IGKFDGICGHA
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	DFKFCELAIFJ KKEFHAHBNID
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface ANIKOLLGOOI : AEDOMBFKMMB
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) EDNIKJIIDFJ(Rigidbody OCNJPCIDJKA);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BCNDKIEACPI : DGEDFPLAJKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView MEHJDNJAJPG
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class PPAMEKHAAJD : DBLDEGJNGJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly INPEPHPGFEC DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private CollisionDetectionMode KOAEJJFJEFN;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody MIEMDJAPKBC
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA0D0", Offset = "0x6FC90D0", VA = "0x186FCA0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode MKJGANAAIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF790", Offset = "0x6FDE790", VA = "0x186FDF790", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF720", Offset = "0x6FDE720", VA = "0x186FDF720", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA550", Offset = "0x6FC9550", VA = "0x186FCA550")]
	public PPAMEKHAAJD(DFKFCELAIFJ DFDEBBEGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF4F0", Offset = "0x6FDE4F0", VA = "0x186FDF4F0", Slot = "6")]
	public void HKPMLCIOMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF8A0", Offset = "0x6FDE8A0", VA = "0x186FDF8A0", Slot = "9")]
	public void MCBEHMNHFPL(Rigidbody KHNFKMKPMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF4D0", Offset = "0x6FDE4D0", VA = "0x186FDF4D0", Slot = "7")]
	public void FOFNCBJBJJK(bool GPNAEJAOCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF4E0", Offset = "0x6FDE4E0", VA = "0x186FDF4E0", Slot = "8")]
	public void HCOKMGFLBOO(bool GPNAEJAOCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF370", Offset = "0x6FDE370", VA = "0x186FDF370", Slot = "10")]
	public bool BOLPAFLMHKH(Vector3 DJAIHLPIJBH, [Out] RaycastHit IJJOILIEHOI, float BIJEBEJFKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF600", Offset = "0x6FDE600", VA = "0x186FDF600")]
	private void JJHMMMCBFAL(bool GPNAEJAOCBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FJHDIMFDMMO : GHOHNLBIOEJ, IDisposable, HEJCMDHONJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly INPEPHPGFEC DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private OIAPKHBMKCC EOMCJKMMCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private MMAMIIEJECJ EILCBBCKPFJ;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public OIAPKHBMKCC EEMHNCNBDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1EC0", Offset = "0x6FD0EC0", VA = "0x186FD1EC0", Slot = "6")]
		get
		{
			return default(OIAPKHBMKCC);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1DF0", Offset = "0x6FD0DF0", VA = "0x186FD1DF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform MODCKNPIJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1DD0", Offset = "0x6FD0DD0", VA = "0x186FD1DD0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<OOGOAJCGPNN, OOGOAJCGPNN> JACGAKDPIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2000", Offset = "0x6FD1000", VA = "0x186FD2000", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2370", Offset = "0x6FD1370", VA = "0x186FD2370", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2420", Offset = "0x6FD1420", VA = "0x186FD2420")]
	public FJHDIMFDMMO(DFKFCELAIFJ DFDEBBEGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2100", Offset = "0x6FD1100", VA = "0x186FD2100", Slot = "8")]
	public void HKPMLCIOMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6FD20B0", Offset = "0x6FD10B0", VA = "0x186FD20B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0xA51850", Offset = "0xA50850", VA = "0x180A51850", Slot = "11")]
	private void GEDNAODBDCE(OOGOAJCGPNN AADNFIHEBGF, OOGOAJCGPNN GEBBLEELDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "12")]
	private void CCIONHHCNGJ(bool OJHGBAANJLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class COEGMHNODJP : OMFCOBGAIAH
{
	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE390", Offset = "0x6FCD390", VA = "0x186FCE390", Slot = "4")]
	public NKGCEIFHHMN GCCELBBIGKP(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6FCEE00", Offset = "0x6FCDE00", VA = "0x186FCEE00", Slot = "5")]
	public IFPIILLFAMG PHFHPNAAJAL(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE0B0", Offset = "0x6FCD0B0", VA = "0x186FCE0B0", Slot = "6")]
	public BNKEGDFMOIA EFBLAHJGHBD(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDEA0", Offset = "0x6FCCEA0", VA = "0x186FCDEA0", Slot = "7")]
	public AJEJDLJNOLE ACIADDIFJLI(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6FCEC70", Offset = "0x6FCDC70", VA = "0x186FCEC70", Slot = "8")]
	public BFGGNDAFJPJ OJHOCBFDIAD(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE2C0", Offset = "0x6FCD2C0", VA = "0x186FCE2C0", Slot = "9")]
	public GHOHNLBIOEJ ELBNDIOAJAI(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6FCEA00", Offset = "0x6FCDA00", VA = "0x186FCEA00", Slot = "10")]
	public FOAGNFAIEJA MKJABANPILO(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE810", Offset = "0x6FCD810", VA = "0x186FCE810", Slot = "11")]
	public KMCAEKBOLKK LGICGMENPEN(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE5C0", Offset = "0x6FCD5C0", VA = "0x186FCE5C0", Slot = "12")]
	public DBLDEGJNGJC KDCNHGIJNEN(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6FCED40", Offset = "0x6FCDD40", VA = "0x186FCED40", Slot = "13")]
	public HLLPPLMFENG OMIHANAAOKE(DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE480", Offset = "0x6FCD480", VA = "0x186FCE480")]
	public AAIAPCIMDND ICFKOBKDOCJ(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE680", Offset = "0x6FCD680", VA = "0x186FCE680")]
	public DGEDFPLAJKI KMFKHCBKGNO(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE8D0", Offset = "0x6FCD8D0", VA = "0x186FCE8D0")]
	public PACNDENCNOF LLHODGFMABL(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDF20", Offset = "0x6FCCF20", VA = "0x186FCDF20")]
	public AEDOMBFKMMB CJHJLDGDFIA(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE1E0", Offset = "0x6FCD1E0", VA = "0x186FCE1E0")]
	public CBLFLACPMLA ILOHLCDEAAC(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6FCEB20", Offset = "0x6FCDB20", VA = "0x186FCEB20", Slot = "19")]
	public DFKFCELAIFJ NBDDDGBOOFM(RigidbodyEx DFDEBBEGAOA, KFNPMFNDCGH AHGAPHMJDIB, GBMCAGCNMFD HADKCEDAMNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public COEGMHNODJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE480", Offset = "0x6FCD480", VA = "0x186FCE480", Slot = "14")]
	private AAIAPCIMDND KMBJONBGKOL(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE680", Offset = "0x6FCD680", VA = "0x186FCE680", Slot = "15")]
	private DGEDFPLAJKI MANDKCCLKLC(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE8D0", Offset = "0x6FCD8D0", VA = "0x186FCE8D0", Slot = "16")]
	private PACNDENCNOF MIFFKCCKFGP(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDF20", Offset = "0x6FCCF20", VA = "0x186FCDF20", Slot = "17")]
	private AEDOMBFKMMB OMHNHNELGCE(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE1E0", Offset = "0x6FCD1E0", VA = "0x186FCE1E0", Slot = "18")]
	private CBLFLACPMLA EKMDLAKKKOJ(DFKFCELAIFJ OEFGKJLECGH, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class AICGHGNEBEE : KMCAEKBOLKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly INPEPHPGFEC DFDEBBEGAOA;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody MIEMDJAPKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA0D0", Offset = "0x6FC90D0", VA = "0x186FCA0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool FECJGCKLHED
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA500", Offset = "0x6FC9500", VA = "0x186FCA500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool OHHGFHHHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA070", Offset = "0x6FC9070", VA = "0x186FCA070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private DFKFCELAIFJ EOBHJDGKNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9790", Offset = "0x6FC8790", VA = "0x186FC9790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA550", Offset = "0x6FC9550", VA = "0x186FCA550")]
	public AICGHGNEBEE(DFKFCELAIFJ DFDEBBEGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA120", Offset = "0x6FC9120", VA = "0x186FCA120", Slot = "4")]
	public void NPPFCGBENNC(Vector3 HPJKELEMMFE, ForceMode FEOIDGGLIEB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9A50", Offset = "0x6FC8A50", VA = "0x186FC9A50")]
	private void IJJHLNKGEPI(Vector3 HPJKELEMMFE, ForceMode FEOIDGGLIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA280", Offset = "0x6FC9280", VA = "0x186FCA280", Slot = "5")]
	public void OFLICFLBDJG(Vector3 HPJKELEMMFE, Vector3 LLLHNMGEKPM, ForceMode FEOIDGGLIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9F10", Offset = "0x6FC8F10", VA = "0x186FC9F10", Slot = "6")]
	public void KMPIHOIHHMG(Vector3 BGMBOOCPFBE, ForceMode FEOIDGGLIEB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6FC97F0", Offset = "0x6FC87F0", VA = "0x186FC97F0")]
	private void ICCLIKPMIAA(Vector3 BGMBOOCPFBE, ForceMode FEOIDGGLIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9CB0", Offset = "0x6FC8CB0", VA = "0x186FC9CB0", Slot = "7")]
	public void JLGLLONLHNO(Vector3 BGMBOOCPFBE, ForceMode FEOIDGGLIEB = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class IMFLKFMCPHB : HLLPPLMFENG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly INPEPHPGFEC DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool DDHKBGIPDHE;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool LPOAFHJMOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x95D990", Offset = "0x95C990", VA = "0x18095D990", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5C90", Offset = "0x6FD4C90", VA = "0x186FD5C90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA550", Offset = "0x6FC9550", VA = "0x186FCA550")]
	public IMFLKFMCPHB(DFKFCELAIFJ DFDEBBEGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5DA0", Offset = "0x6FD4DA0", VA = "0x186FD5DA0", Slot = "6")]
	public void MCBEHMNHFPL(Rigidbody KHNFKMKPMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5C20", Offset = "0x6FD4C20", VA = "0x186FD5C20", Slot = "7")]
	public void DAILHFDMBCP(Rigidbody KHNFKMKPMNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class EONAIFDPJLI : DHBDDLNFFKD, NKGCEIFHHMN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly DFKFCELAIFJ DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<DFKFCELAIFJ> PHGEECMOLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private DFKFCELAIFJ JMCFDCHCIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private DFKFCELAIFJ EMOKCJBMKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private Transform ABGKAGFHMPM;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform EALAKNFEFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1110", Offset = "0x6FD0110", VA = "0x186FD1110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public DFKFCELAIFJ EOBHJDGKNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x8507D0", VA = "0x1808517D0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1220", Offset = "0x6FD0220", VA = "0x186FD1220", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public DFKFCELAIFJ KILMHGFMJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8516D0", Offset = "0x8506D0", VA = "0x1808516D0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<DFKFCELAIFJ> BJIGDHFOKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x85B5E0", Offset = "0x85A5E0", VA = "0x18085B5E0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event JMLNINKIFHA IGFHFJKFGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF840", Offset = "0x6FCE840", VA = "0x186FCF840", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD0590", Offset = "0x6FCF590", VA = "0x186FD0590", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event JMLNINKIFHA DDAMOFBGOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD0E00", Offset = "0x6FCFE00", VA = "0x186FD0E00", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF420", Offset = "0x6FCE420", VA = "0x186FCF420", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event ILNJNDCGDOB COGNAEOHMBE
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD0BB0", Offset = "0x6FCFBB0", VA = "0x186FD0BB0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD0C50", Offset = "0x6FCFC50", VA = "0x186FD0C50", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action HCLMLIEDFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF760", Offset = "0x6FCE760", VA = "0x186FCF760", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6FD0F40", Offset = "0x6FCFF40", VA = "0x186FD0F40", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action MMOCFPGEJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6FCFCB0", Offset = "0x6FCECB0", VA = "0x186FCFCB0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF570", Offset = "0x6FCE570", VA = "0x186FCF570", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<DFKFCELAIFJ> AHPHOFJCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF4C0", Offset = "0x6FCE4C0", VA = "0x186FCF4C0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF6B0", Offset = "0x6FCE6B0", VA = "0x186FCF6B0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<DFKFCELAIFJ> NFEJOPJJJBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1170", Offset = "0x6FD0170", VA = "0x186FD1170", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6FCFC00", Offset = "0x6FCEC00", VA = "0x186FCFC00", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action OBKICNCLENO
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6FD0EA0", Offset = "0x6FCFEA0", VA = "0x186FD0EA0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6FCFB60", Offset = "0x6FCEB60", VA = "0x186FCFB60", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<DFKFCELAIFJ> HCONIEMGGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6FD04E0", Offset = "0x6FCF4E0", VA = "0x186FD04E0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6FCFAB0", Offset = "0x6FCEAB0", VA = "0x186FCFAB0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1230", Offset = "0x6FD0230", VA = "0x186FD1230")]
	public EONAIFDPJLI(DFKFCELAIFJ DFDEBBEGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFA10", Offset = "0x6FCEA10", VA = "0x186FCFA10", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0630", Offset = "0x6FCF630", VA = "0x186FD0630", Slot = "30")]
	public void MLPLIFGNEGJ(DFKFCELAIFJ MECDJMBEHCP, bool PANBHGCACAL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFD50", Offset = "0x6FCED50", VA = "0x186FCFD50", Slot = "6")]
	public void HPINKIAMIAF(DFKFCELAIFJ NHBKNIAECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0260", Offset = "0x6FCF260", VA = "0x186FD0260", Slot = "7")]
	public void MBCACFMKOMH(DFKFCELAIFJ NHBKNIAECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0CF0", Offset = "0x6FCFCF0", VA = "0x186FD0CF0", Slot = "4")]
	public void MOFEODPEIPI(DFKFCELAIFJ DFDEBBEGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6FD01C0", Offset = "0x6FCF1C0", VA = "0x186FD01C0", Slot = "5")]
	public void JMPGGDOEONM(DFKFCELAIFJ DFDEBBEGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF610", Offset = "0x6FCE610", VA = "0x186FCF610")]
	private void AOIBMLLJDND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF800", Offset = "0x6FCE800", VA = "0x186FCF800")]
	private void CEJOKLFEGHA(DFKFCELAIFJ NHBKNIAECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0080", Offset = "0x6FCF080", VA = "0x186FD0080")]
	private void INBCDGBGOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0FE0", Offset = "0x6FCFFE0", VA = "0x186FD0FE0")]
	private void ODLIPBNFLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF8E0", Offset = "0x6FCE8E0", VA = "0x186FCF8E0")]
	private void DKGIKOFPNAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFFC0", Offset = "0x6FCEFC0", VA = "0x186FCFFC0")]
	[CompilerGenerated]
	private object IHILCJNCAJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class CEDKACCOLPB
{
	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDDE0", Offset = "0x6FCCDE0", VA = "0x186FCDDE0")]
	public static DHBDDLNFFKD MMPINNONJMG(this DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class JHEKKMIFANN : MPOJMMHFLJO, BNKEGDFMOIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly INPEPHPGFEC DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly LNHMKNJPHJE<DFKFCELAIFJ> OOELDMNODNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool NHDKEBJKEMF;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public LNHMKNJPHJE<DFKFCELAIFJ> IGKFDGICGHA
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 PBFJHAANDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6FDBE20", Offset = "0x6FDAE20", VA = "0x186FDBE20", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 NIMMPMMFIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6FDBEB0", Offset = "0x6FDAEB0", VA = "0x186FDBEB0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 BLLHMKAKHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC840", Offset = "0x6FDB840", VA = "0x186FDC840")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public DFKFCELAIFJ KKEFHAHBNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC070", Offset = "0x6FDB070", VA = "0x186FDC070", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6FDC9A0", Offset = "0x6FDB9A0", VA = "0x186FDC9A0")]
	public JHEKKMIFANN(DFKFCELAIFJ DFDEBBEGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6FDC930", Offset = "0x6FDB930", VA = "0x186FDC930", Slot = "8")]
	public void KAOGBFCNPNB(DFKFCELAIFJ EMOKCJBMKOL, object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6FDBE50", Offset = "0x6FDAE50", VA = "0x186FDBE50", Slot = "9")]
	public void BAOOJLNFEEC(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6FDC120", Offset = "0x6FDB120", VA = "0x186FDC120")]
	private Vector3 GOLEAGHPJBH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6FDC4B0", Offset = "0x6FDB4B0", VA = "0x186FDC4B0")]
	private void JFBMPAFNAFK(DFKFCELAIFJ JIBDKPLCPPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class MFOAADBELJG
{
	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD960", Offset = "0x6FDC960", VA = "0x186FDD960")]
	public static MPOJMMHFLJO BOJDNLKEEMH(this DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class CAJINDOGBPE : ANIKOLLGOOI, AEDOMBFKMMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly INPEPHPGFEC DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 OLADPOLGPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly OverridableVector3 GIBIPKFLPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float PMFOALBFFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private float HHIIADIOGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3 KKFPJBJFJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Vector3? HLMANMMDAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Quaternion? LEMMBFDPBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool EMOAKCEGHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool AOIPCCFEMML;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 IAKOELCOBDH
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xE50EC0", Offset = "0xE4FEC0", VA = "0x180E50EC0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC430", Offset = "0x6FCB430", VA = "0x186FCC430", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 OBEIAONFNHA
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC340", Offset = "0x6FCB340", VA = "0x186FCC340", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float GBGMHHELEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x95D9C0", Offset = "0x95C9C0", VA = "0x18095D9C0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6FCAB60", Offset = "0x6FC9B60", VA = "0x186FCAB60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float EJFLHGNKANJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x95D9B0", Offset = "0x95C9B0", VA = "0x18095D9B0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA930", Offset = "0x6FC9930", VA = "0x186FCA930", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 AAHHOMEFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC660", Offset = "0x6FCB660", VA = "0x186FCC660", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion MCHGPDENHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB1A0", Offset = "0x6FCA1A0", VA = "0x186FCB1A0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody MIEMDJAPKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCBF0", Offset = "0x6FCBBF0", VA = "0x186FCCBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event JMLNINKIFHA OFAEKNFHDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA9E0", Offset = "0x6FC99E0", VA = "0x186FCA9E0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD0E0", Offset = "0x6FCC0E0", VA = "0x186FCD0E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD180", Offset = "0x6FCC180", VA = "0x186FCD180")]
	public CAJINDOGBPE(DFKFCELAIFJ DFDEBBEGAOA, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6FCB320", Offset = "0x6FCA320", VA = "0x186FCB320", Slot = "17")]
	public void DJJBEGFPKFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FCAA80", Offset = "0x6FC9A80", VA = "0x186FCAA80", Slot = "16")]
	public void CGFDKPKFDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCB10", Offset = "0x6FCBB10", VA = "0x186FCCB10", Slot = "19")]
	public void MCBEHMNHFPL(Rigidbody KHNFKMKPMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FCAE10", Offset = "0x6FC9E10", VA = "0x186FCAE10", Slot = "20")]
	public void DAILHFDMBCP(Rigidbody KHNFKMKPMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FCAFF0", Offset = "0x6FC9FF0", VA = "0x186FCAFF0", Slot = "18")]
	public void DCMCPIBNEPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCC40", Offset = "0x6FCBC40", VA = "0x186FCCC40", Slot = "21")]
	public void MGAKKCHNFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC430", Offset = "0x6FCB430", VA = "0x186FCC430")]
	private void FEDILBDOGIG(Vector3 JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCA20", Offset = "0x6FCBA20", VA = "0x186FCCA20")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 ILNHCGMKHFH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6FCAB60", Offset = "0x6FC9B60", VA = "0x186FCAB60")]
	private void OBDLDNFFODA(float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA930", Offset = "0x6FC9930", VA = "0x186FCA930")]
	private void BBOLHOEOFOM(float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6FCAC70", Offset = "0x6FC9C70", VA = "0x186FCAC70")]
	private Vector3 DADABADFCIK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC7F0", Offset = "0x6FCB7F0", VA = "0x186FCC7F0", Slot = "15")]
	public void IGJDLHBDBKE((Quaternion rot, Vector3 moments) FGEFCHPKOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC4E0", Offset = "0x6FCB4E0", VA = "0x186FCC4E0")]
	private Quaternion FKHIJCFMKIJ()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6FCB4D0", Offset = "0x6FCA4D0", VA = "0x186FCB4D0")]
	public void EDNIKJIIDFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6FCB5A0", Offset = "0x6FCA5A0", VA = "0x186FCB5A0", Slot = "4")]
	public (float, Vector3) EDNIKJIIDFJ(Rigidbody OCNJPCIDJKA)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class HNKIJAOPJND
{
	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5B60", Offset = "0x6FD4B60", VA = "0x186FD5B60")]
	public static ANIKOLLGOOI AFFJFNGBNEJ(this DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class LHMIBKBNFOJ : PACNDENCNOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly INPEPHPGFEC DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly MBGIGHPFJLL BDJHJIGPGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly JMHIAMIADEH DJMDNPHHLCI;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool NOMGLLEIOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x1004410", Offset = "0x1003410", VA = "0x181004410", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public JMHIAMIADEH AAHOPFOMJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9ABFE0", Offset = "0x9AAFE0", VA = "0x1809ABFE0", Slot = "11")]
		get
		{
			return default(JMHIAMIADEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD290", Offset = "0x6FDC290", VA = "0x186FDD290")]
	public LHMIBKBNFOJ(DFKFCELAIFJ DFDEBBEGAOA, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCE60", Offset = "0x6FDBE60", VA = "0x186FDCE60", Slot = "4")]
	public void HKPMLCIOMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCCA0", Offset = "0x6FDBCA0", VA = "0x186FDCCA0")]
	private bool GBJFJHKEDGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCF30", Offset = "0x6FDBF30", VA = "0x186FDCF30", Slot = "5")]
	public void KAHCELNLDAN(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCC70", Offset = "0x6FDBC70", VA = "0x186FDCC70", Slot = "6")]
	public void BDECIABKNNC(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD110", Offset = "0x6FDC110", VA = "0x186FDD110", Slot = "9")]
	public void OFDOCLJGHPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCD40", Offset = "0x6FDBD40", VA = "0x186FDCD40")]
	private void GFBLDKBOLAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCFA0", Offset = "0x6FDBFA0", VA = "0x186FDCFA0")]
	private void LFLGPHPFDLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD250", Offset = "0x6FDC250", VA = "0x186FDD250", Slot = "8")]
	public void OGEJJODIBEN(DFKFCELAIFJ DFDEBBEGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCF60", Offset = "0x6FDBF60", VA = "0x186FDCF60", Slot = "7")]
	public void KIABAJLPADP(DFKFCELAIFJ DFDEBBEGAOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class EHOGDKBDJDC : FOAGNFAIEJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly INPEPHPGFEC DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly MBGIGHPFJLL NIFNPJNBHDC;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool FECJGCKLHED
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF1E0", Offset = "0x6FCE1E0", VA = "0x186FCF1E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event JMLNINKIFHA CNAFCFDIHHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF290", Offset = "0x6FCE290", VA = "0x186FCF290", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6FCEF20", Offset = "0x6FCDF20", VA = "0x186FCEF20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF330", Offset = "0x6FCE330", VA = "0x186FCF330")]
	public EHOGDKBDJDC(DFKFCELAIFJ DFDEBBEGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6FCEFC0", Offset = "0x6FCDFC0", VA = "0x186FCEFC0", Slot = "7")]
	public void BLNGBDGGJDB(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF1D0", Offset = "0x6FCE1D0", VA = "0x186FCF1D0", Slot = "8")]
	public void NMDIMOEGJIM(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF000", Offset = "0x6FCE000", VA = "0x186FCF000", Slot = "9")]
	public void GCKPKKDAKDO(object DJIBMMAIGPE, bool NMJDAPPHKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF110", Offset = "0x6FCE110", VA = "0x186FCF110", Slot = "12")]
	public void HMMGMLDNEOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF150", Offset = "0x6FCE150", VA = "0x186FCF150", Slot = "10")]
	public void MCBEHMNHFPL(Rigidbody MEADPIPLGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6FCEFD0", Offset = "0x6FCDFD0", VA = "0x186FCEFD0", Slot = "11")]
	public void DAILHFDMBCP(Rigidbody KHNFKMKPMNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class OBBHDMHAAOB : BCNDKIEACPI, DGEDFPLAJKI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly INPEPHPGFEC DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private PhotonView KDEMNNBJFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool DMAKNNEEEGE;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView MEHJDNJAJPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool LLPBCOPOAND
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6FDE430", Offset = "0x6FDD430", VA = "0x186FDE430", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool HIGNAPNNMIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xB4A400", Offset = "0xB49400", VA = "0x180B4A400", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event JMLNINKIFHA JLECKOCGJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6FDDD10", Offset = "0x6FDCD10", VA = "0x186FDDD10", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6FDDB70", Offset = "0x6FDCB70", VA = "0x186FDDB70", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE5C0", Offset = "0x6FDD5C0", VA = "0x186FDE5C0")]
	public OBBHDMHAAOB(DFKFCELAIFJ DFDEBBEGAOA, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE090", Offset = "0x6FDD090", VA = "0x186FDE090", Slot = "9")]
	public void HKPMLCIOMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDC10", Offset = "0x6FDCC10", VA = "0x186FDDC10", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE450", Offset = "0x6FDD450", VA = "0x186FDE450", Slot = "10")]
	public void OMFIJJAJDAO(DFKFCELAIFJ EMOKCJBMKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDF20", Offset = "0x6FDCF20", VA = "0x186FDDF20", Slot = "11")]
	public void GFHHPBMEDLF(DFKFCELAIFJ EMOKCJBMKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDDB0", Offset = "0x6FDCDB0", VA = "0x186FDDDB0")]
	private void FDMIOGAMHAN(PhotonView GMJABLJLLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDA20", Offset = "0x6FDCA20", VA = "0x186FDDA20")]
	private void ADEFDOPAGLG(FKKFNKHOOAA NNELBCFBEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE1C0", Offset = "0x6FDD1C0", VA = "0x186FDE1C0")]
	private void KKEKOMDIGOP(PhotonView FGOKOEELJCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class LFLLLMIHGIE
{
	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCBB0", Offset = "0x6FDBBB0", VA = "0x186FDCBB0")]
	public static BCNDKIEACPI HLBFCJNDBEP(this DFKFCELAIFJ OEFGKJLECGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class MDJDOOPMNNK : CBLFLACPMLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly INPEPHPGFEC DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private RigidbodyConstraints KDMHMPJFOPO;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool HBBNKPPIMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x95D900", Offset = "0x95C900", VA = "0x18095D900", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x45BAA20", Offset = "0x45B9A20", VA = "0x1845BAA20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool PLKOKHFHLMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x95D920", Offset = "0x95C920", VA = "0x18095D920", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x45BAA10", Offset = "0x45B9A10", VA = "0x1845BAA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints ENOOHPAIPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x85BDB0", Offset = "0x85ADB0", VA = "0x18085BDB0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x6FDD760", Offset = "0x6FDC760", VA = "0x186FDD760", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD8C0", Offset = "0x6FDC8C0", VA = "0x186FDD8C0")]
	public MDJDOOPMNNK(DFKFCELAIFJ DFDEBBEGAOA, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD890", Offset = "0x6FDC890", VA = "0x186FDD890", Slot = "9")]
	public void MCBEHMNHFPL(Rigidbody KHNFKMKPMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD730", Offset = "0x6FDC730", VA = "0x186FDD730", Slot = "10")]
	public void DAILHFDMBCP(Rigidbody KHNFKMKPMNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class LLAPFPHOMGK : AJEJDLJNOLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly DFKFCELAIFJ DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float GKAKHGCNJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private float CLPMHAMDMMI;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float IGBCDKAFKFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x99AE70", Offset = "0x999E70", VA = "0x18099AE70", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6FDD430", Offset = "0x6FDC430", VA = "0x186FDD430", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float NCMDNGFEPNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x99AE60", Offset = "0x999E60", VA = "0x18099AE60", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x6FDD550", Offset = "0x6FDC550", VA = "0x186FDD550", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD620", Offset = "0x6FDC620", VA = "0x186FDD620")]
	public LLAPFPHOMGK(DFKFCELAIFJ DFDEBBEGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD500", Offset = "0x6FDC500", VA = "0x186FDD500", Slot = "8")]
	public void MCBEHMNHFPL(Rigidbody KHNFKMKPMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD390", Offset = "0x6FDC390", VA = "0x186FDD390", Slot = "9")]
	public void DAILHFDMBCP(Rigidbody KHNFKMKPMNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class CCFOGEFJDGA : BFGGNDAFJPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly INPEPHPGFEC DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool LAEGGCLIJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private bool OLPMHNJFGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int LEBJMIAJMFK;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody MIEMDJAPKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCBF0", Offset = "0x6FCBBF0", VA = "0x186FCCBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool DHBNIHIBKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD760", Offset = "0x6FCC760", VA = "0x186FCD760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private DFKFCELAIFJ EOBHJDGKNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD2E0", Offset = "0x6FCC2E0", VA = "0x186FCD2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool OHHGFHHHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6FCDA60", Offset = "0x6FCCA60", VA = "0x186FCDA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event JMLNINKIFHA CDLFDNALIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD810", Offset = "0x6FCC810", VA = "0x186FCD810", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD4D0", Offset = "0x6FCC4D0", VA = "0x186FCD4D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDD50", Offset = "0x6FCCD50", VA = "0x186FCDD50")]
	public CCFOGEFJDGA(DFKFCELAIFJ DFDEBBEGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD780", Offset = "0x6FCC780", VA = "0x186FCD780", Slot = "6")]
	public void HKPMLCIOMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDB60", Offset = "0x6FCCB60", VA = "0x186FCDB60", Slot = "8")]
	public void NOPCPNOMMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD570", Offset = "0x6FCC570", VA = "0x186FCD570", Slot = "7")]
	public bool FIMHINPOPMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDAC0", Offset = "0x6FCCAC0", VA = "0x186FCDAC0", Slot = "9")]
	public void NCGLFOBFHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD6C0", Offset = "0x6FCC6C0", VA = "0x186FCD6C0", Slot = "11")]
	public void FKAKBCDENJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD8B0", Offset = "0x6FCC8B0", VA = "0x186FCD8B0", Slot = "10")]
	public void IFKBGELHDNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDB70", Offset = "0x6FCCB70", VA = "0x186FCDB70")]
	private bool PMGFPBDCBAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD340", Offset = "0x6FCC340", VA = "0x186FCD340")]
	private void BFNJGNIFAFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class FFHAKJEHDFN : AAIAPCIMDND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly INPEPHPGFEC DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly MBGIGHPFJLL EJDFPEKMKMJ;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody MIEMDJAPKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool OHHGFHHHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA070", Offset = "0x6FC9070", VA = "0x186FCA070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool LCCAELECGIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x1004410", Offset = "0x1003410", VA = "0x181004410", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1CC0", Offset = "0x6FD0CC0", VA = "0x186FD1CC0")]
	public FFHAKJEHDFN(DFKFCELAIFJ DFDEBBEGAOA, [In] KFNPMFNDCGH AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1A30", Offset = "0x6FD0A30", VA = "0x186FD1A30", Slot = "5")]
	public void HKPMLCIOMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1550", Offset = "0x6FD0550", VA = "0x186FD1550", Slot = "7")]
	public void CGAAOOCFJLO(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1520", Offset = "0x6FD0520", VA = "0x186FD1520", Slot = "8")]
	public void BEDABBIDNKK(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1700", Offset = "0x6FD0700", VA = "0x186FD1700", Slot = "9")]
	public void CNHLLGOJLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1AD0", Offset = "0x6FD0AD0", VA = "0x186FD1AD0", Slot = "10")]
	public void NKGNDNFKMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1580", Offset = "0x6FD0580", VA = "0x186FD1580", Slot = "11")]
	public void CIPEDJLCFDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class HBBMAHJPKEH : IFPIILLFAMG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly INPEPHPGFEC DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly MBGIGHPFJLL FLMHJFFCAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private float KNEPNOIABKO;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public GHKLKADMCLK MAOOOBLDOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x855820", Offset = "0x854820", VA = "0x180855820", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public JLDEAACPJLG OIKNHNOABJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x855810", Offset = "0x854810", VA = "0x180855810", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 BLLHMKAKHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4A90", Offset = "0x6FD3A90", VA = "0x186FD4A90", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6FD59B0", Offset = "0x6FD49B0", VA = "0x186FD59B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 BPFENOHBMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD27E0", Offset = "0x6FD17E0", VA = "0x186FD27E0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2AA0", Offset = "0x6FD1AA0", VA = "0x186FD2AA0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 HKHJELDKBGA
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2560", Offset = "0x6FD1560", VA = "0x186FD2560", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD26C0", Offset = "0x6FD16C0", VA = "0x186FD26C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 HCOGDBJHCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4140", Offset = "0x6FD3140", VA = "0x186FD4140", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD57C0", Offset = "0x6FD47C0", VA = "0x186FD57C0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float LDIJOKADLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x95D9D0", Offset = "0x95C9D0", VA = "0x18095D9D0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3A40", Offset = "0x6FD2A40", VA = "0x186FD3A40", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool DLGMMAHDEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x198B400", Offset = "0x198A400", VA = "0x18198B400", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private KMCAEKBOLKK DDEKLACBIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x67F4EA0", Offset = "0x67F3EA0", VA = "0x1867F4EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool DHBNIHIBKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3B50", Offset = "0x6FD2B50", VA = "0x186FD3B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5A70", Offset = "0x6FD4A70", VA = "0x186FD5A70")]
	public HBBMAHJPKEH(DFKFCELAIFJ DFDEBBEGAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6FD24B0", Offset = "0x6FD14B0", VA = "0x186FD24B0", Slot = "19")]
	public void HKPMLCIOMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2AD0", Offset = "0x6FD1AD0", VA = "0x186FD2AD0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5260", Offset = "0x6FD4260", VA = "0x186FD5260", Slot = "28")]
	public void MCBEHMNHFPL(Rigidbody KHNFKMKPMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xE11580", Offset = "0xE10580", VA = "0x180E11580", Slot = "20")]
	public void BAEAPPBKNOE(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0xE11D40", Offset = "0xE10D40", VA = "0x180E11D40", Slot = "30")]
	public void JDAGOFDGDMI(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4BF0", Offset = "0x6FD3BF0", VA = "0x186FD4BF0", Slot = "35")]
	public Vector3 KEKMJGLJNJP(Vector3 NKDCMJAIHCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD57F0", Offset = "0x6FD47F0", VA = "0x186FD57F0", Slot = "34")]
	public Vector3 MMAAAIDDKKN(Vector3 CCMFHJLEKOG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD24B0", Offset = "0x6FD14B0", VA = "0x186FD24B0", Slot = "27")]
	public void BACIIGGFLGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2780", Offset = "0x6FD1780", VA = "0x186FD2780", Slot = "25")]
	public void CEECMIGGMDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3B70", Offset = "0x6FD2B70", VA = "0x186FD3B70", Slot = "24")]
	public void IBFPMPLPMAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3250", Offset = "0x6FD2250", VA = "0x186FD3250", Slot = "33")]
	public void ENBDCHCJMNC(Vector3 KBJBGEBKDGD, Vector3 DGLIDJNFFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4A30", Offset = "0x6FD3A30", VA = "0x186FD4A30", Slot = "32")]
	public void JPHIHPPKNEJ(Vector3 NIDALEFHFGP, Vector3 AMMNBNBOHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2900", Offset = "0x6FD1900", VA = "0x186FD2900", Slot = "31")]
	public void CLIGPBPPJPB(Vector3 CGJNBPCMBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2BE0", Offset = "0x6FD1BE0", VA = "0x186FD2BE0", Slot = "22")]
	public void ELKLHMOPGNC(PINDDEBDGAN LJHIOLBCCLM, Vector3 CHJCBNCKLNJ, float PENDKPMEBEM, float IHDHJOHPOID = 8f, float CPJCMINNEPA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5390", Offset = "0x6FD4390", VA = "0x186FD5390", Slot = "21")]
	public void MEMDAICICEL(IMFKBKBHMKC BPMCIHAHBEP, Vector3 PKAILENOOIF, float HKJPMNKBPCD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4520", Offset = "0x6FD3520", VA = "0x186FD4520", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JNNKCEADNND(IMFKBKBHMKC BPMCIHAHBEP, Vector3 BCKIPOGEHOJ, float BCBOHKMEOIN = 7f, float CBILEDLNPGP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0xF47380", Offset = "0xF46380", VA = "0x180F47380")]
	private static void PHBPJMDANKO(Vector3 LKAKKODKGLB, Vector3 NJOPFIOMLFB, [Out] Vector3 FBNFLHLDIOJ, [Out] Vector3 JFBCDDCAEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4060", Offset = "0x6FD3060", VA = "0x186FD4060", Slot = "29")]
	public Vector3 IGCHDLIAKLN(Vector3 LKAKKODKGLB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4270", Offset = "0x6FD3270", VA = "0x186FD4270", Slot = "26")]
	public void JFAINLNIDHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3A40", Offset = "0x6FD2A40", VA = "0x186FD3A40")]
	private void MJCHALGDDAP(float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5620", Offset = "0x6FD4620", VA = "0x186FD5620")]
	private void MGFJFFFDJMC(Vector3 PKAILENOOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4910", Offset = "0x6FD3910", VA = "0x186FD4910")]
	private Vector3 JPDNODPEOEI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4DD0", Offset = "0x6FD3DD0", VA = "0x186FD4DD0")]
	private void LPCKHPICKOI(Vector3 CCMFHJLEKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4400", Offset = "0x6FD3400", VA = "0x186FD4400")]
	private Vector3 JJNIEMKEABP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3BD0", Offset = "0x6FD2BD0", VA = "0x186FD3BD0")]
	private void ICADIOOJBAG(Vector3 JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3490", Offset = "0x6FD2490", VA = "0x186FD3490")]
	private void FIMAFIHNPEA(Vector3 CCMFHJLEKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2B30", Offset = "0x6FD1B30", VA = "0x186FD2B30")]
	private void EADPGELIBFE()
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
