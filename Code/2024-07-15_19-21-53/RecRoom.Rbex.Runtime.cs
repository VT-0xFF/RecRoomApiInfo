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
	public class LogRegistrationIndex : MKCMLEJGADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F30E10", Offset = "0x6F2F610", VA = "0x186F30E10", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
	public class _AssemblyIndex : ACEDPDPNKDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HGLIPANAEFD bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x14ED5A0", Offset = "0x14EBDA0", VA = "0x1814ED5A0", Slot = "5")]
		public override void GGDGBHPPNIB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F38C30", Offset = "0x6F37430", VA = "0x186F38C30")]
		private void AOCOLDKKJHF(FCHLICHCLOD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F38F30", Offset = "0x6F37730", VA = "0x186F38F30", Slot = "6")]
		public override void KNAPKCNJDIM(FCHLICHCLOD registry, [In] NGGDAGDIDAI filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "8")]
		public override void KCOPNMGFKOP(GOMCEOHIOKI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F38F90", Offset = "0x6F37790", VA = "0x186F38F90")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, HJKEDKBDPPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly CDLNJDLNIPA EAKBAFMDBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool KCLGDJILEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private LJEEPNBNNHB INFEHJIACJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[GEDHJJPMAGH(LEHCEJJDOON.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[GEDHJJPMAGH(LEHCEJJDOON.SelfAndParent, true, false, false)]
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
		private ONPHIJJLPGG physicsInterpolation;

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

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal LJEEPNBNNHB AIBPMOMJGNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6F34650", Offset = "0x6F32E50", VA = "0x186F34650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LJEEPNBNNHB HGPLEJGEAPO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int DGFFNAGFKDO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F360A0", Offset = "0x6F348A0", VA = "0x186F360A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx BOHHFPAPAAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F36400", Offset = "0x6F34C00", VA = "0x186F36400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx DHCIAOJNIGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F36340", Offset = "0x6F34B40", VA = "0x186F36340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx BMBBFJPOJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6F370A0", Offset = "0x6F358A0", VA = "0x186F370A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F385A0", Offset = "0x6F36DA0", VA = "0x186F385A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform CCIHBJHNFDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x87B800", Offset = "0x87A000", VA = "0x18087B800", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform NFGKEMNGCHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x87B800", Offset = "0x87A000", VA = "0x18087B800", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public EEPBOLJHLNK MCAKOHHFPJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F36100", Offset = "0x6F34900", VA = "0x186F36100")]
			get
			{
				return default(EEPBOLJHLNK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F37D50", Offset = "0x6F36550", VA = "0x186F37D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GGCJPCDEOFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F36710", Offset = "0x6F34F10", VA = "0x186F36710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool OMMEKKCNHOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F36220", Offset = "0x6F34A20", VA = "0x186F36220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public GCCHGDAONKB GLMHBPJHKEB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F36650", Offset = "0x6F34E50", VA = "0x186F36650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F37F10", Offset = "0x6F36710", VA = "0x186F37F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LIJOKMDFOFH MCJHNAIMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F365F0", Offset = "0x6F34DF0", VA = "0x186F365F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F37EA0", Offset = "0x6F366A0", VA = "0x186F37EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool BOOAKEKDDLH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F36540", Offset = "0x6F34D40", VA = "0x186F36540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody DHIIHPKBDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F365A0", Offset = "0x6F34DA0", VA = "0x186F365A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool FKLLLKFDFMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F36280", Offset = "0x6F34A80", VA = "0x186F36280")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F37DC0", Offset = "0x6F365C0", VA = "0x186F37DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool FNFOMIAJIKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6C15B40", Offset = "0x6C14340", VA = "0x186C15B40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float MFLAEOCINDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F37040", Offset = "0x6F35840", VA = "0x186F37040")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float NLILMFBCLII
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F36FE0", Offset = "0x6F357E0", VA = "0x186F36FE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F38530", Offset = "0x6F36D30", VA = "0x186F38530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float MFICPAKCDLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F36970", Offset = "0x6F35170", VA = "0x186F36970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F381B0", Offset = "0x6F369B0", VA = "0x186F381B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float JPAHPGHKFID
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F36770", Offset = "0x6F34F70", VA = "0x186F36770")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6F37F80", Offset = "0x6F36780", VA = "0x186F37F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool GEOCOMMJHCI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6F375F0", Offset = "0x6F35DF0", VA = "0x186F375F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F38AE0", Offset = "0x6F372E0", VA = "0x186F38AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 OKJPOCNNKIP
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F36DC0", Offset = "0x6F355C0", VA = "0x186F36DC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F38300", Offset = "0x6F36B00", VA = "0x186F38300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 GNEGFFPGDPL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F37730", Offset = "0x6F35F30", VA = "0x186F37730")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode OHMIAFIIEPI
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F368B0", Offset = "0x6F350B0", VA = "0x186F368B0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6F380D0", Offset = "0x6F368D0", VA = "0x186F380D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float OBLJBMFPBCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F362E0", Offset = "0x6F34AE0", VA = "0x186F362E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F37E30", Offset = "0x6F36630", VA = "0x186F37E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints JPAPNIOBBKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F36910", Offset = "0x6F35110", VA = "0x186F36910")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F38140", Offset = "0x6F36940", VA = "0x186F38140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 FNLEIIJLBBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F37160", Offset = "0x6F35960", VA = "0x186F37160")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 MPCBIACINGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F37160", Offset = "0x6F35960", VA = "0x186F37160")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F388C0", Offset = "0x6F370C0", VA = "0x186F388C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float AHDCCDIOAPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6F36EA0", Offset = "0x6F356A0", VA = "0x186F36EA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F383E0", Offset = "0x6F36BE0", VA = "0x186F383E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NGAMAICEFKI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F37590", Offset = "0x6F35D90", VA = "0x186F37590")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F38A70", Offset = "0x6F37270", VA = "0x186F38A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion BHIAAANLCMM
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F37240", Offset = "0x6F35A40", VA = "0x186F37240")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F38640", Offset = "0x6F36E40", VA = "0x186F38640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion ONNKAJNPEEG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F374C0", Offset = "0x6F35CC0", VA = "0x186F374C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6F389A0", Offset = "0x6F371A0", VA = "0x186F389A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 FPHICFGFPKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F37310", Offset = "0x6F35B10", VA = "0x186F37310")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6F38710", Offset = "0x6F36F10", VA = "0x186F38710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion PFGGMIAAHLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F373F0", Offset = "0x6F35BF0", VA = "0x186F373F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6F387F0", Offset = "0x6F36FF0", VA = "0x186F387F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 GPJLHMNPICC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F37650", Offset = "0x6F35E50", VA = "0x186F37650")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6F38B50", Offset = "0x6F37350", VA = "0x186F38B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 NOGFFKGBCOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6F36F00", Offset = "0x6F35700", VA = "0x186F36F00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6F38450", Offset = "0x6F36C50", VA = "0x186F38450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 FJCOMDPBLBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6F367D0", Offset = "0x6F34FD0", VA = "0x186F367D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6F37FF0", Offset = "0x6F367F0", VA = "0x186F37FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 IGMBCDNHIBE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6F36CE0", Offset = "0x6F354E0", VA = "0x186F36CE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6F38220", Offset = "0x6F36A20", VA = "0x186F38220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 CKKOBMDHEHP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6F36BA0", Offset = "0x6F353A0", VA = "0x186F36BA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion PBLCAIBKDLE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6F36AD0", Offset = "0x6F352D0", VA = "0x186F36AD0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 IHBGJBAOAJE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6F378F0", Offset = "0x6F360F0", VA = "0x186F378F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 NAPNEBENMHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6F37810", Offset = "0x6F36010", VA = "0x186F37810")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool JMEEMLNLABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6F36C80", Offset = "0x6F35480", VA = "0x186F36C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool HJFGMLFHNIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6F366B0", Offset = "0x6F34EB0", VA = "0x186F366B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool GFHIPOLMMFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6F361C0", Offset = "0x6F349C0", VA = "0x186F361C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool FGNIPGKHKKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6F36160", Offset = "0x6F34960", VA = "0x186F36160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DKNNPMBIPBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6F36040", Offset = "0x6F34840", VA = "0x186F36040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool FNJKLOEFDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6F369D0", Offset = "0x6F351D0", VA = "0x186F369D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HPJBMFGHLLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5936580", Offset = "0x5934D80", VA = "0x185936580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event KFNJEADEOOD LICFJNGNCOE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F35F60", Offset = "0x6F34760", VA = "0x186F35F60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6F37C70", Offset = "0x6F36470", VA = "0x186F37C70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CEJKOKAHCJG GOMCPIIALCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6F35CD0", Offset = "0x6F344D0", VA = "0x186F35CD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6F379D0", Offset = "0x6F361D0", VA = "0x186F379D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event CEJKOKAHCJG KNBPNKNELBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F35D30", Offset = "0x6F34530", VA = "0x186F35D30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6F37A40", Offset = "0x6F36240", VA = "0x186F37A40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event CEJKOKAHCJG LALHICAPNBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6F35E80", Offset = "0x6F34680", VA = "0x186F35E80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6F37B90", Offset = "0x6F36390", VA = "0x186F37B90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<FHBBMPGGCGD, FHBBMPGGCGD> MDHINEPAAFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F35E10", Offset = "0x6F34610", VA = "0x186F35E10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F37B20", Offset = "0x6F36320", VA = "0x186F37B20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event CEJKOKAHCJG CLKHELDEPHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F35EF0", Offset = "0x6F346F0", VA = "0x186F35EF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F37C00", Offset = "0x6F36400", VA = "0x186F37C00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event CEJKOKAHCJG BIJPPNGOHEI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F35FD0", Offset = "0x6F347D0", VA = "0x186F35FD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F37CE0", Offset = "0x6F364E0", VA = "0x186F37CE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event CEJKOKAHCJG HCDKLCFJLOG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F35DA0", Offset = "0x6F345A0", VA = "0x186F35DA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F37AB0", Offset = "0x6F362B0", VA = "0x186F37AB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851070", VA = "0x180852870", Slot = "8")]
		private void DHGOHHBIDBH(LJEEPNBNNHB CIGKBEKHOLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F34D40", Offset = "0x6F33540", VA = "0x186F34D40")]
		internal void PJIEKOHGLGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F359F0", Offset = "0x6F341F0", VA = "0x186F359F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody JNPMEKFEALJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F34700", Offset = "0x6F32F00", VA = "0x186F34700")]
		public HJKEDKBDPPP GetChild(int DHNLEFJCEAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6F35660", Offset = "0x6F33E60", VA = "0x186F35660")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) CKEJAFLIMPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F341E0", Offset = "0x6F329E0", VA = "0x186F341E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F34650", Offset = "0x6F32E50", VA = "0x186F34650")]
		private LJEEPNBNNHB GBHFCLLMEDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F34430", Offset = "0x6F32C30", VA = "0x186F34430")]
		private void EEKIDKGBNNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F34E30", Offset = "0x6F33630", VA = "0x186F34E30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F34D40", Offset = "0x6F33540", VA = "0x186F34D40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F34DD0", Offset = "0x6F335D0", VA = "0x186F34DD0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F34E90", Offset = "0x6F33690", VA = "0x186F34E90")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F337D0", Offset = "0x6F31FD0", VA = "0x186F337D0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F34EF0", Offset = "0x6F336F0", VA = "0x186F34EF0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F343D0", Offset = "0x6F32BD0", VA = "0x186F343D0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F34CE0", Offset = "0x6F334E0", VA = "0x186F34CE0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F357C0", Offset = "0x6F33FC0", VA = "0x186F357C0")]
		public void SetParent(RigidbodyEx JMDCGOKJIDA, bool DCIOAOCCLNO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F35200", Offset = "0x6F33A00", VA = "0x186F35200")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F349B0", Offset = "0x6F331B0", VA = "0x186F349B0")]
		public bool IsRigidbodyAncestor(RigidbodyEx KPIPNJDNJNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F34A90", Offset = "0x6F33290", VA = "0x186F34A90")]
		public bool IsRigidbodyDescendant(RigidbodyEx NIOHKOJCMDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F33A40", Offset = "0x6F32240", VA = "0x186F33A40")]
		public void AddInterpolationRestriction(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F34F60", Offset = "0x6F33760", VA = "0x186F34F60")]
		public void RemoveInterpolationRestriction(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F33AB0", Offset = "0x6F322B0", VA = "0x186F33AB0")]
		public void AddKinematic(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F34FD0", Offset = "0x6F337D0", VA = "0x186F34FD0")]
		public void RemoveKinematic(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F35740", Offset = "0x6F33F40", VA = "0x186F35740")]
		public void SetKinematic(object EOCJCEFCOOA, bool MCDOCGGGECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F35560", Offset = "0x6F33D60", VA = "0x186F35560")]
		public void SetDiscontinuousPositionAndRotation(Vector3 BELOINIPDIB, Quaternion HJPFNIDEMNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F35460", Offset = "0x6F33C60", VA = "0x186F35460")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 LEDGGONKHOH, Quaternion GNOJHHCJPOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F348A0", Offset = "0x6F330A0", VA = "0x186F348A0")]
		public Vector3 GetConstrainedVelocity(Vector3 GPJLHMNPICC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F34790", Offset = "0x6F32F90", VA = "0x186F34790")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 FJCOMDPBLBJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F33950", Offset = "0x6F32150", VA = "0x186F33950")]
		public void AddForce(Vector3 AMNFMCIBNPO, ForceMode HAMIBHDKAKH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F33840", Offset = "0x6F32040", VA = "0x186F33840")]
		public void AddForceAtPosition(Vector3 AMNFMCIBNPO, Vector3 HGDCPNGLIKJ, ForceMode HAMIBHDKAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F33C80", Offset = "0x6F32480", VA = "0x186F33C80")]
		public void AddTorque(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F33B20", Offset = "0x6F32320", VA = "0x186F33B20")]
		public void AddRelativeTorque(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F35AC0", Offset = "0x6F342C0", VA = "0x186F35AC0")]
		public Vector3 WorldToLocalVelocity(Vector3 FIMFMOJFCFJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F34BD0", Offset = "0x6F333D0", VA = "0x186F34BD0")]
		public Vector3 LocalToWorldVelocity(Vector3 NOGFFKGBCOL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F34370", Offset = "0x6F32B70", VA = "0x186F34370")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F34310", Offset = "0x6F32B10", VA = "0x186F34310")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F342B0", Offset = "0x6F32AB0", VA = "0x186F342B0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F34250", Offset = "0x6F32A50", VA = "0x186F34250")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F35360", Offset = "0x6F33B60", VA = "0x186F35360")]
		public void ResetVelocityWorldSpace(Vector3 HFOBNBKELJL, Vector3 MHBEFOAKJDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F35260", Offset = "0x6F33A60", VA = "0x186F35260")]
		public void ResetVelocityLocalSpace(Vector3 JNININDALMJ, Vector3 IGMBCDNHIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F35120", Offset = "0x6F33920", VA = "0x186F35120")]
		public void ResetLinearVelocityLocalSpace(Vector3 JNININDALMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F358F0", Offset = "0x6F340F0", VA = "0x186F358F0")]
		public bool SweepTest(Vector3 FCBGHELDCII, [Out] RaycastHit MGGIMCBEOEH, float BKKDIDJOENO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F34B70", Offset = "0x6F33370", VA = "0x186F34B70")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F35890", Offset = "0x6F34090", VA = "0x186F35890")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F35A60", Offset = "0x6F34260", VA = "0x186F35A60")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F33C10", Offset = "0x6F32410", VA = "0x186F33C10")]
		public void AddShouldHaveUnityRigidbodyToken(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F35040", Offset = "0x6F33840", VA = "0x186F35040")]
		public void RemoveShouldHaveUnityRigidbodyToken(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6F34010", Offset = "0x6F32810", VA = "0x186F34010")]
		public void ApplyForceVelocityChange(CJOGEGMLKDO OEJNBMLJOIB, Vector3 NBOECIFPPEF, float AHEAGOIPKJF, float CNMGOEBKPGK = 8f, float IMBABICPDKH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F33F10", Offset = "0x6F32710", VA = "0x186F33F10")]
		public void ApplyAngularVelocityChange(JCBCIKFMAML KEJNJHGGNMJ, Vector3 BJMFJJKFMAF, float EEDKOLOOPKK = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F340D0", Offset = "0x6F328D0", VA = "0x186F340D0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(JCBCIKFMAML KEJNJHGGNMJ, Vector3 LCDJINCAHMD, float ONOCCGOPHEL = 7f, float BKJDNLFEDGK = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F33E40", Offset = "0x6F32640", VA = "0x186F33E40")]
		public bool AllowedScaleChange(float BONLJCBABLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F33D70", Offset = "0x6F32570", VA = "0x186F33D70")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx KNDIPAMGJEH, object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6F350B0", Offset = "0x6F338B0", VA = "0x186F350B0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F35C60", Offset = "0x6F34460", VA = "0x186F35C60")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9470D0", Offset = "0x9458D0", VA = "0x1809470D0", Slot = "4")]
		private GameObject OJCAIHCGHDH()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x87B800", Offset = "0x87A000", VA = "0x18087B800", Slot = "5")]
		private Transform PGCBPGAFFCL()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class LHGGPBOAFAK
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F301E0", Offset = "0x6F2E9E0", VA = "0x186F301E0")]
	public static LJEEPNBNNHB AIBPMOMJGNG(this RigidbodyEx NKIPNFFBDAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OMGHGEFADHA(typeof(NGLPLNHDEND), new string[] { })]
public class OKMFNHAJNMD : NGLPLNHDEND, CEFKIMLFJCK
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private AMHKPPIPMFB JDGOCFMKIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private EHBLFKODNKE EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private CHMPPNFIFLC MAGBCPDOEFN;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public EHBLFKODNKE KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public CHMPPNFIFLC KKACPIKCPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F327F0", Offset = "0x6F30FF0", VA = "0x186F327F0", Slot = "7")]
	public void InitReferences(GANFHFOELEK FGDLGNMCKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F326E0", Offset = "0x6F30EE0", VA = "0x186F326E0", Slot = "6")]
	public LJEEPNBNNHB BAEHCLHNCHB(RigidbodyEx NKIPNFFBDAI, KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public OKMFNHAJNMD()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static EHODCIMNDCH UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int GPLCDBFAMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int GFKECHHEOOK;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F33630", Offset = "0x6F31E30", VA = "0x186F33630")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F33670", Offset = "0x6F31E70", VA = "0x186F33670")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F33650", Offset = "0x6F31E50", VA = "0x186F33650")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string JNNDBFGKHHD, [Optional] UnityEngine.Object CNBJCJOALNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string JNNDBFGKHHD, [Optional] UnityEngine.Object CNBJCJOALNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F33780", Offset = "0x6F31F80", VA = "0x186F33780")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BGPGHLGDHJM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class OLKJGBMCMLD : GCCHGDAONKB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x862EA0", Offset = "0x8616A0", VA = "0x180862EA0", Slot = "4")]
		public Vector3 DIFJFDGIODF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x862EA0", Offset = "0x8616A0", VA = "0x180862EA0", Slot = "5")]
		public Vector3 BGIAFHGNAFC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public OLKJGBMCMLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static GCCHGDAONKB OAPCCIJDEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F25180", Offset = "0x6F23980", VA = "0x186F25180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KHFOMKPIPGM
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode AIBPEFBJHBH
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
	void PJMDLPKCJOP();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANGDFDOOLIM(bool JMEEMLNLABH);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOOFBKMEGCH(bool JMEEMLNLABH);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DLPAKOEIMOE(Vector3 FCBGHELDCII, [Out] RaycastHit MGGIMCBEOEH, float BKKDIDJOENO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BBELJPEBCDG : IDisposable, BKOBFDPOEOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	EEPBOLJHLNK MCAKOHHFPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<FHBBMPGGCGD, FHBBMPGGCGD> MDHINEPAAFP;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PJMDLPKCJOP();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface CHMPPNFIFLC
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OBLCMNIHHPA AKEKIEBHBJM(LJEEPNBNNHB CIGKBEKHOLC);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HAOKEBMAJGF BDMGOHHJINE(LJEEPNBNNHB CIGKBEKHOLC);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OLJDHFEMIEM HAPBJDJMOKP(LJEEPNBNNHB CIGKBEKHOLC);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BNEAKDEKEGF IJMKDLBCPMP(LJEEPNBNNHB CIGKBEKHOLC);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JKJFHGFNKMI HPEKAGMBJOF(LJEEPNBNNHB CIGKBEKHOLC);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BBELJPEBCDG KJDJCCIJHCL(LJEEPNBNNHB CIGKBEKHOLC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IACJBDKKNDH OKCGHCGAIAG(LJEEPNBNNHB CIGKBEKHOLC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MPONMNOKEDF IOLKGNHHCJA(LJEEPNBNNHB CIGKBEKHOLC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KHFOMKPIPGM LBHINPABMFD(LJEEPNBNNHB CIGKBEKHOLC);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CJGADINNADB KHOAHPFHAGL(LJEEPNBNNHB CIGKBEKHOLC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LCNNLPJHPDO KKNJHPKAHML(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ENODCFCBNKN BDCEKGMLOAH(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HAPDGEOPNLL JEELHNMABOD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IGANODCOKHB NCBDCBPKBEJ(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EJDCPCDIDOH DPMMFGFJGFD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LJEEPNBNNHB BAEHCLHNCHB(RigidbodyEx NKIPNFFBDAI, KPFNKPJMKHJ LINJEFIAFHO, NGLPLNHDEND GOHDOKCJOFP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MPONMNOKEDF
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAPGLCIGOAI(Vector3 AMNFMCIBNPO, ForceMode HAMIBHDKAKH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APEKDDPMJIA(Vector3 AMNFMCIBNPO, Vector3 HGDCPNGLIKJ, ForceMode HAMIBHDKAKH);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPEOIJLIBJD(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HDLFPCCLPMC(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CJGADINNADB
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool FLNDLEBMONH
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
	void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBFMCBMPPJM(Rigidbody AMBNMKKFJOP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OBLCMNIHHPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<LJEEPNBNNHB> PLOBAPBGHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	LJEEPNBNNHB DHCIAOJNIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	LJEEPNBNNHB EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event CEJKOKAHCJG GOMCPIIALCH;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event CEJKOKAHCJG KNBPNKNELBJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event KFNJEADEOOD OLAGEKEIEFG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action DEIDEILNFOA;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action GHDCKGFKHCC;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<LJEEPNBNNHB> DMOBOFFADLE;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<LJEEPNBNNHB> CINCKADPPGC;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action JPDIHOFJFAI;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<LJEEPNBNNHB> IHFECPECMPL;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MMADMDAOMMK(LJEEPNBNNHB KGHLFFBGAIM, bool DCIOAOCCLNO = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OLJDHFEMIEM
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 CHBOEELJBMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 EHOGFCCMBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOFFLJFDKEL(LJEEPNBNNHB BMBBFJPOJEB, object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANLGKCFDEGE(object EOCJCEFCOOA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IGANODCOKHB
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 MPKDNNPCOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 MLGKNLKHOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float CNPKCGDBOHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float FKLAKHONCEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 GLAIIHKCPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion IFMMPIPGKAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event CEJKOKAHCJG PPJCEIJIBEP;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BJNIMHBPEJI((Quaternion rot, Vector3 moments) CKEJAFLIMPB);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MPNLKLPFHHL();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KJDIAFCJJIF();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JONIHJFPCDA();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MBFMCBMPPJM(Rigidbody AMBNMKKFJOP);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LFEIJDEHHMF();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HAPDGEOPNLL
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJMDLPKCJOP();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGEPFNEICCP(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HGCOKOEFMOK(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HOJGFBCHDEJ(LJEEPNBNNHB NKIPNFFBDAI);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ICGJKBEJBIA(LJEEPNBNNHB NKIPNFFBDAI);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OMOOHCBNEBJ();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IACJBDKKNDH
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool PBLHJBGBIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event CEJKOKAHCJG IDADILKKDPK;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DCIFLICONLL(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KGHICEPBNMM(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PAIMJFADCAB(object EOCJCEFCOOA, bool MCDOCGGGECM);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BPPFGEIDBGG(Rigidbody KLDLKACCMKB);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MBFMCBMPPJM(Rigidbody AMBNMKKFJOP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ENODCFCBNKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool GGCJPCDEOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool OMMEKKCNHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event CEJKOKAHCJG HFEDDJKAHPB;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PJMDLPKCJOP();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HCJFHFKIFCI(LJEEPNBNNHB BMBBFJPOJEB);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BFJIHMPHLJA(LJEEPNBNNHB BMBBFJPOJEB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EJDCPCDIDOH
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool FKLLLKFDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool BHGJNLBILDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints OFGMKLMDGHD
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
	void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MBFMCBMPPJM(Rigidbody AMBNMKKFJOP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BNEAKDEKEGF
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float LGIGFNNJAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float JJGEJCPKFBN
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
	void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MBFMCBMPPJM(Rigidbody AMBNMKKFJOP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JKJFHGFNKMI
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event CEJKOKAHCJG PDPOOKEFDLO;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJMDLPKCJOP();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DBEPKAHMKBC();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HACGNHECFOP();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NMFKFBHACCD();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IMKIFNNMNLM();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DENFDBJHBLN();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LCNNLPJHPDO
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody DHIIHPKBDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool KLCPPBHBKKE
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJMDLPKCJOP();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CDBCEDMLJNK(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OLCAAIPHEIP(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IGNDFADNBMI();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HAOKEBMAJGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	GCCHGDAONKB GLMHBPJHKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	LIJOKMDFOFH MCJHNAIMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 JGCPBAEFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 PCBLAEINONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 DOJOOKOADMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 NNHDGLHBCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float OBLJBMFPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool BOOAKEKDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PJMDLPKCJOP();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KBNPIHBKMOE(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LDGDMKCOGAH(JCBCIKFMAML KEJNJHGGNMJ, Vector3 BJMFJJKFMAF, float EEDKOLOOPKK = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OEHCHBFDEKM(CJOGEGMLKDO OEJNBMLJOIB, Vector3 NBOECIFPPEF, float AHEAGOIPKJF, float CNMGOEBKPGK = 8f, float IMBABICPDKH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JLBJDDHJOHM(JCBCIKFMAML KEJNJHGGNMJ, Vector3 LCDJINCAHMD, float ONOCCGOPHEL = 7f, float BKJDNLFEDGK = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PMEPFJEJIDK();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CELBLPAFCIH();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JOFNHGFIFKE();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void FOFMMMJGGFN();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 IGGKIKFINPM(Vector3 GPJLHMNPICC);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NLMCONACPDB(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void ADFDPALOCLC(Vector3 HGGENDDBBJC);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CHAAMCPOLKD(Vector3 JNININDALMJ, Vector3 IGMBCDNHIBE);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FLNMHLJEABK(Vector3 HFOBNBKELJL, Vector3 MHBEFOAKJDN);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 EHACCJENFAB(Vector3 NOGFFKGBCOL);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 CMIOFOLPDBD(Vector3 FIMFMOJFCFJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface EHBLFKODNKE
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool FIECHMOMELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADBPMMDCIBO(string GGEHLADLJHF);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PIIAHKDDIIC(RigidbodyEx NKIPNFFBDAI, Action ENGMCBPHJGL);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PPLBJOKIONH PKHLDNDKAPD(int JHPGGLNJBKI);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLAMPJKFAGP(Vector3 GNEGFFPGDPL, float DAIEBPJKGPB, Color KIJNHGNFMMA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
public interface NGLPLNHDEND
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	EHBLFKODNKE KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	CHMPPNFIFLC KKACPIKCPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LJEEPNBNNHB BAEHCLHNCHB(RigidbodyEx NKIPNFFBDAI, KPFNKPJMKHJ LINJEFIAFHO);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AKECFCILGBG : LJEEPNBNNHB, IDisposable, AJGKJECLEJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly NGLPLNHDEND GOHDOKCJOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal OBLCMNIHHPA DBOIGEKAFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal HAPDGEOPNLL FANNGNIOCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal ENODCFCBNKN BMDCCBCAAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal HAOKEBMAJGF GPJLHMNPICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal OLJDHFEMIEM HKNMHILHHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal IGANODCOKHB NILIHCCOBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal BNEAKDEKEGF NFCLKMJDHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal CJGADINNADB JGDDDOFNDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal JKJFHGFNKMI KHHCFHADAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal BBELJPEBCDG NBBLFMLBODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal IACJBDKKNDH DJBLNLFBMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal MPONMNOKEDF AMNFMCIBNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal EJDCPCDIDOH FLGEPILEMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal LCNNLPJHPDO AMBNMKKFJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal KHFOMKPIPGM GIIGHEGGDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable PLNPPJLAGEE;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public GABGGJOAGAC KBDICEKIIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "22")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public HJKEDKBDPPP AKJLGFMEBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x85FDF0", Offset = "0x85E5F0", VA = "0x18085FDF0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x85FD70", Offset = "0x85E570", VA = "0x18085FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject BGONLCODLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9E66A0", Offset = "0x9E4EA0", VA = "0x1809E66A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9C5320", Offset = "0x9C3B20", VA = "0x1809C5320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform IKKMMCBJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6F205C0", Offset = "0x6F1EDC0", VA = "0x186F205C0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody DHIIHPKBDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F820", Offset = "0x6F1E020", VA = "0x186F1F820", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public LJEEPNBNNHB EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6F22780", Offset = "0x6F20F80", VA = "0x186F22780", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6F24D10", Offset = "0x6F23510", VA = "0x186F24D10", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int DGFFNAGFKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6F242D0", Offset = "0x6F22AD0", VA = "0x186F242D0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public LJEEPNBNNHB DHCIAOJNIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6F22730", Offset = "0x6F20F30", VA = "0x186F22730", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool KIMLMAODMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FC50", Offset = "0x6F1E450", VA = "0x186F1FC50", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool GGCJPCDEOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FDB0", Offset = "0x6F1E5B0", VA = "0x186F1FDB0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool OMMEKKCNHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6F24B80", Offset = "0x6F23380", VA = "0x186F24B80", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public GCCHGDAONKB GLMHBPJHKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6F23220", Offset = "0x6F21A20", VA = "0x186F23220", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6F21C00", Offset = "0x6F20400", VA = "0x186F21C00", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public LIJOKMDFOFH MCJHNAIMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6F24DC0", Offset = "0x6F235C0", VA = "0x186F24DC0", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6F24020", Offset = "0x6F22820", VA = "0x186F24020", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float OBLJBMFPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6F227F0", Offset = "0x6F20FF0", VA = "0x186F227F0", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6F21A30", Offset = "0x6F20230", VA = "0x186F21A30", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 PCBLAEINONF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6F22E90", Offset = "0x6F21690", VA = "0x186F22E90", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6F201A0", Offset = "0x6F1E9A0", VA = "0x186F201A0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 NNHDGLHBCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6F21090", Offset = "0x6F1F890", VA = "0x186F21090", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6F21620", Offset = "0x6F1FE20", VA = "0x186F21620", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 JGCPBAEFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6F24990", Offset = "0x6F23190", VA = "0x186F24990", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6F22D10", Offset = "0x6F21510", VA = "0x186F22D10", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 DOJOOKOADMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6F24530", Offset = "0x6F22D30", VA = "0x186F24530", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6F20430", Offset = "0x6F1EC30", VA = "0x186F20430", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool GFHIPOLMMFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6F20280", Offset = "0x6F1EA80", VA = "0x186F20280", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool FGNIPGKHKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6F240E0", Offset = "0x6F228E0", VA = "0x186F240E0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool DKNNPMBIPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6F23B10", Offset = "0x6F22310", VA = "0x186F23B10", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool BOOAKEKDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6F22370", Offset = "0x6F20B70", VA = "0x186F22370", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 CHBOEELJBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6F20A40", Offset = "0x6F1F240", VA = "0x186F20A40", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 EHOGFCCMBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6F24390", Offset = "0x6F22B90", VA = "0x186F24390", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 MPKDNNPCOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F236E0", Offset = "0x6F21EE0", VA = "0x186F236E0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F20B10", Offset = "0x6F1F310", VA = "0x186F20B10", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 MLGKNLKHOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F21CB0", Offset = "0x6F204B0", VA = "0x186F21CB0", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float CNPKCGDBOHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F24E10", Offset = "0x6F23610", VA = "0x186F24E10", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float FKLAKHONCEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F22320", Offset = "0x6F20B20", VA = "0x186F22320", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F1EE70", Offset = "0x6F1D670", VA = "0x186F1EE70", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 GLAIIHKCPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F21850", Offset = "0x6F20050", VA = "0x186F21850", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion IFMMPIPGKAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F22A20", Offset = "0x6F21220", VA = "0x186F22A20", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float LGIGFNNJAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F20650", Offset = "0x6F1EE50", VA = "0x186F20650", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F21980", Offset = "0x6F20180", VA = "0x186F21980", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float JJGEJCPKFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FD60", Offset = "0x6F1E560", VA = "0x186F1FD60", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F22AF0", Offset = "0x6F212F0", VA = "0x186F22AF0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool FLNDLEBMONH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F219E0", Offset = "0x6F201E0", VA = "0x186F219E0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F206A0", Offset = "0x6F1EEA0", VA = "0x186F206A0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public EEPBOLJHLNK MCAKOHHFPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F23FD0", Offset = "0x6F227D0", VA = "0x186F23FD0", Slot = "68")]
		get
		{
			return default(EEPBOLJHLNK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F22900", Offset = "0x6F21100", VA = "0x186F22900", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool PBLHJBGBIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F24A70", Offset = "0x6F23270", VA = "0x186F24A70", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform NFGKEMNGCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F239E0", Offset = "0x6F221E0", VA = "0x186F239E0", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 EPEMKAANOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F940", Offset = "0x6F1E140", VA = "0x186F1F940", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F22840", Offset = "0x6F21040", VA = "0x186F22840", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float DLMMKBPCBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F220", Offset = "0x6F1DA20", VA = "0x186F1F220", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F237C0", Offset = "0x6F21FC0", VA = "0x186F237C0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float JDLKEDGCFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F23BF0", Offset = "0x6F223F0", VA = "0x186F23BF0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F21520", Offset = "0x6F1FD20", VA = "0x186F21520", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion KHCNENJLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F223C0", Offset = "0x6F20BC0", VA = "0x186F223C0", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F20700", Offset = "0x6F1EF00", VA = "0x186F20700", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 PCKAHHMDECP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F21C60", Offset = "0x6F20460", VA = "0x186F21C60", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F24140", Offset = "0x6F22940", VA = "0x186F24140", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion ACLOFDCFLFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F21000", Offset = "0x6F1F800", VA = "0x186F21000", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F234A0", Offset = "0x6F21CA0", VA = "0x186F234A0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints OFGMKLMDGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FD10", Offset = "0x6F1E510", VA = "0x186F1FD10", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F22960", Offset = "0x6F21160", VA = "0x186F22960", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool FKLLLKFDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F6C0", Offset = "0x6F1DEC0", VA = "0x186F1F6C0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F23160", Offset = "0x6F21960", VA = "0x186F23160", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode AIBPEFBJHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F21040", Offset = "0x6F1F840", VA = "0x186F21040", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6F24E60", Offset = "0x6F23660", VA = "0x186F24E60", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool CBCMAKKEDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F24190", Offset = "0x6F22990", VA = "0x186F24190", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool HJFGMLFHNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FEE0", Offset = "0x6F1E6E0", VA = "0x186F1FEE0", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event CEJKOKAHCJG GOMCPIIALCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6F23830", Offset = "0x6F22030", VA = "0x186F23830", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F160", Offset = "0x6F1D960", VA = "0x186F1F160", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event CEJKOKAHCJG KNBPNKNELBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6F246D0", Offset = "0x6F22ED0", VA = "0x186F246D0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6F21170", Offset = "0x6F1F970", VA = "0x186F21170", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event KFNJEADEOOD OLAGEKEIEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6F214C0", Offset = "0x6F1FCC0", VA = "0x186F214C0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6F24610", Offset = "0x6F22E10", VA = "0x186F24610", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event CEJKOKAHCJG HFEDDJKAHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6F231C0", Offset = "0x6F219C0", VA = "0x186F231C0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6F24080", Offset = "0x6F22880", VA = "0x186F24080", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event CEJKOKAHCJG LALHICAPNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6F23050", Offset = "0x6F21850", VA = "0x186F23050", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6F21DF0", Offset = "0x6F205F0", VA = "0x186F21DF0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event CEJKOKAHCJG PDPOOKEFDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F23A60", Offset = "0x6F22260", VA = "0x186F23A60", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F217F0", Offset = "0x6F1FFF0", VA = "0x186F217F0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<FHBBMPGGCGD, FHBBMPGGCGD> MDHINEPAAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F1C0", Offset = "0x6F1D9C0", VA = "0x186F1F1C0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F229C0", Offset = "0x6F211C0", VA = "0x186F229C0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event CEJKOKAHCJG IDADILKKDPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F23440", Offset = "0x6F21C40", VA = "0x186F23440", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F24B20", Offset = "0x6F23320", VA = "0x186F24B20", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event CEJKOKAHCJG HCDKLCFJLOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F23630", Offset = "0x6F21E30", VA = "0x186F23630", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F22B50", Offset = "0x6F21350", VA = "0x186F22B50", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6F24F00", Offset = "0x6F23700", VA = "0x186F24F00")]
	public AKECFCILGBG(GameObject NBDLDMDNCAL, RigidbodyEx EFJFPKJHPOE, NGLPLNHDEND GOHDOKCJOFP, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6F211D0", Offset = "0x6F1F9D0", VA = "0x186F211D0", Slot = "136")]
	protected virtual void FBGPFOOCPOG(NGLPLNHDEND GOHDOKCJOFP, KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6F20D50", Offset = "0x6F1F550", VA = "0x186F20D50", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6F24BD0", Offset = "0x6F233D0", VA = "0x186F24BD0", Slot = "91")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6F21930", Offset = "0x6F20130", VA = "0x186F21930", Slot = "92")]
	public void NFLKBJHAPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6F227D0", Offset = "0x6F20FD0", VA = "0x186F227D0", Slot = "93")]
	public void IKNKANAKDJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6F233C0", Offset = "0x6F21BC0", VA = "0x186F233C0")]
	private void LFENBOKJKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FE00", Offset = "0x6F1E600", VA = "0x186F1FE00", Slot = "30")]
	public LJEEPNBNNHB BPLEDEIPGKB(int DHNLEFJCEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6F239F0", Offset = "0x6F221F0", VA = "0x186F239F0", Slot = "95")]
	public void MMADMDAOMMK(LJEEPNBNNHB JMDCGOKJIDA, bool DCIOAOCCLNO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6F21D90", Offset = "0x6F20590", VA = "0x186F21D90", Slot = "96")]
	public void GMBDJPNPBNI(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6F202D0", Offset = "0x6F1EAD0", VA = "0x186F202D0", Slot = "97")]
	public void CICBOHHFGOI(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6F20330", Offset = "0x6F1EB30", VA = "0x186F20330", Slot = "98")]
	public Vector3 CMIOFOLPDBD(Vector3 FIMFMOJFCFJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6F20F00", Offset = "0x6F1F700", VA = "0x186F20F00", Slot = "99")]
	public Vector3 EHACCJENFAB(Vector3 NOGFFKGBCOL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6F21930", Offset = "0x6F20130", VA = "0x186F21930", Slot = "100")]
	public void FOFMMMJGGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6F20060", Offset = "0x6F1E860", VA = "0x186F20060", Slot = "101")]
	public void CELBLPAFCIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6F24D70", Offset = "0x6F23570", VA = "0x186F24D70", Slot = "102")]
	public void PMEPFJEJIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6F21700", Offset = "0x6F1FF00", VA = "0x186F21700", Slot = "103")]
	public void FLNMHLJEABK(Vector3 HFOBNBKELJL, Vector3 MHBEFOAKJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6F200B0", Offset = "0x6F1E8B0", VA = "0x186F200B0", Slot = "104")]
	public void CHAAMCPOLKD(Vector3 JNININDALMJ, Vector3 IGMBCDNHIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EED0", Offset = "0x6F1D6D0", VA = "0x186F1EED0", Slot = "105")]
	public void ADFDPALOCLC(Vector3 HGGENDDBBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6F24470", Offset = "0x6F22C70", VA = "0x186F24470", Slot = "106")]
	public void OEHCHBFDEKM(CJOGEGMLKDO OEJNBMLJOIB, Vector3 NBOECIFPPEF, float AHEAGOIPKJF, float CNMGOEBKPGK = 8f, float IMBABICPDKH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6F23270", Offset = "0x6F21A70", VA = "0x186F23270", Slot = "107")]
	public void LDGDMKCOGAH(JCBCIKFMAML KEJNJHGGNMJ, Vector3 BJMFJJKFMAF, float EEDKOLOOPKK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6F22C00", Offset = "0x6F21400", VA = "0x186F22C00", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JLBJDDHJOHM(JCBCIKFMAML KEJNJHGGNMJ, Vector3 LCDJINCAHMD, float ONOCCGOPHEL = 7f, float BKJDNLFEDGK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6F22570", Offset = "0x6F20D70", VA = "0x186F22570", Slot = "109")]
	public Vector3 IGGKIKFINPM(Vector3 JMDCGOKJIDA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EFB0", Offset = "0x6F1D7B0", VA = "0x186F1EFB0", Slot = "110")]
	public Vector3 AGLJKLOFAKO(Vector3 JMDCGOKJIDA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6F22DF0", Offset = "0x6F215F0", VA = "0x186F22DF0", Slot = "111")]
	public void JOFNHGFIFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6F235C0", Offset = "0x6F21DC0", VA = "0x186F235C0", Slot = "112")]
	public void MCGHHLGPCDO(LJEEPNBNNHB KNDIPAMGJEH, object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EE10", Offset = "0x6F1D610", VA = "0x186F1EE10", Slot = "113")]
	public void ABPOJCBHDFP(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FB70", Offset = "0x6F1E370", VA = "0x186F1FB70", Slot = "61")]
	public void BJNIMHBPEJI((Quaternion rot, Vector3 moments) CKEJAFLIMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F23110", Offset = "0x6F21910", VA = "0x186F23110", Slot = "114")]
	public void KJDIAFCJJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F23AC0", Offset = "0x6F222C0", VA = "0x186F23AC0", Slot = "115")]
	public void MPNLKLPFHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F22E40", Offset = "0x6F21640", VA = "0x186F22E40", Slot = "116")]
	public void JONIHJFPCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F20510", Offset = "0x6F1ED10", VA = "0x186F20510", Slot = "117")]
	public bool DBEPKAHMKBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F24340", Offset = "0x6F22B40", VA = "0x186F24340", Slot = "94")]
	public void NMFKFBHACCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F207F0", Offset = "0x6F1EFF0", VA = "0x186F207F0", Slot = "118")]
	public void DENFDBJHBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F20560", Offset = "0x6F1ED60", VA = "0x186F20560", Slot = "119")]
	public void DCIFLICONLL(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F230B0", Offset = "0x6F218B0", VA = "0x186F230B0", Slot = "120")]
	public void KGHICEPBNMM(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F24920", Offset = "0x6F23120", VA = "0x186F24920", Slot = "121")]
	public void PAIMJFADCAB(object EOCJCEFCOOA, bool MCDOCGGGECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F20840", Offset = "0x6F1F040", VA = "0x186F20840", Slot = "122")]
	public void DKOHPMAPHGG(Vector3 BELOINIPDIB, Quaternion HJPFNIDEMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F23890", Offset = "0x6F22090", VA = "0x186F23890", Slot = "123")]
	public void MLABCGDNEEH(Vector3 LEDGGONKHOH, Quaternion GNOJHHCJPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F24AC0", Offset = "0x6F232C0", VA = "0x186F24AC0", Slot = "124")]
	public bool PGOKKFJFMGD(float BONLJCBABLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FCB0", Offset = "0x6F1E4B0", VA = "0x186F1FCB0", Slot = "125")]
	public void BKONGIFNHPB(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F20CF0", Offset = "0x6F1F4F0", VA = "0x186F20CF0", Slot = "126")]
	public void DNKOPNCBMHI(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FE80", Offset = "0x6F1E680", VA = "0x186F1FE80", Slot = "127")]
	public void CDBCEDMLJNK(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F24670", Offset = "0x6F22E70", VA = "0x186F24670", Slot = "128")]
	public void OLCAAIPHEIP(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F22F70", Offset = "0x6F21770", VA = "0x186F22F70", Slot = "129")]
	public void KAPGLCIGOAI(Vector3 AMNFMCIBNPO, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F240", Offset = "0x6F1DA40", VA = "0x186F1F240", Slot = "130")]
	public void APEKDDPMJIA(Vector3 AMNFMCIBNPO, Vector3 HGDCPNGLIKJ, ForceMode HAMIBHDKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F234E0", Offset = "0x6F21CE0", VA = "0x186F234E0", Slot = "131")]
	public void LPEOIJLIBJD(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F22240", Offset = "0x6F20A40", VA = "0x186F22240", Slot = "132")]
	public void HDLFPCCLPMC(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F20BF0", Offset = "0x6F1F3F0", VA = "0x186F20BF0", Slot = "133")]
	public bool DLPAKOEIMOE(Vector3 FCBGHELDCII, [Out] RaycastHit MGGIMCBEOEH, float BKKDIDJOENO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F23370", Offset = "0x6F21B70", VA = "0x186F23370", Slot = "134")]
	public void LFEIJDEHHMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F24EC0", Offset = "0x6F236C0", VA = "0x186F24EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F20E20", Offset = "0x6F1F620", VA = "0x186F20E20")]
	private void EBODCBMBMPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F710", Offset = "0x6F1DF10", VA = "0x186F1F710")]
	private void BBEEPJFMBJD(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F24730", Offset = "0x6F22F30", VA = "0x186F24730")]
	private void ONHAKDBCCNG(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F0B0", Offset = "0x6F1D8B0", VA = "0x186F1F0B0")]
	private void AHFEECKILMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F22470", Offset = "0x6F20C70", VA = "0x186F22470")]
	private void IDDFEBGHOBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F9F0", Offset = "0x6F1E1F0", VA = "0x186F1F9F0")]
	private void BIAKALOJJNG(LJEEPNBNNHB LKNDHCECGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F22170", Offset = "0x6F20970", VA = "0x186F22170")]
	private void HCJFHFKIFCI(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F870", Offset = "0x6F1E070", VA = "0x186F1F870")]
	private void BFJIHMPHLJA(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F21A90", Offset = "0x6F20290", VA = "0x186F21A90")]
	private void GFFAHDGIPGI(HJKEDKBDPPP BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F23C10", Offset = "0x6F22410", VA = "0x186F23C10", Slot = "141")]
	protected virtual void NEGBLOEOEHL(HJKEDKBDPPP NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F21E50", Offset = "0x6F20650", VA = "0x186F21E50")]
	protected void HBKMAEIMBKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F350", Offset = "0x6F1DB50", VA = "0x186F1F350")]
	protected void BACAJBCAJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F22670", Offset = "0x6F20E70", VA = "0x186F22670", Slot = "142")]
	protected virtual IDisposable IHIINBLEBOJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class FECCMDOKBJL
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F26640", Offset = "0x6F24E40", VA = "0x186F26640")]
	public static LJEEPNBNNHB BDBBMKBAFNB(this LJEEPNBNNHB NKIPNFFBDAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F26780", Offset = "0x6F24F80", VA = "0x186F26780")]
	public static bool IINKAPCDGDI(this LJEEPNBNNHB NKIPNFFBDAI, LJEEPNBNNHB KPIPNJDNJNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F26800", Offset = "0x6F25000", VA = "0x186F26800")]
	public static bool PKOHNLBLMCB(this LJEEPNBNNHB NKIPNFFBDAI, LJEEPNBNNHB NIOHKOJCMDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F26880", Offset = "0x6F25080", VA = "0x186F26880")]
	public static HJKEDKBDPPP PNBIPFIMHIE(this LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F26700", Offset = "0x6F24F00", VA = "0x186F26700")]
	public static AKECFCILGBG DIMEOMPBOHJ(this LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DOJNMGBCOPL : CHMPPNFIFLC
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F258D0", Offset = "0x6F240D0", VA = "0x186F258D0", Slot = "19")]
	public LJEEPNBNNHB BAEHCLHNCHB(RigidbodyEx NKIPNFFBDAI, KPFNKPJMKHJ LINJEFIAFHO, NGLPLNHDEND GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "4")]
	public OBLCMNIHHPA AKEKIEBHBJM(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "5")]
	public HAOKEBMAJGF BDMGOHHJINE(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "6")]
	public OLJDHFEMIEM HAPBJDJMOKP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "7")]
	public BNEAKDEKEGF IJMKDLBCPMP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "8")]
	public JKJFHGFNKMI HPEKAGMBJOF(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "9")]
	public BBELJPEBCDG KJDJCCIJHCL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "10")]
	public IACJBDKKNDH OKCGHCGAIAG(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "11")]
	public MPONMNOKEDF IOLKGNHHCJA(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "12")]
	public KHFOMKPIPGM LBHINPABMFD(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "13")]
	public CJGADINNADB KHOAHPFHAGL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0")]
	public LCNNLPJHPDO KKNJHPKAHML(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0")]
	public ENODCFCBNKN BDCEKGMLOAH(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0")]
	public HAPDGEOPNLL JEELHNMABOD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0")]
	public IGANODCOKHB NCBDCBPKBEJ(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0")]
	public EJDCPCDIDOH DPMMFGFJGFD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public DOJNMGBCOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "14")]
	private LCNNLPJHPDO GHAOFICPAOL(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "15")]
	private ENODCFCBNKN PJEBCMEGNBI(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "16")]
	private HAPDGEOPNLL GDLIICLCEIA(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "17")]
	private IGANODCOKHB EDAECLKGAIE(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "18")]
	private EJDCPCDIDOH LLKPDMIAJMM(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[OMGHGEFADHA(typeof(CHMPPNFIFLC), new string[] { })]
public class PPBCEGBKCOC : CHMPPNFIFLC, CEFKIMLFJCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly CHMPPNFIFLC EIGAEJHONMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly CHMPPNFIFLC FJMAFAKODJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private AMHKPPIPMFB JDGOCFMKIOM;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private CHMPPNFIFLC KKACPIKCPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6F32BC0", Offset = "0x6F313C0", VA = "0x186F32BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6F332B0", Offset = "0x6F31AB0", VA = "0x186F332B0", Slot = "20")]
	public void InitReferences(GANFHFOELEK FGDLGNMCKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6F329D0", Offset = "0x6F311D0", VA = "0x186F329D0", Slot = "4")]
	public OBLCMNIHHPA AKEKIEBHBJM(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6F32CD0", Offset = "0x6F314D0", VA = "0x186F32CD0", Slot = "5")]
	public HAOKEBMAJGF BDMGOHHJINE(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6F33030", Offset = "0x6F31830", VA = "0x186F33030", Slot = "6")]
	public OLJDHFEMIEM HAPBJDJMOKP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6F33170", Offset = "0x6F31970", VA = "0x186F33170", Slot = "7")]
	public BNEAKDEKEGF IJMKDLBCPMP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6F330D0", Offset = "0x6F318D0", VA = "0x186F330D0", Slot = "8")]
	public JKJFHGFNKMI HPEKAGMBJOF(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6F333A0", Offset = "0x6F31BA0", VA = "0x186F333A0", Slot = "9")]
	public BBELJPEBCDG KJDJCCIJHCL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6F334E0", Offset = "0x6F31CE0", VA = "0x186F334E0", Slot = "10")]
	public IACJBDKKNDH OKCGHCGAIAG(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6F33210", Offset = "0x6F31A10", VA = "0x186F33210", Slot = "11")]
	public MPONMNOKEDF IOLKGNHHCJA(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6F33440", Offset = "0x6F31C40", VA = "0x186F33440", Slot = "12")]
	public KHFOMKPIPGM LBHINPABMFD(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6F33300", Offset = "0x6F31B00", VA = "0x186F33300", Slot = "13")]
	public CJGADINNADB KHOAHPFHAGL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6F32F80", Offset = "0x6F31780", VA = "0x186F32F80")]
	public LCNNLPJHPDO KKNJHPKAHML(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6F32C20", Offset = "0x6F31420", VA = "0x186F32C20")]
	public ENODCFCBNKN BDCEKGMLOAH(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6F32ED0", Offset = "0x6F316D0", VA = "0x186F32ED0")]
	public HAPDGEOPNLL JEELHNMABOD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F32E20", Offset = "0x6F31620", VA = "0x186F32E20")]
	public IGANODCOKHB NCBDCBPKBEJ(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F32D70", Offset = "0x6F31570", VA = "0x186F32D70")]
	public EJDCPCDIDOH DPMMFGFJGFD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6F32A70", Offset = "0x6F31270", VA = "0x186F32A70", Slot = "19")]
	public LJEEPNBNNHB BAEHCLHNCHB(RigidbodyEx NKIPNFFBDAI, KPFNKPJMKHJ LINJEFIAFHO, NGLPLNHDEND GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6F33580", Offset = "0x6F31D80", VA = "0x186F33580")]
	public PPBCEGBKCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6F32F80", Offset = "0x6F31780", VA = "0x186F32F80", Slot = "14")]
	private LCNNLPJHPDO GHAOFICPAOL(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6F32C20", Offset = "0x6F31420", VA = "0x186F32C20", Slot = "15")]
	private ENODCFCBNKN PJEBCMEGNBI(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6F32ED0", Offset = "0x6F316D0", VA = "0x186F32ED0", Slot = "16")]
	private HAPDGEOPNLL GDLIICLCEIA(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6F32E20", Offset = "0x6F31620", VA = "0x186F32E20", Slot = "17")]
	private IGANODCOKHB EDAECLKGAIE(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6F32D70", Offset = "0x6F31570", VA = "0x186F32D70", Slot = "18")]
	private EJDCPCDIDOH LLKPDMIAJMM(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MEAPDLKKDPD : OBLCMNIHHPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGJHIGDGICA(LJEEPNBNNHB NKIPNFFBDAI);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMFKCEMIMAH(LJEEPNBNNHB NKIPNFFBDAI);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MMINCMFEKID(LJEEPNBNNHB LKNDHCECGJG);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AAKBDKKNEBM(LJEEPNBNNHB LKNDHCECGJG);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DDOICKAOEBC : OLJDHFEMIEM
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	BDHOMIPIJNO<LJEEPNBNNHB> IDFEKHKGFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	LJEEPNBNNHB BBIBDDHIDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PJBKBEOGOFN : IGANODCOKHB
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) BJEDCAPDABC(Rigidbody POEMMNMNOEI);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface IKKOJINNDFI : ENODCFCBNKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView LOLDDNOAIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class FABNLOPBJEE : KHFOMKPIPGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly AKECFCILGBG NKIPNFFBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode KDHFGAKGJLC;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody DHIIHPKBDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D540", Offset = "0x6F1BD40", VA = "0x186F1D540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode AIBPEFBJHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6F26280", Offset = "0x6F24A80", VA = "0x186F26280", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6F265D0", Offset = "0x6F24DD0", VA = "0x186F265D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E080", Offset = "0x6F1C880", VA = "0x186F1E080")]
	public FABNLOPBJEE(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F264C0", Offset = "0x6F24CC0", VA = "0x186F264C0", Slot = "6")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6F260A0", Offset = "0x6F248A0", VA = "0x186F260A0", Slot = "9")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6F26090", Offset = "0x6F24890", VA = "0x186F26090", Slot = "7")]
	public void ANGDFDOOLIM(bool JMEEMLNLABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6F26390", Offset = "0x6F24B90", VA = "0x186F26390", Slot = "8")]
	public void FOOFBKMEGCH(bool JMEEMLNLABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6F26120", Offset = "0x6F24920", VA = "0x186F26120", Slot = "10")]
	public bool DLPAKOEIMOE(Vector3 FCBGHELDCII, [Out] RaycastHit MGGIMCBEOEH, float BKKDIDJOENO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6F263A0", Offset = "0x6F24BA0", VA = "0x186F263A0")]
	private void KMDOAKFEKCO(bool JMEEMLNLABH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FNPLKLIGBGF : BBELJPEBCDG, IDisposable, BKOBFDPOEOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly AKECFCILGBG NKIPNFFBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private EEPBOLJHLNK BNPFFFLOCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private PPLBJOKIONH NFLDBIEMONH;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public EEPBOLJHLNK MCAKOHHFPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A220", Offset = "0x6F28A20", VA = "0x186F2A220", Slot = "6")]
		get
		{
			return default(EEPBOLJHLNK);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A0A0", Offset = "0x6F288A0", VA = "0x186F2A0A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform OOHDDHCJCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A080", Offset = "0x6F28880", VA = "0x186F2A080", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<FHBBMPGGCGD, FHBBMPGGCGD> MDHINEPAAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6F29F80", Offset = "0x6F28780", VA = "0x186F29F80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A170", Offset = "0x6F28970", VA = "0x186F2A170", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A5F0", Offset = "0x6F28DF0", VA = "0x186F2A5F0")]
	public FNPLKLIGBGF(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A370", Offset = "0x6F28B70", VA = "0x186F2A370", Slot = "8")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A030", Offset = "0x6F28830", VA = "0x186F2A030", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x978E50", Offset = "0x977650", VA = "0x180978E50", Slot = "11")]
	private void KJBJEIDMPPE(FHBBMPGGCGD KMCHIMPGNCP, FHBBMPGGCGD BNADEAHLELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "12")]
	private void NIMFPOEIGLH(bool ILLAIMLPMFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LCNLKIDNKBB : CHMPPNFIFLC
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F170", Offset = "0x6F2D970", VA = "0x186F2F170", Slot = "4")]
	public OBLCMNIHHPA AKEKIEBHBJM(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F510", Offset = "0x6F2DD10", VA = "0x186F2F510", Slot = "5")]
	public HAOKEBMAJGF BDMGOHHJINE(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FB30", Offset = "0x6F2E330", VA = "0x186F2FB30", Slot = "6")]
	public OLJDHFEMIEM HAPBJDJMOKP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FD30", Offset = "0x6F2E530", VA = "0x186F2FD30", Slot = "7")]
	public BNEAKDEKEGF IJMKDLBCPMP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FC60", Offset = "0x6F2E460", VA = "0x186F2FC60", Slot = "8")]
	public JKJFHGFNKMI HPEKAGMBJOF(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FF30", Offset = "0x6F2E730", VA = "0x186F2FF30", Slot = "9")]
	public BBELJPEBCDG KJDJCCIJHCL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6F300C0", Offset = "0x6F2E8C0", VA = "0x186F300C0", Slot = "10")]
	public IACJBDKKNDH OKCGHCGAIAG(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FDB0", Offset = "0x6F2E5B0", VA = "0x186F2FDB0", Slot = "11")]
	public MPONMNOKEDF IOLKGNHHCJA(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6F30000", Offset = "0x6F2E800", VA = "0x186F30000", Slot = "12")]
	public KHFOMKPIPGM LBHINPABMFD(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FE70", Offset = "0x6F2E670", VA = "0x186F2FE70", Slot = "13")]
	public CJGADINNADB KHOAHPFHAGL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F9F0", Offset = "0x6F2E1F0", VA = "0x186F2F9F0")]
	public LCNNLPJHPDO KKNJHPKAHML(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F380", Offset = "0x6F2DB80", VA = "0x186F2F380")]
	public ENODCFCBNKN BDCEKGMLOAH(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F8C0", Offset = "0x6F2E0C0", VA = "0x186F2F8C0")]
	public HAPDGEOPNLL JEELHNMABOD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F720", Offset = "0x6F2DF20", VA = "0x186F2F720")]
	public IGANODCOKHB NCBDCBPKBEJ(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F640", Offset = "0x6F2DE40", VA = "0x186F2F640")]
	public EJDCPCDIDOH DPMMFGFJGFD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F260", Offset = "0x6F2DA60", VA = "0x186F2F260", Slot = "19")]
	public LJEEPNBNNHB BAEHCLHNCHB(RigidbodyEx NKIPNFFBDAI, KPFNKPJMKHJ LINJEFIAFHO, NGLPLNHDEND GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public LCNLKIDNKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F9F0", Offset = "0x6F2E1F0", VA = "0x186F2F9F0", Slot = "14")]
	private LCNNLPJHPDO GHAOFICPAOL(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F380", Offset = "0x6F2DB80", VA = "0x186F2F380", Slot = "15")]
	private ENODCFCBNKN PJEBCMEGNBI(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F8C0", Offset = "0x6F2E0C0", VA = "0x186F2F8C0", Slot = "16")]
	private HAPDGEOPNLL GDLIICLCEIA(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F720", Offset = "0x6F2DF20", VA = "0x186F2F720", Slot = "17")]
	private IGANODCOKHB EDAECLKGAIE(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F640", Offset = "0x6F2DE40", VA = "0x186F2F640", Slot = "18")]
	private EJDCPCDIDOH LLKPDMIAJMM(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class ACBPOFJKBCC : MPONMNOKEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly AKECFCILGBG NKIPNFFBDAI;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody DHIIHPKBDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D540", Offset = "0x6F1BD40", VA = "0x186F1D540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool PBLHJBGBIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DDD0", Offset = "0x6F1C5D0", VA = "0x186F1DDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool KIMLMAODMNF
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D590", Offset = "0x6F1BD90", VA = "0x186F1D590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private LJEEPNBNNHB EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D850", Offset = "0x6F1C050", VA = "0x186F1D850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E080", Offset = "0x6F1C880", VA = "0x186F1E080")]
	public ACBPOFJKBCC(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D8B0", Offset = "0x6F1C0B0", VA = "0x186F1D8B0", Slot = "4")]
	public void KAPGLCIGOAI(Vector3 AMNFMCIBNPO, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DE20", Offset = "0x6F1C620", VA = "0x186F1DE20")]
	private void PHBDKNPPCAL(Vector3 AMNFMCIBNPO, ForceMode HAMIBHDKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D2C0", Offset = "0x6F1BAC0", VA = "0x186F1D2C0", Slot = "5")]
	public void APEKDDPMJIA(Vector3 AMNFMCIBNPO, Vector3 HGDCPNGLIKJ, ForceMode HAMIBHDKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DA10", Offset = "0x6F1C210", VA = "0x186F1DA10", Slot = "6")]
	public void LPEOIJLIBJD(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DB70", Offset = "0x6F1C370", VA = "0x186F1DB70")]
	private void NDNOFKHGIEM(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D5F0", Offset = "0x6F1BDF0", VA = "0x186F1D5F0", Slot = "7")]
	public void HDLFPCCLPMC(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class APECLDGCONL : CJGADINNADB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly AKECFCILGBG NKIPNFFBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool GEOCOMMJHCI;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool FLNDLEBMONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x91FDA0", Offset = "0x91E5A0", VA = "0x18091FDA0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6F25000", Offset = "0x6F23800", VA = "0x186F25000", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E080", Offset = "0x6F1C880", VA = "0x186F1E080")]
	public APECLDGCONL(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6F24FD0", Offset = "0x6F237D0", VA = "0x186F24FD0", Slot = "6")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6F25110", Offset = "0x6F23910", VA = "0x186F25110", Slot = "7")]
	public void MBFMCBMPPJM(Rigidbody AMBNMKKFJOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class HHFBFHNOBOA : MEAPDLKKDPD, OBLCMNIHHPA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly LJEEPNBNNHB NKIPNFFBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<LJEEPNBNNHB> PANMICOBDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private LJEEPNBNNHB GFFCILHEGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private LJEEPNBNNHB BMBBFJPOJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform NDCJIHEJNKD;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform IKKMMCBJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6F2AD10", Offset = "0x6F29510", VA = "0x186F2AD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public LJEEPNBNNHB EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x856BA0", Offset = "0x8553A0", VA = "0x180856BA0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C620", Offset = "0x6F2AE20", VA = "0x186F2C620", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public LJEEPNBNNHB DHCIAOJNIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x856A90", Offset = "0x855290", VA = "0x180856A90", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<LJEEPNBNNHB> PLOBAPBGHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x856320", Offset = "0x854B20", VA = "0x180856320", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event CEJKOKAHCJG GOMCPIIALCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B880", Offset = "0x6F2A080", VA = "0x186F2B880", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6F2AB40", Offset = "0x6F29340", VA = "0x186F2AB40", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event CEJKOKAHCJG KNBPNKNELBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C580", Offset = "0x6F2AD80", VA = "0x186F2C580", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6F2AF70", Offset = "0x6F29770", VA = "0x186F2AF70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event KFNJEADEOOD OLAGEKEIEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B0D0", Offset = "0x6F298D0", VA = "0x186F2B0D0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C4E0", Offset = "0x6F2ACE0", VA = "0x186F2C4E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action DEIDEILNFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C250", Offset = "0x6F2AA50", VA = "0x186F2C250", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C2F0", Offset = "0x6F2AAF0", VA = "0x186F2C2F0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action GHDCKGFKHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C440", Offset = "0x6F2AC40", VA = "0x186F2C440", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B220", Offset = "0x6F29A20", VA = "0x186F2B220", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<LJEEPNBNNHB> DMOBOFFADLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B4F0", Offset = "0x6F29CF0", VA = "0x186F2B4F0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B440", Offset = "0x6F29C40", VA = "0x186F2B440", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<LJEEPNBNNHB> CINCKADPPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C390", Offset = "0x6F2AB90", VA = "0x186F2C390", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6F2AEC0", Offset = "0x6F296C0", VA = "0x186F2AEC0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action JPDIHOFJFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B360", Offset = "0x6F29B60", VA = "0x186F2B360", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B7E0", Offset = "0x6F29FE0", VA = "0x186F2B7E0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<LJEEPNBNNHB> IHFECPECMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B170", Offset = "0x6F29970", VA = "0x186F2B170", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6F2AD70", Offset = "0x6F29570", VA = "0x186F2AD70", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C6D0", Offset = "0x6F2AED0", VA = "0x186F2C6D0")]
	public HHFBFHNOBOA(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6F2AE20", Offset = "0x6F29620", VA = "0x186F2AE20", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B920", Offset = "0x6F2A120", VA = "0x186F2B920", Slot = "30")]
	public void MMADMDAOMMK(LJEEPNBNNHB KGHLFFBGAIM, bool DCIOAOCCLNO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6F2BEA0", Offset = "0x6F2A6A0", VA = "0x186F2BEA0", Slot = "6")]
	public void MMINCMFEKID(LJEEPNBNNHB LKNDHCECGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A8C0", Offset = "0x6F290C0", VA = "0x186F2A8C0", Slot = "7")]
	public void AAKBDKKNEBM(LJEEPNBNNHB LKNDHCECGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B5A0", Offset = "0x6F29DA0", VA = "0x186F2B5A0", Slot = "4")]
	public void LGJHIGDGICA(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C630", Offset = "0x6F2AE30", VA = "0x186F2C630", Slot = "5")]
	public void PMFKCEMIMAH(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B2C0", Offset = "0x6F29AC0", VA = "0x186F2B2C0")]
	private void HOPFFNNEJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B400", Offset = "0x6F29C00", VA = "0x186F2B400")]
	private void IHGHEGFMBLF(LJEEPNBNNHB LKNDHCECGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C110", Offset = "0x6F2A910", VA = "0x186F2C110")]
	private void NAIOIGCEJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6F2ABE0", Offset = "0x6F293E0", VA = "0x186F2ABE0")]
	private void CBAJHLGCLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B6B0", Offset = "0x6F29EB0", VA = "0x186F2B6B0")]
	private void LPOHGFPNNLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B010", Offset = "0x6F29810", VA = "0x186F2B010")]
	[CompilerGenerated]
	private object FAFLCHMBMGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class BLAGODCEGOH
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6F25250", Offset = "0x6F23A50", VA = "0x186F25250")]
	public static MEAPDLKKDPD HLKMCIAHGPB(this LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class OJPLLKCCNPL : DDOICKAOEBC, OLJDHFEMIEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly AKECFCILGBG NKIPNFFBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly BDHOMIPIJNO<LJEEPNBNNHB> ADADGLAJJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool LFHDGIFNEBH;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public BDHOMIPIJNO<LJEEPNBNNHB> IDFEKHKGFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 CHBOEELJBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6F31B70", Offset = "0x6F30370", VA = "0x186F31B70", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 EHOGFCCMBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6F32330", Offset = "0x6F30B30", VA = "0x186F32330", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 JGCPBAEFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6F324F0", Offset = "0x6F30CF0", VA = "0x186F324F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public LJEEPNBNNHB BBIBDDHIDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6F31AC0", Offset = "0x6F302C0", VA = "0x186F31AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6F325E0", Offset = "0x6F30DE0", VA = "0x186F325E0")]
	public OJPLLKCCNPL(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6F322C0", Offset = "0x6F30AC0", VA = "0x186F322C0", Slot = "8")]
	public void JOFFLJFDKEL(LJEEPNBNNHB BMBBFJPOJEB, object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6F31A60", Offset = "0x6F30260", VA = "0x186F31A60", Slot = "9")]
	public void ANLGKCFDEGE(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F31BA0", Offset = "0x6F303A0", VA = "0x186F31BA0")]
	private Vector3 FCDEPHNHPAB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6F31F30", Offset = "0x6F30730", VA = "0x186F31F30")]
	private void FEMBAJMCIGK(LJEEPNBNNHB BAMJAECANAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class LLCLGPOGBEE
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6F30D50", Offset = "0x6F2F550", VA = "0x186F30D50")]
	public static DDOICKAOEBC IEBJKOKAPBC(this LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class KOADCEMAONI : PJBKBEOGOFN, IGANODCOKHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly AKECFCILGBG NKIPNFFBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 BAMHKCIJGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 MMOGMLHFAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float NLILMFBCLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float MFLAEOCINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 OKJPOCNNKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? CKKOBMDHEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? PBLCAIBKDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool PFPOOGAGCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool BMNPMDNNGMM;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 MPKDNNPCOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xD71C80", Offset = "0xD70480", VA = "0x180D71C80", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DA20", Offset = "0x6F2C220", VA = "0x186F2DA20", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 MLGKNLKHOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DEA0", Offset = "0x6F2C6A0", VA = "0x186F2DEA0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float CNPKCGDBOHH
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8BE940", Offset = "0x8BD140", VA = "0x1808BE940", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E600", Offset = "0x6F2CE00", VA = "0x186F2E600")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float FKLAKHONCEG
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA50", Offset = "0x8BD250", VA = "0x1808BEA50", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C790", Offset = "0x6F2AF90", VA = "0x186F2C790", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 GLAIIHKCPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DD10", Offset = "0x6F2C510", VA = "0x186F2DD10", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion IFMMPIPGKAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E120", Offset = "0x6F2C920", VA = "0x186F2E120", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody DHIIHPKBDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C840", Offset = "0x6F2B040", VA = "0x186F2C840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event CEJKOKAHCJG PPJCEIJIBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6F2EDA0", Offset = "0x6F2D5A0", VA = "0x186F2EDA0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DAD0", Offset = "0x6F2C2D0", VA = "0x186F2DAD0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F010", Offset = "0x6F2D810", VA = "0x186F2F010")]
	public KOADCEMAONI(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E450", Offset = "0x6F2CC50", VA = "0x186F2E450", Slot = "17")]
	public void KJDIAFCJJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F2EE40", Offset = "0x6F2D640", VA = "0x186F2EE40", Slot = "16")]
	public void MPNLKLPFHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F2D940", Offset = "0x6F2C140", VA = "0x186F2D940", Slot = "19")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F2EBB0", Offset = "0x6F2D3B0", VA = "0x186F2EBB0", Slot = "20")]
	public void MBFMCBMPPJM(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E2A0", Offset = "0x6F2CAA0", VA = "0x186F2E2A0", Slot = "18")]
	public void JONIHJFPCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E710", Offset = "0x6F2CF10", VA = "0x186F2E710", Slot = "21")]
	public void LFEIJDEHHMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DA20", Offset = "0x6F2C220", VA = "0x186F2DA20")]
	private void DJLOHHFJMPH(Vector3 JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F2EF20", Offset = "0x6F2D720", VA = "0x186F2EF20")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 OFNHKOLKBOB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E600", Offset = "0x6F2CE00", VA = "0x186F2E600")]
	private void KLJCBMHBLJO(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C790", Offset = "0x6F2AF90", VA = "0x186F2C790")]
	private void FELHKLHIBFA(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DB70", Offset = "0x6F2C370", VA = "0x186F2DB70")]
	private Vector3 FEFNEPMKIHI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F2D710", Offset = "0x6F2BF10", VA = "0x186F2D710", Slot = "15")]
	public void BJNIMHBPEJI((Quaternion rot, Vector3 moments) CKEJAFLIMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DFA0", Offset = "0x6F2C7A0", VA = "0x186F2DFA0")]
	private Quaternion HELIIBEMCHE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C890", Offset = "0x6F2B090", VA = "0x186F2C890")]
	public void BJEDCAPDABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C960", Offset = "0x6F2B160", VA = "0x186F2C960", Slot = "4")]
	public (float, Vector3) BJEDCAPDABC(Rigidbody POEMMNMNOEI)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class DNCCJLAIPBI
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F25810", Offset = "0x6F24010", VA = "0x186F25810")]
	public static PJBKBEOGOFN GKGLPCPKMNM(this LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class ECMKJAPAOJP : HAPDGEOPNLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly AKECFCILGBG NKIPNFFBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly MJPOGCFKFFN MCOFHMNNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly ONPHIJJLPGG EEBPBEAOODP;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool MCPKAEGAGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xEF1880", Offset = "0xEF0080", VA = "0x180EF1880", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public ONPHIJJLPGG FFLGFNAAOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8CDB30", Offset = "0x8CC330", VA = "0x1808CDB30", Slot = "11")]
		get
		{
			return default(ONPHIJJLPGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F25F90", Offset = "0x6F24790", VA = "0x186F25F90")]
	public ECMKJAPAOJP(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F25EC0", Offset = "0x6F246C0", VA = "0x186F25EC0", Slot = "4")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F25970", Offset = "0x6F24170", VA = "0x186F25970")]
	private bool ABMDCKKGGNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F25CA0", Offset = "0x6F244A0", VA = "0x186F25CA0", Slot = "5")]
	public void DGEPFNEICCP(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F25CD0", Offset = "0x6F244D0", VA = "0x186F25CD0", Slot = "6")]
	public void HGCOKOEFMOK(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F25D80", Offset = "0x6F24580", VA = "0x186F25D80", Slot = "9")]
	public void OMOOHCBNEBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F25A10", Offset = "0x6F24210", VA = "0x186F25A10")]
	private void ANKLEIFGGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F25B30", Offset = "0x6F24330", VA = "0x186F25B30")]
	private void BLKAFMDMCKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F25D40", Offset = "0x6F24540", VA = "0x186F25D40", Slot = "8")]
	public void ICGJKBEJBIA(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F25D00", Offset = "0x6F24500", VA = "0x186F25D00", Slot = "7")]
	public void HOJGFBCHDEJ(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class CBFOKBIICLF : IACJBDKKNDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly AKECFCILGBG NKIPNFFBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly MJPOGCFKFFN JIAFKCBDJHA;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool PBLHJBGBIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F25590", Offset = "0x6F23D90", VA = "0x186F25590", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event CEJKOKAHCJG IDADILKKDPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F253B0", Offset = "0x6F23BB0", VA = "0x186F253B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F25680", Offset = "0x6F23E80", VA = "0x186F25680", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F25720", Offset = "0x6F23F20", VA = "0x186F25720")]
	public CBFOKBIICLF(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F25390", Offset = "0x6F23B90", VA = "0x186F25390", Slot = "7")]
	public void DCIFLICONLL(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F253A0", Offset = "0x6F23BA0", VA = "0x186F253A0", Slot = "8")]
	public void KGHICEPBNMM(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F25480", Offset = "0x6F23C80", VA = "0x186F25480", Slot = "9")]
	public void PAIMJFADCAB(object EOCJCEFCOOA, bool MCDOCGGGECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F25640", Offset = "0x6F23E40", VA = "0x186F25640", Slot = "12")]
	public void PGGABFKDEIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F25310", Offset = "0x6F23B10", VA = "0x186F25310", Slot = "10")]
	public void BPPFGEIDBGG(Rigidbody KLDLKACCMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F25450", Offset = "0x6F23C50", VA = "0x186F25450", Slot = "11")]
	public void MBFMCBMPPJM(Rigidbody AMBNMKKFJOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class AKBAGCBMKNB : IKKOJINNDFI, ENODCFCBNKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AKECFCILGBG NKIPNFFBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView HDDPEKIEOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool AHJDHJCDCEE;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView LOLDDNOAIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool GGCJPCDEOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E3D0", Offset = "0x6F1CBD0", VA = "0x186F1E3D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool OMMEKKCNHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D560", Offset = "0xA6BD60", VA = "0x180A6D560", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event CEJKOKAHCJG HFEDDJKAHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E660", Offset = "0x6F1CE60", VA = "0x186F1E660", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E970", Offset = "0x6F1D170", VA = "0x186F1E970", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ECB0", Offset = "0x6F1D4B0", VA = "0x186F1ECB0")]
	public AKBAGCBMKNB(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EB80", Offset = "0x6F1D380", VA = "0x186F1EB80", Slot = "9")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E3F0", Offset = "0x6F1CBF0", VA = "0x186F1E3F0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E4F0", Offset = "0x6F1CCF0", VA = "0x186F1E4F0", Slot = "10")]
	public void HCJFHFKIFCI(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E110", Offset = "0x6F1C910", VA = "0x186F1E110", Slot = "11")]
	public void BFJIHMPHLJA(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EA10", Offset = "0x6F1D210", VA = "0x186F1EA10")]
	private void PJAMIBLLAJO(PhotonView PFDHDOKBLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E280", Offset = "0x6F1CA80", VA = "0x186F1E280")]
	private void BNJLKAAGMEP(HJKEDKBDPPP LAOPCGKBCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E700", Offset = "0x6F1CF00", VA = "0x186F1E700")]
	private void NDFEOOIBOKA(PhotonView AEPHECJCJCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class PIBKLLMHDEL
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F32910", Offset = "0x6F31110", VA = "0x186F32910")]
	public static IKKOJINNDFI NJIKKJPDJGD(this LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class HGPMOBDFJND : EJDCPCDIDOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly AKECFCILGBG NKIPNFFBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints JPAPNIOBBKO;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool FKLLLKFDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xCF0C00", Offset = "0xCEF400", VA = "0x180CF0C00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x44E91C0", Offset = "0x44E79C0", VA = "0x1844E91C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool BHGJNLBILDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xF3FD80", Offset = "0xF3E580", VA = "0x180F3FD80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x44E91B0", Offset = "0x44E79B0", VA = "0x1844E91B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints OFGMKLMDGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E510", VA = "0x18085FD10", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A6B0", Offset = "0x6F28EB0", VA = "0x186F2A6B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A810", Offset = "0x6F29010", VA = "0x186F2A810")]
	public HGPMOBDFJND(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A680", Offset = "0x6F28E80", VA = "0x186F2A680", Slot = "9")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A7E0", Offset = "0x6F28FE0", VA = "0x186F2A7E0", Slot = "10")]
	public void MBFMCBMPPJM(Rigidbody AMBNMKKFJOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class OEANOHBDAAL : BNEAKDEKEGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LJEEPNBNNHB NKIPNFFBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float MFICPAKCDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float JPAHPGHKFID;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float LGIGFNNJAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAD0", Offset = "0x8BD2D0", VA = "0x1808BEAD0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F317E0", Offset = "0x6F2FFE0", VA = "0x186F317E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float JJGEJCPKFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA90", Offset = "0x8BD290", VA = "0x1808BEA90", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F318B0", Offset = "0x6F300B0", VA = "0x186F318B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F31A20", Offset = "0x6F30220", VA = "0x186F31A20")]
	public OEANOHBDAAL(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F31790", Offset = "0x6F2FF90", VA = "0x186F31790", Slot = "8")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F31980", Offset = "0x6F30180", VA = "0x186F31980", Slot = "9")]
	public void MBFMCBMPPJM(Rigidbody AMBNMKKFJOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class LIBCLCOHFFF : JKJFHGFNKMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly AKECFCILGBG NKIPNFFBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool MOGIIMBFBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool IDPIFOLNJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int OFLPNINPADE;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody DHIIHPKBDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C840", Offset = "0x6F2B040", VA = "0x186F2C840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool CBCMAKKEDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F30B70", Offset = "0x6F2F370", VA = "0x186F30B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private LJEEPNBNNHB EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F308C0", Offset = "0x6F2F0C0", VA = "0x186F308C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool KIMLMAODMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F30250", Offset = "0x6F2EA50", VA = "0x186F30250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event CEJKOKAHCJG PDPOOKEFDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F30AD0", Offset = "0x6F2F2D0", VA = "0x186F30AD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F30810", Offset = "0x6F2F010", VA = "0x186F30810", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F30CC0", Offset = "0x6F2F4C0", VA = "0x186F30CC0")]
	public LIBCLCOHFFF(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F30C30", Offset = "0x6F2F430", VA = "0x186F30C30", Slot = "6")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F308B0", Offset = "0x6F2F0B0", VA = "0x186F308B0", Slot = "8")]
	public void HACGNHECFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F302B0", Offset = "0x6F2EAB0", VA = "0x186F302B0", Slot = "7")]
	public bool DBEPKAHMKBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F30B90", Offset = "0x6F2F390", VA = "0x186F30B90", Slot = "9")]
	public void NMFKFBHACCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F30400", Offset = "0x6F2EC00", VA = "0x186F30400", Slot = "11")]
	public void DENFDBJHBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F30920", Offset = "0x6F2F120", VA = "0x186F30920", Slot = "10")]
	public void IMKIFNNMNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F30630", Offset = "0x6F2EE30", VA = "0x186F30630")]
	private bool EHDEBMFGJFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F304A0", Offset = "0x6F2ECA0", VA = "0x186F304A0")]
	private void ECEOIKHFOBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class NGEKODKPLMJ : LCNNLPJHPDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly AKECFCILGBG NKIPNFFBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly MJPOGCFKFFN OBFAPKNDAIB;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody DHIIHPKBDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851070", VA = "0x180852870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool KIMLMAODMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D590", Offset = "0x6F1BD90", VA = "0x186F1D590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool KLCPPBHBKKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xEF1880", Offset = "0xEF0080", VA = "0x180EF1880", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F31680", Offset = "0x6F2FE80", VA = "0x186F31680")]
	public NGEKODKPLMJ(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F313F0", Offset = "0x6F2FBF0", VA = "0x186F313F0", Slot = "5")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F30EE0", Offset = "0x6F2F6E0", VA = "0x186F30EE0", Slot = "7")]
	public void CDBCEDMLJNK(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F313C0", Offset = "0x6F2FBC0", VA = "0x186F313C0", Slot = "8")]
	public void OLCAAIPHEIP(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6F31090", Offset = "0x6F2F890", VA = "0x186F31090", Slot = "9")]
	public void IGNDFADNBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6F31490", Offset = "0x6F2FC90", VA = "0x186F31490", Slot = "10")]
	public void PLNIPPDHELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6F30F10", Offset = "0x6F2F710", VA = "0x186F30F10", Slot = "11")]
	public void GHBNOPDHNCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class FIHADBAPKAD : HAOKEBMAJGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly AKECFCILGBG NKIPNFFBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly MJPOGCFKFFN BMFBEGDMBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float CCGJENGKEPC;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public GCCHGDAONKB GLMHBPJHKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8577C0", VA = "0x180858FC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public LIJOKMDFOFH MCJHNAIMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x859CC0", VA = "0x18085B4C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 JGCPBAEFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x6F29840", Offset = "0x6F28040", VA = "0x186F29840", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6F28790", Offset = "0x6F26F90", VA = "0x186F28790", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 PCBLAEINONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6F289E0", Offset = "0x6F271E0", VA = "0x186F289E0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6F27320", Offset = "0x6F25B20", VA = "0x186F27320", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 DOJOOKOADMA
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6F295C0", Offset = "0x6F27DC0", VA = "0x186F295C0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6F27530", Offset = "0x6F25D30", VA = "0x186F27530", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 NNHDGLHBCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6F278C0", Offset = "0x6F260C0", VA = "0x186F278C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6F279F0", Offset = "0x6F261F0", VA = "0x186F279F0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float OBLJBMFPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9B0", Offset = "0x8BD1B0", VA = "0x1808BE9B0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6F26A70", Offset = "0x6F25270", VA = "0x186F26A70", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool BOOAKEKDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x18C0450", Offset = "0x18BEC50", VA = "0x1818C0450", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private MPONMNOKEDF FDMIHFIIOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x67509C0", Offset = "0x674F1C0", VA = "0x1867509C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool CBCMAKKEDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6F28F30", Offset = "0x6F27730", VA = "0x186F28F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6F29E90", Offset = "0x6F28690", VA = "0x186F29E90")]
	public FIHADBAPKAD(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6F27C60", Offset = "0x6F26460", VA = "0x186F27C60", Slot = "19")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6F276A0", Offset = "0x6F25EA0", VA = "0x186F276A0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6F27130", Offset = "0x6F25930", VA = "0x186F27130", Slot = "28")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xD2C7A0", Offset = "0xD2AFA0", VA = "0x180D2C7A0", Slot = "20")]
	public void KBNPIHBKMOE(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xD2AF30", Offset = "0xD29730", VA = "0x180D2AF30", Slot = "30")]
	public void NLMCONACPDB(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6F27350", Offset = "0x6F25B50", VA = "0x186F27350", Slot = "35")]
	public Vector3 CMIOFOLPDBD(Vector3 FIMFMOJFCFJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6F27700", Offset = "0x6F25F00", VA = "0x186F27700", Slot = "34")]
	public Vector3 EHACCJENFAB(Vector3 NOGFFKGBCOL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6F27C60", Offset = "0x6F26460", VA = "0x186F27C60", Slot = "27")]
	public void FOFMMMJGGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6F27260", Offset = "0x6F25A60", VA = "0x186F27260", Slot = "25")]
	public void CELBLPAFCIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6F29E30", Offset = "0x6F28630", VA = "0x186F29E30", Slot = "24")]
	public void PMEPFJEJIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6F27A20", Offset = "0x6F26220", VA = "0x186F27A20", Slot = "33")]
	public void FLNMHLJEABK(Vector3 HFOBNBKELJL, Vector3 MHBEFOAKJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6F272C0", Offset = "0x6F25AC0", VA = "0x186F272C0", Slot = "32")]
	public void CHAAMCPOLKD(Vector3 JNININDALMJ, Vector3 IGMBCDNHIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6F268D0", Offset = "0x6F250D0", VA = "0x186F268D0", Slot = "31")]
	public void ADFDPALOCLC(Vector3 HGGENDDBBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6F28F50", Offset = "0x6F27750", VA = "0x186F28F50", Slot = "22")]
	public void OEHCHBFDEKM(CJOGEGMLKDO OEJNBMLJOIB, Vector3 NBOECIFPPEF, float AHEAGOIPKJF, float CNMGOEBKPGK = 8f, float IMBABICPDKH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6F28B00", Offset = "0x6F27300", VA = "0x186F28B00", Slot = "21")]
	public void LDGDMKCOGAH(JCBCIKFMAML KEJNJHGGNMJ, Vector3 BJMFJJKFMAF, float EEDKOLOOPKK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6F283A0", Offset = "0x6F26BA0", VA = "0x186F283A0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JLBJDDHJOHM(JCBCIKFMAML KEJNJHGGNMJ, Vector3 LCDJINCAHMD, float ONOCCGOPHEL = 7f, float BKJDNLFEDGK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xE309A0", Offset = "0xE2F1A0", VA = "0x180E309A0")]
	private static void CNEEAMJCMOP(Vector3 GPJLHMNPICC, Vector3 NFFLDAHKGKD, [Out] Vector3 OPMHPIHPDOH, [Out] Vector3 CEIIPAPENEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6F282C0", Offset = "0x6F26AC0", VA = "0x186F282C0", Slot = "29")]
	public Vector3 IGGKIKFINPM(Vector3 GPJLHMNPICC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6F28850", Offset = "0x6F27050", VA = "0x186F28850", Slot = "26")]
	public void JOFNHGFIFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6F26A70", Offset = "0x6F25270", VA = "0x186F26A70")]
	private void AIOGMGGHDKM(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6F28D90", Offset = "0x6F27590", VA = "0x186F28D90")]
	private void MHAHPHBFLCI(Vector3 BJMFJJKFMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6F29720", Offset = "0x6F27F20", VA = "0x186F29720")]
	private Vector3 OOAPJNOBCPA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6F26B80", Offset = "0x6F25380", VA = "0x186F26B80")]
	private void AJGHMPFPAMD(Vector3 NOGFFKGBCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6F27010", Offset = "0x6F25810", VA = "0x186F27010")]
	private Vector3 BGIAFHGNAFC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6F299A0", Offset = "0x6F281A0", VA = "0x186F299A0")]
	private void PDHGDFGJFJA(Vector3 JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6F27D10", Offset = "0x6F26510", VA = "0x186F27D10")]
	private void HEBCAMHGKPG(Vector3 NOGFFKGBCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6F275F0", Offset = "0x6F25DF0", VA = "0x186F275F0")]
	private void DCCFKCCICKM()
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
