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
	public class LogRegistrationIndex : IFEEDCBNDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E92F10", Offset = "0x6E91710", VA = "0x186E92F10", Slot = "4")]
		public override void MPPLGFJBDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
	public class _AssemblyIndex : NDNGKAAFJBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private EOODGALFNHL bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x149A6C0", Offset = "0x1498EC0", VA = "0x18149A6C0", Slot = "5")]
		public override void NCCJLKGOOND(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E4E0", Offset = "0x6E9CCE0", VA = "0x186E9E4E0")]
		private void BFGJMJHNDBB(BHFHJLNFDOB registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E480", Offset = "0x6E9CC80", VA = "0x186E9E480", Slot = "6")]
		public override void ADLANINFHKN(BHFHJLNFDOB registry, [In] AHOCCHEAOIJ filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "8")]
		public override void BJELADPEBKG(LJEINPAGHKF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E7F0", Offset = "0x6E9CFF0", VA = "0x186E9E7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, DACPPDODOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly MMJHHDEPGMK HONBNKLJKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool KMOKHDNLPOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private BLIBIMCHNOD PIPIKCMFIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[NOCFGPDPMKL(EEKFPEEGEKF.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[NOCFGPDPMKL(EEKFPEEGEKF.SelfAndParent, true, false, false)]
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
		private AAOCMHJKPKO physicsInterpolation;

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
		internal BLIBIMCHNOD DNPOJKCODIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6E99110", Offset = "0x6E97910", VA = "0x186E99110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private BLIBIMCHNOD KMNDAEHMBMK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int CFJAMIEIIBB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6E9B8B0", Offset = "0x6E9A0B0", VA = "0x186E9B8B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx BDFFAPBPNMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6E9BC10", Offset = "0x6E9A410", VA = "0x186E9BC10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx BENFNHCGCFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6E9BB50", Offset = "0x6E9A350", VA = "0x186E9BB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx GGJNHHDMGON
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C8C0", Offset = "0x6E9B0C0", VA = "0x186E9C8C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6E9DDF0", Offset = "0x6E9C5F0", VA = "0x186E9DDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform DFFMNDEDAAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x86C0F0", Offset = "0x86A8F0", VA = "0x18086C0F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform GMOCABCHDAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x86C0F0", Offset = "0x86A8F0", VA = "0x18086C0F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public COGJEJCHONG CNNIDAAFDMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6E9B910", Offset = "0x6E9A110", VA = "0x186E9B910")]
			get
			{
				return default(COGJEJCHONG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D5A0", Offset = "0x6E9BDA0", VA = "0x186E9D5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OPKOGIKNNAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6E9BF20", Offset = "0x6E9A720", VA = "0x186E9BF20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool KJOHMFNDCMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6E9BA30", Offset = "0x6E9A230", VA = "0x186E9BA30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public FCAMINOCOJA MEKONANKKKP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6E9BE60", Offset = "0x6E9A660", VA = "0x186E9BE60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D760", Offset = "0x6E9BF60", VA = "0x186E9D760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public JILCCGMFDPF LAPJIFHJGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6E9BE00", Offset = "0x6E9A600", VA = "0x186E9BE00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D6F0", Offset = "0x6E9BEF0", VA = "0x186E9D6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool OMMLNEFLEBE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6E9BD50", Offset = "0x6E9A550", VA = "0x186E9BD50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody CBNKMMHNKGG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6E9BDB0", Offset = "0x6E9A5B0", VA = "0x186E9BDB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool AHPJGJHNNDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6E9BA90", Offset = "0x6E9A290", VA = "0x186E9BA90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D610", Offset = "0x6E9BE10", VA = "0x186E9D610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool BFHAEEABGGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x65B7000", Offset = "0x65B5800", VA = "0x1865B7000", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float ACAKKPHHCLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C860", Offset = "0x6E9B060", VA = "0x186E9C860")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float DEHBBBPFAIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C800", Offset = "0x6E9B000", VA = "0x186E9C800")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6E9DD80", Offset = "0x6E9C580", VA = "0x186E9DD80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float GFHAEHONOMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C180", Offset = "0x6E9A980", VA = "0x186E9C180")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6E9DA00", Offset = "0x6E9C200", VA = "0x186E9DA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float MCAKFMNMJOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6E9BF80", Offset = "0x6E9A780", VA = "0x186E9BF80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D7D0", Offset = "0x6E9BFD0", VA = "0x186E9D7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool OHLDOBBEIGN
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6E9CE40", Offset = "0x6E9B640", VA = "0x186E9CE40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6E9E330", Offset = "0x6E9CB30", VA = "0x186E9E330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 JFPPNNFHCDA
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C5E0", Offset = "0x6E9ADE0", VA = "0x186E9C5E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6E9DB50", Offset = "0x6E9C350", VA = "0x186E9DB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 GJNPKJKHPHH
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6E9CF80", Offset = "0x6E9B780", VA = "0x186E9CF80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode MPLFPFFNEFA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C0C0", Offset = "0x6E9A8C0", VA = "0x186E9C0C0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D920", Offset = "0x6E9C120", VA = "0x186E9D920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float IALJDEHLOFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6E9BAF0", Offset = "0x6E9A2F0", VA = "0x186E9BAF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D680", Offset = "0x6E9BE80", VA = "0x186E9D680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints AMILDFOPLDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C120", Offset = "0x6E9A920", VA = "0x186E9C120")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D990", Offset = "0x6E9C190", VA = "0x186E9D990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 MBIHAMCILCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C980", Offset = "0x6E9B180", VA = "0x186E9C980")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 BNIIFMNANLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C980", Offset = "0x6E9B180", VA = "0x186E9C980")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6E9E110", Offset = "0x6E9C910", VA = "0x186E9E110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float OJLHODMLAFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C6C0", Offset = "0x6E9AEC0", VA = "0x186E9C6C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6E9DC30", Offset = "0x6E9C430", VA = "0x186E9DC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float BLOAELOKEMO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6E9CDE0", Offset = "0x6E9B5E0", VA = "0x186E9CDE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6E9E2C0", Offset = "0x6E9CAC0", VA = "0x186E9E2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion MIDENHJGDPB
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6E9CA60", Offset = "0x6E9B260", VA = "0x186E9CA60")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6E9DE90", Offset = "0x6E9C690", VA = "0x186E9DE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion FNHJNAAKDJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6E9CD00", Offset = "0x6E9B500", VA = "0x186E9CD00")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6E9E1F0", Offset = "0x6E9C9F0", VA = "0x186E9E1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 KBKADMGPNOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6E9CB40", Offset = "0x6E9B340", VA = "0x186E9CB40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6E9DF60", Offset = "0x6E9C760", VA = "0x186E9DF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion NMHIPDALPNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6E9CC20", Offset = "0x6E9B420", VA = "0x186E9CC20")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6E9E040", Offset = "0x6E9C840", VA = "0x186E9E040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 BDPGEMOCEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6E9CEA0", Offset = "0x6E9B6A0", VA = "0x186E9CEA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6E9E3A0", Offset = "0x6E9CBA0", VA = "0x186E9E3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 JDJKHLHCBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C720", Offset = "0x6E9AF20", VA = "0x186E9C720")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6E9DCA0", Offset = "0x6E9C4A0", VA = "0x186E9DCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 HLMGJIDHMFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6E9BFE0", Offset = "0x6E9A7E0", VA = "0x186E9BFE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D840", Offset = "0x6E9C040", VA = "0x186E9D840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 MHHCOPPDPMM
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C500", Offset = "0x6E9AD00", VA = "0x186E9C500")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6E9DA70", Offset = "0x6E9C270", VA = "0x186E9DA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 JANBHHCNKIH
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C3C0", Offset = "0x6E9ABC0", VA = "0x186E9C3C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion DGGFILMBGPM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C2E0", Offset = "0x6E9AAE0", VA = "0x186E9C2E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 ENPHAHPFLCO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D140", Offset = "0x6E9B940", VA = "0x186E9D140")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 PMBHKLIDNLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D060", Offset = "0x6E9B860", VA = "0x186E9D060")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool DGIIKLNEKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C4A0", Offset = "0x6E9ACA0", VA = "0x186E9C4A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IHMAEHBDBEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6E9BEC0", Offset = "0x6E9A6C0", VA = "0x186E9BEC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool EIEBANADLEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6E9B9D0", Offset = "0x6E9A1D0", VA = "0x186E9B9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool IPNDPAFCMME
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6E9B970", Offset = "0x6E9A170", VA = "0x186E9B970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool PEINGDFJLEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6E9B850", Offset = "0x6E9A050", VA = "0x186E9B850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool CNMDFEHGAMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C1E0", Offset = "0x6E9A9E0", VA = "0x186E9C1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool ICIDCBOPNAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x59186B0", Offset = "0x5916EB0", VA = "0x1859186B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OIOCDFIICEJ AFFHLNMCHFG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6E9B770", Offset = "0x6E99F70", VA = "0x186E9B770")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D4C0", Offset = "0x6E9BCC0", VA = "0x186E9D4C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event JDCBCOFMANP KGHFDCJBICF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6E9B4E0", Offset = "0x6E99CE0", VA = "0x186E9B4E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D220", Offset = "0x6E9BA20", VA = "0x186E9D220")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event JDCBCOFMANP DNJPMAKDPMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6E9B540", Offset = "0x6E99D40", VA = "0x186E9B540")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D290", Offset = "0x6E9BA90", VA = "0x186E9D290")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event JDCBCOFMANP HCCJABEAMEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6E9B690", Offset = "0x6E99E90", VA = "0x186E9B690")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D3E0", Offset = "0x6E9BBE0", VA = "0x186E9D3E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<LPELNIAIFBH, LPELNIAIFBH> PFPGJFIOAJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6E9B620", Offset = "0x6E99E20", VA = "0x186E9B620")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D370", Offset = "0x6E9BB70", VA = "0x186E9D370")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event JDCBCOFMANP FACBMCMLCLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6E9B700", Offset = "0x6E99F00", VA = "0x186E9B700")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D450", Offset = "0x6E9BC50", VA = "0x186E9D450")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event JDCBCOFMANP BBLIEOKDMCC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6E9B7E0", Offset = "0x6E99FE0", VA = "0x186E9B7E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D530", Offset = "0x6E9BD30", VA = "0x186E9D530")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event JDCBCOFMANP DEPFNDDBBKG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6E9B5B0", Offset = "0x6E99DB0", VA = "0x186E9B5B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6E9D300", Offset = "0x6E9BB00", VA = "0x186E9D300")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x844F30", Offset = "0x843730", VA = "0x180844F30", Slot = "8")]
		private void LAJPHHNGNLP(BLIBIMCHNOD LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A5C0", Offset = "0x6E98DC0", VA = "0x186E9A5C0")]
		internal void PAJNJMILODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B210", Offset = "0x6E99A10", VA = "0x186E9B210")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody BAIDAAHJDBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E99D60", Offset = "0x6E98560", VA = "0x186E99D60")]
		public DACPPDODOBJ GetChild(int JBDLDJOINOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6E9AEE0", Offset = "0x6E996E0", VA = "0x186E9AEE0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) EJDPIICEIBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E99B10", Offset = "0x6E98310", VA = "0x186E99B10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6E99110", Offset = "0x6E97910", VA = "0x186E99110")]
		private BLIBIMCHNOD AEJKELLJECP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A230", Offset = "0x6E98A30", VA = "0x186E9A230")]
		private void LMDILLFIIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A6B0", Offset = "0x6E98EB0", VA = "0x186E9A6B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A5C0", Offset = "0x6E98DC0", VA = "0x186E9A5C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A650", Offset = "0x6E98E50", VA = "0x186E9A650")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A710", Offset = "0x6E98F10", VA = "0x186E9A710")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6E991C0", Offset = "0x6E979C0", VA = "0x186E991C0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object OECMOOGGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A770", Offset = "0x6E98F70", VA = "0x186E9A770")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object OECMOOGGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6E99D00", Offset = "0x6E98500", VA = "0x186E99D00")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A560", Offset = "0x6E98D60", VA = "0x186E9A560")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B040", Offset = "0x6E99840", VA = "0x186E9B040")]
		public void SetParent(RigidbodyEx IPHHABIKCHD, bool NEAOAKEDNKH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6E9AA80", Offset = "0x6E99280", VA = "0x186E9AA80")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A010", Offset = "0x6E98810", VA = "0x186E9A010")]
		public bool IsRigidbodyAncestor(RigidbodyEx DLFKEDHMFMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A0F0", Offset = "0x6E988F0", VA = "0x186E9A0F0")]
		public bool IsRigidbodyDescendant(RigidbodyEx CEJNLGONIBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6E99430", Offset = "0x6E97C30", VA = "0x186E99430")]
		public void AddInterpolationRestriction(object OECMOOGGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A7E0", Offset = "0x6E98FE0", VA = "0x186E9A7E0")]
		public void RemoveInterpolationRestriction(object OECMOOGGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6E994A0", Offset = "0x6E97CA0", VA = "0x186E994A0")]
		public void AddKinematic(object OECMOOGGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A850", Offset = "0x6E99050", VA = "0x186E9A850")]
		public void RemoveKinematic(object OECMOOGGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6E9AFC0", Offset = "0x6E997C0", VA = "0x186E9AFC0")]
		public void SetKinematic(object OECMOOGGOOF, bool KCOPEBDIOPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6E9ADE0", Offset = "0x6E995E0", VA = "0x186E9ADE0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 ELGCFIEOFEO, Quaternion DCKHBNEMBML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6E9ACE0", Offset = "0x6E994E0", VA = "0x186E9ACE0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 AEGPEJCEFDG, Quaternion LDPFGICFDIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6E99F00", Offset = "0x6E98700", VA = "0x186E99F00")]
		public Vector3 GetConstrainedVelocity(Vector3 BDPGEMOCEKF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6E99DF0", Offset = "0x6E985F0", VA = "0x186E99DF0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 HLMGJIDHMFL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6E99340", Offset = "0x6E97B40", VA = "0x186E99340")]
		public void AddForce(Vector3 AIDFLNGPPBP, ForceMode FAEAIBHJCJL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6E99230", Offset = "0x6E97A30", VA = "0x186E99230")]
		public void AddForceAtPosition(Vector3 AIDFLNGPPBP, Vector3 GBKEBGLIOFD, ForceMode FAEAIBHJCJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6E99670", Offset = "0x6E97E70", VA = "0x186E99670")]
		public void AddTorque(Vector3 MODELFPBHLJ, ForceMode FAEAIBHJCJL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6E99510", Offset = "0x6E97D10", VA = "0x186E99510")]
		public void AddRelativeTorque(Vector3 MODELFPBHLJ, ForceMode FAEAIBHJCJL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B2E0", Offset = "0x6E99AE0", VA = "0x186E9B2E0")]
		public Vector3 WorldToLocalVelocity(Vector3 FGJLCJLJNIH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A450", Offset = "0x6E98C50", VA = "0x186E9A450")]
		public Vector3 LocalToWorldVelocity(Vector3 JDJKHLHCBKJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6E99CA0", Offset = "0x6E984A0", VA = "0x186E99CA0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6E99C40", Offset = "0x6E98440", VA = "0x186E99C40")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E99BE0", Offset = "0x6E983E0", VA = "0x186E99BE0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6E99B80", Offset = "0x6E98380", VA = "0x186E99B80")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6E9ABE0", Offset = "0x6E993E0", VA = "0x186E9ABE0")]
		public void ResetVelocityWorldSpace(Vector3 CANJCDKNECM, Vector3 HGAJHDLFDOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6E9AAE0", Offset = "0x6E992E0", VA = "0x186E9AAE0")]
		public void ResetVelocityLocalSpace(Vector3 BBBBLJNFIIN, Vector3 MHHCOPPDPMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A9A0", Offset = "0x6E991A0", VA = "0x186E9A9A0")]
		public void ResetLinearVelocityLocalSpace(Vector3 BBBBLJNFIIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B170", Offset = "0x6E99970", VA = "0x186E9B170")]
		public bool SweepTest(Vector3 NHPNENOFEDP, [Out] RaycastHit ODIFANJGAKA, float NGOKPHBDKPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A1D0", Offset = "0x6E989D0", VA = "0x186E9A1D0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B110", Offset = "0x6E99910", VA = "0x186E9B110")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B280", Offset = "0x6E99A80", VA = "0x186E9B280")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6E99600", Offset = "0x6E97E00", VA = "0x186E99600")]
		public void AddShouldHaveUnityRigidbodyToken(object OECMOOGGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A8C0", Offset = "0x6E990C0", VA = "0x186E9A8C0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object OECMOOGGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6E999A0", Offset = "0x6E981A0", VA = "0x186E999A0")]
		public void ApplyForceVelocityChange(HHDEFPFLNPK IEKDAIGCGCD, Vector3 IGIFOANCFEK, float GMIEKGDCBNK, float FPFOKJKKFIH = 8f, float ICICHGCMKLL = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6E99900", Offset = "0x6E98100", VA = "0x186E99900")]
		public void ApplyAngularVelocityChange(DPAMEKGJPIB FGKFDJCPHID, Vector3 EJPFIPNBFHE, float JGAPKPCMPGB = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6E99A60", Offset = "0x6E98260", VA = "0x186E99A60")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(DPAMEKGJPIB FGKFDJCPHID, Vector3 LOMIHBHMPMH, float OODKBJMFLAN = 7f, float KLHDNNAMDKE = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6E99830", Offset = "0x6E98030", VA = "0x186E99830")]
		public bool AllowedScaleChange(float FMCCCFIPNDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6E99760", Offset = "0x6E97F60", VA = "0x186E99760")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx FHOCPFNFMCA, object OECMOOGGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A930", Offset = "0x6E99130", VA = "0x186E9A930")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object OECMOOGGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B470", Offset = "0x6E99C70", VA = "0x186E9B470")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x90B1C0", Offset = "0x9099C0", VA = "0x18090B1C0", Slot = "4")]
		private GameObject NDIEIDNBFBL()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x86C0F0", Offset = "0x86A8F0", VA = "0x18086C0F0", Slot = "5")]
		private Transform DNNOCODJAFD()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class PCAMHIFMKKH
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6E96DE0", Offset = "0x6E955E0", VA = "0x186E96DE0")]
	public static BLIBIMCHNOD DNPOJKCODIO(this RigidbodyEx IBBECBMNJMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LBIGLGLDDJL(typeof(BDAOOANIINJ), new string[] { })]
public class OPOFHDCNIGH : BDAOOANIINJ, NNMHDEKAJII
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private JFNMNHAAKGD CDAFJEIOFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private EHIFOPDKKBJ NALLEMLECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private LLPOOBOPOCM CJELABLKNAB;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public EHIFOPDKKBJ BHIHJNCNCDD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public LLPOOBOPOCM GIOINJOABCB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6E96CD0", Offset = "0x6E954D0", VA = "0x186E96CD0", Slot = "7")]
	public void InitReferences(CDDEGKNDPAN FOBEFOGAKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6E96C40", Offset = "0x6E95440", VA = "0x186E96C40", Slot = "6")]
	public BLIBIMCHNOD INHDBDFOAPE(RigidbodyEx IBBECBMNJMD, IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public OPOFHDCNIGH()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static LFHDLKLNBFG UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int KKJOOJOJBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int JGDBBJCLDEO;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6E98F90", Offset = "0x6E97790", VA = "0x186E98F90")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E98FD0", Offset = "0x6E977D0", VA = "0x186E98FD0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E98FB0", Offset = "0x6E977B0", VA = "0x186E98FB0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string CLBGCJICGJG, [Optional] UnityEngine.Object BHFMOMNKABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string CLBGCJICGJG, [Optional] UnityEngine.Object BHFMOMNKABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E990C0", Offset = "0x6E978C0", VA = "0x186E990C0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OIEHIECNPKN
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class AFDKAMEDCNB : FCAMINOCOJA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x852D10", Offset = "0x851510", VA = "0x180852D10", Slot = "4")]
		public Vector3 IEMPFFKFJDF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x852D10", Offset = "0x851510", VA = "0x180852D10", Slot = "5")]
		public Vector3 ABDLIHIONAE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public AFDKAMEDCNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static FCAMINOCOJA DELFPNMJFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6E96AB0", Offset = "0x6E952B0", VA = "0x186E96AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CNEOMOHKMKE
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode DECMOOCMCIC
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
	void JGNDLDOBBPO();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EJHBMFGOGKF(bool DGIIKLNEKFE);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ANNBIHHDOJO(bool DGIIKLNEKFE);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GJHIAAEHEJJ(Rigidbody BBEDNPEOIIM);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CKPKMOKPEAD(Vector3 NHPNENOFEDP, [Out] RaycastHit ODIFANJGAKA, float NGOKPHBDKPG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GIEEMCPLHAL : IDisposable, IEEDHJFAECG
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	COGJEJCHONG CNNIDAAFDMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<LPELNIAIFBH, LPELNIAIFBH> PFPGJFIOAJB;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGNDLDOBBPO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface LLPOOBOPOCM
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DJKJHBDDJNC LMHFHCFCBAG(BLIBIMCHNOD LHMMDMHNIJC);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BPIMIPOECAF KOCPOPLJHKO(BLIBIMCHNOD LHMMDMHNIJC);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LHFKCOAKAFP LLPJFBCPKCN(BLIBIMCHNOD LHMMDMHNIJC);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CIEGLAHOOIK FJNIKFPHEMM(BLIBIMCHNOD LHMMDMHNIJC);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BMCEHGACILG JPILLAGIKEC(BLIBIMCHNOD LHMMDMHNIJC);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GIEEMCPLHAL APBBLIOCMAI(BLIBIMCHNOD LHMMDMHNIJC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PFDPEDGHBLL OEPLLAKEFOC(BLIBIMCHNOD LHMMDMHNIJC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JOMIKNKHKIK HDDOHJFIGCH(BLIBIMCHNOD LHMMDMHNIJC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CNEOMOHKMKE LHPJEPELMAJ(BLIBIMCHNOD LHMMDMHNIJC);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EMAGCCOLODN AHEKMFDJLAN(BLIBIMCHNOD LHMMDMHNIJC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HEIEIIECEIH DKJGCIABGEM(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PFOFEJPPCEK HNDCPKAJAKJ(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NGFEMPEEJHM FMFCADLAEPH(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FBKLACCKALP EMHHMPHJNGJ(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PNOEALDCJLD FLHJGJPAKDG(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BLIBIMCHNOD INHDBDFOAPE(RigidbodyEx IBBECBMNJMD, IFFGFEPPNHH MLKNGAFFKGE, BDAOOANIINJ KOFDOJONBID);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JOMIKNKHKIK
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMGLNCEALOI(Vector3 AIDFLNGPPBP, ForceMode FAEAIBHJCJL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCCHCEKONBH(Vector3 AIDFLNGPPBP, Vector3 GBKEBGLIOFD, ForceMode FAEAIBHJCJL);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JFGEJOBBMAO(Vector3 MODELFPBHLJ, ForceMode FAEAIBHJCJL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KFBMLPCOLML(Vector3 MODELFPBHLJ, ForceMode FAEAIBHJCJL = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EMAGCCOLODN
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool GJJJAFNFPEE
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
	void GJHIAAEHEJJ(Rigidbody BBEDNPEOIIM);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGNBBJJGDMJ(Rigidbody BBEDNPEOIIM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DJKJHBDDJNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<BLIBIMCHNOD> CNJBJPJMJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	BLIBIMCHNOD BENFNHCGCFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	BLIBIMCHNOD GFHKLHCNBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event JDCBCOFMANP KGHFDCJBICF;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event JDCBCOFMANP DNJPMAKDPMO;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event OIOCDFIICEJ KCMDBECEJLM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action JBJOBNEFGIN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action HPDLLFCBHDM;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<BLIBIMCHNOD> JKCMJAHCHBC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<BLIBIMCHNOD> INHKILDONGC;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action LIMNEOMCPKF;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<BLIBIMCHNOD> BEGGEFKJFMO;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BFFDCAOPJND(BLIBIMCHNOD OGAPKPCGEHM, bool NEAOAKEDNKH = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LHFKCOAKAFP
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 EFINPOPLKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 IAHMJIMOAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBFOHBMNHPH(BLIBIMCHNOD GGJNHHDMGON, object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OAIIBHEAFFE(object OECMOOGGOOF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FBKLACCKALP
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 MJMHHNPDCGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 BJAEOLLMDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float NOIFPIGGDBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float BHAGJPJDMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 LCEENPPGPDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion CPJKDPJHJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event JDCBCOFMANP MNNHDMKDMMI;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JBEJPGIKMFB((Quaternion rot, Vector3 moments) EJDPIICEIBJ);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BCJNOAFHLBA();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ICLCACMFEHF();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AKKFJHEEDKA();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GJHIAAEHEJJ(Rigidbody BBEDNPEOIIM);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FGNBBJJGDMJ(Rigidbody BBEDNPEOIIM);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ODFKKDADEDP();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NGFEMPEEJHM
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGNDLDOBBPO();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDCPAJFJMOG(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPIBMKADDKA(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PBCMMDONLLN(BLIBIMCHNOD IBBECBMNJMD);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBAFJCFPAPK(BLIBIMCHNOD IBBECBMNJMD);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GPCCEBKLCMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PFDPEDGHBLL
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool CLMLPLJBEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event JDCBCOFMANP IDNGIOKNFLN;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIMJFPFEPLD(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADCENDCGKGM(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OBJFMIGLMGM(object OECMOOGGOOF, bool KCOPEBDIOPC);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GJHIAAEHEJJ(Rigidbody EBBDKHLIBPM);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FGNBBJJGDMJ(Rigidbody BBEDNPEOIIM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PFOFEJPPCEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool OPKOGIKNNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool KJOHMFNDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event JDCBCOFMANP GAHOJLCEMPA;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGNDLDOBBPO();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKBOOGFNOML(BLIBIMCHNOD GGJNHHDMGON);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PNCEIDMPLDF(BLIBIMCHNOD GGJNHHDMGON);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PNOEALDCJLD
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool AHPJGJHNNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool GEAEJCNEFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints MBGDFDDGMKN
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
	void GJHIAAEHEJJ(Rigidbody BBEDNPEOIIM);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FGNBBJJGDMJ(Rigidbody BBEDNPEOIIM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CIEGLAHOOIK
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float FLCCBCFCFAC
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float LHMGKIPGNDI
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
	void GJHIAAEHEJJ(Rigidbody BBEDNPEOIIM);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGNBBJJGDMJ(Rigidbody BBEDNPEOIIM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BMCEHGACILG
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event JDCBCOFMANP JFDIAIEIKDI;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGNDLDOBBPO();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NDMHBGEBIJP();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJCAEHOLKCB();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KOFDMENNLIJ();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JEMBLOPFNLJ();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ACGLIAEOOFN();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HEIEIIECEIH
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody CBNKMMHNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool LMANJLJNKHB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGNDLDOBBPO();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OOMOLILEKIP(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LNGMHNFFFAF(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AMLGMDCJBID();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KEHFGNOLCIH();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BPIMIPOECAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	FCAMINOCOJA MEKONANKKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	JILCCGMFDPF LAPJIFHJGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 IHOIHNGCNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 HODGLLMGNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 AFOCIAPHPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 JKGLJJAHGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float IALJDEHLOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool OMMLNEFLEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JGNDLDOBBPO();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OAEIHNOBKCD(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BNGNNEOHKDB(DPAMEKGJPIB FGKFDJCPHID, Vector3 EJPFIPNBFHE, float JGAPKPCMPGB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GEKDDCOAMGG(HHDEFPFLNPK IEKDAIGCGCD, Vector3 IGIFOANCFEK, float GMIEKGDCBNK, float FPFOKJKKFIH = 8f, float ICICHGCMKLL = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HNJOBGDEAPL(DPAMEKGJPIB FGKFDJCPHID, Vector3 LOMIHBHMPMH, float OODKBJMFLAN = 7f, float KLHDNNAMDKE = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HILPLCDGDCA();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PFAHOCILJJD();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GFMKFDINHOF();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KOHJLEDPKOC();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GJHIAAEHEJJ(Rigidbody BBEDNPEOIIM);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 HCENJEONKBP(Vector3 BDPGEMOCEKF);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void AHIFMAEEEJI(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HKNCONIMPPD(Vector3 KCCHHOLMGED);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JBIFLKBLOIG(Vector3 BBBBLJNFIIN, Vector3 MHHCOPPDPMM);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FCDJKPADNPE(Vector3 CANJCDKNECM, Vector3 HGAJHDLFDOD);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 IEAGFGBBACO(Vector3 JDJKHLHCBKJ);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 OAMALPNFMIN(Vector3 FGJLCJLJNIH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface EHIFOPDKKBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool KHKMBFHOCHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPIGLHMPFBC(string EBFMCGAMIGF);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMJDDAJKBHP(RigidbodyEx IBBECBMNJMD, Action BMOCGPMNBAF);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OHGALMMLAOE KMLHCBCKKFJ(int AENOMCNMMMD);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BBCOPOANMKI(Vector3 GJNPKJKHPHH, float NGGPBGOKJHH, Color NLKAPPNAHLI);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AGAEDPEPBMC();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JNHFBPJHLNC();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface BDAOOANIINJ
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	EHIFOPDKKBJ BHIHJNCNCDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	LLPOOBOPOCM GIOINJOABCB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BLIBIMCHNOD INHDBDFOAPE(RigidbodyEx IBBECBMNJMD, IFFGFEPPNHH MLKNGAFFKGE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BDJHPKIGIFJ : BLIBIMCHNOD, IDisposable, ANHOOAAKBHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly BDAOOANIINJ KOFDOJONBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal DJKJHBDDJNC GPGBLFPGCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal NGFEMPEEJHM MKKODKEIDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal PFOFEJPPCEK MFEBACJMNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal BPIMIPOECAF BDPGEMOCEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal LHFKCOAKAFP AANKMCDLJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal FBKLACCKALP JBGEJMKPMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal CIEGLAHOOIK LMMJEPDALAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal EMAGCCOLODN DJMAOCCLGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal BMCEHGACILG NBOACEEKEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal GIEEMCPLHAL MCKJANLEMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal PFDPEDGHBLL OAKCOBDDFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal JOMIKNKHKIK AIDFLNGPPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal PNOEALDCJLD ELNHOCMDOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal HEIEIIECEIH BBEDNPEOIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal CNEOMOHKMKE EGBBFMLAIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable AFJGNNLIAGP;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "22")]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public DACPPDODOBJ EAGOIIFAHOA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8513F0", Offset = "0x84FBF0", VA = "0x1808513F0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x851340", Offset = "0x84FB40", VA = "0x180851340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject ADPKHONGLGK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x991990", Offset = "0x990190", VA = "0x180991990", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x991AB0", Offset = "0x9902B0", VA = "0x180991AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform BNMINHJAICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6E87110", Offset = "0x6E85910", VA = "0x186E87110", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody CBNKMMHNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6E88060", Offset = "0x6E86860", VA = "0x186E88060", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public BLIBIMCHNOD GFHKLHCNBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6E87540", Offset = "0x6E85D40", VA = "0x186E87540", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6E87E50", Offset = "0x6E86650", VA = "0x186E87E50", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int CFJAMIEIIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6E82EE0", Offset = "0x6E816E0", VA = "0x186E82EE0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public BLIBIMCHNOD BENFNHCGCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6E85A10", Offset = "0x6E84210", VA = "0x186E85A10", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool PFCCDAMMLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6E83940", Offset = "0x6E82140", VA = "0x186E83940", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool OPKOGIKNNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6E85B10", Offset = "0x6E84310", VA = "0x186E85B10", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool KJOHMFNDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6E864D0", Offset = "0x6E84CD0", VA = "0x186E864D0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public FCAMINOCOJA MEKONANKKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6E830E0", Offset = "0x6E818E0", VA = "0x186E830E0", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6E87480", Offset = "0x6E85C80", VA = "0x186E87480", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public JILCCGMFDPF LAPJIFHJGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6E83380", Offset = "0x6E81B80", VA = "0x186E83380", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6E83E80", Offset = "0x6E82680", VA = "0x186E83E80", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float IALJDEHLOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6E87060", Offset = "0x6E85860", VA = "0x186E87060", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6E86520", Offset = "0x6E84D20", VA = "0x186E86520", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 HODGLLMGNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6E845E0", Offset = "0x6E82DE0", VA = "0x186E845E0", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6E82F50", Offset = "0x6E81750", VA = "0x186E82F50", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 JKGLJJAHGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6E83670", Offset = "0x6E81E70", VA = "0x186E83670", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6E854C0", Offset = "0x6E83CC0", VA = "0x186E854C0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 IHOIHNGCNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6E87200", Offset = "0x6E85A00", VA = "0x186E87200", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6E84200", Offset = "0x6E82A00", VA = "0x186E84200", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 AFOCIAPHPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6E86A30", Offset = "0x6E85230", VA = "0x186E86A30", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6E880B0", Offset = "0x6E868B0", VA = "0x186E880B0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool EIEBANADLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6E83EE0", Offset = "0x6E826E0", VA = "0x186E83EE0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool IPNDPAFCMME
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6E870B0", Offset = "0x6E858B0", VA = "0x186E870B0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool PEINGDFJLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6E88340", Offset = "0x6E86B40", VA = "0x186E88340", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool OMMLNEFLEBE
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6E83330", Offset = "0x6E81B30", VA = "0x186E83330", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 EFINPOPLKCK
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6E855F0", Offset = "0x6E83DF0", VA = "0x186E855F0", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 IAHMJIMOAJH
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6E876A0", Offset = "0x6E85EA0", VA = "0x186E876A0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 MJMHHNPDCGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E829D0", Offset = "0x6E811D0", VA = "0x186E829D0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6E843B0", Offset = "0x6E82BB0", VA = "0x186E843B0", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 BJAEOLLMDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E885F0", Offset = "0x6E86DF0", VA = "0x186E885F0", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float NOIFPIGGDBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E88420", Offset = "0x6E86C20", VA = "0x186E88420", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float BHAGJPJDMML
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E87FB0", Offset = "0x6E867B0", VA = "0x186E87FB0", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6E83F30", Offset = "0x6E82730", VA = "0x186E83F30", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 LCEENPPGPDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E831F0", Offset = "0x6E819F0", VA = "0x186E831F0", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion CPJKDPJHJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E85B60", Offset = "0x6E84360", VA = "0x186E85B60", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float FLCCBCFCFAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6E839A0", Offset = "0x6E821A0", VA = "0x186E839A0", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E86BF0", Offset = "0x6E853F0", VA = "0x186E86BF0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float LHMGKIPGNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E885A0", Offset = "0x6E86DA0", VA = "0x186E885A0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6E87DF0", Offset = "0x6E865F0", VA = "0x186E87DF0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool GJJJAFNFPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6E85190", Offset = "0x6E83990", VA = "0x186E85190", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E84350", Offset = "0x6E82B50", VA = "0x186E84350", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public COGJEJCHONG CNNIDAAFDMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6E853C0", Offset = "0x6E83BC0", VA = "0x186E853C0", Slot = "68")]
		get
		{
			return default(COGJEJCHONG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6E87AB0", Offset = "0x6E862B0", VA = "0x186E87AB0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool CLMLPLJBEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6E869E0", Offset = "0x6E851E0", VA = "0x186E869E0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform GMOCABCHDAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6E85180", Offset = "0x6E83980", VA = "0x186E85180", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 FMHDCFKEJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6E87590", Offset = "0x6E85D90", VA = "0x186E87590", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E87890", Offset = "0x6E86090", VA = "0x186E87890", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float OAINCPHPOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6E884D0", Offset = "0x6E86CD0", VA = "0x186E884D0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6E85110", Offset = "0x6E83910", VA = "0x186E85110", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float LCJAICMGMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6E83750", Offset = "0x6E81F50", VA = "0x186E83750", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6E87EB0", Offset = "0x6E866B0", VA = "0x186E87EB0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion FIIADFGBHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6E84150", Offset = "0x6E82950", VA = "0x186E84150", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6E834E0", Offset = "0x6E81CE0", VA = "0x186E834E0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 NPNMPABLGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E87A00", Offset = "0x6E86200", VA = "0x186E87A00", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6E87010", Offset = "0x6E85810", VA = "0x186E87010", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion NIILCMPNFAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E84810", Offset = "0x6E83010", VA = "0x186E84810", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6E859D0", Offset = "0x6E841D0", VA = "0x186E859D0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints MBGDFDDGMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6E849D0", Offset = "0x6E831D0", VA = "0x186E849D0", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6E84090", Offset = "0x6E82890", VA = "0x186E84090", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool AHPJGJHNNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E86FC0", Offset = "0x6E857C0", VA = "0x186E86FC0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6E832D0", Offset = "0x6E81AD0", VA = "0x186E832D0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode DECMOOCMCIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6E87BC0", Offset = "0x6E863C0", VA = "0x186E87BC0", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6E85050", Offset = "0x6E83850", VA = "0x186E85050", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool AAHEEMLHNGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E87340", Offset = "0x6E85B40", VA = "0x186E87340", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool IHMAEHBDBEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E84850", Offset = "0x6E83050", VA = "0x186E84850", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event JDCBCOFMANP KGHFDCJBICF
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6E847B0", Offset = "0x6E82FB0", VA = "0x186E847B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6E88540", Offset = "0x6E86D40", VA = "0x186E88540", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event JDCBCOFMANP DNJPMAKDPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6E82B10", Offset = "0x6E81310", VA = "0x186E82B10", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6E871A0", Offset = "0x6E859A0", VA = "0x186E871A0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event OIOCDFIICEJ KCMDBECEJLM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6E85800", Offset = "0x6E84000", VA = "0x186E85800", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6E87A50", Offset = "0x6E86250", VA = "0x186E87A50", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event JDCBCOFMANP GAHOJLCEMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6E856C0", Offset = "0x6E83EC0", VA = "0x186E856C0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6E86F10", Offset = "0x6E85710", VA = "0x186E86F10", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event JDCBCOFMANP HCCJABEAMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E82AB0", Offset = "0x6E812B0", VA = "0x186E82AB0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E86CB0", Offset = "0x6E854B0", VA = "0x186E86CB0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event JDCBCOFMANP JFDIAIEIKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E88000", Offset = "0x6E86800", VA = "0x186E88000", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E840F0", Offset = "0x6E828F0", VA = "0x186E840F0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<LPELNIAIFBH, LPELNIAIFBH> PFPGJFIOAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E88730", Offset = "0x6E86F30", VA = "0x186E88730", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E867A0", Offset = "0x6E84FA0", VA = "0x186E867A0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event JDCBCOFMANP IDNGIOKNFLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6E850B0", Offset = "0x6E838B0", VA = "0x186E850B0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6E86C50", Offset = "0x6E85450", VA = "0x186E86C50", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event JDCBCOFMANP DEPFNDDBBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6E84B20", Offset = "0x6E83320", VA = "0x186E84B20", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E85410", Offset = "0x6E83C10", VA = "0x186E85410", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6E88900", Offset = "0x6E87100", VA = "0x186E88900")]
	public BDJHPKIGIFJ(GameObject DLBGNHFNDNP, RigidbodyEx DNDKHKAGAMM, BDAOOANIINJ KOFDOJONBID, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6E85E90", Offset = "0x6E84690", VA = "0x186E85E90", Slot = "136")]
	protected virtual void IIJJEKPFJHC(BDAOOANIINJ KOFDOJONBID, IFFGFEPPNHH MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6E83DB0", Offset = "0x6E825B0", VA = "0x186E83DB0", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6E86660", Offset = "0x6E84E60", VA = "0x186E86660", Slot = "91")]
	public void JGNDLDOBBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6E85E40", Offset = "0x6E84640", VA = "0x186E85E40", Slot = "92")]
	public void IFABOCHGFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6E87C10", Offset = "0x6E86410", VA = "0x186E87C10", Slot = "93")]
	public void NMEBMIBGGOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6E87B10", Offset = "0x6E86310", VA = "0x186E87B10")]
	private void NJNAEBHHHEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6E852E0", Offset = "0x6E83AE0", VA = "0x186E852E0", Slot = "30")]
	public BLIBIMCHNOD HDBMOBPFKBC(int JBDLDJOINOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6E83180", Offset = "0x6E81980", VA = "0x186E83180", Slot = "95")]
	public void BFFDCAOPJND(BLIBIMCHNOD IPHHABIKCHD, bool NEAOAKEDNKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6E87950", Offset = "0x6E86150", VA = "0x186E87950", Slot = "96")]
	public void NDCGKMFHAIL(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6E874E0", Offset = "0x6E85CE0", VA = "0x186E874E0", Slot = "97")]
	public void MBPCNLEIAFL(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6E87C30", Offset = "0x6E86430", VA = "0x186E87C30", Slot = "98")]
	public Vector3 OAMALPNFMIN(Vector3 FGJLCJLJNIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6E85D40", Offset = "0x6E84540", VA = "0x186E85D40", Slot = "99")]
	public Vector3 IEAGFGBBACO(Vector3 JDJKHLHCBKJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6E85E40", Offset = "0x6E84640", VA = "0x186E85E40", Slot = "100")]
	public void KOHJLEDPKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6E884F0", Offset = "0x6E86CF0", VA = "0x186E884F0", Slot = "101")]
	public void PFAHOCILJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6E855A0", Offset = "0x6E83DA0", VA = "0x186E855A0", Slot = "102")]
	public void HILPLCDGDCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6E846C0", Offset = "0x6E82EC0", VA = "0x186E846C0", Slot = "103")]
	public void FCDJKPADNPE(Vector3 CANJCDKNECM, Vector3 HGAJHDLFDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6E863E0", Offset = "0x6E84BE0", VA = "0x186E863E0", Slot = "104")]
	public void JBIFLKBLOIG(Vector3 BBBBLJNFIIN, Vector3 MHHCOPPDPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6E85720", Offset = "0x6E83F20", VA = "0x186E85720", Slot = "105")]
	public void HKNCONIMPPD(Vector3 KCCHHOLMGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6E84F40", Offset = "0x6E83740", VA = "0x186E84F40", Slot = "106")]
	public void GEKDDCOAMGG(HHDEFPFLNPK IEKDAIGCGCD, Vector3 IGIFOANCFEK, float GMIEKGDCBNK, float FPFOKJKKFIH = 8f, float ICICHGCMKLL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6E835D0", Offset = "0x6E81DD0", VA = "0x186E835D0", Slot = "107")]
	public void BNGNNEOHKDB(DPAMEKGJPIB FGKFDJCPHID, Vector3 EJPFIPNBFHE, float JGAPKPCMPGB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6E85A60", Offset = "0x6E84260", VA = "0x186E85A60", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HNJOBGDEAPL(DPAMEKGJPIB FGKFDJCPHID, Vector3 LOMIHBHMPMH, float OODKBJMFLAN = 7f, float KLHDNNAMDKE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6E851E0", Offset = "0x6E839E0", VA = "0x186E851E0", Slot = "109")]
	public Vector3 HCENJEONKBP(Vector3 IPHHABIKCHD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6E83F90", Offset = "0x6E82790", VA = "0x186E83F90", Slot = "110")]
	public Vector3 EELPKIMHCHN(Vector3 IPHHABIKCHD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6E85000", Offset = "0x6E83800", VA = "0x186E85000", Slot = "111")]
	public void GFMKFDINHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6E842E0", Offset = "0x6E82AE0", VA = "0x186E842E0", Slot = "112")]
	public void EMKIINPCIPB(BLIBIMCHNOD FHOCPFNFMCA, object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6E886D0", Offset = "0x6E86ED0", VA = "0x186E886D0", Slot = "113")]
	public void PKDKAGJMDCM(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E86300", Offset = "0x6E84B00", VA = "0x186E86300", Slot = "61")]
	public void JBEJPGIKMFB((Quaternion rot, Vector3 moments) EJDPIICEIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E85C30", Offset = "0x6E84430", VA = "0x186E85C30", Slot = "114")]
	public void ICLCACMFEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E83130", Offset = "0x6E81930", VA = "0x186E83130", Slot = "115")]
	public void BCJNOAFHLBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E82B70", Offset = "0x6E81370", VA = "0x186E82B70", Slot = "116")]
	public void AKKFJHEEDKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6E879B0", Offset = "0x6E861B0", VA = "0x186E879B0", Slot = "117")]
	public bool NDMHBGEBIJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6E86F70", Offset = "0x6E85770", VA = "0x186E86F70", Slot = "94")]
	public void KOFDMENNLIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6E82920", Offset = "0x6E81120", VA = "0x186E82920", Slot = "118")]
	public void ACGLIAEOOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6E87640", Offset = "0x6E85E40", VA = "0x186E87640", Slot = "119")]
	public void MIMJFPFEPLD(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6E82970", Offset = "0x6E81170", VA = "0x186E82970", Slot = "120")]
	public void ADCENDCGKGM(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6E87D30", Offset = "0x6E86530", VA = "0x186E87D30", Slot = "121")]
	public void OBJFMIGLMGM(object OECMOOGGOOF, bool KCOPEBDIOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6E86D10", Offset = "0x6E85510", VA = "0x186E86D10", Slot = "122")]
	public void KNDFCAFEKMF(Vector3 ELGCFIEOFEO, Quaternion DCKHBNEMBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6E84490", Offset = "0x6E82C90", VA = "0x186E84490", Slot = "123")]
	public void FAJOOGIGOCH(Vector3 AEGPEJCEFDG, Quaternion LDPFGICFDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6E83810", Offset = "0x6E82010", VA = "0x186E83810", Slot = "124")]
	public bool CNDLDOGPJGP(float FMCCCFIPNDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6E88790", Offset = "0x6E86F90", VA = "0x186E88790", Slot = "125")]
	public void PKOLJANMAKF(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6E85360", Offset = "0x6E83B60", VA = "0x186E85360", Slot = "126")]
	public void HDFPLJMCNJE(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6E88470", Offset = "0x6E86C70", VA = "0x186E88470", Slot = "127")]
	public void OOMOLILEKIP(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6E872E0", Offset = "0x6E85AE0", VA = "0x186E872E0", Slot = "128")]
	public void LNGMHNFFFAF(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6E88260", Offset = "0x6E86A60", VA = "0x186E88260", Slot = "129")]
	public void OMGLNCEALOI(Vector3 AIDFLNGPPBP, ForceMode FAEAIBHJCJL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6E87780", Offset = "0x6E85F80", VA = "0x186E87780", Slot = "130")]
	public void NCCHCEKONBH(Vector3 AIDFLNGPPBP, Vector3 GBKEBGLIOFD, ForceMode FAEAIBHJCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6E86580", Offset = "0x6E84D80", VA = "0x186E86580", Slot = "131")]
	public void JFGEJOBBMAO(Vector3 MODELFPBHLJ, ForceMode FAEAIBHJCJL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6E86B10", Offset = "0x6E85310", VA = "0x186E86B10", Slot = "132")]
	public void KFBMLPCOLML(Vector3 MODELFPBHLJ, ForceMode FAEAIBHJCJL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6E83770", Offset = "0x6E81F70", VA = "0x186E83770", Slot = "133")]
	public bool CKPKMOKPEAD(Vector3 NHPNENOFEDP, [Out] RaycastHit ODIFANJGAKA, float NGOKPHBDKPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6E87DA0", Offset = "0x6E865A0", VA = "0x186E87DA0", Slot = "134")]
	public void ODFKKDADEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6E888C0", Offset = "0x6E870C0", VA = "0x186E888C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6E83870", Offset = "0x6E82070", VA = "0x186E83870")]
	private void CPCHGHENLEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6E833D0", Offset = "0x6E81BD0", VA = "0x186E833D0")]
	private void BLJOEOCBPML(BLIBIMCHNOD GGJNHHDMGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6E86800", Offset = "0x6E85000", VA = "0x186E86800")]
	private void JNMOIAJNEBL(BLIBIMCHNOD GGJNHHDMGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6E83030", Offset = "0x6E81830", VA = "0x186E83030")]
	private void AONGBPICDCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6E84A20", Offset = "0x6E83220", VA = "0x186E84A20")]
	private void FNCKPGGFBKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6E86180", Offset = "0x6E84980", VA = "0x186E86180")]
	private void IPHJGAMEBMO(BLIBIMCHNOD OFNOGOAIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6E88190", Offset = "0x6E86990", VA = "0x186E88190")]
	private void OKBOOGFNOML(BLIBIMCHNOD GGJNHHDMGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6E887F0", Offset = "0x6E86FF0", VA = "0x186E887F0")]
	private void PNCEIDMPLDF(BLIBIMCHNOD GGJNHHDMGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6E85860", Offset = "0x6E84060", VA = "0x186E85860")]
	private void HLOKFGKLLAG(DACPPDODOBJ GGJNHHDMGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6E839F0", Offset = "0x6E821F0", VA = "0x186E839F0", Slot = "141")]
	protected virtual void DPDAOMAJNFB(DACPPDODOBJ IBBECBMNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6E82BC0", Offset = "0x6E813C0", VA = "0x186E82BC0")]
	protected void ALPIJFKAACF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6E84BD0", Offset = "0x6E833D0", VA = "0x186E84BD0")]
	protected void GAIKJMNICBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6E85C80", Offset = "0x6E84480", VA = "0x186E85C80", Slot = "142")]
	protected virtual IDisposable IDJAEFNMNBB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class MFNDDNOGBNC
{
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E930A0", Offset = "0x6E918A0", VA = "0x186E930A0")]
	public static BLIBIMCHNOD CAJEHEKFLIH(this BLIBIMCHNOD IBBECBMNJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6E93230", Offset = "0x6E91A30", VA = "0x186E93230")]
	public static bool NLMIMAMMNEG(this BLIBIMCHNOD IBBECBMNJMD, BLIBIMCHNOD DLFKEDHMFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6E931B0", Offset = "0x6E919B0", VA = "0x186E931B0")]
	public static bool NHPNDIGOOIE(this BLIBIMCHNOD IBBECBMNJMD, BLIBIMCHNOD CEJNLGONIBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6E93160", Offset = "0x6E91960", VA = "0x186E93160")]
	public static DACPPDODOBJ LLDOHGKLPIO(this BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6E932B0", Offset = "0x6E91AB0", VA = "0x186E932B0")]
	public static BDJHPKIGIFJ PPFFFGMAFCI(this BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IKBHHCEMDOD : LLPOOBOPOCM
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6E91920", Offset = "0x6E90120", VA = "0x186E91920", Slot = "19")]
	public BLIBIMCHNOD INHDBDFOAPE(RigidbodyEx IBBECBMNJMD, IFFGFEPPNHH MLKNGAFFKGE, BDAOOANIINJ KOFDOJONBID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "4")]
	public DJKJHBDDJNC LMHFHCFCBAG(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "5")]
	public BPIMIPOECAF KOCPOPLJHKO(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "6")]
	public LHFKCOAKAFP LLPJFBCPKCN(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "7")]
	public CIEGLAHOOIK FJNIKFPHEMM(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "8")]
	public BMCEHGACILG JPILLAGIKEC(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "9")]
	public GIEEMCPLHAL APBBLIOCMAI(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "10")]
	public PFDPEDGHBLL OEPLLAKEFOC(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "11")]
	public JOMIKNKHKIK HDDOHJFIGCH(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "12")]
	public CNEOMOHKMKE LHPJEPELMAJ(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "13")]
	public EMAGCCOLODN AHEKMFDJLAN(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540")]
	public HEIEIIECEIH DKJGCIABGEM(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540")]
	public PFOFEJPPCEK HNDCPKAJAKJ(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540")]
	public NGFEMPEEJHM FMFCADLAEPH(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540")]
	public FBKLACCKALP EMHHMPHJNGJ(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540")]
	public PNOEALDCJLD FLHJGJPAKDG(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public IKBHHCEMDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "14")]
	private HEIEIIECEIH EHFCCDFHEEK(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "15")]
	private PFOFEJPPCEK CFGCIJJFDNC(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "16")]
	private NGFEMPEEJHM NEJHJNMDILP(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "17")]
	private FBKLACCKALP FOJPBONOMDE(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "18")]
	private PNOEALDCJLD AMJECPKHLGE(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[LBIGLGLDDJL(typeof(LLPOOBOPOCM), new string[] { })]
public class PICGAKGILCI : LLPOOBOPOCM, NNMHDEKAJII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly LLPOOBOPOCM MGCGFHEALAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly LLPOOBOPOCM MHONPLDGBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private JFNMNHAAKGD CDAFJEIOFEF;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private LLPOOBOPOCM GIOINJOABCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6E97930", Offset = "0x6E96130", VA = "0x186E97930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6E97520", Offset = "0x6E95D20", VA = "0x186E97520", Slot = "20")]
	public void InitReferences(CDDEGKNDPAN FOBEFOGAKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6E977F0", Offset = "0x6E95FF0", VA = "0x186E977F0", Slot = "4")]
	public DJKJHBDDJNC LMHFHCFCBAG(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6E97610", Offset = "0x6E95E10", VA = "0x186E97610", Slot = "5")]
	public BPIMIPOECAF KOCPOPLJHKO(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6E97750", Offset = "0x6E95F50", VA = "0x186E97750", Slot = "6")]
	public LHFKCOAKAFP LLPJFBCPKCN(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6E97250", Offset = "0x6E95A50", VA = "0x186E97250", Slot = "7")]
	public CIEGLAHOOIK FJNIKFPHEMM(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6E97570", Offset = "0x6E95D70", VA = "0x186E97570", Slot = "8")]
	public BMCEHGACILG JPILLAGIKEC(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6E96FA0", Offset = "0x6E957A0", VA = "0x186E96FA0", Slot = "9")]
	public GIEEMCPLHAL APBBLIOCMAI(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6E97890", Offset = "0x6E96090", VA = "0x186E97890", Slot = "10")]
	public PFDPEDGHBLL OEPLLAKEFOC(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6E973A0", Offset = "0x6E95BA0", VA = "0x186E973A0", Slot = "11")]
	public JOMIKNKHKIK HDDOHJFIGCH(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6E976B0", Offset = "0x6E95EB0", VA = "0x186E976B0", Slot = "12")]
	public CNEOMOHKMKE LHPJEPELMAJ(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6E96E50", Offset = "0x6E95650", VA = "0x186E96E50", Slot = "13")]
	public EMAGCCOLODN AHEKMFDJLAN(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6E970F0", Offset = "0x6E958F0", VA = "0x186E970F0")]
	public HEIEIIECEIH DKJGCIABGEM(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6E97040", Offset = "0x6E95840", VA = "0x186E97040")]
	public PFOFEJPPCEK HNDCPKAJAKJ(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6E972F0", Offset = "0x6E95AF0", VA = "0x186E972F0")]
	public NGFEMPEEJHM FMFCADLAEPH(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6E971A0", Offset = "0x6E959A0", VA = "0x186E971A0")]
	public FBKLACCKALP EMHHMPHJNGJ(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6E96EF0", Offset = "0x6E956F0", VA = "0x186E96EF0")]
	public PNOEALDCJLD FLHJGJPAKDG(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6E97440", Offset = "0x6E95C40", VA = "0x186E97440", Slot = "19")]
	public BLIBIMCHNOD INHDBDFOAPE(RigidbodyEx IBBECBMNJMD, IFFGFEPPNHH MLKNGAFFKGE, BDAOOANIINJ KOFDOJONBID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6E97990", Offset = "0x6E96190", VA = "0x186E97990")]
	public PICGAKGILCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6E970F0", Offset = "0x6E958F0", VA = "0x186E970F0", Slot = "14")]
	private HEIEIIECEIH EHFCCDFHEEK(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6E97040", Offset = "0x6E95840", VA = "0x186E97040", Slot = "15")]
	private PFOFEJPPCEK CFGCIJJFDNC(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6E972F0", Offset = "0x6E95AF0", VA = "0x186E972F0", Slot = "16")]
	private NGFEMPEEJHM NEJHJNMDILP(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6E971A0", Offset = "0x6E959A0", VA = "0x186E971A0", Slot = "17")]
	private FBKLACCKALP FOJPBONOMDE(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6E96EF0", Offset = "0x6E956F0", VA = "0x186E96EF0", Slot = "18")]
	private PNOEALDCJLD AMJECPKHLGE(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FDKCPGHAEJJ : DJKJHBDDJNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMNJLOIFMNG(BLIBIMCHNOD IBBECBMNJMD);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEHKHJKDOJE(BLIBIMCHNOD IBBECBMNJMD);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENGNPMFOBAF(BLIBIMCHNOD OFNOGOAIFKH);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JNPIBLDIPFG(BLIBIMCHNOD OFNOGOAIFKH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ODNMMNCLKGC : LHFKCOAKAFP
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	PGCEKNIGHHM<BLIBIMCHNOD> APJEJJAMEMC
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	BLIBIMCHNOD IIJEKPGKGLM
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LNKHEDGMHEM : FBKLACCKALP
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) HHALEFKJCDP(Rigidbody JDFPCPPAJCI);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DIDJHJGCDMB : PFOFEJPPCEK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView MCKLFFHOJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class KNBBOHEHPMK : CNEOMOHKMKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly BDJHPKIGIFJ IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode KBMFMKLOEDN;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody CBNKMMHNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6E92EC0", Offset = "0x6E916C0", VA = "0x186E92EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode DECMOOCMCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6E92DB0", Offset = "0x6E915B0", VA = "0x186E92DB0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6E92C30", Offset = "0x6E91430", VA = "0x186E92C30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BD10", Offset = "0x6E8A510", VA = "0x186E8BD10")]
	public KNBBOHEHPMK(BLIBIMCHNOD IBBECBMNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6E92CA0", Offset = "0x6E914A0", VA = "0x186E92CA0", Slot = "6")]
	public void JGNDLDOBBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6E92BB0", Offset = "0x6E913B0", VA = "0x186E92BB0", Slot = "9")]
	public void GJHIAAEHEJJ(Rigidbody BBEDNPEOIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6E92BA0", Offset = "0x6E913A0", VA = "0x186E92BA0", Slot = "7")]
	public void EJHBMFGOGKF(bool DGIIKLNEKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6E92A30", Offset = "0x6E91230", VA = "0x186E92A30", Slot = "8")]
	public void ANNBIHHDOJO(bool DGIIKLNEKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6E92A40", Offset = "0x6E91240", VA = "0x186E92A40", Slot = "10")]
	public bool CKPKMOKPEAD(Vector3 NHPNENOFEDP, [Out] RaycastHit ODIFANJGAKA, float NGOKPHBDKPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6E92910", Offset = "0x6E91110", VA = "0x186E92910")]
	private void AAAFDOLENIO(bool DGIIKLNEKFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class GPEDHFPMJIM : GIEEMCPLHAL, IDisposable, IEEDHJFAECG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly BDJHPKIGIFJ IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private COGJEJCHONG FBOPNPDMAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private OHGALMMLAOE MLBHCBFHKKC;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public COGJEJCHONG CNNIDAAFDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6E8DBB0", Offset = "0x6E8C3B0", VA = "0x186E8DBB0", Slot = "6")]
		get
		{
			return default(COGJEJCHONG);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6E8E030", Offset = "0x6E8C830", VA = "0x186E8E030", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform MIBDLNCBMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6E8E010", Offset = "0x6E8C810", VA = "0x186E8E010", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<LPELNIAIFBH, LPELNIAIFBH> PFPGJFIOAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6E8E100", Offset = "0x6E8C900", VA = "0x186E8E100", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6E8DF60", Offset = "0x6E8C760", VA = "0x186E8DF60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E1B0", Offset = "0x6E8C9B0", VA = "0x186E8E1B0")]
	public GPEDHFPMJIM(BLIBIMCHNOD IBBECBMNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DCF0", Offset = "0x6E8C4F0", VA = "0x186E8DCF0", Slot = "8")]
	public void JGNDLDOBBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DB60", Offset = "0x6E8C360", VA = "0x186E8DB60", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x944E40", Offset = "0x943640", VA = "0x180944E40", Slot = "11")]
	private void HNOGJNBOKCO(LPELNIAIFBH MENHELCNPAE, LPELNIAIFBH DLLGGKJLENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "12")]
	private void KEGKIGFFPOC(bool EJKKPOHPAHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PMNAOIGIHKK : LLPOOBOPOCM
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6E98880", Offset = "0x6E97080", VA = "0x186E98880", Slot = "4")]
	public DJKJHBDDJNC LMHFHCFCBAG(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6E98570", Offset = "0x6E96D70", VA = "0x186E98570", Slot = "5")]
	public BPIMIPOECAF KOCPOPLJHKO(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6E98750", Offset = "0x6E96F50", VA = "0x186E98750", Slot = "6")]
	public LHFKCOAKAFP LLPJFBCPKCN(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6E98110", Offset = "0x6E96910", VA = "0x186E98110", Slot = "7")]
	public CIEGLAHOOIK FJNIKFPHEMM(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6E984A0", Offset = "0x6E96CA0", VA = "0x186E984A0", Slot = "8")]
	public BMCEHGACILG JPILLAGIKEC(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6E97BE0", Offset = "0x6E963E0", VA = "0x186E97BE0", Slot = "9")]
	public GIEEMCPLHAL APBBLIOCMAI(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6E98970", Offset = "0x6E97170", VA = "0x186E98970", Slot = "10")]
	public PFDPEDGHBLL OEPLLAKEFOC(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6E982C0", Offset = "0x6E96AC0", VA = "0x186E982C0", Slot = "11")]
	public JOMIKNKHKIK HDDOHJFIGCH(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6E98690", Offset = "0x6E96E90", VA = "0x186E98690", Slot = "12")]
	public CNEOMOHKMKE LHPJEPELMAJ(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6E97A40", Offset = "0x6E96240", VA = "0x186E97A40", Slot = "13")]
	public EMAGCCOLODN AHEKMFDJLAN(BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6E97E40", Offset = "0x6E96640", VA = "0x186E97E40")]
	public HEIEIIECEIH DKJGCIABGEM(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6E97CB0", Offset = "0x6E964B0", VA = "0x186E97CB0")]
	public PFOFEJPPCEK HNDCPKAJAKJ(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6E98190", Offset = "0x6E96990", VA = "0x186E98190")]
	public NGFEMPEEJHM FMFCADLAEPH(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6E97F80", Offset = "0x6E96780", VA = "0x186E97F80")]
	public FBKLACCKALP EMHHMPHJNGJ(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6E97B00", Offset = "0x6E96300", VA = "0x186E97B00")]
	public PNOEALDCJLD FLHJGJPAKDG(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6E98380", Offset = "0x6E96B80", VA = "0x186E98380", Slot = "19")]
	public BLIBIMCHNOD INHDBDFOAPE(RigidbodyEx IBBECBMNJMD, IFFGFEPPNHH MLKNGAFFKGE, BDAOOANIINJ KOFDOJONBID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public PMNAOIGIHKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6E97E40", Offset = "0x6E96640", VA = "0x186E97E40", Slot = "14")]
	private HEIEIIECEIH EHFCCDFHEEK(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6E97CB0", Offset = "0x6E964B0", VA = "0x186E97CB0", Slot = "15")]
	private PFOFEJPPCEK CFGCIJJFDNC(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6E98190", Offset = "0x6E96990", VA = "0x186E98190", Slot = "16")]
	private NGFEMPEEJHM NEJHJNMDILP(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6E97F80", Offset = "0x6E96780", VA = "0x186E97F80", Slot = "17")]
	private FBKLACCKALP FOJPBONOMDE(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6E97B00", Offset = "0x6E96300", VA = "0x186E97B00", Slot = "18")]
	private PNOEALDCJLD AMJECPKHLGE(BLIBIMCHNOD LHMMDMHNIJC, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class NMHAHNMEECP : JOMIKNKHKIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly BDJHPKIGIFJ IBBECBMNJMD;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody CBNKMMHNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6E92EC0", Offset = "0x6E916C0", VA = "0x186E92EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool CLMLPLJBEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6E95660", Offset = "0x6E93E60", VA = "0x186E95660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool PFCCDAMMLFD
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6E8D3E0", Offset = "0x6E8BBE0", VA = "0x186E8D3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private BLIBIMCHNOD GFHKLHCNBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6E95910", Offset = "0x6E94110", VA = "0x186E95910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BD10", Offset = "0x6E8A510", VA = "0x186E8BD10")]
	public NMHAHNMEECP(BLIBIMCHNOD IBBECBMNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6E95BF0", Offset = "0x6E943F0", VA = "0x186E95BF0", Slot = "4")]
	public void OMGLNCEALOI(Vector3 AIDFLNGPPBP, ForceMode FAEAIBHJCJL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6E95D50", Offset = "0x6E94550", VA = "0x186E95D50")]
	private void PKGLFGCALOE(Vector3 AIDFLNGPPBP, ForceMode FAEAIBHJCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6E95970", Offset = "0x6E94170", VA = "0x186E95970", Slot = "5")]
	public void NCCHCEKONBH(Vector3 AIDFLNGPPBP, Vector3 GBKEBGLIOFD, ForceMode FAEAIBHJCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6E95500", Offset = "0x6E93D00", VA = "0x186E95500", Slot = "6")]
	public void JFGEJOBBMAO(Vector3 MODELFPBHLJ, ForceMode FAEAIBHJCJL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6E952A0", Offset = "0x6E93AA0", VA = "0x186E952A0")]
	private void GEENACDCKIH(Vector3 MODELFPBHLJ, ForceMode FAEAIBHJCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6E956B0", Offset = "0x6E93EB0", VA = "0x186E956B0", Slot = "7")]
	public void KFBMLPCOLML(Vector3 MODELFPBHLJ, ForceMode FAEAIBHJCJL = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class EJBPFPJDNMJ : EMAGCCOLODN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly BDJHPKIGIFJ IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool OHLDOBBEIGN;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool GJJJAFNFPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F40", Offset = "0x8E1740", VA = "0x1808E2F40", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BB60", Offset = "0x6E8A360", VA = "0x186E8BB60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BD10", Offset = "0x6E8A510", VA = "0x186E8BD10")]
	public EJBPFPJDNMJ(BLIBIMCHNOD IBBECBMNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BCE0", Offset = "0x6E8A4E0", VA = "0x186E8BCE0", Slot = "6")]
	public void GJHIAAEHEJJ(Rigidbody BBEDNPEOIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BC70", Offset = "0x6E8A470", VA = "0x186E8BC70", Slot = "7")]
	public void FGNBBJJGDMJ(Rigidbody BBEDNPEOIIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class MGNHGIBNFAM : FDKCPGHAEJJ, DJKJHBDDJNC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BLIBIMCHNOD IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<BLIBIMCHNOD> MDKAMMONHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private BLIBIMCHNOD AHKBBGKKCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private BLIBIMCHNOD GGJNHHDMGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform NMMIDNEALAG;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform BNMINHJAICK
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6E94E90", Offset = "0x6E93690", VA = "0x186E94E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public BLIBIMCHNOD GFHKLHCNBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x843F90", Offset = "0x842790", VA = "0x180843F90", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6E95070", Offset = "0x6E93870", VA = "0x186E95070", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public BLIBIMCHNOD BENFNHCGCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x843FF0", Offset = "0x8427F0", VA = "0x180843FF0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<BLIBIMCHNOD> CNJBJPJMJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x843FE0", Offset = "0x8427E0", VA = "0x180843FE0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event JDCBCOFMANP KGHFDCJBICF
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6E942A0", Offset = "0x6E92AA0", VA = "0x186E942A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6E95080", Offset = "0x6E93880", VA = "0x186E95080", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event JDCBCOFMANP DNJPMAKDPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6E934F0", Offset = "0x6E91CF0", VA = "0x186E934F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6E94EF0", Offset = "0x6E936F0", VA = "0x186E94EF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event OIOCDFIICEJ KCMDBECEJLM
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6E94650", Offset = "0x6E92E50", VA = "0x186E94650", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6E94FD0", Offset = "0x6E937D0", VA = "0x186E94FD0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action JBJOBNEFGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6E93C50", Offset = "0x6E92450", VA = "0x186E93C50", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6E93BB0", Offset = "0x6E923B0", VA = "0x186E93BB0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action HPDLLFCBHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6E93590", Offset = "0x6E91D90", VA = "0x186E93590", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6E94450", Offset = "0x6E92C50", VA = "0x186E94450", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<BLIBIMCHNOD> JKCMJAHCHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6E94AC0", Offset = "0x6E932C0", VA = "0x186E94AC0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6E944F0", Offset = "0x6E92CF0", VA = "0x186E944F0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<BLIBIMCHNOD> INHKILDONGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6E93F80", Offset = "0x6E92780", VA = "0x186E93F80", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6E946F0", Offset = "0x6E92EF0", VA = "0x186E946F0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action LIMNEOMCPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6E94B70", Offset = "0x6E93370", VA = "0x186E94B70", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6E94A20", Offset = "0x6E93220", VA = "0x186E94A20", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<BLIBIMCHNOD> BEGGEFKJFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6E93E30", Offset = "0x6E92630", VA = "0x186E93E30", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6E945A0", Offset = "0x6E92DA0", VA = "0x186E945A0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x6E95120", Offset = "0x6E93920", VA = "0x186E95120")]
	public MGNHGIBNFAM(BLIBIMCHNOD IBBECBMNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x6E93EE0", Offset = "0x6E926E0", VA = "0x186E93EE0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6E93630", Offset = "0x6E91E30", VA = "0x186E93630", Slot = "30")]
	public void BFFDCAOPJND(BLIBIMCHNOD OGAPKPCGEHM, bool NEAOAKEDNKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6E94030", Offset = "0x6E92830", VA = "0x186E94030", Slot = "6")]
	public void ENGNPMFOBAF(BLIBIMCHNOD OFNOGOAIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6E947A0", Offset = "0x6E92FA0", VA = "0x186E947A0", Slot = "7")]
	public void JNPIBLDIPFG(BLIBIMCHNOD OFNOGOAIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6E94340", Offset = "0x6E92B40", VA = "0x186E94340", Slot = "4")]
	public void FMNJLOIFMNG(BLIBIMCHNOD IBBECBMNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6E93450", Offset = "0x6E91C50", VA = "0x186E93450", Slot = "5")]
	public void AEHKHJKDOJE(BLIBIMCHNOD IBBECBMNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6E94DF0", Offset = "0x6E935F0", VA = "0x186E94DF0")]
	private void LAMMMJIANPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6E94F90", Offset = "0x6E93790", VA = "0x186E94F90")]
	private void MAKPLGAJGDM(BLIBIMCHNOD OFNOGOAIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6E93CF0", Offset = "0x6E924F0", VA = "0x186E93CF0")]
	private void DHKLICFKNFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6E93320", Offset = "0x6E91B20", VA = "0x186E93320")]
	private void ABALGLAPHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6E94C10", Offset = "0x6E93410", VA = "0x186E94C10")]
	private void KILPMDFBBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6E94D30", Offset = "0x6E93530", VA = "0x186E94D30")]
	[CompilerGenerated]
	private object KNDIKAPOKGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class MFIPCAHEEDC
{
	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6E92FE0", Offset = "0x6E917E0", VA = "0x186E92FE0")]
	public static FDKCPGHAEJJ OGGHIBHHBBN(this BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class KDFDAHHAGHO : ODNMMNCLKGC, LHFKCOAKAFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly BDJHPKIGIFJ IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PGCEKNIGHHM<BLIBIMCHNOD> MMHAIAIJFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool EILMNCCELGO;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public PGCEKNIGHHM<BLIBIMCHNOD> APJEJJAMEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 EFINPOPLKCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6E91D40", Offset = "0x6E90540", VA = "0x186E91D40", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 IAHMJIMOAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6E92580", Offset = "0x6E90D80", VA = "0x186E92580", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 IHOIHNGCNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6E92100", Offset = "0x6E90900", VA = "0x186E92100")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public BLIBIMCHNOD IIJEKPGKGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6E91C90", Offset = "0x6E90490", VA = "0x186E91C90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6E92810", Offset = "0x6E91010", VA = "0x186E92810")]
	public KDFDAHHAGHO(BLIBIMCHNOD IBBECBMNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6E927A0", Offset = "0x6E90FA0", VA = "0x186E927A0", Slot = "8")]
	public void OBFOHBMNHPH(BLIBIMCHNOD GGJNHHDMGON, object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6E92740", Offset = "0x6E90F40", VA = "0x186E92740", Slot = "9")]
	public void OAIIBHEAFFE(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6E921F0", Offset = "0x6E909F0", VA = "0x186E921F0")]
	private Vector3 MFHLEKEODDH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6E91D70", Offset = "0x6E90570", VA = "0x186E91D70")]
	private void KGGPIHBNNDM(BLIBIMCHNOD PBKBHLKJFBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class DDMHPKAAFCB
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6E889D0", Offset = "0x6E871D0", VA = "0x186E889D0")]
	public static ODNMMNCLKGC DHLJHLGKNHC(this BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class DJDANEEFPBO : LNKHEDGMHEM, FBKLACCKALP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly BDJHPKIGIFJ IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 AFMBELFAFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 JKPHILDBACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float DEHBBBPFAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float ACAKKPHHCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 JFPPNNFHCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? JANBHHCNKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? DGGFILMBGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool BKBJHGDLBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool CDLOCLIOMIA;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 MJMHHNPDCGE
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xD2ECE0", Offset = "0xD2D4E0", VA = "0x180D2ECE0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6E89860", Offset = "0x6E88060", VA = "0x186E89860", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 BJAEOLLMDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6E8B900", Offset = "0x6E8A100", VA = "0x186E8B900", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float NOIFPIGGDBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B17D0", Offset = "0x8AFFD0", VA = "0x1808B17D0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E896A0", Offset = "0x6E87EA0", VA = "0x186E896A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float BHAGJPJDMML
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B18E0", Offset = "0x8B00E0", VA = "0x1808B18E0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E897B0", Offset = "0x6E87FB0", VA = "0x186E897B0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 LCEENPPGPDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6E89510", Offset = "0x6E87D10", VA = "0x186E89510", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion CPJKDPJHJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E8AAF0", Offset = "0x6E892F0", VA = "0x186E8AAF0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody CBNKMMHNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6E8B8B0", Offset = "0x6E8A0B0", VA = "0x186E8B8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event JDCBCOFMANP MNNHDMKDMMI
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6E89BE0", Offset = "0x6E883E0", VA = "0x186E89BE0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6E8B050", Offset = "0x6E89850", VA = "0x186E8B050", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BA00", Offset = "0x6E8A200", VA = "0x186E8BA00")]
	public DJDANEEFPBO(BLIBIMCHNOD IBBECBMNJMD, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6E8AC70", Offset = "0x6E89470", VA = "0x186E8AC70", Slot = "17")]
	public void ICLCACMFEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6E89430", Offset = "0x6E87C30", VA = "0x186E89430", Slot = "16")]
	public void BCJNOAFHLBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6E89B00", Offset = "0x6E88300", VA = "0x186E89B00", Slot = "19")]
	public void GJHIAAEHEJJ(Rigidbody BBEDNPEOIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6E89910", Offset = "0x6E88110", VA = "0x186E89910", Slot = "20")]
	public void FGNBBJJGDMJ(Rigidbody BBEDNPEOIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E89280", Offset = "0x6E87A80", VA = "0x186E89280", Slot = "18")]
	public void AKKFJHEEDKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E8B410", Offset = "0x6E89C10", VA = "0x186E8B410", Slot = "21")]
	public void ODFKKDADEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E89860", Offset = "0x6E88060", VA = "0x186E89860")]
	private void EIOADHJLEHM(Vector3 IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6E89190", Offset = "0x6E87990", VA = "0x186E89190")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 ABENMCJCJOP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6E896A0", Offset = "0x6E87EA0", VA = "0x186E896A0")]
	private void EEAPCPEFPEB(float IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6E897B0", Offset = "0x6E87FB0", VA = "0x186E897B0")]
	private void HAGPGJIKOJH(float IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6E8B270", Offset = "0x6E89A70", VA = "0x186E8B270")]
	private Vector3 MAICFMPGOFP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6E8AE20", Offset = "0x6E89620", VA = "0x186E8AE20", Slot = "15")]
	public void JBEJPGIKMFB((Quaternion rot, Vector3 moments) EJDPIICEIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6E8B0F0", Offset = "0x6E898F0", VA = "0x186E8B0F0")]
	private Quaternion LIBHNFMJNDG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6E8AA20", Offset = "0x6E89220", VA = "0x186E8AA20")]
	public void HHALEFKJCDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6E89C80", Offset = "0x6E88480", VA = "0x186E89C80", Slot = "4")]
	public (float, Vector3) HHALEFKJCDP(Rigidbody JDFPCPPAJCI)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class MHLJPJNIPHP
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6E951E0", Offset = "0x6E939E0", VA = "0x186E951E0")]
	public static LNKHEDGMHEM HIMIKNBICAJ(this BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class DEGPKKDDPND : NGFEMPEEJHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly BDJHPKIGIFJ IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly ADHBKFMFMPL PCIHODBHNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly AAOCMHJKPKO APONHBLBCOK;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool CCIJFGMJIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xEAB410", Offset = "0xEA9C10", VA = "0x180EAB410", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public AAOCMHJKPKO MFEKHJJCHEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B89F0", Offset = "0x8B71F0", VA = "0x1808B89F0", Slot = "11")]
		get
		{
			return default(AAOCMHJKPKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6E89090", Offset = "0x6E87890", VA = "0x186E89090")]
	public DEGPKKDDPND(BLIBIMCHNOD IBBECBMNJMD, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6E88EA0", Offset = "0x6E876A0", VA = "0x186E88EA0", Slot = "4")]
	public void JGNDLDOBBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6E88F70", Offset = "0x6E87770", VA = "0x186E88F70")]
	private bool JKMHJGCPOHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6E88A90", Offset = "0x6E87290", VA = "0x186E88A90", Slot = "5")]
	public void GDCPAJFJMOG(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E88E70", Offset = "0x6E87670", VA = "0x186E88E70", Slot = "6")]
	public void HPIBMKADDKA(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E88C30", Offset = "0x6E87430", VA = "0x186E88C30", Slot = "9")]
	public void GPCCEBKLCMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6E88D60", Offset = "0x6E87560", VA = "0x186E88D60")]
	private void HBGIIJNHMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6E88AC0", Offset = "0x6E872C0", VA = "0x186E88AC0")]
	private void GENHLPHDCBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6E89010", Offset = "0x6E87810", VA = "0x186E89010", Slot = "8")]
	public void PBAFJCFPAPK(BLIBIMCHNOD IBBECBMNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6E89050", Offset = "0x6E87850", VA = "0x186E89050", Slot = "7")]
	public void PBCMMDONLLN(BLIBIMCHNOD IBBECBMNJMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class PNPFFIKBNCK : PFDPEDGHBLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly BDJHPKIGIFJ IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly ADHBKFMFMPL DKHMHGNCEMD;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool CLMLPLJBEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6E98C30", Offset = "0x6E97430", VA = "0x186E98C30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event JDCBCOFMANP IDNGIOKNFLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6E98B50", Offset = "0x6E97350", VA = "0x186E98B50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E98CE0", Offset = "0x6E974E0", VA = "0x186E98CE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E98EA0", Offset = "0x6E976A0", VA = "0x186E98EA0")]
	public PNPFFIKBNCK(BLIBIMCHNOD IBBECBMNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6E98D80", Offset = "0x6E97580", VA = "0x186E98D80", Slot = "7")]
	public void MIMJFPFEPLD(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6E98A90", Offset = "0x6E97290", VA = "0x186E98A90", Slot = "8")]
	public void ADCENDCGKGM(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6E98D90", Offset = "0x6E97590", VA = "0x186E98D90", Slot = "9")]
	public void OBJFMIGLMGM(object OECMOOGGOOF, bool KCOPEBDIOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6E98BF0", Offset = "0x6E973F0", VA = "0x186E98BF0", Slot = "12")]
	public void IJOLJPBNEDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6E98AD0", Offset = "0x6E972D0", VA = "0x186E98AD0", Slot = "10")]
	public void GJHIAAEHEJJ(Rigidbody EBBDKHLIBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x6E98AA0", Offset = "0x6E972A0", VA = "0x186E98AA0", Slot = "11")]
	public void FGNBBJJGDMJ(Rigidbody BBEDNPEOIIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class EOCBCDDDJBC : DIDJHJGCDMB, PFOFEJPPCEK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly BDJHPKIGIFJ IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView HLJNKLNAEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool GEOBFNIACKK;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView MCKLFFHOJFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool OPKOGIKNNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E8C200", Offset = "0x6E8AA00", VA = "0x186E8C200", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool KJOHMFNDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA28750", Offset = "0xA26F50", VA = "0x180A28750", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event JDCBCOFMANP GAHOJLCEMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6E8C160", Offset = "0x6E8A960", VA = "0x186E8C160", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E8C350", Offset = "0x6E8AB50", VA = "0x186E8C350", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C940", Offset = "0x6E8B140", VA = "0x186E8C940")]
	public EOCBCDDDJBC(BLIBIMCHNOD IBBECBMNJMD, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C220", Offset = "0x6E8AA20", VA = "0x186E8C220", Slot = "9")]
	public void JGNDLDOBBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BF10", Offset = "0x6E8A710", VA = "0x186E8BF10", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C660", Offset = "0x6E8AE60", VA = "0x186E8C660", Slot = "10")]
	public void OKBOOGFNOML(BLIBIMCHNOD GGJNHHDMGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C7D0", Offset = "0x6E8AFD0", VA = "0x186E8C7D0", Slot = "11")]
	public void PNCEIDMPLDF(BLIBIMCHNOD GGJNHHDMGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BDA0", Offset = "0x6E8A5A0", VA = "0x186E8BDA0")]
	private void DIHLEOILOEF(PhotonView IJMFCMNHCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C010", Offset = "0x6E8A810", VA = "0x186E8C010")]
	private void EMHMGJNILLG(DACPPDODOBJ MGBKODCBFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C3F0", Offset = "0x6E8ABF0", VA = "0x186E8C3F0")]
	private void NKMNGKKLOCP(PhotonView GEAJGPMLFJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class OIGJEDKMDIL
{
	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6E96B80", Offset = "0x6E95380", VA = "0x186E96B80")]
	public static DIDJHJGCDMB DKBAGFOMCJC(this BLIBIMCHNOD LHMMDMHNIJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class FGINHKMEKJG : PNOEALDCJLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BDJHPKIGIFJ IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints AMILDFOPLDD;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool AHPJGJHNNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xC8F800", Offset = "0xC8E000", VA = "0x180C8F800", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x43FA420", Offset = "0x43F8C20", VA = "0x1843FA420", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool GEAEJCNEFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xEF9D40", Offset = "0xEF8540", VA = "0x180EF9D40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x43FA410", Offset = "0x43F8C10", VA = "0x1843FA410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints MBGDFDDGMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x84F0B0", Offset = "0x84D8B0", VA = "0x18084F0B0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6E8CA90", Offset = "0x6E8B290", VA = "0x186E8CA90", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CC20", Offset = "0x6E8B420", VA = "0x186E8CC20")]
	public FGINHKMEKJG(BLIBIMCHNOD IBBECBMNJMD, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CBF0", Offset = "0x6E8B3F0", VA = "0x186E8CBF0", Slot = "9")]
	public void GJHIAAEHEJJ(Rigidbody BBEDNPEOIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CBC0", Offset = "0x6E8B3C0", VA = "0x186E8CBC0", Slot = "10")]
	public void FGNBBJJGDMJ(Rigidbody BBEDNPEOIIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class JJPLEIKODKH : CIEGLAHOOIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly BLIBIMCHNOD IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float GFHAEHONOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float MCAKFMNMJOC;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float FLCCBCFCFAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8B1960", Offset = "0x8B0160", VA = "0x1808B1960", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x6E91AB0", Offset = "0x6E902B0", VA = "0x186E91AB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float LHMGKIPGNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8B1920", Offset = "0x8B0120", VA = "0x1808B1920", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6E91B80", Offset = "0x6E90380", VA = "0x186E91B80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6E91C50", Offset = "0x6E90450", VA = "0x186E91C50")]
	public JJPLEIKODKH(BLIBIMCHNOD IBBECBMNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6E91A60", Offset = "0x6E90260", VA = "0x186E91A60", Slot = "8")]
	public void GJHIAAEHEJJ(Rigidbody BBEDNPEOIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6E919C0", Offset = "0x6E901C0", VA = "0x186E919C0", Slot = "9")]
	public void FGNBBJJGDMJ(Rigidbody BBEDNPEOIIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class OELCKJCIHAD : BMCEHGACILG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly BDJHPKIGIFJ IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool CGHECAKLNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool NBGKAGJFKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int ENKLCFHPNAH;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody CBNKMMHNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6E8B8B0", Offset = "0x6E8A0B0", VA = "0x186E8B8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool AAHEEMLHNGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6E967B0", Offset = "0x6E94FB0", VA = "0x186E967B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private BLIBIMCHNOD GFHKLHCNBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6E967D0", Offset = "0x6E94FD0", VA = "0x186E967D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool PFCCDAMMLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6E96050", Offset = "0x6E94850", VA = "0x186E96050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event JDCBCOFMANP JFDIAIEIKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6E96980", Offset = "0x6E95180", VA = "0x186E96980", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6E960C0", Offset = "0x6E948C0", VA = "0x186E960C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6E96A20", Offset = "0x6E95220", VA = "0x186E96A20")]
	public OELCKJCIHAD(BLIBIMCHNOD IBBECBMNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6E96680", Offset = "0x6E94E80", VA = "0x186E96680", Slot = "6")]
	public void JGNDLDOBBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6E960B0", Offset = "0x6E948B0", VA = "0x186E960B0", Slot = "8")]
	public void EJCAEHOLKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6E96830", Offset = "0x6E95030", VA = "0x186E96830", Slot = "7")]
	public bool NDMHBGEBIJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E96710", Offset = "0x6E94F10", VA = "0x186E96710", Slot = "9")]
	public void KOFDMENNLIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6E95FB0", Offset = "0x6E947B0", VA = "0x186E95FB0", Slot = "11")]
	public void ACGLIAEOOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6E964D0", Offset = "0x6E94CD0", VA = "0x186E964D0", Slot = "10")]
	public void JEMBLOPFNLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6E96160", Offset = "0x6E94960", VA = "0x186E96160")]
	private bool EMMLBPJOAFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6E96340", Offset = "0x6E94B40", VA = "0x186E96340")]
	private void IPFMNADJOKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class GAGKDGJHLME : HEIEIIECEIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly BDJHPKIGIFJ IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly ADHBKFMFMPL BDFPFADKCLM;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody CBNKMMHNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x844F30", Offset = "0x843730", VA = "0x180844F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool PFCCDAMMLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6E8D3E0", Offset = "0x6E8BBE0", VA = "0x186E8D3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool LMANJLJNKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xEAB410", Offset = "0xEA9C10", VA = "0x180EAB410", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DA50", Offset = "0x6E8C250", VA = "0x186E8DA50")]
	public GAGKDGJHLME(BLIBIMCHNOD IBBECBMNJMD, [In] IFFGFEPPNHH MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D440", Offset = "0x6E8BC40", VA = "0x186E8D440", Slot = "5")]
	public void JGNDLDOBBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DA20", Offset = "0x6E8C220", VA = "0x186E8DA20", Slot = "7")]
	public void OOMOLILEKIP(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D9F0", Offset = "0x6E8C1F0", VA = "0x186E8D9F0", Slot = "8")]
	public void LNGMHNFFFAF(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CCC0", Offset = "0x6E8B4C0", VA = "0x186E8CCC0", Slot = "9")]
	public void AMLGMDCJBID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D1F0", Offset = "0x6E8B9F0", VA = "0x186E8D1F0", Slot = "11")]
	public void BOGDJKPIHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D870", Offset = "0x6E8C070", VA = "0x186E8D870", Slot = "12")]
	public void LGFHLDCHEBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D4E0", Offset = "0x6E8BCE0", VA = "0x186E8D4E0", Slot = "10")]
	public void KEHFGNOLCIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D670", Offset = "0x6E8BE70", VA = "0x186E8D670")]
	private void KFMBAGLKIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CFF0", Offset = "0x6E8B7F0", VA = "0x186E8CFF0")]
	private void BBJGEEBNMNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class IFOCFBDDKOL : BPIMIPOECAF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly BDJHPKIGIFJ IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly ADHBKFMFMPL KDHGFLEBDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float JJEIEHNJDNN;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public FCAMINOCOJA MEKONANKKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x84A250", Offset = "0x848A50", VA = "0x18084A250", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public JILCCGMFDPF LAPJIFHJGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x84A240", Offset = "0x848A40", VA = "0x18084A240", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 IHOIHNGCNAI
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6E913B0", Offset = "0x6E8FBB0", VA = "0x186E913B0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6E8EE80", Offset = "0x6E8D680", VA = "0x186E8EE80", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 HODGLLMGNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x6E8EF40", Offset = "0x6E8D740", VA = "0x186E8EF40", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6E8E360", Offset = "0x6E8CB60", VA = "0x186E8E360", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 AFOCIAPHPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6E91140", Offset = "0x6E8F940", VA = "0x186E91140", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x6E91710", Offset = "0x6E8FF10", VA = "0x186E91710", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 JKGLJJAHGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6E8E7C0", Offset = "0x6E8CFC0", VA = "0x186E8E7C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6E90110", Offset = "0x6E8E910", VA = "0x186E90110", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float IALJDEHLOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8B1840", Offset = "0x8B0040", VA = "0x1808B1840", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x6E909E0", Offset = "0x6E8F1E0", VA = "0x186E909E0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool OMMLNEFLEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x18587A0", Offset = "0x1856FA0", VA = "0x1818587A0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private JOMIKNKHKIK NFIBMEJCGDK
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x66E56A0", Offset = "0x66E3EA0", VA = "0x1866E56A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool AAHEEMLHNGO
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6E91510", Offset = "0x6E8FD10", VA = "0x186E91510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6E91830", Offset = "0x6E90030", VA = "0x186E91830")]
	public IFOCFBDDKOL(BLIBIMCHNOD IBBECBMNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6E90AF0", Offset = "0x6E8F2F0", VA = "0x186E90AF0", Slot = "19")]
	public void JGNDLDOBBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E9A0", Offset = "0x6E8D1A0", VA = "0x186E8E9A0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FA80", Offset = "0x6E8E280", VA = "0x186E8FA80", Slot = "28")]
	public void GJHIAAEHEJJ(Rigidbody BBEDNPEOIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0xCEDFB0", Offset = "0xCEC7B0", VA = "0x180CEDFB0", Slot = "20")]
	public void OAEIHNOBKCD(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0xCEE270", Offset = "0xCECA70", VA = "0x180CEE270", Slot = "30")]
	public void AHIFMAEEEJI(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6E91530", Offset = "0x6E8FD30", VA = "0x186E91530", Slot = "35")]
	public Vector3 OAMALPNFMIN(Vector3 FGJLCJLJNIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6E907C0", Offset = "0x6E8EFC0", VA = "0x186E907C0", Slot = "34")]
	public Vector3 IEAGFGBBACO(Vector3 JDJKHLHCBKJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6E90AF0", Offset = "0x6E8F2F0", VA = "0x186E90AF0", Slot = "27")]
	public void KOHJLEDPKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6E917D0", Offset = "0x6E8FFD0", VA = "0x186E917D0", Slot = "25")]
	public void PFAHOCILJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6E90140", Offset = "0x6E8E940", VA = "0x186E90140", Slot = "24")]
	public void HILPLCDGDCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F060", Offset = "0x6E8D860", VA = "0x186E8F060", Slot = "33")]
	public void FCDJKPADNPE(Vector3 CANJCDKNECM, Vector3 HGAJHDLFDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6E90980", Offset = "0x6E8F180", VA = "0x186E90980", Slot = "32")]
	public void JBIFLKBLOIG(Vector3 BBBBLJNFIIN, Vector3 MHHCOPPDPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6E901A0", Offset = "0x6E8E9A0", VA = "0x186E901A0", Slot = "31")]
	public void HKNCONIMPPD(Vector3 KCCHHOLMGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F2A0", Offset = "0x6E8DAA0", VA = "0x186E8F2A0", Slot = "22")]
	public void GEKDDCOAMGG(HHDEFPFLNPK IEKDAIGCGCD, Vector3 IGIFOANCFEK, float GMIEKGDCBNK, float FPFOKJKKFIH = 8f, float ICICHGCMKLL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E530", Offset = "0x6E8CD30", VA = "0x186E8E530", Slot = "21")]
	public void BNGNNEOHKDB(DPAMEKGJPIB FGKFDJCPHID, Vector3 EJPFIPNBFHE, float JGAPKPCMPGB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6E90340", Offset = "0x6E8EB40", VA = "0x186E90340", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HNJOBGDEAPL(DPAMEKGJPIB FGKFDJCPHID, Vector3 LOMIHBHMPMH, float OODKBJMFLAN = 7f, float KLHDNNAMDKE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0xDDE090", Offset = "0xDDC890", VA = "0x180DDE090")]
	private static void KMPGCJHGDEJ(Vector3 BDPGEMOCEKF, Vector3 ANAAMNHLGOD, [Out] Vector3 FDEDPMPKIIN, [Out] Vector3 MHDFMNKPFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6E90030", Offset = "0x6E8E830", VA = "0x186E90030", Slot = "29")]
	public Vector3 HCENJEONKBP(Vector3 BDPGEMOCEKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F8F0", Offset = "0x6E8E0F0", VA = "0x186E8F8F0", Slot = "26")]
	public void GFMKFDINHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6E909E0", Offset = "0x6E8F1E0", VA = "0x186E909E0")]
	private void NHJOGCHKCNE(float IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E390", Offset = "0x6E8CB90", VA = "0x186E8E390")]
	private void BMJEHMHGCOM(Vector3 EJPFIPNBFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6E912A0", Offset = "0x6E8FAA0", VA = "0x186E912A0")]
	private Vector3 KLLDBOMLPME()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FBB0", Offset = "0x6E8E3B0", VA = "0x186E8FBB0")]
	private void GOGIGEMOBIF(Vector3 JDJKHLHCBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E240", Offset = "0x6E8CA40", VA = "0x186E8E240")]
	private Vector3 ABDLIHIONAE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x6E8EA00", Offset = "0x6E8D200", VA = "0x186E8EA00")]
	private void EBHJNOKPBPB(Vector3 IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6E90B90", Offset = "0x6E8F390", VA = "0x186E90B90")]
	private void KBBODAFPPEK(Vector3 JDJKHLHCBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E8F0", Offset = "0x6E8D0F0", VA = "0x186E8E8F0")]
	private void DKHJPFGBOIA()
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
