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
		[Cpp2IlInjected.Address(RVA = "0x71DA2B0", Offset = "0x71D88B0", VA = "0x1871DA2B0", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x170A0F0", Offset = "0x17086F0", VA = "0x18170A0F0", Slot = "5")]
		public override void NPEPAFCACGO(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71E4300", Offset = "0x71E2900", VA = "0x1871E4300")]
		private void PPMCIGPJJHC(OKABLMMJMFE registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71E42A0", Offset = "0x71E28A0", VA = "0x1871E42A0", Slot = "6")]
		public override void BLGFFGICMBK(OKABLMMJMFE registry, [In] EFAAIAEHAHM filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71E4610", Offset = "0x71E2C10", VA = "0x1871E4610")]
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
			[Cpp2IlInjected.Address(RVA = "0x71DFCF0", Offset = "0x71DE2F0", VA = "0x1871DFCF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LIIKICNCDGJ FPJBDDLAPBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FCCFPOKIGIC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x71E16D0", Offset = "0x71DFCD0", VA = "0x1871E16D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx DBPFKKJAOIC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x71E1A30", Offset = "0x71E0030", VA = "0x1871E1A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx GEBPHFIJDHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x71E1970", Offset = "0x71DFF70", VA = "0x1871E1970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx LDJCBIBELIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x71E26E0", Offset = "0x71E0CE0", VA = "0x1871E26E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x71E3C10", Offset = "0x71E2210", VA = "0x1871E3C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform CLMENJCDDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8AE8C0", Offset = "0x8ACEC0", VA = "0x1808AE8C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform JOJCKMBBNHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8AE8C0", Offset = "0x8ACEC0", VA = "0x1808AE8C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IDPKEMCPFEK LDMEPBIHABI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x71E1730", Offset = "0x71DFD30", VA = "0x1871E1730")]
			get
			{
				return default(IDPKEMCPFEK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x71E33C0", Offset = "0x71E19C0", VA = "0x1871E33C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EDFLICMDNLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x71E1D40", Offset = "0x71E0340", VA = "0x1871E1D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool FJHGFOFBNHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x71E1850", Offset = "0x71DFE50", VA = "0x1871E1850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JAJDMPNLONJ BIEFJFNFNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x71E1C80", Offset = "0x71E0280", VA = "0x1871E1C80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x71E3580", Offset = "0x71E1B80", VA = "0x1871E3580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BBKEJCDCLFA AOGHHFMNIGH
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x71E1C20", Offset = "0x71E0220", VA = "0x1871E1C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x71E3510", Offset = "0x71E1B10", VA = "0x1871E3510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool ENBMDKNMHDD
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x71E1B70", Offset = "0x71E0170", VA = "0x1871E1B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody KJODLCHDEJI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x71E1BD0", Offset = "0x71E01D0", VA = "0x1871E1BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool CHOMHMJJDAE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x71E18B0", Offset = "0x71DFEB0", VA = "0x1871E18B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x71E3430", Offset = "0x71E1A30", VA = "0x1871E3430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool JJJFHLFAKKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6EB31C0", Offset = "0x6EB17C0", VA = "0x186EB31C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float LBLHKMLAOCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x71E2680", Offset = "0x71E0C80", VA = "0x1871E2680")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float GKILHKLOHHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x71E2620", Offset = "0x71E0C20", VA = "0x1871E2620")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x71E3BA0", Offset = "0x71E21A0", VA = "0x1871E3BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float CAAHNDOCFDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x71E1FA0", Offset = "0x71E05A0", VA = "0x1871E1FA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x71E3820", Offset = "0x71E1E20", VA = "0x1871E3820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float BHCJEPFNLJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x71E1DA0", Offset = "0x71E03A0", VA = "0x1871E1DA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x71E35F0", Offset = "0x71E1BF0", VA = "0x1871E35F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool GKFNMBGEFBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x71E2C60", Offset = "0x71E1260", VA = "0x1871E2C60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x71E4150", Offset = "0x71E2750", VA = "0x1871E4150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 EIHNNMDBOKG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x71E2400", Offset = "0x71E0A00", VA = "0x1871E2400")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x71E3970", Offset = "0x71E1F70", VA = "0x1871E3970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 MKBOBLLEBEB
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x71E2DA0", Offset = "0x71E13A0", VA = "0x1871E2DA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode PDHKEGACJCL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x71E1EE0", Offset = "0x71E04E0", VA = "0x1871E1EE0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x71E3740", Offset = "0x71E1D40", VA = "0x1871E3740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float OHPFGDDNLOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x71E1910", Offset = "0x71DFF10", VA = "0x1871E1910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x71E34A0", Offset = "0x71E1AA0", VA = "0x1871E34A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints OPIKDHJECDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x71E1F40", Offset = "0x71E0540", VA = "0x1871E1F40")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x71E37B0", Offset = "0x71E1DB0", VA = "0x1871E37B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 IFIHLMDPNJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x71E27A0", Offset = "0x71E0DA0", VA = "0x1871E27A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 JOIBHGPGLLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x71E27A0", Offset = "0x71E0DA0", VA = "0x1871E27A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x71E3F30", Offset = "0x71E2530", VA = "0x1871E3F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float LDFEJLDJAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x71E24E0", Offset = "0x71E0AE0", VA = "0x1871E24E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x71E3A50", Offset = "0x71E2050", VA = "0x1871E3A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float PMIPCKHIBMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x71E2C00", Offset = "0x71E1200", VA = "0x1871E2C00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x71E40E0", Offset = "0x71E26E0", VA = "0x1871E40E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion JOJGECMDGJF
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x71E2880", Offset = "0x71E0E80", VA = "0x1871E2880")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x71E3CB0", Offset = "0x71E22B0", VA = "0x1871E3CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion PIPOCGEFJAK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x71E2B20", Offset = "0x71E1120", VA = "0x1871E2B20")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x71E4010", Offset = "0x71E2610", VA = "0x1871E4010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 KGNEENFKOED
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x71E2960", Offset = "0x71E0F60", VA = "0x1871E2960")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x71E3D80", Offset = "0x71E2380", VA = "0x1871E3D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DDBIDBFFJOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x71E2A40", Offset = "0x71E1040", VA = "0x1871E2A40")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x71E3E60", Offset = "0x71E2460", VA = "0x1871E3E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 DLPEMGFGHPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x71E2CC0", Offset = "0x71E12C0", VA = "0x1871E2CC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x71E41C0", Offset = "0x71E27C0", VA = "0x1871E41C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 CALOMLJNHAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x71E2540", Offset = "0x71E0B40", VA = "0x1871E2540")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x71E3AC0", Offset = "0x71E20C0", VA = "0x1871E3AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 OHHCFKJBEEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x71E1E00", Offset = "0x71E0400", VA = "0x1871E1E00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x71E3660", Offset = "0x71E1C60", VA = "0x1871E3660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 JKDCCBAFKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x71E2320", Offset = "0x71E0920", VA = "0x1871E2320")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x71E3890", Offset = "0x71E1E90", VA = "0x1871E3890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 APLMKDPAJBI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x71E21E0", Offset = "0x71E07E0", VA = "0x1871E21E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion BEIKBCAEKBL
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x71E2100", Offset = "0x71E0700", VA = "0x1871E2100")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 CCNDBAHIGIE
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x71E2F60", Offset = "0x71E1560", VA = "0x1871E2F60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 HIPFLCHJMPN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x71E2E80", Offset = "0x71E1480", VA = "0x1871E2E80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool ILMFJGEOAEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x71E22C0", Offset = "0x71E08C0", VA = "0x1871E22C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool KBGODMPIDOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x71E1CE0", Offset = "0x71E02E0", VA = "0x1871E1CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CGOAGBDFOCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x71E17F0", Offset = "0x71DFDF0", VA = "0x1871E17F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool EJHGOMAIJPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x71E1790", Offset = "0x71DFD90", VA = "0x1871E1790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool AKHLIBBDLBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x71E1670", Offset = "0x71DFC70", VA = "0x1871E1670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool MHHCMEDLEKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x71E2000", Offset = "0x71E0600", VA = "0x1871E2000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CMFCJHGPMDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x19842E0", Offset = "0x19828E0", VA = "0x1819842E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event KHNKEDFCPCA OFIDAELEKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x71E1590", Offset = "0x71DFB90", VA = "0x1871E1590")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x71E32E0", Offset = "0x71E18E0", VA = "0x1871E32E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LDHKFCBONJG HAPCHNBOPIO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x71E1300", Offset = "0x71DF900", VA = "0x1871E1300")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x71E3040", Offset = "0x71E1640", VA = "0x1871E3040")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event LDHKFCBONJG ALMMOHFNLGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x71E1360", Offset = "0x71DF960", VA = "0x1871E1360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x71E30B0", Offset = "0x71E16B0", VA = "0x1871E30B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event LDHKFCBONJG HHBHHCLMKAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x71E14B0", Offset = "0x71DFAB0", VA = "0x1871E14B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x71E3200", Offset = "0x71E1800", VA = "0x1871E3200")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<MGNMBPEAPIF, MGNMBPEAPIF> HGNPDKHNLHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x71E1440", Offset = "0x71DFA40", VA = "0x1871E1440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x71E3190", Offset = "0x71E1790", VA = "0x1871E3190")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event LDHKFCBONJG AJNALHDLMNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x71E1520", Offset = "0x71DFB20", VA = "0x1871E1520")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x71E3270", Offset = "0x71E1870", VA = "0x1871E3270")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event LDHKFCBONJG ICMFDAELLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x71E1600", Offset = "0x71DFC00", VA = "0x1871E1600")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x71E3350", Offset = "0x71E1950", VA = "0x1871E3350")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event LDHKFCBONJG CLODFINLIGM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x71E13D0", Offset = "0x71DF9D0", VA = "0x1871E13D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x71E3120", Offset = "0x71E1720", VA = "0x1871E3120")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885640", VA = "0x180887040", Slot = "8")]
		private void CBLHNPOKBLM(LIIKICNCDGJ BDPEMHOFOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x71E0270", Offset = "0x71DE870", VA = "0x1871E0270")]
		internal void KJABNOMCHGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71E1030", Offset = "0x71DF630", VA = "0x1871E1030")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody OIPPEPPFCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x71DFDA0", Offset = "0x71DE3A0", VA = "0x1871DFDA0")]
		public EKIGEEIGKIO GetChild(int HGFDMIDEFHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x71E0D00", Offset = "0x71DF300", VA = "0x1871E0D00")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) JBHPDEADHAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x71DFAA0", Offset = "0x71DE0A0", VA = "0x1871DFAA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x71DFCF0", Offset = "0x71DE2F0", VA = "0x1871DFCF0")]
		private LIIKICNCDGJ FPKFIFABCBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x71DEF30", Offset = "0x71DD530", VA = "0x1871DEF30")]
		private void AMLGEKNOMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x71E04D0", Offset = "0x71DEAD0", VA = "0x1871E04D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x71E0270", Offset = "0x71DE870", VA = "0x1871E0270")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x71E0470", Offset = "0x71DEA70", VA = "0x1871E0470")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x71E0530", Offset = "0x71DEB30", VA = "0x1871E0530")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x71DF150", Offset = "0x71DD750", VA = "0x1871DF150")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x71E0590", Offset = "0x71DEB90", VA = "0x1871E0590")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x71DFC90", Offset = "0x71DE290", VA = "0x1871DFC90")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x71E0410", Offset = "0x71DEA10", VA = "0x1871E0410")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x71E0E60", Offset = "0x71DF460", VA = "0x1871E0E60")]
		public void SetParent(RigidbodyEx KLABJGGMBGH, bool AMABBFGDEKH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x71E08A0", Offset = "0x71DEEA0", VA = "0x1871E08A0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x71E0050", Offset = "0x71DE650", VA = "0x1871E0050")]
		public bool IsRigidbodyAncestor(RigidbodyEx NJFMAAHNHCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x71E0130", Offset = "0x71DE730", VA = "0x1871E0130")]
		public bool IsRigidbodyDescendant(RigidbodyEx EMNAFJIGFAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x71DF3C0", Offset = "0x71DD9C0", VA = "0x1871DF3C0")]
		public void AddInterpolationRestriction(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x71E0600", Offset = "0x71DEC00", VA = "0x1871E0600")]
		public void RemoveInterpolationRestriction(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x71DF430", Offset = "0x71DDA30", VA = "0x1871DF430")]
		public void AddKinematic(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x71E0670", Offset = "0x71DEC70", VA = "0x1871E0670")]
		public void RemoveKinematic(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x71E0DE0", Offset = "0x71DF3E0", VA = "0x1871E0DE0")]
		public void SetKinematic(object FLLNLBHFENG, bool HJBOCAGMBCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x71E0C00", Offset = "0x71DF200", VA = "0x1871E0C00")]
		public void SetDiscontinuousPositionAndRotation(Vector3 ALEJNJJFLEH, Quaternion AJOIIFAELBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x71E0B00", Offset = "0x71DF100", VA = "0x1871E0B00")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 PFAHFEPFAAJ, Quaternion NKABCINOOKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x71DFF40", Offset = "0x71DE540", VA = "0x1871DFF40")]
		public Vector3 GetConstrainedVelocity(Vector3 DLPEMGFGHPD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x71DFE30", Offset = "0x71DE430", VA = "0x1871DFE30")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 OHHCFKJBEEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x71DF2D0", Offset = "0x71DD8D0", VA = "0x1871DF2D0")]
		public void AddForce(Vector3 LENLJCDCMCG, ForceMode KNHJEAKHHDM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x71DF1C0", Offset = "0x71DD7C0", VA = "0x1871DF1C0")]
		public void AddForceAtPosition(Vector3 LENLJCDCMCG, Vector3 LEELMECKGCG, ForceMode KNHJEAKHHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x71DF600", Offset = "0x71DDC00", VA = "0x1871DF600")]
		public void AddTorque(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x71DF4A0", Offset = "0x71DDAA0", VA = "0x1871DF4A0")]
		public void AddRelativeTorque(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x71E1100", Offset = "0x71DF700", VA = "0x1871E1100")]
		public Vector3 WorldToLocalVelocity(Vector3 FOEOPLOKPOB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x71E0300", Offset = "0x71DE900", VA = "0x1871E0300")]
		public Vector3 LocalToWorldVelocity(Vector3 CALOMLJNHAK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x71DFC30", Offset = "0x71DE230", VA = "0x1871DFC30")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x71DFBD0", Offset = "0x71DE1D0", VA = "0x1871DFBD0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x71DFB70", Offset = "0x71DE170", VA = "0x1871DFB70")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x71DFB10", Offset = "0x71DE110", VA = "0x1871DFB10")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x71E0A00", Offset = "0x71DF000", VA = "0x1871E0A00")]
		public void ResetVelocityWorldSpace(Vector3 MEKMEJHIFMC, Vector3 KBNCPNDBCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x71E0900", Offset = "0x71DEF00", VA = "0x1871E0900")]
		public void ResetVelocityLocalSpace(Vector3 AHEKOJPDIDP, Vector3 JKDCCBAFKIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x71E07C0", Offset = "0x71DEDC0", VA = "0x1871E07C0")]
		public void ResetLinearVelocityLocalSpace(Vector3 AHEKOJPDIDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x71E0F90", Offset = "0x71DF590", VA = "0x1871E0F90")]
		public bool SweepTest(Vector3 JFCINBHKCNC, [Out] RaycastHit DPMDGOFFPKK, float KEEIEBHGPIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x71E0210", Offset = "0x71DE810", VA = "0x1871E0210")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x71E0F30", Offset = "0x71DF530", VA = "0x1871E0F30")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x71E10A0", Offset = "0x71DF6A0", VA = "0x1871E10A0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x71DF590", Offset = "0x71DDB90", VA = "0x1871DF590")]
		public void AddShouldHaveUnityRigidbodyToken(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x71E06E0", Offset = "0x71DECE0", VA = "0x1871E06E0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x71DF930", Offset = "0x71DDF30", VA = "0x1871DF930")]
		public void ApplyForceVelocityChange(DCOEIOEOLOO OGDHOAEFGEK, Vector3 ADCIKHMIKDC, float BFNABEBMGML, float EJJOPELHGIF = 8f, float ODMENHHKENK = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x71DF890", Offset = "0x71DDE90", VA = "0x1871DF890")]
		public void ApplyAngularVelocityChange(HLIEOJLMCMD DLJHIKDDMED, Vector3 FDNLGBMHIMG, float LGADHHDBLPE = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x71DF9F0", Offset = "0x71DDFF0", VA = "0x1871DF9F0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(HLIEOJLMCMD DLJHIKDDMED, Vector3 JOLHFCINNMA, float LGCLKPGINJF = 7f, float GNAMHFMCPHB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x71DF7C0", Offset = "0x71DDDC0", VA = "0x1871DF7C0")]
		public bool AllowedScaleChange(float OADJCOEBHOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x71DF6F0", Offset = "0x71DDCF0", VA = "0x1871DF6F0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx CEECOCODHNB, object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x71E0750", Offset = "0x71DED50", VA = "0x1871E0750")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x71E1290", Offset = "0x71DF890", VA = "0x1871E1290")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xB6EE60", Offset = "0xB6D460", VA = "0x180B6EE60", Slot = "4")]
		private GameObject BPBEBKOGPPJ()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8C0", Offset = "0x8ACEC0", VA = "0x1808AE8C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x71CE4D0", Offset = "0x71CCAD0", VA = "0x1871CE4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DFHCEAJLAEJ DMCOGGNKFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x71D1CE0", Offset = "0x71D02E0", VA = "0x1871D1CE0", Slot = "7")]
	public void InitReferences(GOMDDPLFKLJ KKAHGNKMLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x71D1C50", Offset = "0x71D0250", VA = "0x1871D1C50", Slot = "6")]
	public LIIKICNCDGJ ENFLHFFGAOB(RigidbodyEx IOHJIPHILJI, OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x71DEDB0", Offset = "0x71DD3B0", VA = "0x1871DEDB0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x71DEDF0", Offset = "0x71DD3F0", VA = "0x1871DEDF0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x71DEDD0", Offset = "0x71DD3D0", VA = "0x1871DEDD0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string KFAOBDLOMDC, [Optional] UnityEngine.Object EIGKPCONJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string KFAOBDLOMDC, [Optional] UnityEngine.Object EIGKPCONJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x71DEEE0", Offset = "0x71DD4E0", VA = "0x1871DEEE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x895B10", Offset = "0x894110", VA = "0x180895B10", Slot = "4")]
		public Vector3 MHHJOJACDNH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x895B10", Offset = "0x894110", VA = "0x180895B10", Slot = "5")]
		public Vector3 ODGKCHKOFEI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public OIADFDGEGPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static JAJDMPNLONJ PBNNDAHHPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x71D8AD0", Offset = "0x71D70D0", VA = "0x1871D8AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "22")]
		get
		{
			return default(GJJPJLAFENF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EKIGEEIGKIO AEKONCKCCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x88D620", Offset = "0x88BC20", VA = "0x18088D620", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x88D6C0", Offset = "0x88BCC0", VA = "0x18088D6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject MNAAHCNCEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x93DEE0", Offset = "0x93C4E0", VA = "0x18093DEE0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xB7C280", Offset = "0xB7A880", VA = "0x180B7C280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform MJIIFCFMCAF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x885DE0", Offset = "0x8843E0", VA = "0x180885DE0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x885DC0", Offset = "0x8843C0", VA = "0x180885DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody KJODLCHDEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x71D2AF0", Offset = "0x71D10F0", VA = "0x1871D2AF0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public LIIKICNCDGJ NPDGLEPLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x71D49A0", Offset = "0x71D2FA0", VA = "0x1871D49A0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x71D7C00", Offset = "0x71D6200", VA = "0x1871D7C00", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int FCCFPOKIGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x71D5050", Offset = "0x71D3650", VA = "0x1871D5050", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public LIIKICNCDGJ GEBPHFIJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x71D5AE0", Offset = "0x71D40E0", VA = "0x1871D5AE0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool IIJMHMHEHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x71D62E0", Offset = "0x71D48E0", VA = "0x1871D62E0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool EDFLICMDNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x71D4530", Offset = "0x71D2B30", VA = "0x1871D4530", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool FJHGFOFBNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x71D6940", Offset = "0x71D4F40", VA = "0x1871D6940", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public JAJDMPNLONJ BIEFJFNFNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x71D4950", Offset = "0x71D2F50", VA = "0x1871D4950", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x71D21D0", Offset = "0x71D07D0", VA = "0x1871D21D0", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public BBKEJCDCLFA AOGHHFMNIGH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x71D3920", Offset = "0x71D1F20", VA = "0x1871D3920", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x71D3150", Offset = "0x71D1750", VA = "0x1871D3150", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float OHPFGDDNLOG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x71D1F00", Offset = "0x71D0500", VA = "0x1871D1F00", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x71D2230", Offset = "0x71D0830", VA = "0x1871D2230", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 PFNOKEMFJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x71D1FF0", Offset = "0x71D05F0", VA = "0x1871D1FF0", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x71D4690", Offset = "0x71D2C90", VA = "0x1871D4690", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 DKKOHOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x71D51D0", Offset = "0x71D37D0", VA = "0x1871D51D0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x71D56B0", Offset = "0x71D3CB0", VA = "0x1871D56B0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 GJNHMHCKKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x71D7600", Offset = "0x71D5C00", VA = "0x1871D7600", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x71D7AC0", Offset = "0x71D60C0", VA = "0x1871D7AC0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 GAEJILGJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x71D6020", Offset = "0x71D4620", VA = "0x1871D6020", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x71D4160", Offset = "0x71D2760", VA = "0x1871D4160", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool CGOAGBDFOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x71D2120", Offset = "0x71D0720", VA = "0x1871D2120", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool EJHGOMAIJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x71D7180", Offset = "0x71D5780", VA = "0x1871D7180", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool AKHLIBBDLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x71D23D0", Offset = "0x71D09D0", VA = "0x1871D23D0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool ENBMDKNMHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x71D2780", Offset = "0x71D0D80", VA = "0x1871D2780", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 BNNAKBMDNKI
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x71D3D30", Offset = "0x71D2330", VA = "0x1871D3D30", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 ECNEMFJNMLD
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x71D4CC0", Offset = "0x71D32C0", VA = "0x1871D4CC0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 JBNBGKGBAKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x71D37F0", Offset = "0x71D1DF0", VA = "0x1871D37F0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x71D6520", Offset = "0x71D4B20", VA = "0x1871D6520", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 LDFAKINHCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x71D4F00", Offset = "0x71D3500", VA = "0x1871D4F00", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float LINHIOGBDJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x71D28D0", Offset = "0x71D0ED0", VA = "0x1871D28D0", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float ABINEMAJDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x71D4EB0", Offset = "0x71D34B0", VA = "0x1871D4EB0", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x71D6F50", Offset = "0x71D5550", VA = "0x1871D6F50", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 LALMNOFKGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x71D71E0", Offset = "0x71D57E0", VA = "0x1871D71E0", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion KPBECAOAIDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x71D6210", Offset = "0x71D4810", VA = "0x1871D6210", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float NEAAAENLEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x71D1F50", Offset = "0x71D0550", VA = "0x1871D1F50", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x71D3210", Offset = "0x71D1810", VA = "0x1871D3210", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float CHNNGEICIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x71D2A00", Offset = "0x71D1000", VA = "0x1871D2A00", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x71D6D10", Offset = "0x71D5310", VA = "0x1871D6D10", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool FGACBMNAHCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x71D3750", Offset = "0x71D1D50", VA = "0x1871D3750", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x71D48C0", Offset = "0x71D2EC0", VA = "0x1871D48C0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IDPKEMCPFEK LDMEPBIHABI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x71D5660", Offset = "0x71D3C60", VA = "0x1871D5660", Slot = "68")]
		get
		{
			return default(IDPKEMCPFEK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x71D6D70", Offset = "0x71D5370", VA = "0x1871D6D70", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool GBINOLADCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x71D5D70", Offset = "0x71D4370", VA = "0x1871D5D70", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform JOJCKMBBNHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x885DE0", Offset = "0x8843E0", VA = "0x180885DE0", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 PKIKEFANDCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x71D4DA0", Offset = "0x71D33A0", VA = "0x1871D4DA0", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x71D7850", Offset = "0x71D5E50", VA = "0x1871D7850", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float CJEPBLIJPDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x71D43E0", Offset = "0x71D29E0", VA = "0x1871D43E0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x71D4060", Offset = "0x71D2660", VA = "0x1871D4060", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float LEFOLJKLIPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x71D4770", Offset = "0x71D2D70", VA = "0x1871D4770", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x71D2510", Offset = "0x71D0B10", VA = "0x1871D2510", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion NGDPLNEHBDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x71D2C10", Offset = "0x71D1210", VA = "0x1871D2C10", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x71D6810", Offset = "0x71D4E10", VA = "0x1871D6810", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 NBIMBFHIDEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x71D4AE0", Offset = "0x71D30E0", VA = "0x1871D4AE0", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x71D2A50", Offset = "0x71D1050", VA = "0x1871D2A50", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion DGNKNFBAMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x71D5FE0", Offset = "0x71D45E0", VA = "0x1871D5FE0", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x71D4920", Offset = "0x71D2F20", VA = "0x1871D4920", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints BIJPIEOKJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x71D32D0", Offset = "0x71D18D0", VA = "0x1871D32D0", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x71D3020", Offset = "0x71D1620", VA = "0x1871D3020", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool CHOMHMJJDAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x71D68F0", Offset = "0x71D4EF0", VA = "0x1871D68F0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x71D76E0", Offset = "0x71D5CE0", VA = "0x1871D76E0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode OHGCCBCICEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x71D37A0", Offset = "0x71D1DA0", VA = "0x1871D37A0", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x71D24B0", Offset = "0x71D0AB0", VA = "0x1871D24B0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool DJDPKKNHDEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x71D4780", Offset = "0x71D2D80", VA = "0x1871D4780", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool KBGODMPIDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x71D6DD0", Offset = "0x71D53D0", VA = "0x1871D6DD0", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event LDHKFCBONJG HAPCHNBOPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x71D6FB0", Offset = "0x71D55B0", VA = "0x1871D6FB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x71D54B0", Offset = "0x71D3AB0", VA = "0x1871D54B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event LDHKFCBONJG ALMMOHFNLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x71D5BF0", Offset = "0x71D41F0", VA = "0x1871D5BF0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x71D7010", Offset = "0x71D5610", VA = "0x1871D7010", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event KHNKEDFCPCA LMKJBLGMEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x71D5B90", Offset = "0x71D4190", VA = "0x1871D5B90", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x71D7120", Offset = "0x71D5720", VA = "0x1871D7120", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event LDHKFCBONJG NFNPGGIDPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x71D5A80", Offset = "0x71D4080", VA = "0x1871D5A80", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x71D7BA0", Offset = "0x71D61A0", VA = "0x1871D7BA0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event LDHKFCBONJG HHBHHCLMKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x71D2170", Offset = "0x71D0770", VA = "0x1871D2170", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x71D7900", Offset = "0x71D5F00", VA = "0x1871D7900", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event LDHKFCBONJG MAPLCBMMGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x71D5790", Offset = "0x71D3D90", VA = "0x1871D5790", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x71D5600", Offset = "0x71D3C00", VA = "0x1871D5600", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<MGNMBPEAPIF, MGNMBPEAPIF> HGNPDKHNLHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x71D6100", Offset = "0x71D4700", VA = "0x1871D6100", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x71D31B0", Offset = "0x71D17B0", VA = "0x1871D31B0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event LDHKFCBONJG CJBJKADPOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x71D5DC0", Offset = "0x71D43C0", VA = "0x1871D5DC0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x71D44D0", Offset = "0x71D2AD0", VA = "0x1871D44D0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event LDHKFCBONJG CLODFINLIGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x71D26D0", Offset = "0x71D0CD0", VA = "0x1871D26D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x71D5120", Offset = "0x71D3720", VA = "0x1871D5120", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x71D7CF0", Offset = "0x71D62F0", VA = "0x1871D7CF0")]
	public HDBLPCDAJNK(GameObject MNKAGJEGJCF, RigidbodyEx ELEFADMBDGP, PLEPOBHCEGN EHABNPPLNPG, [In] OCGBPCDKBKC JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x71D7310", Offset = "0x71D5910", VA = "0x1871D7310", Slot = "136")]
	protected virtual void OJHNCDGLBJM(PLEPOBHCEGN EHABNPPLNPG, OCGBPCDKBKC JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x71D3080", Offset = "0x71D1680", VA = "0x1871D3080", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x71D2290", Offset = "0x71D0890", VA = "0x1871D2290", Slot = "91")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x71D1EB0", Offset = "0x71D04B0", VA = "0x1871D1EB0", Slot = "92")]
	public void ADALIIEJKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x71D4140", Offset = "0x71D2740", VA = "0x1871D4140", Slot = "93")]
	public void GICFABMMEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x71D3370", Offset = "0x71D1970", VA = "0x1871D3370")]
	private void FDNCIOBOPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x71D3FE0", Offset = "0x71D25E0", VA = "0x1871D3FE0", Slot = "30")]
	public LIIKICNCDGJ GEFJICFDKLF(int HGFDMIDEFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x71D7790", Offset = "0x71D5D90", VA = "0x1871D7790", Slot = "95")]
	public void OOCNJIHJKBG(LIIKICNCDGJ KLABJGGMBGH, bool AMABBFGDEKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x71D5B30", Offset = "0x71D4130", VA = "0x1871D5B30", Slot = "96")]
	public void JJMPFDCNDHH(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x71D2A90", Offset = "0x71D1090", VA = "0x1871D2A90", Slot = "97")]
	public void DCPDNOOILNJ(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x71D7960", Offset = "0x71D5F60", VA = "0x1871D7960", Slot = "98")]
	public Vector3 PBFBIDMAHAC(Vector3 FOEOPLOKPOB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x71D4B20", Offset = "0x71D3120", VA = "0x1871D4B20", Slot = "99")]
	public Vector3 IAPPHLOLCLB(Vector3 CALOMLJNHAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x71D1EB0", Offset = "0x71D04B0", VA = "0x1871D1EB0", Slot = "100")]
	public void DLEEIKFFPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x71D38D0", Offset = "0x71D1ED0", VA = "0x1871D38D0", Slot = "101")]
	public void FNJCHAFGION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x71D20D0", Offset = "0x71D06D0", VA = "0x1871D20D0", Slot = "102")]
	public void BJBDPEAHGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x71D5510", Offset = "0x71D3B10", VA = "0x1871D5510", Slot = "103")]
	public void IPGHPFLDEBA(Vector3 MEKMEJHIFMC, Vector3 KBNCPNDBCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x71D49F0", Offset = "0x71D2FF0", VA = "0x1871D49F0", Slot = "104")]
	public void IADKCNKPDLN(Vector3 AHEKOJPDIDP, Vector3 JKDCCBAFKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x71D2920", Offset = "0x71D0F20", VA = "0x1871D2920", Slot = "105")]
	public void CODKDPLCDHD(Vector3 IEAGHIDJHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x71D45D0", Offset = "0x71D2BD0", VA = "0x1871D45D0", Slot = "106")]
	public void HHIIHBGIEBI(DCOEIOEOLOO OGDHOAEFGEK, Vector3 ADCIKHMIKDC, float BFNABEBMGML, float EJJOPELHGIF = 8f, float ODMENHHKENK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x71D4C20", Offset = "0x71D3220", VA = "0x1871D4C20", Slot = "107")]
	public void IBGBKJDOGEF(HLIEOJLMCMD DLJHIKDDMED, Vector3 FDNLGBMHIMG, float LGADHHDBLPE = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x71D7070", Offset = "0x71D5670", VA = "0x1871D7070", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void NICHPOJBKKJ(HLIEOJLMCMD DLJHIKDDMED, Vector3 JOLHFCINNMA, float LGCLKPGINJF = 7f, float GNAMHFMCPHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x71D5EE0", Offset = "0x71D44E0", VA = "0x1871D5EE0", Slot = "109")]
	public Vector3 KMAMKOPDPLJ(Vector3 KLABJGGMBGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x71D27D0", Offset = "0x71D0DD0", VA = "0x1871D27D0", Slot = "110")]
	public Vector3 CJOMOILHAIC(Vector3 KLABJGGMBGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x71D7C60", Offset = "0x71D6260", VA = "0x1871D7C60", Slot = "111")]
	public void PMJJMHPJAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x71D40D0", Offset = "0x71D26D0", VA = "0x1871D40D0", Slot = "112")]
	public void GGPIDHALABF(LIIKICNCDGJ CEECOCODHNB, object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x71D3270", Offset = "0x71D1870", VA = "0x1871D3270", Slot = "113")]
	public void EOKDJDIFNHB(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x71D57F0", Offset = "0x71D3DF0", VA = "0x1871D57F0", Slot = "61")]
	public void JGHOGCEFAIE((Quaternion rot, Vector3 moments) JBHPDEADHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x71D4580", Offset = "0x71D2B80", VA = "0x1871D4580", Slot = "114")]
	public void HGAGCFBNGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x71D7740", Offset = "0x71D5D40", VA = "0x1871D7740", Slot = "115")]
	public void OMMIJCKCGMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x71D5C50", Offset = "0x71D4250", VA = "0x1871D5C50", Slot = "116")]
	public void JNIJLCFKCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x71D1FA0", Offset = "0x71D05A0", VA = "0x1871D1FA0", Slot = "117")]
	public bool BEIIONGBDOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x71D58D0", Offset = "0x71D3ED0", VA = "0x1871D58D0", Slot = "94")]
	public void JGJAPHHHLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x71D72C0", Offset = "0x71D58C0", VA = "0x1871D72C0", Slot = "118")]
	public void OIPENABPJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x71D6CB0", Offset = "0x71D52B0", VA = "0x1871D6CB0", Slot = "119")]
	public void MLIEHFDDMKO(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x71D7A60", Offset = "0x71D6060", VA = "0x1871D7A60", Slot = "120")]
	public void PBJGEJFAFPH(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x71D4FE0", Offset = "0x71D35E0", VA = "0x1871D4FE0", Slot = "121")]
	public void IIKHLAALMID(object FLLNLBHFENG, bool HJBOCAGMBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x71D52B0", Offset = "0x71D38B0", VA = "0x1871D52B0", Slot = "122")]
	public void IONGMLONIEL(Vector3 ALEJNJJFLEH, Quaternion AJOIIFAELBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x71D6600", Offset = "0x71D4C00", VA = "0x1871D6600", Slot = "123")]
	public void LOPIGIIJLAG(Vector3 PFAHFEPFAAJ, Quaternion NKABCINOOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x71D3320", Offset = "0x71D1920", VA = "0x1871D3320", Slot = "124")]
	public bool FDEJIKDPNDF(float OADJCOEBHOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x71D3E00", Offset = "0x71D2400", VA = "0x1871D3E00", Slot = "125")]
	public void GCABGAHFDOG(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x71D36F0", Offset = "0x71D1CF0", VA = "0x1871D36F0", Slot = "126")]
	public void FJJFBANMDNK(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x71D50C0", Offset = "0x71D36C0", VA = "0x1871D50C0", Slot = "127")]
	public void IMDNBJHCJDN(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x71D4E50", Offset = "0x71D3450", VA = "0x1871D4E50", Slot = "128")]
	public void IFBCHBJDHFA(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x71D25F0", Offset = "0x71D0BF0", VA = "0x1871D25F0", Slot = "129")]
	public void CHFHEKALINP(Vector3 LENLJCDCMCG, ForceMode KNHJEAKHHDM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x71D3500", Offset = "0x71D1B00", VA = "0x1871D3500", Slot = "130")]
	public void FGINIKMJJCN(Vector3 LENLJCDCMCG, Vector3 LEELMECKGCG, ForceMode KNHJEAKHHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x71D43F0", Offset = "0x71D29F0", VA = "0x1871D43F0", Slot = "131")]
	public void HCJOOMKAIIF(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x71D3610", Offset = "0x71D1C10", VA = "0x1871D3610", Slot = "132")]
	public void FIKJJJCHOCM(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x71D4240", Offset = "0x71D2840", VA = "0x1871D4240", Slot = "133")]
	public bool GNBADKMPLDL(Vector3 JFCINBHKCNC, [Out] RaycastHit DPMDGOFFPKK, float KEEIEBHGPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x71D7800", Offset = "0x71D5E00", VA = "0x1871D7800", Slot = "134")]
	public void OPJOMHHIOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x71D7CB0", Offset = "0x71D62B0", VA = "0x1871D7CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x71D6740", Offset = "0x71D4D40", VA = "0x1871D6740")]
	private void MAECMFALOHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x71D33F0", Offset = "0x71D19F0", VA = "0x1871D33F0")]
	private void FEHNMBACMKC(LIIKICNCDGJ LDJCBIBELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x71D6340", Offset = "0x71D4940", VA = "0x1871D6340")]
	private void LKKANNMKPCC(LIIKICNCDGJ LDJCBIBELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x71D6160", Offset = "0x71D4760", VA = "0x1871D6160")]
	private void LIHDCLJKFPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x71D42E0", Offset = "0x71D28E0", VA = "0x1871D42E0")]
	private void GPIFCMFJGOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x71D3E60", Offset = "0x71D2460", VA = "0x1871D3E60")]
	private void GCEAJLGMLAO(LIIKICNCDGJ MKEMFFOAONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x71D5CA0", Offset = "0x71D42A0", VA = "0x1871D5CA0")]
	private void JPEFCMPOPCG(LIIKICNCDGJ LDJCBIBELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x71D2B40", Offset = "0x71D1140", VA = "0x1871D2B40")]
	private void DEBKOMLEGPA(LIIKICNCDGJ LDJCBIBELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x71D5920", Offset = "0x71D3F20", VA = "0x1871D5920")]
	private void JGMMPGMIHFI(EKIGEEIGKIO LDJCBIBELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x71D3970", Offset = "0x71D1F70", VA = "0x1871D3970", Slot = "141")]
	protected virtual void FNONFAOOJAN(EKIGEEIGKIO IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x71D6990", Offset = "0x71D4F90", VA = "0x1871D6990")]
	protected void MICNHICNDGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x71D2CB0", Offset = "0x71D12B0", VA = "0x1871D2CB0")]
	protected void DGMNBIPNFCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x71D5E20", Offset = "0x71D4420", VA = "0x1871D5E20", Slot = "142")]
	protected virtual IDisposable KGHHKDJJCKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class POBLGGPCKOL
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x71DEB30", Offset = "0x71DD130", VA = "0x1871DEB30")]
	public static LIIKICNCDGJ EGEDFEICPLP(this LIIKICNCDGJ IOHJIPHILJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x71DEBF0", Offset = "0x71DD1F0", VA = "0x1871DEBF0")]
	public static bool GIAEJNADIKG(this LIIKICNCDGJ IOHJIPHILJI, LIIKICNCDGJ NJFMAAHNHCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x71DEC70", Offset = "0x71DD270", VA = "0x1871DEC70")]
	public static bool HNCJDKEBHLC(this LIIKICNCDGJ IOHJIPHILJI, LIIKICNCDGJ EMNAFJIGFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x71DECF0", Offset = "0x71DD2F0", VA = "0x1871DECF0")]
	public static EKIGEEIGKIO IHNGEPJPIOF(this LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x71DED40", Offset = "0x71DD340", VA = "0x1871DED40")]
	public static HDBLPCDAJNK MNNCAMHKCIE(this LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BPHGPPJLIDK : DFHCEAJLAEJ
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x71CAB20", Offset = "0x71C9120", VA = "0x1871CAB20", Slot = "19")]
	public LIIKICNCDGJ ENFLHFFGAOB(RigidbodyEx IOHJIPHILJI, OCGBPCDKBKC JGCMECODHDI, PLEPOBHCEGN EHABNPPLNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "4")]
	public AJKKKNAMDJO FEFKNLMJDGI(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "5")]
	public AOKAONLJHOF MKBPNEELGIH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "6")]
	public DEGIIDBFCIH LCECHNCNPPN(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "7")]
	public KJJGDBKLOGE LEKMAHANNMM(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "8")]
	public ENMPBGGDGOP JADPOEEKFJA(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "9")]
	public KIAJJIOCNGO CPFFGDECCLE(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "10")]
	public KIAAOCCDDCB NBINMFELFGP(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "11")]
	public HEBLMGHFANA GDADELKPNAH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "12")]
	public IJJJKIKMEKK DGGJKEDCOKH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "13")]
	public LKNIHEGCKKI IILOOAKBFCC(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360")]
	public HMNMNHHFKJC GBCLHDECGFM(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360")]
	public OMJMPOHILOG FPMDDNDJJCF(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360")]
	public CDFAFOAFKII FMNBBFAABKB(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360")]
	public GKHFDEMHCGH IICGHNCEKCL(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360")]
	public NEDIICPLNME PBLEFFOELKN(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public BPHGPPJLIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "14")]
	private HMNMNHHFKJC MPMJAKCFNOD(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "15")]
	private OMJMPOHILOG AGEFOPNFPME(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "16")]
	private CDFAFOAFKII IAKCJKBIMCK(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "17")]
	private GKHFDEMHCGH DLEIFLNLDHE(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x71C97F0", Offset = "0x71C7DF0", VA = "0x1871C97F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x71C95C0", Offset = "0x71C7BC0", VA = "0x1871C95C0", Slot = "20")]
	public void InitReferences(GOMDDPLFKLJ KKAHGNKMLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x71C9280", Offset = "0x71C7880", VA = "0x1871C9280", Slot = "4")]
	public AJKKKNAMDJO FEFKNLMJDGI(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x71C9850", Offset = "0x71C7E50", VA = "0x1871C9850", Slot = "5")]
	public AOKAONLJHOF MKBPNEELGIH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x71C96B0", Offset = "0x71C7CB0", VA = "0x1871C96B0", Slot = "6")]
	public DEGIIDBFCIH LCECHNCNPPN(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x71C9750", Offset = "0x71C7D50", VA = "0x1871C9750", Slot = "7")]
	public KJJGDBKLOGE LEKMAHANNMM(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x71C9610", Offset = "0x71C7C10", VA = "0x1871C9610", Slot = "8")]
	public ENMPBGGDGOP JADPOEEKFJA(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x71C8FB0", Offset = "0x71C75B0", VA = "0x1871C8FB0", Slot = "9")]
	public KIAJJIOCNGO CPFFGDECCLE(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x71C98F0", Offset = "0x71C7EF0", VA = "0x1871C98F0", Slot = "10")]
	public KIAAOCCDDCB NBINMFELFGP(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x71C9480", Offset = "0x71C7A80", VA = "0x1871C9480", Slot = "11")]
	public HEBLMGHFANA GDADELKPNAH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x71C9050", Offset = "0x71C7650", VA = "0x1871C9050", Slot = "12")]
	public IJJJKIKMEKK DGGJKEDCOKH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x71C9520", Offset = "0x71C7B20", VA = "0x1871C9520", Slot = "13")]
	public LKNIHEGCKKI IILOOAKBFCC(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x71C93D0", Offset = "0x71C79D0", VA = "0x1871C93D0")]
	public HMNMNHHFKJC GBCLHDECGFM(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x71C8E50", Offset = "0x71C7450", VA = "0x1871C8E50")]
	public OMJMPOHILOG FPMDDNDJJCF(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x71C9320", Offset = "0x71C7920", VA = "0x1871C9320")]
	public CDFAFOAFKII FMNBBFAABKB(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x71C90F0", Offset = "0x71C76F0", VA = "0x1871C90F0")]
	public GKHFDEMHCGH IICGHNCEKCL(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x71C8F00", Offset = "0x71C7500", VA = "0x1871C8F00")]
	public NEDIICPLNME PBLEFFOELKN(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x71C91A0", Offset = "0x71C77A0", VA = "0x1871C91A0", Slot = "19")]
	public LIIKICNCDGJ ENFLHFFGAOB(RigidbodyEx IOHJIPHILJI, OCGBPCDKBKC JGCMECODHDI, PLEPOBHCEGN EHABNPPLNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x71C9990", Offset = "0x71C7F90", VA = "0x1871C9990")]
	public ABCHDKLPAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x71C93D0", Offset = "0x71C79D0", VA = "0x1871C93D0", Slot = "14")]
	private HMNMNHHFKJC MPMJAKCFNOD(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x71C8E50", Offset = "0x71C7450", VA = "0x1871C8E50", Slot = "15")]
	private OMJMPOHILOG AGEFOPNFPME(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x71C9320", Offset = "0x71C7920", VA = "0x1871C9320", Slot = "16")]
	private CDFAFOAFKII IAKCJKBIMCK(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x71C90F0", Offset = "0x71C76F0", VA = "0x1871C90F0", Slot = "17")]
	private GKHFDEMHCGH DLEIFLNLDHE(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x71C8F00", Offset = "0x71C7500", VA = "0x1871C8F00", Slot = "18")]
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
	GOJDLPKALLN<LIIKICNCDGJ> CLJIKLFCENI
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
		[Cpp2IlInjected.Address(RVA = "0x71D1050", Offset = "0x71CF650", VA = "0x1871D1050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode OHGCCBCICEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x71DE790", Offset = "0x71DCD90", VA = "0x1871DE790", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x71DE690", Offset = "0x71DCC90", VA = "0x1871DE690", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x71CE440", Offset = "0x71CCA40", VA = "0x1871CE440")]
	public PJMCOFDOGMD(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x71DE580", Offset = "0x71DCB80", VA = "0x1871DE580", Slot = "6")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x71DE700", Offset = "0x71DCD00", VA = "0x1871DE700", Slot = "9")]
	public void CFCFDMGBDJO(Rigidbody OLNABEIJDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x71DEA00", Offset = "0x71DD000", VA = "0x1871DEA00", Slot = "7")]
	public void HNFBAGBIDGN(bool ILMFJGEOAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x71DE780", Offset = "0x71DCD80", VA = "0x1871DE780", Slot = "8")]
	public void EGEGGPMALGL(bool ILMFJGEOAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x71DE8A0", Offset = "0x71DCEA0", VA = "0x1871DE8A0", Slot = "10")]
	public bool GNBADKMPLDL(Vector3 JFCINBHKCNC, [Out] RaycastHit DPMDGOFFPKK, float KEEIEBHGPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x71DEA10", Offset = "0x71DD010", VA = "0x1871DEA10")]
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
		[Cpp2IlInjected.Address(RVA = "0x71D9D30", Offset = "0x71D8330", VA = "0x1871D9D30", Slot = "6")]
		get
		{
			return default(IDPKEMCPFEK);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x71D9F20", Offset = "0x71D8520", VA = "0x1871D9F20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform IFEDLKIIKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x71D99A0", Offset = "0x71D7FA0", VA = "0x1871D99A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<MGNMBPEAPIF, MGNMBPEAPIF> HGNPDKHNLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x71D9E70", Offset = "0x71D8470", VA = "0x1871D9E70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x71D9C80", Offset = "0x71D8280", VA = "0x1871D9C80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x71D9FF0", Offset = "0x71D85F0", VA = "0x1871D9FF0")]
	public LFNMKGGOEFG(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x71D99C0", Offset = "0x71D7FC0", VA = "0x1871D99C0", Slot = "8")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x71D9C30", Offset = "0x71D8230", VA = "0x1871D9C30", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xB15650", Offset = "0xB13C50", VA = "0x180B15650", Slot = "11")]
	private void KLIDDCMEIFA(MGNMBPEAPIF FOLFJJOEOPG, MGNMBPEAPIF EDIGGMGOMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "12")]
	private void AEDBPGIDLOI(bool ABGDCOOCPNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OKOCGDNIHAO : DFHCEAJLAEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x71DDBE0", Offset = "0x71DC1E0", VA = "0x1871DDBE0", Slot = "4")]
	public AJKKKNAMDJO FEFKNLMJDGI(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x71DE340", Offset = "0x71DC940", VA = "0x1871DE340", Slot = "5")]
	public AOKAONLJHOF MKBPNEELGIH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x71DE190", Offset = "0x71DC790", VA = "0x1871DE190", Slot = "6")]
	public DEGIIDBFCIH LCECHNCNPPN(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x71DE2C0", Offset = "0x71DC8C0", VA = "0x1871DE2C0", Slot = "7")]
	public KJJGDBKLOGE LEKMAHANNMM(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x71DE0C0", Offset = "0x71DC6C0", VA = "0x1871DE0C0", Slot = "8")]
	public ENMPBGGDGOP JADPOEEKFJA(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x71DD770", Offset = "0x71DBD70", VA = "0x1871DD770", Slot = "9")]
	public KIAJJIOCNGO CPFFGDECCLE(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x71DE460", Offset = "0x71DCA60", VA = "0x1871DE460", Slot = "10")]
	public KIAAOCCDDCB NBINMFELFGP(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x71DDF40", Offset = "0x71DC540", VA = "0x1871DDF40", Slot = "11")]
	public HEBLMGHFANA GDADELKPNAH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x71DD840", Offset = "0x71DBE40", VA = "0x1871DD840", Slot = "12")]
	public IJJJKIKMEKK DGGJKEDCOKH(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x71DE000", Offset = "0x71DC600", VA = "0x1871DE000", Slot = "13")]
	public LKNIHEGCKKI IILOOAKBFCC(LIIKICNCDGJ BDPEMHOFOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x71DDE00", Offset = "0x71DC400", VA = "0x1871DDE00")]
	public HMNMNHHFKJC GBCLHDECGFM(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x71DD500", Offset = "0x71DBB00", VA = "0x1871DD500")]
	public OMJMPOHILOG FPMDDNDJJCF(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x71DDCD0", Offset = "0x71DC2D0", VA = "0x1871DDCD0")]
	public CDFAFOAFKII FMNBBFAABKB(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x71DD900", Offset = "0x71DBF00", VA = "0x1871DD900")]
	public GKHFDEMHCGH IICGHNCEKCL(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x71DD690", Offset = "0x71DBC90", VA = "0x1871DD690")]
	public NEDIICPLNME PBLEFFOELKN(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x71DDA90", Offset = "0x71DC090", VA = "0x1871DDA90", Slot = "19")]
	public LIIKICNCDGJ ENFLHFFGAOB(RigidbodyEx IOHJIPHILJI, OCGBPCDKBKC JGCMECODHDI, PLEPOBHCEGN EHABNPPLNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public OKOCGDNIHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x71DDE00", Offset = "0x71DC400", VA = "0x1871DDE00", Slot = "14")]
	private HMNMNHHFKJC MPMJAKCFNOD(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x71DD500", Offset = "0x71DBB00", VA = "0x1871DD500", Slot = "15")]
	private OMJMPOHILOG AGEFOPNFPME(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x71DDCD0", Offset = "0x71DC2D0", VA = "0x1871DDCD0", Slot = "16")]
	private CDFAFOAFKII IAKCJKBIMCK(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x71DD900", Offset = "0x71DBF00", VA = "0x1871DD900", Slot = "17")]
	private GKHFDEMHCGH DLEIFLNLDHE(LIIKICNCDGJ BDPEMHOFOHC, [In] OCGBPCDKBKC JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x71DD690", Offset = "0x71DBC90", VA = "0x1871DD690", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x71D1050", Offset = "0x71CF650", VA = "0x1871D1050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool GBINOLADCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x71D1740", Offset = "0x71CFD40", VA = "0x1871D1740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool IIJMHMHEHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x71CA500", Offset = "0x71C8B00", VA = "0x1871CA500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private LIIKICNCDGJ NPDGLEPLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x71D16E0", Offset = "0x71CFCE0", VA = "0x1871D16E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x71CE440", Offset = "0x71CCA40", VA = "0x1871CE440")]
	public FAGPJFMMCAN(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x71D0EF0", Offset = "0x71CF4F0", VA = "0x1871D0EF0", Slot = "4")]
	public void CHFHEKALINP(Vector3 LENLJCDCMCG, ForceMode KNHJEAKHHDM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x71D1790", Offset = "0x71CFD90", VA = "0x1871D1790")]
	private void KMEALNCAKNG(Vector3 LENLJCDCMCG, ForceMode KNHJEAKHHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x71D10A0", Offset = "0x71CF6A0", VA = "0x1871D10A0", Slot = "5")]
	public void FGINIKMJJCN(Vector3 LENLJCDCMCG, Vector3 LEELMECKGCG, ForceMode KNHJEAKHHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x71D1580", Offset = "0x71CFB80", VA = "0x1871D1580", Slot = "6")]
	public void HCJOOMKAIIF(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x71D19F0", Offset = "0x71CFFF0", VA = "0x1871D19F0")]
	private void PNMFGIKJIBH(Vector3 KDCOGIIMFGH, ForceMode KNHJEAKHHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x71D1320", Offset = "0x71CF920", VA = "0x1871D1320", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F2D20", Offset = "0x9F1320", VA = "0x1809F2D20", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x71CE2C0", Offset = "0x71CC8C0", VA = "0x1871CE2C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x71CE440", Offset = "0x71CCA40", VA = "0x1871CE440")]
	public DILAANDHNIC(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x71CE290", Offset = "0x71CC890", VA = "0x1871CE290", Slot = "6")]
	public void CFCFDMGBDJO(Rigidbody OLNABEIJDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x71CE3D0", Offset = "0x71CC9D0", VA = "0x1871CE3D0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x71DBB50", Offset = "0x71DA150", VA = "0x1871DBB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public LIIKICNCDGJ NPDGLEPLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x887950", Offset = "0x885F50", VA = "0x180887950", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x71DD390", Offset = "0x71DB990", VA = "0x1871DD390", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public LIIKICNCDGJ GEBPHFIJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x886840", Offset = "0x884E40", VA = "0x180886840", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<LIIKICNCDGJ> FCLKNFGAHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x886870", Offset = "0x884E70", VA = "0x180886870", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event LDHKFCBONJG HAPCHNBOPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x71DCB10", Offset = "0x71DB110", VA = "0x1871DCB10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x71DC2B0", Offset = "0x71DA8B0", VA = "0x1871DC2B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event LDHKFCBONJG ALMMOHFNLGC
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x71DC670", Offset = "0x71DAC70", VA = "0x1871DC670", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x71DCBB0", Offset = "0x71DB1B0", VA = "0x1871DCBB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event KHNKEDFCPCA LMKJBLGMEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x71DC5D0", Offset = "0x71DABD0", VA = "0x1871DC5D0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x71DCC50", Offset = "0x71DB250", VA = "0x1871DCC50", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action ANMGCGOCFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x71DB640", Offset = "0x71D9C40", VA = "0x1871DB640", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x71DC870", Offset = "0x71DAE70", VA = "0x1871DC870", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action FNEODFAMECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x71DBC50", Offset = "0x71DA250", VA = "0x1871DBC50", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x71DD3A0", Offset = "0x71DB9A0", VA = "0x1871DD3A0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<LIIKICNCDGJ> KPHMOBEEIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x71DCA60", Offset = "0x71DB060", VA = "0x1871DCA60", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x71DC7C0", Offset = "0x71DADC0", VA = "0x1871DC7C0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<LIIKICNCDGJ> PLJJCAEANAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x71DC710", Offset = "0x71DAD10", VA = "0x1871DC710", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x71DBEF0", Offset = "0x71DA4F0", VA = "0x1871DBEF0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action EKFLHALGKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x71DC210", Offset = "0x71DA810", VA = "0x1871DC210", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x71DBCF0", Offset = "0x71DA2F0", VA = "0x1871DBCF0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<LIIKICNCDGJ> MPBOIHOJJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x71DC910", Offset = "0x71DAF10", VA = "0x1871DC910", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x71DBAA0", Offset = "0x71DA0A0", VA = "0x1871DBAA0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x71DD440", Offset = "0x71DBA40", VA = "0x1871DD440")]
	public ODNEPNKNCAK(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x71DBBB0", Offset = "0x71DA1B0", VA = "0x1871DBBB0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x71DCCF0", Offset = "0x71DB2F0", VA = "0x1871DCCF0", Slot = "30")]
	public void OOCNJIHJKBG(LIIKICNCDGJ LEEMAEKICLM, bool AMABBFGDEKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x71DBFA0", Offset = "0x71DA5A0", VA = "0x1871DBFA0", Slot = "6")]
	public void ICNHCIBJJPB(LIIKICNCDGJ MKEMFFOAONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x71DC350", Offset = "0x71DA950", VA = "0x1871DC350", Slot = "7")]
	public void JJNCIJPMKLL(LIIKICNCDGJ MKEMFFOAONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x71DB6E0", Offset = "0x71D9CE0", VA = "0x1871DB6E0", Slot = "4")]
	public void BHLBCINICIP(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x71DC9C0", Offset = "0x71DAFC0", VA = "0x1871DC9C0", Slot = "5")]
	public void MBJFOPHLCHM(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x71DBD90", Offset = "0x71DA390", VA = "0x1871DBD90")]
	private void FLODNCANFJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x71DB7F0", Offset = "0x71D9DF0", VA = "0x1871DB7F0")]
	private void BOJFJPJNMEM(LIIKICNCDGJ MKEMFFOAONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x71DB960", Offset = "0x71D9F60", VA = "0x1871DB960")]
	private void CCIKNEDOJLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x71DB830", Offset = "0x71D9E30", VA = "0x1871DB830")]
	private void CAOPJHOHEKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x71DD270", Offset = "0x71DB870", VA = "0x1871DD270")]
	private void OPNNLEFPCDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x71DBE30", Offset = "0x71DA430", VA = "0x1871DBE30")]
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
	[Cpp2IlInjected.Address(RVA = "0x71DA380", Offset = "0x71D8980", VA = "0x1871DA380")]
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
	private readonly GOJDLPKALLN<LIIKICNCDGJ> GNCMJCKJPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool KOPFHGOJFFJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GOJDLPKALLN<LIIKICNCDGJ> CLJIKLFCENI
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 BNNAKBMDNKI
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x71D8FA0", Offset = "0x71D75A0", VA = "0x1871D8FA0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 ECNEMFJNMLD
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x71D8FD0", Offset = "0x71D75D0", VA = "0x1871D8FD0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 GJNHMHCKKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x71D9630", Offset = "0x71D7C30", VA = "0x1871D9630")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public LIIKICNCDGJ GBBIDMLGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x71D9580", Offset = "0x71D7B80", VA = "0x1871D9580", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x71D9720", Offset = "0x71D7D20", VA = "0x1871D9720")]
	public KGJMHCLOIIP(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x71D8BA0", Offset = "0x71D71A0", VA = "0x1871D8BA0", Slot = "8")]
	public void AMEIMADIHAC(LIIKICNCDGJ LDJCBIBELIM, object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x71D9190", Offset = "0x71D7790", VA = "0x1871D9190", Slot = "9")]
	public void IDAJDBAPFGN(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x71D91F0", Offset = "0x71D77F0", VA = "0x1871D91F0")]
	private Vector3 KMCODOFJKOM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x71D8C10", Offset = "0x71D7210", VA = "0x1871D8C10")]
	private void AMLMKAIIBGP(LIIKICNCDGJ HMDBGPHMHLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class LBFPGDCINIH
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x71D98E0", Offset = "0x71D7EE0", VA = "0x1871D98E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xF08640", Offset = "0xF06C40", VA = "0x180F08640", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x71CE8B0", Offset = "0x71CCEB0", VA = "0x1871CE8B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 LDFAKINHCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x71CFD00", Offset = "0x71CE300", VA = "0x1871CFD00", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float LINHIOGBDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9F2D40", Offset = "0x9F1340", VA = "0x1809F2D40", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x71CE960", Offset = "0x71CCF60", VA = "0x1871CE960")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float ABINEMAJDGH
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2D30", Offset = "0x9F1330", VA = "0x1809F2D30", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x71D05D0", Offset = "0x71CEBD0", VA = "0x1871D05D0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 LALMNOFKGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x71D0680", Offset = "0x71CEC80", VA = "0x1871D0680", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion KPBECAOAIDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x71D03B0", Offset = "0x71CE9B0", VA = "0x1871D03B0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody KJODLCHDEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x71CE860", Offset = "0x71CCE60", VA = "0x1871CE860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event LDHKFCBONJG EKOJGAGMOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x71CE7C0", Offset = "0x71CCDC0", VA = "0x1871CE7C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x71D0530", Offset = "0x71CEB30", VA = "0x1871D0530", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x71D0D90", Offset = "0x71CF390", VA = "0x1871D0D90")]
	public EIMKGAPFGDN(LIIKICNCDGJ IOHJIPHILJI, [In] OCGBPCDKBKC JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x71CFB50", Offset = "0x71CE150", VA = "0x1871CFB50", Slot = "17")]
	public void HGAGCFBNGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x71D0810", Offset = "0x71CEE10", VA = "0x1871D0810", Slot = "16")]
	public void OMMIJCKCGMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x71CE6E0", Offset = "0x71CCCE0", VA = "0x1871CE6E0", Slot = "19")]
	public void CFCFDMGBDJO(Rigidbody OLNABEIJDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x71D01D0", Offset = "0x71CE7D0", VA = "0x1871D01D0", Slot = "20")]
	public void KLMOMCBKCOC(Rigidbody OLNABEIJDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x71D0020", Offset = "0x71CE620", VA = "0x1871D0020", Slot = "18")]
	public void JNIJLCFKCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x71D08F0", Offset = "0x71CEEF0", VA = "0x1871D08F0", Slot = "21")]
	public void OPJOMHHIOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x71CE8B0", Offset = "0x71CCEB0", VA = "0x1871CE8B0")]
	private void DGLEAJDAJAD(Vector3 KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x71CFA60", Offset = "0x71CE060", VA = "0x1871CFA60")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 FLGDKPCHMMH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x71CE960", Offset = "0x71CCF60", VA = "0x1871CE960")]
	private void LGOONBOELMA(float KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x71D05D0", Offset = "0x71CEBD0", VA = "0x1871D05D0")]
	private void PINHAICNNMP(float KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x71CE540", Offset = "0x71CCB40", VA = "0x1871CE540")]
	private Vector3 BNGEGGBECNP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x71CFDF0", Offset = "0x71CE3F0", VA = "0x1871CFDF0", Slot = "15")]
	public void JGHOGCEFAIE((Quaternion rot, Vector3 moments) JBHPDEADHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x71CEA70", Offset = "0x71CD070", VA = "0x1871CEA70")]
	private Quaternion EHMKCJEOGGK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x71CEBF0", Offset = "0x71CD1F0", VA = "0x1871CEBF0")]
	public void FGIJBHJABKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x71CECC0", Offset = "0x71CD2C0", VA = "0x1871CECC0", Slot = "4")]
	public (float, Vector3) FGIJBHJABKI(Rigidbody INJJGGGMMHL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class GIBJPDHAKNO
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x71D1DF0", Offset = "0x71D03F0", VA = "0x1871D1DF0")]
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
	private readonly GLGPGBPNFLE FKNHIGAGNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DKOEEBIFOEM NKKEOAMLFCK;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool IDJFOGKNBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x109DC80", Offset = "0x109C280", VA = "0x18109DC80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public DKOEEBIFOEM EMGADGGKFNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8F5280", Offset = "0x8F3880", VA = "0x1808F5280", Slot = "11")]
		get
		{
			return default(DKOEEBIFOEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x71DAA40", Offset = "0x71D9040", VA = "0x1871DAA40")]
	public MHCBMKICHDP(LIIKICNCDGJ IOHJIPHILJI, [In] OCGBPCDKBKC JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x71DA440", Offset = "0x71D8A40", VA = "0x1871DA440", Slot = "4")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x71DA9A0", Offset = "0x71D8FA0", VA = "0x1871DA9A0")]
	private bool PMEFPGDJNIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x71DA550", Offset = "0x71D8B50", VA = "0x1871DA550", Slot = "5")]
	public void FKCKHNKJPKE(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x71DA6B0", Offset = "0x71D8CB0", VA = "0x1871DA6B0", Slot = "6")]
	public void GIOLFHAFEFA(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x71DA580", Offset = "0x71D8B80", VA = "0x1871DA580", Slot = "9")]
	public void GAAIHOIMDNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x71DA720", Offset = "0x71D8D20", VA = "0x1871DA720")]
	private void IBCKMHJLHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x71DA830", Offset = "0x71D8E30", VA = "0x1871DA830")]
	private void IOHDHOOJODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x71DA510", Offset = "0x71D8B10", VA = "0x1871DA510", Slot = "8")]
	public void EEFGGKEHGNE(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x71DA6E0", Offset = "0x71D8CE0", VA = "0x1871DA6E0", Slot = "7")]
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
	private readonly GLGPGBPNFLE PFALBCBFPFK;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool GBINOLADCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x71C9C70", Offset = "0x71C8270", VA = "0x1871C9C70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event LDHKFCBONJG CJBJKADPOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x71C9D20", Offset = "0x71C8320", VA = "0x1871C9D20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x71C9AC0", Offset = "0x71C80C0", VA = "0x1871C9AC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x71C9E50", Offset = "0x71C8450", VA = "0x1871C9E50")]
	public AKFPBKEHNKD(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x71C9E30", Offset = "0x71C8430", VA = "0x1871C9E30", Slot = "7")]
	public void MLIEHFDDMKO(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x71C9E40", Offset = "0x71C8440", VA = "0x1871C9E40", Slot = "8")]
	public void PBJGEJFAFPH(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x71C9B60", Offset = "0x71C8160", VA = "0x1871C9B60", Slot = "9")]
	public void IIKHLAALMID(object FLLNLBHFENG, bool HJBOCAGMBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x71C9DF0", Offset = "0x71C83F0", VA = "0x1871C9DF0", Slot = "12")]
	public void LFBICFOCLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x71C9A40", Offset = "0x71C8040", VA = "0x1871C9A40", Slot = "10")]
	public void CFCFDMGBDJO(Rigidbody FHMDKJNEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x71C9DC0", Offset = "0x71C83C0", VA = "0x1871C9DC0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool EDFLICMDNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x71D82F0", Offset = "0x71D68F0", VA = "0x1871D82F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool FJHGFOFBNHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x901400", Offset = "0x8FFA00", VA = "0x180901400", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event LDHKFCBONJG NFNPGGIDPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x71D8460", Offset = "0x71D6A60", VA = "0x1871D8460", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x71D88E0", Offset = "0x71D6EE0", VA = "0x1871D88E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x71D8980", Offset = "0x71D6F80", VA = "0x1871D8980")]
	public JJJBCDKGMFG(LIIKICNCDGJ IOHJIPHILJI, [In] OCGBPCDKBKC JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x71D7DE0", Offset = "0x71D63E0", VA = "0x1871D7DE0", Slot = "9")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x71D81F0", Offset = "0x71D67F0", VA = "0x1871D81F0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x71D8500", Offset = "0x71D6B00", VA = "0x1871D8500", Slot = "10")]
	public void JPEFCMPOPCG(LIIKICNCDGJ LDJCBIBELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x71D7F10", Offset = "0x71D6510", VA = "0x1871D7F10", Slot = "11")]
	public void DEBKOMLEGPA(LIIKICNCDGJ LDJCBIBELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x71D8080", Offset = "0x71D6680", VA = "0x1871D8080")]
	private void DIKMJIPMHAI(PhotonView LNLADNNPHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x71D8310", Offset = "0x71D6910", VA = "0x1871D8310")]
	private void IEEBIAHADLI(EKIGEEIGKIO NHMPFCPPNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x71D8670", Offset = "0x71D6C70", VA = "0x1871D8670")]
	private void OHLICAJMDJF(PhotonView JFHBHKMIEHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class LAPKHDHFLNM
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x71D9820", Offset = "0x71D7E20", VA = "0x1871D9820")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D1A70", Offset = "0x8D0070", VA = "0x1808D1A70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x46F2330", Offset = "0x46F0930", VA = "0x1846F2330", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool NJDFJEAACPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9F2CD0", Offset = "0x9F12D0", VA = "0x1809F2CD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x46F2320", Offset = "0x46F0920", VA = "0x1846F2320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints BIJPIEOKJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x88D660", Offset = "0x88BC60", VA = "0x18088D660", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x71DA0B0", Offset = "0x71D86B0", VA = "0x1871DA0B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x71DA210", Offset = "0x71D8810", VA = "0x1871DA210")]
	public LKLANCHNKNL(LIIKICNCDGJ IOHJIPHILJI, [In] OCGBPCDKBKC JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x71DA080", Offset = "0x71D8680", VA = "0x1871DA080", Slot = "9")]
	public void CFCFDMGBDJO(Rigidbody OLNABEIJDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x71DA1E0", Offset = "0x71D87E0", VA = "0x1871DA1E0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x91DD80", Offset = "0x91C380", VA = "0x18091DD80", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x71C9F90", Offset = "0x71C8590", VA = "0x1871C9F90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float CHNNGEICIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35AB0", VA = "0x180A374B0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x71CA100", Offset = "0x71C8700", VA = "0x1871CA100", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x71CA1D0", Offset = "0x71C87D0", VA = "0x1871CA1D0")]
	public AOMPCOJFIHB(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x71C9F40", Offset = "0x71C8540", VA = "0x1871C9F40", Slot = "8")]
	public void CFCFDMGBDJO(Rigidbody OLNABEIJDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x71CA060", Offset = "0x71C8660", VA = "0x1871CA060", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x71CE860", Offset = "0x71CCE60", VA = "0x1871CE860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool DJDPKKNHDEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x71DAD30", Offset = "0x71D9330", VA = "0x1871DAD30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private LIIKICNCDGJ NPDGLEPLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x71DAEE0", Offset = "0x71D94E0", VA = "0x1871DAEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool IIJMHMHEHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x71DB300", Offset = "0x71D9900", VA = "0x1871DB300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event LDHKFCBONJG MAPLCBMMGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x71DB1C0", Offset = "0x71D97C0", VA = "0x1871DB1C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x71DB120", Offset = "0x71D9720", VA = "0x1871DB120", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x71DB5B0", Offset = "0x71D9BB0", VA = "0x1871DB5B0")]
	public NBIFKJKICNC(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x71DACA0", Offset = "0x71D92A0", VA = "0x1871DACA0", Slot = "6")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x71DAC90", Offset = "0x71D9290", VA = "0x1871DAC90", Slot = "8")]
	public void BJENNCIKLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x71DAB40", Offset = "0x71D9140", VA = "0x1871DAB40", Slot = "7")]
	public bool BEIIONGBDOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x71DB260", Offset = "0x71D9860", VA = "0x1871DB260", Slot = "9")]
	public void JGJAPHHHLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x71DB510", Offset = "0x71D9B10", VA = "0x1871DB510", Slot = "11")]
	public void OIPENABPJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x71DB360", Offset = "0x71D9960", VA = "0x1871DB360", Slot = "10")]
	public void OAOEGMONBJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x71DAF40", Offset = "0x71D9540", VA = "0x1871DAF40")]
	private bool HPHNMNPHJDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x71DAD50", Offset = "0x71D9350", VA = "0x1871DAD50")]
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
	private readonly GLGPGBPNFLE LIPKLOMBLDI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody KJODLCHDEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885640", VA = "0x180887040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool IIJMHMHEHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x71CA500", Offset = "0x71C8B00", VA = "0x1871CA500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool IBMBBGNFEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x109DC80", Offset = "0x109C280", VA = "0x18109DC80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x71CAA10", Offset = "0x71C9010", VA = "0x1871CAA10")]
	public BGHLGECHLGO(LIIKICNCDGJ IOHJIPHILJI, [In] OCGBPCDKBKC JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x71CA400", Offset = "0x71C8A00", VA = "0x1871CA400", Slot = "5")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x71CA4D0", Offset = "0x71C8AD0", VA = "0x1871CA4D0", Slot = "7")]
	public void IMDNBJHCJDN(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x71CA4A0", Offset = "0x71C8AA0", VA = "0x1871CA4A0", Slot = "8")]
	public void IFBCHBJDHFA(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x71CA560", Offset = "0x71C8B60", VA = "0x1871CA560", Slot = "9")]
	public void OEGGCLEMPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x71CA210", Offset = "0x71C8810", VA = "0x1871CA210", Slot = "10")]
	public void BCJMDHINOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x71CA890", Offset = "0x71C8E90", VA = "0x1871CA890", Slot = "11")]
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
	private readonly GLGPGBPNFLE FKCDFJKGJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private float GCAPGMEHLFJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public JAJDMPNLONJ BIEFJFNFNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x88B6B0", Offset = "0x889CB0", VA = "0x18088B6B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public BBKEJCDCLFA AOGHHFMNIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x88B6A0", Offset = "0x889CA0", VA = "0x18088B6A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 GJNHMHCKKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x71CD670", Offset = "0x71CBC70", VA = "0x1871CD670", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x71CD9B0", Offset = "0x71CBFB0", VA = "0x1871CD9B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 PFNOKEMFJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x71CABC0", Offset = "0x71C91C0", VA = "0x1871CABC0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x71CBAA0", Offset = "0x71CA0A0", VA = "0x1871CBAA0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 GAEJILGJFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x71CC950", Offset = "0x71CAF50", VA = "0x1871CC950", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x71CB390", Offset = "0x71C9990", VA = "0x1871CB390", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 DKKOHOIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x71CBFA0", Offset = "0x71CA5A0", VA = "0x1871CBFA0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x71CC310", Offset = "0x71CA910", VA = "0x1871CC310", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float OHPFGDDNLOG
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2D50", Offset = "0x9F1350", VA = "0x1809F2D50", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x71CACE0", Offset = "0x71C92E0", VA = "0x1871CACE0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool ENBMDKNMHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1A32F20", Offset = "0x1A31520", VA = "0x181A32F20", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private HEBLMGHFANA NKFHNKJOABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x69E74A0", Offset = "0x69E5AA0", VA = "0x1869E74A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool DJDPKKNHDEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x71CBAD0", Offset = "0x71CA0D0", VA = "0x1871CBAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x71CE1A0", Offset = "0x71CC7A0", VA = "0x1871CE1A0")]
	public CIFNHODCFPB(LIIKICNCDGJ IOHJIPHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x71CAE50", Offset = "0x71C9450", VA = "0x1871CAE50", Slot = "19")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x71CB2D0", Offset = "0x71C98D0", VA = "0x1871CB2D0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x71CAEF0", Offset = "0x71C94F0", VA = "0x1871CAEF0", Slot = "28")]
	public void CFCFDMGBDJO(Rigidbody OLNABEIJDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xECDB40", Offset = "0xECC140", VA = "0x180ECDB40", Slot = "20")]
	public void PFGJINBIANE(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xECF070", Offset = "0xECD670", VA = "0x180ECF070", Slot = "30")]
	public void LJJKJJAHIDI(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x71CD7D0", Offset = "0x71CBDD0", VA = "0x1871CD7D0", Slot = "35")]
	public Vector3 PBFBIDMAHAC(Vector3 FOEOPLOKPOB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x71CBB50", Offset = "0x71CA150", VA = "0x1871CBB50", Slot = "34")]
	public Vector3 IAPPHLOLCLB(Vector3 CALOMLJNHAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x71CAE50", Offset = "0x71C9450", VA = "0x1871CAE50", Slot = "27")]
	public void DLEEIKFFPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x71CB330", Offset = "0x71C9930", VA = "0x1871CB330", Slot = "25")]
	public void FNJCHAFGION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x71CADF0", Offset = "0x71C93F0", VA = "0x1871CADF0", Slot = "24")]
	public void BJBDPEAHGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x71CC0D0", Offset = "0x71CA6D0", VA = "0x1871CC0D0", Slot = "33")]
	public void IPGHPFLDEBA(Vector3 MEKMEJHIFMC, Vector3 KBNCPNDBCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x71CBAF0", Offset = "0x71CA0F0", VA = "0x1871CBAF0", Slot = "32")]
	public void IADKCNKPDLN(Vector3 AHEKOJPDIDP, Vector3 JKDCCBAFKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x71CB020", Offset = "0x71C9620", VA = "0x1871CB020", Slot = "31")]
	public void CODKDPLCDHD(Vector3 IEAGHIDJHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x71CB450", Offset = "0x71C9A50", VA = "0x1871CB450", Slot = "22")]
	public void HHIIHBGIEBI(DCOEIOEOLOO OGDHOAEFGEK, Vector3 ADCIKHMIKDC, float BFNABEBMGML, float EJJOPELHGIF = 8f, float ODMENHHKENK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x71CBD10", Offset = "0x71CA310", VA = "0x1871CBD10", Slot = "21")]
	public void IBGBKJDOGEF(HLIEOJLMCMD DLJHIKDDMED, Vector3 FDNLGBMHIMG, float LGADHHDBLPE = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x71CD0D0", Offset = "0x71CB6D0", VA = "0x1871CD0D0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void NICHPOJBKKJ(HLIEOJLMCMD DLJHIKDDMED, Vector3 JOLHFCINNMA, float LGCLKPGINJF = 7f, float GNAMHFMCPHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xFC9E10", Offset = "0xFC8410", VA = "0x180FC9E10")]
	private static void NMPPHFIMPLC(Vector3 DLPEMGFGHPD, Vector3 DBBPPLLNKOD, [Out] Vector3 FPCMBDNNCNI, [Out] Vector3 KEIFFIGICEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x71CC870", Offset = "0x71CAE70", VA = "0x1871CC870", Slot = "29")]
	public Vector3 KMAMKOPDPLJ(Vector3 DLPEMGFGHPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x71CE010", Offset = "0x71CC610", VA = "0x1871CE010", Slot = "26")]
	public void PMJJMHPJAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x71CACE0", Offset = "0x71C92E0", VA = "0x1871CACE0")]
	private void BEOJMBJBKOC(float KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x71CCAB0", Offset = "0x71CB0B0", VA = "0x1871CCAB0")]
	private void LKPKNBGDKKJ(Vector3 FDNLGBMHIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x71CB1C0", Offset = "0x71C97C0", VA = "0x1871CB1C0")]
	private Vector3 DGPGLFENLAB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x71CCC50", Offset = "0x71CB250", VA = "0x1871CCC50")]
	private void MLJCEMHBPDK(Vector3 CALOMLJNHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x71CD550", Offset = "0x71CBB50", VA = "0x1871CD550")]
	private Vector3 ODGKCHKOFEI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x71CC340", Offset = "0x71CA940", VA = "0x1871CC340")]
	private void JHHEOMOBBKL(Vector3 KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x71CDA70", Offset = "0x71CC070", VA = "0x1871CDA70")]
	private void PKKJCPNPCAJ(Vector3 CALOMLJNHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x71CC7C0", Offset = "0x71CADC0", VA = "0x1871CC7C0")]
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
