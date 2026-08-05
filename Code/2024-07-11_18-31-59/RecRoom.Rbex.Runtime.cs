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
		[Cpp2IlInjected.Address(RVA = "0x6F30F10", Offset = "0x6F2F910", VA = "0x186F30F10", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855340", VA = "0x180856940", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x14ED5A0", Offset = "0x14EBFA0", VA = "0x1814ED5A0", Slot = "5")]
		public override void GGDGBHPPNIB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F38D30", Offset = "0x6F37730", VA = "0x186F38D30")]
		private void AOCOLDKKJHF(FCHLICHCLOD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F39030", Offset = "0x6F37A30", VA = "0x186F39030", Slot = "6")]
		public override void KNAPKCNJDIM(FCHLICHCLOD registry, [In] NGGDAGDIDAI filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "8")]
		public override void KCOPNMGFKOP(GOMCEOHIOKI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F39090", Offset = "0x6F37A90", VA = "0x186F39090")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F34750", Offset = "0x6F33150", VA = "0x186F34750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LJEEPNBNNHB HGPLEJGEAPO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int DGFFNAGFKDO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F361A0", Offset = "0x6F34BA0", VA = "0x186F361A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx BOHHFPAPAAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F36500", Offset = "0x6F34F00", VA = "0x186F36500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx DHCIAOJNIGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F36440", Offset = "0x6F34E40", VA = "0x186F36440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx BMBBFJPOJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6F371A0", Offset = "0x6F35BA0", VA = "0x186F371A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F386A0", Offset = "0x6F370A0", VA = "0x186F386A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform CCIHBJHNFDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x87B800", Offset = "0x87A200", VA = "0x18087B800", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform NFGKEMNGCHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x87B800", Offset = "0x87A200", VA = "0x18087B800", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public EEPBOLJHLNK MCAKOHHFPJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F36200", Offset = "0x6F34C00", VA = "0x186F36200")]
			get
			{
				return default(EEPBOLJHLNK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F37E50", Offset = "0x6F36850", VA = "0x186F37E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GGCJPCDEOFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F36810", Offset = "0x6F35210", VA = "0x186F36810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool OMMEKKCNHOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F36320", Offset = "0x6F34D20", VA = "0x186F36320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public GCCHGDAONKB GLMHBPJHKEB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F36750", Offset = "0x6F35150", VA = "0x186F36750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F38010", Offset = "0x6F36A10", VA = "0x186F38010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LIJOKMDFOFH MCJHNAIMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F366F0", Offset = "0x6F350F0", VA = "0x186F366F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F37FA0", Offset = "0x6F369A0", VA = "0x186F37FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool BOOAKEKDDLH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F36640", Offset = "0x6F35040", VA = "0x186F36640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody DHIIHPKBDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F366A0", Offset = "0x6F350A0", VA = "0x186F366A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool FKLLLKFDFMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F36380", Offset = "0x6F34D80", VA = "0x186F36380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F37EC0", Offset = "0x6F368C0", VA = "0x186F37EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool FNFOMIAJIKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6C15C40", Offset = "0x6C14640", VA = "0x186C15C40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float MFLAEOCINDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F37140", Offset = "0x6F35B40", VA = "0x186F37140")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float NLILMFBCLII
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F370E0", Offset = "0x6F35AE0", VA = "0x186F370E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F38630", Offset = "0x6F37030", VA = "0x186F38630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float MFICPAKCDLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F36A70", Offset = "0x6F35470", VA = "0x186F36A70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F382B0", Offset = "0x6F36CB0", VA = "0x186F382B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float JPAHPGHKFID
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F36870", Offset = "0x6F35270", VA = "0x186F36870")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6F38080", Offset = "0x6F36A80", VA = "0x186F38080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool GEOCOMMJHCI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6F376F0", Offset = "0x6F360F0", VA = "0x186F376F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F38BE0", Offset = "0x6F375E0", VA = "0x186F38BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 OKJPOCNNKIP
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F36EC0", Offset = "0x6F358C0", VA = "0x186F36EC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F38400", Offset = "0x6F36E00", VA = "0x186F38400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 GNEGFFPGDPL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F37830", Offset = "0x6F36230", VA = "0x186F37830")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode OHMIAFIIEPI
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F369B0", Offset = "0x6F353B0", VA = "0x186F369B0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6F381D0", Offset = "0x6F36BD0", VA = "0x186F381D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float OBLJBMFPBCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F363E0", Offset = "0x6F34DE0", VA = "0x186F363E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F37F30", Offset = "0x6F36930", VA = "0x186F37F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints JPAPNIOBBKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F36A10", Offset = "0x6F35410", VA = "0x186F36A10")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F38240", Offset = "0x6F36C40", VA = "0x186F38240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 FNLEIIJLBBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F37260", Offset = "0x6F35C60", VA = "0x186F37260")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 MPCBIACINGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F37260", Offset = "0x6F35C60", VA = "0x186F37260")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F389C0", Offset = "0x6F373C0", VA = "0x186F389C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float AHDCCDIOAPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6F36FA0", Offset = "0x6F359A0", VA = "0x186F36FA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F384E0", Offset = "0x6F36EE0", VA = "0x186F384E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NGAMAICEFKI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F37690", Offset = "0x6F36090", VA = "0x186F37690")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F38B70", Offset = "0x6F37570", VA = "0x186F38B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion BHIAAANLCMM
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F37340", Offset = "0x6F35D40", VA = "0x186F37340")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F38740", Offset = "0x6F37140", VA = "0x186F38740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion ONNKAJNPEEG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F375C0", Offset = "0x6F35FC0", VA = "0x186F375C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6F38AA0", Offset = "0x6F374A0", VA = "0x186F38AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 FPHICFGFPKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F37410", Offset = "0x6F35E10", VA = "0x186F37410")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6F38810", Offset = "0x6F37210", VA = "0x186F38810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion PFGGMIAAHLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F374F0", Offset = "0x6F35EF0", VA = "0x186F374F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6F388F0", Offset = "0x6F372F0", VA = "0x186F388F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 GPJLHMNPICC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F37750", Offset = "0x6F36150", VA = "0x186F37750")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6F38C50", Offset = "0x6F37650", VA = "0x186F38C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 NOGFFKGBCOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6F37000", Offset = "0x6F35A00", VA = "0x186F37000")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6F38550", Offset = "0x6F36F50", VA = "0x186F38550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 FJCOMDPBLBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6F368D0", Offset = "0x6F352D0", VA = "0x186F368D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6F380F0", Offset = "0x6F36AF0", VA = "0x186F380F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 IGMBCDNHIBE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6F36DE0", Offset = "0x6F357E0", VA = "0x186F36DE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6F38320", Offset = "0x6F36D20", VA = "0x186F38320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 CKKOBMDHEHP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6F36CA0", Offset = "0x6F356A0", VA = "0x186F36CA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion PBLCAIBKDLE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6F36BD0", Offset = "0x6F355D0", VA = "0x186F36BD0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 IHBGJBAOAJE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6F379F0", Offset = "0x6F363F0", VA = "0x186F379F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 NAPNEBENMHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6F37910", Offset = "0x6F36310", VA = "0x186F37910")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool JMEEMLNLABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6F36D80", Offset = "0x6F35780", VA = "0x186F36D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool HJFGMLFHNIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6F367B0", Offset = "0x6F351B0", VA = "0x186F367B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool GFHIPOLMMFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6F362C0", Offset = "0x6F34CC0", VA = "0x186F362C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool FGNIPGKHKKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6F36260", Offset = "0x6F34C60", VA = "0x186F36260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DKNNPMBIPBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6F36140", Offset = "0x6F34B40", VA = "0x186F36140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool FNJKLOEFDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6F36AD0", Offset = "0x6F354D0", VA = "0x186F36AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HPJBMFGHLLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5936680", Offset = "0x5935080", VA = "0x185936680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event KFNJEADEOOD LICFJNGNCOE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F36060", Offset = "0x6F34A60", VA = "0x186F36060")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6F37D70", Offset = "0x6F36770", VA = "0x186F37D70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CEJKOKAHCJG GOMCPIIALCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6F35DD0", Offset = "0x6F347D0", VA = "0x186F35DD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6F37AD0", Offset = "0x6F364D0", VA = "0x186F37AD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event CEJKOKAHCJG KNBPNKNELBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F35E30", Offset = "0x6F34830", VA = "0x186F35E30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6F37B40", Offset = "0x6F36540", VA = "0x186F37B40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event CEJKOKAHCJG LALHICAPNBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6F35F80", Offset = "0x6F34980", VA = "0x186F35F80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6F37C90", Offset = "0x6F36690", VA = "0x186F37C90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<FHBBMPGGCGD, FHBBMPGGCGD> MDHINEPAAFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F35F10", Offset = "0x6F34910", VA = "0x186F35F10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F37C20", Offset = "0x6F36620", VA = "0x186F37C20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event CEJKOKAHCJG CLKHELDEPHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F35FF0", Offset = "0x6F349F0", VA = "0x186F35FF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F37D00", Offset = "0x6F36700", VA = "0x186F37D00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event CEJKOKAHCJG BIJPPNGOHEI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F360D0", Offset = "0x6F34AD0", VA = "0x186F360D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F37DE0", Offset = "0x6F367E0", VA = "0x186F37DE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event CEJKOKAHCJG HCDKLCFJLOG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F35EA0", Offset = "0x6F348A0", VA = "0x186F35EA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F37BB0", Offset = "0x6F365B0", VA = "0x186F37BB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851270", VA = "0x180852870", Slot = "8")]
		private void DHGOHHBIDBH(LJEEPNBNNHB CIGKBEKHOLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F34E40", Offset = "0x6F33840", VA = "0x186F34E40")]
		internal void PJIEKOHGLGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F35AF0", Offset = "0x6F344F0", VA = "0x186F35AF0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody JNPMEKFEALJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F34800", Offset = "0x6F33200", VA = "0x186F34800")]
		public HJKEDKBDPPP GetChild(int DHNLEFJCEAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6F35760", Offset = "0x6F34160", VA = "0x186F35760")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) CKEJAFLIMPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F342E0", Offset = "0x6F32CE0", VA = "0x186F342E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F34750", Offset = "0x6F33150", VA = "0x186F34750")]
		private LJEEPNBNNHB GBHFCLLMEDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F34530", Offset = "0x6F32F30", VA = "0x186F34530")]
		private void EEKIDKGBNNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F34F30", Offset = "0x6F33930", VA = "0x186F34F30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F34E40", Offset = "0x6F33840", VA = "0x186F34E40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F34ED0", Offset = "0x6F338D0", VA = "0x186F34ED0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F34F90", Offset = "0x6F33990", VA = "0x186F34F90")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F338D0", Offset = "0x6F322D0", VA = "0x186F338D0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F34FF0", Offset = "0x6F339F0", VA = "0x186F34FF0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F344D0", Offset = "0x6F32ED0", VA = "0x186F344D0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F34DE0", Offset = "0x6F337E0", VA = "0x186F34DE0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F358C0", Offset = "0x6F342C0", VA = "0x186F358C0")]
		public void SetParent(RigidbodyEx JMDCGOKJIDA, bool DCIOAOCCLNO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F35300", Offset = "0x6F33D00", VA = "0x186F35300")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F34AB0", Offset = "0x6F334B0", VA = "0x186F34AB0")]
		public bool IsRigidbodyAncestor(RigidbodyEx KPIPNJDNJNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F34B90", Offset = "0x6F33590", VA = "0x186F34B90")]
		public bool IsRigidbodyDescendant(RigidbodyEx NIOHKOJCMDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F33B40", Offset = "0x6F32540", VA = "0x186F33B40")]
		public void AddInterpolationRestriction(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F35060", Offset = "0x6F33A60", VA = "0x186F35060")]
		public void RemoveInterpolationRestriction(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F33BB0", Offset = "0x6F325B0", VA = "0x186F33BB0")]
		public void AddKinematic(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F350D0", Offset = "0x6F33AD0", VA = "0x186F350D0")]
		public void RemoveKinematic(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F35840", Offset = "0x6F34240", VA = "0x186F35840")]
		public void SetKinematic(object EOCJCEFCOOA, bool MCDOCGGGECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F35660", Offset = "0x6F34060", VA = "0x186F35660")]
		public void SetDiscontinuousPositionAndRotation(Vector3 BELOINIPDIB, Quaternion HJPFNIDEMNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F35560", Offset = "0x6F33F60", VA = "0x186F35560")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 LEDGGONKHOH, Quaternion GNOJHHCJPOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F349A0", Offset = "0x6F333A0", VA = "0x186F349A0")]
		public Vector3 GetConstrainedVelocity(Vector3 GPJLHMNPICC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F34890", Offset = "0x6F33290", VA = "0x186F34890")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 FJCOMDPBLBJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F33A50", Offset = "0x6F32450", VA = "0x186F33A50")]
		public void AddForce(Vector3 AMNFMCIBNPO, ForceMode HAMIBHDKAKH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F33940", Offset = "0x6F32340", VA = "0x186F33940")]
		public void AddForceAtPosition(Vector3 AMNFMCIBNPO, Vector3 HGDCPNGLIKJ, ForceMode HAMIBHDKAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F33D80", Offset = "0x6F32780", VA = "0x186F33D80")]
		public void AddTorque(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F33C20", Offset = "0x6F32620", VA = "0x186F33C20")]
		public void AddRelativeTorque(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F35BC0", Offset = "0x6F345C0", VA = "0x186F35BC0")]
		public Vector3 WorldToLocalVelocity(Vector3 FIMFMOJFCFJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F34CD0", Offset = "0x6F336D0", VA = "0x186F34CD0")]
		public Vector3 LocalToWorldVelocity(Vector3 NOGFFKGBCOL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F34470", Offset = "0x6F32E70", VA = "0x186F34470")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F34410", Offset = "0x6F32E10", VA = "0x186F34410")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F343B0", Offset = "0x6F32DB0", VA = "0x186F343B0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F34350", Offset = "0x6F32D50", VA = "0x186F34350")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F35460", Offset = "0x6F33E60", VA = "0x186F35460")]
		public void ResetVelocityWorldSpace(Vector3 HFOBNBKELJL, Vector3 MHBEFOAKJDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F35360", Offset = "0x6F33D60", VA = "0x186F35360")]
		public void ResetVelocityLocalSpace(Vector3 JNININDALMJ, Vector3 IGMBCDNHIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F35220", Offset = "0x6F33C20", VA = "0x186F35220")]
		public void ResetLinearVelocityLocalSpace(Vector3 JNININDALMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F359F0", Offset = "0x6F343F0", VA = "0x186F359F0")]
		public bool SweepTest(Vector3 FCBGHELDCII, [Out] RaycastHit MGGIMCBEOEH, float BKKDIDJOENO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F34C70", Offset = "0x6F33670", VA = "0x186F34C70")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F35990", Offset = "0x6F34390", VA = "0x186F35990")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F35B60", Offset = "0x6F34560", VA = "0x186F35B60")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F33D10", Offset = "0x6F32710", VA = "0x186F33D10")]
		public void AddShouldHaveUnityRigidbodyToken(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F35140", Offset = "0x6F33B40", VA = "0x186F35140")]
		public void RemoveShouldHaveUnityRigidbodyToken(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6F34110", Offset = "0x6F32B10", VA = "0x186F34110")]
		public void ApplyForceVelocityChange(CJOGEGMLKDO OEJNBMLJOIB, Vector3 NBOECIFPPEF, float AHEAGOIPKJF, float CNMGOEBKPGK = 8f, float IMBABICPDKH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F34010", Offset = "0x6F32A10", VA = "0x186F34010")]
		public void ApplyAngularVelocityChange(JCBCIKFMAML KEJNJHGGNMJ, Vector3 BJMFJJKFMAF, float EEDKOLOOPKK = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F341D0", Offset = "0x6F32BD0", VA = "0x186F341D0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(JCBCIKFMAML KEJNJHGGNMJ, Vector3 LCDJINCAHMD, float ONOCCGOPHEL = 7f, float BKJDNLFEDGK = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F33F40", Offset = "0x6F32940", VA = "0x186F33F40")]
		public bool AllowedScaleChange(float BONLJCBABLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F33E70", Offset = "0x6F32870", VA = "0x186F33E70")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx KNDIPAMGJEH, object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6F351B0", Offset = "0x6F33BB0", VA = "0x186F351B0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F35D60", Offset = "0x6F34760", VA = "0x186F35D60")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9470D0", Offset = "0x945AD0", VA = "0x1809470D0", Slot = "4")]
		private GameObject OJCAIHCGHDH()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x87B800", Offset = "0x87A200", VA = "0x18087B800", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F302E0", Offset = "0x6F2ECE0", VA = "0x186F302E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public CHMPPNFIFLC KKACPIKCPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F328F0", Offset = "0x6F312F0", VA = "0x186F328F0", Slot = "7")]
	public void InitReferences(GANFHFOELEK FGDLGNMCKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F327E0", Offset = "0x6F311E0", VA = "0x186F327E0", Slot = "6")]
	public LJEEPNBNNHB BAEHCLHNCHB(RigidbodyEx NKIPNFFBDAI, KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F33730", Offset = "0x6F32130", VA = "0x186F33730")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F33770", Offset = "0x6F32170", VA = "0x186F33770")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F33750", Offset = "0x6F32150", VA = "0x186F33750")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string JNNDBFGKHHD, [Optional] UnityEngine.Object CNBJCJOALNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string JNNDBFGKHHD, [Optional] UnityEngine.Object CNBJCJOALNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F33880", Offset = "0x6F32280", VA = "0x186F33880")]
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
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x862EA0", Offset = "0x8618A0", VA = "0x180862EA0", Slot = "4")]
		public Vector3 DIFJFDGIODF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x862EA0", Offset = "0x8618A0", VA = "0x180862EA0", Slot = "5")]
		public Vector3 BGIAFHGNAFC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public OLKJGBMCMLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static GCCHGDAONKB OAPCCIJDEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F25280", Offset = "0x6F23C80", VA = "0x186F25280")]
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
		[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "22")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public HJKEDKBDPPP AKJLGFMEBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x85FDF0", Offset = "0x85E7F0", VA = "0x18085FDF0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x85FD70", Offset = "0x85E770", VA = "0x18085FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject BGONLCODLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9E66A0", Offset = "0x9E50A0", VA = "0x1809E66A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9C5320", Offset = "0x9C3D20", VA = "0x1809C5320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform IKKMMCBJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6F206C0", Offset = "0x6F1F0C0", VA = "0x186F206C0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody DHIIHPKBDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F920", Offset = "0x6F1E320", VA = "0x186F1F920", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public LJEEPNBNNHB EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6F22880", Offset = "0x6F21280", VA = "0x186F22880", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6F24E10", Offset = "0x6F23810", VA = "0x186F24E10", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int DGFFNAGFKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6F243D0", Offset = "0x6F22DD0", VA = "0x186F243D0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public LJEEPNBNNHB DHCIAOJNIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6F22830", Offset = "0x6F21230", VA = "0x186F22830", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool KIMLMAODMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FD50", Offset = "0x6F1E750", VA = "0x186F1FD50", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool GGCJPCDEOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FEB0", Offset = "0x6F1E8B0", VA = "0x186F1FEB0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool OMMEKKCNHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6F24C80", Offset = "0x6F23680", VA = "0x186F24C80", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public GCCHGDAONKB GLMHBPJHKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6F23320", Offset = "0x6F21D20", VA = "0x186F23320", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6F21D00", Offset = "0x6F20700", VA = "0x186F21D00", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public LIJOKMDFOFH MCJHNAIMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6F24EC0", Offset = "0x6F238C0", VA = "0x186F24EC0", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6F24120", Offset = "0x6F22B20", VA = "0x186F24120", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float OBLJBMFPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6F228F0", Offset = "0x6F212F0", VA = "0x186F228F0", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6F21B30", Offset = "0x6F20530", VA = "0x186F21B30", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 PCBLAEINONF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6F22F90", Offset = "0x6F21990", VA = "0x186F22F90", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6F202A0", Offset = "0x6F1ECA0", VA = "0x186F202A0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 NNHDGLHBCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6F21190", Offset = "0x6F1FB90", VA = "0x186F21190", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6F21720", Offset = "0x6F20120", VA = "0x186F21720", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 JGCPBAEFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6F24A90", Offset = "0x6F23490", VA = "0x186F24A90", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6F22E10", Offset = "0x6F21810", VA = "0x186F22E10", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 DOJOOKOADMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6F24630", Offset = "0x6F23030", VA = "0x186F24630", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6F20530", Offset = "0x6F1EF30", VA = "0x186F20530", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool GFHIPOLMMFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6F20380", Offset = "0x6F1ED80", VA = "0x186F20380", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool FGNIPGKHKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6F241E0", Offset = "0x6F22BE0", VA = "0x186F241E0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool DKNNPMBIPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6F23C10", Offset = "0x6F22610", VA = "0x186F23C10", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool BOOAKEKDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6F22470", Offset = "0x6F20E70", VA = "0x186F22470", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 CHBOEELJBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6F20B40", Offset = "0x6F1F540", VA = "0x186F20B40", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 EHOGFCCMBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6F24490", Offset = "0x6F22E90", VA = "0x186F24490", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 MPKDNNPCOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F237E0", Offset = "0x6F221E0", VA = "0x186F237E0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F20C10", Offset = "0x6F1F610", VA = "0x186F20C10", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 MLGKNLKHOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F21DB0", Offset = "0x6F207B0", VA = "0x186F21DB0", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float CNPKCGDBOHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F24F10", Offset = "0x6F23910", VA = "0x186F24F10", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float FKLAKHONCEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F22420", Offset = "0x6F20E20", VA = "0x186F22420", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F1EF70", Offset = "0x6F1D970", VA = "0x186F1EF70", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 GLAIIHKCPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F21950", Offset = "0x6F20350", VA = "0x186F21950", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion IFMMPIPGKAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F22B20", Offset = "0x6F21520", VA = "0x186F22B20", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float LGIGFNNJAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F20750", Offset = "0x6F1F150", VA = "0x186F20750", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F21A80", Offset = "0x6F20480", VA = "0x186F21A80", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float JJGEJCPKFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FE60", Offset = "0x6F1E860", VA = "0x186F1FE60", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F22BF0", Offset = "0x6F215F0", VA = "0x186F22BF0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool FLNDLEBMONH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F21AE0", Offset = "0x6F204E0", VA = "0x186F21AE0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F207A0", Offset = "0x6F1F1A0", VA = "0x186F207A0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public EEPBOLJHLNK MCAKOHHFPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F240D0", Offset = "0x6F22AD0", VA = "0x186F240D0", Slot = "68")]
		get
		{
			return default(EEPBOLJHLNK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F22A00", Offset = "0x6F21400", VA = "0x186F22A00", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool PBLHJBGBIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F24B70", Offset = "0x6F23570", VA = "0x186F24B70", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform NFGKEMNGCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F23AE0", Offset = "0x6F224E0", VA = "0x186F23AE0", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 EPEMKAANOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FA40", Offset = "0x6F1E440", VA = "0x186F1FA40", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F22940", Offset = "0x6F21340", VA = "0x186F22940", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float DLMMKBPCBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F320", Offset = "0x6F1DD20", VA = "0x186F1F320", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F238C0", Offset = "0x6F222C0", VA = "0x186F238C0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float JDLKEDGCFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F23CF0", Offset = "0x6F226F0", VA = "0x186F23CF0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F21620", Offset = "0x6F20020", VA = "0x186F21620", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion KHCNENJLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F224C0", Offset = "0x6F20EC0", VA = "0x186F224C0", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F20800", Offset = "0x6F1F200", VA = "0x186F20800", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 PCKAHHMDECP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F21D60", Offset = "0x6F20760", VA = "0x186F21D60", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F24240", Offset = "0x6F22C40", VA = "0x186F24240", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion ACLOFDCFLFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F21100", Offset = "0x6F1FB00", VA = "0x186F21100", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F235A0", Offset = "0x6F21FA0", VA = "0x186F235A0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints OFGMKLMDGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FE10", Offset = "0x6F1E810", VA = "0x186F1FE10", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F22A60", Offset = "0x6F21460", VA = "0x186F22A60", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool FKLLLKFDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F7C0", Offset = "0x6F1E1C0", VA = "0x186F1F7C0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F23260", Offset = "0x6F21C60", VA = "0x186F23260", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode AIBPEFBJHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F21140", Offset = "0x6F1FB40", VA = "0x186F21140", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6F24F60", Offset = "0x6F23960", VA = "0x186F24F60", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool CBCMAKKEDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F24290", Offset = "0x6F22C90", VA = "0x186F24290", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool HJFGMLFHNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FFE0", Offset = "0x6F1E9E0", VA = "0x186F1FFE0", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event CEJKOKAHCJG GOMCPIIALCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6F23930", Offset = "0x6F22330", VA = "0x186F23930", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F260", Offset = "0x6F1DC60", VA = "0x186F1F260", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event CEJKOKAHCJG KNBPNKNELBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6F247D0", Offset = "0x6F231D0", VA = "0x186F247D0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6F21270", Offset = "0x6F1FC70", VA = "0x186F21270", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event KFNJEADEOOD OLAGEKEIEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6F215C0", Offset = "0x6F1FFC0", VA = "0x186F215C0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6F24710", Offset = "0x6F23110", VA = "0x186F24710", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event CEJKOKAHCJG HFEDDJKAHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6F232C0", Offset = "0x6F21CC0", VA = "0x186F232C0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6F24180", Offset = "0x6F22B80", VA = "0x186F24180", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event CEJKOKAHCJG LALHICAPNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6F23150", Offset = "0x6F21B50", VA = "0x186F23150", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6F21EF0", Offset = "0x6F208F0", VA = "0x186F21EF0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event CEJKOKAHCJG PDPOOKEFDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F23B60", Offset = "0x6F22560", VA = "0x186F23B60", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F218F0", Offset = "0x6F202F0", VA = "0x186F218F0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<FHBBMPGGCGD, FHBBMPGGCGD> MDHINEPAAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F2C0", Offset = "0x6F1DCC0", VA = "0x186F1F2C0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F22AC0", Offset = "0x6F214C0", VA = "0x186F22AC0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event CEJKOKAHCJG IDADILKKDPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F23540", Offset = "0x6F21F40", VA = "0x186F23540", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F24C20", Offset = "0x6F23620", VA = "0x186F24C20", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event CEJKOKAHCJG HCDKLCFJLOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F23730", Offset = "0x6F22130", VA = "0x186F23730", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F22C50", Offset = "0x6F21650", VA = "0x186F22C50", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6F25000", Offset = "0x6F23A00", VA = "0x186F25000")]
	public AKECFCILGBG(GameObject NBDLDMDNCAL, RigidbodyEx EFJFPKJHPOE, NGLPLNHDEND GOHDOKCJOFP, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6F212D0", Offset = "0x6F1FCD0", VA = "0x186F212D0", Slot = "136")]
	protected virtual void FBGPFOOCPOG(NGLPLNHDEND GOHDOKCJOFP, KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6F20E50", Offset = "0x6F1F850", VA = "0x186F20E50", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6F24CD0", Offset = "0x6F236D0", VA = "0x186F24CD0", Slot = "91")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6F21A30", Offset = "0x6F20430", VA = "0x186F21A30", Slot = "92")]
	public void NFLKBJHAPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6F228D0", Offset = "0x6F212D0", VA = "0x186F228D0", Slot = "93")]
	public void IKNKANAKDJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6F234C0", Offset = "0x6F21EC0", VA = "0x186F234C0")]
	private void LFENBOKJKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FF00", Offset = "0x6F1E900", VA = "0x186F1FF00", Slot = "30")]
	public LJEEPNBNNHB BPLEDEIPGKB(int DHNLEFJCEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6F23AF0", Offset = "0x6F224F0", VA = "0x186F23AF0", Slot = "95")]
	public void MMADMDAOMMK(LJEEPNBNNHB JMDCGOKJIDA, bool DCIOAOCCLNO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6F21E90", Offset = "0x6F20890", VA = "0x186F21E90", Slot = "96")]
	public void GMBDJPNPBNI(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6F203D0", Offset = "0x6F1EDD0", VA = "0x186F203D0", Slot = "97")]
	public void CICBOHHFGOI(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6F20430", Offset = "0x6F1EE30", VA = "0x186F20430", Slot = "98")]
	public Vector3 CMIOFOLPDBD(Vector3 FIMFMOJFCFJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6F21000", Offset = "0x6F1FA00", VA = "0x186F21000", Slot = "99")]
	public Vector3 EHACCJENFAB(Vector3 NOGFFKGBCOL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6F21A30", Offset = "0x6F20430", VA = "0x186F21A30", Slot = "100")]
	public void FOFMMMJGGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6F20160", Offset = "0x6F1EB60", VA = "0x186F20160", Slot = "101")]
	public void CELBLPAFCIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6F24E70", Offset = "0x6F23870", VA = "0x186F24E70", Slot = "102")]
	public void PMEPFJEJIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6F21800", Offset = "0x6F20200", VA = "0x186F21800", Slot = "103")]
	public void FLNMHLJEABK(Vector3 HFOBNBKELJL, Vector3 MHBEFOAKJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6F201B0", Offset = "0x6F1EBB0", VA = "0x186F201B0", Slot = "104")]
	public void CHAAMCPOLKD(Vector3 JNININDALMJ, Vector3 IGMBCDNHIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EFD0", Offset = "0x6F1D9D0", VA = "0x186F1EFD0", Slot = "105")]
	public void ADFDPALOCLC(Vector3 HGGENDDBBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6F24570", Offset = "0x6F22F70", VA = "0x186F24570", Slot = "106")]
	public void OEHCHBFDEKM(CJOGEGMLKDO OEJNBMLJOIB, Vector3 NBOECIFPPEF, float AHEAGOIPKJF, float CNMGOEBKPGK = 8f, float IMBABICPDKH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6F23370", Offset = "0x6F21D70", VA = "0x186F23370", Slot = "107")]
	public void LDGDMKCOGAH(JCBCIKFMAML KEJNJHGGNMJ, Vector3 BJMFJJKFMAF, float EEDKOLOOPKK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6F22D00", Offset = "0x6F21700", VA = "0x186F22D00", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JLBJDDHJOHM(JCBCIKFMAML KEJNJHGGNMJ, Vector3 LCDJINCAHMD, float ONOCCGOPHEL = 7f, float BKJDNLFEDGK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6F22670", Offset = "0x6F21070", VA = "0x186F22670", Slot = "109")]
	public Vector3 IGGKIKFINPM(Vector3 JMDCGOKJIDA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F0B0", Offset = "0x6F1DAB0", VA = "0x186F1F0B0", Slot = "110")]
	public Vector3 AGLJKLOFAKO(Vector3 JMDCGOKJIDA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6F22EF0", Offset = "0x6F218F0", VA = "0x186F22EF0", Slot = "111")]
	public void JOFNHGFIFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6F236C0", Offset = "0x6F220C0", VA = "0x186F236C0", Slot = "112")]
	public void MCGHHLGPCDO(LJEEPNBNNHB KNDIPAMGJEH, object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EF10", Offset = "0x6F1D910", VA = "0x186F1EF10", Slot = "113")]
	public void ABPOJCBHDFP(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FC70", Offset = "0x6F1E670", VA = "0x186F1FC70", Slot = "61")]
	public void BJNIMHBPEJI((Quaternion rot, Vector3 moments) CKEJAFLIMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F23210", Offset = "0x6F21C10", VA = "0x186F23210", Slot = "114")]
	public void KJDIAFCJJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F23BC0", Offset = "0x6F225C0", VA = "0x186F23BC0", Slot = "115")]
	public void MPNLKLPFHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F22F40", Offset = "0x6F21940", VA = "0x186F22F40", Slot = "116")]
	public void JONIHJFPCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F20610", Offset = "0x6F1F010", VA = "0x186F20610", Slot = "117")]
	public bool DBEPKAHMKBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F24440", Offset = "0x6F22E40", VA = "0x186F24440", Slot = "94")]
	public void NMFKFBHACCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F208F0", Offset = "0x6F1F2F0", VA = "0x186F208F0", Slot = "118")]
	public void DENFDBJHBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F20660", Offset = "0x6F1F060", VA = "0x186F20660", Slot = "119")]
	public void DCIFLICONLL(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F231B0", Offset = "0x6F21BB0", VA = "0x186F231B0", Slot = "120")]
	public void KGHICEPBNMM(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F24A20", Offset = "0x6F23420", VA = "0x186F24A20", Slot = "121")]
	public void PAIMJFADCAB(object EOCJCEFCOOA, bool MCDOCGGGECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F20940", Offset = "0x6F1F340", VA = "0x186F20940", Slot = "122")]
	public void DKOHPMAPHGG(Vector3 BELOINIPDIB, Quaternion HJPFNIDEMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F23990", Offset = "0x6F22390", VA = "0x186F23990", Slot = "123")]
	public void MLABCGDNEEH(Vector3 LEDGGONKHOH, Quaternion GNOJHHCJPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F24BC0", Offset = "0x6F235C0", VA = "0x186F24BC0", Slot = "124")]
	public bool PGOKKFJFMGD(float BONLJCBABLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FDB0", Offset = "0x6F1E7B0", VA = "0x186F1FDB0", Slot = "125")]
	public void BKONGIFNHPB(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F20DF0", Offset = "0x6F1F7F0", VA = "0x186F20DF0", Slot = "126")]
	public void DNKOPNCBMHI(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FF80", Offset = "0x6F1E980", VA = "0x186F1FF80", Slot = "127")]
	public void CDBCEDMLJNK(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F24770", Offset = "0x6F23170", VA = "0x186F24770", Slot = "128")]
	public void OLCAAIPHEIP(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F23070", Offset = "0x6F21A70", VA = "0x186F23070", Slot = "129")]
	public void KAPGLCIGOAI(Vector3 AMNFMCIBNPO, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F340", Offset = "0x6F1DD40", VA = "0x186F1F340", Slot = "130")]
	public void APEKDDPMJIA(Vector3 AMNFMCIBNPO, Vector3 HGDCPNGLIKJ, ForceMode HAMIBHDKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F235E0", Offset = "0x6F21FE0", VA = "0x186F235E0", Slot = "131")]
	public void LPEOIJLIBJD(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F22340", Offset = "0x6F20D40", VA = "0x186F22340", Slot = "132")]
	public void HDLFPCCLPMC(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F20CF0", Offset = "0x6F1F6F0", VA = "0x186F20CF0", Slot = "133")]
	public bool DLPAKOEIMOE(Vector3 FCBGHELDCII, [Out] RaycastHit MGGIMCBEOEH, float BKKDIDJOENO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F23470", Offset = "0x6F21E70", VA = "0x186F23470", Slot = "134")]
	public void LFEIJDEHHMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F24FC0", Offset = "0x6F239C0", VA = "0x186F24FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F20F20", Offset = "0x6F1F920", VA = "0x186F20F20")]
	private void EBODCBMBMPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F810", Offset = "0x6F1E210", VA = "0x186F1F810")]
	private void BBEEPJFMBJD(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F24830", Offset = "0x6F23230", VA = "0x186F24830")]
	private void ONHAKDBCCNG(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F1B0", Offset = "0x6F1DBB0", VA = "0x186F1F1B0")]
	private void AHFEECKILMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F22570", Offset = "0x6F20F70", VA = "0x186F22570")]
	private void IDDFEBGHOBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FAF0", Offset = "0x6F1E4F0", VA = "0x186F1FAF0")]
	private void BIAKALOJJNG(LJEEPNBNNHB LKNDHCECGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F22270", Offset = "0x6F20C70", VA = "0x186F22270")]
	private void HCJFHFKIFCI(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F970", Offset = "0x6F1E370", VA = "0x186F1F970")]
	private void BFJIHMPHLJA(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F21B90", Offset = "0x6F20590", VA = "0x186F21B90")]
	private void GFFAHDGIPGI(HJKEDKBDPPP BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F23D10", Offset = "0x6F22710", VA = "0x186F23D10", Slot = "141")]
	protected virtual void NEGBLOEOEHL(HJKEDKBDPPP NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F21F50", Offset = "0x6F20950", VA = "0x186F21F50")]
	protected void HBKMAEIMBKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F450", Offset = "0x6F1DE50", VA = "0x186F1F450")]
	protected void BACAJBCAJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F22770", Offset = "0x6F21170", VA = "0x186F22770", Slot = "142")]
	protected virtual IDisposable IHIINBLEBOJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class FECCMDOKBJL
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F26740", Offset = "0x6F25140", VA = "0x186F26740")]
	public static LJEEPNBNNHB BDBBMKBAFNB(this LJEEPNBNNHB NKIPNFFBDAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F26880", Offset = "0x6F25280", VA = "0x186F26880")]
	public static bool IINKAPCDGDI(this LJEEPNBNNHB NKIPNFFBDAI, LJEEPNBNNHB KPIPNJDNJNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F26900", Offset = "0x6F25300", VA = "0x186F26900")]
	public static bool PKOHNLBLMCB(this LJEEPNBNNHB NKIPNFFBDAI, LJEEPNBNNHB NIOHKOJCMDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F26980", Offset = "0x6F25380", VA = "0x186F26980")]
	public static HJKEDKBDPPP PNBIPFIMHIE(this LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F26800", Offset = "0x6F25200", VA = "0x186F26800")]
	public static AKECFCILGBG DIMEOMPBOHJ(this LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DOJNMGBCOPL : CHMPPNFIFLC
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F259D0", Offset = "0x6F243D0", VA = "0x186F259D0", Slot = "19")]
	public LJEEPNBNNHB BAEHCLHNCHB(RigidbodyEx NKIPNFFBDAI, KPFNKPJMKHJ LINJEFIAFHO, NGLPLNHDEND GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "4")]
	public OBLCMNIHHPA AKEKIEBHBJM(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "5")]
	public HAOKEBMAJGF BDMGOHHJINE(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "6")]
	public OLJDHFEMIEM HAPBJDJMOKP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "7")]
	public BNEAKDEKEGF IJMKDLBCPMP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "8")]
	public JKJFHGFNKMI HPEKAGMBJOF(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "9")]
	public BBELJPEBCDG KJDJCCIJHCL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "10")]
	public IACJBDKKNDH OKCGHCGAIAG(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "11")]
	public MPONMNOKEDF IOLKGNHHCJA(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "12")]
	public KHFOMKPIPGM LBHINPABMFD(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "13")]
	public CJGADINNADB KHOAHPFHAGL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0")]
	public LCNNLPJHPDO KKNJHPKAHML(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0")]
	public ENODCFCBNKN BDCEKGMLOAH(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0")]
	public HAPDGEOPNLL JEELHNMABOD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0")]
	public IGANODCOKHB NCBDCBPKBEJ(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0")]
	public EJDCPCDIDOH DPMMFGFJGFD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public DOJNMGBCOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "14")]
	private LCNNLPJHPDO GHAOFICPAOL(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "15")]
	private ENODCFCBNKN PJEBCMEGNBI(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "16")]
	private HAPDGEOPNLL GDLIICLCEIA(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "17")]
	private IGANODCOKHB EDAECLKGAIE(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F32CC0", Offset = "0x6F316C0", VA = "0x186F32CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6F333B0", Offset = "0x6F31DB0", VA = "0x186F333B0", Slot = "20")]
	public void InitReferences(GANFHFOELEK FGDLGNMCKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6F32AD0", Offset = "0x6F314D0", VA = "0x186F32AD0", Slot = "4")]
	public OBLCMNIHHPA AKEKIEBHBJM(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6F32DD0", Offset = "0x6F317D0", VA = "0x186F32DD0", Slot = "5")]
	public HAOKEBMAJGF BDMGOHHJINE(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6F33130", Offset = "0x6F31B30", VA = "0x186F33130", Slot = "6")]
	public OLJDHFEMIEM HAPBJDJMOKP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6F33270", Offset = "0x6F31C70", VA = "0x186F33270", Slot = "7")]
	public BNEAKDEKEGF IJMKDLBCPMP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6F331D0", Offset = "0x6F31BD0", VA = "0x186F331D0", Slot = "8")]
	public JKJFHGFNKMI HPEKAGMBJOF(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6F334A0", Offset = "0x6F31EA0", VA = "0x186F334A0", Slot = "9")]
	public BBELJPEBCDG KJDJCCIJHCL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6F335E0", Offset = "0x6F31FE0", VA = "0x186F335E0", Slot = "10")]
	public IACJBDKKNDH OKCGHCGAIAG(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6F33310", Offset = "0x6F31D10", VA = "0x186F33310", Slot = "11")]
	public MPONMNOKEDF IOLKGNHHCJA(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6F33540", Offset = "0x6F31F40", VA = "0x186F33540", Slot = "12")]
	public KHFOMKPIPGM LBHINPABMFD(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6F33400", Offset = "0x6F31E00", VA = "0x186F33400", Slot = "13")]
	public CJGADINNADB KHOAHPFHAGL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6F33080", Offset = "0x6F31A80", VA = "0x186F33080")]
	public LCNNLPJHPDO KKNJHPKAHML(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6F32D20", Offset = "0x6F31720", VA = "0x186F32D20")]
	public ENODCFCBNKN BDCEKGMLOAH(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6F32FD0", Offset = "0x6F319D0", VA = "0x186F32FD0")]
	public HAPDGEOPNLL JEELHNMABOD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F32F20", Offset = "0x6F31920", VA = "0x186F32F20")]
	public IGANODCOKHB NCBDCBPKBEJ(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F32E70", Offset = "0x6F31870", VA = "0x186F32E70")]
	public EJDCPCDIDOH DPMMFGFJGFD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6F32B70", Offset = "0x6F31570", VA = "0x186F32B70", Slot = "19")]
	public LJEEPNBNNHB BAEHCLHNCHB(RigidbodyEx NKIPNFFBDAI, KPFNKPJMKHJ LINJEFIAFHO, NGLPLNHDEND GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6F33680", Offset = "0x6F32080", VA = "0x186F33680")]
	public PPBCEGBKCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6F33080", Offset = "0x6F31A80", VA = "0x186F33080", Slot = "14")]
	private LCNNLPJHPDO GHAOFICPAOL(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6F32D20", Offset = "0x6F31720", VA = "0x186F32D20", Slot = "15")]
	private ENODCFCBNKN PJEBCMEGNBI(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6F32FD0", Offset = "0x6F319D0", VA = "0x186F32FD0", Slot = "16")]
	private HAPDGEOPNLL GDLIICLCEIA(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6F32F20", Offset = "0x6F31920", VA = "0x186F32F20", Slot = "17")]
	private IGANODCOKHB EDAECLKGAIE(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6F32E70", Offset = "0x6F31870", VA = "0x186F32E70", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F1D640", Offset = "0x6F1C040", VA = "0x186F1D640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode AIBPEFBJHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6F26380", Offset = "0x6F24D80", VA = "0x186F26380", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6F266D0", Offset = "0x6F250D0", VA = "0x186F266D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E180", Offset = "0x6F1CB80", VA = "0x186F1E180")]
	public FABNLOPBJEE(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F265C0", Offset = "0x6F24FC0", VA = "0x186F265C0", Slot = "6")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6F261A0", Offset = "0x6F24BA0", VA = "0x186F261A0", Slot = "9")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6F26190", Offset = "0x6F24B90", VA = "0x186F26190", Slot = "7")]
	public void ANGDFDOOLIM(bool JMEEMLNLABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6F26490", Offset = "0x6F24E90", VA = "0x186F26490", Slot = "8")]
	public void FOOFBKMEGCH(bool JMEEMLNLABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6F26220", Offset = "0x6F24C20", VA = "0x186F26220", Slot = "10")]
	public bool DLPAKOEIMOE(Vector3 FCBGHELDCII, [Out] RaycastHit MGGIMCBEOEH, float BKKDIDJOENO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6F264A0", Offset = "0x6F24EA0", VA = "0x186F264A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F2A320", Offset = "0x6F28D20", VA = "0x186F2A320", Slot = "6")]
		get
		{
			return default(EEPBOLJHLNK);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A1A0", Offset = "0x6F28BA0", VA = "0x186F2A1A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform OOHDDHCJCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A180", Offset = "0x6F28B80", VA = "0x186F2A180", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<FHBBMPGGCGD, FHBBMPGGCGD> MDHINEPAAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A080", Offset = "0x6F28A80", VA = "0x186F2A080", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A270", Offset = "0x6F28C70", VA = "0x186F2A270", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A6F0", Offset = "0x6F290F0", VA = "0x186F2A6F0")]
	public FNPLKLIGBGF(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A470", Offset = "0x6F28E70", VA = "0x186F2A470", Slot = "8")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A130", Offset = "0x6F28B30", VA = "0x186F2A130", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x978E50", Offset = "0x977850", VA = "0x180978E50", Slot = "11")]
	private void KJBJEIDMPPE(FHBBMPGGCGD KMCHIMPGNCP, FHBBMPGGCGD BNADEAHLELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "12")]
	private void NIMFPOEIGLH(bool ILLAIMLPMFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LCNLKIDNKBB : CHMPPNFIFLC
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F270", Offset = "0x6F2DC70", VA = "0x186F2F270", Slot = "4")]
	public OBLCMNIHHPA AKEKIEBHBJM(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F610", Offset = "0x6F2E010", VA = "0x186F2F610", Slot = "5")]
	public HAOKEBMAJGF BDMGOHHJINE(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FC30", Offset = "0x6F2E630", VA = "0x186F2FC30", Slot = "6")]
	public OLJDHFEMIEM HAPBJDJMOKP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FE30", Offset = "0x6F2E830", VA = "0x186F2FE30", Slot = "7")]
	public BNEAKDEKEGF IJMKDLBCPMP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FD60", Offset = "0x6F2E760", VA = "0x186F2FD60", Slot = "8")]
	public JKJFHGFNKMI HPEKAGMBJOF(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6F30030", Offset = "0x6F2EA30", VA = "0x186F30030", Slot = "9")]
	public BBELJPEBCDG KJDJCCIJHCL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6F301C0", Offset = "0x6F2EBC0", VA = "0x186F301C0", Slot = "10")]
	public IACJBDKKNDH OKCGHCGAIAG(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FEB0", Offset = "0x6F2E8B0", VA = "0x186F2FEB0", Slot = "11")]
	public MPONMNOKEDF IOLKGNHHCJA(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6F30100", Offset = "0x6F2EB00", VA = "0x186F30100", Slot = "12")]
	public KHFOMKPIPGM LBHINPABMFD(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FF70", Offset = "0x6F2E970", VA = "0x186F2FF70", Slot = "13")]
	public CJGADINNADB KHOAHPFHAGL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FAF0", Offset = "0x6F2E4F0", VA = "0x186F2FAF0")]
	public LCNNLPJHPDO KKNJHPKAHML(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F480", Offset = "0x6F2DE80", VA = "0x186F2F480")]
	public ENODCFCBNKN BDCEKGMLOAH(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F9C0", Offset = "0x6F2E3C0", VA = "0x186F2F9C0")]
	public HAPDGEOPNLL JEELHNMABOD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F820", Offset = "0x6F2E220", VA = "0x186F2F820")]
	public IGANODCOKHB NCBDCBPKBEJ(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F740", Offset = "0x6F2E140", VA = "0x186F2F740")]
	public EJDCPCDIDOH DPMMFGFJGFD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F360", Offset = "0x6F2DD60", VA = "0x186F2F360", Slot = "19")]
	public LJEEPNBNNHB BAEHCLHNCHB(RigidbodyEx NKIPNFFBDAI, KPFNKPJMKHJ LINJEFIAFHO, NGLPLNHDEND GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public LCNLKIDNKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FAF0", Offset = "0x6F2E4F0", VA = "0x186F2FAF0", Slot = "14")]
	private LCNNLPJHPDO GHAOFICPAOL(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F480", Offset = "0x6F2DE80", VA = "0x186F2F480", Slot = "15")]
	private ENODCFCBNKN PJEBCMEGNBI(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F9C0", Offset = "0x6F2E3C0", VA = "0x186F2F9C0", Slot = "16")]
	private HAPDGEOPNLL GDLIICLCEIA(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F820", Offset = "0x6F2E220", VA = "0x186F2F820", Slot = "17")]
	private IGANODCOKHB EDAECLKGAIE(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F740", Offset = "0x6F2E140", VA = "0x186F2F740", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F1D640", Offset = "0x6F1C040", VA = "0x186F1D640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool PBLHJBGBIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DED0", Offset = "0x6F1C8D0", VA = "0x186F1DED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool KIMLMAODMNF
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D690", Offset = "0x6F1C090", VA = "0x186F1D690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private LJEEPNBNNHB EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D950", Offset = "0x6F1C350", VA = "0x186F1D950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E180", Offset = "0x6F1CB80", VA = "0x186F1E180")]
	public ACBPOFJKBCC(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D9B0", Offset = "0x6F1C3B0", VA = "0x186F1D9B0", Slot = "4")]
	public void KAPGLCIGOAI(Vector3 AMNFMCIBNPO, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DF20", Offset = "0x6F1C920", VA = "0x186F1DF20")]
	private void PHBDKNPPCAL(Vector3 AMNFMCIBNPO, ForceMode HAMIBHDKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D3C0", Offset = "0x6F1BDC0", VA = "0x186F1D3C0", Slot = "5")]
	public void APEKDDPMJIA(Vector3 AMNFMCIBNPO, Vector3 HGDCPNGLIKJ, ForceMode HAMIBHDKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DB10", Offset = "0x6F1C510", VA = "0x186F1DB10", Slot = "6")]
	public void LPEOIJLIBJD(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DC70", Offset = "0x6F1C670", VA = "0x186F1DC70")]
	private void NDNOFKHGIEM(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D6F0", Offset = "0x6F1C0F0", VA = "0x186F1D6F0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x91FDA0", Offset = "0x91E7A0", VA = "0x18091FDA0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6F25100", Offset = "0x6F23B00", VA = "0x186F25100", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E180", Offset = "0x6F1CB80", VA = "0x186F1E180")]
	public APECLDGCONL(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6F250D0", Offset = "0x6F23AD0", VA = "0x186F250D0", Slot = "6")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6F25210", Offset = "0x6F23C10", VA = "0x186F25210", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F2AE10", Offset = "0x6F29810", VA = "0x186F2AE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public LJEEPNBNNHB EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x856BA0", Offset = "0x8555A0", VA = "0x180856BA0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C720", Offset = "0x6F2B120", VA = "0x186F2C720", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public LJEEPNBNNHB DHCIAOJNIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x856A90", Offset = "0x855490", VA = "0x180856A90", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<LJEEPNBNNHB> PLOBAPBGHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x856320", Offset = "0x854D20", VA = "0x180856320", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event CEJKOKAHCJG GOMCPIIALCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B980", Offset = "0x6F2A380", VA = "0x186F2B980", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6F2AC40", Offset = "0x6F29640", VA = "0x186F2AC40", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event CEJKOKAHCJG KNBPNKNELBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C680", Offset = "0x6F2B080", VA = "0x186F2C680", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B070", Offset = "0x6F29A70", VA = "0x186F2B070", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event KFNJEADEOOD OLAGEKEIEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B1D0", Offset = "0x6F29BD0", VA = "0x186F2B1D0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C5E0", Offset = "0x6F2AFE0", VA = "0x186F2C5E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action DEIDEILNFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C350", Offset = "0x6F2AD50", VA = "0x186F2C350", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C3F0", Offset = "0x6F2ADF0", VA = "0x186F2C3F0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action GHDCKGFKHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C540", Offset = "0x6F2AF40", VA = "0x186F2C540", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B320", Offset = "0x6F29D20", VA = "0x186F2B320", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<LJEEPNBNNHB> DMOBOFFADLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B5F0", Offset = "0x6F29FF0", VA = "0x186F2B5F0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B540", Offset = "0x6F29F40", VA = "0x186F2B540", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<LJEEPNBNNHB> CINCKADPPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C490", Offset = "0x6F2AE90", VA = "0x186F2C490", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6F2AFC0", Offset = "0x6F299C0", VA = "0x186F2AFC0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action JPDIHOFJFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B460", Offset = "0x6F29E60", VA = "0x186F2B460", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B8E0", Offset = "0x6F2A2E0", VA = "0x186F2B8E0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<LJEEPNBNNHB> IHFECPECMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6F2B270", Offset = "0x6F29C70", VA = "0x186F2B270", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6F2AE70", Offset = "0x6F29870", VA = "0x186F2AE70", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C7D0", Offset = "0x6F2B1D0", VA = "0x186F2C7D0")]
	public HHFBFHNOBOA(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6F2AF20", Offset = "0x6F29920", VA = "0x186F2AF20", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6F2BA20", Offset = "0x6F2A420", VA = "0x186F2BA20", Slot = "30")]
	public void MMADMDAOMMK(LJEEPNBNNHB KGHLFFBGAIM, bool DCIOAOCCLNO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6F2BFA0", Offset = "0x6F2A9A0", VA = "0x186F2BFA0", Slot = "6")]
	public void MMINCMFEKID(LJEEPNBNNHB LKNDHCECGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A9C0", Offset = "0x6F293C0", VA = "0x186F2A9C0", Slot = "7")]
	public void AAKBDKKNEBM(LJEEPNBNNHB LKNDHCECGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B6A0", Offset = "0x6F2A0A0", VA = "0x186F2B6A0", Slot = "4")]
	public void LGJHIGDGICA(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C730", Offset = "0x6F2B130", VA = "0x186F2C730", Slot = "5")]
	public void PMFKCEMIMAH(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B3C0", Offset = "0x6F29DC0", VA = "0x186F2B3C0")]
	private void HOPFFNNEJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B500", Offset = "0x6F29F00", VA = "0x186F2B500")]
	private void IHGHEGFMBLF(LJEEPNBNNHB LKNDHCECGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C210", Offset = "0x6F2AC10", VA = "0x186F2C210")]
	private void NAIOIGCEJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6F2ACE0", Offset = "0x6F296E0", VA = "0x186F2ACE0")]
	private void CBAJHLGCLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B7B0", Offset = "0x6F2A1B0", VA = "0x186F2B7B0")]
	private void LPOHGFPNNLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B110", Offset = "0x6F29B10", VA = "0x186F2B110")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F25350", Offset = "0x6F23D50", VA = "0x186F25350")]
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
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 CHBOEELJBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6F31C70", Offset = "0x6F30670", VA = "0x186F31C70", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 EHOGFCCMBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6F32430", Offset = "0x6F30E30", VA = "0x186F32430", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 JGCPBAEFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6F325F0", Offset = "0x6F30FF0", VA = "0x186F325F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public LJEEPNBNNHB BBIBDDHIDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6F31BC0", Offset = "0x6F305C0", VA = "0x186F31BC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6F326E0", Offset = "0x6F310E0", VA = "0x186F326E0")]
	public OJPLLKCCNPL(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6F323C0", Offset = "0x6F30DC0", VA = "0x186F323C0", Slot = "8")]
	public void JOFFLJFDKEL(LJEEPNBNNHB BMBBFJPOJEB, object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6F31B60", Offset = "0x6F30560", VA = "0x186F31B60", Slot = "9")]
	public void ANLGKCFDEGE(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F31CA0", Offset = "0x6F306A0", VA = "0x186F31CA0")]
	private Vector3 FCDEPHNHPAB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6F32030", Offset = "0x6F30A30", VA = "0x186F32030")]
	private void FEMBAJMCIGK(LJEEPNBNNHB BAMJAECANAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class LLCLGPOGBEE
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6F30E50", Offset = "0x6F2F850", VA = "0x186F30E50")]
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
		[Cpp2IlInjected.Address(RVA = "0xD71C80", Offset = "0xD70680", VA = "0x180D71C80", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DB20", Offset = "0x6F2C520", VA = "0x186F2DB20", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 MLGKNLKHOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DFA0", Offset = "0x6F2C9A0", VA = "0x186F2DFA0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float CNPKCGDBOHH
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8BE940", Offset = "0x8BD340", VA = "0x1808BE940", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E700", Offset = "0x6F2D100", VA = "0x186F2E700")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float FKLAKHONCEG
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA50", Offset = "0x8BD450", VA = "0x1808BEA50", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C890", Offset = "0x6F2B290", VA = "0x186F2C890", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 GLAIIHKCPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DE10", Offset = "0x6F2C810", VA = "0x186F2DE10", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion IFMMPIPGKAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E220", Offset = "0x6F2CC20", VA = "0x186F2E220", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody DHIIHPKBDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C940", Offset = "0x6F2B340", VA = "0x186F2C940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event CEJKOKAHCJG PPJCEIJIBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6F2EEA0", Offset = "0x6F2D8A0", VA = "0x186F2EEA0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DBD0", Offset = "0x6F2C5D0", VA = "0x186F2DBD0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F110", Offset = "0x6F2DB10", VA = "0x186F2F110")]
	public KOADCEMAONI(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E550", Offset = "0x6F2CF50", VA = "0x186F2E550", Slot = "17")]
	public void KJDIAFCJJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F2EF40", Offset = "0x6F2D940", VA = "0x186F2EF40", Slot = "16")]
	public void MPNLKLPFHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DA40", Offset = "0x6F2C440", VA = "0x186F2DA40", Slot = "19")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F2ECB0", Offset = "0x6F2D6B0", VA = "0x186F2ECB0", Slot = "20")]
	public void MBFMCBMPPJM(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E3A0", Offset = "0x6F2CDA0", VA = "0x186F2E3A0", Slot = "18")]
	public void JONIHJFPCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E810", Offset = "0x6F2D210", VA = "0x186F2E810", Slot = "21")]
	public void LFEIJDEHHMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DB20", Offset = "0x6F2C520", VA = "0x186F2DB20")]
	private void DJLOHHFJMPH(Vector3 JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F020", Offset = "0x6F2DA20", VA = "0x186F2F020")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 OFNHKOLKBOB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E700", Offset = "0x6F2D100", VA = "0x186F2E700")]
	private void KLJCBMHBLJO(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C890", Offset = "0x6F2B290", VA = "0x186F2C890")]
	private void FELHKLHIBFA(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DC70", Offset = "0x6F2C670", VA = "0x186F2DC70")]
	private Vector3 FEFNEPMKIHI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F2D810", Offset = "0x6F2C210", VA = "0x186F2D810", Slot = "15")]
	public void BJNIMHBPEJI((Quaternion rot, Vector3 moments) CKEJAFLIMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F2E0A0", Offset = "0x6F2CAA0", VA = "0x186F2E0A0")]
	private Quaternion HELIIBEMCHE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C990", Offset = "0x6F2B390", VA = "0x186F2C990")]
	public void BJEDCAPDABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F2CA60", Offset = "0x6F2B460", VA = "0x186F2CA60", Slot = "4")]
	public (float, Vector3) BJEDCAPDABC(Rigidbody POEMMNMNOEI)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class DNCCJLAIPBI
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F25910", Offset = "0x6F24310", VA = "0x186F25910")]
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
		[Cpp2IlInjected.Address(RVA = "0xEF1880", Offset = "0xEF0280", VA = "0x180EF1880", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public ONPHIJJLPGG FFLGFNAAOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8CDB30", Offset = "0x8CC530", VA = "0x1808CDB30", Slot = "11")]
		get
		{
			return default(ONPHIJJLPGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F26090", Offset = "0x6F24A90", VA = "0x186F26090")]
	public ECMKJAPAOJP(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F25FC0", Offset = "0x6F249C0", VA = "0x186F25FC0", Slot = "4")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F25A70", Offset = "0x6F24470", VA = "0x186F25A70")]
	private bool ABMDCKKGGNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F25DA0", Offset = "0x6F247A0", VA = "0x186F25DA0", Slot = "5")]
	public void DGEPFNEICCP(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F25DD0", Offset = "0x6F247D0", VA = "0x186F25DD0", Slot = "6")]
	public void HGCOKOEFMOK(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F25E80", Offset = "0x6F24880", VA = "0x186F25E80", Slot = "9")]
	public void OMOOHCBNEBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F25B10", Offset = "0x6F24510", VA = "0x186F25B10")]
	private void ANKLEIFGGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F25C30", Offset = "0x6F24630", VA = "0x186F25C30")]
	private void BLKAFMDMCKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F25E40", Offset = "0x6F24840", VA = "0x186F25E40", Slot = "8")]
	public void ICGJKBEJBIA(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F25E00", Offset = "0x6F24800", VA = "0x186F25E00", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F25690", Offset = "0x6F24090", VA = "0x186F25690", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event CEJKOKAHCJG IDADILKKDPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F254B0", Offset = "0x6F23EB0", VA = "0x186F254B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F25780", Offset = "0x6F24180", VA = "0x186F25780", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F25820", Offset = "0x6F24220", VA = "0x186F25820")]
	public CBFOKBIICLF(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F25490", Offset = "0x6F23E90", VA = "0x186F25490", Slot = "7")]
	public void DCIFLICONLL(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F254A0", Offset = "0x6F23EA0", VA = "0x186F254A0", Slot = "8")]
	public void KGHICEPBNMM(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F25580", Offset = "0x6F23F80", VA = "0x186F25580", Slot = "9")]
	public void PAIMJFADCAB(object EOCJCEFCOOA, bool MCDOCGGGECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F25740", Offset = "0x6F24140", VA = "0x186F25740", Slot = "12")]
	public void PGGABFKDEIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F25410", Offset = "0x6F23E10", VA = "0x186F25410", Slot = "10")]
	public void BPPFGEIDBGG(Rigidbody KLDLKACCMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F25550", Offset = "0x6F23F50", VA = "0x186F25550", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool GGCJPCDEOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E4D0", Offset = "0x6F1CED0", VA = "0x186F1E4D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool OMMEKKCNHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D560", Offset = "0xA6BF60", VA = "0x180A6D560", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event CEJKOKAHCJG HFEDDJKAHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E760", Offset = "0x6F1D160", VA = "0x186F1E760", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F1EA70", Offset = "0x6F1D470", VA = "0x186F1EA70", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EDB0", Offset = "0x6F1D7B0", VA = "0x186F1EDB0")]
	public AKBAGCBMKNB(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EC80", Offset = "0x6F1D680", VA = "0x186F1EC80", Slot = "9")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E4F0", Offset = "0x6F1CEF0", VA = "0x186F1E4F0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E5F0", Offset = "0x6F1CFF0", VA = "0x186F1E5F0", Slot = "10")]
	public void HCJFHFKIFCI(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E210", Offset = "0x6F1CC10", VA = "0x186F1E210", Slot = "11")]
	public void BFJIHMPHLJA(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EB10", Offset = "0x6F1D510", VA = "0x186F1EB10")]
	private void PJAMIBLLAJO(PhotonView PFDHDOKBLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E380", Offset = "0x6F1CD80", VA = "0x186F1E380")]
	private void BNJLKAAGMEP(HJKEDKBDPPP LAOPCGKBCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E800", Offset = "0x6F1D200", VA = "0x186F1E800")]
	private void NDFEOOIBOKA(PhotonView AEPHECJCJCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class PIBKLLMHDEL
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F32A10", Offset = "0x6F31410", VA = "0x186F32A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF0C00", Offset = "0xCEF600", VA = "0x180CF0C00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x44E92C0", Offset = "0x44E7CC0", VA = "0x1844E92C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool BHGJNLBILDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xF3FD80", Offset = "0xF3E780", VA = "0x180F3FD80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x44E92B0", Offset = "0x44E7CB0", VA = "0x1844E92B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints OFGMKLMDGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E710", VA = "0x18085FD10", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A7B0", Offset = "0x6F291B0", VA = "0x186F2A7B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A910", Offset = "0x6F29310", VA = "0x186F2A910")]
	public HGPMOBDFJND(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A780", Offset = "0x6F29180", VA = "0x186F2A780", Slot = "9")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A8E0", Offset = "0x6F292E0", VA = "0x186F2A8E0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BEAD0", Offset = "0x8BD4D0", VA = "0x1808BEAD0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F318E0", Offset = "0x6F302E0", VA = "0x186F318E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float JJGEJCPKFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA90", Offset = "0x8BD490", VA = "0x1808BEA90", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F319B0", Offset = "0x6F303B0", VA = "0x186F319B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F31B20", Offset = "0x6F30520", VA = "0x186F31B20")]
	public OEANOHBDAAL(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F31890", Offset = "0x6F30290", VA = "0x186F31890", Slot = "8")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F31A80", Offset = "0x6F30480", VA = "0x186F31A80", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F2C940", Offset = "0x6F2B340", VA = "0x186F2C940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool CBCMAKKEDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F30C70", Offset = "0x6F2F670", VA = "0x186F30C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private LJEEPNBNNHB EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F309C0", Offset = "0x6F2F3C0", VA = "0x186F309C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool KIMLMAODMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F30350", Offset = "0x6F2ED50", VA = "0x186F30350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event CEJKOKAHCJG PDPOOKEFDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F30BD0", Offset = "0x6F2F5D0", VA = "0x186F30BD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F30910", Offset = "0x6F2F310", VA = "0x186F30910", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F30DC0", Offset = "0x6F2F7C0", VA = "0x186F30DC0")]
	public LIBCLCOHFFF(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F30D30", Offset = "0x6F2F730", VA = "0x186F30D30", Slot = "6")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F309B0", Offset = "0x6F2F3B0", VA = "0x186F309B0", Slot = "8")]
	public void HACGNHECFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F303B0", Offset = "0x6F2EDB0", VA = "0x186F303B0", Slot = "7")]
	public bool DBEPKAHMKBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F30C90", Offset = "0x6F2F690", VA = "0x186F30C90", Slot = "9")]
	public void NMFKFBHACCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F30500", Offset = "0x6F2EF00", VA = "0x186F30500", Slot = "11")]
	public void DENFDBJHBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F30A20", Offset = "0x6F2F420", VA = "0x186F30A20", Slot = "10")]
	public void IMKIFNNMNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F30730", Offset = "0x6F2F130", VA = "0x186F30730")]
	private bool EHDEBMFGJFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F305A0", Offset = "0x6F2EFA0", VA = "0x186F305A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851270", VA = "0x180852870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool KIMLMAODMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D690", Offset = "0x6F1C090", VA = "0x186F1D690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool KLCPPBHBKKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xEF1880", Offset = "0xEF0280", VA = "0x180EF1880", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F31780", Offset = "0x6F30180", VA = "0x186F31780")]
	public NGEKODKPLMJ(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F314F0", Offset = "0x6F2FEF0", VA = "0x186F314F0", Slot = "5")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F30FE0", Offset = "0x6F2F9E0", VA = "0x186F30FE0", Slot = "7")]
	public void CDBCEDMLJNK(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F314C0", Offset = "0x6F2FEC0", VA = "0x186F314C0", Slot = "8")]
	public void OLCAAIPHEIP(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6F31190", Offset = "0x6F2FB90", VA = "0x186F31190", Slot = "9")]
	public void IGNDFADNBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6F31590", Offset = "0x6F2FF90", VA = "0x186F31590", Slot = "10")]
	public void PLNIPPDHELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6F31010", Offset = "0x6F2FA10", VA = "0x186F31010", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855340", VA = "0x180856940", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8579C0", VA = "0x180858FC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public LIJOKMDFOFH MCJHNAIMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8555C0", VA = "0x180856BC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x859EC0", VA = "0x18085B4C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 JGCPBAEFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x6F29940", Offset = "0x6F28340", VA = "0x186F29940", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6F28890", Offset = "0x6F27290", VA = "0x186F28890", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 PCBLAEINONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6F28AE0", Offset = "0x6F274E0", VA = "0x186F28AE0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6F27420", Offset = "0x6F25E20", VA = "0x186F27420", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 DOJOOKOADMA
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6F296C0", Offset = "0x6F280C0", VA = "0x186F296C0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6F27630", Offset = "0x6F26030", VA = "0x186F27630", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 NNHDGLHBCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6F279C0", Offset = "0x6F263C0", VA = "0x186F279C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6F27AF0", Offset = "0x6F264F0", VA = "0x186F27AF0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float OBLJBMFPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE9B0", Offset = "0x8BD3B0", VA = "0x1808BE9B0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6F26B70", Offset = "0x6F25570", VA = "0x186F26B70", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool BOOAKEKDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x18C0450", Offset = "0x18BEE50", VA = "0x1818C0450", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private MPONMNOKEDF FDMIHFIIOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6750AC0", Offset = "0x674F4C0", VA = "0x186750AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool CBCMAKKEDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6F29030", Offset = "0x6F27A30", VA = "0x186F29030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6F29F90", Offset = "0x6F28990", VA = "0x186F29F90")]
	public FIHADBAPKAD(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6F27D60", Offset = "0x6F26760", VA = "0x186F27D60", Slot = "19")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6F277A0", Offset = "0x6F261A0", VA = "0x186F277A0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6F27230", Offset = "0x6F25C30", VA = "0x186F27230", Slot = "28")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xD2C7A0", Offset = "0xD2B1A0", VA = "0x180D2C7A0", Slot = "20")]
	public void KBNPIHBKMOE(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xD2AF30", Offset = "0xD29930", VA = "0x180D2AF30", Slot = "30")]
	public void NLMCONACPDB(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6F27450", Offset = "0x6F25E50", VA = "0x186F27450", Slot = "35")]
	public Vector3 CMIOFOLPDBD(Vector3 FIMFMOJFCFJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6F27800", Offset = "0x6F26200", VA = "0x186F27800", Slot = "34")]
	public Vector3 EHACCJENFAB(Vector3 NOGFFKGBCOL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6F27D60", Offset = "0x6F26760", VA = "0x186F27D60", Slot = "27")]
	public void FOFMMMJGGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6F27360", Offset = "0x6F25D60", VA = "0x186F27360", Slot = "25")]
	public void CELBLPAFCIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6F29F30", Offset = "0x6F28930", VA = "0x186F29F30", Slot = "24")]
	public void PMEPFJEJIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6F27B20", Offset = "0x6F26520", VA = "0x186F27B20", Slot = "33")]
	public void FLNMHLJEABK(Vector3 HFOBNBKELJL, Vector3 MHBEFOAKJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6F273C0", Offset = "0x6F25DC0", VA = "0x186F273C0", Slot = "32")]
	public void CHAAMCPOLKD(Vector3 JNININDALMJ, Vector3 IGMBCDNHIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6F269D0", Offset = "0x6F253D0", VA = "0x186F269D0", Slot = "31")]
	public void ADFDPALOCLC(Vector3 HGGENDDBBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6F29050", Offset = "0x6F27A50", VA = "0x186F29050", Slot = "22")]
	public void OEHCHBFDEKM(CJOGEGMLKDO OEJNBMLJOIB, Vector3 NBOECIFPPEF, float AHEAGOIPKJF, float CNMGOEBKPGK = 8f, float IMBABICPDKH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6F28C00", Offset = "0x6F27600", VA = "0x186F28C00", Slot = "21")]
	public void LDGDMKCOGAH(JCBCIKFMAML KEJNJHGGNMJ, Vector3 BJMFJJKFMAF, float EEDKOLOOPKK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6F284A0", Offset = "0x6F26EA0", VA = "0x186F284A0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JLBJDDHJOHM(JCBCIKFMAML KEJNJHGGNMJ, Vector3 LCDJINCAHMD, float ONOCCGOPHEL = 7f, float BKJDNLFEDGK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xE309A0", Offset = "0xE2F3A0", VA = "0x180E309A0")]
	private static void CNEEAMJCMOP(Vector3 GPJLHMNPICC, Vector3 NFFLDAHKGKD, [Out] Vector3 OPMHPIHPDOH, [Out] Vector3 CEIIPAPENEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6F283C0", Offset = "0x6F26DC0", VA = "0x186F283C0", Slot = "29")]
	public Vector3 IGGKIKFINPM(Vector3 GPJLHMNPICC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6F28950", Offset = "0x6F27350", VA = "0x186F28950", Slot = "26")]
	public void JOFNHGFIFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6F26B70", Offset = "0x6F25570", VA = "0x186F26B70")]
	private void AIOGMGGHDKM(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6F28E90", Offset = "0x6F27890", VA = "0x186F28E90")]
	private void MHAHPHBFLCI(Vector3 BJMFJJKFMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6F29820", Offset = "0x6F28220", VA = "0x186F29820")]
	private Vector3 OOAPJNOBCPA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6F26C80", Offset = "0x6F25680", VA = "0x186F26C80")]
	private void AJGHMPFPAMD(Vector3 NOGFFKGBCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6F27110", Offset = "0x6F25B10", VA = "0x186F27110")]
	private Vector3 BGIAFHGNAFC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6F29AA0", Offset = "0x6F284A0", VA = "0x186F29AA0")]
	private void PDHGDFGJFJA(Vector3 JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6F27E10", Offset = "0x6F26810", VA = "0x186F27E10")]
	private void HEBCAMHGKPG(Vector3 NOGFFKGBCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6F276F0", Offset = "0x6F260F0", VA = "0x186F276F0")]
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
