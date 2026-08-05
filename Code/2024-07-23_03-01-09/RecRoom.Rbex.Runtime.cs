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
		[Cpp2IlInjected.Address(RVA = "0x6F4FAF0", Offset = "0x6F4ECF0", VA = "0x186F4FAF0", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855B40", VA = "0x180856940", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x14F2F20", Offset = "0x14F2120", VA = "0x1814F2F20", Slot = "5")]
		public override void GGDGBHPPNIB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F57910", Offset = "0x6F56B10", VA = "0x186F57910")]
		private void AOCOLDKKJHF(FCHLICHCLOD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F57C10", Offset = "0x6F56E10", VA = "0x186F57C10", Slot = "6")]
		public override void KNAPKCNJDIM(FCHLICHCLOD registry, [In] NGGDAGDIDAI filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "8")]
		public override void KCOPNMGFKOP(GOMCEOHIOKI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F57C70", Offset = "0x6F56E70", VA = "0x186F57C70")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F53330", Offset = "0x6F52530", VA = "0x186F53330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LJEEPNBNNHB HGPLEJGEAPO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int DGFFNAGFKDO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F54D80", Offset = "0x6F53F80", VA = "0x186F54D80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx BOHHFPAPAAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F550E0", Offset = "0x6F542E0", VA = "0x186F550E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx DHCIAOJNIGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F55020", Offset = "0x6F54220", VA = "0x186F55020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx BMBBFJPOJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6F55D80", Offset = "0x6F54F80", VA = "0x186F55D80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F57280", Offset = "0x6F56480", VA = "0x186F57280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform CCIHBJHNFDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x87B710", Offset = "0x87A910", VA = "0x18087B710", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform NFGKEMNGCHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x87B710", Offset = "0x87A910", VA = "0x18087B710", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public EEPBOLJHLNK MCAKOHHFPJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F54DE0", Offset = "0x6F53FE0", VA = "0x186F54DE0")]
			get
			{
				return default(EEPBOLJHLNK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F56A30", Offset = "0x6F55C30", VA = "0x186F56A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GGCJPCDEOFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F553F0", Offset = "0x6F545F0", VA = "0x186F553F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool OMMEKKCNHOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F54F00", Offset = "0x6F54100", VA = "0x186F54F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public GCCHGDAONKB GLMHBPJHKEB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F55330", Offset = "0x6F54530", VA = "0x186F55330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F56BF0", Offset = "0x6F55DF0", VA = "0x186F56BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LIJOKMDFOFH MCJHNAIMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F552D0", Offset = "0x6F544D0", VA = "0x186F552D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F56B80", Offset = "0x6F55D80", VA = "0x186F56B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool BOOAKEKDDLH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F55220", Offset = "0x6F54420", VA = "0x186F55220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody DHIIHPKBDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F55280", Offset = "0x6F54480", VA = "0x186F55280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool FKLLLKFDFMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F54F60", Offset = "0x6F54160", VA = "0x186F54F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F56AA0", Offset = "0x6F55CA0", VA = "0x186F56AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool FNFOMIAJIKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6C31D60", Offset = "0x6C30F60", VA = "0x186C31D60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float MFLAEOCINDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F55D20", Offset = "0x6F54F20", VA = "0x186F55D20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float NLILMFBCLII
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F55CC0", Offset = "0x6F54EC0", VA = "0x186F55CC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F57210", Offset = "0x6F56410", VA = "0x186F57210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float MFICPAKCDLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F55650", Offset = "0x6F54850", VA = "0x186F55650")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F56E90", Offset = "0x6F56090", VA = "0x186F56E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float JPAHPGHKFID
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F55450", Offset = "0x6F54650", VA = "0x186F55450")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6F56C60", Offset = "0x6F55E60", VA = "0x186F56C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool GEOCOMMJHCI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6F562D0", Offset = "0x6F554D0", VA = "0x186F562D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F577C0", Offset = "0x6F569C0", VA = "0x186F577C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 OKJPOCNNKIP
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F55AA0", Offset = "0x6F54CA0", VA = "0x186F55AA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F56FE0", Offset = "0x6F561E0", VA = "0x186F56FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 GNEGFFPGDPL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F56410", Offset = "0x6F55610", VA = "0x186F56410")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode OHMIAFIIEPI
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F55590", Offset = "0x6F54790", VA = "0x186F55590")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6F56DB0", Offset = "0x6F55FB0", VA = "0x186F56DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float OBLJBMFPBCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F54FC0", Offset = "0x6F541C0", VA = "0x186F54FC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F56B10", Offset = "0x6F55D10", VA = "0x186F56B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints JPAPNIOBBKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F555F0", Offset = "0x6F547F0", VA = "0x186F555F0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F56E20", Offset = "0x6F56020", VA = "0x186F56E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 FNLEIIJLBBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F55E40", Offset = "0x6F55040", VA = "0x186F55E40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 MPCBIACINGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F55E40", Offset = "0x6F55040", VA = "0x186F55E40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F575A0", Offset = "0x6F567A0", VA = "0x186F575A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float AHDCCDIOAPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6F55B80", Offset = "0x6F54D80", VA = "0x186F55B80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F570C0", Offset = "0x6F562C0", VA = "0x186F570C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NGAMAICEFKI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F56270", Offset = "0x6F55470", VA = "0x186F56270")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F57750", Offset = "0x6F56950", VA = "0x186F57750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion BHIAAANLCMM
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F55F20", Offset = "0x6F55120", VA = "0x186F55F20")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F57320", Offset = "0x6F56520", VA = "0x186F57320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion ONNKAJNPEEG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F561A0", Offset = "0x6F553A0", VA = "0x186F561A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6F57680", Offset = "0x6F56880", VA = "0x186F57680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 FPHICFGFPKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F55FF0", Offset = "0x6F551F0", VA = "0x186F55FF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6F573F0", Offset = "0x6F565F0", VA = "0x186F573F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion PFGGMIAAHLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F560D0", Offset = "0x6F552D0", VA = "0x186F560D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6F574D0", Offset = "0x6F566D0", VA = "0x186F574D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 GPJLHMNPICC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F56330", Offset = "0x6F55530", VA = "0x186F56330")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6F57830", Offset = "0x6F56A30", VA = "0x186F57830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 NOGFFKGBCOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6F55BE0", Offset = "0x6F54DE0", VA = "0x186F55BE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6F57130", Offset = "0x6F56330", VA = "0x186F57130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 FJCOMDPBLBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6F554B0", Offset = "0x6F546B0", VA = "0x186F554B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6F56CD0", Offset = "0x6F55ED0", VA = "0x186F56CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 IGMBCDNHIBE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6F559C0", Offset = "0x6F54BC0", VA = "0x186F559C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6F56F00", Offset = "0x6F56100", VA = "0x186F56F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 CKKOBMDHEHP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6F55880", Offset = "0x6F54A80", VA = "0x186F55880")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion PBLCAIBKDLE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6F557B0", Offset = "0x6F549B0", VA = "0x186F557B0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 IHBGJBAOAJE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6F565D0", Offset = "0x6F557D0", VA = "0x186F565D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 NAPNEBENMHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6F564F0", Offset = "0x6F556F0", VA = "0x186F564F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool JMEEMLNLABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6F55960", Offset = "0x6F54B60", VA = "0x186F55960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool HJFGMLFHNIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6F55390", Offset = "0x6F54590", VA = "0x186F55390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool GFHIPOLMMFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6F54EA0", Offset = "0x6F540A0", VA = "0x186F54EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool FGNIPGKHKKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6F54E40", Offset = "0x6F54040", VA = "0x186F54E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DKNNPMBIPBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6F54D20", Offset = "0x6F53F20", VA = "0x186F54D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool FNJKLOEFDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6F556B0", Offset = "0x6F548B0", VA = "0x186F556B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HPJBMFGHLLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x594E670", Offset = "0x594D870", VA = "0x18594E670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event KFNJEADEOOD LICFJNGNCOE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F54C40", Offset = "0x6F53E40", VA = "0x186F54C40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6F56950", Offset = "0x6F55B50", VA = "0x186F56950")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CEJKOKAHCJG GOMCPIIALCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6F549B0", Offset = "0x6F53BB0", VA = "0x186F549B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6F566B0", Offset = "0x6F558B0", VA = "0x186F566B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event CEJKOKAHCJG KNBPNKNELBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F54A10", Offset = "0x6F53C10", VA = "0x186F54A10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6F56720", Offset = "0x6F55920", VA = "0x186F56720")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event CEJKOKAHCJG LALHICAPNBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6F54B60", Offset = "0x6F53D60", VA = "0x186F54B60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6F56870", Offset = "0x6F55A70", VA = "0x186F56870")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<FHBBMPGGCGD, FHBBMPGGCGD> MDHINEPAAFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F54AF0", Offset = "0x6F53CF0", VA = "0x186F54AF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F56800", Offset = "0x6F55A00", VA = "0x186F56800")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event CEJKOKAHCJG CLKHELDEPHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F54BD0", Offset = "0x6F53DD0", VA = "0x186F54BD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F568E0", Offset = "0x6F55AE0", VA = "0x186F568E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event CEJKOKAHCJG BIJPPNGOHEI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F54CB0", Offset = "0x6F53EB0", VA = "0x186F54CB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F569C0", Offset = "0x6F55BC0", VA = "0x186F569C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event CEJKOKAHCJG HCDKLCFJLOG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F54A80", Offset = "0x6F53C80", VA = "0x186F54A80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F56790", Offset = "0x6F55990", VA = "0x186F56790")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851A70", VA = "0x180852870", Slot = "8")]
		private void DHGOHHBIDBH(LJEEPNBNNHB CIGKBEKHOLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F53A20", Offset = "0x6F52C20", VA = "0x186F53A20")]
		internal void PJIEKOHGLGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F546D0", Offset = "0x6F538D0", VA = "0x186F546D0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody JNPMEKFEALJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F533E0", Offset = "0x6F525E0", VA = "0x186F533E0")]
		public HJKEDKBDPPP GetChild(int DHNLEFJCEAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6F54340", Offset = "0x6F53540", VA = "0x186F54340")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) CKEJAFLIMPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F52EC0", Offset = "0x6F520C0", VA = "0x186F52EC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F53330", Offset = "0x6F52530", VA = "0x186F53330")]
		private LJEEPNBNNHB GBHFCLLMEDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F53110", Offset = "0x6F52310", VA = "0x186F53110")]
		private void EEKIDKGBNNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F53B10", Offset = "0x6F52D10", VA = "0x186F53B10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F53A20", Offset = "0x6F52C20", VA = "0x186F53A20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F53AB0", Offset = "0x6F52CB0", VA = "0x186F53AB0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F53B70", Offset = "0x6F52D70", VA = "0x186F53B70")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F524B0", Offset = "0x6F516B0", VA = "0x186F524B0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F53BD0", Offset = "0x6F52DD0", VA = "0x186F53BD0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F530B0", Offset = "0x6F522B0", VA = "0x186F530B0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F539C0", Offset = "0x6F52BC0", VA = "0x186F539C0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F544A0", Offset = "0x6F536A0", VA = "0x186F544A0")]
		public void SetParent(RigidbodyEx JMDCGOKJIDA, bool DCIOAOCCLNO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F53EE0", Offset = "0x6F530E0", VA = "0x186F53EE0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F53690", Offset = "0x6F52890", VA = "0x186F53690")]
		public bool IsRigidbodyAncestor(RigidbodyEx KPIPNJDNJNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F53770", Offset = "0x6F52970", VA = "0x186F53770")]
		public bool IsRigidbodyDescendant(RigidbodyEx NIOHKOJCMDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F52720", Offset = "0x6F51920", VA = "0x186F52720")]
		public void AddInterpolationRestriction(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F53C40", Offset = "0x6F52E40", VA = "0x186F53C40")]
		public void RemoveInterpolationRestriction(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F52790", Offset = "0x6F51990", VA = "0x186F52790")]
		public void AddKinematic(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F53CB0", Offset = "0x6F52EB0", VA = "0x186F53CB0")]
		public void RemoveKinematic(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F54420", Offset = "0x6F53620", VA = "0x186F54420")]
		public void SetKinematic(object EOCJCEFCOOA, bool MCDOCGGGECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F54240", Offset = "0x6F53440", VA = "0x186F54240")]
		public void SetDiscontinuousPositionAndRotation(Vector3 BELOINIPDIB, Quaternion HJPFNIDEMNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F54140", Offset = "0x6F53340", VA = "0x186F54140")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 LEDGGONKHOH, Quaternion GNOJHHCJPOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F53580", Offset = "0x6F52780", VA = "0x186F53580")]
		public Vector3 GetConstrainedVelocity(Vector3 GPJLHMNPICC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F53470", Offset = "0x6F52670", VA = "0x186F53470")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 FJCOMDPBLBJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F52630", Offset = "0x6F51830", VA = "0x186F52630")]
		public void AddForce(Vector3 AMNFMCIBNPO, ForceMode HAMIBHDKAKH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F52520", Offset = "0x6F51720", VA = "0x186F52520")]
		public void AddForceAtPosition(Vector3 AMNFMCIBNPO, Vector3 HGDCPNGLIKJ, ForceMode HAMIBHDKAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F52960", Offset = "0x6F51B60", VA = "0x186F52960")]
		public void AddTorque(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F52800", Offset = "0x6F51A00", VA = "0x186F52800")]
		public void AddRelativeTorque(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F547A0", Offset = "0x6F539A0", VA = "0x186F547A0")]
		public Vector3 WorldToLocalVelocity(Vector3 FIMFMOJFCFJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F538B0", Offset = "0x6F52AB0", VA = "0x186F538B0")]
		public Vector3 LocalToWorldVelocity(Vector3 NOGFFKGBCOL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F53050", Offset = "0x6F52250", VA = "0x186F53050")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F52FF0", Offset = "0x6F521F0", VA = "0x186F52FF0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F52F90", Offset = "0x6F52190", VA = "0x186F52F90")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F52F30", Offset = "0x6F52130", VA = "0x186F52F30")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F54040", Offset = "0x6F53240", VA = "0x186F54040")]
		public void ResetVelocityWorldSpace(Vector3 HFOBNBKELJL, Vector3 MHBEFOAKJDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F53F40", Offset = "0x6F53140", VA = "0x186F53F40")]
		public void ResetVelocityLocalSpace(Vector3 JNININDALMJ, Vector3 IGMBCDNHIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F53E00", Offset = "0x6F53000", VA = "0x186F53E00")]
		public void ResetLinearVelocityLocalSpace(Vector3 JNININDALMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F545D0", Offset = "0x6F537D0", VA = "0x186F545D0")]
		public bool SweepTest(Vector3 FCBGHELDCII, [Out] RaycastHit MGGIMCBEOEH, float BKKDIDJOENO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F53850", Offset = "0x6F52A50", VA = "0x186F53850")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F54570", Offset = "0x6F53770", VA = "0x186F54570")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F54740", Offset = "0x6F53940", VA = "0x186F54740")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F528F0", Offset = "0x6F51AF0", VA = "0x186F528F0")]
		public void AddShouldHaveUnityRigidbodyToken(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F53D20", Offset = "0x6F52F20", VA = "0x186F53D20")]
		public void RemoveShouldHaveUnityRigidbodyToken(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6F52CF0", Offset = "0x6F51EF0", VA = "0x186F52CF0")]
		public void ApplyForceVelocityChange(CJOGEGMLKDO OEJNBMLJOIB, Vector3 NBOECIFPPEF, float AHEAGOIPKJF, float CNMGOEBKPGK = 8f, float IMBABICPDKH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F52BF0", Offset = "0x6F51DF0", VA = "0x186F52BF0")]
		public void ApplyAngularVelocityChange(JCBCIKFMAML KEJNJHGGNMJ, Vector3 BJMFJJKFMAF, float EEDKOLOOPKK = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F52DB0", Offset = "0x6F51FB0", VA = "0x186F52DB0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(JCBCIKFMAML KEJNJHGGNMJ, Vector3 LCDJINCAHMD, float ONOCCGOPHEL = 7f, float BKJDNLFEDGK = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F52B20", Offset = "0x6F51D20", VA = "0x186F52B20")]
		public bool AllowedScaleChange(float BONLJCBABLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F52A50", Offset = "0x6F51C50", VA = "0x186F52A50")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx KNDIPAMGJEH, object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6F53D90", Offset = "0x6F52F90", VA = "0x186F53D90")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F54940", Offset = "0x6F53B40", VA = "0x186F54940")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x947E80", Offset = "0x947080", VA = "0x180947E80", Slot = "4")]
		private GameObject OJCAIHCGHDH()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x87B710", Offset = "0x87A910", VA = "0x18087B710", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F4EEC0", Offset = "0x6F4E0C0", VA = "0x186F4EEC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public CHMPPNFIFLC KKACPIKCPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F514D0", Offset = "0x6F506D0", VA = "0x186F514D0", Slot = "7")]
	public void InitReferences(GANFHFOELEK FGDLGNMCKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F513C0", Offset = "0x6F505C0", VA = "0x186F513C0", Slot = "6")]
	public LJEEPNBNNHB BAEHCLHNCHB(RigidbodyEx NKIPNFFBDAI, KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F52310", Offset = "0x6F51510", VA = "0x186F52310")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F52350", Offset = "0x6F51550", VA = "0x186F52350")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F52330", Offset = "0x6F51530", VA = "0x186F52330")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string JNNDBFGKHHD, [Optional] UnityEngine.Object CNBJCJOALNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string JNNDBFGKHHD, [Optional] UnityEngine.Object CNBJCJOALNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F52460", Offset = "0x6F51660", VA = "0x186F52460")]
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
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x862EA0", Offset = "0x8620A0", VA = "0x180862EA0", Slot = "4")]
		public Vector3 DIFJFDGIODF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x862EA0", Offset = "0x8620A0", VA = "0x180862EA0", Slot = "5")]
		public Vector3 BGIAFHGNAFC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public OLKJGBMCMLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static GCCHGDAONKB OAPCCIJDEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F43E60", Offset = "0x6F43060", VA = "0x186F43E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "22")]
		get
		{
			return default(GABGGJOAGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public HJKEDKBDPPP AKJLGFMEBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x85FDF0", Offset = "0x85EFF0", VA = "0x18085FDF0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x85FD70", Offset = "0x85EF70", VA = "0x18085FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject BGONLCODLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9E7450", Offset = "0x9E6650", VA = "0x1809E7450", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9C60D0", Offset = "0x9C52D0", VA = "0x1809C60D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform IKKMMCBJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F2A0", Offset = "0x6F3E4A0", VA = "0x186F3F2A0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody DHIIHPKBDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6F3E500", Offset = "0x6F3D700", VA = "0x186F3E500", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public LJEEPNBNNHB EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6F41460", Offset = "0x6F40660", VA = "0x186F41460", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6F439F0", Offset = "0x6F42BF0", VA = "0x186F439F0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int DGFFNAGFKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6F42FB0", Offset = "0x6F421B0", VA = "0x186F42FB0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public LJEEPNBNNHB DHCIAOJNIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6F41410", Offset = "0x6F40610", VA = "0x186F41410", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool KIMLMAODMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6F3E930", Offset = "0x6F3DB30", VA = "0x186F3E930", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool GGCJPCDEOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6F3EA90", Offset = "0x6F3DC90", VA = "0x186F3EA90", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool OMMEKKCNHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6F43860", Offset = "0x6F42A60", VA = "0x186F43860", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public GCCHGDAONKB GLMHBPJHKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6F41F00", Offset = "0x6F41100", VA = "0x186F41F00", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6F408E0", Offset = "0x6F3FAE0", VA = "0x186F408E0", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public LIJOKMDFOFH MCJHNAIMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6F43AA0", Offset = "0x6F42CA0", VA = "0x186F43AA0", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6F42D00", Offset = "0x6F41F00", VA = "0x186F42D00", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float OBLJBMFPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6F414D0", Offset = "0x6F406D0", VA = "0x186F414D0", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6F40710", Offset = "0x6F3F910", VA = "0x186F40710", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 PCBLAEINONF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6F41B70", Offset = "0x6F40D70", VA = "0x186F41B70", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6F3EE80", Offset = "0x6F3E080", VA = "0x186F3EE80", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 NNHDGLHBCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6F3FD70", Offset = "0x6F3EF70", VA = "0x186F3FD70", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6F40300", Offset = "0x6F3F500", VA = "0x186F40300", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 JGCPBAEFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6F43670", Offset = "0x6F42870", VA = "0x186F43670", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6F419F0", Offset = "0x6F40BF0", VA = "0x186F419F0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 DOJOOKOADMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6F43210", Offset = "0x6F42410", VA = "0x186F43210", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F110", Offset = "0x6F3E310", VA = "0x186F3F110", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool GFHIPOLMMFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6F3EF60", Offset = "0x6F3E160", VA = "0x186F3EF60", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool FGNIPGKHKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6F42DC0", Offset = "0x6F41FC0", VA = "0x186F42DC0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool DKNNPMBIPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6F427F0", Offset = "0x6F419F0", VA = "0x186F427F0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool BOOAKEKDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6F41050", Offset = "0x6F40250", VA = "0x186F41050", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 CHBOEELJBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F720", Offset = "0x6F3E920", VA = "0x186F3F720", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 EHOGFCCMBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6F43070", Offset = "0x6F42270", VA = "0x186F43070", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 MPKDNNPCOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F423C0", Offset = "0x6F415C0", VA = "0x186F423C0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F7F0", Offset = "0x6F3E9F0", VA = "0x186F3F7F0", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 MLGKNLKHOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F40990", Offset = "0x6F3FB90", VA = "0x186F40990", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float CNPKCGDBOHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F43AF0", Offset = "0x6F42CF0", VA = "0x186F43AF0", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float FKLAKHONCEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F41000", Offset = "0x6F40200", VA = "0x186F41000", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F3DB50", Offset = "0x6F3CD50", VA = "0x186F3DB50", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 GLAIIHKCPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F40530", Offset = "0x6F3F730", VA = "0x186F40530", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion IFMMPIPGKAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F41700", Offset = "0x6F40900", VA = "0x186F41700", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float LGIGFNNJAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F330", Offset = "0x6F3E530", VA = "0x186F3F330", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F40660", Offset = "0x6F3F860", VA = "0x186F40660", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float JJGEJCPKFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F3EA40", Offset = "0x6F3DC40", VA = "0x186F3EA40", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F417D0", Offset = "0x6F409D0", VA = "0x186F417D0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool FLNDLEBMONH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F406C0", Offset = "0x6F3F8C0", VA = "0x186F406C0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F380", Offset = "0x6F3E580", VA = "0x186F3F380", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public EEPBOLJHLNK MCAKOHHFPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F42CB0", Offset = "0x6F41EB0", VA = "0x186F42CB0", Slot = "68")]
		get
		{
			return default(EEPBOLJHLNK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F415E0", Offset = "0x6F407E0", VA = "0x186F415E0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool PBLHJBGBIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F43750", Offset = "0x6F42950", VA = "0x186F43750", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform NFGKEMNGCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F426C0", Offset = "0x6F418C0", VA = "0x186F426C0", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 EPEMKAANOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F3E620", Offset = "0x6F3D820", VA = "0x186F3E620", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F41520", Offset = "0x6F40720", VA = "0x186F41520", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float DLMMKBPCBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F3DF00", Offset = "0x6F3D100", VA = "0x186F3DF00", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F424A0", Offset = "0x6F416A0", VA = "0x186F424A0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float JDLKEDGCFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F428D0", Offset = "0x6F41AD0", VA = "0x186F428D0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F40200", Offset = "0x6F3F400", VA = "0x186F40200", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion KHCNENJLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F410A0", Offset = "0x6F402A0", VA = "0x186F410A0", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F3E0", Offset = "0x6F3E5E0", VA = "0x186F3F3E0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 PCKAHHMDECP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F40940", Offset = "0x6F3FB40", VA = "0x186F40940", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F42E20", Offset = "0x6F42020", VA = "0x186F42E20", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion ACLOFDCFLFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F3FCE0", Offset = "0x6F3EEE0", VA = "0x186F3FCE0", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F42180", Offset = "0x6F41380", VA = "0x186F42180", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints OFGMKLMDGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F3E9F0", Offset = "0x6F3DBF0", VA = "0x186F3E9F0", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F41640", Offset = "0x6F40840", VA = "0x186F41640", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool FKLLLKFDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F3E3A0", Offset = "0x6F3D5A0", VA = "0x186F3E3A0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F41E40", Offset = "0x6F41040", VA = "0x186F41E40", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode AIBPEFBJHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F3FD20", Offset = "0x6F3EF20", VA = "0x186F3FD20", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6F43B40", Offset = "0x6F42D40", VA = "0x186F43B40", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool CBCMAKKEDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F42E70", Offset = "0x6F42070", VA = "0x186F42E70", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool HJFGMLFHNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6F3EBC0", Offset = "0x6F3DDC0", VA = "0x186F3EBC0", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event CEJKOKAHCJG GOMCPIIALCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6F42510", Offset = "0x6F41710", VA = "0x186F42510", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6F3DE40", Offset = "0x6F3D040", VA = "0x186F3DE40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event CEJKOKAHCJG KNBPNKNELBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6F433B0", Offset = "0x6F425B0", VA = "0x186F433B0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6F3FE50", Offset = "0x6F3F050", VA = "0x186F3FE50", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event KFNJEADEOOD OLAGEKEIEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6F401A0", Offset = "0x6F3F3A0", VA = "0x186F401A0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6F432F0", Offset = "0x6F424F0", VA = "0x186F432F0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event CEJKOKAHCJG HFEDDJKAHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6F41EA0", Offset = "0x6F410A0", VA = "0x186F41EA0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6F42D60", Offset = "0x6F41F60", VA = "0x186F42D60", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event CEJKOKAHCJG LALHICAPNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6F41D30", Offset = "0x6F40F30", VA = "0x186F41D30", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6F40AD0", Offset = "0x6F3FCD0", VA = "0x186F40AD0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event CEJKOKAHCJG PDPOOKEFDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F42740", Offset = "0x6F41940", VA = "0x186F42740", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F404D0", Offset = "0x6F3F6D0", VA = "0x186F404D0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<FHBBMPGGCGD, FHBBMPGGCGD> MDHINEPAAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F3DEA0", Offset = "0x6F3D0A0", VA = "0x186F3DEA0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F416A0", Offset = "0x6F408A0", VA = "0x186F416A0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event CEJKOKAHCJG IDADILKKDPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F42120", Offset = "0x6F41320", VA = "0x186F42120", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F43800", Offset = "0x6F42A00", VA = "0x186F43800", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event CEJKOKAHCJG HCDKLCFJLOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F42310", Offset = "0x6F41510", VA = "0x186F42310", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F41830", Offset = "0x6F40A30", VA = "0x186F41830", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6F43BE0", Offset = "0x6F42DE0", VA = "0x186F43BE0")]
	public AKECFCILGBG(GameObject NBDLDMDNCAL, RigidbodyEx EFJFPKJHPOE, NGLPLNHDEND GOHDOKCJOFP, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6F3FEB0", Offset = "0x6F3F0B0", VA = "0x186F3FEB0", Slot = "136")]
	protected virtual void FBGPFOOCPOG(NGLPLNHDEND GOHDOKCJOFP, KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6F3FA30", Offset = "0x6F3EC30", VA = "0x186F3FA30", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6F438B0", Offset = "0x6F42AB0", VA = "0x186F438B0", Slot = "91")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6F40610", Offset = "0x6F3F810", VA = "0x186F40610", Slot = "92")]
	public void NFLKBJHAPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6F414B0", Offset = "0x6F406B0", VA = "0x186F414B0", Slot = "93")]
	public void IKNKANAKDJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6F420A0", Offset = "0x6F412A0", VA = "0x186F420A0")]
	private void LFENBOKJKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6F3EAE0", Offset = "0x6F3DCE0", VA = "0x186F3EAE0", Slot = "30")]
	public LJEEPNBNNHB BPLEDEIPGKB(int DHNLEFJCEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6F426D0", Offset = "0x6F418D0", VA = "0x186F426D0", Slot = "95")]
	public void MMADMDAOMMK(LJEEPNBNNHB JMDCGOKJIDA, bool DCIOAOCCLNO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6F40A70", Offset = "0x6F3FC70", VA = "0x186F40A70", Slot = "96")]
	public void GMBDJPNPBNI(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6F3EFB0", Offset = "0x6F3E1B0", VA = "0x186F3EFB0", Slot = "97")]
	public void CICBOHHFGOI(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F010", Offset = "0x6F3E210", VA = "0x186F3F010", Slot = "98")]
	public Vector3 CMIOFOLPDBD(Vector3 FIMFMOJFCFJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6F3FBE0", Offset = "0x6F3EDE0", VA = "0x186F3FBE0", Slot = "99")]
	public Vector3 EHACCJENFAB(Vector3 NOGFFKGBCOL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6F40610", Offset = "0x6F3F810", VA = "0x186F40610", Slot = "100")]
	public void FOFMMMJGGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6F3ED40", Offset = "0x6F3DF40", VA = "0x186F3ED40", Slot = "101")]
	public void CELBLPAFCIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6F43A50", Offset = "0x6F42C50", VA = "0x186F43A50", Slot = "102")]
	public void PMEPFJEJIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6F403E0", Offset = "0x6F3F5E0", VA = "0x186F403E0", Slot = "103")]
	public void FLNMHLJEABK(Vector3 HFOBNBKELJL, Vector3 MHBEFOAKJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6F3ED90", Offset = "0x6F3DF90", VA = "0x186F3ED90", Slot = "104")]
	public void CHAAMCPOLKD(Vector3 JNININDALMJ, Vector3 IGMBCDNHIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DBB0", Offset = "0x6F3CDB0", VA = "0x186F3DBB0", Slot = "105")]
	public void ADFDPALOCLC(Vector3 HGGENDDBBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6F43150", Offset = "0x6F42350", VA = "0x186F43150", Slot = "106")]
	public void OEHCHBFDEKM(CJOGEGMLKDO OEJNBMLJOIB, Vector3 NBOECIFPPEF, float AHEAGOIPKJF, float CNMGOEBKPGK = 8f, float IMBABICPDKH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6F41F50", Offset = "0x6F41150", VA = "0x186F41F50", Slot = "107")]
	public void LDGDMKCOGAH(JCBCIKFMAML KEJNJHGGNMJ, Vector3 BJMFJJKFMAF, float EEDKOLOOPKK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6F418E0", Offset = "0x6F40AE0", VA = "0x186F418E0", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JLBJDDHJOHM(JCBCIKFMAML KEJNJHGGNMJ, Vector3 LCDJINCAHMD, float ONOCCGOPHEL = 7f, float BKJDNLFEDGK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6F41250", Offset = "0x6F40450", VA = "0x186F41250", Slot = "109")]
	public Vector3 IGGKIKFINPM(Vector3 JMDCGOKJIDA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DC90", Offset = "0x6F3CE90", VA = "0x186F3DC90", Slot = "110")]
	public Vector3 AGLJKLOFAKO(Vector3 JMDCGOKJIDA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6F41AD0", Offset = "0x6F40CD0", VA = "0x186F41AD0", Slot = "111")]
	public void JOFNHGFIFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6F422A0", Offset = "0x6F414A0", VA = "0x186F422A0", Slot = "112")]
	public void MCGHHLGPCDO(LJEEPNBNNHB KNDIPAMGJEH, object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DAF0", Offset = "0x6F3CCF0", VA = "0x186F3DAF0", Slot = "113")]
	public void ABPOJCBHDFP(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E850", Offset = "0x6F3DA50", VA = "0x186F3E850", Slot = "61")]
	public void BJNIMHBPEJI((Quaternion rot, Vector3 moments) CKEJAFLIMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F41DF0", Offset = "0x6F40FF0", VA = "0x186F41DF0", Slot = "114")]
	public void KJDIAFCJJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F427A0", Offset = "0x6F419A0", VA = "0x186F427A0", Slot = "115")]
	public void MPNLKLPFHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F41B20", Offset = "0x6F40D20", VA = "0x186F41B20", Slot = "116")]
	public void JONIHJFPCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F1F0", Offset = "0x6F3E3F0", VA = "0x186F3F1F0", Slot = "117")]
	public bool DBEPKAHMKBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F43020", Offset = "0x6F42220", VA = "0x186F43020", Slot = "94")]
	public void NMFKFBHACCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F4D0", Offset = "0x6F3E6D0", VA = "0x186F3F4D0", Slot = "118")]
	public void DENFDBJHBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F240", Offset = "0x6F3E440", VA = "0x186F3F240", Slot = "119")]
	public void DCIFLICONLL(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F41D90", Offset = "0x6F40F90", VA = "0x186F41D90", Slot = "120")]
	public void KGHICEPBNMM(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F43600", Offset = "0x6F42800", VA = "0x186F43600", Slot = "121")]
	public void PAIMJFADCAB(object EOCJCEFCOOA, bool MCDOCGGGECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F520", Offset = "0x6F3E720", VA = "0x186F3F520", Slot = "122")]
	public void DKOHPMAPHGG(Vector3 BELOINIPDIB, Quaternion HJPFNIDEMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F42570", Offset = "0x6F41770", VA = "0x186F42570", Slot = "123")]
	public void MLABCGDNEEH(Vector3 LEDGGONKHOH, Quaternion GNOJHHCJPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F437A0", Offset = "0x6F429A0", VA = "0x186F437A0", Slot = "124")]
	public bool PGOKKFJFMGD(float BONLJCBABLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E990", Offset = "0x6F3DB90", VA = "0x186F3E990", Slot = "125")]
	public void BKONGIFNHPB(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F9D0", Offset = "0x6F3EBD0", VA = "0x186F3F9D0", Slot = "126")]
	public void DNKOPNCBMHI(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F3EB60", Offset = "0x6F3DD60", VA = "0x186F3EB60", Slot = "127")]
	public void CDBCEDMLJNK(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F43350", Offset = "0x6F42550", VA = "0x186F43350", Slot = "128")]
	public void OLCAAIPHEIP(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F41C50", Offset = "0x6F40E50", VA = "0x186F41C50", Slot = "129")]
	public void KAPGLCIGOAI(Vector3 AMNFMCIBNPO, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DF20", Offset = "0x6F3D120", VA = "0x186F3DF20", Slot = "130")]
	public void APEKDDPMJIA(Vector3 AMNFMCIBNPO, Vector3 HGDCPNGLIKJ, ForceMode HAMIBHDKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F421C0", Offset = "0x6F413C0", VA = "0x186F421C0", Slot = "131")]
	public void LPEOIJLIBJD(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F40F20", Offset = "0x6F40120", VA = "0x186F40F20", Slot = "132")]
	public void HDLFPCCLPMC(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F8D0", Offset = "0x6F3EAD0", VA = "0x186F3F8D0", Slot = "133")]
	public bool DLPAKOEIMOE(Vector3 FCBGHELDCII, [Out] RaycastHit MGGIMCBEOEH, float BKKDIDJOENO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F42050", Offset = "0x6F41250", VA = "0x186F42050", Slot = "134")]
	public void LFEIJDEHHMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F43BA0", Offset = "0x6F42DA0", VA = "0x186F43BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F3FB00", Offset = "0x6F3ED00", VA = "0x186F3FB00")]
	private void EBODCBMBMPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E3F0", Offset = "0x6F3D5F0", VA = "0x186F3E3F0")]
	private void BBEEPJFMBJD(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F43410", Offset = "0x6F42610", VA = "0x186F43410")]
	private void ONHAKDBCCNG(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DD90", Offset = "0x6F3CF90", VA = "0x186F3DD90")]
	private void AHFEECKILMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F41150", Offset = "0x6F40350", VA = "0x186F41150")]
	private void IDDFEBGHOBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E6D0", Offset = "0x6F3D8D0", VA = "0x186F3E6D0")]
	private void BIAKALOJJNG(LJEEPNBNNHB LKNDHCECGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F40E50", Offset = "0x6F40050", VA = "0x186F40E50")]
	private void HCJFHFKIFCI(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E550", Offset = "0x6F3D750", VA = "0x186F3E550")]
	private void BFJIHMPHLJA(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F40770", Offset = "0x6F3F970", VA = "0x186F40770")]
	private void GFFAHDGIPGI(HJKEDKBDPPP BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F428F0", Offset = "0x6F41AF0", VA = "0x186F428F0", Slot = "141")]
	protected virtual void NEGBLOEOEHL(HJKEDKBDPPP NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F40B30", Offset = "0x6F3FD30", VA = "0x186F40B30")]
	protected void HBKMAEIMBKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E030", Offset = "0x6F3D230", VA = "0x186F3E030")]
	protected void BACAJBCAJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F41350", Offset = "0x6F40550", VA = "0x186F41350", Slot = "142")]
	protected virtual IDisposable IHIINBLEBOJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class FECCMDOKBJL
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F45320", Offset = "0x6F44520", VA = "0x186F45320")]
	public static LJEEPNBNNHB BDBBMKBAFNB(this LJEEPNBNNHB NKIPNFFBDAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F45460", Offset = "0x6F44660", VA = "0x186F45460")]
	public static bool IINKAPCDGDI(this LJEEPNBNNHB NKIPNFFBDAI, LJEEPNBNNHB KPIPNJDNJNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F454E0", Offset = "0x6F446E0", VA = "0x186F454E0")]
	public static bool PKOHNLBLMCB(this LJEEPNBNNHB NKIPNFFBDAI, LJEEPNBNNHB NIOHKOJCMDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F45560", Offset = "0x6F44760", VA = "0x186F45560")]
	public static HJKEDKBDPPP PNBIPFIMHIE(this LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F453E0", Offset = "0x6F445E0", VA = "0x186F453E0")]
	public static AKECFCILGBG DIMEOMPBOHJ(this LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DOJNMGBCOPL : CHMPPNFIFLC
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F445B0", Offset = "0x6F437B0", VA = "0x186F445B0", Slot = "19")]
	public LJEEPNBNNHB BAEHCLHNCHB(RigidbodyEx NKIPNFFBDAI, KPFNKPJMKHJ LINJEFIAFHO, NGLPLNHDEND GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "4")]
	public OBLCMNIHHPA AKEKIEBHBJM(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "5")]
	public HAOKEBMAJGF BDMGOHHJINE(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "6")]
	public OLJDHFEMIEM HAPBJDJMOKP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "7")]
	public BNEAKDEKEGF IJMKDLBCPMP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "8")]
	public JKJFHGFNKMI HPEKAGMBJOF(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "9")]
	public BBELJPEBCDG KJDJCCIJHCL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "10")]
	public IACJBDKKNDH OKCGHCGAIAG(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "11")]
	public MPONMNOKEDF IOLKGNHHCJA(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "12")]
	public KHFOMKPIPGM LBHINPABMFD(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "13")]
	public CJGADINNADB KHOAHPFHAGL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0")]
	public LCNNLPJHPDO KKNJHPKAHML(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0")]
	public ENODCFCBNKN BDCEKGMLOAH(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0")]
	public HAPDGEOPNLL JEELHNMABOD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0")]
	public IGANODCOKHB NCBDCBPKBEJ(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0")]
	public EJDCPCDIDOH DPMMFGFJGFD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public DOJNMGBCOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "14")]
	private LCNNLPJHPDO GHAOFICPAOL(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "15")]
	private ENODCFCBNKN PJEBCMEGNBI(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "16")]
	private HAPDGEOPNLL GDLIICLCEIA(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "17")]
	private IGANODCOKHB EDAECLKGAIE(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F518A0", Offset = "0x6F50AA0", VA = "0x186F518A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6F51F90", Offset = "0x6F51190", VA = "0x186F51F90", Slot = "20")]
	public void InitReferences(GANFHFOELEK FGDLGNMCKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6F516B0", Offset = "0x6F508B0", VA = "0x186F516B0", Slot = "4")]
	public OBLCMNIHHPA AKEKIEBHBJM(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6F519B0", Offset = "0x6F50BB0", VA = "0x186F519B0", Slot = "5")]
	public HAOKEBMAJGF BDMGOHHJINE(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6F51D10", Offset = "0x6F50F10", VA = "0x186F51D10", Slot = "6")]
	public OLJDHFEMIEM HAPBJDJMOKP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6F51E50", Offset = "0x6F51050", VA = "0x186F51E50", Slot = "7")]
	public BNEAKDEKEGF IJMKDLBCPMP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6F51DB0", Offset = "0x6F50FB0", VA = "0x186F51DB0", Slot = "8")]
	public JKJFHGFNKMI HPEKAGMBJOF(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6F52080", Offset = "0x6F51280", VA = "0x186F52080", Slot = "9")]
	public BBELJPEBCDG KJDJCCIJHCL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6F521C0", Offset = "0x6F513C0", VA = "0x186F521C0", Slot = "10")]
	public IACJBDKKNDH OKCGHCGAIAG(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6F51EF0", Offset = "0x6F510F0", VA = "0x186F51EF0", Slot = "11")]
	public MPONMNOKEDF IOLKGNHHCJA(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6F52120", Offset = "0x6F51320", VA = "0x186F52120", Slot = "12")]
	public KHFOMKPIPGM LBHINPABMFD(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6F51FE0", Offset = "0x6F511E0", VA = "0x186F51FE0", Slot = "13")]
	public CJGADINNADB KHOAHPFHAGL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6F51C60", Offset = "0x6F50E60", VA = "0x186F51C60")]
	public LCNNLPJHPDO KKNJHPKAHML(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6F51900", Offset = "0x6F50B00", VA = "0x186F51900")]
	public ENODCFCBNKN BDCEKGMLOAH(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6F51BB0", Offset = "0x6F50DB0", VA = "0x186F51BB0")]
	public HAPDGEOPNLL JEELHNMABOD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F51B00", Offset = "0x6F50D00", VA = "0x186F51B00")]
	public IGANODCOKHB NCBDCBPKBEJ(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F51A50", Offset = "0x6F50C50", VA = "0x186F51A50")]
	public EJDCPCDIDOH DPMMFGFJGFD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6F51750", Offset = "0x6F50950", VA = "0x186F51750", Slot = "19")]
	public LJEEPNBNNHB BAEHCLHNCHB(RigidbodyEx NKIPNFFBDAI, KPFNKPJMKHJ LINJEFIAFHO, NGLPLNHDEND GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6F52260", Offset = "0x6F51460", VA = "0x186F52260")]
	public PPBCEGBKCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6F51C60", Offset = "0x6F50E60", VA = "0x186F51C60", Slot = "14")]
	private LCNNLPJHPDO GHAOFICPAOL(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6F51900", Offset = "0x6F50B00", VA = "0x186F51900", Slot = "15")]
	private ENODCFCBNKN PJEBCMEGNBI(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6F51BB0", Offset = "0x6F50DB0", VA = "0x186F51BB0", Slot = "16")]
	private HAPDGEOPNLL GDLIICLCEIA(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6F51B00", Offset = "0x6F50D00", VA = "0x186F51B00", Slot = "17")]
	private IGANODCOKHB EDAECLKGAIE(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6F51A50", Offset = "0x6F50C50", VA = "0x186F51A50", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F3C220", Offset = "0x6F3B420", VA = "0x186F3C220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode AIBPEFBJHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6F44F60", Offset = "0x6F44160", VA = "0x186F44F60", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6F452B0", Offset = "0x6F444B0", VA = "0x186F452B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6F3CD60", Offset = "0x6F3BF60", VA = "0x186F3CD60")]
	public FABNLOPBJEE(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F451A0", Offset = "0x6F443A0", VA = "0x186F451A0", Slot = "6")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6F44D80", Offset = "0x6F43F80", VA = "0x186F44D80", Slot = "9")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6F44D70", Offset = "0x6F43F70", VA = "0x186F44D70", Slot = "7")]
	public void ANGDFDOOLIM(bool JMEEMLNLABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6F45070", Offset = "0x6F44270", VA = "0x186F45070", Slot = "8")]
	public void FOOFBKMEGCH(bool JMEEMLNLABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6F44E00", Offset = "0x6F44000", VA = "0x186F44E00", Slot = "10")]
	public bool DLPAKOEIMOE(Vector3 FCBGHELDCII, [Out] RaycastHit MGGIMCBEOEH, float BKKDIDJOENO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6F45080", Offset = "0x6F44280", VA = "0x186F45080")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F48F00", Offset = "0x6F48100", VA = "0x186F48F00", Slot = "6")]
		get
		{
			return default(EEPBOLJHLNK);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6F48D80", Offset = "0x6F47F80", VA = "0x186F48D80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform OOHDDHCJCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6F48D60", Offset = "0x6F47F60", VA = "0x186F48D60", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<FHBBMPGGCGD, FHBBMPGGCGD> MDHINEPAAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6F48C60", Offset = "0x6F47E60", VA = "0x186F48C60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6F48E50", Offset = "0x6F48050", VA = "0x186F48E50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6F492D0", Offset = "0x6F484D0", VA = "0x186F492D0")]
	public FNPLKLIGBGF(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6F49050", Offset = "0x6F48250", VA = "0x186F49050", Slot = "8")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6F48D10", Offset = "0x6F47F10", VA = "0x186F48D10", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x979C00", Offset = "0x978E00", VA = "0x180979C00", Slot = "11")]
	private void KJBJEIDMPPE(FHBBMPGGCGD KMCHIMPGNCP, FHBBMPGGCGD BNADEAHLELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "12")]
	private void NIMFPOEIGLH(bool ILLAIMLPMFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LCNLKIDNKBB : CHMPPNFIFLC
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DE50", Offset = "0x6F4D050", VA = "0x186F4DE50", Slot = "4")]
	public OBLCMNIHHPA AKEKIEBHBJM(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E1F0", Offset = "0x6F4D3F0", VA = "0x186F4E1F0", Slot = "5")]
	public HAOKEBMAJGF BDMGOHHJINE(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E810", Offset = "0x6F4DA10", VA = "0x186F4E810", Slot = "6")]
	public OLJDHFEMIEM HAPBJDJMOKP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EA10", Offset = "0x6F4DC10", VA = "0x186F4EA10", Slot = "7")]
	public BNEAKDEKEGF IJMKDLBCPMP(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E940", Offset = "0x6F4DB40", VA = "0x186F4E940", Slot = "8")]
	public JKJFHGFNKMI HPEKAGMBJOF(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EC10", Offset = "0x6F4DE10", VA = "0x186F4EC10", Slot = "9")]
	public BBELJPEBCDG KJDJCCIJHCL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EDA0", Offset = "0x6F4DFA0", VA = "0x186F4EDA0", Slot = "10")]
	public IACJBDKKNDH OKCGHCGAIAG(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EA90", Offset = "0x6F4DC90", VA = "0x186F4EA90", Slot = "11")]
	public MPONMNOKEDF IOLKGNHHCJA(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6F4ECE0", Offset = "0x6F4DEE0", VA = "0x186F4ECE0", Slot = "12")]
	public KHFOMKPIPGM LBHINPABMFD(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EB50", Offset = "0x6F4DD50", VA = "0x186F4EB50", Slot = "13")]
	public CJGADINNADB KHOAHPFHAGL(LJEEPNBNNHB CIGKBEKHOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E6D0", Offset = "0x6F4D8D0", VA = "0x186F4E6D0")]
	public LCNNLPJHPDO KKNJHPKAHML(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E060", Offset = "0x6F4D260", VA = "0x186F4E060")]
	public ENODCFCBNKN BDCEKGMLOAH(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E5A0", Offset = "0x6F4D7A0", VA = "0x186F4E5A0")]
	public HAPDGEOPNLL JEELHNMABOD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E400", Offset = "0x6F4D600", VA = "0x186F4E400")]
	public IGANODCOKHB NCBDCBPKBEJ(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E320", Offset = "0x6F4D520", VA = "0x186F4E320")]
	public EJDCPCDIDOH DPMMFGFJGFD(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DF40", Offset = "0x6F4D140", VA = "0x186F4DF40", Slot = "19")]
	public LJEEPNBNNHB BAEHCLHNCHB(RigidbodyEx NKIPNFFBDAI, KPFNKPJMKHJ LINJEFIAFHO, NGLPLNHDEND GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public LCNLKIDNKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E6D0", Offset = "0x6F4D8D0", VA = "0x186F4E6D0", Slot = "14")]
	private LCNNLPJHPDO GHAOFICPAOL(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E060", Offset = "0x6F4D260", VA = "0x186F4E060", Slot = "15")]
	private ENODCFCBNKN PJEBCMEGNBI(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E5A0", Offset = "0x6F4D7A0", VA = "0x186F4E5A0", Slot = "16")]
	private HAPDGEOPNLL GDLIICLCEIA(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E400", Offset = "0x6F4D600", VA = "0x186F4E400", Slot = "17")]
	private IGANODCOKHB EDAECLKGAIE(LJEEPNBNNHB CIGKBEKHOLC, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E320", Offset = "0x6F4D520", VA = "0x186F4E320", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F3C220", Offset = "0x6F3B420", VA = "0x186F3C220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool PBLHJBGBIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6F3CAB0", Offset = "0x6F3BCB0", VA = "0x186F3CAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool KIMLMAODMNF
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C270", Offset = "0x6F3B470", VA = "0x186F3C270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private LJEEPNBNNHB EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C530", Offset = "0x6F3B730", VA = "0x186F3C530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6F3CD60", Offset = "0x6F3BF60", VA = "0x186F3CD60")]
	public ACBPOFJKBCC(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C590", Offset = "0x6F3B790", VA = "0x186F3C590", Slot = "4")]
	public void KAPGLCIGOAI(Vector3 AMNFMCIBNPO, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F3CB00", Offset = "0x6F3BD00", VA = "0x186F3CB00")]
	private void PHBDKNPPCAL(Vector3 AMNFMCIBNPO, ForceMode HAMIBHDKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BFA0", Offset = "0x6F3B1A0", VA = "0x186F3BFA0", Slot = "5")]
	public void APEKDDPMJIA(Vector3 AMNFMCIBNPO, Vector3 HGDCPNGLIKJ, ForceMode HAMIBHDKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C6F0", Offset = "0x6F3B8F0", VA = "0x186F3C6F0", Slot = "6")]
	public void LPEOIJLIBJD(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C850", Offset = "0x6F3BA50", VA = "0x186F3C850")]
	private void NDNOFKHGIEM(Vector3 LKLNBDFPCPM, ForceMode HAMIBHDKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C2D0", Offset = "0x6F3B4D0", VA = "0x186F3C2D0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x920B50", Offset = "0x91FD50", VA = "0x180920B50", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6F43CE0", Offset = "0x6F42EE0", VA = "0x186F43CE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6F3CD60", Offset = "0x6F3BF60", VA = "0x186F3CD60")]
	public APECLDGCONL(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6F43CB0", Offset = "0x6F42EB0", VA = "0x186F43CB0", Slot = "6")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6F43DF0", Offset = "0x6F42FF0", VA = "0x186F43DF0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F499F0", Offset = "0x6F48BF0", VA = "0x186F499F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public LJEEPNBNNHB EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x856BA0", Offset = "0x855DA0", VA = "0x180856BA0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B300", Offset = "0x6F4A500", VA = "0x186F4B300", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public LJEEPNBNNHB DHCIAOJNIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x856A90", Offset = "0x855C90", VA = "0x180856A90", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<LJEEPNBNNHB> PLOBAPBGHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x856320", Offset = "0x855520", VA = "0x180856320", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event CEJKOKAHCJG GOMCPIIALCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A560", Offset = "0x6F49760", VA = "0x186F4A560", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6F49820", Offset = "0x6F48A20", VA = "0x186F49820", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event CEJKOKAHCJG KNBPNKNELBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B260", Offset = "0x6F4A460", VA = "0x186F4B260", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6F49C50", Offset = "0x6F48E50", VA = "0x186F49C50", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event KFNJEADEOOD OLAGEKEIEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6F49DB0", Offset = "0x6F48FB0", VA = "0x186F49DB0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B1C0", Offset = "0x6F4A3C0", VA = "0x186F4B1C0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action DEIDEILNFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AF30", Offset = "0x6F4A130", VA = "0x186F4AF30", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AFD0", Offset = "0x6F4A1D0", VA = "0x186F4AFD0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action GHDCKGFKHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B120", Offset = "0x6F4A320", VA = "0x186F4B120", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6F49F00", Offset = "0x6F49100", VA = "0x186F49F00", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<LJEEPNBNNHB> DMOBOFFADLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A1D0", Offset = "0x6F493D0", VA = "0x186F4A1D0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A120", Offset = "0x6F49320", VA = "0x186F4A120", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<LJEEPNBNNHB> CINCKADPPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B070", Offset = "0x6F4A270", VA = "0x186F4B070", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6F49BA0", Offset = "0x6F48DA0", VA = "0x186F49BA0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action JPDIHOFJFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A040", Offset = "0x6F49240", VA = "0x186F4A040", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A4C0", Offset = "0x6F496C0", VA = "0x186F4A4C0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<LJEEPNBNNHB> IHFECPECMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6F49E50", Offset = "0x6F49050", VA = "0x186F49E50", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6F49A50", Offset = "0x6F48C50", VA = "0x186F49A50", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B3B0", Offset = "0x6F4A5B0", VA = "0x186F4B3B0")]
	public HHFBFHNOBOA(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6F49B00", Offset = "0x6F48D00", VA = "0x186F49B00", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A600", Offset = "0x6F49800", VA = "0x186F4A600", Slot = "30")]
	public void MMADMDAOMMK(LJEEPNBNNHB KGHLFFBGAIM, bool DCIOAOCCLNO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AB80", Offset = "0x6F49D80", VA = "0x186F4AB80", Slot = "6")]
	public void MMINCMFEKID(LJEEPNBNNHB LKNDHCECGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6F495A0", Offset = "0x6F487A0", VA = "0x186F495A0", Slot = "7")]
	public void AAKBDKKNEBM(LJEEPNBNNHB LKNDHCECGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A280", Offset = "0x6F49480", VA = "0x186F4A280", Slot = "4")]
	public void LGJHIGDGICA(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B310", Offset = "0x6F4A510", VA = "0x186F4B310", Slot = "5")]
	public void PMFKCEMIMAH(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6F49FA0", Offset = "0x6F491A0", VA = "0x186F49FA0")]
	private void HOPFFNNEJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A0E0", Offset = "0x6F492E0", VA = "0x186F4A0E0")]
	private void IHGHEGFMBLF(LJEEPNBNNHB LKNDHCECGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6F4ADF0", Offset = "0x6F49FF0", VA = "0x186F4ADF0")]
	private void NAIOIGCEJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6F498C0", Offset = "0x6F48AC0", VA = "0x186F498C0")]
	private void CBAJHLGCLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A390", Offset = "0x6F49590", VA = "0x186F4A390")]
	private void LPOHGFPNNLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6F49CF0", Offset = "0x6F48EF0", VA = "0x186F49CF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F43F30", Offset = "0x6F43130", VA = "0x186F43F30")]
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
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 CHBOEELJBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6F50850", Offset = "0x6F4FA50", VA = "0x186F50850", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 EHOGFCCMBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6F51010", Offset = "0x6F50210", VA = "0x186F51010", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 JGCPBAEFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6F511D0", Offset = "0x6F503D0", VA = "0x186F511D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public LJEEPNBNNHB BBIBDDHIDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6F507A0", Offset = "0x6F4F9A0", VA = "0x186F507A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6F512C0", Offset = "0x6F504C0", VA = "0x186F512C0")]
	public OJPLLKCCNPL(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6F50FA0", Offset = "0x6F501A0", VA = "0x186F50FA0", Slot = "8")]
	public void JOFFLJFDKEL(LJEEPNBNNHB BMBBFJPOJEB, object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6F50740", Offset = "0x6F4F940", VA = "0x186F50740", Slot = "9")]
	public void ANLGKCFDEGE(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F50880", Offset = "0x6F4FA80", VA = "0x186F50880")]
	private Vector3 FCDEPHNHPAB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6F50C10", Offset = "0x6F4FE10", VA = "0x186F50C10")]
	private void FEMBAJMCIGK(LJEEPNBNNHB BAMJAECANAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class LLCLGPOGBEE
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6F4FA30", Offset = "0x6F4EC30", VA = "0x186F4FA30")]
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
		[Cpp2IlInjected.Address(RVA = "0xD73530", Offset = "0xD72730", VA = "0x180D73530", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C700", Offset = "0x6F4B900", VA = "0x186F4C700", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 MLGKNLKHOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CB80", Offset = "0x6F4BD80", VA = "0x186F4CB80", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float CNPKCGDBOHH
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8BE780", Offset = "0x8BD980", VA = "0x1808BE780", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D2E0", Offset = "0x6F4C4E0", VA = "0x186F4D2E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float FKLAKHONCEG
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE890", Offset = "0x8BDA90", VA = "0x1808BE890", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B470", Offset = "0x6F4A670", VA = "0x186F4B470", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 GLAIIHKCPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C9F0", Offset = "0x6F4BBF0", VA = "0x186F4C9F0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion IFMMPIPGKAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CE00", Offset = "0x6F4C000", VA = "0x186F4CE00", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody DHIIHPKBDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B520", Offset = "0x6F4A720", VA = "0x186F4B520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event CEJKOKAHCJG PPJCEIJIBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DA80", Offset = "0x6F4CC80", VA = "0x186F4DA80", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C7B0", Offset = "0x6F4B9B0", VA = "0x186F4C7B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DCF0", Offset = "0x6F4CEF0", VA = "0x186F4DCF0")]
	public KOADCEMAONI(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D130", Offset = "0x6F4C330", VA = "0x186F4D130", Slot = "17")]
	public void KJDIAFCJJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DB20", Offset = "0x6F4CD20", VA = "0x186F4DB20", Slot = "16")]
	public void MPNLKLPFHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C620", Offset = "0x6F4B820", VA = "0x186F4C620", Slot = "19")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D890", Offset = "0x6F4CA90", VA = "0x186F4D890", Slot = "20")]
	public void MBFMCBMPPJM(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CF80", Offset = "0x6F4C180", VA = "0x186F4CF80", Slot = "18")]
	public void JONIHJFPCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D3F0", Offset = "0x6F4C5F0", VA = "0x186F4D3F0", Slot = "21")]
	public void LFEIJDEHHMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C700", Offset = "0x6F4B900", VA = "0x186F4C700")]
	private void DJLOHHFJMPH(Vector3 JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DC00", Offset = "0x6F4CE00", VA = "0x186F4DC00")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 OFNHKOLKBOB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D2E0", Offset = "0x6F4C4E0", VA = "0x186F4D2E0")]
	private void KLJCBMHBLJO(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B470", Offset = "0x6F4A670", VA = "0x186F4B470")]
	private void FELHKLHIBFA(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C850", Offset = "0x6F4BA50", VA = "0x186F4C850")]
	private Vector3 FEFNEPMKIHI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C3F0", Offset = "0x6F4B5F0", VA = "0x186F4C3F0", Slot = "15")]
	public void BJNIMHBPEJI((Quaternion rot, Vector3 moments) CKEJAFLIMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CC80", Offset = "0x6F4BE80", VA = "0x186F4CC80")]
	private Quaternion HELIIBEMCHE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B570", Offset = "0x6F4A770", VA = "0x186F4B570")]
	public void BJEDCAPDABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B640", Offset = "0x6F4A840", VA = "0x186F4B640", Slot = "4")]
	public (float, Vector3) BJEDCAPDABC(Rigidbody POEMMNMNOEI)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class DNCCJLAIPBI
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F444F0", Offset = "0x6F436F0", VA = "0x186F444F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEF32E0", Offset = "0xEF24E0", VA = "0x180EF32E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public ONPHIJJLPGG FFLGFNAAOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9B0", Offset = "0x8CCBB0", VA = "0x1808CD9B0", Slot = "11")]
		get
		{
			return default(ONPHIJJLPGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F44C70", Offset = "0x6F43E70", VA = "0x186F44C70")]
	public ECMKJAPAOJP(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F44BA0", Offset = "0x6F43DA0", VA = "0x186F44BA0", Slot = "4")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F44650", Offset = "0x6F43850", VA = "0x186F44650")]
	private bool ABMDCKKGGNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F44980", Offset = "0x6F43B80", VA = "0x186F44980", Slot = "5")]
	public void DGEPFNEICCP(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F449B0", Offset = "0x6F43BB0", VA = "0x186F449B0", Slot = "6")]
	public void HGCOKOEFMOK(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F44A60", Offset = "0x6F43C60", VA = "0x186F44A60", Slot = "9")]
	public void OMOOHCBNEBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F446F0", Offset = "0x6F438F0", VA = "0x186F446F0")]
	private void ANKLEIFGGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F44810", Offset = "0x6F43A10", VA = "0x186F44810")]
	private void BLKAFMDMCKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F44A20", Offset = "0x6F43C20", VA = "0x186F44A20", Slot = "8")]
	public void ICGJKBEJBIA(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F449E0", Offset = "0x6F43BE0", VA = "0x186F449E0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F44270", Offset = "0x6F43470", VA = "0x186F44270", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event CEJKOKAHCJG IDADILKKDPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F44090", Offset = "0x6F43290", VA = "0x186F44090", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F44360", Offset = "0x6F43560", VA = "0x186F44360", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F44400", Offset = "0x6F43600", VA = "0x186F44400")]
	public CBFOKBIICLF(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F44070", Offset = "0x6F43270", VA = "0x186F44070", Slot = "7")]
	public void DCIFLICONLL(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F44080", Offset = "0x6F43280", VA = "0x186F44080", Slot = "8")]
	public void KGHICEPBNMM(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F44160", Offset = "0x6F43360", VA = "0x186F44160", Slot = "9")]
	public void PAIMJFADCAB(object EOCJCEFCOOA, bool MCDOCGGGECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F44320", Offset = "0x6F43520", VA = "0x186F44320", Slot = "12")]
	public void PGGABFKDEIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F43FF0", Offset = "0x6F431F0", VA = "0x186F43FF0", Slot = "10")]
	public void BPPFGEIDBGG(Rigidbody KLDLKACCMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F44130", Offset = "0x6F43330", VA = "0x186F44130", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool GGCJPCDEOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F3D0B0", Offset = "0x6F3C2B0", VA = "0x186F3D0B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool OMMEKKCNHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA6E540", Offset = "0xA6D740", VA = "0x180A6E540", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event CEJKOKAHCJG HFEDDJKAHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F3D340", Offset = "0x6F3C540", VA = "0x186F3D340", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F3D650", Offset = "0x6F3C850", VA = "0x186F3D650", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D990", Offset = "0x6F3CB90", VA = "0x186F3D990")]
	public AKBAGCBMKNB(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D860", Offset = "0x6F3CA60", VA = "0x186F3D860", Slot = "9")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D0D0", Offset = "0x6F3C2D0", VA = "0x186F3D0D0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D1D0", Offset = "0x6F3C3D0", VA = "0x186F3D1D0", Slot = "10")]
	public void HCJFHFKIFCI(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F3CDF0", Offset = "0x6F3BFF0", VA = "0x186F3CDF0", Slot = "11")]
	public void BFJIHMPHLJA(LJEEPNBNNHB BMBBFJPOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D6F0", Offset = "0x6F3C8F0", VA = "0x186F3D6F0")]
	private void PJAMIBLLAJO(PhotonView PFDHDOKBLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F3CF60", Offset = "0x6F3C160", VA = "0x186F3CF60")]
	private void BNJLKAAGMEP(HJKEDKBDPPP LAOPCGKBCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D3E0", Offset = "0x6F3C5E0", VA = "0x186F3D3E0")]
	private void NDFEOOIBOKA(PhotonView AEPHECJCJCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class PIBKLLMHDEL
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F515F0", Offset = "0x6F507F0", VA = "0x186F515F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF1F60", Offset = "0xCF1160", VA = "0x180CF1F60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x44FEB40", Offset = "0x44FDD40", VA = "0x1844FEB40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool BHGJNLBILDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xF417F0", Offset = "0xF409F0", VA = "0x180F417F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x44FEB30", Offset = "0x44FDD30", VA = "0x1844FEB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints OFGMKLMDGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85EF10", VA = "0x18085FD10", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F49390", Offset = "0x6F48590", VA = "0x186F49390", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F494F0", Offset = "0x6F486F0", VA = "0x186F494F0")]
	public HGPMOBDFJND(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F49360", Offset = "0x6F48560", VA = "0x186F49360", Slot = "9")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F494C0", Offset = "0x6F486C0", VA = "0x186F494C0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BE910", Offset = "0x8BDB10", VA = "0x1808BE910", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F504C0", Offset = "0x6F4F6C0", VA = "0x186F504C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float JJGEJCPKFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BE8D0", Offset = "0x8BDAD0", VA = "0x1808BE8D0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F50590", Offset = "0x6F4F790", VA = "0x186F50590", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F50700", Offset = "0x6F4F900", VA = "0x186F50700")]
	public OEANOHBDAAL(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F50470", Offset = "0x6F4F670", VA = "0x186F50470", Slot = "8")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F50660", Offset = "0x6F4F860", VA = "0x186F50660", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F4B520", Offset = "0x6F4A720", VA = "0x186F4B520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool CBCMAKKEDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F850", Offset = "0x6F4EA50", VA = "0x186F4F850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private LJEEPNBNNHB EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F5A0", Offset = "0x6F4E7A0", VA = "0x186F4F5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool KIMLMAODMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F4EF30", Offset = "0x6F4E130", VA = "0x186F4EF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event CEJKOKAHCJG PDPOOKEFDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F7B0", Offset = "0x6F4E9B0", VA = "0x186F4F7B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F4F0", Offset = "0x6F4E6F0", VA = "0x186F4F4F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F9A0", Offset = "0x6F4EBA0", VA = "0x186F4F9A0")]
	public LIBCLCOHFFF(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F910", Offset = "0x6F4EB10", VA = "0x186F4F910", Slot = "6")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F590", Offset = "0x6F4E790", VA = "0x186F4F590", Slot = "8")]
	public void HACGNHECFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EF90", Offset = "0x6F4E190", VA = "0x186F4EF90", Slot = "7")]
	public bool DBEPKAHMKBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F870", Offset = "0x6F4EA70", VA = "0x186F4F870", Slot = "9")]
	public void NMFKFBHACCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F0E0", Offset = "0x6F4E2E0", VA = "0x186F4F0E0", Slot = "11")]
	public void DENFDBJHBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F600", Offset = "0x6F4E800", VA = "0x186F4F600", Slot = "10")]
	public void IMKIFNNMNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F310", Offset = "0x6F4E510", VA = "0x186F4F310")]
	private bool EHDEBMFGJFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F180", Offset = "0x6F4E380", VA = "0x186F4F180")]
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
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851A70", VA = "0x180852870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool KIMLMAODMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C270", Offset = "0x6F3B470", VA = "0x186F3C270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool KLCPPBHBKKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xEF32E0", Offset = "0xEF24E0", VA = "0x180EF32E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F50360", Offset = "0x6F4F560", VA = "0x186F50360")]
	public NGEKODKPLMJ(LJEEPNBNNHB NKIPNFFBDAI, [In] KPFNKPJMKHJ LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F500D0", Offset = "0x6F4F2D0", VA = "0x186F500D0", Slot = "5")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F4FBC0", Offset = "0x6F4EDC0", VA = "0x186F4FBC0", Slot = "7")]
	public void CDBCEDMLJNK(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F500A0", Offset = "0x6F4F2A0", VA = "0x186F500A0", Slot = "8")]
	public void OLCAAIPHEIP(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6F4FD70", Offset = "0x6F4EF70", VA = "0x186F4FD70", Slot = "9")]
	public void IGNDFADNBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6F50170", Offset = "0x6F4F370", VA = "0x186F50170", Slot = "10")]
	public void PLNIPPDHELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6F4FBF0", Offset = "0x6F4EDF0", VA = "0x186F4FBF0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855B40", VA = "0x180856940", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8581C0", VA = "0x180858FC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public LIJOKMDFOFH MCJHNAIMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x855DC0", VA = "0x180856BC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x85A6C0", VA = "0x18085B4C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 JGCPBAEFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x6F48520", Offset = "0x6F47720", VA = "0x186F48520", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6F47470", Offset = "0x6F46670", VA = "0x186F47470", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 PCBLAEINONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6F476C0", Offset = "0x6F468C0", VA = "0x186F476C0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6F46000", Offset = "0x6F45200", VA = "0x186F46000", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 DOJOOKOADMA
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6F482A0", Offset = "0x6F474A0", VA = "0x186F482A0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6F46210", Offset = "0x6F45410", VA = "0x186F46210", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 NNHDGLHBCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6F465A0", Offset = "0x6F457A0", VA = "0x186F465A0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6F466D0", Offset = "0x6F458D0", VA = "0x186F466D0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float OBLJBMFPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE7F0", Offset = "0x8BD9F0", VA = "0x1808BE7F0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6F45750", Offset = "0x6F44950", VA = "0x186F45750", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool BOOAKEKDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x18C9530", Offset = "0x18C8730", VA = "0x1818C9530", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private MPONMNOKEDF FDMIHFIIOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x676A6D0", Offset = "0x67698D0", VA = "0x18676A6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool CBCMAKKEDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6F47C10", Offset = "0x6F46E10", VA = "0x186F47C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6F48B70", Offset = "0x6F47D70", VA = "0x186F48B70")]
	public FIHADBAPKAD(LJEEPNBNNHB NKIPNFFBDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6F46940", Offset = "0x6F45B40", VA = "0x186F46940", Slot = "19")]
	public void PJMDLPKCJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6F46380", Offset = "0x6F45580", VA = "0x186F46380", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6F45E10", Offset = "0x6F45010", VA = "0x186F45E10", Slot = "28")]
	public void BPPFGEIDBGG(Rigidbody AMBNMKKFJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xD2DF40", Offset = "0xD2D140", VA = "0x180D2DF40", Slot = "20")]
	public void KBNPIHBKMOE(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xD2C6D0", Offset = "0xD2B8D0", VA = "0x180D2C6D0", Slot = "30")]
	public void NLMCONACPDB(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6F46030", Offset = "0x6F45230", VA = "0x186F46030", Slot = "35")]
	public Vector3 CMIOFOLPDBD(Vector3 FIMFMOJFCFJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6F463E0", Offset = "0x6F455E0", VA = "0x186F463E0", Slot = "34")]
	public Vector3 EHACCJENFAB(Vector3 NOGFFKGBCOL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6F46940", Offset = "0x6F45B40", VA = "0x186F46940", Slot = "27")]
	public void FOFMMMJGGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6F45F40", Offset = "0x6F45140", VA = "0x186F45F40", Slot = "25")]
	public void CELBLPAFCIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6F48B10", Offset = "0x6F47D10", VA = "0x186F48B10", Slot = "24")]
	public void PMEPFJEJIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6F46700", Offset = "0x6F45900", VA = "0x186F46700", Slot = "33")]
	public void FLNMHLJEABK(Vector3 HFOBNBKELJL, Vector3 MHBEFOAKJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6F45FA0", Offset = "0x6F451A0", VA = "0x186F45FA0", Slot = "32")]
	public void CHAAMCPOLKD(Vector3 JNININDALMJ, Vector3 IGMBCDNHIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6F455B0", Offset = "0x6F447B0", VA = "0x186F455B0", Slot = "31")]
	public void ADFDPALOCLC(Vector3 HGGENDDBBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6F47C30", Offset = "0x6F46E30", VA = "0x186F47C30", Slot = "22")]
	public void OEHCHBFDEKM(CJOGEGMLKDO OEJNBMLJOIB, Vector3 NBOECIFPPEF, float AHEAGOIPKJF, float CNMGOEBKPGK = 8f, float IMBABICPDKH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6F477E0", Offset = "0x6F469E0", VA = "0x186F477E0", Slot = "21")]
	public void LDGDMKCOGAH(JCBCIKFMAML KEJNJHGGNMJ, Vector3 BJMFJJKFMAF, float EEDKOLOOPKK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6F47080", Offset = "0x6F46280", VA = "0x186F47080", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JLBJDDHJOHM(JCBCIKFMAML KEJNJHGGNMJ, Vector3 LCDJINCAHMD, float ONOCCGOPHEL = 7f, float BKJDNLFEDGK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xE322D0", Offset = "0xE314D0", VA = "0x180E322D0")]
	private static void CNEEAMJCMOP(Vector3 GPJLHMNPICC, Vector3 NFFLDAHKGKD, [Out] Vector3 OPMHPIHPDOH, [Out] Vector3 CEIIPAPENEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6F46FA0", Offset = "0x6F461A0", VA = "0x186F46FA0", Slot = "29")]
	public Vector3 IGGKIKFINPM(Vector3 GPJLHMNPICC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6F47530", Offset = "0x6F46730", VA = "0x186F47530", Slot = "26")]
	public void JOFNHGFIFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6F45750", Offset = "0x6F44950", VA = "0x186F45750")]
	private void AIOGMGGHDKM(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6F47A70", Offset = "0x6F46C70", VA = "0x186F47A70")]
	private void MHAHPHBFLCI(Vector3 BJMFJJKFMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6F48400", Offset = "0x6F47600", VA = "0x186F48400")]
	private Vector3 OOAPJNOBCPA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6F45860", Offset = "0x6F44A60", VA = "0x186F45860")]
	private void AJGHMPFPAMD(Vector3 NOGFFKGBCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6F45CF0", Offset = "0x6F44EF0", VA = "0x186F45CF0")]
	private Vector3 BGIAFHGNAFC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6F48680", Offset = "0x6F47880", VA = "0x186F48680")]
	private void PDHGDFGJFJA(Vector3 JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6F469F0", Offset = "0x6F45BF0", VA = "0x186F469F0")]
	private void HEBCAMHGKPG(Vector3 NOGFFKGBCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6F462D0", Offset = "0x6F454D0", VA = "0x186F462D0")]
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
