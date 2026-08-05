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
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72C57E0", Offset = "0x72C41E0", VA = "0x1872C57E0", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private DFMCGIMCFGD bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1868050", Offset = "0x1866A50", VA = "0x181868050", Slot = "5")]
		public override void NPEPAFCACGO(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72CF830", Offset = "0x72CE230", VA = "0x1872CF830")]
		private void PPMCIGPJJHC(OKABLMMJMFE registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72CF7D0", Offset = "0x72CE1D0", VA = "0x1872CF7D0", Slot = "6")]
		public override void BLGFFGICMBK(OKABLMMJMFE registry, [In] EFAAIAEHAHM filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72CFB40", Offset = "0x72CE540", VA = "0x1872CFB40")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, EKIGEEIGKIO
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly CMICIECANPG LBHKLNDAPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool FPFOFLBGPCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private LIIKICNCDGJ FGLFHMNJOBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[HELBAACNMJG(LPFNGFMJOGK.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[HELBAACNMJG(LPFNGFMJOGK.SelfAndParent, true, false, false)]
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
		[FormerlySerializedAs("forceNoInterpolation")]
		[SerializeField]
		private DKOEEBIFOEM physicsInterpolation;

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
		internal LIIKICNCDGJ GLLFIKGKNOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x72CB220", Offset = "0x72C9C20", VA = "0x1872CB220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LIIKICNCDGJ FPJBDDLAPBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FCCFPOKIGIC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x72CCC00", Offset = "0x72CB600", VA = "0x1872CCC00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx DBPFKKJAOIC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x72CCF60", Offset = "0x72CB960", VA = "0x1872CCF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx GEBPHFIJDHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x72CCEA0", Offset = "0x72CB8A0", VA = "0x1872CCEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx LDJCBIBELIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x72CDC10", Offset = "0x72CC610", VA = "0x1872CDC10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x72CF140", Offset = "0x72CDB40", VA = "0x1872CF140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform CLMENJCDDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8C08C0", Offset = "0x8BF2C0", VA = "0x1808C08C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform JOJCKMBBNHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8C08C0", Offset = "0x8BF2C0", VA = "0x1808C08C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IDPKEMCPFEK LDMEPBIHABI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x72CCC60", Offset = "0x72CB660", VA = "0x1872CCC60")]
			get
			{
				return default(IDPKEMCPFEK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x72CE8F0", Offset = "0x72CD2F0", VA = "0x1872CE8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EDFLICMDNLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x72CD270", Offset = "0x72CBC70", VA = "0x1872CD270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool FJHGFOFBNHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x72CCD80", Offset = "0x72CB780", VA = "0x1872CCD80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JAJDMPNLONJ BIEFJFNFNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x72CD1B0", Offset = "0x72CBBB0", VA = "0x1872CD1B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x72CEAB0", Offset = "0x72CD4B0", VA = "0x1872CEAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BBKEJCDCLFA AOGHHFMNIGH
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x72CD150", Offset = "0x72CBB50", VA = "0x1872CD150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x72CEA40", Offset = "0x72CD440", VA = "0x1872CEA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool ENBMDKNMHDD
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x72CD0A0", Offset = "0x72CBAA0", VA = "0x1872CD0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody KJODLCHDEJI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x72CD100", Offset = "0x72CBB00", VA = "0x1872CD100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool CHOMHMJJDAE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x72CCDE0", Offset = "0x72CB7E0", VA = "0x1872CCDE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x72CE960", Offset = "0x72CD360", VA = "0x1872CE960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool JJJFHLFAKKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F9AC70", Offset = "0x6F99670", VA = "0x186F9AC70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float LBLHKMLAOCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x72CDBB0", Offset = "0x72CC5B0", VA = "0x1872CDBB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float GKILHKLOHHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x72CDB50", Offset = "0x72CC550", VA = "0x1872CDB50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x72CF0D0", Offset = "0x72CDAD0", VA = "0x1872CF0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float CAAHNDOCFDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x72CD4D0", Offset = "0x72CBED0", VA = "0x1872CD4D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x72CED50", Offset = "0x72CD750", VA = "0x1872CED50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float BHCJEPFNLJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x72CD2D0", Offset = "0x72CBCD0", VA = "0x1872CD2D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x72CEB20", Offset = "0x72CD520", VA = "0x1872CEB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool GKFNMBGEFBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x72CE190", Offset = "0x72CCB90", VA = "0x1872CE190")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x72CF680", Offset = "0x72CE080", VA = "0x1872CF680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 EIHNNMDBOKG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x72CD930", Offset = "0x72CC330", VA = "0x1872CD930")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x72CEEA0", Offset = "0x72CD8A0", VA = "0x1872CEEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 MKBOBLLEBEB
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x72CE2D0", Offset = "0x72CCCD0", VA = "0x1872CE2D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode PDHKEGACJCL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x72CD410", Offset = "0x72CBE10", VA = "0x1872CD410")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x72CEC70", Offset = "0x72CD670", VA = "0x1872CEC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float OHPFGDDNLOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x72CCE40", Offset = "0x72CB840", VA = "0x1872CCE40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x72CE9D0", Offset = "0x72CD3D0", VA = "0x1872CE9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints OPIKDHJECDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x72CD470", Offset = "0x72CBE70", VA = "0x1872CD470")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x72CECE0", Offset = "0x72CD6E0", VA = "0x1872CECE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 IFIHLMDPNJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x72CDCD0", Offset = "0x72CC6D0", VA = "0x1872CDCD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 JOIBHGPGLLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x72CDCD0", Offset = "0x72CC6D0", VA = "0x1872CDCD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x72CF460", Offset = "0x72CDE60", VA = "0x1872CF460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float LDFEJLDJAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x72CDA10", Offset = "0x72CC410", VA = "0x1872CDA10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x72CEF80", Offset = "0x72CD980", VA = "0x1872CEF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float PMIPCKHIBMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x72CE130", Offset = "0x72CCB30", VA = "0x1872CE130")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x72CF610", Offset = "0x72CE010", VA = "0x1872CF610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion JOJGECMDGJF
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x72CDDB0", Offset = "0x72CC7B0", VA = "0x1872CDDB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x72CF1E0", Offset = "0x72CDBE0", VA = "0x1872CF1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion PIPOCGEFJAK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x72CE050", Offset = "0x72CCA50", VA = "0x1872CE050")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x72CF540", Offset = "0x72CDF40", VA = "0x1872CF540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 KGNEENFKOED
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x72CDE90", Offset = "0x72CC890", VA = "0x1872CDE90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x72CF2B0", Offset = "0x72CDCB0", VA = "0x1872CF2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DDBIDBFFJOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x72CDF70", Offset = "0x72CC970", VA = "0x1872CDF70")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x72CF390", Offset = "0x72CDD90", VA = "0x1872CF390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 DLPEMGFGHPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x72CE1F0", Offset = "0x72CCBF0", VA = "0x1872CE1F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x72CF6F0", Offset = "0x72CE0F0", VA = "0x1872CF6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 CALOMLJNHAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x72CDA70", Offset = "0x72CC470", VA = "0x1872CDA70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x72CEFF0", Offset = "0x72CD9F0", VA = "0x1872CEFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 OHHCFKJBEEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x72CD330", Offset = "0x72CBD30", VA = "0x1872CD330")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x72CEB90", Offset = "0x72CD590", VA = "0x1872CEB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 JKDCCBAFKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x72CD850", Offset = "0x72CC250", VA = "0x1872CD850")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x72CEDC0", Offset = "0x72CD7C0", VA = "0x1872CEDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 APLMKDPAJBI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x72CD710", Offset = "0x72CC110", VA = "0x1872CD710")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion BEIKBCAEKBL
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x72CD630", Offset = "0x72CC030", VA = "0x1872CD630")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 CCNDBAHIGIE
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x72CE490", Offset = "0x72CCE90", VA = "0x1872CE490")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 HIPFLCHJMPN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x72CE3B0", Offset = "0x72CCDB0", VA = "0x1872CE3B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool ILMFJGEOAEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x72CD7F0", Offset = "0x72CC1F0", VA = "0x1872CD7F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool KBGODMPIDOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x72CD210", Offset = "0x72CBC10", VA = "0x1872CD210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CGOAGBDFOCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x72CCD20", Offset = "0x72CB720", VA = "0x1872CCD20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool EJHGOMAIJPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x72CCCC0", Offset = "0x72CB6C0", VA = "0x1872CCCC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool AKHLIBBDLBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x72CCBA0", Offset = "0x72CB5A0", VA = "0x1872CCBA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool MHHCMEDLEKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x72CD530", Offset = "0x72CBF30", VA = "0x1872CD530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CMFCJHGPMDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1ABCC30", Offset = "0x1ABB630", VA = "0x181ABCC30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event KHNKEDFCPCA OFIDAELEKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x72CCAC0", Offset = "0x72CB4C0", VA = "0x1872CCAC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x72CE810", Offset = "0x72CD210", VA = "0x1872CE810")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LDHKFCBONJG HAPCHNBOPIO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x72CC830", Offset = "0x72CB230", VA = "0x1872CC830")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x72CE570", Offset = "0x72CCF70", VA = "0x1872CE570")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event LDHKFCBONJG ALMMOHFNLGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x72CC890", Offset = "0x72CB290", VA = "0x1872CC890")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x72CE5E0", Offset = "0x72CCFE0", VA = "0x1872CE5E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event LDHKFCBONJG HHBHHCLMKAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x72CC9E0", Offset = "0x72CB3E0", VA = "0x1872CC9E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x72CE730", Offset = "0x72CD130", VA = "0x1872CE730")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<MGNMBPEAPIF, MGNMBPEAPIF> HGNPDKHNLHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x72CC970", Offset = "0x72CB370", VA = "0x1872CC970")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x72CE6C0", Offset = "0x72CD0C0", VA = "0x1872CE6C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event LDHKFCBONJG AJNALHDLMNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x72CCA50", Offset = "0x72CB450", VA = "0x1872CCA50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x72CE7A0", Offset = "0x72CD1A0", VA = "0x1872CE7A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event LDHKFCBONJG ICMFDAELLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x72CCB30", Offset = "0x72CB530", VA = "0x1872CCB30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x72CE880", Offset = "0x72CD280", VA = "0x1872CE880")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event LDHKFCBONJG CLODFINLIGM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x72CC900", Offset = "0x72CB300", VA = "0x1872CC900")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72CE650", Offset = "0x72CD050", VA = "0x1872CE650")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x899040", Offset = "0x897A40", VA = "0x180899040", Slot = "8")]
		private void CBLHNPOKBLM(LIIKICNCDGJ BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72CB7A0", Offset = "0x72CA1A0", VA = "0x1872CB7A0")]
		internal void KJABNOMCHGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72CC560", Offset = "0x72CAF60", VA = "0x1872CC560")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody OIPPEPPFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72CB2D0", Offset = "0x72C9CD0", VA = "0x1872CB2D0")]
		public EKIGEEIGKIO GetChild(int HGFDMIDEFHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x72CC230", Offset = "0x72CAC30", VA = "0x1872CC230")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) JBHPDEADHAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72CAFD0", Offset = "0x72C99D0", VA = "0x1872CAFD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72CB220", Offset = "0x72C9C20", VA = "0x1872CB220")]
		private LIIKICNCDGJ FPKFIFABCBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72CA460", Offset = "0x72C8E60", VA = "0x1872CA460")]
		private void AMLGEKNOMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72CBA00", Offset = "0x72CA400", VA = "0x1872CBA00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72CB7A0", Offset = "0x72CA1A0", VA = "0x1872CB7A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x72CB9A0", Offset = "0x72CA3A0", VA = "0x1872CB9A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x72CBA60", Offset = "0x72CA460", VA = "0x1872CBA60")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x72CA680", Offset = "0x72C9080", VA = "0x1872CA680")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x72CBAC0", Offset = "0x72CA4C0", VA = "0x1872CBAC0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x72CB1C0", Offset = "0x72C9BC0", VA = "0x1872CB1C0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x72CB940", Offset = "0x72CA340", VA = "0x1872CB940")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x72CC390", Offset = "0x72CAD90", VA = "0x1872CC390")]
		public void SetParent(RigidbodyEx KLABJGGMBGH, bool AMABBFGDEKH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x72CBDD0", Offset = "0x72CA7D0", VA = "0x1872CBDD0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x72CB580", Offset = "0x72C9F80", VA = "0x1872CB580")]
		public bool IsRigidbodyAncestor(RigidbodyEx NJFMAAHNHCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x72CB660", Offset = "0x72CA060", VA = "0x1872CB660")]
		public bool IsRigidbodyDescendant(RigidbodyEx EMNAFJIGFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x72CA8F0", Offset = "0x72C92F0", VA = "0x1872CA8F0")]
		public void AddInterpolationRestriction(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x72CBB30", Offset = "0x72CA530", VA = "0x1872CBB30")]
		public void RemoveInterpolationRestriction(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x72CA960", Offset = "0x72C9360", VA = "0x1872CA960")]
		public void AddKinematic(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x72CBBA0", Offset = "0x72CA5A0", VA = "0x1872CBBA0")]
		public void RemoveKinematic(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x72CC310", Offset = "0x72CAD10", VA = "0x1872CC310")]
		public void SetKinematic(object FLLNLBHFENG, bool HJBOCAGMBCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x72CC130", Offset = "0x72CAB30", VA = "0x1872CC130")]
		public void SetDiscontinuousPositionAndRotation(Vector3 ALEJNJJFLEH, Quaternion AJOIIFAELBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x72CC030", Offset = "0x72CAA30", VA = "0x1872CC030")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 PFAHFEPFAAJ, Quaternion NKABCINOOKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x72CB470", Offset = "0x72C9E70", VA = "0x1872CB470")]
		public Vector3 GetConstrainedVelocity(Vector3 DLPEMGFGHPD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x72CB360", Offset = "0x72C9D60", VA = "0x1872CB360")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 OHHCFKJBEEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x72CA800", Offset = "0x72C9200", VA = "0x1872CA800")]
		public void AddForce(Vector3 LENLJCDCMCG, ForceMode KNHJEAKHHDM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x72CA6F0", Offset = "0x72C90F0", VA = "0x1872CA6F0")]
		public void AddForceAtPosition(Vector3 LENLJCDCMCG, Vector3 LEELMECKGCG, ForceMode KNHJEAKHHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x72CAB30", Offset = "0x72C9530", VA = "0x1872CAB30")]
		public void AddTorque(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x72CA9D0", Offset = "0x72C93D0", VA = "0x1872CA9D0")]
		public void AddRelativeTorque(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x72CC630", Offset = "0x72CB030", VA = "0x1872CC630")]
		public Vector3 WorldToLocalVelocity(Vector3 FOEOPLOKPOB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x72CB830", Offset = "0x72CA230", VA = "0x1872CB830")]
		public Vector3 LocalToWorldVelocity(Vector3 CALOMLJNHAK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x72CB160", Offset = "0x72C9B60", VA = "0x1872CB160")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x72CB100", Offset = "0x72C9B00", VA = "0x1872CB100")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x72CB0A0", Offset = "0x72C9AA0", VA = "0x1872CB0A0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x72CB040", Offset = "0x72C9A40", VA = "0x1872CB040")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x72CBF30", Offset = "0x72CA930", VA = "0x1872CBF30")]
		public void ResetVelocityWorldSpace(Vector3 MEKMEJHIFMC, Vector3 KBNCPNDBCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x72CBE30", Offset = "0x72CA830", VA = "0x1872CBE30")]
		public void ResetVelocityLocalSpace(Vector3 AHEKOJPDIDP, Vector3 JKDCCBAFKIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x72CBCF0", Offset = "0x72CA6F0", VA = "0x1872CBCF0")]
		public void ResetLinearVelocityLocalSpace(Vector3 AHEKOJPDIDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x72CC4C0", Offset = "0x72CAEC0", VA = "0x1872CC4C0")]
		public bool SweepTest(Vector3 JFCINBHKCNC, [Out] RaycastHit DPMDGOFFPKK, float KEEIEBHGPIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x72CB740", Offset = "0x72CA140", VA = "0x1872CB740")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x72CC460", Offset = "0x72CAE60", VA = "0x1872CC460")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x72CC5D0", Offset = "0x72CAFD0", VA = "0x1872CC5D0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x72CAAC0", Offset = "0x72C94C0", VA = "0x1872CAAC0")]
		public void AddShouldHaveUnityRigidbodyToken(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x72CBC10", Offset = "0x72CA610", VA = "0x1872CBC10")]
		public void RemoveShouldHaveUnityRigidbodyToken(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x72CAE60", Offset = "0x72C9860", VA = "0x1872CAE60")]
		public void ApplyForceVelocityChange(DCOEIOEOLOO OGDHOAEFGEK, Vector3 ADCIKHMIKDC, float BFNABEBMGML, float EJJOPELHGIF = 8f, float ODMENHHKENK = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x72CADC0", Offset = "0x72C97C0", VA = "0x1872CADC0")]
		public void ApplyAngularVelocityChange(HLIEOJLMCMD DLJHIKDDMED, Vector3 FDNLGBMHIMG, float LGADHHDBLPE = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x72CAF20", Offset = "0x72C9920", VA = "0x1872CAF20")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(HLIEOJLMCMD DLJHIKDDMED, Vector3 JOLHFCINNMA, float LGCLKPGINJF = 7f, float GNAMHFMCPHB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x72CACF0", Offset = "0x72C96F0", VA = "0x1872CACF0")]
		public bool AllowedScaleChange(float OADJCOEBHOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x72CAC20", Offset = "0x72C9620", VA = "0x1872CAC20")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx CEECOCODHNB, object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72CBC80", Offset = "0x72CA680", VA = "0x1872CBC80")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x72CC7C0", Offset = "0x72CB1C0", VA = "0x1872CC7C0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xC3DBF0", Offset = "0xC3C5F0", VA = "0x180C3DBF0", Slot = "4")]
		private GameObject BPBEBKOGPPJ()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8C08C0", Offset = "0x8BF2C0", VA = "0x1808C08C0", Slot = "5")]
		private Transform NOBKHECEEMN()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class DKFOJLEAKIH
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x72B9A00", Offset = "0x72B8400", VA = "0x1872B9A00")]
	public static LIIKICNCDGJ GLLFIKGKNOL(this RigidbodyEx IOHJIPHILJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AODOHJCIOJB(typeof(PLEPOBHCEGN), new string[] { })]
public class GFNFLINDCOF : PLEPOBHCEGN, KINLAMFGOOC
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private CHGFOFIHPPB LILKAOEDHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private MPAHCCEMMEI GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private DFHCEAJLAEJ PHGLEMABFII;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MPAHCCEMMEI DBCHGEHMEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DFHCEAJLAEJ DMCOGGNKFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x72BD210", Offset = "0x72BBC10", VA = "0x1872BD210", Slot = "7")]
	public void InitReferences(GOMDDPLFKLJ KKAHGNKMLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x72BD180", Offset = "0x72BBB80", VA = "0x1872BD180", Slot = "6")]
	public LIIKICNCDGJ ENFLHFFGAOB(RigidbodyEx IOHJIPHILJI, OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public GFNFLINDCOF()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static GHNLMGKLHKE UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int PKDGFNBIAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int KJGNFPJPNJN;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x72CA2E0", Offset = "0x72C8CE0", VA = "0x1872CA2E0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x72CA320", Offset = "0x72C8D20", VA = "0x1872CA320")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x72CA300", Offset = "0x72C8D00", VA = "0x1872CA300")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string KFAOBDLOMDC, [Optional] UnityEngine.Object EIGKPCONJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string KFAOBDLOMDC, [Optional] UnityEngine.Object EIGKPCONJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x72CA410", Offset = "0x72C8E10", VA = "0x1872CA410")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JMPLOHKBPLC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class OIADFDGEGPF : JAJDMPNLONJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8A7B10", Offset = "0x8A6510", VA = "0x1808A7B10", Slot = "4")]
		public Vector3 MHHJOJACDNH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A7B10", Offset = "0x8A6510", VA = "0x1808A7B10", Slot = "5")]
		public Vector3 ODGKCHKOFEI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public OIADFDGEGPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static JAJDMPNLONJ PBNNDAHHPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x72C4000", Offset = "0x72C2A00", VA = "0x1872C4000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IJJJKIKMEKK
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode OHGCCBCICEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPMACNMHMCK();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNFBAGBIDGN(bool ILMFJGEOAEE);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EGEGGPMALGL(bool ILMFJGEOAEE);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFCFDMGBDJO(Rigidbody OLNABEIJDDM);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GNBADKMPLDL(Vector3 JFCINBHKCNC, [Out] RaycastHit DPMDGOFFPKK, float KEEIEBHGPIH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KIAJJIOCNGO : IDisposable, PLHBJJNCKPL
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	IDPKEMCPFEK LDMEPBIHABI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<MGNMBPEAPIF, MGNMBPEAPIF> HGNPDKHNLHF;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BPMACNMHMCK();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[FMCCJGKNHAK(IIIIPAKMKHE.Application)]
public interface DFHCEAJLAEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AJKKKNAMDJO FEFKNLMJDGI(LIIKICNCDGJ BDPEMHOFOHC);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AOKAONLJHOF MKBPNEELGIH(LIIKICNCDGJ BDPEMHOFOHC);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DEGIIDBFCIH LCECHNCNPPN(LIIKICNCDGJ BDPEMHOFOHC);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KJJGDBKLOGE LEKMAHANNMM(LIIKICNCDGJ BDPEMHOFOHC);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ENMPBGGDGOP JADPOEEKFJA(LIIKICNCDGJ BDPEMHOFOHC);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KIAJJIOCNGO CPFFGDECCLE(LIIKICNCDGJ BDPEMHOFOHC);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KIAAOCCDDCB NBINMFELFGP(LIIKICNCDGJ BDPEMHOFOHC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HEBLMGHFANA GDADELKPNAH(LIIKICNCDGJ BDPEMHOFOHC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IJJJKIKMEKK DGGJKEDCOKH(LIIKICNCDGJ BDPEMHOFOHC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LKNIHEGCKKI IILOOAKBFCC(LIIKICNCDGJ BDPEMHOFOHC);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HMNMNHHFKJC GBCLHDECGFM(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OMJMPOHILOG FPMDDNDJJCF(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CDFAFOAFKII FMNBBFAABKB(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GKHFDEMHCGH IICGHNCEKCL(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NEDIICPLNME PBLEFFOELKN(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LIIKICNCDGJ ENFLHFFGAOB(RigidbodyEx IOHJIPHILJI, OCGBPCDKBKC JGCMECODHDI, PLEPOBHCEGN EHABNPPLNPG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HEBLMGHFANA
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHFHEKALINP(Vector3 LENLJCDCMCG, ForceMode KNHJEAKHHDM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FGINIKMJJCN(Vector3 LENLJCDCMCG, Vector3 LEELMECKGCG, ForceMode KNHJEAKHHDM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HCJOOMKAIIF(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FIKJJJCHOCM(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LKNIHEGCKKI
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool FGACBMNAHCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFCFDMGBDJO(Rigidbody OLNABEIJDDM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KLMOMCBKCOC(Rigidbody OLNABEIJDDM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AJKKKNAMDJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<LIIKICNCDGJ> FCLKNFGAHIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	LIIKICNCDGJ GEBPHFIJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	LIIKICNCDGJ NPDGLEPLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event LDHKFCBONJG HAPCHNBOPIO;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event LDHKFCBONJG ALMMOHFNLGC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event KHNKEDFCPCA LMKJBLGMEDI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action ANMGCGOCFGN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action FNEODFAMECD;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<LIIKICNCDGJ> KPHMOBEEIOK;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<LIIKICNCDGJ> PLJJCAEANAI;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action EKFLHALGKGH;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<LIIKICNCDGJ> MPBOIHOJJCO;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OOCNJIHJKBG(LIIKICNCDGJ LEEMAEKICLM, bool AMABBFGDEKH = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DEGIIDBFCIH
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 BNNAKBMDNKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 ECNEMFJNMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMEIMADIHAC(LIIKICNCDGJ LDJCBIBELIM, object FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IDAJDBAPFGN(object FLLNLBHFENG);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GKHFDEMHCGH
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 JBNBGKGBAKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 LDFAKINHCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float LINHIOGBDJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float ABINEMAJDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 LALMNOFKGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion KPBECAOAIDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event LDHKFCBONJG EKOJGAGMOPF;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JGHOGCEFAIE((Quaternion rot, Vector3 moments) JBHPDEADHAN);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OMMIJCKCGMG();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HGAGCFBNGBI();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JNIJLCFKCGP();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CFCFDMGBDJO(Rigidbody OLNABEIJDDM);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KLMOMCBKCOC(Rigidbody OLNABEIJDDM);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OPJOMHHIOOE();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CDFAFOAFKII
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPMACNMHMCK();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKCKHNKJPKE(object FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GIOLFHAFEFA(object FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFBPLDCFDNO(LIIKICNCDGJ IOHJIPHILJI);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EEFGGKEHGNE(LIIKICNCDGJ IOHJIPHILJI);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GAAIHOIMDNA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KIAAOCCDDCB
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool GBINOLADCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event LDHKFCBONJG CJBJKADPOLD;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MLIEHFDDMKO(object FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBJGEJFAFPH(object FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IIKHLAALMID(object FLLNLBHFENG, bool HJBOCAGMBCG);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CFCFDMGBDJO(Rigidbody FHMDKJNEMLN);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KLMOMCBKCOC(Rigidbody OLNABEIJDDM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OMJMPOHILOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool EDFLICMDNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool FJHGFOFBNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event LDHKFCBONJG NFNPGGIDPMN;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BPMACNMHMCK();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPEFCMPOPCG(LIIKICNCDGJ LDJCBIBELIM);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DEBKOMLEGPA(LIIKICNCDGJ LDJCBIBELIM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NEDIICPLNME
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool CHOMHMJJDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool NJDFJEAACPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints BIJPIEOKJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFCFDMGBDJO(Rigidbody OLNABEIJDDM);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLMOMCBKCOC(Rigidbody OLNABEIJDDM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KJJGDBKLOGE
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float NEAAAENLEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float CHNNGEICIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFCFDMGBDJO(Rigidbody OLNABEIJDDM);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KLMOMCBKCOC(Rigidbody OLNABEIJDDM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ENMPBGGDGOP
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event LDHKFCBONJG MAPLCBMMGBB;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPMACNMHMCK();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BEIIONGBDOP();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BJENNCIKLDC();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JGJAPHHHLDF();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OAOEGMONBJA();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OIPENABPJGC();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HMNMNHHFKJC
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody KJODLCHDEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool IBMBBGNFEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPMACNMHMCK();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IMDNBJHCJDN(object FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IFBCHBJDHFA(object FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OEGGCLEMPGF();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AOKAONLJHOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	JAJDMPNLONJ BIEFJFNFNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	BBKEJCDCLFA AOGHHFMNIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 GJNHMHCKKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 PFNOKEMFJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 GAEJILGJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 DKKOHOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float OHPFGDDNLOG
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool ENBMDKNMHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BPMACNMHMCK();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PFGJINBIANE(object FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IBGBKJDOGEF(HLIEOJLMCMD DLJHIKDDMED, Vector3 FDNLGBMHIMG, float LGADHHDBLPE = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HHIIHBGIEBI(DCOEIOEOLOO OGDHOAEFGEK, Vector3 ADCIKHMIKDC, float BFNABEBMGML, float EJJOPELHGIF = 8f, float ODMENHHKENK = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NICHPOJBKKJ(HLIEOJLMCMD DLJHIKDDMED, Vector3 JOLHFCINNMA, float LGCLKPGINJF = 7f, float GNAMHFMCPHB = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BJBDPEAHGEJ();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FNJCHAFGION();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PMJJMHPJAAA();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DLEEIKFFPOM();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CFCFDMGBDJO(Rigidbody OLNABEIJDDM);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 KMAMKOPDPLJ(Vector3 DLPEMGFGHPD);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LJJKJJAHIDI(object FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CODKDPLCDHD(Vector3 IEAGHIDJHNB);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IADKCNKPDLN(Vector3 AHEKOJPDIDP, Vector3 JKDCCBAFKIJ);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void IPGHPFLDEBA(Vector3 MEKMEJHIFMC, Vector3 KBNCPNDBCFI);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 IAPPHLOLCLB(Vector3 CALOMLJNHAK);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 PBFBIDMAHAC(Vector3 FOEOPLOKPOB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[FMCCJGKNHAK(IIIIPAKMKHE.Application)]
public interface MPAHCCEMMEI
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool PFCLKJAOJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFFCBCIKGNH(string ENDMINEHNJK);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EFGMPGNDHNI(RigidbodyEx IOHJIPHILJI, Action PMCMEAHOBEF);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NHDPODLODNG BCNACMLMGNO(int NDELDPJANBC);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PAKCNKACEMN(Vector3 MKBOBLLEBEB, float PHOGGCIOOMC, Color FEHNKBJAMFH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[FMCCJGKNHAK(IIIIPAKMKHE.Application)]
public interface PLEPOBHCEGN
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	MPAHCCEMMEI DBCHGEHMEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	DFHCEAJLAEJ DMCOGGNKFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LIIKICNCDGJ ENFLHFFGAOB(RigidbodyEx IOHJIPHILJI, OCGBPCDKBKC JGCMECODHDI);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HDBLPCDAJNK : LIIKICNCDGJ, IDisposable, ONNNBJFNIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly PLEPOBHCEGN EHABNPPLNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal AJKKKNAMDJO CHMJBKDFMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal CDFAFOAFKII FOFIKNHFGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal OMJMPOHILOG IJIOOJOJNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal AOKAONLJHOF DLPEMGFGHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DEGIIDBFCIH HHAFGIGFEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal GKHFDEMHCGH NEDINAEFOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal KJJGDBKLOGE FPCIPDEEKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal LKNIHEGCKKI KPCCLGKAEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal ENMPBGGDGOP MLPEBFPOLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal KIAJJIOCNGO MBAPAINNJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal KIAAOCCDDCB ABJBEKFMDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal HEBLMGHFANA LENLJCDCMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal NEDIICPLNME HEGNNNNIBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal HMNMNHHFKJC OLNABEIJDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal IJJJKIKMEKK IBPKLFHOKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable JOHDBFGEOGF;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public GJJPJLAFENF BKJDJDPGCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "22")]
		get
		{
			return default(GJJPJLAFENF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EKIGEEIGKIO AEKONCKCCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x89F620", Offset = "0x89E020", VA = "0x18089F620", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x89F6C0", Offset = "0x89E0C0", VA = "0x18089F6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject MNAAHCNCEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x949AA0", Offset = "0x9484A0", VA = "0x180949AA0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x923D60", Offset = "0x922760", VA = "0x180923D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform MJIIFCFMCAF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x897DE0", Offset = "0x8967E0", VA = "0x180897DE0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x897DC0", Offset = "0x8967C0", VA = "0x180897DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody KJODLCHDEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x72BE020", Offset = "0x72BCA20", VA = "0x1872BE020", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public LIIKICNCDGJ NPDGLEPLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x72BFED0", Offset = "0x72BE8D0", VA = "0x1872BFED0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x72C3130", Offset = "0x72C1B30", VA = "0x1872C3130", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int FCCFPOKIGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x72C0580", Offset = "0x72BEF80", VA = "0x1872C0580", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public LIIKICNCDGJ GEBPHFIJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x72C1010", Offset = "0x72BFA10", VA = "0x1872C1010", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool IIJMHMHEHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x72C1810", Offset = "0x72C0210", VA = "0x1872C1810", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool EDFLICMDNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x72BFA60", Offset = "0x72BE460", VA = "0x1872BFA60", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool FJHGFOFBNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x72C1E70", Offset = "0x72C0870", VA = "0x1872C1E70", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public JAJDMPNLONJ BIEFJFNFNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x72BFE80", Offset = "0x72BE880", VA = "0x1872BFE80", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x72BD700", Offset = "0x72BC100", VA = "0x1872BD700", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public BBKEJCDCLFA AOGHHFMNIGH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x72BEE50", Offset = "0x72BD850", VA = "0x1872BEE50", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x72BE680", Offset = "0x72BD080", VA = "0x1872BE680", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float OHPFGDDNLOG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x72BD430", Offset = "0x72BBE30", VA = "0x1872BD430", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x72BD760", Offset = "0x72BC160", VA = "0x1872BD760", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 PFNOKEMFJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x72BD520", Offset = "0x72BBF20", VA = "0x1872BD520", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x72BFBC0", Offset = "0x72BE5C0", VA = "0x1872BFBC0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 DKKOHOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x72C0700", Offset = "0x72BF100", VA = "0x1872C0700", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x72C0BE0", Offset = "0x72BF5E0", VA = "0x1872C0BE0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 GJNHMHCKKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x72C2B30", Offset = "0x72C1530", VA = "0x1872C2B30", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x72C2FF0", Offset = "0x72C19F0", VA = "0x1872C2FF0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 GAEJILGJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x72C1550", Offset = "0x72BFF50", VA = "0x1872C1550", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x72BF690", Offset = "0x72BE090", VA = "0x1872BF690", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool CGOAGBDFOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x72BD650", Offset = "0x72BC050", VA = "0x1872BD650", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool EJHGOMAIJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x72C26B0", Offset = "0x72C10B0", VA = "0x1872C26B0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool AKHLIBBDLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x72BD900", Offset = "0x72BC300", VA = "0x1872BD900", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool ENBMDKNMHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x72BDCB0", Offset = "0x72BC6B0", VA = "0x1872BDCB0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 BNNAKBMDNKI
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x72BF260", Offset = "0x72BDC60", VA = "0x1872BF260", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 ECNEMFJNMLD
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x72C01F0", Offset = "0x72BEBF0", VA = "0x1872C01F0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 JBNBGKGBAKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x72BED20", Offset = "0x72BD720", VA = "0x1872BED20", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x72C1A50", Offset = "0x72C0450", VA = "0x1872C1A50", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 LDFAKINHCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x72C0430", Offset = "0x72BEE30", VA = "0x1872C0430", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float LINHIOGBDJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x72BDE00", Offset = "0x72BC800", VA = "0x1872BDE00", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float ABINEMAJDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x72C03E0", Offset = "0x72BEDE0", VA = "0x1872C03E0", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x72C2480", Offset = "0x72C0E80", VA = "0x1872C2480", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 LALMNOFKGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x72C2710", Offset = "0x72C1110", VA = "0x1872C2710", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion KPBECAOAIDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x72C1740", Offset = "0x72C0140", VA = "0x1872C1740", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float NEAAAENLEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x72BD480", Offset = "0x72BBE80", VA = "0x1872BD480", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x72BE740", Offset = "0x72BD140", VA = "0x1872BE740", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float CHNNGEICIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x72BDF30", Offset = "0x72BC930", VA = "0x1872BDF30", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x72C2240", Offset = "0x72C0C40", VA = "0x1872C2240", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool FGACBMNAHCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x72BEC80", Offset = "0x72BD680", VA = "0x1872BEC80", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x72BFDF0", Offset = "0x72BE7F0", VA = "0x1872BFDF0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IDPKEMCPFEK LDMEPBIHABI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x72C0B90", Offset = "0x72BF590", VA = "0x1872C0B90", Slot = "68")]
		get
		{
			return default(IDPKEMCPFEK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x72C22A0", Offset = "0x72C0CA0", VA = "0x1872C22A0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool GBINOLADCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x72C12A0", Offset = "0x72BFCA0", VA = "0x1872C12A0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform JOJCKMBBNHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x897DE0", Offset = "0x8967E0", VA = "0x180897DE0", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 PKIKEFANDCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x72C02D0", Offset = "0x72BECD0", VA = "0x1872C02D0", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x72C2D80", Offset = "0x72C1780", VA = "0x1872C2D80", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float CJEPBLIJPDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x72BF910", Offset = "0x72BE310", VA = "0x1872BF910", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x72BF590", Offset = "0x72BDF90", VA = "0x1872BF590", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float LEFOLJKLIPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x72BFCA0", Offset = "0x72BE6A0", VA = "0x1872BFCA0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x72BDA40", Offset = "0x72BC440", VA = "0x1872BDA40", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion NGDPLNEHBDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x72BE140", Offset = "0x72BCB40", VA = "0x1872BE140", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x72C1D40", Offset = "0x72C0740", VA = "0x1872C1D40", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 NBIMBFHIDEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x72C0010", Offset = "0x72BEA10", VA = "0x1872C0010", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x72BDF80", Offset = "0x72BC980", VA = "0x1872BDF80", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion DGNKNFBAMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x72C1510", Offset = "0x72BFF10", VA = "0x1872C1510", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x72BFE50", Offset = "0x72BE850", VA = "0x1872BFE50", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints BIJPIEOKJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x72BE800", Offset = "0x72BD200", VA = "0x1872BE800", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x72BE550", Offset = "0x72BCF50", VA = "0x1872BE550", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool CHOMHMJJDAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x72C1E20", Offset = "0x72C0820", VA = "0x1872C1E20", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x72C2C10", Offset = "0x72C1610", VA = "0x1872C2C10", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode OHGCCBCICEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x72BECD0", Offset = "0x72BD6D0", VA = "0x1872BECD0", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x72BD9E0", Offset = "0x72BC3E0", VA = "0x1872BD9E0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool DJDPKKNHDEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x72BFCB0", Offset = "0x72BE6B0", VA = "0x1872BFCB0", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool KBGODMPIDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x72C2300", Offset = "0x72C0D00", VA = "0x1872C2300", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event LDHKFCBONJG HAPCHNBOPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x72C24E0", Offset = "0x72C0EE0", VA = "0x1872C24E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x72C09E0", Offset = "0x72BF3E0", VA = "0x1872C09E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event LDHKFCBONJG ALMMOHFNLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x72C1120", Offset = "0x72BFB20", VA = "0x1872C1120", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x72C2540", Offset = "0x72C0F40", VA = "0x1872C2540", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event KHNKEDFCPCA LMKJBLGMEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x72C10C0", Offset = "0x72BFAC0", VA = "0x1872C10C0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x72C2650", Offset = "0x72C1050", VA = "0x1872C2650", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event LDHKFCBONJG NFNPGGIDPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x72C0FB0", Offset = "0x72BF9B0", VA = "0x1872C0FB0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x72C30D0", Offset = "0x72C1AD0", VA = "0x1872C30D0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event LDHKFCBONJG HHBHHCLMKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x72BD6A0", Offset = "0x72BC0A0", VA = "0x1872BD6A0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x72C2E30", Offset = "0x72C1830", VA = "0x1872C2E30", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event LDHKFCBONJG MAPLCBMMGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x72C0CC0", Offset = "0x72BF6C0", VA = "0x1872C0CC0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x72C0B30", Offset = "0x72BF530", VA = "0x1872C0B30", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<MGNMBPEAPIF, MGNMBPEAPIF> HGNPDKHNLHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x72C1630", Offset = "0x72C0030", VA = "0x1872C1630", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x72BE6E0", Offset = "0x72BD0E0", VA = "0x1872BE6E0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event LDHKFCBONJG CJBJKADPOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x72C12F0", Offset = "0x72BFCF0", VA = "0x1872C12F0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x72BFA00", Offset = "0x72BE400", VA = "0x1872BFA00", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event LDHKFCBONJG CLODFINLIGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x72BDC00", Offset = "0x72BC600", VA = "0x1872BDC00", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x72C0650", Offset = "0x72BF050", VA = "0x1872C0650", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x72C3220", Offset = "0x72C1C20", VA = "0x1872C3220")]
	public HDBLPCDAJNK(GameObject MNKAGJEGJCF, RigidbodyEx ELEFADMBDGP, PLEPOBHCEGN EHABNPPLNPG, [In] OCGBPCDKBKC JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x72C2840", Offset = "0x72C1240", VA = "0x1872C2840", Slot = "136")]
	protected virtual void OJHNCDGLBJM(PLEPOBHCEGN EHABNPPLNPG, OCGBPCDKBKC JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x72BE5B0", Offset = "0x72BCFB0", VA = "0x1872BE5B0", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x72BD7C0", Offset = "0x72BC1C0", VA = "0x1872BD7C0", Slot = "91")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x72BD3E0", Offset = "0x72BBDE0", VA = "0x1872BD3E0", Slot = "92")]
	public void ADALIIEJKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x72BF670", Offset = "0x72BE070", VA = "0x1872BF670", Slot = "93")]
	public void GICFABMMEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x72BE8A0", Offset = "0x72BD2A0", VA = "0x1872BE8A0")]
	private void FDNCIOBOPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x72BF510", Offset = "0x72BDF10", VA = "0x1872BF510", Slot = "30")]
	public LIIKICNCDGJ GEFJICFDKLF(int HGFDMIDEFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x72C2CC0", Offset = "0x72C16C0", VA = "0x1872C2CC0", Slot = "95")]
	public void OOCNJIHJKBG(LIIKICNCDGJ KLABJGGMBGH, bool AMABBFGDEKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x72C1060", Offset = "0x72BFA60", VA = "0x1872C1060", Slot = "96")]
	public void JJMPFDCNDHH(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x72BDFC0", Offset = "0x72BC9C0", VA = "0x1872BDFC0", Slot = "97")]
	public void DCPDNOOILNJ(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x72C2E90", Offset = "0x72C1890", VA = "0x1872C2E90", Slot = "98")]
	public Vector3 PBFBIDMAHAC(Vector3 FOEOPLOKPOB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x72C0050", Offset = "0x72BEA50", VA = "0x1872C0050", Slot = "99")]
	public Vector3 IAPPHLOLCLB(Vector3 CALOMLJNHAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x72BD3E0", Offset = "0x72BBDE0", VA = "0x1872BD3E0", Slot = "100")]
	public void DLEEIKFFPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x72BEE00", Offset = "0x72BD800", VA = "0x1872BEE00", Slot = "101")]
	public void FNJCHAFGION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x72BD600", Offset = "0x72BC000", VA = "0x1872BD600", Slot = "102")]
	public void BJBDPEAHGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x72C0A40", Offset = "0x72BF440", VA = "0x1872C0A40", Slot = "103")]
	public void IPGHPFLDEBA(Vector3 MEKMEJHIFMC, Vector3 KBNCPNDBCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x72BFF20", Offset = "0x72BE920", VA = "0x1872BFF20", Slot = "104")]
	public void IADKCNKPDLN(Vector3 AHEKOJPDIDP, Vector3 JKDCCBAFKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x72BDE50", Offset = "0x72BC850", VA = "0x1872BDE50", Slot = "105")]
	public void CODKDPLCDHD(Vector3 IEAGHIDJHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x72BFB00", Offset = "0x72BE500", VA = "0x1872BFB00", Slot = "106")]
	public void HHIIHBGIEBI(DCOEIOEOLOO OGDHOAEFGEK, Vector3 ADCIKHMIKDC, float BFNABEBMGML, float EJJOPELHGIF = 8f, float ODMENHHKENK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x72C0150", Offset = "0x72BEB50", VA = "0x1872C0150", Slot = "107")]
	public void IBGBKJDOGEF(HLIEOJLMCMD DLJHIKDDMED, Vector3 FDNLGBMHIMG, float LGADHHDBLPE = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x72C25A0", Offset = "0x72C0FA0", VA = "0x1872C25A0", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void NICHPOJBKKJ(HLIEOJLMCMD DLJHIKDDMED, Vector3 JOLHFCINNMA, float LGCLKPGINJF = 7f, float GNAMHFMCPHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x72C1410", Offset = "0x72BFE10", VA = "0x1872C1410", Slot = "109")]
	public Vector3 KMAMKOPDPLJ(Vector3 KLABJGGMBGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x72BDD00", Offset = "0x72BC700", VA = "0x1872BDD00", Slot = "110")]
	public Vector3 CJOMOILHAIC(Vector3 KLABJGGMBGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x72C3190", Offset = "0x72C1B90", VA = "0x1872C3190", Slot = "111")]
	public void PMJJMHPJAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x72BF600", Offset = "0x72BE000", VA = "0x1872BF600", Slot = "112")]
	public void GGPIDHALABF(LIIKICNCDGJ CEECOCODHNB, object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x72BE7A0", Offset = "0x72BD1A0", VA = "0x1872BE7A0", Slot = "113")]
	public void EOKDJDIFNHB(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x72C0D20", Offset = "0x72BF720", VA = "0x1872C0D20", Slot = "61")]
	public void JGHOGCEFAIE((Quaternion rot, Vector3 moments) JBHPDEADHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x72BFAB0", Offset = "0x72BE4B0", VA = "0x1872BFAB0", Slot = "114")]
	public void HGAGCFBNGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x72C2C70", Offset = "0x72C1670", VA = "0x1872C2C70", Slot = "115")]
	public void OMMIJCKCGMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x72C1180", Offset = "0x72BFB80", VA = "0x1872C1180", Slot = "116")]
	public void JNIJLCFKCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x72BD4D0", Offset = "0x72BBED0", VA = "0x1872BD4D0", Slot = "117")]
	public bool BEIIONGBDOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x72C0E00", Offset = "0x72BF800", VA = "0x1872C0E00", Slot = "94")]
	public void JGJAPHHHLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x72C27F0", Offset = "0x72C11F0", VA = "0x1872C27F0", Slot = "118")]
	public void OIPENABPJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x72C21E0", Offset = "0x72C0BE0", VA = "0x1872C21E0", Slot = "119")]
	public void MLIEHFDDMKO(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x72C2F90", Offset = "0x72C1990", VA = "0x1872C2F90", Slot = "120")]
	public void PBJGEJFAFPH(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x72C0510", Offset = "0x72BEF10", VA = "0x1872C0510", Slot = "121")]
	public void IIKHLAALMID(object FLLNLBHFENG, bool HJBOCAGMBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x72C07E0", Offset = "0x72BF1E0", VA = "0x1872C07E0", Slot = "122")]
	public void IONGMLONIEL(Vector3 ALEJNJJFLEH, Quaternion AJOIIFAELBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x72C1B30", Offset = "0x72C0530", VA = "0x1872C1B30", Slot = "123")]
	public void LOPIGIIJLAG(Vector3 PFAHFEPFAAJ, Quaternion NKABCINOOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x72BE850", Offset = "0x72BD250", VA = "0x1872BE850", Slot = "124")]
	public bool FDEJIKDPNDF(float OADJCOEBHOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x72BF330", Offset = "0x72BDD30", VA = "0x1872BF330", Slot = "125")]
	public void GCABGAHFDOG(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x72BEC20", Offset = "0x72BD620", VA = "0x1872BEC20", Slot = "126")]
	public void FJJFBANMDNK(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x72C05F0", Offset = "0x72BEFF0", VA = "0x1872C05F0", Slot = "127")]
	public void IMDNBJHCJDN(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x72C0380", Offset = "0x72BED80", VA = "0x1872C0380", Slot = "128")]
	public void IFBCHBJDHFA(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x72BDB20", Offset = "0x72BC520", VA = "0x1872BDB20", Slot = "129")]
	public void CHFHEKALINP(Vector3 LENLJCDCMCG, ForceMode KNHJEAKHHDM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x72BEA30", Offset = "0x72BD430", VA = "0x1872BEA30", Slot = "130")]
	public void FGINIKMJJCN(Vector3 LENLJCDCMCG, Vector3 LEELMECKGCG, ForceMode KNHJEAKHHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x72BF920", Offset = "0x72BE320", VA = "0x1872BF920", Slot = "131")]
	public void HCJOOMKAIIF(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x72BEB40", Offset = "0x72BD540", VA = "0x1872BEB40", Slot = "132")]
	public void FIKJJJCHOCM(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x72BF770", Offset = "0x72BE170", VA = "0x1872BF770", Slot = "133")]
	public bool GNBADKMPLDL(Vector3 JFCINBHKCNC, [Out] RaycastHit DPMDGOFFPKK, float KEEIEBHGPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x72C2D30", Offset = "0x72C1730", VA = "0x1872C2D30", Slot = "134")]
	public void OPJOMHHIOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x72C31E0", Offset = "0x72C1BE0", VA = "0x1872C31E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x72C1C70", Offset = "0x72C0670", VA = "0x1872C1C70")]
	private void MAECMFALOHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x72BE920", Offset = "0x72BD320", VA = "0x1872BE920")]
	private void FEHNMBACMKC(LIIKICNCDGJ LDJCBIBELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x72C1870", Offset = "0x72C0270", VA = "0x1872C1870")]
	private void LKKANNMKPCC(LIIKICNCDGJ LDJCBIBELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x72C1690", Offset = "0x72C0090", VA = "0x1872C1690")]
	private void LIHDCLJKFPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x72BF810", Offset = "0x72BE210", VA = "0x1872BF810")]
	private void GPIFCMFJGOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x72BF390", Offset = "0x72BDD90", VA = "0x1872BF390")]
	private void GCEAJLGMLAO(LIIKICNCDGJ MKEMFFOAONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x72C11D0", Offset = "0x72BFBD0", VA = "0x1872C11D0")]
	private void JPEFCMPOPCG(LIIKICNCDGJ LDJCBIBELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x72BE070", Offset = "0x72BCA70", VA = "0x1872BE070")]
	private void DEBKOMLEGPA(LIIKICNCDGJ LDJCBIBELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x72C0E50", Offset = "0x72BF850", VA = "0x1872C0E50")]
	private void JGMMPGMIHFI(EKIGEEIGKIO LDJCBIBELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x72BEEA0", Offset = "0x72BD8A0", VA = "0x1872BEEA0", Slot = "141")]
	protected virtual void FNONFAOOJAN(EKIGEEIGKIO IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x72C1EC0", Offset = "0x72C08C0", VA = "0x1872C1EC0")]
	protected void MICNHICNDGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x72BE1E0", Offset = "0x72BCBE0", VA = "0x1872BE1E0")]
	protected void DGMNBIPNFCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x72C1350", Offset = "0x72BFD50", VA = "0x1872C1350", Slot = "142")]
	protected virtual IDisposable KGHHKDJJCKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class POBLGGPCKOL
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x72CA060", Offset = "0x72C8A60", VA = "0x1872CA060")]
	public static LIIKICNCDGJ EGEDFEICPLP(this LIIKICNCDGJ IOHJIPHILJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x72CA120", Offset = "0x72C8B20", VA = "0x1872CA120")]
	public static bool GIAEJNADIKG(this LIIKICNCDGJ IOHJIPHILJI, LIIKICNCDGJ NJFMAAHNHCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x72CA1A0", Offset = "0x72C8BA0", VA = "0x1872CA1A0")]
	public static bool HNCJDKEBHLC(this LIIKICNCDGJ IOHJIPHILJI, LIIKICNCDGJ EMNAFJIGFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x72CA220", Offset = "0x72C8C20", VA = "0x1872CA220")]
	public static EKIGEEIGKIO IHNGEPJPIOF(this LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x72CA270", Offset = "0x72C8C70", VA = "0x1872CA270")]
	public static HDBLPCDAJNK MNNCAMHKCIE(this LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BPHGPPJLIDK : DFHCEAJLAEJ
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x72B6050", Offset = "0x72B4A50", VA = "0x1872B6050", Slot = "19")]
	public LIIKICNCDGJ ENFLHFFGAOB(RigidbodyEx IOHJIPHILJI, OCGBPCDKBKC JGCMECODHDI, PLEPOBHCEGN EHABNPPLNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "4")]
	public AJKKKNAMDJO FEFKNLMJDGI(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "5")]
	public AOKAONLJHOF MKBPNEELGIH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "6")]
	public DEGIIDBFCIH LCECHNCNPPN(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "7")]
	public KJJGDBKLOGE LEKMAHANNMM(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "8")]
	public ENMPBGGDGOP JADPOEEKFJA(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "9")]
	public KIAJJIOCNGO CPFFGDECCLE(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "10")]
	public KIAAOCCDDCB NBINMFELFGP(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "11")]
	public HEBLMGHFANA GDADELKPNAH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "12")]
	public IJJJKIKMEKK DGGJKEDCOKH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "13")]
	public LKNIHEGCKKI IILOOAKBFCC(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360")]
	public HMNMNHHFKJC GBCLHDECGFM(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360")]
	public OMJMPOHILOG FPMDDNDJJCF(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360")]
	public CDFAFOAFKII FMNBBFAABKB(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360")]
	public GKHFDEMHCGH IICGHNCEKCL(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360")]
	public NEDIICPLNME PBLEFFOELKN(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public BPHGPPJLIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "14")]
	private HMNMNHHFKJC MPMJAKCFNOD(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "15")]
	private OMJMPOHILOG AGEFOPNFPME(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "16")]
	private CDFAFOAFKII IAKCJKBIMCK(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "17")]
	private GKHFDEMHCGH DLEIFLNLDHE(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "18")]
	private NEDIICPLNME BPPGEMGHLLD(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[AODOHJCIOJB(typeof(DFHCEAJLAEJ), new string[] { })]
public class ABCHDKLPAHH : DFHCEAJLAEJ, KINLAMFGOOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly DFHCEAJLAEJ JDFNAEKAHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly DFHCEAJLAEJ EFJHHEECOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private CHGFOFIHPPB LILKAOEDHFA;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private DFHCEAJLAEJ DMCOGGNKFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x72B4D20", Offset = "0x72B3720", VA = "0x1872B4D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x72B4AF0", Offset = "0x72B34F0", VA = "0x1872B4AF0", Slot = "20")]
	public void InitReferences(GOMDDPLFKLJ KKAHGNKMLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x72B47B0", Offset = "0x72B31B0", VA = "0x1872B47B0", Slot = "4")]
	public AJKKKNAMDJO FEFKNLMJDGI(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x72B4D80", Offset = "0x72B3780", VA = "0x1872B4D80", Slot = "5")]
	public AOKAONLJHOF MKBPNEELGIH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x72B4BE0", Offset = "0x72B35E0", VA = "0x1872B4BE0", Slot = "6")]
	public DEGIIDBFCIH LCECHNCNPPN(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x72B4C80", Offset = "0x72B3680", VA = "0x1872B4C80", Slot = "7")]
	public KJJGDBKLOGE LEKMAHANNMM(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x72B4B40", Offset = "0x72B3540", VA = "0x1872B4B40", Slot = "8")]
	public ENMPBGGDGOP JADPOEEKFJA(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x72B44E0", Offset = "0x72B2EE0", VA = "0x1872B44E0", Slot = "9")]
	public KIAJJIOCNGO CPFFGDECCLE(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x72B4E20", Offset = "0x72B3820", VA = "0x1872B4E20", Slot = "10")]
	public KIAAOCCDDCB NBINMFELFGP(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x72B49B0", Offset = "0x72B33B0", VA = "0x1872B49B0", Slot = "11")]
	public HEBLMGHFANA GDADELKPNAH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x72B4580", Offset = "0x72B2F80", VA = "0x1872B4580", Slot = "12")]
	public IJJJKIKMEKK DGGJKEDCOKH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x72B4A50", Offset = "0x72B3450", VA = "0x1872B4A50", Slot = "13")]
	public LKNIHEGCKKI IILOOAKBFCC(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x72B4900", Offset = "0x72B3300", VA = "0x1872B4900")]
	public HMNMNHHFKJC GBCLHDECGFM(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x72B4380", Offset = "0x72B2D80", VA = "0x1872B4380")]
	public OMJMPOHILOG FPMDDNDJJCF(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x72B4850", Offset = "0x72B3250", VA = "0x1872B4850")]
	public CDFAFOAFKII FMNBBFAABKB(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x72B4620", Offset = "0x72B3020", VA = "0x1872B4620")]
	public GKHFDEMHCGH IICGHNCEKCL(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x72B4430", Offset = "0x72B2E30", VA = "0x1872B4430")]
	public NEDIICPLNME PBLEFFOELKN(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x72B46D0", Offset = "0x72B30D0", VA = "0x1872B46D0", Slot = "19")]
	public LIIKICNCDGJ ENFLHFFGAOB(RigidbodyEx IOHJIPHILJI, OCGBPCDKBKC JGCMECODHDI, PLEPOBHCEGN EHABNPPLNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x72B4EC0", Offset = "0x72B38C0", VA = "0x1872B4EC0")]
	public ABCHDKLPAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x72B4900", Offset = "0x72B3300", VA = "0x1872B4900", Slot = "14")]
	private HMNMNHHFKJC MPMJAKCFNOD(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x72B4380", Offset = "0x72B2D80", VA = "0x1872B4380", Slot = "15")]
	private OMJMPOHILOG AGEFOPNFPME(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x72B4850", Offset = "0x72B3250", VA = "0x1872B4850", Slot = "16")]
	private CDFAFOAFKII IAKCJKBIMCK(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x72B4620", Offset = "0x72B3020", VA = "0x1872B4620", Slot = "17")]
	private GKHFDEMHCGH DLEIFLNLDHE(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x72B4430", Offset = "0x72B2E30", VA = "0x1872B4430", Slot = "18")]
	private NEDIICPLNME BPPGEMGHLLD(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ILJIOPAKFEB : AJKKKNAMDJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHLBCINICIP(LIIKICNCDGJ IOHJIPHILJI);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBJFOPHLCHM(LIIKICNCDGJ IOHJIPHILJI);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICNHCIBJJPB(LIIKICNCDGJ MKEMFFOAONA);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJNCIJPMKLL(LIIKICNCDGJ MKEMFFOAONA);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FODKLOJKGKG : DEGIIDBFCIH
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	EAIGACMIAOO<LIIKICNCDGJ> CLJIKLFCENI
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	LIIKICNCDGJ GBBIDMLGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface EHOMHIKFOEC : GKHFDEMHCGH
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) FGIJBHJABKI(Rigidbody INJJGGGMMHL);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface JIFGONMADEL : OMJMPOHILOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView GCPCGKLIKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class PJMCOFDOGMD : IJJJKIKMEKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly HDBLPCDAJNK IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private CollisionDetectionMode PGBDBKONKHA;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody KJODLCHDEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x72BC580", Offset = "0x72BAF80", VA = "0x1872BC580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode OHGCCBCICEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x72C9CC0", Offset = "0x72C86C0", VA = "0x1872C9CC0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x72C9BC0", Offset = "0x72C85C0", VA = "0x1872C9BC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x72B9970", Offset = "0x72B8370", VA = "0x1872B9970")]
	public PJMCOFDOGMD(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x72C9AB0", Offset = "0x72C84B0", VA = "0x1872C9AB0", Slot = "6")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x72C9C30", Offset = "0x72C8630", VA = "0x1872C9C30", Slot = "9")]
	public void CFCFDMGBDJO(Rigidbody OLNABEIJDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x72C9F30", Offset = "0x72C8930", VA = "0x1872C9F30", Slot = "7")]
	public void HNFBAGBIDGN(bool ILMFJGEOAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x72C9CB0", Offset = "0x72C86B0", VA = "0x1872C9CB0", Slot = "8")]
	public void EGEGGPMALGL(bool ILMFJGEOAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x72C9DD0", Offset = "0x72C87D0", VA = "0x1872C9DD0", Slot = "10")]
	public bool GNBADKMPLDL(Vector3 JFCINBHKCNC, [Out] RaycastHit DPMDGOFFPKK, float KEEIEBHGPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x72C9F40", Offset = "0x72C8940", VA = "0x1872C9F40")]
	private void IMEPGPPKGNP(bool ILMFJGEOAEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LFNMKGGOEFG : KIAJJIOCNGO, IDisposable, PLHBJJNCKPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly HDBLPCDAJNK IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private IDPKEMCPFEK BMEDHNOHFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NHDPODLODNG INJLNJOJGAI;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public IDPKEMCPFEK LDMEPBIHABI
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x72C5260", Offset = "0x72C3C60", VA = "0x1872C5260", Slot = "6")]
		get
		{
			return default(IDPKEMCPFEK);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x72C5450", Offset = "0x72C3E50", VA = "0x1872C5450", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform IFEDLKIIKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x72C4ED0", Offset = "0x72C38D0", VA = "0x1872C4ED0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<MGNMBPEAPIF, MGNMBPEAPIF> HGNPDKHNLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x72C53A0", Offset = "0x72C3DA0", VA = "0x1872C53A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x72C51B0", Offset = "0x72C3BB0", VA = "0x1872C51B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x72C5520", Offset = "0x72C3F20", VA = "0x1872C5520")]
	public LFNMKGGOEFG(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x72C4EF0", Offset = "0x72C38F0", VA = "0x1872C4EF0", Slot = "8")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x72C5160", Offset = "0x72C3B60", VA = "0x1872C5160", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xBC93A0", Offset = "0xBC7DA0", VA = "0x180BC93A0", Slot = "11")]
	private void KLIDDCMEIFA(MGNMBPEAPIF FOLFJJOEOPG, MGNMBPEAPIF EDIGGMGOMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "12")]
	private void AEDBPGIDLOI(bool ABGDCOOCPNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OKOCGDNIHAO : DFHCEAJLAEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x72C9110", Offset = "0x72C7B10", VA = "0x1872C9110", Slot = "4")]
	public AJKKKNAMDJO FEFKNLMJDGI(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x72C9870", Offset = "0x72C8270", VA = "0x1872C9870", Slot = "5")]
	public AOKAONLJHOF MKBPNEELGIH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x72C96C0", Offset = "0x72C80C0", VA = "0x1872C96C0", Slot = "6")]
	public DEGIIDBFCIH LCECHNCNPPN(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x72C97F0", Offset = "0x72C81F0", VA = "0x1872C97F0", Slot = "7")]
	public KJJGDBKLOGE LEKMAHANNMM(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x72C95F0", Offset = "0x72C7FF0", VA = "0x1872C95F0", Slot = "8")]
	public ENMPBGGDGOP JADPOEEKFJA(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x72C8CA0", Offset = "0x72C76A0", VA = "0x1872C8CA0", Slot = "9")]
	public KIAJJIOCNGO CPFFGDECCLE(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x72C9990", Offset = "0x72C8390", VA = "0x1872C9990", Slot = "10")]
	public KIAAOCCDDCB NBINMFELFGP(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x72C9470", Offset = "0x72C7E70", VA = "0x1872C9470", Slot = "11")]
	public HEBLMGHFANA GDADELKPNAH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x72C8D70", Offset = "0x72C7770", VA = "0x1872C8D70", Slot = "12")]
	public IJJJKIKMEKK DGGJKEDCOKH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x72C9530", Offset = "0x72C7F30", VA = "0x1872C9530", Slot = "13")]
	public LKNIHEGCKKI IILOOAKBFCC(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x72C9330", Offset = "0x72C7D30", VA = "0x1872C9330")]
	public HMNMNHHFKJC GBCLHDECGFM(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x72C8A30", Offset = "0x72C7430", VA = "0x1872C8A30")]
	public OMJMPOHILOG FPMDDNDJJCF(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x72C9200", Offset = "0x72C7C00", VA = "0x1872C9200")]
	public CDFAFOAFKII FMNBBFAABKB(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x72C8E30", Offset = "0x72C7830", VA = "0x1872C8E30")]
	public GKHFDEMHCGH IICGHNCEKCL(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x72C8BC0", Offset = "0x72C75C0", VA = "0x1872C8BC0")]
	public NEDIICPLNME PBLEFFOELKN(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x72C8FC0", Offset = "0x72C79C0", VA = "0x1872C8FC0", Slot = "19")]
	public LIIKICNCDGJ ENFLHFFGAOB(RigidbodyEx IOHJIPHILJI, OCGBPCDKBKC JGCMECODHDI, PLEPOBHCEGN EHABNPPLNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public OKOCGDNIHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x72C9330", Offset = "0x72C7D30", VA = "0x1872C9330", Slot = "14")]
	private HMNMNHHFKJC MPMJAKCFNOD(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x72C8A30", Offset = "0x72C7430", VA = "0x1872C8A30", Slot = "15")]
	private OMJMPOHILOG AGEFOPNFPME(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x72C9200", Offset = "0x72C7C00", VA = "0x1872C9200", Slot = "16")]
	private CDFAFOAFKII IAKCJKBIMCK(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x72C8E30", Offset = "0x72C7830", VA = "0x1872C8E30", Slot = "17")]
	private GKHFDEMHCGH DLEIFLNLDHE(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x72C8BC0", Offset = "0x72C75C0", VA = "0x1872C8BC0", Slot = "18")]
	private NEDIICPLNME BPPGEMGHLLD(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class FAGPJFMMCAN : HEBLMGHFANA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HDBLPCDAJNK IOHJIPHILJI;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody KJODLCHDEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x72BC580", Offset = "0x72BAF80", VA = "0x1872BC580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool GBINOLADCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x72BCC70", Offset = "0x72BB670", VA = "0x1872BCC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool IIJMHMHEHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x72B5A30", Offset = "0x72B4430", VA = "0x1872B5A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private LIIKICNCDGJ NPDGLEPLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x72BCC10", Offset = "0x72BB610", VA = "0x1872BCC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x72B9970", Offset = "0x72B8370", VA = "0x1872B9970")]
	public FAGPJFMMCAN(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x72BC420", Offset = "0x72BAE20", VA = "0x1872BC420", Slot = "4")]
	public void CHFHEKALINP(Vector3 LENLJCDCMCG, ForceMode KNHJEAKHHDM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x72BCCC0", Offset = "0x72BB6C0", VA = "0x1872BCCC0")]
	private void KMEALNCAKNG(Vector3 LENLJCDCMCG, ForceMode KNHJEAKHHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x72BC5D0", Offset = "0x72BAFD0", VA = "0x1872BC5D0", Slot = "5")]
	public void FGINIKMJJCN(Vector3 LENLJCDCMCG, Vector3 LEELMECKGCG, ForceMode KNHJEAKHHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x72BCAB0", Offset = "0x72BB4B0", VA = "0x1872BCAB0", Slot = "6")]
	public void HCJOOMKAIIF(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x72BCF20", Offset = "0x72BB920", VA = "0x1872BCF20")]
	private void PNMFGIKJIBH(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x72BC850", Offset = "0x72BB250", VA = "0x1872BC850", Slot = "7")]
	public void FIKJJJCHOCM(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class DILAANDHNIC : LKNIHEGCKKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HDBLPCDAJNK IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool GKFNMBGEFBF;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool FGACBMNAHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xAC0390", Offset = "0xABED90", VA = "0x180AC0390", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x72B97F0", Offset = "0x72B81F0", VA = "0x1872B97F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x72B9970", Offset = "0x72B8370", VA = "0x1872B9970")]
	public DILAANDHNIC(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x72B97C0", Offset = "0x72B81C0", VA = "0x1872B97C0", Slot = "6")]
	public void CFCFDMGBDJO(Rigidbody OLNABEIJDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x72B9900", Offset = "0x72B8300", VA = "0x1872B9900", Slot = "7")]
	public void KLMOMCBKCOC(Rigidbody OLNABEIJDDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class ODNEPNKNCAK : ILJIOPAKFEB, AJKKKNAMDJO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LIIKICNCDGJ IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<LIIKICNCDGJ> IOGPEHBLNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private LIIKICNCDGJ JPBBEMPIGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private LIIKICNCDGJ LDJCBIBELIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private Transform GFJMMKIGALI;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform MJIIFCFMCAF
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x72C7080", Offset = "0x72C5A80", VA = "0x1872C7080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public LIIKICNCDGJ NPDGLEPLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x899950", Offset = "0x898350", VA = "0x180899950", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x72C88C0", Offset = "0x72C72C0", VA = "0x1872C88C0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public LIIKICNCDGJ GEBPHFIJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x898840", Offset = "0x897240", VA = "0x180898840", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<LIIKICNCDGJ> FCLKNFGAHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x898870", Offset = "0x897270", VA = "0x180898870", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event LDHKFCBONJG HAPCHNBOPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x72C8040", Offset = "0x72C6A40", VA = "0x1872C8040", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x72C77E0", Offset = "0x72C61E0", VA = "0x1872C77E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event LDHKFCBONJG ALMMOHFNLGC
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x72C7BA0", Offset = "0x72C65A0", VA = "0x1872C7BA0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x72C80E0", Offset = "0x72C6AE0", VA = "0x1872C80E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event KHNKEDFCPCA LMKJBLGMEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x72C7B00", Offset = "0x72C6500", VA = "0x1872C7B00", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x72C8180", Offset = "0x72C6B80", VA = "0x1872C8180", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action ANMGCGOCFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x72C6B70", Offset = "0x72C5570", VA = "0x1872C6B70", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x72C7DA0", Offset = "0x72C67A0", VA = "0x1872C7DA0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action FNEODFAMECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x72C7180", Offset = "0x72C5B80", VA = "0x1872C7180", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x72C88D0", Offset = "0x72C72D0", VA = "0x1872C88D0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<LIIKICNCDGJ> KPHMOBEEIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x72C7F90", Offset = "0x72C6990", VA = "0x1872C7F90", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x72C7CF0", Offset = "0x72C66F0", VA = "0x1872C7CF0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<LIIKICNCDGJ> PLJJCAEANAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x72C7C40", Offset = "0x72C6640", VA = "0x1872C7C40", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x72C7420", Offset = "0x72C5E20", VA = "0x1872C7420", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action EKFLHALGKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x72C7740", Offset = "0x72C6140", VA = "0x1872C7740", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x72C7220", Offset = "0x72C5C20", VA = "0x1872C7220", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<LIIKICNCDGJ> MPBOIHOJJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x72C7E40", Offset = "0x72C6840", VA = "0x1872C7E40", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x72C6FD0", Offset = "0x72C59D0", VA = "0x1872C6FD0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x72C8970", Offset = "0x72C7370", VA = "0x1872C8970")]
	public ODNEPNKNCAK(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x72C70E0", Offset = "0x72C5AE0", VA = "0x1872C70E0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x72C8220", Offset = "0x72C6C20", VA = "0x1872C8220", Slot = "30")]
	public void OOCNJIHJKBG(LIIKICNCDGJ LEEMAEKICLM, bool AMABBFGDEKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x72C74D0", Offset = "0x72C5ED0", VA = "0x1872C74D0", Slot = "6")]
	public void ICNHCIBJJPB(LIIKICNCDGJ MKEMFFOAONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x72C7880", Offset = "0x72C6280", VA = "0x1872C7880", Slot = "7")]
	public void JJNCIJPMKLL(LIIKICNCDGJ MKEMFFOAONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x72C6C10", Offset = "0x72C5610", VA = "0x1872C6C10", Slot = "4")]
	public void BHLBCINICIP(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x72C7EF0", Offset = "0x72C68F0", VA = "0x1872C7EF0", Slot = "5")]
	public void MBJFOPHLCHM(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x72C72C0", Offset = "0x72C5CC0", VA = "0x1872C72C0")]
	private void FLODNCANFJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x72C6D20", Offset = "0x72C5720", VA = "0x1872C6D20")]
	private void BOJFJPJNMEM(LIIKICNCDGJ MKEMFFOAONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x72C6E90", Offset = "0x72C5890", VA = "0x1872C6E90")]
	private void CCIKNEDOJLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x72C6D60", Offset = "0x72C5760", VA = "0x1872C6D60")]
	private void CAOPJHOHEKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x72C87A0", Offset = "0x72C71A0", VA = "0x1872C87A0")]
	private void OPNNLEFPCDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x72C7360", Offset = "0x72C5D60", VA = "0x1872C7360")]
	[CompilerGenerated]
	private object GNHNGJHPALM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class MCPIPFFDOLA
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x72C58B0", Offset = "0x72C42B0", VA = "0x1872C58B0")]
	public static ILJIOPAKFEB BFGOGNFHPPB(this LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class KGJMHCLOIIP : FODKLOJKGKG, DEGIIDBFCIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly HDBLPCDAJNK IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly EAIGACMIAOO<LIIKICNCDGJ> GNCMJCKJPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool KOPFHGOJFFJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public EAIGACMIAOO<LIIKICNCDGJ> CLJIKLFCENI
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 BNNAKBMDNKI
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x72C44D0", Offset = "0x72C2ED0", VA = "0x1872C44D0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 ECNEMFJNMLD
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x72C4500", Offset = "0x72C2F00", VA = "0x1872C4500", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 GJNHMHCKKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x72C4B60", Offset = "0x72C3560", VA = "0x1872C4B60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public LIIKICNCDGJ GBBIDMLGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x72C4AB0", Offset = "0x72C34B0", VA = "0x1872C4AB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x72C4C50", Offset = "0x72C3650", VA = "0x1872C4C50")]
	public KGJMHCLOIIP(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x72C40D0", Offset = "0x72C2AD0", VA = "0x1872C40D0", Slot = "8")]
	public void AMEIMADIHAC(LIIKICNCDGJ LDJCBIBELIM, object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x72C46C0", Offset = "0x72C30C0", VA = "0x1872C46C0", Slot = "9")]
	public void IDAJDBAPFGN(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x72C4720", Offset = "0x72C3120", VA = "0x1872C4720")]
	private Vector3 KMCODOFJKOM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x72C4140", Offset = "0x72C2B40", VA = "0x1872C4140")]
	private void AMLMKAIIBGP(LIIKICNCDGJ HMDBGPHMHLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class LBFPGDCINIH
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x72C4E10", Offset = "0x72C3810", VA = "0x1872C4E10")]
	public static FODKLOJKGKG JAKBOKFGHEE(this LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class EIMKGAPFGDN : EHOMHIKFOEC, GKHFDEMHCGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly HDBLPCDAJNK IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 LFCEFGDACHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly OverridableVector3 DCGJMKPEKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float GKILHKLOHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private float LBLHKMLAOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3 EIHNNMDBOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Vector3? APLMKDPAJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Quaternion? BEIKBCAEKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool BHNLLGDFLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool GNHGJIDDCML;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 JBNBGKGBAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xFBD5C0", Offset = "0xFBBFC0", VA = "0x180FBD5C0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x72B9DE0", Offset = "0x72B87E0", VA = "0x1872B9DE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 LDFAKINHCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x72BB230", Offset = "0x72B9C30", VA = "0x1872BB230", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float LINHIOGBDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xAC03B0", Offset = "0xABEDB0", VA = "0x180AC03B0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x72B9E90", Offset = "0x72B8890", VA = "0x1872B9E90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float ABINEMAJDGH
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xAC03A0", Offset = "0xABEDA0", VA = "0x180AC03A0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x72BBB00", Offset = "0x72BA500", VA = "0x1872BBB00", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 LALMNOFKGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x72BBBB0", Offset = "0x72BA5B0", VA = "0x1872BBBB0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion KPBECAOAIDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x72BB8E0", Offset = "0x72BA2E0", VA = "0x1872BB8E0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody KJODLCHDEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x72B9D90", Offset = "0x72B8790", VA = "0x1872B9D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event LDHKFCBONJG EKOJGAGMOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x72B9CF0", Offset = "0x72B86F0", VA = "0x1872B9CF0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x72BBA60", Offset = "0x72BA460", VA = "0x1872BBA60", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x72BC2C0", Offset = "0x72BACC0", VA = "0x1872BC2C0")]
	public EIMKGAPFGDN(LIIKICNCDGJ IOHJIPHILJI, [In] OCGBPCDKBKC JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x72BB080", Offset = "0x72B9A80", VA = "0x1872BB080", Slot = "17")]
	public void HGAGCFBNGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x72BBD40", Offset = "0x72BA740", VA = "0x1872BBD40", Slot = "16")]
	public void OMMIJCKCGMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x72B9C10", Offset = "0x72B8610", VA = "0x1872B9C10", Slot = "19")]
	public void CFCFDMGBDJO(Rigidbody OLNABEIJDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x72BB700", Offset = "0x72BA100", VA = "0x1872BB700", Slot = "20")]
	public void KLMOMCBKCOC(Rigidbody OLNABEIJDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x72BB550", Offset = "0x72B9F50", VA = "0x1872BB550", Slot = "18")]
	public void JNIJLCFKCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x72BBE20", Offset = "0x72BA820", VA = "0x1872BBE20", Slot = "21")]
	public void OPJOMHHIOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x72B9DE0", Offset = "0x72B87E0", VA = "0x1872B9DE0")]
	private void DGLEAJDAJAD(Vector3 KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x72BAF90", Offset = "0x72B9990", VA = "0x1872BAF90")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 FLGDKPCHMMH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x72B9E90", Offset = "0x72B8890", VA = "0x1872B9E90")]
	private void LGOONBOELMA(float KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x72BBB00", Offset = "0x72BA500", VA = "0x1872BBB00")]
	private void PINHAICNNMP(float KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x72B9A70", Offset = "0x72B8470", VA = "0x1872B9A70")]
	private Vector3 BNGEGGBECNP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x72BB320", Offset = "0x72B9D20", VA = "0x1872BB320", Slot = "15")]
	public void JGHOGCEFAIE((Quaternion rot, Vector3 moments) JBHPDEADHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x72B9FA0", Offset = "0x72B89A0", VA = "0x1872B9FA0")]
	private Quaternion EHMKCJEOGGK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x72BA120", Offset = "0x72B8B20", VA = "0x1872BA120")]
	public void FGIJBHJABKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x72BA1F0", Offset = "0x72B8BF0", VA = "0x1872BA1F0", Slot = "4")]
	public (float, Vector3) FGIJBHJABKI(Rigidbody INJJGGGMMHL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class GIBJPDHAKNO
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x72BD320", Offset = "0x72BBD20", VA = "0x1872BD320")]
	public static EHOMHIKFOEC JIFJODCGKHC(this LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class MHCBMKICHDP : CDFAFOAFKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly HDBLPCDAJNK IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly HOLNLKKBEGE FKNHIGAGNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DKOEEBIFOEM NKKEOAMLFCK;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool IDJFOGKNBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x116CCE0", Offset = "0x116B6E0", VA = "0x18116CCE0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public DKOEEBIFOEM EMGADGGKFNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x941880", Offset = "0x940280", VA = "0x180941880", Slot = "11")]
		get
		{
			return default(DKOEEBIFOEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x72C5F70", Offset = "0x72C4970", VA = "0x1872C5F70")]
	public MHCBMKICHDP(LIIKICNCDGJ IOHJIPHILJI, [In] OCGBPCDKBKC JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x72C5970", Offset = "0x72C4370", VA = "0x1872C5970", Slot = "4")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x72C5ED0", Offset = "0x72C48D0", VA = "0x1872C5ED0")]
	private bool PMEFPGDJNIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x72C5A80", Offset = "0x72C4480", VA = "0x1872C5A80", Slot = "5")]
	public void FKCKHNKJPKE(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x72C5BE0", Offset = "0x72C45E0", VA = "0x1872C5BE0", Slot = "6")]
	public void GIOLFHAFEFA(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x72C5AB0", Offset = "0x72C44B0", VA = "0x1872C5AB0", Slot = "9")]
	public void GAAIHOIMDNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x72C5C50", Offset = "0x72C4650", VA = "0x1872C5C50")]
	private void IBCKMHJLHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x72C5D60", Offset = "0x72C4760", VA = "0x1872C5D60")]
	private void IOHDHOOJODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x72C5A40", Offset = "0x72C4440", VA = "0x1872C5A40", Slot = "8")]
	public void EEFGGKEHGNE(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x72C5C10", Offset = "0x72C4610", VA = "0x1872C5C10", Slot = "7")]
	public void HFBPLDCFDNO(LIIKICNCDGJ IOHJIPHILJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class AKFPBKEHNKD : KIAAOCCDDCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly HDBLPCDAJNK IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly HOLNLKKBEGE PFALBCBFPFK;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool GBINOLADCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x72B51A0", Offset = "0x72B3BA0", VA = "0x1872B51A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event LDHKFCBONJG CJBJKADPOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x72B5250", Offset = "0x72B3C50", VA = "0x1872B5250", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x72B4FF0", Offset = "0x72B39F0", VA = "0x1872B4FF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x72B5380", Offset = "0x72B3D80", VA = "0x1872B5380")]
	public AKFPBKEHNKD(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x72B5360", Offset = "0x72B3D60", VA = "0x1872B5360", Slot = "7")]
	public void MLIEHFDDMKO(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x72B5370", Offset = "0x72B3D70", VA = "0x1872B5370", Slot = "8")]
	public void PBJGEJFAFPH(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x72B5090", Offset = "0x72B3A90", VA = "0x1872B5090", Slot = "9")]
	public void IIKHLAALMID(object FLLNLBHFENG, bool HJBOCAGMBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x72B5320", Offset = "0x72B3D20", VA = "0x1872B5320", Slot = "12")]
	public void LFBICFOCLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x72B4F70", Offset = "0x72B3970", VA = "0x1872B4F70", Slot = "10")]
	public void CFCFDMGBDJO(Rigidbody FHMDKJNEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x72B52F0", Offset = "0x72B3CF0", VA = "0x1872B52F0", Slot = "11")]
	public void KLMOMCBKCOC(Rigidbody OLNABEIJDDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class JJJBCDKGMFG : JIFGONMADEL, OMJMPOHILOG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly HDBLPCDAJNK IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private PhotonView HCOBCJNJKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool BBNILICGABA;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView GCPCGKLIKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool EDFLICMDNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x72C3820", Offset = "0x72C2220", VA = "0x1872C3820", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool FJHGFOFBNHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C00", Offset = "0x9C2600", VA = "0x1809C3C00", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event LDHKFCBONJG NFNPGGIDPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x72C3990", Offset = "0x72C2390", VA = "0x1872C3990", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x72C3E10", Offset = "0x72C2810", VA = "0x1872C3E10", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x72C3EB0", Offset = "0x72C28B0", VA = "0x1872C3EB0")]
	public JJJBCDKGMFG(LIIKICNCDGJ IOHJIPHILJI, [In] OCGBPCDKBKC JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x72C3310", Offset = "0x72C1D10", VA = "0x1872C3310", Slot = "9")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x72C3720", Offset = "0x72C2120", VA = "0x1872C3720", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x72C3A30", Offset = "0x72C2430", VA = "0x1872C3A30", Slot = "10")]
	public void JPEFCMPOPCG(LIIKICNCDGJ LDJCBIBELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x72C3440", Offset = "0x72C1E40", VA = "0x1872C3440", Slot = "11")]
	public void DEBKOMLEGPA(LIIKICNCDGJ LDJCBIBELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x72C35B0", Offset = "0x72C1FB0", VA = "0x1872C35B0")]
	private void DIKMJIPMHAI(PhotonView LNLADNNPHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x72C3840", Offset = "0x72C2240", VA = "0x1872C3840")]
	private void IEEBIAHADLI(EKIGEEIGKIO NHMPFCPPNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x72C3BA0", Offset = "0x72C25A0", VA = "0x1872C3BA0")]
	private void OHLICAJMDJF(PhotonView JFHBHKMIEHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class LAPKHDHFLNM
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x72C4D50", Offset = "0x72C3750", VA = "0x1872C4D50")]
	public static JIFGONMADEL GDJNODCIJLJ(this LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class LKLANCHNKNL : NEDIICPLNME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HDBLPCDAJNK IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private RigidbodyConstraints OPIKDHJECDP;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool CHOMHMJJDAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8FA490", Offset = "0x8F8E90", VA = "0x1808FA490", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x47C8DA0", Offset = "0x47C77A0", VA = "0x1847C8DA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool NJDFJEAACPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xAC0350", Offset = "0xABED50", VA = "0x180AC0350", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x47C8D90", Offset = "0x47C7790", VA = "0x1847C8D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints BIJPIEOKJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x89F660", Offset = "0x89E060", VA = "0x18089F660", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x72C55E0", Offset = "0x72C3FE0", VA = "0x1872C55E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x72C5740", Offset = "0x72C4140", VA = "0x1872C5740")]
	public LKLANCHNKNL(LIIKICNCDGJ IOHJIPHILJI, [In] OCGBPCDKBKC JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x72C55B0", Offset = "0x72C3FB0", VA = "0x1872C55B0", Slot = "9")]
	public void CFCFDMGBDJO(Rigidbody OLNABEIJDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x72C5710", Offset = "0x72C4110", VA = "0x1872C5710", Slot = "10")]
	public void KLMOMCBKCOC(Rigidbody OLNABEIJDDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class AOMPCOJFIHB : KJJGDBKLOGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly LIIKICNCDGJ IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float CAAHNDOCFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private float BHCJEPFNLJP;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float NEAAAENLEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x9C14D0", Offset = "0x9BFED0", VA = "0x1809C14D0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x72B54C0", Offset = "0x72B3EC0", VA = "0x1872B54C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float CHNNGEICIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xB063A0", Offset = "0xB04DA0", VA = "0x180B063A0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x72B5630", Offset = "0x72B4030", VA = "0x1872B5630", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x72B5700", Offset = "0x72B4100", VA = "0x1872B5700")]
	public AOMPCOJFIHB(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x72B5470", Offset = "0x72B3E70", VA = "0x1872B5470", Slot = "8")]
	public void CFCFDMGBDJO(Rigidbody OLNABEIJDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x72B5590", Offset = "0x72B3F90", VA = "0x1872B5590", Slot = "9")]
	public void KLMOMCBKCOC(Rigidbody OLNABEIJDDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class NBIFKJKICNC : ENMPBGGDGOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly HDBLPCDAJNK IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool GKPIHAMKHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private bool CPLFPPNDAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int BAOAGNNFBKP;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody KJODLCHDEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x72B9D90", Offset = "0x72B8790", VA = "0x1872B9D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool DJDPKKNHDEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x72C6260", Offset = "0x72C4C60", VA = "0x1872C6260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private LIIKICNCDGJ NPDGLEPLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x72C6410", Offset = "0x72C4E10", VA = "0x1872C6410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool IIJMHMHEHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x72C6830", Offset = "0x72C5230", VA = "0x1872C6830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event LDHKFCBONJG MAPLCBMMGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x72C66F0", Offset = "0x72C50F0", VA = "0x1872C66F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x72C6650", Offset = "0x72C5050", VA = "0x1872C6650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x72C6AE0", Offset = "0x72C54E0", VA = "0x1872C6AE0")]
	public NBIFKJKICNC(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x72C61D0", Offset = "0x72C4BD0", VA = "0x1872C61D0", Slot = "6")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x72C61C0", Offset = "0x72C4BC0", VA = "0x1872C61C0", Slot = "8")]
	public void BJENNCIKLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x72C6070", Offset = "0x72C4A70", VA = "0x1872C6070", Slot = "7")]
	public bool BEIIONGBDOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x72C6790", Offset = "0x72C5190", VA = "0x1872C6790", Slot = "9")]
	public void JGJAPHHHLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x72C6A40", Offset = "0x72C5440", VA = "0x1872C6A40", Slot = "11")]
	public void OIPENABPJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x72C6890", Offset = "0x72C5290", VA = "0x1872C6890", Slot = "10")]
	public void OAOEGMONBJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x72C6470", Offset = "0x72C4E70", VA = "0x1872C6470")]
	private bool HPHNMNPHJDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x72C6280", Offset = "0x72C4C80", VA = "0x1872C6280")]
	private void HKBMOFBNODO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BGHLGECHLGO : HMNMNHHFKJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly HDBLPCDAJNK IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly HOLNLKKBEGE LIPKLOMBLDI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody KJODLCHDEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x899040", Offset = "0x897A40", VA = "0x180899040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool IIJMHMHEHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x72B5A30", Offset = "0x72B4430", VA = "0x1872B5A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool IBMBBGNFEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x116CCE0", Offset = "0x116B6E0", VA = "0x18116CCE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x72B5F40", Offset = "0x72B4940", VA = "0x1872B5F40")]
	public BGHLGECHLGO(LIIKICNCDGJ IOHJIPHILJI, [In] OCGBPCDKBKC JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x72B5930", Offset = "0x72B4330", VA = "0x1872B5930", Slot = "5")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x72B5A00", Offset = "0x72B4400", VA = "0x1872B5A00", Slot = "7")]
	public void IMDNBJHCJDN(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x72B59D0", Offset = "0x72B43D0", VA = "0x1872B59D0", Slot = "8")]
	public void IFBCHBJDHFA(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x72B5A90", Offset = "0x72B4490", VA = "0x1872B5A90", Slot = "9")]
	public void OEGGCLEMPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x72B5740", Offset = "0x72B4140", VA = "0x1872B5740", Slot = "10")]
	public void BCJMDHINOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x72B5DC0", Offset = "0x72B47C0", VA = "0x1872B5DC0", Slot = "11")]
	public void PDKGPMLOJHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class CIFNHODCFPB : AOKAONLJHOF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly HDBLPCDAJNK IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly HOLNLKKBEGE FKCDFJKGJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private float GCAPGMEHLFJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public JAJDMPNLONJ BIEFJFNFNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x89D6B0", Offset = "0x89C0B0", VA = "0x18089D6B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public BBKEJCDCLFA AOGHHFMNIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x89D6A0", Offset = "0x89C0A0", VA = "0x18089D6A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 GJNHMHCKKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x72B8BA0", Offset = "0x72B75A0", VA = "0x1872B8BA0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x72B8EE0", Offset = "0x72B78E0", VA = "0x1872B8EE0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 PFNOKEMFJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x72B60F0", Offset = "0x72B4AF0", VA = "0x1872B60F0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x72B6FD0", Offset = "0x72B59D0", VA = "0x1872B6FD0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 GAEJILGJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x72B7E80", Offset = "0x72B6880", VA = "0x1872B7E80", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x72B68C0", Offset = "0x72B52C0", VA = "0x1872B68C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 DKKOHOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x72B74D0", Offset = "0x72B5ED0", VA = "0x1872B74D0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x72B7840", Offset = "0x72B6240", VA = "0x1872B7840", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float OHPFGDDNLOG
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xAC03C0", Offset = "0xABEDC0", VA = "0x180AC03C0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x72B6210", Offset = "0x72B4C10", VA = "0x1872B6210", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool ENBMDKNMHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1E50", Offset = "0x1AD0850", VA = "0x181AD1E50", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private HEBLMGHFANA NKFHNKJOABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6ACB850", Offset = "0x6ACA250", VA = "0x186ACB850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool DJDPKKNHDEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x72B7000", Offset = "0x72B5A00", VA = "0x1872B7000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x72B96D0", Offset = "0x72B80D0", VA = "0x1872B96D0")]
	public CIFNHODCFPB(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x72B6380", Offset = "0x72B4D80", VA = "0x1872B6380", Slot = "19")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x72B6800", Offset = "0x72B5200", VA = "0x1872B6800", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x72B6420", Offset = "0x72B4E20", VA = "0x1872B6420", Slot = "28")]
	public void CFCFDMGBDJO(Rigidbody OLNABEIJDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xF828A0", Offset = "0xF812A0", VA = "0x180F828A0", Slot = "20")]
	public void PFGJINBIANE(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xF83DD0", Offset = "0xF827D0", VA = "0x180F83DD0", Slot = "30")]
	public void LJJKJJAHIDI(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x72B8D00", Offset = "0x72B7700", VA = "0x1872B8D00", Slot = "35")]
	public Vector3 PBFBIDMAHAC(Vector3 FOEOPLOKPOB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x72B7080", Offset = "0x72B5A80", VA = "0x1872B7080", Slot = "34")]
	public Vector3 IAPPHLOLCLB(Vector3 CALOMLJNHAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x72B6380", Offset = "0x72B4D80", VA = "0x1872B6380", Slot = "27")]
	public void DLEEIKFFPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x72B6860", Offset = "0x72B5260", VA = "0x1872B6860", Slot = "25")]
	public void FNJCHAFGION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x72B6320", Offset = "0x72B4D20", VA = "0x1872B6320", Slot = "24")]
	public void BJBDPEAHGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x72B7600", Offset = "0x72B6000", VA = "0x1872B7600", Slot = "33")]
	public void IPGHPFLDEBA(Vector3 MEKMEJHIFMC, Vector3 KBNCPNDBCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x72B7020", Offset = "0x72B5A20", VA = "0x1872B7020", Slot = "32")]
	public void IADKCNKPDLN(Vector3 AHEKOJPDIDP, Vector3 JKDCCBAFKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x72B6550", Offset = "0x72B4F50", VA = "0x1872B6550", Slot = "31")]
	public void CODKDPLCDHD(Vector3 IEAGHIDJHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x72B6980", Offset = "0x72B5380", VA = "0x1872B6980", Slot = "22")]
	public void HHIIHBGIEBI(DCOEIOEOLOO OGDHOAEFGEK, Vector3 ADCIKHMIKDC, float BFNABEBMGML, float EJJOPELHGIF = 8f, float ODMENHHKENK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x72B7240", Offset = "0x72B5C40", VA = "0x1872B7240", Slot = "21")]
	public void IBGBKJDOGEF(HLIEOJLMCMD DLJHIKDDMED, Vector3 FDNLGBMHIMG, float LGADHHDBLPE = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x72B8600", Offset = "0x72B7000", VA = "0x1872B8600", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void NICHPOJBKKJ(HLIEOJLMCMD DLJHIKDDMED, Vector3 JOLHFCINNMA, float LGCLKPGINJF = 7f, float GNAMHFMCPHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x109A030", Offset = "0x1098A30", VA = "0x18109A030")]
	private static void NMPPHFIMPLC(Vector3 DLPEMGFGHPD, Vector3 DBBPPLLNKOD, [Out] Vector3 FPCMBDNNCNI, [Out] Vector3 KEIFFIGICEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x72B7DA0", Offset = "0x72B67A0", VA = "0x1872B7DA0", Slot = "29")]
	public Vector3 KMAMKOPDPLJ(Vector3 DLPEMGFGHPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x72B9540", Offset = "0x72B7F40", VA = "0x1872B9540", Slot = "26")]
	public void PMJJMHPJAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x72B6210", Offset = "0x72B4C10", VA = "0x1872B6210")]
	private void BEOJMBJBKOC(float KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x72B7FE0", Offset = "0x72B69E0", VA = "0x1872B7FE0")]
	private void LKPKNBGDKKJ(Vector3 FDNLGBMHIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x72B66F0", Offset = "0x72B50F0", VA = "0x1872B66F0")]
	private Vector3 DGPGLFENLAB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x72B8180", Offset = "0x72B6B80", VA = "0x1872B8180")]
	private void MLJCEMHBPDK(Vector3 CALOMLJNHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x72B8A80", Offset = "0x72B7480", VA = "0x1872B8A80")]
	private Vector3 ODGKCHKOFEI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x72B7870", Offset = "0x72B6270", VA = "0x1872B7870")]
	private void JHHEOMOBBKL(Vector3 KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x72B8FA0", Offset = "0x72B79A0", VA = "0x1872B8FA0")]
	private void PKKJCPNPCAJ(Vector3 CALOMLJNHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x72B7CF0", Offset = "0x72B66F0", VA = "0x1872B7CF0")]
	private void KCOJHMAJIDC()
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
