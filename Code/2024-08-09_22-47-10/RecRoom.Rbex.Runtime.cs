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
	public class LogRegistrationIndex : DLJCNHBICIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F40CC0", Offset = "0x6F400C0", VA = "0x186F40CC0", Slot = "4")]
		public override void NLGJOIAOEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
	public class _AssemblyIndex : OIHPLJCCMGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HELGCKGNJCP bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x15D3CC0", Offset = "0x15D30C0", VA = "0x1815D3CC0", Slot = "5")]
		public override void LGJJIPPJFHB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F56500", Offset = "0x6F55900", VA = "0x186F56500")]
		private void HKLAFMGGDHJ(NLGBDMBMDHC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F56810", Offset = "0x6F55C10", VA = "0x186F56810", Slot = "6")]
		public override void HOLCLMBHKNK(NLGBDMBMDHC registry, [In] FACCPJLOOCE filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "8")]
		public override void DLOFGCDOMEH(FELKOHNNBJK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F56870", Offset = "0x6F55C70", VA = "0x186F56870")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, DMMCHBJDPCN
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly BADOKLEEAHE MBNPFEACONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool JAIJELAEFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private CCDJNBGDDDE DEAKFCJIHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[AFPIJOONNOP(HNCPNLMMHNP.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[AFPIJOONNOP(HNCPNLMMHNP.SelfAndParent, true, false, false)]
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
		private DJAFCNJDKGP physicsInterpolation;

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
		internal CCDJNBGDDDE KPFDILKCFKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6F52280", Offset = "0x6F51680", VA = "0x186F52280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private CCDJNBGDDDE IIONFKDPHBF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int ADMDKGAABJL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F53930", Offset = "0x6F52D30", VA = "0x186F53930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx BMJDMEMGCAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F53C90", Offset = "0x6F53090", VA = "0x186F53C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx JIDLAENMFAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F53BD0", Offset = "0x6F52FD0", VA = "0x186F53BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx KOBAADDGPBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6F54940", Offset = "0x6F53D40", VA = "0x186F54940")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F55E70", Offset = "0x6F55270", VA = "0x186F55E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform BLKBKBBBALH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x874790", Offset = "0x873B90", VA = "0x180874790", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform CBIMHGFCJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x874790", Offset = "0x873B90", VA = "0x180874790", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BCGHGEBOGGJ KHHHEGHLHPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F53990", Offset = "0x6F52D90", VA = "0x186F53990")]
			get
			{
				return default(BCGHGEBOGGJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F55620", Offset = "0x6F54A20", VA = "0x186F55620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GCOOADPCENM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F53FA0", Offset = "0x6F533A0", VA = "0x186F53FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NHECKGLEIGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F53AB0", Offset = "0x6F52EB0", VA = "0x186F53AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public PFGMJPGCKDN FNIKKHIDKFE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F53EE0", Offset = "0x6F532E0", VA = "0x186F53EE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F557E0", Offset = "0x6F54BE0", VA = "0x186F557E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public KPCMLMPKPIO FJJLNPOBMNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F53E80", Offset = "0x6F53280", VA = "0x186F53E80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F55770", Offset = "0x6F54B70", VA = "0x186F55770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool PIGAGNMMPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F53DD0", Offset = "0x6F531D0", VA = "0x186F53DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody MLNLGAAEPGN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F53E30", Offset = "0x6F53230", VA = "0x186F53E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OCDFAMCJFHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F53B10", Offset = "0x6F52F10", VA = "0x186F53B10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F55690", Offset = "0x6F54A90", VA = "0x186F55690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IDNBOKFCIMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6C2F2A0", Offset = "0x6C2E6A0", VA = "0x186C2F2A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float EJJKGLMJAHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F548E0", Offset = "0x6F53CE0", VA = "0x186F548E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float DNIBKKDLNNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F54880", Offset = "0x6F53C80", VA = "0x186F54880")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F55E00", Offset = "0x6F55200", VA = "0x186F55E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float CKOKLCCANIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F54200", Offset = "0x6F53600", VA = "0x186F54200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F55A80", Offset = "0x6F54E80", VA = "0x186F55A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float CMIDBFEELBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F54000", Offset = "0x6F53400", VA = "0x186F54000")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6F55850", Offset = "0x6F54C50", VA = "0x186F55850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool DCOKKEIAOOK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6F54EC0", Offset = "0x6F542C0", VA = "0x186F54EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F563B0", Offset = "0x6F557B0", VA = "0x186F563B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 DFLCIKLKBHH
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F54660", Offset = "0x6F53A60", VA = "0x186F54660")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F55BD0", Offset = "0x6F54FD0", VA = "0x186F55BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 BIDGICCMIOO
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F55000", Offset = "0x6F54400", VA = "0x186F55000")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode BDPKFMAFACE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F54140", Offset = "0x6F53540", VA = "0x186F54140")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6F559A0", Offset = "0x6F54DA0", VA = "0x186F559A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float BAJAEPAMIBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F53B70", Offset = "0x6F52F70", VA = "0x186F53B70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F55700", Offset = "0x6F54B00", VA = "0x186F55700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints HNHIGMJKFJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F541A0", Offset = "0x6F535A0", VA = "0x186F541A0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F55A10", Offset = "0x6F54E10", VA = "0x186F55A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 KLNCNHKFOBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F54A00", Offset = "0x6F53E00", VA = "0x186F54A00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 GFGJAGMEJKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F54A00", Offset = "0x6F53E00", VA = "0x186F54A00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F56190", Offset = "0x6F55590", VA = "0x186F56190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float OGCFKDPCEML
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6F54740", Offset = "0x6F53B40", VA = "0x186F54740")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F55CB0", Offset = "0x6F550B0", VA = "0x186F55CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float EHKLFKCJDIB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F54E60", Offset = "0x6F54260", VA = "0x186F54E60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F56340", Offset = "0x6F55740", VA = "0x186F56340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion CCANBOFGEGI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F54AE0", Offset = "0x6F53EE0", VA = "0x186F54AE0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F55F10", Offset = "0x6F55310", VA = "0x186F55F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion EHENAJNDLDI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F54D80", Offset = "0x6F54180", VA = "0x186F54D80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6F56270", Offset = "0x6F55670", VA = "0x186F56270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 PCCJNFKEDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F54BC0", Offset = "0x6F53FC0", VA = "0x186F54BC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6F55FE0", Offset = "0x6F553E0", VA = "0x186F55FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DDLOGGFKNCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F54CA0", Offset = "0x6F540A0", VA = "0x186F54CA0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6F560C0", Offset = "0x6F554C0", VA = "0x186F560C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 CLFPHNHFBOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F54F20", Offset = "0x6F54320", VA = "0x186F54F20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6F56420", Offset = "0x6F55820", VA = "0x186F56420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 DFABCICEPAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6F547A0", Offset = "0x6F53BA0", VA = "0x186F547A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6F55D20", Offset = "0x6F55120", VA = "0x186F55D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 LHKMHBCIMBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6F54060", Offset = "0x6F53460", VA = "0x186F54060")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6F558C0", Offset = "0x6F54CC0", VA = "0x186F558C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 NAKIJOPFMKM
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6F54580", Offset = "0x6F53980", VA = "0x186F54580")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6F55AF0", Offset = "0x6F54EF0", VA = "0x186F55AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 MGJBBOCIDIM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6F54440", Offset = "0x6F53840", VA = "0x186F54440")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion CMEMFGLEONN
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6F54360", Offset = "0x6F53760", VA = "0x186F54360")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 FEJFPNKNDKE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6F551C0", Offset = "0x6F545C0", VA = "0x186F551C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 OFNHDFCKPJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6F550E0", Offset = "0x6F544E0", VA = "0x186F550E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool CMPKFIGHGBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6F54520", Offset = "0x6F53920", VA = "0x186F54520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool OOEKHHGEKDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6F53F40", Offset = "0x6F53340", VA = "0x186F53F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool LDBCOOJLKEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6F53A50", Offset = "0x6F52E50", VA = "0x186F53A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool LDLIGAOIGFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6F539F0", Offset = "0x6F52DF0", VA = "0x186F539F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool PAFCEDFALMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6F538D0", Offset = "0x6F52CD0", VA = "0x186F538D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool MBHKJPLIENN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6F54260", Offset = "0x6F53660", VA = "0x186F54260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool ADBLGJPBPPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1841E60", Offset = "0x1841260", VA = "0x181841E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event NHDOEHJFCKK OPDHOGPJDCF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F537F0", Offset = "0x6F52BF0", VA = "0x186F537F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6F55540", Offset = "0x6F54940", VA = "0x186F55540")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ADPKLNACACP KEBHKJEAMAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6F53560", Offset = "0x6F52960", VA = "0x186F53560")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6F552A0", Offset = "0x6F546A0", VA = "0x186F552A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ADPKLNACACP CLHCIGIJGAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F535C0", Offset = "0x6F529C0", VA = "0x186F535C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6F55310", Offset = "0x6F54710", VA = "0x186F55310")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event ADPKLNACACP BOGHLMGLDPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6F53710", Offset = "0x6F52B10", VA = "0x186F53710")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6F55460", Offset = "0x6F54860", VA = "0x186F55460")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<DHNIPGENADJ, DHNIPGENADJ> IIICKDLOGIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F536A0", Offset = "0x6F52AA0", VA = "0x186F536A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F553F0", Offset = "0x6F547F0", VA = "0x186F553F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event ADPKLNACACP MPEDFKCKFLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F53780", Offset = "0x6F52B80", VA = "0x186F53780")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F554D0", Offset = "0x6F548D0", VA = "0x186F554D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event ADPKLNACACP HHMKPNDNKOE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F53860", Offset = "0x6F52C60", VA = "0x186F53860")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F555B0", Offset = "0x6F549B0", VA = "0x186F555B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event ADPKLNACACP EBIDEGDEGNO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F53630", Offset = "0x6F52A30", VA = "0x186F53630")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F55380", Offset = "0x6F54780", VA = "0x186F55380")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84D8D0", Offset = "0x84CCD0", VA = "0x18084D8D0", Slot = "8")]
		private void HANKKFGHLMO(CCDJNBGDDDE DJKNDPHDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F51EE0", Offset = "0x6F512E0", VA = "0x186F51EE0")]
		internal void DKCNFNLBJIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F53280", Offset = "0x6F52680", VA = "0x186F53280")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody EEBBGMAHIJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F51FD0", Offset = "0x6F513D0", VA = "0x186F51FD0")]
		public DMMCHBJDPCN GetChild(int AGAGKNBDCIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6F52F50", Offset = "0x6F52350", VA = "0x186F52F50")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) NABKBOELDNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F51AD0", Offset = "0x6F50ED0", VA = "0x186F51AD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F52280", Offset = "0x6F51680", VA = "0x186F52280")]
		private CCDJNBGDDDE HAGFNLDPMOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F51B40", Offset = "0x6F50F40", VA = "0x186F51B40")]
		private void BGMBKGHFJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F52720", Offset = "0x6F51B20", VA = "0x186F52720")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F51EE0", Offset = "0x6F512E0", VA = "0x186F51EE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F526C0", Offset = "0x6F51AC0", VA = "0x186F526C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F52780", Offset = "0x6F51B80", VA = "0x186F52780")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F51180", Offset = "0x6F50580", VA = "0x186F51180")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object IAIFDAAIBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F527E0", Offset = "0x6F51BE0", VA = "0x186F527E0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object IAIFDAAIBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F51F70", Offset = "0x6F51370", VA = "0x186F51F70")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F52660", Offset = "0x6F51A60", VA = "0x186F52660")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F530B0", Offset = "0x6F524B0", VA = "0x186F530B0")]
		public void SetParent(RigidbodyEx OBEEJPGJPFD, bool ONNBDPJFLCI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F52AF0", Offset = "0x6F51EF0", VA = "0x186F52AF0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F52330", Offset = "0x6F51730", VA = "0x186F52330")]
		public bool IsRigidbodyAncestor(RigidbodyEx OBIBGJDAAJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F52410", Offset = "0x6F51810", VA = "0x186F52410")]
		public bool IsRigidbodyDescendant(RigidbodyEx PNFONMNLJHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F513F0", Offset = "0x6F507F0", VA = "0x186F513F0")]
		public void AddInterpolationRestriction(object IAIFDAAIBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F52850", Offset = "0x6F51C50", VA = "0x186F52850")]
		public void RemoveInterpolationRestriction(object IAIFDAAIBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F51460", Offset = "0x6F50860", VA = "0x186F51460")]
		public void AddKinematic(object IAIFDAAIBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F528C0", Offset = "0x6F51CC0", VA = "0x186F528C0")]
		public void RemoveKinematic(object IAIFDAAIBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F53030", Offset = "0x6F52430", VA = "0x186F53030")]
		public void SetKinematic(object IAIFDAAIBBN, bool CMADNBKCNLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F52E50", Offset = "0x6F52250", VA = "0x186F52E50")]
		public void SetDiscontinuousPositionAndRotation(Vector3 CAGMGLLKHIL, Quaternion EGOOOFEFDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F52D50", Offset = "0x6F52150", VA = "0x186F52D50")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 KCBBKKIJODF, Quaternion JDFPMPLMODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F52170", Offset = "0x6F51570", VA = "0x186F52170")]
		public Vector3 GetConstrainedVelocity(Vector3 CLFPHNHFBOP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F52060", Offset = "0x6F51460", VA = "0x186F52060")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 LHKMHBCIMBF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F51300", Offset = "0x6F50700", VA = "0x186F51300")]
		public void AddForce(Vector3 MCCPONPGBFK, ForceMode ELJCKLEHNDE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F511F0", Offset = "0x6F505F0", VA = "0x186F511F0")]
		public void AddForceAtPosition(Vector3 MCCPONPGBFK, Vector3 HBGADHMDPAD, ForceMode ELJCKLEHNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F51630", Offset = "0x6F50A30", VA = "0x186F51630")]
		public void AddTorque(Vector3 NCIODGEKLOH, ForceMode ELJCKLEHNDE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F514D0", Offset = "0x6F508D0", VA = "0x186F514D0")]
		public void AddRelativeTorque(Vector3 NCIODGEKLOH, ForceMode ELJCKLEHNDE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F53350", Offset = "0x6F52750", VA = "0x186F53350")]
		public Vector3 WorldToLocalVelocity(Vector3 HBNBBIDAMOF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F52550", Offset = "0x6F51950", VA = "0x186F52550")]
		public Vector3 LocalToWorldVelocity(Vector3 DFABCICEPAA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F51E80", Offset = "0x6F51280", VA = "0x186F51E80")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F51E20", Offset = "0x6F51220", VA = "0x186F51E20")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F51DC0", Offset = "0x6F511C0", VA = "0x186F51DC0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F51D60", Offset = "0x6F51160", VA = "0x186F51D60")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F52C50", Offset = "0x6F52050", VA = "0x186F52C50")]
		public void ResetVelocityWorldSpace(Vector3 FPIOEGKPDHN, Vector3 BIIKFDLLGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F52B50", Offset = "0x6F51F50", VA = "0x186F52B50")]
		public void ResetVelocityLocalSpace(Vector3 IIOAECOBFCF, Vector3 NAKIJOPFMKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F52A10", Offset = "0x6F51E10", VA = "0x186F52A10")]
		public void ResetLinearVelocityLocalSpace(Vector3 IIOAECOBFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F531E0", Offset = "0x6F525E0", VA = "0x186F531E0")]
		public bool SweepTest(Vector3 EOKIIKENLCD, [Out] RaycastHit EENPCFCEILM, float LDGBFHOOAML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F524F0", Offset = "0x6F518F0", VA = "0x186F524F0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F53180", Offset = "0x6F52580", VA = "0x186F53180")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F532F0", Offset = "0x6F526F0", VA = "0x186F532F0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F515C0", Offset = "0x6F509C0", VA = "0x186F515C0")]
		public void AddShouldHaveUnityRigidbodyToken(object IAIFDAAIBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F52930", Offset = "0x6F51D30", VA = "0x186F52930")]
		public void RemoveShouldHaveUnityRigidbodyToken(object IAIFDAAIBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6F51960", Offset = "0x6F50D60", VA = "0x186F51960")]
		public void ApplyForceVelocityChange(AAHEMBGGCHJ PNJDOEEGGNC, Vector3 EMOBCJNELGO, float KLPBBMDHNKK, float KOJOBIBDCMN = 8f, float COFKNDPPEKN = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F518C0", Offset = "0x6F50CC0", VA = "0x186F518C0")]
		public void ApplyAngularVelocityChange(FLBJHNGHAGI GPAFAKKLCNE, Vector3 OEDPIGEECGA, float LPNMJGDPLAP = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F51A20", Offset = "0x6F50E20", VA = "0x186F51A20")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(FLBJHNGHAGI GPAFAKKLCNE, Vector3 MGJIDJKDGAB, float ADKJPLGKKMF = 7f, float IFCJLPHCGOF = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F517F0", Offset = "0x6F50BF0", VA = "0x186F517F0")]
		public bool AllowedScaleChange(float GJLNPLOFFPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F51720", Offset = "0x6F50B20", VA = "0x186F51720")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx FBEDMBNBOFH, object IAIFDAAIBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6F529A0", Offset = "0x6F51DA0", VA = "0x186F529A0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object IAIFDAAIBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F534F0", Offset = "0x6F528F0", VA = "0x186F534F0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA19540", Offset = "0xA18940", VA = "0x180A19540", Slot = "4")]
		private GameObject AFEICAKENBD()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x874790", Offset = "0x873B90", VA = "0x180874790", Slot = "5")]
		private Transform HLGBEMKPDIG()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class CLKACMNBHHJ
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BDA0", Offset = "0x6F3B1A0", VA = "0x186F3BDA0")]
	public static CCDJNBGDDDE KPFDILKCFKP(this RigidbodyEx CNGOHFHGBJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[EFCEPDIPLEI(typeof(MHFODEJJPLD), new string[] { })]
public class DFOPMDCFHAK : MHFODEJJPLD, HGLPGAMBODG
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly BADOKLEEAHE MMCLBKHCHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private MKKHJLBCCIL GGNPHHPCMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private IMLPALOEBAE PKEMJFONHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private FMABOFKJJKO CKALPNOBHCO;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IMLPALOEBAE AGNMBNKNMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public FMABOFKJJKO JIOIKLLILMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BEA0", Offset = "0x6F3B2A0", VA = "0x186F3BEA0", Slot = "7")]
	public void InitReferences(EGOJPPMNMDN AGFGGBNBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BE10", Offset = "0x6F3B210", VA = "0x186F3BE10", Slot = "6")]
	public CCDJNBGDDDE AEBLEKKDDII(RigidbodyEx CNGOHFHGBJN, MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public DFOPMDCFHAK()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static IDDBOOGKPOH UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int LPLCGLDDNEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int IMIGIOBKGGD;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F50FE0", Offset = "0x6F503E0", VA = "0x186F50FE0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F51020", Offset = "0x6F50420", VA = "0x186F51020")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F51000", Offset = "0x6F50400", VA = "0x186F51000")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string PBDOHNMILPN, [Optional] UnityEngine.Object NMIKEFKOPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string PBDOHNMILPN, [Optional] UnityEngine.Object NMIKEFKOPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F51130", Offset = "0x6F50530", VA = "0x186F51130")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FBLCPEJMCEL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class IHIILDFPLID : PFGMJPGCKDN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x85BD60", Offset = "0x85B160", VA = "0x18085BD60", Slot = "4")]
		public Vector3 EOLCLJOHCMF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x85BD60", Offset = "0x85B160", VA = "0x18085BD60", Slot = "5")]
		public Vector3 BNFPCBOPEEJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public IHIILDFPLID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static PFGMJPGCKDN BFGPCJJMOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F3D1C0", Offset = "0x6F3C5C0", VA = "0x186F3D1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DBDJCPOJEEH
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode JHDFCCCMAEO
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
	void EOHNLKEPLBJ();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GMIIAEEPHMI(bool CMPKFIGHGBB);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFODBIHOFAM(bool CMPKFIGHGBB);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PLFJKHPOFKB(Rigidbody DCMLHPJLAOP);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HNOFHCBDPOD(Vector3 EOKIIKENLCD, [Out] RaycastHit EENPCFCEILM, float LDGBFHOOAML);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MJEJHLBBCJG : IDisposable, KPLOEMKEKII
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	BCGHGEBOGGJ KHHHEGHLHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<DHNIPGENADJ, DHNIPGENADJ> IIICKDLOGIA;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EOHNLKEPLBJ();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[HNPBPAPMCJD(HLMJHHDGPFE.Application)]
public interface FMABOFKJJKO
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AMBJIFNMLIM JEHDKNNCAFO(CCDJNBGDDDE DJKNDPHDPMJ);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NDMONJOFEPH ADADJKNDPAH(CCDJNBGDDDE DJKNDPHDPMJ);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FPOBIJMEOJK ELCNKJIBMDC(CCDJNBGDDDE DJKNDPHDPMJ);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IPFNIOPBPHB PPCAEJHBABA(CCDJNBGDDDE DJKNDPHDPMJ);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NJCPPIKPDOE EEFOIACPEIG(CCDJNBGDDDE DJKNDPHDPMJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MJEJHLBBCJG EBKJHODGEJF(CCDJNBGDDDE DJKNDPHDPMJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LEHHMIHENFC BGGLFPNICCC(CCDJNBGDDDE DJKNDPHDPMJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CNCFFBJBEKH MOLLBCMPLLP(CCDJNBGDDDE DJKNDPHDPMJ);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DBDJCPOJEEH ELKDIDHEBOI(CCDJNBGDDDE DJKNDPHDPMJ);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GDDLCFKBAIN KNFFLNLMAOB(CCDJNBGDDDE DJKNDPHDPMJ);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NFDFLOGLJJG KDDLGNMABNM(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NFKOLADOAEF HFMJHOLDJLB(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PEMACMFJPOC BBLJCEOLIJO(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KPCONFPCDMB OPHNOOLJMPE(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	BHMHJPFICDO EJMPNNMLMNP(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CCDJNBGDDDE AEBLEKKDDII(RigidbodyEx CNGOHFHGBJN, MOGMJHIJFHA LDNEPNAGEGN, MHFODEJJPLD BENNAIJLPHL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CNCFFBJBEKH
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMCBPIBKMNK(Vector3 MCCPONPGBFK, ForceMode ELJCKLEHNDE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EDEKJELHBDP(Vector3 MCCPONPGBFK, Vector3 HBGADHMDPAD, ForceMode ELJCKLEHNDE);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDAJJMPKDFJ(Vector3 NCIODGEKLOH, ForceMode ELJCKLEHNDE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PNNACAJMBFM(Vector3 NCIODGEKLOH, ForceMode ELJCKLEHNDE = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GDDLCFKBAIN
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool AKDNFEKFHKK
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
	void PLFJKHPOFKB(Rigidbody DCMLHPJLAOP);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CDGKKKCFKDO(Rigidbody DCMLHPJLAOP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AMBJIFNMLIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<CCDJNBGDDDE> AOHANOFFJEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	CCDJNBGDDDE JIDLAENMFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CCDJNBGDDDE EOCBFDAOCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event ADPKLNACACP KEBHKJEAMAM;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event ADPKLNACACP CLHCIGIJGAG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event NHDOEHJFCKK KNGCIADPLKK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action JPIKAOHNLOO;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action JGGBONBLOOD;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<CCDJNBGDDDE> GONLKOAJNGI;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<CCDJNBGDDDE> ONGJMFDLGHB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action JHFNPGABABC;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<CCDJNBGDDDE> NANOBNEGFIK;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ECNJEHIAHLH(CCDJNBGDDDE DADNCNLHDCH, bool ONNBDPJFLCI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FPOBIJMEOJK
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 JNAEFCNFMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 IFFOPIHEHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LCCBCHBIOKI(CCDJNBGDDDE KOBAADDGPBN, object IAIFDAAIBBN);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GLFFAOJHKEI(object IAIFDAAIBBN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KPCONFPCDMB
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 KCKPPPFOFGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 IOAEGOHIJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float AODHLGOPLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float IMBJJLGMFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 KLPANANJHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion PNBNFKGNIDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event ADPKLNACACP MMOCGHHNIIL;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AGOJFIAFAAL((Quaternion rot, Vector3 moments) NABKBOELDNH);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PONKNLICDLL();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EFOKCICDEIC();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FPGOLMDLFOH();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PLFJKHPOFKB(Rigidbody DCMLHPJLAOP);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CDGKKKCFKDO(Rigidbody DCMLHPJLAOP);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LLDKFMDONLA();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PEMACMFJPOC
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOHNLKEPLBJ();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIAAPDCHOOD(object IAIFDAAIBBN);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPCBJBPBPLB(object IAIFDAAIBBN);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGEIJNCHMNI(CCDJNBGDDDE CNGOHFHGBJN);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGBCPNHECAM(CCDJNBGDDDE CNGOHFHGBJN);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NCICBJMEJOF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LEHHMIHENFC
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool IHGNCMOLCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event ADPKLNACACP BOOAACEFJCE;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DILLJPEBACK(object IAIFDAAIBBN);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKGLHCHDIMC(object IAIFDAAIBBN);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HKDHOKBGJGH(object IAIFDAAIBBN, bool CMADNBKCNLA);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PLFJKHPOFKB(Rigidbody LMOGFGDEOJM);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CDGKKKCFKDO(Rigidbody DCMLHPJLAOP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NFKOLADOAEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool GCOOADPCENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool NHECKGLEIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event ADPKLNACACP FECDFNNGMEE;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EOHNLKEPLBJ();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CELHADHHPMJ(CCDJNBGDDDE KOBAADDGPBN);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JDLGABBFNFF(CCDJNBGDDDE KOBAADDGPBN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BHMHJPFICDO
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool OCDFAMCJFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool FBDJFMIBLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints NAHFNGGGPLG
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
	void PLFJKHPOFKB(Rigidbody DCMLHPJLAOP);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CDGKKKCFKDO(Rigidbody DCMLHPJLAOP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IPFNIOPBPHB
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float BIKCECPLMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float AFNKOIOCGOH
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
	void PLFJKHPOFKB(Rigidbody DCMLHPJLAOP);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CDGKKKCFKDO(Rigidbody DCMLHPJLAOP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NJCPPIKPDOE
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event ADPKLNACACP GFIOGCGHGEG;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOHNLKEPLBJ();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BBNCMEPMHFD();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IMGGEELGDDJ();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MPBOONPMKBA();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BLOFDHDLMGN();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void APEINKEJOLJ();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NFDFLOGLJJG
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody MLNLGAAEPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool GEMJPJHMOHG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOHNLKEPLBJ();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CDFJLCNHLAH(object IAIFDAAIBBN);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECABBGKKPGG(object IAIFDAAIBBN);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MJJGJLNHOAP();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NDMONJOFEPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	PFGMJPGCKDN FNIKKHIDKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	KPCMLMPKPIO FJJLNPOBMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 KBKBJDBMDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 FCAPPEBFPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 IKKCDALJGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 HDJMEOPFDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float BAJAEPAMIBD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool PIGAGNMMPAK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EOHNLKEPLBJ();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AJBLCBEPPHG(object IAIFDAAIBBN);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LCPANJMIOMC(FLBJHNGHAGI GPAFAKKLCNE, Vector3 OEDPIGEECGA, float LPNMJGDPLAP = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FJEHBHGJDME(AAHEMBGGCHJ PNJDOEEGGNC, Vector3 EMOBCJNELGO, float KLPBBMDHNKK, float KOJOBIBDCMN = 8f, float COFKNDPPEKN = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PJKOPADLMJI(FLBJHNGHAGI GPAFAKKLCNE, Vector3 MGJIDJKDGAB, float ADKJPLGKKMF = 7f, float IFCJLPHCGOF = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MACGJECPGED();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MMOHKMCODIM();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IGJHPNEPEFN();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void APHEJDKJFPF();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PLFJKHPOFKB(Rigidbody DCMLHPJLAOP);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 DJALDLIBFJF(Vector3 CLFPHNHFBOP);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NIAEMJNAGBN(object IAIFDAAIBBN);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EPEBDIJNKGN(Vector3 JLHNNPABOCG);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FHCBDLFBBBN(Vector3 IIOAECOBFCF, Vector3 NAKIJOPFMKM);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void GEHCJMBAPIF(Vector3 FPIOEGKPDHN, Vector3 BIIKFDLLGHA);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 POEFOLGJGPE(Vector3 DFABCICEPAA);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 CPGCPEJNDCI(Vector3 HBNBBIDAMOF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[HNPBPAPMCJD(HLMJHHDGPFE.Application)]
public interface IMLPALOEBAE
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool BKKEKOJEEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPJLIFIEKII(string ODIFAFDGMDE);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCMDKNKDANB(RigidbodyEx CNGOHFHGBJN, Action FADGJFNLBLP);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LLLKKOLPLLJ CDEGNFCMDHJ(int JPLHBKKJNAG);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DBDHNKBODIA(Vector3 BIDGICCMIOO, float AOIMHDCLCCB, Color IGDDAGDAAIO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[HNPBPAPMCJD(HLMJHHDGPFE.Application)]
public interface MHFODEJJPLD
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	IMLPALOEBAE AGNMBNKNMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	FMABOFKJJKO JIOIKLLILMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CCDJNBGDDDE AEBLEKKDDII(RigidbodyEx CNGOHFHGBJN, MOGMJHIJFHA LDNEPNAGEGN);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PGANAEOOJLB : CCDJNBGDDDE, IDisposable, JGEMEGIPJEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly MHFODEJJPLD BENNAIJLPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal AMBJIFNMLIM BBFJJKDIBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal PEMACMFJPOC MDGLEEEHGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal NFKOLADOAEF BNKPJOLHMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal NDMONJOFEPH CLFPHNHFBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal FPOBIJMEOJK IKFEGOJNGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal KPCONFPCDMB KBKFMDIELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal IPFNIOPBPHB DPLOKDHMPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal GDDLCFKBAIN MKEKIHPKHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal NJCPPIKPDOE BIMFFMDGPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal MJEJHLBBCJG KPHCFDIACKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal LEHHMIHENFC BLCLODMGFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal CNCFFBJBEKH MCCPONPGBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal BHMHJPFICDO ACEOOLHCJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal NFDFLOGLJJG DCMLHPJLAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal DBDJCPOJEEH AFNDNNABLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable JJDPLCDPCNH;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EBAHGGHEDAJ FGFMCGCOEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "22")]
		get
		{
			return default(EBAHGGHEDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public DMMCHBJDPCN OJFFBLOODPB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x855F80", Offset = "0x855380", VA = "0x180855F80", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x855FD0", Offset = "0x8553D0", VA = "0x180855FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject MHEPINPOCON
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xB372F0", Offset = "0xB366F0", VA = "0x180B372F0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xAB6500", Offset = "0xAB5900", VA = "0x180AB6500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform PEDBLOEBMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F9D0", Offset = "0x6F4EDD0", VA = "0x186F4F9D0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody MLNLGAAEPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6F4E490", Offset = "0x6F4D890", VA = "0x186F4E490", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public CCDJNBGDDDE EOCBFDAOCJD
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F5F0", Offset = "0x6F4E9F0", VA = "0x186F4F5F0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6F4E900", Offset = "0x6F4DD00", VA = "0x186F4E900", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int ADMDKGAABJL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A4A0", Offset = "0x6F498A0", VA = "0x186F4A4A0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public CCDJNBGDDDE JIDLAENMFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F980", Offset = "0x6F4ED80", VA = "0x186F4F980", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool LAAKKNFBEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F150", Offset = "0x6F4E550", VA = "0x186F4F150", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool GCOOADPCENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C120", Offset = "0x6F4B520", VA = "0x186F4C120", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool NHECKGLEIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6F4EFB0", Offset = "0x6F4E3B0", VA = "0x186F4EFB0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public PFGMJPGCKDN FNIKKHIDKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D9D0", Offset = "0x6F4CDD0", VA = "0x186F4D9D0", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6F4E850", Offset = "0x6F4DC50", VA = "0x186F4E850", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public KPCMLMPKPIO FJJLNPOBMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6F4E3A0", Offset = "0x6F4D7A0", VA = "0x186F4E3A0", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F390", Offset = "0x6F4E790", VA = "0x186F4F390", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float BAJAEPAMIBD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DA80", Offset = "0x6F4CE80", VA = "0x186F4DA80", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6F4BB80", Offset = "0x6F4AF80", VA = "0x186F4BB80", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 FCAPPEBFPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B950", Offset = "0x6F4AD50", VA = "0x186F4B950", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C3A0", Offset = "0x6F4B7A0", VA = "0x186F4C3A0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 HDJMEOPFDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B820", Offset = "0x6F4AC20", VA = "0x186F4B820", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F450", Offset = "0x6F4E850", VA = "0x186F4F450", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 KBKBJDBMDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F850", Offset = "0x6F4EC50", VA = "0x186F4F850", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B080", Offset = "0x6F4A480", VA = "0x186F4B080", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 IKKCDALJGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AA20", Offset = "0x6F49E20", VA = "0x186F4AA20", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A510", Offset = "0x6F49910", VA = "0x186F4A510", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool LDBCOOJLKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6F4E8B0", Offset = "0x6F4DCB0", VA = "0x186F4E8B0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool LDLIGAOIGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A5F0", Offset = "0x6F499F0", VA = "0x186F4A5F0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool PAFCEDFALMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AE90", Offset = "0x6F4A290", VA = "0x186F4AE90", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool PIGAGNMMPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F2F0", Offset = "0x6F4E6F0", VA = "0x186F4F2F0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 JNAEFCNFMGG
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C480", Offset = "0x6F4B880", VA = "0x186F4C480", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 IFFOPIHEHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6F500C0", Offset = "0x6F4F4C0", VA = "0x186F500C0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 KCKPPPFOFGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CE10", Offset = "0x6F4C210", VA = "0x186F4CE10", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B660", Offset = "0x6F4AA60", VA = "0x186F4B660", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 IOAEGOHIJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DAD0", Offset = "0x6F4CED0", VA = "0x186F4DAD0", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float AODHLGOPLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F4EE60", Offset = "0x6F4E260", VA = "0x186F4EE60", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float IMBJJLGMFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DD20", Offset = "0x6F4D120", VA = "0x186F4DD20", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CAE0", Offset = "0x6F4BEE0", VA = "0x186F4CAE0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 KLPANANJHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D210", Offset = "0x6F4C610", VA = "0x186F4D210", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion PNBNFKGNIDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B1C0", Offset = "0x6F4A5C0", VA = "0x186F4B1C0", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float BIKCECPLMOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F930", Offset = "0x6F4ED30", VA = "0x186F4F930", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F4E1D0", Offset = "0x6F4D5D0", VA = "0x186F4E1D0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float AFNKOIOCGOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F1B0", Offset = "0x6F4E5B0", VA = "0x186F4F1B0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C620", Offset = "0x6F4BA20", VA = "0x186F4C620", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool AKDNFEKFHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F2A0", Offset = "0x6F4E6A0", VA = "0x186F4F2A0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AF70", Offset = "0x6F4A370", VA = "0x186F4AF70", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public BCGHGEBOGGJ KHHHEGHLHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F4BA30", Offset = "0x6F4AE30", VA = "0x186F4BA30", Slot = "68")]
		get
		{
			return default(BCGHGEBOGGJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A440", Offset = "0x6F49840", VA = "0x186F4A440", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool IHGNCMOLCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F250", Offset = "0x6F4E650", VA = "0x186F4F250", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform CBIMHGFCJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F4FEE0", Offset = "0x6F4F2E0", VA = "0x186F4FEE0", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 KOKFCMOGMIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F000", Offset = "0x6F4E400", VA = "0x186F4F000", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B290", Offset = "0x6F4A690", VA = "0x186F4B290", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float DNLDJKGBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F580", Offset = "0x6F4E980", VA = "0x186F4F580", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D880", Offset = "0x6F4CC80", VA = "0x186F4D880", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float JKNAIFBKPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F4BBE0", Offset = "0x6F4AFE0", VA = "0x186F4BBE0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F4FAB0", Offset = "0x6F4EEB0", VA = "0x186F4FAB0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion CENNPMCKHKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CD60", Offset = "0x6F4C160", VA = "0x186F4CD60", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F4EB70", Offset = "0x6F4DF70", VA = "0x186F4EB70", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 KIBNMIMEJJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F4EEB0", Offset = "0x6F4E2B0", VA = "0x186F4EEB0", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F4FA60", Offset = "0x6F4EE60", VA = "0x186F4FA60", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion KCKHOJFDOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F4FEA0", Offset = "0x6F4F2A0", VA = "0x186F4FEA0", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CAA0", Offset = "0x6F4BEA0", VA = "0x186F4CAA0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints NAHFNGGGPLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F4E440", Offset = "0x6F4D840", VA = "0x186F4E440", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B3B0", Offset = "0x6F4A7B0", VA = "0x186F4B3B0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool OCDFAMCJFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C8C0", Offset = "0x6F4BCC0", VA = "0x186F4C8C0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B4E0", Offset = "0x6F4A8E0", VA = "0x186F4B4E0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode JHDFCCCMAEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B900", Offset = "0x6F4AD00", VA = "0x186F4B900", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D730", Offset = "0x6F4CB30", VA = "0x186F4D730", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool KPFMJCINAON
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F4ECC0", Offset = "0x6F4E0C0", VA = "0x186F4ECC0", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool OOEKHHGEKDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D2F0", Offset = "0x6F4C6F0", VA = "0x186F4D2F0", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event ADPKLNACACP KEBHKJEAMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F6A0", Offset = "0x6F4EAA0", VA = "0x186F4F6A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6F4FFB0", Offset = "0x6F4F3B0", VA = "0x186F4FFB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event ADPKLNACACP CLHCIGIJGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6F4EA40", Offset = "0x6F4DE40", VA = "0x186F4EA40", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C1D0", Offset = "0x6F4B5D0", VA = "0x186F4C1D0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event NHDOEHJFCKK KNGCIADPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F3F0", Offset = "0x6F4E7F0", VA = "0x186F4F3F0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D620", Offset = "0x6F4CA20", VA = "0x186F4D620", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event ADPKLNACACP FECDFNNGMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6F4BEE0", Offset = "0x6F4B2E0", VA = "0x186F4BEE0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B600", Offset = "0x6F4AA00", VA = "0x186F4B600", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event ADPKLNACACP BOGHLMGLDPB
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B540", Offset = "0x6F4A940", VA = "0x186F4B540", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6F4FEF0", Offset = "0x6F4F2F0", VA = "0x186F4FEF0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event ADPKLNACACP GFIOGCGHGEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DA20", Offset = "0x6F4CE20", VA = "0x186F4DA20", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B160", Offset = "0x6F4A560", VA = "0x186F4B160", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<DHNIPGENADJ, DHNIPGENADJ> IIICKDLOGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B5A0", Offset = "0x6F4A9A0", VA = "0x186F4B5A0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F4F640", Offset = "0x6F4EA40", VA = "0x186F4F640", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event ADPKLNACACP BOOAACEFJCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D6D0", Offset = "0x6F4CAD0", VA = "0x186F4D6D0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F4EC60", Offset = "0x6F4E060", VA = "0x186F4EC60", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event ADPKLNACACP EBIDEGDEGNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AFD0", Offset = "0x6F4A3D0", VA = "0x186F4AFD0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AC90", Offset = "0x6F4A090", VA = "0x186F4AC90", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6F50410", Offset = "0x6F4F810", VA = "0x186F50410")]
	public PGANAEOOJLB(GameObject GODEJCKEDNP, RigidbodyEx PIMMFKOLJPK, MHFODEJJPLD BENNAIJLPHL, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6F4FBB0", Offset = "0x6F4EFB0", VA = "0x186F4FBB0", Slot = "136")]
	protected virtual void ONMENDCBCMB(MHFODEJJPLD BENNAIJLPHL, MOGMJHIJFHA LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C550", Offset = "0x6F4B950", VA = "0x186F4C550", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CB40", Offset = "0x6F4BF40", VA = "0x186F4CB40", Slot = "91")]
	public void EOHNLKEPLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AD90", Offset = "0x6F4A190", VA = "0x186F4AD90", Slot = "92")]
	public void LCJFNOPHCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D9B0", Offset = "0x6F4CDB0", VA = "0x186F4D9B0", Slot = "93")]
	public void GHNMMFOGAPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C960", Offset = "0x6F4BD60", VA = "0x186F4C960")]
	private void EGMEIPNOEJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AB00", Offset = "0x6F49F00", VA = "0x186F4AB00", Slot = "30")]
	public CCDJNBGDDDE AMIIIEPOKND(int AGAGKNBDCIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C740", Offset = "0x6F4BB40", VA = "0x186F4C740", Slot = "95")]
	public void ECNJEHIAHLH(CCDJNBGDDDE OBEEJPGJPFD, bool ONNBDPJFLCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C9E0", Offset = "0x6F4BDE0", VA = "0x186F4C9E0", Slot = "96")]
	public void EINHPDNHBDH(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EE00", Offset = "0x6F4E200", VA = "0x186F4EE00", Slot = "97")]
	public void JODBABFPOJC(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BA80", Offset = "0x6F4AE80", VA = "0x186F4BA80", Slot = "98")]
	public Vector3 CPGCPEJNDCI(Vector3 HBNBBIDAMOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6F50280", Offset = "0x6F4F680", VA = "0x186F50280", Slot = "99")]
	public Vector3 POEFOLGJGPE(Vector3 DFABCICEPAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AD90", Offset = "0x6F4A190", VA = "0x186F4AD90", Slot = "100")]
	public void APHEJDKJFPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F530", Offset = "0x6F4E930", VA = "0x186F4F530", Slot = "101")]
	public void MMOHKMCODIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F340", Offset = "0x6F4E740", VA = "0x186F4F340", Slot = "102")]
	public void MACGJECPGED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D790", Offset = "0x6F4CB90", VA = "0x186F4D790", Slot = "103")]
	public void GEHCJMBAPIF(Vector3 FPIOEGKPDHN, Vector3 BIIKFDLLGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D470", Offset = "0x6F4C870", VA = "0x186F4D470", Slot = "104")]
	public void FHCBDLFBBBN(Vector3 IIOAECOBFCF, Vector3 NAKIJOPFMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CC80", Offset = "0x6F4C080", VA = "0x186F4CC80", Slot = "105")]
	public void EPEBDIJNKGN(Vector3 JLHNNPABOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D560", Offset = "0x6F4C960", VA = "0x186F4D560", Slot = "106")]
	public void FJEHBHGJDME(AAHEMBGGCHJ PNJDOEEGGNC, Vector3 EMOBCJNELGO, float KLPBBMDHNKK, float KOJOBIBDCMN = 8f, float COFKNDPPEKN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F0B0", Offset = "0x6F4E4B0", VA = "0x186F4F0B0", Slot = "107")]
	public void LCPANJMIOMC(FLBJHNGHAGI GPAFAKKLCNE, Vector3 OEDPIGEECGA, float LPNMJGDPLAP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6F50010", Offset = "0x6F4F410", VA = "0x186F50010", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void PJKOPADLMJI(FLBJHNGHAGI GPAFAKKLCNE, Vector3 MGJIDJKDGAB, float ADKJPLGKKMF = 7f, float IFCJLPHCGOF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C230", Offset = "0x6F4B630", VA = "0x186F4C230", Slot = "109")]
	public Vector3 DJALDLIBFJF(Vector3 OBEEJPGJPFD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A730", Offset = "0x6F49B30", VA = "0x186F4A730", Slot = "110")]
	public Vector3 AJKINGNEMNJ(Vector3 OBEEJPGJPFD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E3F0", Offset = "0x6F4D7F0", VA = "0x186F4E3F0", Slot = "111")]
	public void IGJHPNEPEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C330", Offset = "0x6F4B730", VA = "0x186F4C330", Slot = "112")]
	public void DKIIHOFMDHI(CCDJNBGDDDE FBEDMBNBOFH, object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BF40", Offset = "0x6F4B340", VA = "0x186F4BF40", Slot = "113")]
	public void DHGALLADHIJ(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A650", Offset = "0x6F49A50", VA = "0x186F4A650", Slot = "61")]
	public void AGOJFIAFAAL((Quaternion rot, Vector3 moments) NABKBOELDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C910", Offset = "0x6F4BD10", VA = "0x186F4C910", Slot = "114")]
	public void EFOKCICDEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F50380", Offset = "0x6F4F780", VA = "0x186F50380", Slot = "115")]
	public void PONKNLICDLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D680", Offset = "0x6F4CA80", VA = "0x186F4D680", Slot = "116")]
	public void FPGOLMDLFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AE40", Offset = "0x6F4A240", VA = "0x186F4AE40", Slot = "117")]
	public bool BBNCMEPMHFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F5A0", Offset = "0x6F4E9A0", VA = "0x186F4F5A0", Slot = "94")]
	public void MPBOONPMKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AD40", Offset = "0x6F4A140", VA = "0x186F4AD40", Slot = "118")]
	public void APEINKEJOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C170", Offset = "0x6F4B570", VA = "0x186F4C170", Slot = "119")]
	public void DILLJPEBACK(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CA40", Offset = "0x6F4BE40", VA = "0x186F4CA40", Slot = "120")]
	public void EKGLHCHDIMC(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DBB0", Offset = "0x6F4CFB0", VA = "0x186F4DBB0", Slot = "121")]
	public void HKDHOKBGJGH(object IAIFDAAIBBN, bool CMADNBKCNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BCE0", Offset = "0x6F4B0E0", VA = "0x186F4BCE0", Slot = "122")]
	public void DGHNBFJHMEG(Vector3 CAGMGLLKHIL, Quaternion EGOOOFEFDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F700", Offset = "0x6F4EB00", VA = "0x186F4F700", Slot = "123")]
	public void NFKAHCLJDDM(Vector3 KCBBKKIJODF, Quaternion JDFPMPLMODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F4ADE0", Offset = "0x6F4A1E0", VA = "0x186F4ADE0", Slot = "124")]
	public bool BAHJHBKAFLK(float GJLNPLOFFPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F4FF50", Offset = "0x6F4F350", VA = "0x186F4FF50", Slot = "125")]
	public void PHDHIAGBGBI(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C680", Offset = "0x6F4BA80", VA = "0x186F4C680", Slot = "126")]
	public void EAFAOEFOEIF(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B350", Offset = "0x6F4A750", VA = "0x186F4B350", Slot = "127")]
	public void CDFJLCNHLAH(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C6E0", Offset = "0x6F4BAE0", VA = "0x186F4C6E0", Slot = "128")]
	public void ECABBGKKPGG(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B740", Offset = "0x6F4AB40", VA = "0x186F4B740", Slot = "129")]
	public void CMCBPIBKMNK(Vector3 MCCPONPGBFK, ForceMode ELJCKLEHNDE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C7B0", Offset = "0x6F4BBB0", VA = "0x186F4C7B0", Slot = "130")]
	public void EDEKJELHBDP(Vector3 MCCPONPGBFK, Vector3 HBGADHMDPAD, ForceMode ELJCKLEHNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BC00", Offset = "0x6F4B000", VA = "0x186F4BC00", Slot = "131")]
	public void DDAJJMPKDFJ(Vector3 NCIODGEKLOH, ForceMode ELJCKLEHNDE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F501A0", Offset = "0x6F4F5A0", VA = "0x186F501A0", Slot = "132")]
	public void PNNACAJMBFM(Vector3 NCIODGEKLOH, ForceMode ELJCKLEHNDE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E130", Offset = "0x6F4D530", VA = "0x186F4E130", Slot = "133")]
	public bool HNOFHCBDPOD(Vector3 EOKIIKENLCD, [Out] RaycastHit EENPCFCEILM, float LDGBFHOOAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F200", Offset = "0x6F4E600", VA = "0x186F4F200", Slot = "134")]
	public void LLDKFMDONLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F503D0", Offset = "0x6F4F7D0", VA = "0x186F503D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E960", Offset = "0x6F4DD60", VA = "0x186F4E960")]
	private void IPPNDMNADOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AB80", Offset = "0x6F49F80", VA = "0x186F4AB80")]
	private void AMMAKEEPPHC(CCDJNBGDDDE KOBAADDGPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A830", Offset = "0x6F49C30", VA = "0x186F4A830")]
	private void AKGOLOAIDBI(CCDJNBGDDDE KOBAADDGPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EF00", Offset = "0x6F4E300", VA = "0x186F4EF00")]
	private void KFFIMHGIALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DC20", Offset = "0x6F4D020", VA = "0x186F4DC20")]
	private void HKHKMKCJDBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BFA0", Offset = "0x6F4B3A0", VA = "0x186F4BFA0")]
	private void DHNJOAJGCBP(CCDJNBGDDDE CHHECICKGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B410", Offset = "0x6F4A810", VA = "0x186F4B410")]
	private void CELHADHHPMJ(CCDJNBGDDDE KOBAADDGPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F4EAA0", Offset = "0x6F4DEA0", VA = "0x186F4EAA0")]
	private void JDLGABBFNFF(CCDJNBGDDDE KOBAADDGPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E230", Offset = "0x6F4D630", VA = "0x186F4E230")]
	private void IEDDKKAAOIN(DMMCHBJDPCN KOBAADDGPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DD70", Offset = "0x6F4D170", VA = "0x186F4DD70", Slot = "141")]
	protected virtual void HNLDOJGIMOD(DMMCHBJDPCN CNGOHFHGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CEF0", Offset = "0x6F4C2F0", VA = "0x186F4CEF0")]
	protected void FECKCIEGFMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E4E0", Offset = "0x6F4D8E0", VA = "0x186F4E4E0")]
	protected void IILNDGFPKLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D8F0", Offset = "0x6F4CCF0", VA = "0x186F4D8F0", Slot = "142")]
	protected virtual IDisposable GFGNDHIFMHH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class JMKEEHGECKG
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D9A0", Offset = "0x6F3CDA0", VA = "0x186F3D9A0")]
	public static CCDJNBGDDDE KBOBONELCEI(this CCDJNBGDDDE CNGOHFHGBJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D8A0", Offset = "0x6F3CCA0", VA = "0x186F3D8A0")]
	public static bool ILPOOBEGPON(this CCDJNBGDDDE CNGOHFHGBJN, CCDJNBGDDDE OBIBGJDAAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D7D0", Offset = "0x6F3CBD0", VA = "0x186F3D7D0")]
	public static bool CAELNHDBKLP(this CCDJNBGDDDE CNGOHFHGBJN, CCDJNBGDDDE PNFONMNLJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D850", Offset = "0x6F3CC50", VA = "0x186F3D850")]
	public static DMMCHBJDPCN HILHJDLPIHN(this CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D920", Offset = "0x6F3CD20", VA = "0x186F3D920")]
	public static PGANAEOOJLB JIBIIMCKAJL(this CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LBGJLPJMNAJ : FMABOFKJJKO
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F3FEE0", Offset = "0x6F3F2E0", VA = "0x186F3FEE0", Slot = "19")]
	public CCDJNBGDDDE AEBLEKKDDII(RigidbodyEx CNGOHFHGBJN, MOGMJHIJFHA LDNEPNAGEGN, MHFODEJJPLD BENNAIJLPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "4")]
	public AMBJIFNMLIM JEHDKNNCAFO(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "5")]
	public NDMONJOFEPH ADADJKNDPAH(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "6")]
	public FPOBIJMEOJK ELCNKJIBMDC(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "7")]
	public IPFNIOPBPHB PPCAEJHBABA(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "8")]
	public NJCPPIKPDOE EEFOIACPEIG(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "9")]
	public MJEJHLBBCJG EBKJHODGEJF(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "10")]
	public LEHHMIHENFC BGGLFPNICCC(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "11")]
	public CNCFFBJBEKH MOLLBCMPLLP(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "12")]
	public DBDJCPOJEEH ELKDIDHEBOI(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "13")]
	public GDDLCFKBAIN KNFFLNLMAOB(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230")]
	public NFDFLOGLJJG KDDLGNMABNM(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230")]
	public NFKOLADOAEF HFMJHOLDJLB(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230")]
	public PEMACMFJPOC BBLJCEOLIJO(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230")]
	public KPCONFPCDMB OPHNOOLJMPE(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230")]
	public BHMHJPFICDO EJMPNNMLMNP(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public LBGJLPJMNAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "14")]
	private NFDFLOGLJJG MBGOIODGKAG(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "15")]
	private NFKOLADOAEF ILIIOAFAFHP(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "16")]
	private PEMACMFJPOC LEPOKKEHKPO(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "17")]
	private KPCONFPCDMB GCCANLECPID(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "18")]
	private BHMHJPFICDO GDCMKACFEIL(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[EFCEPDIPLEI(typeof(FMABOFKJJKO), new string[] { })]
public class MELBPOLLPGG : FMABOFKJJKO, HGLPGAMBODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly FMABOFKJJKO GCPPNFAPBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly FMABOFKJJKO ALLOLJJNPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MKKHJLBCCIL GGNPHHPCMKD;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private FMABOFKJJKO JIOIKLLILMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6F41060", Offset = "0x6F40460", VA = "0x186F41060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6F41550", Offset = "0x6F40950", VA = "0x186F41550", Slot = "20")]
	public void InitReferences(EGOJPPMNMDN AGFGGBNBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6F415A0", Offset = "0x6F409A0", VA = "0x186F415A0", Slot = "4")]
	public AMBJIFNMLIM JEHDKNNCAFO(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6F40D90", Offset = "0x6F40190", VA = "0x186F40D90", Slot = "5")]
	public NDMONJOFEPH ADADJKNDPAH(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6F412B0", Offset = "0x6F406B0", VA = "0x186F412B0", Slot = "6")]
	public FPOBIJMEOJK ELCNKJIBMDC(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6F41830", Offset = "0x6F40C30", VA = "0x186F41830", Slot = "7")]
	public IPFNIOPBPHB PPCAEJHBABA(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6F41160", Offset = "0x6F40560", VA = "0x186F41160", Slot = "8")]
	public NJCPPIKPDOE EEFOIACPEIG(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6F410C0", Offset = "0x6F404C0", VA = "0x186F410C0", Slot = "9")]
	public MJEJHLBBCJG EBKJHODGEJF(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6F40FC0", Offset = "0x6F403C0", VA = "0x186F40FC0", Slot = "10")]
	public LEHHMIHENFC BGGLFPNICCC(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6F41790", Offset = "0x6F40B90", VA = "0x186F41790", Slot = "11")]
	public CNCFFBJBEKH MOLLBCMPLLP(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6F41350", Offset = "0x6F40750", VA = "0x186F41350", Slot = "12")]
	public DBDJCPOJEEH ELKDIDHEBOI(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6F416F0", Offset = "0x6F40AF0", VA = "0x186F416F0", Slot = "13")]
	public GDDLCFKBAIN KNFFLNLMAOB(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6F41640", Offset = "0x6F40A40", VA = "0x186F41640")]
	public NFDFLOGLJJG KDDLGNMABNM(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6F414A0", Offset = "0x6F408A0", VA = "0x186F414A0")]
	public NFKOLADOAEF HFMJHOLDJLB(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6F40F10", Offset = "0x6F40310", VA = "0x186F40F10")]
	public PEMACMFJPOC BBLJCEOLIJO(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F413F0", Offset = "0x6F407F0", VA = "0x186F413F0")]
	public KPCONFPCDMB OPHNOOLJMPE(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F41200", Offset = "0x6F40600", VA = "0x186F41200")]
	public BHMHJPFICDO EJMPNNMLMNP(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6F40E30", Offset = "0x6F40230", VA = "0x186F40E30", Slot = "19")]
	public CCDJNBGDDDE AEBLEKKDDII(RigidbodyEx CNGOHFHGBJN, MOGMJHIJFHA LDNEPNAGEGN, MHFODEJJPLD BENNAIJLPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6F418D0", Offset = "0x6F40CD0", VA = "0x186F418D0")]
	public MELBPOLLPGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6F41640", Offset = "0x6F40A40", VA = "0x186F41640", Slot = "14")]
	private NFDFLOGLJJG MBGOIODGKAG(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6F414A0", Offset = "0x6F408A0", VA = "0x186F414A0", Slot = "15")]
	private NFKOLADOAEF ILIIOAFAFHP(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6F40F10", Offset = "0x6F40310", VA = "0x186F40F10", Slot = "16")]
	private PEMACMFJPOC LEPOKKEHKPO(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6F413F0", Offset = "0x6F407F0", VA = "0x186F413F0", Slot = "17")]
	private KPCONFPCDMB GCCANLECPID(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6F41200", Offset = "0x6F40600", VA = "0x186F41200", Slot = "18")]
	private BHMHJPFICDO GDCMKACFEIL(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EGLKPLDMBPB : AMBJIFNMLIM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFOLEMCNFJG(CCDJNBGDDDE CNGOHFHGBJN);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILCJAIJOOJG(CCDJNBGDDDE CNGOHFHGBJN);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MEPLNBJPLLF(CCDJNBGDDDE CHHECICKGJD);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LPFCCPDMBBA(CCDJNBGDDDE CHHECICKGJD);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DJFAEMONMNA : FPOBIJMEOJK
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	PAFBECGKDIG<CCDJNBGDDDE> AJJJFINEFFM
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	CCDJNBGDDDE EECLFHLJHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AJFPHFMBKOF : KPCONFPCDMB
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) JGPEODJLLLE(Rigidbody DNAGJJLODOA);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface EFNCEDMHEAM : NFKOLADOAEF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView CLDFPKMEELB
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class KABNLLBHLDO : DBDJCPOJEEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly PGANAEOOJLB CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode GIODENNLDLI;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody MLNLGAAEPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6F3B3D0", Offset = "0x6F3A7D0", VA = "0x186F3B3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode JHDFCCCMAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6F3DA70", Offset = "0x6F3CE70", VA = "0x186F3DA70", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6F3DC90", Offset = "0x6F3D090", VA = "0x186F3DC90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BC50", Offset = "0x6F3B050", VA = "0x186F3BC50")]
	public KABNLLBHLDO(CCDJNBGDDDE CNGOHFHGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DB80", Offset = "0x6F3CF80", VA = "0x186F3DB80", Slot = "6")]
	public void EOHNLKEPLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DF90", Offset = "0x6F3D390", VA = "0x186F3DF90", Slot = "9")]
	public void PLFJKHPOFKB(Rigidbody DCMLHPJLAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DD00", Offset = "0x6F3D100", VA = "0x186F3DD00", Slot = "7")]
	public void GMIIAEEPHMI(bool CMPKFIGHGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DA60", Offset = "0x6F3CE60", VA = "0x186F3DA60", Slot = "8")]
	public void CFODBIHOFAM(bool CMPKFIGHGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DD10", Offset = "0x6F3D110", VA = "0x186F3DD10", Slot = "10")]
	public bool HNOFHCBDPOD(Vector3 EOKIIKENLCD, [Out] RaycastHit EENPCFCEILM, float LDGBFHOOAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DE70", Offset = "0x6F3D270", VA = "0x186F3DE70")]
	private void NHLDLMPDODO(bool CMPKFIGHGBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NLNBLANHCGL : MJEJHLBBCJG, IDisposable, KPLOEMKEKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly PGANAEOOJLB CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private BCGHGEBOGGJ MPPOKNPKPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private LLLKKOLPLLJ JMHIOJNHGCO;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public BCGHGEBOGGJ KHHHEGHLHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6F43E40", Offset = "0x6F43240", VA = "0x186F43E40", Slot = "6")]
		get
		{
			return default(BCGHGEBOGGJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6F43CC0", Offset = "0x6F430C0", VA = "0x186F43CC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform ACDNGCDHFGA
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6F44310", Offset = "0x6F43710", VA = "0x186F44310", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<DHNIPGENADJ, DHNIPGENADJ> IIICKDLOGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6F43D90", Offset = "0x6F43190", VA = "0x186F43D90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6F44260", Offset = "0x6F43660", VA = "0x186F44260", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6F44330", Offset = "0x6F43730", VA = "0x186F44330")]
	public NLNBLANHCGL(CCDJNBGDDDE CNGOHFHGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6F43FE0", Offset = "0x6F433E0", VA = "0x186F43FE0", Slot = "8")]
	public void EOHNLKEPLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6F43F90", Offset = "0x6F43390", VA = "0x186F43F90", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xA44060", Offset = "0xA43460", VA = "0x180A44060", Slot = "11")]
	private void GAJJFPIIJEN(DHNIPGENADJ BBABLGEFKBA, DHNIPGENADJ FEKCAFDBIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "12")]
	private void CMJPBGOLGEB(bool NBKOGIEJDBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MFGIMAADEND : FMABOFKJJKO
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6F425C0", Offset = "0x6F419C0", VA = "0x186F425C0", Slot = "4")]
	public AMBJIFNMLIM JEHDKNNCAFO(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6F41980", Offset = "0x6F40D80", VA = "0x186F41980", Slot = "5")]
	public NDMONJOFEPH ADADJKNDPAH(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6F420A0", Offset = "0x6F414A0", VA = "0x186F420A0", Slot = "6")]
	public FPOBIJMEOJK ELCNKJIBMDC(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6F42970", Offset = "0x6F41D70", VA = "0x186F42970", Slot = "7")]
	public IPFNIOPBPHB PPCAEJHBABA(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6F41EF0", Offset = "0x6F412F0", VA = "0x186F41EF0", Slot = "8")]
	public NJCPPIKPDOE EEFOIACPEIG(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6F41E20", Offset = "0x6F41220", VA = "0x186F41E20", Slot = "9")]
	public MJEJHLBBCJG EBKJHODGEJF(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6F41D00", Offset = "0x6F41100", VA = "0x186F41D00", Slot = "10")]
	public LEHHMIHENFC BGGLFPNICCC(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6F428B0", Offset = "0x6F41CB0", VA = "0x186F428B0", Slot = "11")]
	public CNCFFBJBEKH MOLLBCMPLLP(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6F421D0", Offset = "0x6F415D0", VA = "0x186F421D0", Slot = "12")]
	public DBDJCPOJEEH ELKDIDHEBOI(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6F427F0", Offset = "0x6F41BF0", VA = "0x186F427F0", Slot = "13")]
	public GDDLCFKBAIN KNFFLNLMAOB(CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6F426B0", Offset = "0x6F41AB0", VA = "0x186F426B0")]
	public NFDFLOGLJJG KDDLGNMABNM(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6F42430", Offset = "0x6F41830", VA = "0x186F42430")]
	public NFKOLADOAEF HFMJHOLDJLB(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6F41BD0", Offset = "0x6F40FD0", VA = "0x186F41BD0")]
	public PEMACMFJPOC BBLJCEOLIJO(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6F42290", Offset = "0x6F41690", VA = "0x186F42290")]
	public KPCONFPCDMB OPHNOOLJMPE(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6F41FC0", Offset = "0x6F413C0", VA = "0x186F41FC0")]
	public BHMHJPFICDO EJMPNNMLMNP(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6F41AB0", Offset = "0x6F40EB0", VA = "0x186F41AB0", Slot = "19")]
	public CCDJNBGDDDE AEBLEKKDDII(RigidbodyEx CNGOHFHGBJN, MOGMJHIJFHA LDNEPNAGEGN, MHFODEJJPLD BENNAIJLPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public MFGIMAADEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6F426B0", Offset = "0x6F41AB0", VA = "0x186F426B0", Slot = "14")]
	private NFDFLOGLJJG MBGOIODGKAG(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6F42430", Offset = "0x6F41830", VA = "0x186F42430", Slot = "15")]
	private NFKOLADOAEF ILIIOAFAFHP(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6F41BD0", Offset = "0x6F40FD0", VA = "0x186F41BD0", Slot = "16")]
	private PEMACMFJPOC LEPOKKEHKPO(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6F42290", Offset = "0x6F41690", VA = "0x186F42290", Slot = "17")]
	private KPCONFPCDMB GCCANLECPID(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6F41FC0", Offset = "0x6F413C0", VA = "0x186F41FC0", Slot = "18")]
	private BHMHJPFICDO GDCMKACFEIL(CCDJNBGDDDE DJKNDPHDPMJ, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class AJECCBAMOPK : CNCFFBJBEKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly PGANAEOOJLB CNGOHFHGBJN;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody MLNLGAAEPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6F3B3D0", Offset = "0x6F3A7D0", VA = "0x186F3B3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool IHGNCMOLCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6F3B6E0", Offset = "0x6F3AAE0", VA = "0x186F3B6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool LAAKKNFBEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6F3B680", Offset = "0x6F3AA80", VA = "0x186F3B680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private CCDJNBGDDDE EOCBFDAOCJD
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6F3B730", Offset = "0x6F3AB30", VA = "0x186F3B730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BC50", Offset = "0x6F3B050", VA = "0x186F3BC50")]
	public AJECCBAMOPK(CCDJNBGDDDE CNGOHFHGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AE90", Offset = "0x6F3A290", VA = "0x186F3AE90", Slot = "4")]
	public void CMCBPIBKMNK(Vector3 MCCPONPGBFK, ForceMode ELJCKLEHNDE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B790", Offset = "0x6F3AB90", VA = "0x186F3B790")]
	private void OBOIHKMNPNN(Vector3 MCCPONPGBFK, ForceMode ELJCKLEHNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B150", Offset = "0x6F3A550", VA = "0x186F3B150", Slot = "5")]
	public void EDEKJELHBDP(Vector3 MCCPONPGBFK, Vector3 HBGADHMDPAD, ForceMode ELJCKLEHNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AFF0", Offset = "0x6F3A3F0", VA = "0x186F3AFF0", Slot = "6")]
	public void DDAJJMPKDFJ(Vector3 NCIODGEKLOH, ForceMode ELJCKLEHNDE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B420", Offset = "0x6F3A820", VA = "0x186F3B420")]
	private void JHDDMHLGLOK(Vector3 NCIODGEKLOH, ForceMode ELJCKLEHNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B9F0", Offset = "0x6F3ADF0", VA = "0x186F3B9F0", Slot = "7")]
	public void PNNACAJMBFM(Vector3 NCIODGEKLOH, ForceMode ELJCKLEHNDE = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class FOIIOOKMMLH : GDDLCFKBAIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly PGANAEOOJLB CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool DCOKKEIAOOK;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool AKDNFEKFHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x95D500", Offset = "0x95C900", VA = "0x18095D500", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6F3D290", Offset = "0x6F3C690", VA = "0x186F3D290", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BC50", Offset = "0x6F3B050", VA = "0x186F3BC50")]
	public FOIIOOKMMLH(CCDJNBGDDDE CNGOHFHGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D410", Offset = "0x6F3C810", VA = "0x186F3D410", Slot = "6")]
	public void PLFJKHPOFKB(Rigidbody DCMLHPJLAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D3A0", Offset = "0x6F3C7A0", VA = "0x186F3D3A0", Slot = "7")]
	public void CDGKKKCFKDO(Rigidbody DCMLHPJLAOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class KAHOOMMLCDD : EGLKPLDMBPB, AMBJIFNMLIM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly CCDJNBGDDDE CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<CCDJNBGDDDE> HNPALNOCLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private CCDJNBGDDDE MILPLABKJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private CCDJNBGDDDE KOBAADDGPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform GOJKOPOEGKG;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform PEDBLOEBMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F970", Offset = "0x6F3ED70", VA = "0x186F3F970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public CCDJNBGDDDE EOCBFDAOCJD
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x850810", Offset = "0x84FC10", VA = "0x180850810", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F010", Offset = "0x6F3E410", VA = "0x186F3F010", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public CCDJNBGDDDE JIDLAENMFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x850780", Offset = "0x84FB80", VA = "0x180850780", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<CCDJNBGDDDE> AOHANOFFJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8507D0", Offset = "0x84FBD0", VA = "0x1808507D0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event ADPKLNACACP KEBHKJEAMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F8D0", Offset = "0x6F3ECD0", VA = "0x186F3F8D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6F3FCE0", Offset = "0x6F3F0E0", VA = "0x186F3FCE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event ADPKLNACACP CLHCIGIJGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F150", Offset = "0x6F3E550", VA = "0x186F3F150", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6F3E360", Offset = "0x6F3D760", VA = "0x186F3E360", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event NHDOEHJFCKK KNGCIADPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F5C0", Offset = "0x6F3E9C0", VA = "0x186F3F5C0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6F3ECD0", Offset = "0x6F3E0D0", VA = "0x186F3ECD0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action JPIKAOHNLOO
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6F3E010", Offset = "0x6F3D410", VA = "0x186F3E010", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6F3EED0", Offset = "0x6F3E2D0", VA = "0x186F3EED0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action JGGBONBLOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6F3E4C0", Offset = "0x6F3D8C0", VA = "0x186F3E4C0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6F3FB30", Offset = "0x6F3EF30", VA = "0x186F3FB30", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<CCDJNBGDDDE> GONLKOAJNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6F3EB80", Offset = "0x6F3DF80", VA = "0x186F3EB80", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F9D0", Offset = "0x6F3EDD0", VA = "0x186F3F9D0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<CCDJNBGDDDE> ONGJMFDLGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6F3ED70", Offset = "0x6F3E170", VA = "0x186F3ED70", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F290", Offset = "0x6F3E690", VA = "0x186F3F290", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action JHFNPGABABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6F3FD80", Offset = "0x6F3F180", VA = "0x186F3FD80", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F1F0", Offset = "0x6F3E5F0", VA = "0x186F3F1F0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<CCDJNBGDDDE> NANOBNEGFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6F3FA80", Offset = "0x6F3EE80", VA = "0x186F3FA80", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6F3EE20", Offset = "0x6F3E220", VA = "0x186F3EE20", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x6F3FE20", Offset = "0x6F3F220", VA = "0x186F3FE20")]
	public KAHOOMMLCDD(CCDJNBGDDDE CNGOHFHGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E560", Offset = "0x6F3D960", VA = "0x186F3E560", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E600", Offset = "0x6F3DA00", VA = "0x186F3E600", Slot = "30")]
	public void ECNJEHIAHLH(CCDJNBGDDDE DADNCNLHDCH, bool ONNBDPJFLCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F660", Offset = "0x6F3EA60", VA = "0x186F3F660", Slot = "6")]
	public void MEPLNBJPLLF(CCDJNBGDDDE CHHECICKGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F340", Offset = "0x6F3E740", VA = "0x186F3F340", Slot = "7")]
	public void LPFCCPDMBBA(CCDJNBGDDDE CHHECICKGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6F3FBD0", Offset = "0x6F3EFD0", VA = "0x186F3FBD0", Slot = "4")]
	public void PFOLEMCNFJG(CCDJNBGDDDE CNGOHFHGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6F3EF70", Offset = "0x6F3E370", VA = "0x186F3EF70", Slot = "5")]
	public void ILCJAIJOOJG(CCDJNBGDDDE CNGOHFHGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6F3EC30", Offset = "0x6F3E030", VA = "0x186F3EC30")]
	private void FJANMJEHOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E0B0", Offset = "0x6F3D4B0", VA = "0x186F3E0B0")]
	private void AOKCBIGEGKB(CCDJNBGDDDE CHHECICKGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E220", Offset = "0x6F3D620", VA = "0x186F3E220")]
	private void CNONJDKCFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E0F0", Offset = "0x6F3D4F0", VA = "0x186F3E0F0")]
	private void CMDNCHJJFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F020", Offset = "0x6F3E420", VA = "0x186F3F020")]
	private void JANKFBKIHND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E400", Offset = "0x6F3D800", VA = "0x186F3E400")]
	[CompilerGenerated]
	private object DJHMAOCGFEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class NGCIIJECNGM
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6F43C00", Offset = "0x6F43000", VA = "0x186F43C00")]
	public static EGLKPLDMBPB MMKBMIIAAIB(this CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class LKJNINBCPPL : DJFAEMONMNA, FPOBIJMEOJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly PGANAEOOJLB CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PAFBECGKDIG<CCDJNBGDDDE> NFLAOAPKFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool DLLBPHOMHOC;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public PAFBECGKDIG<CCDJNBGDDDE> AJJJFINEFFM
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 JNAEFCNFMGG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6F40040", Offset = "0x6F3F440", VA = "0x186F40040", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 IFFOPIHEHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6F40A00", Offset = "0x6F3FE00", VA = "0x186F40A00", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 KBKBJDBMDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6F40910", Offset = "0x6F3FD10", VA = "0x186F40910")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public CCDJNBGDDDE EECLFHLJHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6F40460", Offset = "0x6F3F860", VA = "0x186F40460", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6F40BC0", Offset = "0x6F3FFC0", VA = "0x186F40BC0")]
	public LKJNINBCPPL(CCDJNBGDDDE CNGOHFHGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6F408A0", Offset = "0x6F3FCA0", VA = "0x186F408A0", Slot = "8")]
	public void LCCBCHBIOKI(CCDJNBGDDDE KOBAADDGPBN, object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6F40400", Offset = "0x6F3F800", VA = "0x186F40400", Slot = "9")]
	public void GLFFAOJHKEI(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F40510", Offset = "0x6F3F910", VA = "0x186F40510")]
	private Vector3 KBLCKICKOGL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6F40070", Offset = "0x6F3F470", VA = "0x186F40070")]
	private void FEIGOBHLHKI(CCDJNBGDDDE KMGHFIEIGKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class JDGKKNNLPIF
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D710", Offset = "0x6F3CB10", VA = "0x186F3D710")]
	public static DJFAEMONMNA PCAIJIBBMBP(this CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class NNMGBJDFILJ : AJFPHFMBKOF, KPCONFPCDMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly PGANAEOOJLB CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 FAHDLLIHNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 GKHBMGGLAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float DNIBKKDLNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float EJJKGLMJAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 DFLCIKLKBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? MGJBBOCIDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? CMEMFGLEONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool PPBCLEBJAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool PNOAKGHFGAE;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 KCKPPPFOFGL
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xE42630", Offset = "0xE41A30", VA = "0x180E42630", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6F44A00", Offset = "0x6F43E00", VA = "0x186F44A00", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 IOAEGOHIJIL
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6F45160", Offset = "0x6F44560", VA = "0x186F45160", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float AODHLGOPLFD
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x95D530", Offset = "0x95C930", VA = "0x18095D530", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6F44AB0", Offset = "0x6F43EB0", VA = "0x186F44AB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float IMBJJLGMFOE
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x95D520", Offset = "0x95C920", VA = "0x18095D520", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F44D70", Offset = "0x6F44170", VA = "0x186F44D70", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 KLPANANJHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F44E20", Offset = "0x6F44220", VA = "0x186F44E20", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion PNBNFKGNIDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F44690", Offset = "0x6F43A90", VA = "0x186F44690", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody MLNLGAAEPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F45260", Offset = "0x6F44660", VA = "0x186F45260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event ADPKLNACACP MMOCGHHNIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6F466C0", Offset = "0x6F45AC0", VA = "0x186F466C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6F445F0", Offset = "0x6F439F0", VA = "0x186F445F0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F46C40", Offset = "0x6F46040", VA = "0x186F46C40")]
	public NNMGBJDFILJ(CCDJNBGDDDE CNGOHFHGBJN, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F44BC0", Offset = "0x6F43FC0", VA = "0x186F44BC0", Slot = "17")]
	public void EFOKCICDEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F46B60", Offset = "0x6F45F60", VA = "0x186F46B60", Slot = "16")]
	public void PONKNLICDLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F46A80", Offset = "0x6F45E80", VA = "0x186F46A80", Slot = "19")]
	public void PLFJKHPOFKB(Rigidbody DCMLHPJLAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F44810", Offset = "0x6F43C10", VA = "0x186F44810", Slot = "20")]
	public void CDGKKKCFKDO(Rigidbody DCMLHPJLAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F44FB0", Offset = "0x6F443B0", VA = "0x186F44FB0", Slot = "18")]
	public void FPGOLMDLFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F46220", Offset = "0x6F45620", VA = "0x186F46220", Slot = "21")]
	public void LLDKFMDONLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F44A00", Offset = "0x6F43E00", VA = "0x186F44A00")]
	private void CGGIONAFPNF(Vector3 OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F452B0", Offset = "0x6F446B0", VA = "0x186F452B0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 JEMDEEPIJKM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F44AB0", Offset = "0x6F43EB0", VA = "0x186F44AB0")]
	private void DCOOLAMAFIE(float OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F44D70", Offset = "0x6F44170", VA = "0x186F44D70")]
	private void GEECOJGNLBJ(float OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F468E0", Offset = "0x6F45CE0", VA = "0x186F468E0")]
	private Vector3 PJEKDCPBIKJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F443C0", Offset = "0x6F437C0", VA = "0x186F443C0", Slot = "15")]
	public void AGOJFIAFAAL((Quaternion rot, Vector3 moments) NABKBOELDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F46760", Offset = "0x6F45B60", VA = "0x186F46760")]
	private Quaternion NIJGMKEGPOL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F453A0", Offset = "0x6F447A0", VA = "0x186F453A0")]
	public void JGPEODJLLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F45470", Offset = "0x6F44870", VA = "0x186F45470", Slot = "4")]
	public (float, Vector3) JGPEODJLLLE(Rigidbody DNAGJJLODOA)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class ALLDFELIFEE
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BCE0", Offset = "0x6F3B0E0", VA = "0x186F3BCE0")]
	public static AJFPHFMBKOF GIONAFEJAHM(this CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class NFNGENAEJIG : PEMACMFJPOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly PGANAEOOJLB CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly HGDIPJDAGFM CMFEFHFNHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly DJAFCNJDKGP HIGJKJJEENF;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool MCIHCJDOFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xFF43E0", Offset = "0xFF37E0", VA = "0x180FF43E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public DJAFCNJDKGP JFNMPEKEIJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9874E0", Offset = "0x9868E0", VA = "0x1809874E0", Slot = "11")]
		get
		{
			return default(DJAFCNJDKGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F43B00", Offset = "0x6F42F00", VA = "0x186F43B00")]
	public NFNGENAEJIG(CCDJNBGDDDE CNGOHFHGBJN, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F436E0", Offset = "0x6F42AE0", VA = "0x186F436E0", Slot = "4")]
	public void EOHNLKEPLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F43520", Offset = "0x6F42920", VA = "0x186F43520")]
	private bool DEMOMPOAJDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F437B0", Offset = "0x6F42BB0", VA = "0x186F437B0", Slot = "5")]
	public void GIAAPDCHOOD(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F43820", Offset = "0x6F42C20", VA = "0x186F43820", Slot = "6")]
	public void JPCBJBPBPLB(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F43850", Offset = "0x6F42C50", VA = "0x186F43850", Slot = "9")]
	public void NCICBJMEJOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F435C0", Offset = "0x6F429C0", VA = "0x186F435C0")]
	private void ECDBCHHODOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F43990", Offset = "0x6F42D90", VA = "0x186F43990")]
	private void OOJDKDDPKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F434E0", Offset = "0x6F428E0", VA = "0x186F434E0", Slot = "8")]
	public void AGBCPNHECAM(CCDJNBGDDDE CNGOHFHGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F437E0", Offset = "0x6F42BE0", VA = "0x186F437E0", Slot = "7")]
	public void JGEIJNCHMNI(CCDJNBGDDDE CNGOHFHGBJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class ENLAMKIOJKL : LEHHMIHENFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly PGANAEOOJLB CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly HGDIPJDAGFM GOALEHJGBEG;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool IHGNCMOLCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F3CFA0", Offset = "0x6F3C3A0", VA = "0x186F3CFA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event ADPKLNACACP BOOAACEFJCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F3CD10", Offset = "0x6F3C110", VA = "0x186F3CD10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F3CEC0", Offset = "0x6F3C2C0", VA = "0x186F3CEC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D0D0", Offset = "0x6F3C4D0", VA = "0x186F3D0D0")]
	public ENLAMKIOJKL(CCDJNBGDDDE CNGOHFHGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F3CCF0", Offset = "0x6F3C0F0", VA = "0x186F3CCF0", Slot = "7")]
	public void DILLJPEBACK(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F3CD00", Offset = "0x6F3C100", VA = "0x186F3CD00", Slot = "8")]
	public void EKGLHCHDIMC(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F3CDB0", Offset = "0x6F3C1B0", VA = "0x186F3CDB0", Slot = "9")]
	public void HKDHOKBGJGH(object IAIFDAAIBBN, bool CMADNBKCNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F3CF60", Offset = "0x6F3C360", VA = "0x186F3CF60", Slot = "12")]
	public void LLNNNDMFMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D050", Offset = "0x6F3C450", VA = "0x186F3D050", Slot = "10")]
	public void PLFJKHPOFKB(Rigidbody LMOGFGDEOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F3CCC0", Offset = "0x6F3C0C0", VA = "0x186F3CCC0", Slot = "11")]
	public void CDGKKKCFKDO(Rigidbody DCMLHPJLAOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class DIDCGDGNFKJ : EFNCEDMHEAM, NFKOLADOAEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PGANAEOOJLB CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView DCLGFIMBBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool BPHGDJNJCOH;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView CLDFPKMEELB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool GCOOADPCENM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C3C0", Offset = "0x6F3B7C0", VA = "0x186F3C3C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool NHECKGLEIGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xB41E20", Offset = "0xB41220", VA = "0x180B41E20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event ADPKLNACACP FECDFNNGMEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C320", Offset = "0x6F3B720", VA = "0x186F3C320", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C130", Offset = "0x6F3B530", VA = "0x186F3C130", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F3CB60", Offset = "0x6F3BF60", VA = "0x186F3CB60")]
	public DIDCGDGNFKJ(CCDJNBGDDDE CNGOHFHGBJN, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C4E0", Offset = "0x6F3B8E0", VA = "0x186F3C4E0", Slot = "9")]
	public void EOHNLKEPLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C3E0", Offset = "0x6F3B7E0", VA = "0x186F3C3E0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BFC0", Offset = "0x6F3B3C0", VA = "0x186F3BFC0", Slot = "10")]
	public void CELHADHHPMJ(CCDJNBGDDDE KOBAADDGPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C9F0", Offset = "0x6F3BDF0", VA = "0x186F3C9F0", Slot = "11")]
	public void JDLGABBFNFF(CCDJNBGDDDE KOBAADDGPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C880", Offset = "0x6F3BC80", VA = "0x186F3C880")]
	private void HINAPAAFKFH(PhotonView KAFLABNHAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C1D0", Offset = "0x6F3B5D0", VA = "0x186F3C1D0")]
	private void CKCLAHKEGIP(DMMCHBJDPCN KCFMIODDHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C610", Offset = "0x6F3BA10", VA = "0x186F3C610")]
	private void GEDJLLHFLMJ(PhotonView MIICHLCAIDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class LCNKHAAJHDO
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F3FF80", Offset = "0x6F3F380", VA = "0x186F3FF80")]
	public static EFNCEDMHEAM OJCIKDBNNCM(this CCDJNBGDDDE DJKNDPHDPMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class MMECLIDEJIP : BHMHJPFICDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly PGANAEOOJLB CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints HNHIGMJKFJI;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool OCDFAMCJFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x95D470", Offset = "0x95C870", VA = "0x18095D470", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x44BFAE0", Offset = "0x44BEEE0", VA = "0x1844BFAE0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool FBDJFMIBLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x95D490", Offset = "0x95C890", VA = "0x18095D490", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x44BFAD0", Offset = "0x44BEED0", VA = "0x1844BFAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints NAHFNGGGPLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x850BF0", VA = "0x1808517F0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F42A20", Offset = "0x6F41E20", VA = "0x186F42A20", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F42B80", Offset = "0x6F41F80", VA = "0x186F42B80")]
	public MMECLIDEJIP(CCDJNBGDDDE CNGOHFHGBJN, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F42B50", Offset = "0x6F41F50", VA = "0x186F42B50", Slot = "9")]
	public void PLFJKHPOFKB(Rigidbody DCMLHPJLAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F429F0", Offset = "0x6F41DF0", VA = "0x186F429F0", Slot = "10")]
	public void CDGKKKCFKDO(Rigidbody DCMLHPJLAOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class ICALABPOJDN : IPFNIOPBPHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly CCDJNBGDDDE CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float CKOKLCCANIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float CMIDBFEELBA;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float BIKCECPLMOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x995C50", Offset = "0x995050", VA = "0x180995C50", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F3D5B0", Offset = "0x6F3C9B0", VA = "0x186F3D5B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float AFNKOIOCGOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x995C40", Offset = "0x995040", VA = "0x180995C40", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F3D4E0", Offset = "0x6F3C8E0", VA = "0x186F3D4E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D6D0", Offset = "0x6F3CAD0", VA = "0x186F3D6D0")]
	public ICALABPOJDN(CCDJNBGDDDE CNGOHFHGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D680", Offset = "0x6F3CA80", VA = "0x186F3D680", Slot = "8")]
	public void PLFJKHPOFKB(Rigidbody DCMLHPJLAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D440", Offset = "0x6F3C840", VA = "0x186F3D440", Slot = "9")]
	public void CDGKKKCFKDO(Rigidbody DCMLHPJLAOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class PHCMINMGPOH : NJCPPIKPDOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly PGANAEOOJLB CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool PACMPAANHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool GGPCLPGMAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int CFIFPOHMEMM;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody MLNLGAAEPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F45260", Offset = "0x6F44660", VA = "0x186F45260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool KPFMJCINAON
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F50DD0", Offset = "0x6F501D0", VA = "0x186F50DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private CCDJNBGDDDE EOCBFDAOCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F50EF0", Offset = "0x6F502F0", VA = "0x186F50EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool LAAKKNFBEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F50DF0", Offset = "0x6F501F0", VA = "0x186F50DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event ADPKLNACACP GFIOGCGHGEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F50B40", Offset = "0x6F4FF40", VA = "0x186F50B40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F50880", Offset = "0x6F4FC80", VA = "0x186F50880", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F50F50", Offset = "0x6F50350", VA = "0x186F50F50")]
	public PHCMINMGPOH(CCDJNBGDDDE CNGOHFHGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F50920", Offset = "0x6F4FD20", VA = "0x186F50920", Slot = "6")]
	public void EOHNLKEPLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F50BE0", Offset = "0x6F4FFE0", VA = "0x186F50BE0", Slot = "8")]
	public void IMGGEELGDDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F50580", Offset = "0x6F4F980", VA = "0x186F50580", Slot = "7")]
	public bool BBNCMEPMHFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F50E50", Offset = "0x6F50250", VA = "0x186F50E50", Slot = "9")]
	public void MPBOONPMKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F504E0", Offset = "0x6F4F8E0", VA = "0x186F504E0", Slot = "11")]
	public void APEINKEJOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F506D0", Offset = "0x6F4FAD0", VA = "0x186F506D0", Slot = "10")]
	public void BLOFDHDLMGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F50BF0", Offset = "0x6F4FFF0", VA = "0x186F50BF0")]
	private bool JILBJFADAGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F509B0", Offset = "0x6F4FDB0", VA = "0x186F509B0")]
	private void FCIJBFGPNDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class NCBAHOLEPPJ : NFDFLOGLJJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly PGANAEOOJLB CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly HGDIPJDAGFM MCJDEALPKMN;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody MLNLGAAEPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x84D8D0", Offset = "0x84CCD0", VA = "0x18084D8D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool LAAKKNFBEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F3B680", Offset = "0x6F3AA80", VA = "0x186F3B680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool GEMJPJHMOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xFF43E0", Offset = "0xFF37E0", VA = "0x180FF43E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F433D0", Offset = "0x6F427D0", VA = "0x186F433D0")]
	public NCBAHOLEPPJ(CCDJNBGDDDE CNGOHFHGBJN, [In] MOGMJHIJFHA LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F42C90", Offset = "0x6F42090", VA = "0x186F42C90", Slot = "5")]
	public void EOHNLKEPLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F42C30", Offset = "0x6F42030", VA = "0x186F42C30", Slot = "7")]
	public void CDFJLCNHLAH(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F42C60", Offset = "0x6F42060", VA = "0x186F42C60", Slot = "8")]
	public void ECABBGKKPGG(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6F42EB0", Offset = "0x6F422B0", VA = "0x186F42EB0", Slot = "9")]
	public void MJJGJLNHOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6F431E0", Offset = "0x6F425E0", VA = "0x186F431E0", Slot = "10")]
	public void PPCINFNBNOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6F42D30", Offset = "0x6F42130", VA = "0x186F42D30", Slot = "11")]
	public void KKPDGHAAMNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class NOJJPNKOOOJ : NDMONJOFEPH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly PGANAEOOJLB CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly HGDIPJDAGFM OLILMNDIDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float CJHCOONAPDF;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public PFGMJPGCKDN FNIKKHIDKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x852800", Offset = "0x851C00", VA = "0x180852800", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public KPCMLMPKPIO FJJLNPOBMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x851800", Offset = "0x850C00", VA = "0x180851800", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 KBKBJDBMDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x6F49B10", Offset = "0x6F48F10", VA = "0x186F49B10", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6F47730", Offset = "0x6F46B30", VA = "0x186F47730", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 FCAPPEBFPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6F47A40", Offset = "0x6F46E40", VA = "0x186F47A40", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6F47F30", Offset = "0x6F47330", VA = "0x186F47F30", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 IKKCDALJGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6F47400", Offset = "0x6F46800", VA = "0x186F47400", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6F46DA0", Offset = "0x6F461A0", VA = "0x186F46DA0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 HDJMEOPFDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6F47910", Offset = "0x6F46D10", VA = "0x186F47910", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6F49A80", Offset = "0x6F48E80", VA = "0x186F49A80", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float BAJAEPAMIBD
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x95D540", Offset = "0x95C940", VA = "0x18095D540", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6F47D40", Offset = "0x6F47140", VA = "0x186F47D40", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool PIGAGNMMPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x197D090", Offset = "0x197C490", VA = "0x18197D090", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private CNCFFBJBEKH HHIJDOKGOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6777D40", Offset = "0x6777140", VA = "0x186777D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool KPFMJCINAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6F492E0", Offset = "0x6F486E0", VA = "0x186F492E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A350", Offset = "0x6F49750", VA = "0x186F4A350")]
	public NOJJPNKOOOJ(CCDJNBGDDDE CNGOHFHGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6F47560", Offset = "0x6F46960", VA = "0x186F47560", Slot = "19")]
	public void EOHNLKEPLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6F47F60", Offset = "0x6F47360", VA = "0x186F47F60", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A060", Offset = "0x6F49460", VA = "0x186F4A060", Slot = "28")]
	public void PLFJKHPOFKB(Rigidbody DCMLHPJLAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xE06D30", Offset = "0xE06130", VA = "0x180E06D30", Slot = "20")]
	public void AJBLCBEPPHG(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xE07240", Offset = "0xE06640", VA = "0x180E07240", Slot = "30")]
	public void NIAEMJNAGBN(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6F47B60", Offset = "0x6F46F60", VA = "0x186F47B60", Slot = "35")]
	public Vector3 CPGCPEJNDCI(Vector3 HBNBBIDAMOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A190", Offset = "0x6F49590", VA = "0x186F4A190", Slot = "34")]
	public Vector3 POEFOLGJGPE(Vector3 DFABCICEPAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6F47560", Offset = "0x6F46960", VA = "0x186F47560", Slot = "27")]
	public void APHEJDKJFPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6F49AB0", Offset = "0x6F48EB0", VA = "0x186F49AB0", Slot = "25")]
	public void MMOHKMCODIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6F49A20", Offset = "0x6F48E20", VA = "0x186F49A20", Slot = "24")]
	public void MACGJECPGED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6F48830", Offset = "0x6F47C30", VA = "0x186F48830", Slot = "33")]
	public void GEHCJMBAPIF(Vector3 FPIOEGKPDHN, Vector3 BIIKFDLLGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6F48160", Offset = "0x6F47560", VA = "0x186F48160", Slot = "32")]
	public void FHCBDLFBBBN(Vector3 IIOAECOBFCF, Vector3 NAKIJOPFMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6F47FC0", Offset = "0x6F473C0", VA = "0x186F47FC0", Slot = "31")]
	public void EPEBDIJNKGN(Vector3 JLHNNPABOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6F481C0", Offset = "0x6F475C0", VA = "0x186F481C0", Slot = "22")]
	public void FJEHBHGJDME(AAHEMBGGCHJ PNJDOEEGGNC, Vector3 EMOBCJNELGO, float KLPBBMDHNKK, float KOJOBIBDCMN = 8f, float COFKNDPPEKN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6F49790", Offset = "0x6F48B90", VA = "0x186F49790", Slot = "21")]
	public void LCPANJMIOMC(FLBJHNGHAGI GPAFAKKLCNE, Vector3 OEDPIGEECGA, float LPNMJGDPLAP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6F49C70", Offset = "0x6F49070", VA = "0x186F49C70", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void PJKOPADLMJI(FLBJHNGHAGI GPAFAKKLCNE, Vector3 MGJIDJKDGAB, float ADKJPLGKKMF = 7f, float IFCJLPHCGOF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xF2EE60", Offset = "0xF2E260", VA = "0x180F2EE60")]
	private static void JFCMOILKLAC(Vector3 CLFPHNHFBOP, Vector3 EKOLOLBNIGP, [Out] Vector3 BNLBIBAGPEN, [Out] Vector3 FDHHIAHFBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6F47E50", Offset = "0x6F47250", VA = "0x186F47E50", Slot = "29")]
	public Vector3 DJALDLIBFJF(Vector3 CLFPHNHFBOP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6F490A0", Offset = "0x6F484A0", VA = "0x186F490A0", Slot = "26")]
	public void IGJHPNEPEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6F47D40", Offset = "0x6F47140", VA = "0x186F47D40")]
	private void DFILOMBOEJL(float OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6F48F00", Offset = "0x6F48300", VA = "0x186F48F00")]
	private void ICKODOANEPA(Vector3 OEDPIGEECGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6F47610", Offset = "0x6F46A10", VA = "0x186F47610")]
	private Vector3 APICCIMGPFF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6F49300", Offset = "0x6F48700", VA = "0x186F49300")]
	private void KEDHHNIKIMC(Vector3 DFABCICEPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6F477F0", Offset = "0x6F46BF0", VA = "0x186F477F0")]
	private Vector3 BNFPCBOPEEJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6F48A70", Offset = "0x6F47E70", VA = "0x186F48A70")]
	private void HDHGPHHOJKP(Vector3 OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6F46E60", Offset = "0x6F46260", VA = "0x186F46E60")]
	private void AJAHKFHNNAL(Vector3 DFABCICEPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6F49230", Offset = "0x6F48630", VA = "0x186F49230")]
	private void JKOEDKJBFPF()
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
