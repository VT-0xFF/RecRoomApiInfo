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
	public class LogRegistrationIndex : PDIMPOELJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67C78B0", Offset = "0x67C6AB0", VA = "0x1867C78B0", Slot = "4")]
		public override void FPMBLPAHIMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
	public class _AssemblyIndex : CAKBDCNKOBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private BNPPEDMHMGM bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x13736B0", Offset = "0x13728B0", VA = "0x1813736B0", Slot = "5")]
		public override void FCBNKPLDJOB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67CF630", Offset = "0x67CE830", VA = "0x1867CF630")]
		private void ADEFBFFMAIK(PBABFIIKKEP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x67CF940", Offset = "0x67CEB40", VA = "0x1867CF940", Slot = "6")]
		public override void KOHLKIFPOBH(PBABFIIKKEP registry, [In] OKFMGAJCCBM filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "8")]
		public override void LFGBMGLIJAD(PDIHABEAKLL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x67CF9A0", Offset = "0x67CEBA0", VA = "0x1867CF9A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, IHMHPNACLKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly JJNHGMIGPBK JPABCONOMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool LCDACJPIFJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private HCDGCCECAEP BIJCGHDLGKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[JCPFEOHJOPF(OILHINDHMGI.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[JCPFEOHJOPF(OILHINDHMGI.SelfAndParent, true, false, false)]
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
		private ANOFOMAGMPD physicsInterpolation;

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
		internal HCDGCCECAEP DBCBMKAAOGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x67CAC80", Offset = "0x67C9E80", VA = "0x1867CAC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private HCDGCCECAEP AOLLEPMPFBE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int JKBKEJCNPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x67CCA60", Offset = "0x67CBC60", VA = "0x1867CCA60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx CKNEEMMFHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x67CCDC0", Offset = "0x67CBFC0", VA = "0x1867CCDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx AKJHKAMODFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x67CCD00", Offset = "0x67CBF00", VA = "0x1867CCD00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx BHNONFFBKHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x67CDA70", Offset = "0x67CCC70", VA = "0x1867CDA70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x67CEFA0", Offset = "0x67CE1A0", VA = "0x1867CEFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform LIGAMHMIGOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7DDD50", Offset = "0x7DCF50", VA = "0x1807DDD50", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform BHDKKMFADHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7DDD50", Offset = "0x7DCF50", VA = "0x1807DDD50", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public GPHAHJNAAFN CNDJCFNOHIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x67CCAC0", Offset = "0x67CBCC0", VA = "0x1867CCAC0")]
			get
			{
				return default(GPHAHJNAAFN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x67CE750", Offset = "0x67CD950", VA = "0x1867CE750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GIFOIMPOILG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x67CD0D0", Offset = "0x67CC2D0", VA = "0x1867CD0D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool HBONMENFLEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x67CCBE0", Offset = "0x67CBDE0", VA = "0x1867CCBE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public CKLELEBFCJP GBLMDIJCCFK
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x67CD010", Offset = "0x67CC210", VA = "0x1867CD010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x67CE910", Offset = "0x67CDB10", VA = "0x1867CE910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EJAOGNIOOGM CIHJGHDKNLG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x67CCFB0", Offset = "0x67CC1B0", VA = "0x1867CCFB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x67CE8A0", Offset = "0x67CDAA0", VA = "0x1867CE8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IJKNPLBEOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x67CCF00", Offset = "0x67CC100", VA = "0x1867CCF00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody FLEDBGNMPOM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x67CCF60", Offset = "0x67CC160", VA = "0x1867CCF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool DOGPMNAPHGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x67CCC40", Offset = "0x67CBE40", VA = "0x1867CCC40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x67CE7C0", Offset = "0x67CD9C0", VA = "0x1867CE7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool AOBLMCNBENP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5F5D800", Offset = "0x5F5CA00", VA = "0x185F5D800", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float LGLDCHHCDJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x67CDA10", Offset = "0x67CCC10", VA = "0x1867CDA10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float IKALNGDHJLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x67CD9B0", Offset = "0x67CCBB0", VA = "0x1867CD9B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x67CEF30", Offset = "0x67CE130", VA = "0x1867CEF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float ICEHDFEGFAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x67CD330", Offset = "0x67CC530", VA = "0x1867CD330")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x67CEBB0", Offset = "0x67CDDB0", VA = "0x1867CEBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float FNFPENLAOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x67CD130", Offset = "0x67CC330", VA = "0x1867CD130")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x67CE980", Offset = "0x67CDB80", VA = "0x1867CE980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool PCPNPPPIDOE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x67CDFF0", Offset = "0x67CD1F0", VA = "0x1867CDFF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x67CF4E0", Offset = "0x67CE6E0", VA = "0x1867CF4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 JOFLKGACMIH
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x67CD790", Offset = "0x67CC990", VA = "0x1867CD790")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x67CED00", Offset = "0x67CDF00", VA = "0x1867CED00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 MPIFOMFNBNG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x67CE130", Offset = "0x67CD330", VA = "0x1867CE130")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode LGMLFPIINII
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x67CD270", Offset = "0x67CC470", VA = "0x1867CD270")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x67CEAD0", Offset = "0x67CDCD0", VA = "0x1867CEAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float PNFPKEPCDAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x67CCCA0", Offset = "0x67CBEA0", VA = "0x1867CCCA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x67CE830", Offset = "0x67CDA30", VA = "0x1867CE830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints LAHLNEAOJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x67CD2D0", Offset = "0x67CC4D0", VA = "0x1867CD2D0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x67CEB40", Offset = "0x67CDD40", VA = "0x1867CEB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 KLDLPCHOJKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x67CDB30", Offset = "0x67CCD30", VA = "0x1867CDB30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 JCIPNNNPCOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x67CDB30", Offset = "0x67CCD30", VA = "0x1867CDB30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x67CF2C0", Offset = "0x67CE4C0", VA = "0x1867CF2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float AEDNJMFCMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x67CD870", Offset = "0x67CCA70", VA = "0x1867CD870")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x67CEDE0", Offset = "0x67CDFE0", VA = "0x1867CEDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float DMPDJHOMJJE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x67CDF90", Offset = "0x67CD190", VA = "0x1867CDF90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x67CF470", Offset = "0x67CE670", VA = "0x1867CF470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion APLJHHNMEEL
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x67CDC10", Offset = "0x67CCE10", VA = "0x1867CDC10")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x67CF040", Offset = "0x67CE240", VA = "0x1867CF040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion DLLLFKCMGGA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x67CDEB0", Offset = "0x67CD0B0", VA = "0x1867CDEB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x67CF3A0", Offset = "0x67CE5A0", VA = "0x1867CF3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 MLDEHPHAMPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x67CDCF0", Offset = "0x67CCEF0", VA = "0x1867CDCF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x67CF110", Offset = "0x67CE310", VA = "0x1867CF110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DHPLIEOMIMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x67CDDD0", Offset = "0x67CCFD0", VA = "0x1867CDDD0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x67CF1F0", Offset = "0x67CE3F0", VA = "0x1867CF1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 JPMMLNGJNDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x67CE050", Offset = "0x67CD250", VA = "0x1867CE050")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x67CF550", Offset = "0x67CE750", VA = "0x1867CF550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 MGKFELLKNBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x67CD8D0", Offset = "0x67CCAD0", VA = "0x1867CD8D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x67CEE50", Offset = "0x67CE050", VA = "0x1867CEE50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 IACHFILKNFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x67CD190", Offset = "0x67CC390", VA = "0x1867CD190")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x67CE9F0", Offset = "0x67CDBF0", VA = "0x1867CE9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 IOOLPCCNOIN
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x67CD6B0", Offset = "0x67CC8B0", VA = "0x1867CD6B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x67CEC20", Offset = "0x67CDE20", VA = "0x1867CEC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 JOOIMGMBBCM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x67CD570", Offset = "0x67CC770", VA = "0x1867CD570")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion HMLJOKKHKOB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x67CD490", Offset = "0x67CC690", VA = "0x1867CD490")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 JDIGCPAPDDH
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x67CE2F0", Offset = "0x67CD4F0", VA = "0x1867CE2F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 BIDOHIBFMAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x67CE210", Offset = "0x67CD410", VA = "0x1867CE210")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool CLJGIKNNNMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x67CD650", Offset = "0x67CC850", VA = "0x1867CD650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool DKMCEHCODFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x67CD070", Offset = "0x67CC270", VA = "0x1867CD070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool GGIOBMCCIDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x67CCB80", Offset = "0x67CBD80", VA = "0x1867CCB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool LFOGNOOKPME
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x67CCB20", Offset = "0x67CBD20", VA = "0x1867CCB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool FFDPHNMHHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x67CCA00", Offset = "0x67CBC00", VA = "0x1867CCA00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool FCBOFIJIDMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x67CD390", Offset = "0x67CC590", VA = "0x1867CD390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool FLFFMMHGNFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x52C68F0", Offset = "0x52C5AF0", VA = "0x1852C68F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event BEBLGGPGHFJ EBPMKBNEDDI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x67CC920", Offset = "0x67CBB20", VA = "0x1867CC920")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x67CE670", Offset = "0x67CD870", VA = "0x1867CE670")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MGHEEHNOJLO FNMAGHNOFCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x67CC690", Offset = "0x67CB890", VA = "0x1867CC690")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x67CE3D0", Offset = "0x67CD5D0", VA = "0x1867CE3D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event MGHEEHNOJLO NOBKCJFFBGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x67CC6F0", Offset = "0x67CB8F0", VA = "0x1867CC6F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x67CE440", Offset = "0x67CD640", VA = "0x1867CE440")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event MGHEEHNOJLO MCFIPJHMPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x67CC840", Offset = "0x67CBA40", VA = "0x1867CC840")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x67CE590", Offset = "0x67CD790", VA = "0x1867CE590")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<PGDHFLLAIAB, PGDHFLLAIAB> HJIJHKADNOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x67CC7D0", Offset = "0x67CB9D0", VA = "0x1867CC7D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x67CE520", Offset = "0x67CD720", VA = "0x1867CE520")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event MGHEEHNOJLO BHGGDOKKPKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x67CC8B0", Offset = "0x67CBAB0", VA = "0x1867CC8B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x67CE600", Offset = "0x67CD800", VA = "0x1867CE600")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event MGHEEHNOJLO FMBPJCECFHL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x67CC990", Offset = "0x67CBB90", VA = "0x1867CC990")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x67CE6E0", Offset = "0x67CD8E0", VA = "0x1867CE6E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event MGHEEHNOJLO CMLAOOOKDID
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67CC760", Offset = "0x67CB960", VA = "0x1867CC760")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x67CE4B0", Offset = "0x67CD6B0", VA = "0x1867CE4B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0", Slot = "8")]
		private void PJFHEFONBCK(HCDGCCECAEP PFGBPGKFOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67CAF10", Offset = "0x67CA110", VA = "0x1867CAF10")]
		internal void GIIHCPGAJAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67CC3C0", Offset = "0x67CB5C0", VA = "0x1867CC3C0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody IHLMKEPNEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67CAFA0", Offset = "0x67CA1A0", VA = "0x1867CAFA0")]
		public IHMHPNACLKD GetChild(int HMFNCGHECPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x67CC090", Offset = "0x67CB290", VA = "0x1867CC090")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) PCCDIKIMCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x67CAC10", Offset = "0x67C9E10", VA = "0x1867CAC10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x67CAC80", Offset = "0x67C9E80", VA = "0x1867CAC80")]
		private HCDGCCECAEP CPPGLDLFCCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x67CB470", Offset = "0x67CA670", VA = "0x1867CB470")]
		private void KBPFNBLAFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67CB860", Offset = "0x67CAA60", VA = "0x1867CB860")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x67CAF10", Offset = "0x67CA110", VA = "0x1867CAF10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x67CB800", Offset = "0x67CAA00", VA = "0x1867CB800")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x67CB8C0", Offset = "0x67CAAC0", VA = "0x1867CB8C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x67CA2C0", Offset = "0x67C94C0", VA = "0x1867CA2C0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object FCKLPDKGPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x67CB920", Offset = "0x67CAB20", VA = "0x1867CB920")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object FCKLPDKGPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x67CAEB0", Offset = "0x67CA0B0", VA = "0x1867CAEB0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x67CB7A0", Offset = "0x67CA9A0", VA = "0x1867CB7A0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x67CC1F0", Offset = "0x67CB3F0", VA = "0x1867CC1F0")]
		public void SetParent(RigidbodyEx NICEPFIEJED, bool BGMNOFHPMFB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x67CBC30", Offset = "0x67CAE30", VA = "0x1867CBC30")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x67CB250", Offset = "0x67CA450", VA = "0x1867CB250")]
		public bool IsRigidbodyAncestor(RigidbodyEx NLHIBFMIJEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x67CB330", Offset = "0x67CA530", VA = "0x1867CB330")]
		public bool IsRigidbodyDescendant(RigidbodyEx LGINMEFPPOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x67CA530", Offset = "0x67C9730", VA = "0x1867CA530")]
		public void AddInterpolationRestriction(object FCKLPDKGPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x67CB990", Offset = "0x67CAB90", VA = "0x1867CB990")]
		public void RemoveInterpolationRestriction(object FCKLPDKGPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x67CA5A0", Offset = "0x67C97A0", VA = "0x1867CA5A0")]
		public void AddKinematic(object FCKLPDKGPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x67CBA00", Offset = "0x67CAC00", VA = "0x1867CBA00")]
		public void RemoveKinematic(object FCKLPDKGPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x67CC170", Offset = "0x67CB370", VA = "0x1867CC170")]
		public void SetKinematic(object FCKLPDKGPKE, bool PDEBHACKBII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x67CBF90", Offset = "0x67CB190", VA = "0x1867CBF90")]
		public void SetDiscontinuousPositionAndRotation(Vector3 JGCGPCIKADF, Quaternion KFAMAMEBBII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x67CBE90", Offset = "0x67CB090", VA = "0x1867CBE90")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 DCAILIEPHOG, Quaternion MIBEENCCLHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x67CB140", Offset = "0x67CA340", VA = "0x1867CB140")]
		public Vector3 GetConstrainedVelocity(Vector3 JPMMLNGJNDB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x67CB030", Offset = "0x67CA230", VA = "0x1867CB030")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 IACHFILKNFB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x67CA440", Offset = "0x67C9640", VA = "0x1867CA440")]
		public void AddForce(Vector3 FCLAIJBMLJG, ForceMode OAEDCOGNIMA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x67CA330", Offset = "0x67C9530", VA = "0x1867CA330")]
		public void AddForceAtPosition(Vector3 FCLAIJBMLJG, Vector3 DHMMMGDKPCG, ForceMode OAEDCOGNIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x67CA770", Offset = "0x67C9970", VA = "0x1867CA770")]
		public void AddTorque(Vector3 BCBAKMNPAGJ, ForceMode OAEDCOGNIMA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x67CA610", Offset = "0x67C9810", VA = "0x1867CA610")]
		public void AddRelativeTorque(Vector3 BCBAKMNPAGJ, ForceMode OAEDCOGNIMA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x67CC490", Offset = "0x67CB690", VA = "0x1867CC490")]
		public Vector3 WorldToLocalVelocity(Vector3 DEPCJPCCEGP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x67CB690", Offset = "0x67CA890", VA = "0x1867CB690")]
		public Vector3 LocalToWorldVelocity(Vector3 MGKFELLKNBM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x67CAE50", Offset = "0x67CA050", VA = "0x1867CAE50")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x67CADF0", Offset = "0x67C9FF0", VA = "0x1867CADF0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x67CAD90", Offset = "0x67C9F90", VA = "0x1867CAD90")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x67CAD30", Offset = "0x67C9F30", VA = "0x1867CAD30")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x67CBD90", Offset = "0x67CAF90", VA = "0x1867CBD90")]
		public void ResetVelocityWorldSpace(Vector3 FDMEDIMDJFI, Vector3 OJHACBOBKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x67CBC90", Offset = "0x67CAE90", VA = "0x1867CBC90")]
		public void ResetVelocityLocalSpace(Vector3 DHIAIOAJMJE, Vector3 IOOLPCCNOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x67CBB50", Offset = "0x67CAD50", VA = "0x1867CBB50")]
		public void ResetLinearVelocityLocalSpace(Vector3 DHIAIOAJMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x67CC320", Offset = "0x67CB520", VA = "0x1867CC320")]
		public bool SweepTest(Vector3 ILKFGPOHBIP, [Out] RaycastHit CMMBAEFAAGG, float HJPKMNIGHNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x67CB410", Offset = "0x67CA610", VA = "0x1867CB410")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x67CC2C0", Offset = "0x67CB4C0", VA = "0x1867CC2C0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x67CC430", Offset = "0x67CB630", VA = "0x1867CC430")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x67CA700", Offset = "0x67C9900", VA = "0x1867CA700")]
		public void AddShouldHaveUnityRigidbodyToken(object FCKLPDKGPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x67CBA70", Offset = "0x67CAC70", VA = "0x1867CBA70")]
		public void RemoveShouldHaveUnityRigidbodyToken(object FCKLPDKGPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x67CAAA0", Offset = "0x67C9CA0", VA = "0x1867CAAA0")]
		public void ApplyForceVelocityChange(ODFIFOEIPOB JPNLMCAHNCF, Vector3 IIJKIDIFJNO, float OPKCPNAOJLG, float ADLHHECADCN = 8f, float GGJBGFMFPBH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x67CAA00", Offset = "0x67C9C00", VA = "0x1867CAA00")]
		public void ApplyAngularVelocityChange(MCKLPPJOMOK LAEAKPFEGLK, Vector3 PNGPNDMJNGP, float GEHEKDBMGLO = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x67CAB60", Offset = "0x67C9D60", VA = "0x1867CAB60")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(MCKLPPJOMOK LAEAKPFEGLK, Vector3 HBCECKEGCGH, float NKOKHDMEPJH = 7f, float IDFHKKPEKIN = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x67CA930", Offset = "0x67C9B30", VA = "0x1867CA930")]
		public bool AllowedScaleChange(float FHNIBDNNPGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x67CA860", Offset = "0x67C9A60", VA = "0x1867CA860")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx KJBFBPNGEEG, object FCKLPDKGPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x67CBAE0", Offset = "0x67CACE0", VA = "0x1867CBAE0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object FCKLPDKGPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x67CC620", Offset = "0x67CB820", VA = "0x1867CC620")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x872820", Offset = "0x871A20", VA = "0x180872820", Slot = "4")]
		private GameObject KHMOMDOONOE()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD50", Offset = "0x7DCF50", VA = "0x1807DDD50", Slot = "5")]
		private Transform LEPEDAOPCJF()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class JPEDAADJMJO
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x67C64A0", Offset = "0x67C56A0", VA = "0x1867C64A0")]
	public static HCDGCCECAEP DBCBMKAAOGI(this RigidbodyEx PIGCCDNLNPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HGCGALFKODL(typeof(PFKDEAGOGFL), new string[] { })]
public class CKIADPJMHNL : PFKDEAGOGFL, BKCFFAPDBPM
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly JJNHGMIGPBK OMJOPGOBIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LCCCJGOFHBF NJHOMAGMEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private GNJEBPIENPG KIGDILPPPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private FPLNBHPGIAL GCFKIEIEIMC;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public GNJEBPIENPG JIBKPHHGEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public FPLNBHPGIAL JJFHBPGHLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67B5F40", Offset = "0x67B5140", VA = "0x1867B5F40", Slot = "7")]
	public void InitReferences(CKDGHLLENBO LIHCLMFINBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67B5EB0", Offset = "0x67B50B0", VA = "0x1867B5EB0", Slot = "6")]
	public HCDGCCECAEP BFDOMBBIDNA(RigidbodyEx PIGCCDNLNPO, BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public CKIADPJMHNL()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static AGKHEGBIBIG UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int MBBIBCLCCON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int LPNGNKNJGHE;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x67CA140", Offset = "0x67C9340", VA = "0x1867CA140")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x67CA180", Offset = "0x67C9380", VA = "0x1867CA180")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x67CA160", Offset = "0x67C9360", VA = "0x1867CA160")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string JGNAJPMGGNE, [Optional] UnityEngine.Object KAEEGPAIBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string JGNAJPMGGNE, [Optional] UnityEngine.Object KAEEGPAIBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x67CA270", Offset = "0x67C9470", VA = "0x1867CA270")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HBIBIMNPKBH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class DHBAJOENIOG : CKLELEBFCJP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C49A0", Offset = "0x7C3BA0", VA = "0x1807C49A0", Slot = "4")]
		public Vector3 AIKAIHNNGMM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C49A0", Offset = "0x7C3BA0", VA = "0x1807C49A0", Slot = "5")]
		public Vector3 MJKMLEIDIIO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public DHBAJOENIOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static CKLELEBFCJP GAJFDEKEHMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x67C2D00", Offset = "0x67C1F00", VA = "0x1867C2D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JFGCFIIGCDA
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode GKMIBJKCABK
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
	void ABMIDKDAPOK();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MENNJOCODBP(bool CLJGIKNNNMN);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EMAIDKNBKLA(bool CLJGIKNNNMN);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FCHNLNGIIAP(Rigidbody PDECCLFHGGL);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FPAFMIKNLGH(Vector3 ILKFGPOHBIP, [Out] RaycastHit CMMBAEFAAGG, float HJPKMNIGHNC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JFFEDLDCMCH : IDisposable, EKCFFCDIJFL
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	GPHAHJNAAFN CNDJCFNOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<PGDHFLLAIAB, PGDHFLLAIAB> HJIJHKADNOE;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABMIDKDAPOK();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface FPLNBHPGIAL
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CNMPIDLEHJM GBADCIOACDE(HCDGCCECAEP PFGBPGKFOLN);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OOEEACLPHBP FMBFDKHFPCH(HCDGCCECAEP PFGBPGKFOLN);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	APMNNOJOMOB LPJDNBCALED(HCDGCCECAEP PFGBPGKFOLN);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PLBINDHECDI MLEHHLBPOBH(HCDGCCECAEP PFGBPGKFOLN);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PDKHMONANLE GLBOFIKGLEA(HCDGCCECAEP PFGBPGKFOLN);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JFFEDLDCMCH EFHGFDIDGEA(HCDGCCECAEP PFGBPGKFOLN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IBJDONNOHKJ BOOCHCGKFFE(HCDGCCECAEP PFGBPGKFOLN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BLOMGPJBBOI NMICJBJCLGC(HCDGCCECAEP PFGBPGKFOLN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JFGCFIIGCDA GAFGALEGDGL(HCDGCCECAEP PFGBPGKFOLN);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MCNJPKDDKEA FMBPIOBALAA(HCDGCCECAEP PFGBPGKFOLN);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LFIPGIIPODB DIBFFNALELJ(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HKMPCONONPD GAOGALCAMPM(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EHHIJPJOBCA ENKIAGAPFGE(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MCDEHABHJGH JHEAGDGBDMK(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	INABINDBFIK KBKDIIDLGFE(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HCDGCCECAEP BFDOMBBIDNA(RigidbodyEx PIGCCDNLNPO, BICJDOJJHMH FODGEDCJIDC, PFKDEAGOGFL ANAEOGBFNHN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BLOMGPJBBOI
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJAMKJNKGOF(Vector3 FCLAIJBMLJG, ForceMode OAEDCOGNIMA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKIBLHBEEPO(Vector3 FCLAIJBMLJG, Vector3 DHMMMGDKPCG, ForceMode OAEDCOGNIMA);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OFMNNELFOAF(Vector3 BCBAKMNPAGJ, ForceMode OAEDCOGNIMA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OLEFEGOKGDN(Vector3 BCBAKMNPAGJ, ForceMode OAEDCOGNIMA = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MCNJPKDDKEA
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool GKIDIPKJAKF
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
	void FCHNLNGIIAP(Rigidbody PDECCLFHGGL);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KODKJGCPPBI(Rigidbody PDECCLFHGGL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CNMPIDLEHJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<HCDGCCECAEP> MOPDBBJCFGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	HCDGCCECAEP AKJHKAMODFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	HCDGCCECAEP ANNFPHELCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MGHEEHNOJLO FNMAGHNOFCC;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event MGHEEHNOJLO NOBKCJFFBGK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event BEBLGGPGHFJ BLDJHFBKICJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action DIABPFDPDNI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action CHLHEIJHEHD;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<HCDGCCECAEP> LIGCCNFECCG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<HCDGCCECAEP> KGNCIDAAMKG;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action BAIDDIMCGMC;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<HCDGCCECAEP> GAHCOEJMDGL;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CFLHPBMALHN(HCDGCCECAEP MHAMFGHDGFA, bool BGMNOFHPMFB = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface APMNNOJOMOB
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 OKKAABABFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 NPHAPCACINB
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPNNFMKFCIG(HCDGCCECAEP BHNONFFBKHO, object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANJNGDGBOIB(object FCKLPDKGPKE);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MCDEHABHJGH
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 CJACLIKLAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 BGMIGEKMIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float KHKDBEGDKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float DHGDJCEHBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 EDGGKDBKLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion AKMHFFBBAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event MGHEEHNOJLO DKLFDBJDIGA;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HMIPLFKMHEA((Quaternion rot, Vector3 moments) PCCDIKIMCKI);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LOMDLBEHMCP();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OMDJECHMMFA();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JOHBOOBKFFJ();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FCHNLNGIIAP(Rigidbody PDECCLFHGGL);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KODKJGCPPBI(Rigidbody PDECCLFHGGL);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IFIADBNNDNA();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EHHIJPJOBCA
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABMIDKDAPOK();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDGCGCOGMBH(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKKFGOHEECP(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NPLFDACLOBO(HCDGCCECAEP PIGCCDNLNPO);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EAHLJDNDEIP(HCDGCCECAEP PIGCCDNLNPO);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PAGBALFNAPG();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IBJDONNOHKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool CCEEOOAEGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event MGHEEHNOJLO EMCCEHAFIAI;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CKIHJJBLEMP(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GPHBMEFNNLI(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CMOHPMGOLDH(object FCKLPDKGPKE, bool PDEBHACKBII);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FCHNLNGIIAP(Rigidbody LAANOCCOMFF);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KODKJGCPPBI(Rigidbody PDECCLFHGGL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HKMPCONONPD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool GIFOIMPOILG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HBONMENFLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event MGHEEHNOJLO DFAPJOPCDIP;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABMIDKDAPOK();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FENPMLIEDAM(HCDGCCECAEP BHNONFFBKHO);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JHMFENIIABB(HCDGCCECAEP BHNONFFBKHO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface INABINDBFIK
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool DOGPMNAPHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool NGJPOAKODON
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints HHECACDFAMP
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
	void FCHNLNGIIAP(Rigidbody PDECCLFHGGL);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KODKJGCPPBI(Rigidbody PDECCLFHGGL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PLBINDHECDI
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float HILNNJPODPE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float HMHKEPLBCDL
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
	void FCHNLNGIIAP(Rigidbody PDECCLFHGGL);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KODKJGCPPBI(Rigidbody PDECCLFHGGL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PDKHMONANLE
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event MGHEEHNOJLO DKDFEBGJMEJ;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABMIDKDAPOK();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EDCIGFOEIPE();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FEIBKKJACMK();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EFMNMIEBMDH();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HFLMAHLNBAI();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IGFKFBEIGID();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LFIPGIIPODB
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody FLEDBGNMPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool IIBKNOAKEBG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABMIDKDAPOK();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHEHMGDAINE(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MBIBPFFCOBC(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GKOKNGMJGMF();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EJJBPHOIPHF();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OOEEACLPHBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	CKLELEBFCJP GBLMDIJCCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	EJAOGNIOOGM CIHJGHDKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 JPCJHLPMEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 JKHEFEAECKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 MEJNHHCNIPO
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 AOFHKBKNJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float PNFPKEPCDAO
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool IJKNPLBEOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ABMIDKDAPOK();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FPIEOJBMNFD(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FFBBIPLAOEM(MCKLPPJOMOK LAEAKPFEGLK, Vector3 PNGPNDMJNGP, float GEHEKDBMGLO = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OINGMABDDGL(ODFIFOEIPOB JPNLMCAHNCF, Vector3 IIJKIDIFJNO, float OPKCPNAOJLG, float ADLHHECADCN = 8f, float GGJBGFMFPBH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NNKFGPELLFO(MCKLPPJOMOK LAEAKPFEGLK, Vector3 HBCECKEGCGH, float NKOKHDMEPJH = 7f, float IDFHKKPEKIN = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HAFMKOKJLCL();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JOHLBECDCDI();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LCCEBIADBEF();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MANEBCKGDDJ();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FCHNLNGIIAP(Rigidbody PDECCLFHGGL);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 NMFIDAGOJBF(Vector3 JPMMLNGJNDB);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ILDPPFHIJHG(object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PJDEILJPDJM(Vector3 HLNHFEOKKJM);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LOHDNDLMHOO(Vector3 DHIAIOAJMJE, Vector3 IOOLPCCNOIN);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void OPBCAKCJMIB(Vector3 FDMEDIMDJFI, Vector3 OJHACBOBKAK);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 PDOGEJIDCEK(Vector3 MGKFELLKNBM);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 JKEILGMCIDM(Vector3 DEPCJPCCEGP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface GNJEBPIENPG
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool LBLCHCBIHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APGPBEBFHIG(string BKDLFDLOKJH);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKGCBBLDJKL(RigidbodyEx PIGCCDNLNPO, Action GKGLDBAJJCH);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EOMKGELPLCG DAJDHJDICAD(int PGJJPLOAEGM);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CKPDECAELND(Vector3 MPIFOMFNBNG, float EBHBILJGIBF, Color NHDAKDKKMHH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
public interface PFKDEAGOGFL
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	GNJEBPIENPG JIBKPHHGEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	FPLNBHPGIAL JJFHBPGHLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HCDGCCECAEP BFDOMBBIDNA(RigidbodyEx PIGCCDNLNPO, BICJDOJJHMH FODGEDCJIDC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EPKAMMNFKBC : HCDGCCECAEP, IDisposable, BPLBIHICDIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly PFKDEAGOGFL ANAEOGBFNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal CNMPIDLEHJM JBNJEEOOCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal EHHIJPJOBCA GDBEHALCMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal HKMPCONONPD KLBHHAIPODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal OOEEACLPHBP JPMMLNGJNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal APMNNOJOMOB LFNFEHAFANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal MCDEHABHJGH AEEJFCIFEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal PLBINDHECDI IEJLEBFHIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal MCNJPKDDKEA IICIMOLFKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal PDKHMONANLE HHJIOGMEOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal JFFEDLDCMCH OKDPGLBCNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal IBJDONNOHKJ IJBBMGDIHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal BLOMGPJBBOI FCLAIJBMLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal INABINDBFIK EJBMEFBCOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal LFIPGIIPODB PDECCLFHGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal JFGCFIIGCDA NGJHJLNMOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable CCKPGKOIPGL;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public MDCKLNCPLLP AHIKPAJLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "22")]
		get
		{
			return default(MDCKLNCPLLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public IHMHPNACLKD BGJAPCJPLML
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0240", VA = "0x1807C1040", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F10", Offset = "0x7C0110", VA = "0x1807C0F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject OFPFIDAFJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x89EB50", Offset = "0x89DD50", VA = "0x18089EB50", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x87BCE0", Offset = "0x87AEE0", VA = "0x18087BCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform BHIBJBFFJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x67BCCF0", Offset = "0x67BBEF0", VA = "0x1867BCCF0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody FLEDBGNMPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x67B9B20", Offset = "0x67B8D20", VA = "0x1867B9B20", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public HCDGCCECAEP ANNFPHELCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x67BC450", Offset = "0x67BB650", VA = "0x1867BC450", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x67BDF00", Offset = "0x67BD100", VA = "0x1867BDF00", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int JKBKEJCNPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x67BDA90", Offset = "0x67BCC90", VA = "0x1867BDA90", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public HCDGCCECAEP AKJHKAMODFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x67BB280", Offset = "0x67BA480", VA = "0x1867BB280", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool MEHFEOAECPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x67BA7B0", Offset = "0x67B99B0", VA = "0x1867BA7B0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool GIFOIMPOILG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x67BAA40", Offset = "0x67B9C40", VA = "0x1867BAA40", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool HBONMENFLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x67BC1D0", Offset = "0x67BB3D0", VA = "0x1867BC1D0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public CKLELEBFCJP GBLMDIJCCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x67BDF60", Offset = "0x67BD160", VA = "0x1867BDF60", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x67B9A70", Offset = "0x67B8C70", VA = "0x1867B9A70", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public EJAOGNIOOGM CIHJGHDKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x67BBA20", Offset = "0x67BAC20", VA = "0x1867BBA20", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x67BA750", Offset = "0x67B9950", VA = "0x1867BA750", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float PNFPKEPCDAO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x67B9F40", Offset = "0x67B9140", VA = "0x1867B9F40", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x67B9740", Offset = "0x67B8940", VA = "0x1867B9740", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 JKHEFEAECKB
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x67BB940", Offset = "0x67BAB40", VA = "0x1867BB940", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x67B9D60", Offset = "0x67B8F60", VA = "0x1867B9D60", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 AOFHKBKNJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x67BED00", Offset = "0x67BDF00", VA = "0x1867BED00", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x67B9660", Offset = "0x67B8860", VA = "0x1867B9660", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 JPCJHLPMEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x67BE470", Offset = "0x67BD670", VA = "0x1867BE470", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x67BB640", Offset = "0x67BA840", VA = "0x1867BB640", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 MEJNHHCNIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x67BEE30", Offset = "0x67BE030", VA = "0x1867BEE30", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x67BE550", Offset = "0x67BD750", VA = "0x1867BE550", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool GGIOBMCCIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x67BB2D0", Offset = "0x67BA4D0", VA = "0x1867BB2D0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool LFOGNOOKPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x67BD110", Offset = "0x67BC310", VA = "0x1867BD110", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool FFDPHNMHHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x67BDDC0", Offset = "0x67BCFC0", VA = "0x1867BDDC0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool IJKNPLBEOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x67BCA70", Offset = "0x67BBC70", VA = "0x1867BCA70", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 OKKAABABFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x67B97A0", Offset = "0x67B89A0", VA = "0x1867B97A0", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 NPHAPCACINB
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x67BAF30", Offset = "0x67BA130", VA = "0x1867BAF30", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 CJACLIKLAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x67BCB60", Offset = "0x67BBD60", VA = "0x1867BCB60", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x67B9C20", Offset = "0x67B8E20", VA = "0x1867B9C20", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 BGMIGEKMIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x67BD840", Offset = "0x67BCA40", VA = "0x1867BD840", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float KHKDBEGDKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x67BAED0", Offset = "0x67BA0D0", VA = "0x1867BAED0", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float DHGDJCEHBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x67BD020", Offset = "0x67BC220", VA = "0x1867BD020", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x67BECA0", Offset = "0x67BDEA0", VA = "0x1867BECA0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 EDGGKDBKLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x67BAAF0", Offset = "0x67B9CF0", VA = "0x1867BAAF0", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion AKMHFFBBAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x67BEF70", Offset = "0x67BE170", VA = "0x1867BEF70", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float HILNNJPODPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x67BD070", Offset = "0x67BC270", VA = "0x1867BD070", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x67BEF10", Offset = "0x67BE110", VA = "0x1867BEF10", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float HMHKEPLBCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x67BE770", Offset = "0x67BD970", VA = "0x1867BE770", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x67BA0B0", Offset = "0x67B92B0", VA = "0x1867BA0B0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool GKIDIPKJAKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x67BCCA0", Offset = "0x67BBEA0", VA = "0x1867BCCA0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x67BD980", Offset = "0x67BCB80", VA = "0x1867BD980", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public GPHAHJNAAFN CNDJCFNOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x67BC5A0", Offset = "0x67BB7A0", VA = "0x1867BC5A0", Slot = "68")]
		get
		{
			return default(GPHAHJNAAFN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x67BBC10", Offset = "0x67BAE10", VA = "0x1867BBC10", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool CCEEOOAEGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x67B95D0", Offset = "0x67B87D0", VA = "0x1867B95D0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform BHDKKMFADHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x67BAF20", Offset = "0x67BA120", VA = "0x1867BAF20", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 GBDENECPBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x67B9B70", Offset = "0x67B8D70", VA = "0x1867B9B70", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x67BB7E0", Offset = "0x67BA9E0", VA = "0x1867BB7E0", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float FDAEOKKDIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x67BCEF0", Offset = "0x67BC0F0", VA = "0x1867BCEF0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x67BC300", Offset = "0x67BB500", VA = "0x1867BC300", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float AMNHIPPOEGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x67BC430", Offset = "0x67BB630", VA = "0x1867BC430", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x67BD4F0", Offset = "0x67BC6F0", VA = "0x1867BD4F0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion HEEFMLJPIKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x67BCD80", Offset = "0x67BBF80", VA = "0x1867BCD80", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x67BA110", Offset = "0x67B9310", VA = "0x1867BA110", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 APOIDAPMEHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x67BE930", Offset = "0x67BDB30", VA = "0x1867BE930", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x67BD170", Offset = "0x67BC370", VA = "0x1867BD170", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion CDOBGHCOBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x67BD1C0", Offset = "0x67BC3C0", VA = "0x1867BD1C0", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x67B9620", Offset = "0x67B8820", VA = "0x1867B9620", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints HHECACDFAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x67B9080", Offset = "0x67B8280", VA = "0x1867B9080", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x67BC3D0", Offset = "0x67BB5D0", VA = "0x1867BC3D0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool DOGPMNAPHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x67BEDE0", Offset = "0x67BDFE0", VA = "0x1867BEDE0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x67BA6F0", Offset = "0x67B98F0", VA = "0x1867BA6F0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode GKMIBJKCABK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x67B9AD0", Offset = "0x67B8CD0", VA = "0x1867B9AD0", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x67BE090", Offset = "0x67BD290", VA = "0x1867BE090", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool MFKLFHJCCED
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x67BC650", Offset = "0x67BB850", VA = "0x1867BC650", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool DKMCEHCODFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x67BA810", Offset = "0x67B9A10", VA = "0x1867BA810", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event MGHEEHNOJLO FNMAGHNOFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x67BAD70", Offset = "0x67B9F70", VA = "0x1867BAD70", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x67BCFC0", Offset = "0x67BC1C0", VA = "0x1867BCFC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event MGHEEHNOJLO NOBKCJFFBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x67BEB00", Offset = "0x67BDD00", VA = "0x1867BEB00", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x67BCE30", Offset = "0x67BC030", VA = "0x1867BCE30", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event BEBLGGPGHFJ BLDJHFBKICJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x67B9D00", Offset = "0x67B8F00", VA = "0x1867B9D00", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x67BDEA0", Offset = "0x67BD0A0", VA = "0x1867BDEA0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event MGHEEHNOJLO DFAPJOPCDIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x67BD920", Offset = "0x67BCB20", VA = "0x1867BD920", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x67BEB60", Offset = "0x67BDD60", VA = "0x1867BEB60", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event MGHEEHNOJLO MCFIPJHMPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x67BD200", Offset = "0x67BC400", VA = "0x1867BD200", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x67BE1B0", Offset = "0x67BD3B0", VA = "0x1867BE1B0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event MGHEEHNOJLO DKDFEBGJMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x67BBBB0", Offset = "0x67BADB0", VA = "0x1867BBBB0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x67BAE70", Offset = "0x67BA070", VA = "0x1867BAE70", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<PGDHFLLAIAB, PGDHFLLAIAB> HJIJHKADNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x67BC370", Offset = "0x67BB570", VA = "0x1867BC370", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x67BCF60", Offset = "0x67BC160", VA = "0x1867BCF60", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event MGHEEHNOJLO EMCCEHAFIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x67BCC40", Offset = "0x67BBE40", VA = "0x1867BCC40", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x67BBB50", Offset = "0x67BAD50", VA = "0x1867BBB50", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event MGHEEHNOJLO CMLAOOOKDID
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x67BD9E0", Offset = "0x67BCBE0", VA = "0x1867BD9E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x67BA200", Offset = "0x67B9400", VA = "0x1867BA200", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x67BF080", Offset = "0x67BE280", VA = "0x1867BF080")]
	public EPKAMMNFKBC(GameObject OPEBICILKJE, RigidbodyEx ONPBKHJGMMF, PFKDEAGOGFL ANAEOGBFNHN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x67BBEE0", Offset = "0x67BB0E0", VA = "0x1867BBEE0", Slot = "136")]
	protected virtual void HJBLEABFPKN(PFKDEAGOGFL ANAEOGBFNHN, BICJDOJJHMH FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x67BAC40", Offset = "0x67B9E40", VA = "0x1867BAC40", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x67B9490", Offset = "0x67B8690", VA = "0x1867B9490", Slot = "91")]
	public void ABMIDKDAPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x67BCF10", Offset = "0x67BC110", VA = "0x1867BCF10", Slot = "92")]
	public void KJLBGOBDLMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x67BBDE0", Offset = "0x67BAFE0", VA = "0x1867BBDE0", Slot = "93")]
	public void HGCNFAPLFPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x67BA990", Offset = "0x67B9B90", VA = "0x1867BA990")]
	private void DGNHAJBBJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x67BEA80", Offset = "0x67BDC80", VA = "0x1867BEA80", Slot = "30")]
	public HCDGCCECAEP PEEDFMHLIJM(int HMFNCGHECPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x67B9F90", Offset = "0x67B9190", VA = "0x1867B9F90", Slot = "95")]
	public void CFLHPBMALHN(HCDGCCECAEP NICEPFIEJED, bool BGMNOFHPMFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x67BBCD0", Offset = "0x67BAED0", VA = "0x1867BBCD0", Slot = "96")]
	public void GOMMJMMMPNA(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x67BC4A0", Offset = "0x67BB6A0", VA = "0x1867BC4A0", Slot = "97")]
	public void IFAHBEOHDON(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x67BC860", Offset = "0x67BBA60", VA = "0x1867BC860", Slot = "98")]
	public Vector3 JKEILGMCIDM(Vector3 DEPCJPCCEGP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x67BE980", Offset = "0x67BDB80", VA = "0x1867BE980", Slot = "99")]
	public Vector3 PDOGEJIDCEK(Vector3 MGKFELLKNBM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x67BCF10", Offset = "0x67BC110", VA = "0x1867BCF10", Slot = "100")]
	public void MANEBCKGDDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x67BCB10", Offset = "0x67BBD10", VA = "0x1867BCB10", Slot = "101")]
	public void JOHLBECDCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x67BBD90", Offset = "0x67BAF90", VA = "0x1867BBD90", Slot = "102")]
	public void HAFMKOKJLCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x67BE680", Offset = "0x67BD880", VA = "0x1867BE680", Slot = "103")]
	public void OPBCAKCJMIB(Vector3 FDMEDIMDJFI, Vector3 OJHACBOBKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x67BD3B0", Offset = "0x67BC5B0", VA = "0x1867BD3B0", Slot = "104")]
	public void LOHDNDLMHOO(Vector3 DHIAIOAJMJE, Vector3 IOOLPCCNOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x67BEBC0", Offset = "0x67BDDC0", VA = "0x1867BEBC0", Slot = "105")]
	public void PJDEILJPDJM(Vector3 HLNHFEOKKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x67BE0F0", Offset = "0x67BD2F0", VA = "0x1867BE0F0", Slot = "106")]
	public void OINGMABDDGL(ODFIFOEIPOB JPNLMCAHNCF, Vector3 IIJKIDIFJNO, float OPKCPNAOJLG, float ADLHHECADCN = 8f, float GGJBGFMFPBH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x67BB1E0", Offset = "0x67BA3E0", VA = "0x1867BB1E0", Slot = "107")]
	public void FFBBIPLAOEM(MCKLPPJOMOK LAEAKPFEGLK, Vector3 PNGPNDMJNGP, float GEHEKDBMGLO = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x67BDD10", Offset = "0x67BCF10", VA = "0x1867BDD10", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void NNKFGPELLFO(MCKLPPJOMOK LAEAKPFEGLK, Vector3 HBCECKEGCGH, float NKOKHDMEPJH = 7f, float IDFHKKPEKIN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x67BDB00", Offset = "0x67BCD00", VA = "0x1867BDB00", Slot = "109")]
	public Vector3 NMFIDAGOJBF(Vector3 NICEPFIEJED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x67B9E40", Offset = "0x67B9040", VA = "0x1867B9E40", Slot = "110")]
	public Vector3 CEABJHICAGI(Vector3 NICEPFIEJED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x67BD0C0", Offset = "0x67BC2C0", VA = "0x1867BD0C0", Slot = "111")]
	public void LCCEBIADBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x67BABD0", Offset = "0x67B9DD0", VA = "0x1867BABD0", Slot = "112")]
	public void DOKFGGFHMDO(HCDGCCECAEP KJBFBPNGEEG, object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x67BBC70", Offset = "0x67BAE70", VA = "0x1867BBC70", Slot = "113")]
	public void GMNNFMBMAAC(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x67BC220", Offset = "0x67BB420", VA = "0x1867BC220", Slot = "61")]
	public void HMIPLFKMHEA((Quaternion rot, Vector3 moments) PCCDIKIMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x67BE630", Offset = "0x67BD830", VA = "0x1867BE630", Slot = "114")]
	public void OMDJECHMMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x67BD4A0", Offset = "0x67BC6A0", VA = "0x1867BD4A0", Slot = "115")]
	public void LOMDLBEHMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x67BCAC0", Offset = "0x67BBCC0", VA = "0x1867BCAC0", Slot = "116")]
	public void JOHBOOBKFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x67BADD0", Offset = "0x67B9FD0", VA = "0x1867BADD0", Slot = "117")]
	public bool EDCIGFOEIPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x67BAE20", Offset = "0x67BA020", VA = "0x1867BAE20", Slot = "94")]
	public void EFMNMIEBMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x67BC550", Offset = "0x67BB750", VA = "0x1867BC550", Slot = "118")]
	public void IGFKFBEIGID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x67BA2B0", Offset = "0x67B94B0", VA = "0x1867BA2B0", Slot = "119")]
	public void CKIHJJBLEMP(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x67BBD30", Offset = "0x67BAF30", VA = "0x1867BBD30", Slot = "120")]
	public void GPHBMEFNNLI(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x67BA680", Offset = "0x67B9880", VA = "0x1867BA680", Slot = "121")]
	public void CMOHPMGOLDH(object FCKLPDKGPKE, bool PDEBHACKBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x67B9870", Offset = "0x67B8A70", VA = "0x1867B9870", Slot = "122")]
	public void AGAKJCEELFL(Vector3 JGCGPCIKADF, Quaternion KFAMAMEBBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x67BD260", Offset = "0x67BC460", VA = "0x1867BD260", Slot = "123")]
	public void LODAHKFJHLF(Vector3 DCAILIEPHOG, Quaternion MIBEENCCLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x67BAA90", Offset = "0x67B9C90", VA = "0x1867BAA90", Slot = "124")]
	public bool DLKDHMHCAPE(float FHNIBDNNPGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x67BAD10", Offset = "0x67B9F10", VA = "0x1867BAD10", Slot = "125")]
	public void EABMDPMPNDC(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x67BC5F0", Offset = "0x67BB7F0", VA = "0x1867BC5F0", Slot = "126")]
	public void JBNOLFEOKIP(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x67BCE90", Offset = "0x67BC090", VA = "0x1867BCE90", Slot = "127")]
	public void KHEHMGDAINE(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x67BD5F0", Offset = "0x67BC7F0", VA = "0x1867BD5F0", Slot = "128")]
	public void MBIBPFFCOBC(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x67BBE00", Offset = "0x67BB000", VA = "0x1867BBE00", Slot = "129")]
	public void HJAMKJNKGOF(Vector3 FCLAIJBMLJG, ForceMode OAEDCOGNIMA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x67BC960", Offset = "0x67BBB60", VA = "0x1867BC960", Slot = "130")]
	public void JKIBLHBEEPO(Vector3 FCLAIJBMLJG, Vector3 DHMMMGDKPCG, ForceMode OAEDCOGNIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x67BDFB0", Offset = "0x67BD1B0", VA = "0x1867BDFB0", Slot = "131")]
	public void OFMNNELFOAF(Vector3 BCBAKMNPAGJ, ForceMode OAEDCOGNIMA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x67BE390", Offset = "0x67BD590", VA = "0x1867BE390", Slot = "132")]
	public void OLEFEGOKGDN(Vector3 BCBAKMNPAGJ, ForceMode OAEDCOGNIMA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x67BB8A0", Offset = "0x67BAAA0", VA = "0x1867BB8A0", Slot = "133")]
	public bool FPAFMIKNLGH(Vector3 ILKFGPOHBIP, [Out] RaycastHit CMMBAEFAAGG, float HJPKMNIGHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x67BC500", Offset = "0x67BB700", VA = "0x1867BC500", Slot = "134")]
	public void IFIADBNNDNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x67BF040", Offset = "0x67BE240", VA = "0x1867BF040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x67BBA70", Offset = "0x67BAC70", VA = "0x1867BBA70")]
	private void GBOCEHFBPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x67BDC00", Offset = "0x67BCE00", VA = "0x1867BDC00")]
	private void NMPOLBADGOK(HCDGCCECAEP BHNONFFBKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x67BD650", Offset = "0x67BC850", VA = "0x1867BD650")]
	private void MGHDCNPDNIG(HCDGCCECAEP BHNONFFBKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x67BA000", Offset = "0x67B9200", VA = "0x1867BA000")]
	private void CGBHHLHAGIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x67BB010", Offset = "0x67BA210", VA = "0x1867BB010")]
	private void FDOGCIONDPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x67BE210", Offset = "0x67BD410", VA = "0x1867BE210")]
	private void OLAAIBEGBNK(HCDGCCECAEP OHOCCJEHNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x67BB110", Offset = "0x67BA310", VA = "0x1867BB110")]
	private void FENPMLIEDAM(HCDGCCECAEP BHNONFFBKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x67BC790", Offset = "0x67BB990", VA = "0x1867BC790")]
	private void JHMFENIIABB(HCDGCCECAEP BHNONFFBKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x67BE7C0", Offset = "0x67BD9C0", VA = "0x1867BE7C0")]
	private void PBCDOALFEKN(IHMHPNACLKD BHNONFFBKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x67B90D0", Offset = "0x67B82D0", VA = "0x1867B90D0", Slot = "141")]
	protected virtual void ABLGCCJBKLJ(IHMHPNACLKD PIGCCDNLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x67BB320", Offset = "0x67BA520", VA = "0x1867BB320")]
	protected void FHHNGIIJDBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x67BA310", Offset = "0x67B9510", VA = "0x1867BA310")]
	protected void CMAOLIIJJBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x67BB720", Offset = "0x67BA920", VA = "0x1867BB720", Slot = "142")]
	protected virtual IDisposable FMPIOKLJCPD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class OFLAKNMNKKA
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x67C8830", Offset = "0x67C7A30", VA = "0x1867C8830")]
	public static HCDGCCECAEP JKBMANJBNCK(this HCDGCCECAEP PIGCCDNLNPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x67C8730", Offset = "0x67C7930", VA = "0x1867C8730")]
	public static bool DGPJBCPHHAE(this HCDGCCECAEP PIGCCDNLNPO, HCDGCCECAEP NLHIBFMIJEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x67C8940", Offset = "0x67C7B40", VA = "0x1867C8940")]
	public static bool LOIOODMPFEI(this HCDGCCECAEP PIGCCDNLNPO, HCDGCCECAEP LGINMEFPPOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x67C88F0", Offset = "0x67C7AF0", VA = "0x1867C88F0")]
	public static IHMHPNACLKD LLDAICJGFOP(this HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x67C87B0", Offset = "0x67C79B0", VA = "0x1867C87B0")]
	public static EPKAMMNFKBC IGAHIJICEHN(this HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CHPFFPGOHIE : FPLNBHPGIAL
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x67B3F70", Offset = "0x67B3170", VA = "0x1867B3F70", Slot = "19")]
	public HCDGCCECAEP BFDOMBBIDNA(RigidbodyEx PIGCCDNLNPO, BICJDOJJHMH FODGEDCJIDC, PFKDEAGOGFL ANAEOGBFNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "4")]
	public CNMPIDLEHJM GBADCIOACDE(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "5")]
	public OOEEACLPHBP FMBFDKHFPCH(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "6")]
	public APMNNOJOMOB LPJDNBCALED(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "7")]
	public PLBINDHECDI MLEHHLBPOBH(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "8")]
	public PDKHMONANLE GLBOFIKGLEA(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "9")]
	public JFFEDLDCMCH EFHGFDIDGEA(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "10")]
	public IBJDONNOHKJ BOOCHCGKFFE(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "11")]
	public BLOMGPJBBOI NMICJBJCLGC(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "12")]
	public JFGCFIIGCDA GAFGALEGDGL(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "13")]
	public MCNJPKDDKEA FMBPIOBALAA(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0")]
	public LFIPGIIPODB DIBFFNALELJ(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0")]
	public HKMPCONONPD GAOGALCAMPM(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0")]
	public EHHIJPJOBCA ENKIAGAPFGE(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0")]
	public MCDEHABHJGH JHEAGDGBDMK(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0")]
	public INABINDBFIK KBKDIIDLGFE(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public CHPFFPGOHIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "14")]
	private LFIPGIIPODB INNKJLPIIMA(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "15")]
	private HKMPCONONPD MNHPOPKKOBH(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "16")]
	private EHHIJPJOBCA KHFMMDJPBLN(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "17")]
	private MCDEHABHJGH AJOKMCEFAIE(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "18")]
	private INABINDBFIK MHHMEGLKALA(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[HGCGALFKODL(typeof(FPLNBHPGIAL), new string[] { })]
public class DMKNOIHNHMC : FPLNBHPGIAL, BKCFFAPDBPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly FPLNBHPGIAL PIANBOJMGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly FPLNBHPGIAL ACACPAMHNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private LCCCJGOFHBF NJHOMAGMEKE;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private FPLNBHPGIAL JJFHBPGHLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x67B7F90", Offset = "0x67B7190", VA = "0x1867B7F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x67B7FF0", Offset = "0x67B71F0", VA = "0x1867B7FF0", Slot = "20")]
	public void InitReferences(CKDGHLLENBO LIHCLMFINBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x67B7E50", Offset = "0x67B7050", VA = "0x1867B7E50", Slot = "4")]
	public CNMPIDLEHJM GBADCIOACDE(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x67B7BC0", Offset = "0x67B6DC0", VA = "0x1867B7BC0", Slot = "5")]
	public OOEEACLPHBP FMBFDKHFPCH(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x67B80F0", Offset = "0x67B72F0", VA = "0x1867B80F0", Slot = "6")]
	public APMNNOJOMOB LPJDNBCALED(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x67B8190", Offset = "0x67B7390", VA = "0x1867B8190", Slot = "7")]
	public PLBINDHECDI MLEHHLBPOBH(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x67B7EF0", Offset = "0x67B70F0", VA = "0x1867B7EF0", Slot = "8")]
	public PDKHMONANLE GLBOFIKGLEA(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x67B7A70", Offset = "0x67B6C70", VA = "0x1867B7A70", Slot = "9")]
	public JFFEDLDCMCH EFHGFDIDGEA(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x67B7920", Offset = "0x67B6B20", VA = "0x1867B7920", Slot = "10")]
	public IBJDONNOHKJ BOOCHCGKFFE(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x67B8230", Offset = "0x67B7430", VA = "0x1867B8230", Slot = "11")]
	public BLOMGPJBBOI NMICJBJCLGC(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x67B7D00", Offset = "0x67B6F00", VA = "0x1867B7D00", Slot = "12")]
	public JFGCFIIGCDA GAFGALEGDGL(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x67B7C60", Offset = "0x67B6E60", VA = "0x1867B7C60", Slot = "13")]
	public MCNJPKDDKEA FMBPIOBALAA(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x67B79C0", Offset = "0x67B6BC0", VA = "0x1867B79C0")]
	public LFIPGIIPODB DIBFFNALELJ(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x67B7DA0", Offset = "0x67B6FA0", VA = "0x1867B7DA0")]
	public HKMPCONONPD GAOGALCAMPM(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x67B7B10", Offset = "0x67B6D10", VA = "0x1867B7B10")]
	public EHHIJPJOBCA ENKIAGAPFGE(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x67B7790", Offset = "0x67B6990", VA = "0x1867B7790")]
	public MCDEHABHJGH JHEAGDGBDMK(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x67B8040", Offset = "0x67B7240", VA = "0x1867B8040")]
	public INABINDBFIK KBKDIIDLGFE(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x67B7840", Offset = "0x67B6A40", VA = "0x1867B7840", Slot = "19")]
	public HCDGCCECAEP BFDOMBBIDNA(RigidbodyEx PIGCCDNLNPO, BICJDOJJHMH FODGEDCJIDC, PFKDEAGOGFL ANAEOGBFNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x67B82D0", Offset = "0x67B74D0", VA = "0x1867B82D0")]
	public DMKNOIHNHMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x67B79C0", Offset = "0x67B6BC0", VA = "0x1867B79C0", Slot = "14")]
	private LFIPGIIPODB INNKJLPIIMA(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x67B7DA0", Offset = "0x67B6FA0", VA = "0x1867B7DA0", Slot = "15")]
	private HKMPCONONPD MNHPOPKKOBH(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x67B7B10", Offset = "0x67B6D10", VA = "0x1867B7B10", Slot = "16")]
	private EHHIJPJOBCA KHFMMDJPBLN(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x67B7790", Offset = "0x67B6990", VA = "0x1867B7790", Slot = "17")]
	private MCDEHABHJGH AJOKMCEFAIE(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x67B8040", Offset = "0x67B7240", VA = "0x1867B8040", Slot = "18")]
	private INABINDBFIK MHHMEGLKALA(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface CLBFHCAJPID : CNMPIDLEHJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIMOOLAODCJ(HCDGCCECAEP PIGCCDNLNPO);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIOAHDHBHDM(HCDGCCECAEP PIGCCDNLNPO);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GKKHMNBJNDH(HCDGCCECAEP OHOCCJEHNAI);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LMMCNIBFCKF(HCDGCCECAEP OHOCCJEHNAI);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EPKIFPBHCGG : APMNNOJOMOB
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	EFFKGKGGADI<HCDGCCECAEP> MJEOPCLLNOL
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	HCDGCCECAEP DFDHLEMLNJL
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MLDKPGDJBEL : MCDEHABHJGH
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) HCIPBNGEEKA(Rigidbody LMGPPGIACHI);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BGCCGIFGOKN : HKMPCONONPD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView LDCNPOFOMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class BGDNJOLOEEN : JFGCFIIGCDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly EPKAMMNFKBC PIGCCDNLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode BEDEEBDNMFM;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody FLEDBGNMPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x67B3B00", Offset = "0x67B2D00", VA = "0x1867B3B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode GKMIBJKCABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x67B39F0", Offset = "0x67B2BF0", VA = "0x1867B39F0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x67B3E70", Offset = "0x67B3070", VA = "0x1867B3E70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x67B3EE0", Offset = "0x67B30E0", VA = "0x1867B3EE0")]
	public BGDNJOLOEEN(HCDGCCECAEP PIGCCDNLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x67B38E0", Offset = "0x67B2AE0", VA = "0x1867B38E0", Slot = "6")]
	public void ABMIDKDAPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x67B3B60", Offset = "0x67B2D60", VA = "0x1867B3B60", Slot = "9")]
	public void FCHNLNGIIAP(Rigidbody PDECCLFHGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x67B3D40", Offset = "0x67B2F40", VA = "0x1867B3D40", Slot = "7")]
	public void MENNJOCODBP(bool CLJGIKNNNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x67B3B50", Offset = "0x67B2D50", VA = "0x1867B3B50", Slot = "8")]
	public void EMAIDKNBKLA(bool CLJGIKNNNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x67B3BE0", Offset = "0x67B2DE0", VA = "0x1867B3BE0", Slot = "10")]
	public bool FPAFMIKNLGH(Vector3 ILKFGPOHBIP, [Out] RaycastHit CMMBAEFAAGG, float HJPKMNIGHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x67B3D50", Offset = "0x67B2F50", VA = "0x1867B3D50")]
	private void NJOOIBLADGG(bool CLJGIKNNNMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DDGJIFDJKJC : JFFEDLDCMCH, IDisposable, EKCFFCDIJFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly EPKAMMNFKBC PIGCCDNLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private GPHAHJNAAFN FIBDBCJDKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private EOMKGELPLCG DMKFOPKPEMO;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GPHAHJNAAFN CNDJCFNOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x67B64C0", Offset = "0x67B56C0", VA = "0x1867B64C0", Slot = "6")]
		get
		{
			return default(GPHAHJNAAFN);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x67B6340", Offset = "0x67B5540", VA = "0x1867B6340", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform BEAPPAELGGO
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x67B62D0", Offset = "0x67B54D0", VA = "0x1867B62D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<PGDHFLLAIAB, PGDHFLLAIAB> HJIJHKADNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x67B6410", Offset = "0x67B5610", VA = "0x1867B6410", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x67B6610", Offset = "0x67B5810", VA = "0x1867B6610", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x67B66C0", Offset = "0x67B58C0", VA = "0x1867B66C0")]
	public DDGJIFDJKJC(HCDGCCECAEP PIGCCDNLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x67B6050", Offset = "0x67B5250", VA = "0x1867B6050", Slot = "8")]
	public void ABMIDKDAPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x67B62F0", Offset = "0x67B54F0", VA = "0x1867B62F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x820B10", Offset = "0x81FD10", VA = "0x180820B10", Slot = "11")]
	private void NPLADMOOLGD(PGDHFLLAIAB OILNEMBFDML, PGDHFLLAIAB KOADIGAEKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "12")]
	private void OFIBEHNOHKO(bool BIHAIGGADAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FBLLHLIOBDE : FPLNBHPGIAL
{
	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x67C2670", Offset = "0x67C1870", VA = "0x1867C2670", Slot = "4")]
	public CNMPIDLEHJM GBADCIOACDE(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x67C2230", Offset = "0x67C1430", VA = "0x1867C2230", Slot = "5")]
	public OOEEACLPHBP FMBFDKHFPCH(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x67C2910", Offset = "0x67C1B10", VA = "0x1867C2910", Slot = "6")]
	public APMNNOJOMOB LPJDNBCALED(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x67C2A40", Offset = "0x67C1C40", VA = "0x1867C2A40", Slot = "7")]
	public PLBINDHECDI MLEHHLBPOBH(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x67C2760", Offset = "0x67C1960", VA = "0x1867C2760", Slot = "8")]
	public PDKHMONANLE GLBOFIKGLEA(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x67C2030", Offset = "0x67C1230", VA = "0x1867C2030", Slot = "9")]
	public JFFEDLDCMCH EFHGFDIDGEA(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x67C1DD0", Offset = "0x67C0FD0", VA = "0x1867C1DD0", Slot = "10")]
	public IBJDONNOHKJ BOOCHCGKFFE(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x67C2AC0", Offset = "0x67C1CC0", VA = "0x1867C2AC0", Slot = "11")]
	public BLOMGPJBBOI NMICJBJCLGC(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x67C2420", Offset = "0x67C1620", VA = "0x1867C2420", Slot = "12")]
	public JFGCFIIGCDA GAFGALEGDGL(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x67C2360", Offset = "0x67C1560", VA = "0x1867C2360", Slot = "13")]
	public MCNJPKDDKEA FMBPIOBALAA(HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x67C1EF0", Offset = "0x67C10F0", VA = "0x1867C1EF0")]
	public LFIPGIIPODB DIBFFNALELJ(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x67C24E0", Offset = "0x67C16E0", VA = "0x1867C24E0")]
	public HKMPCONONPD GAOGALCAMPM(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x67C2100", Offset = "0x67C1300", VA = "0x1867C2100")]
	public EHHIJPJOBCA ENKIAGAPFGE(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x67C1B20", Offset = "0x67C0D20", VA = "0x1867C1B20")]
	public MCDEHABHJGH JHEAGDGBDMK(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x67C2830", Offset = "0x67C1A30", VA = "0x1867C2830")]
	public INABINDBFIK KBKDIIDLGFE(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x67C1CB0", Offset = "0x67C0EB0", VA = "0x1867C1CB0", Slot = "19")]
	public HCDGCCECAEP BFDOMBBIDNA(RigidbodyEx PIGCCDNLNPO, BICJDOJJHMH FODGEDCJIDC, PFKDEAGOGFL ANAEOGBFNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public FBLLHLIOBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x67C1EF0", Offset = "0x67C10F0", VA = "0x1867C1EF0", Slot = "14")]
	private LFIPGIIPODB INNKJLPIIMA(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x67C24E0", Offset = "0x67C16E0", VA = "0x1867C24E0", Slot = "15")]
	private HKMPCONONPD MNHPOPKKOBH(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x67C2100", Offset = "0x67C1300", VA = "0x1867C2100", Slot = "16")]
	private EHHIJPJOBCA KHFMMDJPBLN(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x67C1B20", Offset = "0x67C0D20", VA = "0x1867C1B20", Slot = "17")]
	private MCDEHABHJGH AJOKMCEFAIE(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x67C2830", Offset = "0x67C1A30", VA = "0x1867C2830", Slot = "18")]
	private INABINDBFIK MHHMEGLKALA(HCDGCCECAEP PFGBPGKFOLN, [In] BICJDOJJHMH FODGEDCJIDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class DFODDPDBFME : BLOMGPJBBOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly EPKAMMNFKBC PIGCCDNLNPO;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody FLEDBGNMPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x67B3B00", Offset = "0x67B2D00", VA = "0x1867B3B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool CCEEOOAEGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x67B6750", Offset = "0x67B5950", VA = "0x1867B6750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool MEHFEOAECPP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x67B67A0", Offset = "0x67B59A0", VA = "0x1867B67A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private HCDGCCECAEP ANNFPHELCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x67B6BC0", Offset = "0x67B5DC0", VA = "0x1867B6BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x67B3EE0", Offset = "0x67B30E0", VA = "0x1867B3EE0")]
	public DFODDPDBFME(HCDGCCECAEP PIGCCDNLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x67B6A60", Offset = "0x67B5C60", VA = "0x1867B6A60", Slot = "4")]
	public void HJAMKJNKGOF(Vector3 FCLAIJBMLJG, ForceMode OAEDCOGNIMA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x67B6800", Offset = "0x67B5A00", VA = "0x1867B6800")]
	private void FJIBOKFIONG(Vector3 FCLAIJBMLJG, ForceMode OAEDCOGNIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x67B6C20", Offset = "0x67B5E20", VA = "0x1867B6C20", Slot = "5")]
	public void JKIBLHBEEPO(Vector3 FCLAIJBMLJG, Vector3 DHMMMGDKPCG, ForceMode OAEDCOGNIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x67B7100", Offset = "0x67B6300", VA = "0x1867B7100", Slot = "6")]
	public void OFMNNELFOAF(Vector3 BCBAKMNPAGJ, ForceMode OAEDCOGNIMA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x67B6EA0", Offset = "0x67B60A0", VA = "0x1867B6EA0")]
	private void KDJLPCCDEKD(Vector3 BCBAKMNPAGJ, ForceMode OAEDCOGNIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x67B7260", Offset = "0x67B6460", VA = "0x1867B7260", Slot = "7")]
	public void OLEFEGOKGDN(Vector3 BCBAKMNPAGJ, ForceMode OAEDCOGNIMA = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class NBEOCKOHDNE : MCNJPKDDKEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly EPKAMMNFKBC PIGCCDNLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool PCPNPPPIDOE;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool GKIDIPKJAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x85F3E0", Offset = "0x85E5E0", VA = "0x18085F3E0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x67C8620", Offset = "0x67C7820", VA = "0x1867C8620", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x67B3EE0", Offset = "0x67B30E0", VA = "0x1867B3EE0")]
	public NBEOCKOHDNE(HCDGCCECAEP PIGCCDNLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x67C8580", Offset = "0x67C7780", VA = "0x1867C8580", Slot = "6")]
	public void FCHNLNGIIAP(Rigidbody PDECCLFHGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x67C85B0", Offset = "0x67C77B0", VA = "0x1867C85B0", Slot = "7")]
	public void KODKJGCPPBI(Rigidbody PDECCLFHGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class CIGOKEILMFE : CLBFHCAJPID, CNMPIDLEHJM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly HCDGCCECAEP PIGCCDNLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<HCDGCCECAEP> ADAJDPKLMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private HCDGCCECAEP MIAAKEAGJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private HCDGCCECAEP BHNONFFBKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform ILDHJMLJJPO;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform BHIBJBFFJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x67B5340", Offset = "0x67B4540", VA = "0x1867B5340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public HCDGCCECAEP ANNFPHELCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CC0", Offset = "0x7B7EC0", VA = "0x1807B8CC0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x67B5AC0", Offset = "0x67B4CC0", VA = "0x1867B5AC0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public HCDGCCECAEP AKJHKAMODFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D10", Offset = "0x7B7F10", VA = "0x1807B8D10", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<HCDGCCECAEP> MOPDBBJCFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CB0", Offset = "0x7B7EB0", VA = "0x1807B8CB0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event MGHEEHNOJLO FNMAGHNOFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x67B4A10", Offset = "0x67B3C10", VA = "0x1867B4A10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x67B5500", Offset = "0x67B4700", VA = "0x1867B5500", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event MGHEEHNOJLO NOBKCJFFBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x67B5CA0", Offset = "0x67B4EA0", VA = "0x1867B5CA0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x67B53A0", Offset = "0x67B45A0", VA = "0x1867B53A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event BEBLGGPGHFJ BLDJHFBKICJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x67B4350", Offset = "0x67B3550", VA = "0x1867B4350", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x67B5A20", Offset = "0x67B4C20", VA = "0x1867B5A20", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action DIABPFDPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x67B42B0", Offset = "0x67B34B0", VA = "0x1867B42B0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x67B4BA0", Offset = "0x67B3DA0", VA = "0x1867B4BA0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action CHLHEIJHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x67B52A0", Offset = "0x67B44A0", VA = "0x1867B52A0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x67B40C0", Offset = "0x67B32C0", VA = "0x1867B40C0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<HCDGCCECAEP> LIGCCNFECCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x67B4160", Offset = "0x67B3360", VA = "0x1867B4160", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x67B5D40", Offset = "0x67B4F40", VA = "0x1867B5D40", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<HCDGCCECAEP> KGNCIDAAMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x67B5BF0", Offset = "0x67B4DF0", VA = "0x1867B5BF0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x67B4010", Offset = "0x67B3210", VA = "0x1867B4010", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action BAIDDIMCGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x67B5160", Offset = "0x67B4360", VA = "0x1867B5160", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x67B58D0", Offset = "0x67B4AD0", VA = "0x1867B58D0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<HCDGCCECAEP> GAHCOEJMDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x67B55A0", Offset = "0x67B47A0", VA = "0x1867B55A0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x67B5970", Offset = "0x67B4B70", VA = "0x1867B5970", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x67B5DF0", Offset = "0x67B4FF0", VA = "0x1867B5DF0")]
	public CIGOKEILMFE(HCDGCCECAEP PIGCCDNLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x67B4970", Offset = "0x67B3B70", VA = "0x1867B4970", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x67B43F0", Offset = "0x67B35F0", VA = "0x1867B43F0", Slot = "30")]
	public void CFLHPBMALHN(HCDGCCECAEP MHAMFGHDGFA, bool BGMNOFHPMFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x67B4C40", Offset = "0x67B3E40", VA = "0x1867B4C40", Slot = "6")]
	public void GKKHMNBJNDH(HCDGCCECAEP OHOCCJEHNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x67B5650", Offset = "0x67B4850", VA = "0x1867B5650", Slot = "7")]
	public void LMMCNIBFCKF(HCDGCCECAEP OHOCCJEHNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x67B4AB0", Offset = "0x67B3CB0", VA = "0x1867B4AB0", Slot = "4")]
	public void EIMOOLAODCJ(HCDGCCECAEP PIGCCDNLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x67B5200", Offset = "0x67B4400", VA = "0x1867B5200", Slot = "5")]
	public void IIOAHDHBHDM(HCDGCCECAEP PIGCCDNLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x67B4210", Offset = "0x67B3410", VA = "0x1867B4210")]
	private void ALDMCLKOCNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x67B4EB0", Offset = "0x67B40B0", VA = "0x1867B4EB0")]
	private void GMNNFIGECBK(HCDGCCECAEP OHOCCJEHNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x67B5020", Offset = "0x67B4220", VA = "0x1867B5020")]
	private void HLCCKNCDPEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x67B4EF0", Offset = "0x67B40F0", VA = "0x1867B4EF0")]
	private void HHECGKAAALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x67B5AD0", Offset = "0x67B4CD0", VA = "0x1867B5AD0")]
	private void OGHGDJIKBOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x67B5440", Offset = "0x67B4640", VA = "0x1867B5440")]
	[CompilerGenerated]
	private object KLCEKGAHPAH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class KCIIFIMGDJN
{
	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x67C6510", Offset = "0x67C5710", VA = "0x1867C6510")]
	public static CLBFHCAJPID EGEOJFLJNFD(this HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class PKGJMMJMPIG : EPKIFPBHCGG, APMNNOJOMOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly EPKAMMNFKBC PIGCCDNLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly EFFKGKGGADI<HCDGCCECAEP> BJDAPDOGIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool NIAPGAHCKEC;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public EFFKGKGGADI<HCDGCCECAEP> MJEOPCLLNOL
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 OKKAABABFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x67C94C0", Offset = "0x67C86C0", VA = "0x1867C94C0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 NPHAPCACINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x67C98E0", Offset = "0x67C8AE0", VA = "0x1867C98E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 JPCJHLPMEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x67C9BC0", Offset = "0x67C8DC0", VA = "0x1867C9BC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public HCDGCCECAEP DFDHLEMLNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x67C9B10", Offset = "0x67C8D10", VA = "0x1867C9B10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x67CA040", Offset = "0x67C9240", VA = "0x1867CA040")]
	public PKGJMMJMPIG(HCDGCCECAEP PIGCCDNLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x67C9AA0", Offset = "0x67C8CA0", VA = "0x1867C9AA0", Slot = "8")]
	public void HPNNFMKFCIG(HCDGCCECAEP BHNONFFBKHO, object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x67C94F0", Offset = "0x67C86F0", VA = "0x1867C94F0", Slot = "9")]
	public void ANJNGDGBOIB(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x67C9550", Offset = "0x67C8750", VA = "0x1867C9550")]
	private Vector3 DMDLJHGNFPM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x67C9CB0", Offset = "0x67C8EB0", VA = "0x1867C9CB0")]
	private void PJBHMDMCMFH(HCDGCCECAEP BFGJIKOEIJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class ADNOEOFPLBC
{
	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x67B3820", Offset = "0x67B2A20", VA = "0x1867B3820")]
	public static EPKIFPBHCGG JJOLGDEHCNG(this HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class EPNPJJNBMBB : MLDKPGDJBEL, MCDEHABHJGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly EPKAMMNFKBC PIGCCDNLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 FKMCDAMJKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 MNGMGGGOAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float IKALNGDHJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float LGLDCHHCDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 JOFLKGACMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? JOOIMGMBBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? HMLJOKKHKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool FBDILKODIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool PPFNMABIGJK;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 CJACLIKLAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xC1D090", Offset = "0xC1C290", VA = "0x180C1D090", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x67BF1A0", Offset = "0x67BE3A0", VA = "0x1867BF1A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 BGMIGEKMIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x67C13E0", Offset = "0x67C05E0", VA = "0x1867C13E0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float KHKDBEGDKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1261690", Offset = "0x1260890", VA = "0x181261690", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x67C14E0", Offset = "0x67C06E0", VA = "0x1867C14E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float DHGDJCEHBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xC7BA80", Offset = "0xC7AC80", VA = "0x180C7BA80", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x67C0EB0", Offset = "0x67C00B0", VA = "0x1867C0EB0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 EDGGKDBKLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x67BF3D0", Offset = "0x67BE5D0", VA = "0x1867BF3D0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion AKMHFFBBAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x67C1840", Offset = "0x67C0A40", VA = "0x1867C1840", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody FLEDBGNMPOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x67BF150", Offset = "0x67BE350", VA = "0x1867BF150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event MGHEEHNOJLO DKLFDBJDIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x67C15F0", Offset = "0x67C07F0", VA = "0x1867C15F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x67BF640", Offset = "0x67BE840", VA = "0x1867BF640", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x67C19C0", Offset = "0x67C0BC0", VA = "0x1867C19C0")]
	public EPNPJJNBMBB(HCDGCCECAEP PIGCCDNLNPO, [In] BICJDOJJHMH FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x67C1690", Offset = "0x67C0890", VA = "0x1867C1690", Slot = "17")]
	public void OMDJECHMMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x67C1300", Offset = "0x67C0500", VA = "0x1867C1300", Slot = "16")]
	public void LOMDLBEHMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x67BF560", Offset = "0x67BE760", VA = "0x1867BF560", Slot = "19")]
	public void FCHNLNGIIAP(Rigidbody PDECCLFHGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x67C1110", Offset = "0x67C0310", VA = "0x1867C1110", Slot = "20")]
	public void KODKJGCPPBI(Rigidbody PDECCLFHGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x67C0F60", Offset = "0x67C0160", VA = "0x1867C0F60", Slot = "18")]
	public void JOHBOOBKFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x67C0920", Offset = "0x67BFB20", VA = "0x1867C0920", Slot = "21")]
	public void IFIADBNNDNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x67BF1A0", Offset = "0x67BE3A0", VA = "0x1867BF1A0")]
	private void PMCLOBIMMCK(Vector3 NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x67C0DC0", Offset = "0x67BFFC0", VA = "0x1867C0DC0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 JDCOKNELEGB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x67C14E0", Offset = "0x67C06E0", VA = "0x1867C14E0")]
	private void ODJAJGFBMDD(float NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x67C0EB0", Offset = "0x67C00B0", VA = "0x1867C0EB0")]
	private void JKAPACFBBGJ(float NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x67C0780", Offset = "0x67BF980", VA = "0x1867C0780")]
	private Vector3 HNGJPCCLKEO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x67C0550", Offset = "0x67BF750", VA = "0x1867C0550", Slot = "15")]
	public void HMIPLFKMHEA((Quaternion rot, Vector3 moments) PCCDIKIMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x67BF250", Offset = "0x67BE450", VA = "0x1867BF250")]
	private Quaternion DJGMDMFPOAC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x67BF6E0", Offset = "0x67BE8E0", VA = "0x1867BF6E0")]
	public void HCIPBNGEEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x67BF7B0", Offset = "0x67BE9B0", VA = "0x1867BF7B0", Slot = "4")]
	public (float, Vector3) HCIPBNGEEKA(Rigidbody LMGPPGIACHI)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class GGIPIOHMACP
{
	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x67C2C40", Offset = "0x67C1E40", VA = "0x1867C2C40")]
	public static MLDKPGDJBEL EKPOONCGMPL(this HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class MPCKJODFKAB : EHHIJPJOBCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly EPKAMMNFKBC PIGCCDNLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly NFAPFDEEOME BICANBHMALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly ANOFOMAGMPD JMKNFJCECHO;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool AJMOCCHCAOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xDB4C10", Offset = "0xDB3E10", VA = "0x180DB4C10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public ANOFOMAGMPD GPFBBJKAKFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x821ED0", Offset = "0x8210D0", VA = "0x180821ED0", Slot = "11")]
		get
		{
			return default(ANOFOMAGMPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x67C8480", Offset = "0x67C7680", VA = "0x1867C8480")]
	public MPCKJODFKAB(HCDGCCECAEP PIGCCDNLNPO, [In] BICJDOJJHMH FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x67C7E80", Offset = "0x67C7080", VA = "0x1867C7E80", Slot = "4")]
	public void ABMIDKDAPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x67C8090", Offset = "0x67C7290", VA = "0x1867C8090")]
	private bool EABEJFEHCMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x67C8060", Offset = "0x67C7260", VA = "0x1867C8060", Slot = "5")]
	public void CDGCGCOGMBH(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x67C82E0", Offset = "0x67C74E0", VA = "0x1867C82E0", Slot = "6")]
	public void MKKFGOHEECP(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x67C8350", Offset = "0x67C7550", VA = "0x1867C8350", Slot = "9")]
	public void PAGBALFNAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x67C7F50", Offset = "0x67C7150", VA = "0x1867C7F50")]
	private void BDHFDJEHIOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x67C8170", Offset = "0x67C7370", VA = "0x1867C8170")]
	private void JGBDCCPAPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x67C8130", Offset = "0x67C7330", VA = "0x1867C8130", Slot = "8")]
	public void EAHLJDNDEIP(HCDGCCECAEP PIGCCDNLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x67C8310", Offset = "0x67C7510", VA = "0x1867C8310", Slot = "7")]
	public void NPLFDACLOBO(HCDGCCECAEP PIGCCDNLNPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class MJHNFGICGLD : IBJDONNOHKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly EPKAMMNFKBC PIGCCDNLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly NFAPFDEEOME DMLAFDPLEFF;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool CCEEOOAEGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x67C7980", Offset = "0x67C6B80", VA = "0x1867C7980", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event MGHEEHNOJLO EMCCEHAFIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x67C7CC0", Offset = "0x67C6EC0", VA = "0x1867C7CC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x67C7BD0", Offset = "0x67C6DD0", VA = "0x1867C7BD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x67C7D90", Offset = "0x67C6F90", VA = "0x1867C7D90")]
	public MJHNFGICGLD(HCDGCCECAEP PIGCCDNLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x67C7A30", Offset = "0x67C6C30", VA = "0x1867C7A30", Slot = "7")]
	public void CKIHJJBLEMP(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x67C7C70", Offset = "0x67C6E70", VA = "0x1867C7C70", Slot = "8")]
	public void GPHBMEFNNLI(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x67C7A40", Offset = "0x67C6C40", VA = "0x1867C7A40", Slot = "9")]
	public void CMOHPMGOLDH(object FCKLPDKGPKE, bool PDEBHACKBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x67C7C80", Offset = "0x67C6E80", VA = "0x1867C7C80", Slot = "12")]
	public void JFEGHLNKHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x67C7B50", Offset = "0x67C6D50", VA = "0x1867C7B50", Slot = "10")]
	public void FCHNLNGIIAP(Rigidbody LAANOCCOMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x67C7D60", Offset = "0x67C6F60", VA = "0x1867C7D60", Slot = "11")]
	public void KODKJGCPPBI(Rigidbody PDECCLFHGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class DPNOMKCBOAF : BGCCGIFGOKN, HKMPCONONPD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly EPKAMMNFKBC PIGCCDNLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView MMBOHDDPJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool ONOHGBONCDK;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView LDCNPOFOMMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool GIFOIMPOILG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x67B84B0", Offset = "0x67B76B0", VA = "0x1867B84B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool HBONMENFLEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x90D2F0", Offset = "0x90C4F0", VA = "0x18090D2F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event MGHEEHNOJLO DFAPJOPCDIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x67B88B0", Offset = "0x67B7AB0", VA = "0x1867B88B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x67B8E80", Offset = "0x67B8080", VA = "0x1867B8E80", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x67B8F20", Offset = "0x67B8120", VA = "0x1867B8F20")]
	public DPNOMKCBOAF(HCDGCCECAEP PIGCCDNLNPO, [In] BICJDOJJHMH FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x67B8380", Offset = "0x67B7580", VA = "0x1867B8380", Slot = "9")]
	public void ABMIDKDAPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x67B84D0", Offset = "0x67B76D0", VA = "0x1867B84D0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x67B85D0", Offset = "0x67B77D0", VA = "0x1867B85D0", Slot = "10")]
	public void FENPMLIEDAM(HCDGCCECAEP BHNONFFBKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x67B8740", Offset = "0x67B7940", VA = "0x1867B8740", Slot = "11")]
	public void JHMFENIIABB(HCDGCCECAEP BHNONFFBKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x67B8950", Offset = "0x67B7B50", VA = "0x1867B8950")]
	private void NMDKKIKCLFF(PhotonView OLKLEDADFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x67B8D30", Offset = "0x67B7F30", VA = "0x1867B8D30")]
	private void OMKLPMPOKKD(IHMHPNACLKD ALLJKFIIIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x67B8AC0", Offset = "0x67B7CC0", VA = "0x1867B8AC0")]
	private void OBMDOPIJIDH(PhotonView DLGIMNFPJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class FPFNLBPIBNJ
{
	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x67C2B80", Offset = "0x67C1D80", VA = "0x1867C2B80")]
	public static BGCCGIFGOKN BEPAMMOMDFL(this HCDGCCECAEP PFGBPGKFOLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class KNLDCDEIDFC : INABINDBFIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly EPKAMMNFKBC PIGCCDNLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints LAHLNEAOJKI;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool DOGPMNAPHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xB86CC0", Offset = "0xB85EC0", VA = "0x180B86CC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x3FD9E60", Offset = "0x3FD9060", VA = "0x183FD9E60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool NGJPOAKODON
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xE061F0", Offset = "0xE053F0", VA = "0x180E061F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x3FD9E50", Offset = "0x3FD9050", VA = "0x183FD9E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints HHECACDFAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C1090", Offset = "0x7C0290", VA = "0x1807C1090", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x67C6600", Offset = "0x67C5800", VA = "0x1867C6600", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x67C6760", Offset = "0x67C5960", VA = "0x1867C6760")]
	public KNLDCDEIDFC(HCDGCCECAEP PIGCCDNLNPO, [In] BICJDOJJHMH FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x67C65D0", Offset = "0x67C57D0", VA = "0x1867C65D0", Slot = "9")]
	public void FCHNLNGIIAP(Rigidbody PDECCLFHGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x67C6730", Offset = "0x67C5930", VA = "0x1867C6730", Slot = "10")]
	public void KODKJGCPPBI(Rigidbody PDECCLFHGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class DLDJEKGPPKI : PLBINDHECDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly HCDGCCECAEP PIGCCDNLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float ICEHDFEGFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float FNFPENLAOHJ;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float HILNNJPODPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x94A870", Offset = "0x949A70", VA = "0x18094A870", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x67B7680", Offset = "0x67B6880", VA = "0x1867B7680", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float HMHKEPLBCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA03990", Offset = "0xA02B90", VA = "0x180A03990", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x67B74C0", Offset = "0x67B66C0", VA = "0x1867B74C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x67B7750", Offset = "0x67B6950", VA = "0x1867B7750")]
	public DLDJEKGPPKI(HCDGCCECAEP PIGCCDNLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x67B7590", Offset = "0x67B6790", VA = "0x1867B7590", Slot = "8")]
	public void FCHNLNGIIAP(Rigidbody PDECCLFHGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x67B75E0", Offset = "0x67B67E0", VA = "0x1867B75E0", Slot = "9")]
	public void KODKJGCPPBI(Rigidbody PDECCLFHGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class OMKFKFFBECH : PDKHMONANLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly EPKAMMNFKBC PIGCCDNLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool POIDNGJPLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool POOMLABFDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int ANLIGPJEJNI;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody FLEDBGNMPOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x67BF150", Offset = "0x67BE350", VA = "0x1867BF150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool MFKLFHJCCED
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x67C9280", Offset = "0x67C8480", VA = "0x1867C9280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private HCDGCCECAEP ANNFPHELCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x67C9180", Offset = "0x67C8380", VA = "0x1867C9180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool MEHFEOAECPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x67C8A50", Offset = "0x67C7C50", VA = "0x1867C8A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event MGHEEHNOJLO DKDFEBGJMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x67C8F30", Offset = "0x67C8130", VA = "0x1867C8F30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x67C8CA0", Offset = "0x67C7EA0", VA = "0x1867C8CA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x67C9430", Offset = "0x67C8630", VA = "0x1867C9430")]
	public OMKFKFFBECH(HCDGCCECAEP PIGCCDNLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x67C89C0", Offset = "0x67C7BC0", VA = "0x1867C89C0", Slot = "6")]
	public void ABMIDKDAPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x67C8F20", Offset = "0x67C8120", VA = "0x1867C8F20", Slot = "8")]
	public void FEIBKKJACMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x67C8AB0", Offset = "0x67C7CB0", VA = "0x1867C8AB0", Slot = "7")]
	public bool EDCIGFOEIPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x67C8C00", Offset = "0x67C7E00", VA = "0x1867C8C00", Slot = "9")]
	public void EFMNMIEBMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x67C91E0", Offset = "0x67C83E0", VA = "0x1867C91E0", Slot = "11")]
	public void IGFKFBEIGID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x67C8FD0", Offset = "0x67C81D0", VA = "0x1867C8FD0", Slot = "10")]
	public void HFLMAHLNBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x67C8D40", Offset = "0x67C7F40", VA = "0x1867C8D40")]
	private bool EMAOFMBFKLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x67C92A0", Offset = "0x67C84A0", VA = "0x1867C92A0")]
	private void MLJDILLBIKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LGOCIDNHCCG : LFIPGIIPODB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly EPKAMMNFKBC PIGCCDNLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NFAPFDEEOME ABEHGDOBHLE;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody FLEDBGNMPOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool MEHFEOAECPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x67B67A0", Offset = "0x67B59A0", VA = "0x1867B67A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool IIBKNOAKEBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xDB4C10", Offset = "0xDB3E10", VA = "0x180DB4C10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x67C77A0", Offset = "0x67C69A0", VA = "0x1867C77A0")]
	public LGOCIDNHCCG(HCDGCCECAEP PIGCCDNLNPO, [In] BICJDOJJHMH FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x67C6810", Offset = "0x67C5A10", VA = "0x1867C6810", Slot = "5")]
	public void ABMIDKDAPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x67C7550", Offset = "0x67C6750", VA = "0x1867C7550", Slot = "7")]
	public void KHEHMGDAINE(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x67C7580", Offset = "0x67C6780", VA = "0x1867C7580", Slot = "8")]
	public void MBIBPFFCOBC(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x67C7070", Offset = "0x67C6270", VA = "0x1867C7070", Slot = "9")]
	public void GKOKNGMJGMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x67C75B0", Offset = "0x67C67B0", VA = "0x1867C75B0", Slot = "11")]
	public void MCEJDGBIEPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x67C6EF0", Offset = "0x67C60F0", VA = "0x1867C6EF0", Slot = "12")]
	public void FCPHHNKIILF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x67C6A60", Offset = "0x67C5C60", VA = "0x1867C6A60", Slot = "10")]
	public void EJJBPHOIPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x67C73A0", Offset = "0x67C65A0", VA = "0x1867C73A0")]
	private void HDMHOKFFNGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x67C68B0", Offset = "0x67C5AB0", VA = "0x1867C68B0")]
	private void DICJBPBCBEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class HJOONLPAAAM : OOEEACLPHBP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly EPKAMMNFKBC PIGCCDNLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly NFAPFDEEOME HINMPCENBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float OLJJGOCOBMP;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public CKLELEBFCJP GBLMDIJCCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9A0", Offset = "0x7BBBA0", VA = "0x1807BC9A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public EJAOGNIOOGM CIHJGHDKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC990", Offset = "0x7BBB90", VA = "0x1807BC990", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 JPCJHLPMEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x67C5960", Offset = "0x67C4B60", VA = "0x1867C5960", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x67C3A20", Offset = "0x67C2C20", VA = "0x1867C3A20", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 JKHEFEAECKB
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x67C3AE0", Offset = "0x67C2CE0", VA = "0x1867C3AE0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x67C3430", Offset = "0x67C2630", VA = "0x1867C3430", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 MEJNHHCNIPO
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x67C6250", Offset = "0x67C5450", VA = "0x1867C6250", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x67C5AC0", Offset = "0x67C4CC0", VA = "0x1867C5AC0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 AOFHKBKNJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x67C6120", Offset = "0x67C5320", VA = "0x1867C6120", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x67C2E70", Offset = "0x67C2070", VA = "0x1867C2E70", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float PNFPKEPCDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x96F8D0", Offset = "0x96EAD0", VA = "0x18096F8D0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x67C2EA0", Offset = "0x67C20A0", VA = "0x1867C2EA0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool IJKNPLBEOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x176E6B0", Offset = "0x176D8B0", VA = "0x18176E6B0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private BLOMGPJBBOI PNCODKIDEMB
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6081AB0", Offset = "0x6080CB0", VA = "0x186081AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool MFKLFHJCCED
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x67C3E20", Offset = "0x67C3020", VA = "0x1867C3E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x67C63B0", Offset = "0x67C55B0", VA = "0x1867C63B0")]
	public HJOONLPAAAM(HCDGCCECAEP PIGCCDNLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x67C2DD0", Offset = "0x67C1FD0", VA = "0x1867C2DD0", Slot = "19")]
	public void ABMIDKDAPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x67C3460", Offset = "0x67C2660", VA = "0x1867C3460", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x67C3660", Offset = "0x67C2860", VA = "0x1867C3660", Slot = "28")]
	public void FCHNLNGIIAP(Rigidbody PDECCLFHGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xBC2360", Offset = "0xBC1560", VA = "0x180BC2360", Slot = "20")]
	public void FPIEOJBMNFD(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xBC1BE0", Offset = "0xBC0DE0", VA = "0x180BC1BE0", Slot = "30")]
	public void ILDPPFHIJHG(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x67C3E40", Offset = "0x67C3040", VA = "0x1867C3E40", Slot = "35")]
	public Vector3 JKEILGMCIDM(Vector3 DEPCJPCCEGP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x67C5DC0", Offset = "0x67C4FC0", VA = "0x1867C5DC0", Slot = "34")]
	public Vector3 PDOGEJIDCEK(Vector3 MGKFELLKNBM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x67C2DD0", Offset = "0x67C1FD0", VA = "0x1867C2DD0", Slot = "27")]
	public void MANEBCKGDDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x67C4020", Offset = "0x67C3220", VA = "0x1867C4020", Slot = "25")]
	public void JOHLBECDCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x67C3CB0", Offset = "0x67C2EB0", VA = "0x1867C3CB0", Slot = "24")]
	public void HAFMKOKJLCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x67C5B80", Offset = "0x67C4D80", VA = "0x1867C5B80", Slot = "33")]
	public void OPBCAKCJMIB(Vector3 FDMEDIMDJFI, Vector3 OJHACBOBKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x67C47B0", Offset = "0x67C39B0", VA = "0x1867C47B0", Slot = "32")]
	public void LOHDNDLMHOO(Vector3 DHIAIOAJMJE, Vector3 IOOLPCCNOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x67C5F80", Offset = "0x67C5180", VA = "0x1867C5F80", Slot = "31")]
	public void PJDEILJPDJM(Vector3 HLNHFEOKKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x67C5310", Offset = "0x67C4510", VA = "0x1867C5310", Slot = "22")]
	public void OINGMABDDGL(ODFIFOEIPOB JPNLMCAHNCF, Vector3 IIJKIDIFJNO, float OPKCPNAOJLG, float ADLHHECADCN = 8f, float GGJBGFMFPBH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x67C3790", Offset = "0x67C2990", VA = "0x1867C3790", Slot = "21")]
	public void FFBBIPLAOEM(MCKLPPJOMOK LAEAKPFEGLK, Vector3 PNGPNDMJNGP, float GEHEKDBMGLO = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x67C4E90", Offset = "0x67C4090", VA = "0x1867C4E90", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void NNKFGPELLFO(MCKLPPJOMOK LAEAKPFEGLK, Vector3 HBCECKEGCGH, float NKOKHDMEPJH = 7f, float IDFHKKPEKIN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xCBE2F0", Offset = "0xCBD4F0", VA = "0x180CBE2F0")]
	private static void EKKJGCOGLMA(Vector3 JPMMLNGJNDB, Vector3 IAAOFHLOLIL, [Out] Vector3 HLLEHHOIDEC, [Out] Vector3 FIIKPAFEPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x67C4DB0", Offset = "0x67C3FB0", VA = "0x1867C4DB0", Slot = "29")]
	public Vector3 NMFIDAGOJBF(Vector3 JPMMLNGJNDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x67C4080", Offset = "0x67C3280", VA = "0x1867C4080", Slot = "26")]
	public void LCCEBIADBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x67C2EA0", Offset = "0x67C20A0", VA = "0x1867C2EA0")]
	private void KIEEBBGGDPJ(float NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x67C34C0", Offset = "0x67C26C0", VA = "0x1867C34C0")]
	private void EOMGHLPOIMH(Vector3 PNGPNDMJNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x67C3D10", Offset = "0x67C2F10", VA = "0x1867C3D10")]
	private Vector3 JGJLHBFBLHH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x67C2FB0", Offset = "0x67C21B0", VA = "0x1867C2FB0")]
	private void AKMPMHILECE(Vector3 MGKFELLKNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x67C4C90", Offset = "0x67C3E90", VA = "0x1867C4C90")]
	private Vector3 MJKMLEIDIIO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x67C4810", Offset = "0x67C3A10", VA = "0x1867C4810")]
	private void MBMOHCEGCBL(Vector3 NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x67C4210", Offset = "0x67C3410", VA = "0x1867C4210")]
	private void LFCGLIOPLJE(Vector3 MGKFELLKNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x67C3C00", Offset = "0x67C2E00", VA = "0x1867C3C00")]
	private void GALHMDGHMOB()
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
