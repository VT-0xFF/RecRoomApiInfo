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
	public class LogRegistrationIndex : IGBHOMLLHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x748D580", Offset = "0x748BF80", VA = "0x18748D580", Slot = "4")]
		public override void KFMGLABNFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x197E170", Offset = "0x197CB70", VA = "0x18197E170", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74950B0", Offset = "0x7493AB0", VA = "0x1874950B0")]
		private void ACOMFCOBJKA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74953C0", Offset = "0x7493DC0", VA = "0x1874953C0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7495420", Offset = "0x7493E20", VA = "0x187495420")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, PLAOFEANGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly KLEHBGEJMBN AJBBHLBAKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool JEHDNJEGLGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private EMDBJMNALPM KBKHCCJFGMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[HBLGLBJJBJP(CAHCDFDGNOL.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[HBLGLBJJBJP(CAHCDFDGNOL.SelfAndParent, true, false, false)]
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
		private AKCEHIDIOBB physicsInterpolation;

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

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Transform NJBDGCMJLHF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal EMDBJMNALPM CKLHPFDBJPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7490C20", Offset = "0x748F620", VA = "0x187490C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private EMDBJMNALPM OKIJJACLKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int GHOKDFBENLO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7492580", Offset = "0x7490F80", VA = "0x187492580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx OPKNHFBALMM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x74928E0", Offset = "0x74912E0", VA = "0x1874928E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx BPFDMKBMANG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7492820", Offset = "0x7491220", VA = "0x187492820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx NNFBEGDDJKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x74934F0", Offset = "0x7491EF0", VA = "0x1874934F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7494A20", Offset = "0x7493420", VA = "0x187494A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform FOBEMKFOBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xDE6830", Offset = "0xDE5230", VA = "0x180DE6830", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform FFCJDEBBGKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xDE6830", Offset = "0xDE5230", VA = "0x180DE6830", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform AJEFDBEKCIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xDE6830", Offset = "0xDE5230", VA = "0x180DE6830", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public GALLBHMJHEK NKANKIIJBHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x74925E0", Offset = "0x7490FE0", VA = "0x1874925E0")]
			get
			{
				return default(GALLBHMJHEK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x74941D0", Offset = "0x7492BD0", VA = "0x1874941D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool GADPAMAMFPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7492BF0", Offset = "0x74915F0", VA = "0x187492BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool PDLJPLJNAGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7492700", Offset = "0x7491100", VA = "0x187492700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public JJEINIEAKAA ECNMJPDBICD
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7492B30", Offset = "0x7491530", VA = "0x187492B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7494390", Offset = "0x7492D90", VA = "0x187494390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BJJKGMHOOAO ACAOJPDEBNB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7492AD0", Offset = "0x74914D0", VA = "0x187492AD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7494320", Offset = "0x7492D20", VA = "0x187494320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LCGAAJEHGII
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7492A20", Offset = "0x7491420", VA = "0x187492A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody FCBIBJMADMG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7492A80", Offset = "0x7491480", VA = "0x187492A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool MENJAPAJHKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7492760", Offset = "0x7491160", VA = "0x187492760")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7494240", Offset = "0x7492C40", VA = "0x187494240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool LHDJKJIOILH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x71635A0", Offset = "0x7161FA0", VA = "0x1871635A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float AMDGFJNPKMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7493490", Offset = "0x7491E90", VA = "0x187493490")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float GLKLENNKDJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7493430", Offset = "0x7491E30", VA = "0x187493430")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x74949B0", Offset = "0x74933B0", VA = "0x1874949B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float IJHMBBOGMEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7492E50", Offset = "0x7491850", VA = "0x187492E50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7494630", Offset = "0x7493030", VA = "0x187494630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float JFLELCGIBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7492C50", Offset = "0x7491650", VA = "0x187492C50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7494400", Offset = "0x7492E00", VA = "0x187494400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool JFKDHBBKCKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7493A70", Offset = "0x7492470", VA = "0x187493A70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7494F60", Offset = "0x7493960", VA = "0x187494F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 LNHNAMIBKIG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7493210", Offset = "0x7491C10", VA = "0x187493210")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7494780", Offset = "0x7493180", VA = "0x187494780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 KGJOHJIDBGF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7493BB0", Offset = "0x74925B0", VA = "0x187493BB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode BLAAKEOAHCF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7492D90", Offset = "0x7491790", VA = "0x187492D90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7494550", Offset = "0x7492F50", VA = "0x187494550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float IKPNNFFHMJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x74927C0", Offset = "0x74911C0", VA = "0x1874927C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x74942B0", Offset = "0x7492CB0", VA = "0x1874942B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints LFELAMOCLPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7492DF0", Offset = "0x74917F0", VA = "0x187492DF0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x74945C0", Offset = "0x7492FC0", VA = "0x1874945C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 BHGLABBCHOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x74935B0", Offset = "0x7491FB0", VA = "0x1874935B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 FIIGDMBKOLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x74935B0", Offset = "0x7491FB0", VA = "0x1874935B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7494D40", Offset = "0x7493740", VA = "0x187494D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NCBFNFENEGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x74932F0", Offset = "0x7491CF0", VA = "0x1874932F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7494860", Offset = "0x7493260", VA = "0x187494860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float JLPJMIILICL
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7493A10", Offset = "0x7492410", VA = "0x187493A10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7494EF0", Offset = "0x74938F0", VA = "0x187494EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion PFEIFHFJCOB
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7493690", Offset = "0x7492090", VA = "0x187493690")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7494AC0", Offset = "0x74934C0", VA = "0x187494AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion MIHHICGJLOE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7493930", Offset = "0x7492330", VA = "0x187493930")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7494E20", Offset = "0x7493820", VA = "0x187494E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 KLKNDINDCMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7493770", Offset = "0x7492170", VA = "0x187493770")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7494B90", Offset = "0x7493590", VA = "0x187494B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion AGGPAEMJGGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7493850", Offset = "0x7492250", VA = "0x187493850")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7494C70", Offset = "0x7493670", VA = "0x187494C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 FOPADPEODOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7493AD0", Offset = "0x74924D0", VA = "0x187493AD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7494FD0", Offset = "0x74939D0", VA = "0x187494FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 EANDNBDFHAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7493350", Offset = "0x7491D50", VA = "0x187493350")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x74948D0", Offset = "0x74932D0", VA = "0x1874948D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 FMPOKOCBLML
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7492CB0", Offset = "0x74916B0", VA = "0x187492CB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7494470", Offset = "0x7492E70", VA = "0x187494470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 FABHBEPNFKA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7493130", Offset = "0x7491B30", VA = "0x187493130")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x74946A0", Offset = "0x74930A0", VA = "0x1874946A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 ACCJDJLAHDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7492FF0", Offset = "0x74919F0", VA = "0x187492FF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion KAFODNIOJAG
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7492F10", Offset = "0x7491910", VA = "0x187492F10")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 IBHBADHIMNB
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7493D70", Offset = "0x7492770", VA = "0x187493D70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 COCLJOKNBBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7493C90", Offset = "0x7492690", VA = "0x187493C90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool MOMBAGMGJKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x74930D0", Offset = "0x7491AD0", VA = "0x1874930D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool HDGOEBJIEEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7492B90", Offset = "0x7491590", VA = "0x187492B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MFCCKPHMLOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x74926A0", Offset = "0x74910A0", VA = "0x1874926A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LNDJGKIFOMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7492640", Offset = "0x7491040", VA = "0x187492640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool HABDOFFELHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7492520", Offset = "0x7490F20", VA = "0x187492520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool FHMGLBCNJPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7492EB0", Offset = "0x74918B0", VA = "0x187492EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool NPNEBPFKOPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1C0CFA0", Offset = "0x1C0B9A0", VA = "0x181C0CFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event DGPNAMMLLPB OAMKEHADKEL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7492440", Offset = "0x7490E40", VA = "0x187492440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x74940F0", Offset = "0x7492AF0", VA = "0x1874940F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event BLAAMJOBEEE NCBJLMBEHFG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x74921B0", Offset = "0x7490BB0", VA = "0x1874921B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7493E50", Offset = "0x7492850", VA = "0x187493E50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event BLAAMJOBEEE LJAHMKBAAIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7492210", Offset = "0x7490C10", VA = "0x187492210")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7493EC0", Offset = "0x74928C0", VA = "0x187493EC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event BLAAMJOBEEE LKLCCIDKHCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7492360", Offset = "0x7490D60", VA = "0x187492360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7494010", Offset = "0x7492A10", VA = "0x187494010")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<DEMMDJFFENH, DEMMDJFFENH> NKBFNBGBAFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x74922F0", Offset = "0x7490CF0", VA = "0x1874922F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7493FA0", Offset = "0x74929A0", VA = "0x187493FA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event BLAAMJOBEEE BDJJGODMDGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x74923D0", Offset = "0x7490DD0", VA = "0x1874923D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7494080", Offset = "0x7492A80", VA = "0x187494080")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event BLAAMJOBEEE FJFHBEDPLCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x74924B0", Offset = "0x7490EB0", VA = "0x1874924B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7494160", Offset = "0x7492B60", VA = "0x187494160")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event BLAAMJOBEEE FFLCPLKELGO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7492280", Offset = "0x7490C80", VA = "0x187492280")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7493F30", Offset = "0x7492930", VA = "0x187493F30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD750", Offset = "0x8AC150", VA = "0x1808AD750", Slot = "8")]
		private void LDFIBNBMCFJ(EMDBJMNALPM OAAFMJBAJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7490700", Offset = "0x748F100", VA = "0x187490700")]
		internal void BDLGEJMEHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7491EE0", Offset = "0x74908E0", VA = "0x187491EE0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody ADBFMMMBPED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7490970", Offset = "0x748F370", VA = "0x187490970")]
		public PLAOFEANGHJ GetChild(int GCBONJOGHCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7491BB0", Offset = "0x74905B0", VA = "0x187491BB0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) KKAJDAFCIAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7490690", Offset = "0x748F090", VA = "0x187490690")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7490C20", Offset = "0x748F620", VA = "0x187490C20")]
		private EMDBJMNALPM IBBPAEIABHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7490CD0", Offset = "0x748F6D0", VA = "0x187490CD0")]
		private void IGMCENCOPJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7491380", Offset = "0x748FD80", VA = "0x187491380")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x74912C0", Offset = "0x748FCC0", VA = "0x1874912C0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7490700", Offset = "0x748F100", VA = "0x187490700")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7491320", Offset = "0x748FD20", VA = "0x187491320")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x74913E0", Offset = "0x748FDE0", VA = "0x1874913E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x748FD40", Offset = "0x748E740", VA = "0x18748FD40")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object AICEIDIHFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7491440", Offset = "0x748FE40", VA = "0x187491440")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object AICEIDIHFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7490910", Offset = "0x748F310", VA = "0x187490910")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7491260", Offset = "0x748FC60", VA = "0x187491260")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7491D10", Offset = "0x7490710", VA = "0x187491D10")]
		public void SetParent(RigidbodyEx PKCLPFEIPFH, bool IPPGFKCBGDF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7491750", Offset = "0x7490150", VA = "0x187491750")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7490EF0", Offset = "0x748F8F0", VA = "0x187490EF0")]
		public bool IsRigidbodyAncestor(RigidbodyEx PAEILBCCLFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7490FF0", Offset = "0x748F9F0", VA = "0x187490FF0")]
		public bool IsRigidbodyDescendant(RigidbodyEx MNDJIEJPDKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x748FFB0", Offset = "0x748E9B0", VA = "0x18748FFB0")]
		public void AddInterpolationRestriction(object AICEIDIHFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x74914B0", Offset = "0x748FEB0", VA = "0x1874914B0")]
		public void RemoveInterpolationRestriction(object AICEIDIHFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7490020", Offset = "0x748EA20", VA = "0x187490020")]
		public void AddKinematic(object AICEIDIHFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7491520", Offset = "0x748FF20", VA = "0x187491520")]
		public void RemoveKinematic(object AICEIDIHFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7491C90", Offset = "0x7490690", VA = "0x187491C90")]
		public void SetKinematic(object AICEIDIHFDO, bool FMLBLIGLDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7491AB0", Offset = "0x74904B0", VA = "0x187491AB0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 PLLEBMPNFEL, Quaternion FGKDIHJEKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x74919B0", Offset = "0x74903B0", VA = "0x1874919B0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 PEMNGFDEAMG, Quaternion GIPBDKHCLLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7490B10", Offset = "0x748F510", VA = "0x187490B10")]
		public Vector3 GetConstrainedVelocity(Vector3 FOPADPEODOF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7490A00", Offset = "0x748F400", VA = "0x187490A00")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 FMPOKOCBLML)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x748FEC0", Offset = "0x748E8C0", VA = "0x18748FEC0")]
		public void AddForce(Vector3 DEDPJAGPBOL, ForceMode CANGLBGJCPI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x748FDB0", Offset = "0x748E7B0", VA = "0x18748FDB0")]
		public void AddForceAtPosition(Vector3 DEDPJAGPBOL, Vector3 PCPIJKGKPCE, ForceMode CANGLBGJCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x74901F0", Offset = "0x748EBF0", VA = "0x1874901F0")]
		public void AddTorque(Vector3 CBJANMEJBGH, ForceMode CANGLBGJCPI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7490090", Offset = "0x748EA90", VA = "0x187490090")]
		public void AddRelativeTorque(Vector3 CBJANMEJBGH, ForceMode CANGLBGJCPI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7491FB0", Offset = "0x74909B0", VA = "0x187491FB0")]
		public Vector3 WorldToLocalVelocity(Vector3 OLMGFKCPIAD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7491150", Offset = "0x748FB50", VA = "0x187491150")]
		public Vector3 LocalToWorldVelocity(Vector3 EANDNBDFHAK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x74908B0", Offset = "0x748F2B0", VA = "0x1874908B0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7490850", Offset = "0x748F250", VA = "0x187490850")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x74907F0", Offset = "0x748F1F0", VA = "0x1874907F0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7490790", Offset = "0x748F190", VA = "0x187490790")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x74918B0", Offset = "0x74902B0", VA = "0x1874918B0")]
		public void ResetVelocityWorldSpace(Vector3 FBMAHADPHLI, Vector3 CNJKLEBNEPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x74917B0", Offset = "0x74901B0", VA = "0x1874917B0")]
		public void ResetVelocityLocalSpace(Vector3 OANMBMGADDF, Vector3 FABHBEPNFKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7491670", Offset = "0x7490070", VA = "0x187491670")]
		public void ResetLinearVelocityLocalSpace(Vector3 OANMBMGADDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7491E40", Offset = "0x7490840", VA = "0x187491E40")]
		public bool SweepTest(Vector3 GPCBHKJPHLL, [Out] RaycastHit HCINLPJJHIB, float FHNFOJHGAMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x74910F0", Offset = "0x748FAF0", VA = "0x1874910F0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7491DE0", Offset = "0x74907E0", VA = "0x187491DE0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7491F50", Offset = "0x7490950", VA = "0x187491F50")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7490180", Offset = "0x748EB80", VA = "0x187490180")]
		public void AddShouldHaveUnityRigidbodyToken(object AICEIDIHFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7491590", Offset = "0x748FF90", VA = "0x187491590")]
		public void RemoveShouldHaveUnityRigidbodyToken(object AICEIDIHFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7490520", Offset = "0x748EF20", VA = "0x187490520")]
		public void ApplyForceVelocityChange(KKJPMEMAAIK FCEHKBPNPGC, Vector3 MKNILOBHEGF, float EJFAFPILBDC, float LKIICJOHOKF = 8f, float IJKLJKHKJLJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7490480", Offset = "0x748EE80", VA = "0x187490480")]
		public void ApplyAngularVelocityChange(GMFDOIJJCHD CGOIMLAMHPC, Vector3 DMCEEOHELFI, float NNLBEODNLOO = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x74905E0", Offset = "0x748EFE0", VA = "0x1874905E0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(GMFDOIJJCHD CGOIMLAMHPC, Vector3 MHLCHCEFDAI, float PBNDEELCJLM = 7f, float ODIFALBIEHN = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x74903B0", Offset = "0x748EDB0", VA = "0x1874903B0")]
		public bool AllowedScaleChange(float BPHGKAKALMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x74902E0", Offset = "0x748ECE0", VA = "0x1874902E0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx GFPGCNCDHHH, object AICEIDIHFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7491600", Offset = "0x7490000", VA = "0x187491600")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object AICEIDIHFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7492140", Offset = "0x7490B40", VA = "0x187492140")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xD15EE0", Offset = "0xD148E0", VA = "0x180D15EE0", Slot = "4")]
		private GameObject LABHCKGJLBH()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class KAKEGNFLKFL
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7488370", Offset = "0x7486D70", VA = "0x187488370")]
	public static EMDBJMNALPM CKLHPFDBJPC(this RigidbodyEx IENODGFEGDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(BAGKGABDFPN), new string[] { })]
public class BEBPOEDNONB : BAGKGABDFPN, DCJNOFKEBGO
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private OCIHNPJKNKJ EPAHAMBEDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private POHKPODFKBK LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PHDGCDABAGM JOCHLDFCNHJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public POHKPODFKBK NBHKINAHGGI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PHDGCDABAGM DCJGJHLOHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x74802B0", Offset = "0x747ECB0", VA = "0x1874802B0", Slot = "7")]
	public void InitReferences(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7480220", Offset = "0x747EC20", VA = "0x187480220", Slot = "6")]
	public EMDBJMNALPM FJPEGLCEAKN(RigidbodyEx IENODGFEGDN, JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public BEBPOEDNONB()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static APNHDGDPKOI UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static APNHDGDPKOI AfterSyncTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int BLBBFCNBGAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int GGPJBHAFONN;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x748FB10", Offset = "0x748E510", VA = "0x18748FB10")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x748FBB0", Offset = "0x748E5B0", VA = "0x18748FBB0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x748FB30", Offset = "0x748E530", VA = "0x18748FB30")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string FCMDIEEAPHD, [Optional] UnityEngine.Object KMDNOIPDFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string FCMDIEEAPHD, [Optional] UnityEngine.Object KMDNOIPDFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x748FCF0", Offset = "0x748E6F0", VA = "0x18748FCF0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GKEDMPOFHGA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class MDHLGBBCJLC : JJEINIEAKAA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8BC880", Offset = "0x8BB280", VA = "0x1808BC880", Slot = "4")]
		public Vector3 MIAIPBNIDOG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8BC880", Offset = "0x8BB280", VA = "0x1808BC880", Slot = "5")]
		public Vector3 INLBOCEPIIN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public MDHLGBBCJLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static JJEINIEAKAA MOFFIJCLCGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x74857A0", Offset = "0x74841A0", VA = "0x1874857A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DDEIHFGCAKN
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CollisionDetectionMode CMGMHCINOBG
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
	void POAPKFKGGGK();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NACJJBOJHAP(bool MOMBAGMGJKP);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBFBAKHANJH(bool MOMBAGMGJKP);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PJKJGDBGKEH(Rigidbody LAOKNIPNNGA);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PAHLANEJDEJ(Vector3 GPCBHKJPHLL, [Out] RaycastHit HCINLPJJHIB, float FHNFOJHGAMK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BHLCFOJDBOB : IDisposable, LFILLLADNAC
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	GALLBHMJHEK NKANKIIJBHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<DEMMDJFFENH, DEMMDJFFENH> NKBFNBGBAFG;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void POAPKFKGGGK();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface PHDGCDABAGM
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ILGBNFHCIEB DLHFDKKPIFH(EMDBJMNALPM OAAFMJBAJGL);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JIBNMBLKEBB LCMGEGCLONK(EMDBJMNALPM OAAFMJBAJGL);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NPPALMBMLIC OIDAKKDFHIN(EMDBJMNALPM OAAFMJBAJGL);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AJCGLEKKFBF FJLFKAAEGCH(EMDBJMNALPM OAAFMJBAJGL);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPFLOHDBNLA NPOOLBOJEOL(EMDBJMNALPM OAAFMJBAJGL);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BHLCFOJDBOB MLOEDFIJBPC(EMDBJMNALPM OAAFMJBAJGL);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EFPOOJKIJOG FDHKEDLNBCD(EMDBJMNALPM OAAFMJBAJGL);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HJLOADKOONE EPHBBFBEKDI(EMDBJMNALPM OAAFMJBAJGL);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DDEIHFGCAKN KFGEODBLPAK(EMDBJMNALPM OAAFMJBAJGL);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MCCJOBJCMBM NMJEHOPHIEE(EMDBJMNALPM OAAFMJBAJGL);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GJHPBEBEHCE IKDAJPNGHEO(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BAMOAHHDCCC NGKFPBEFMAK(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FNAPAJCHKEB JAGBNDHJPNB(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IIKOCPHBMNK KICFJJCJJKJ(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MEJOFGOJLKB JDHNGLCELNI(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EMDBJMNALPM FJPEGLCEAKN(RigidbodyEx IENODGFEGDN, JBINEELBOCE GGEMPJLCHFC, BAGKGABDFPN PLJBPLDMFHL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HJLOADKOONE
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHMBEIJKPMH(Vector3 DEDPJAGPBOL, ForceMode CANGLBGJCPI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAFLKMCMKBG(Vector3 DEDPJAGPBOL, Vector3 PCPIJKGKPCE, ForceMode CANGLBGJCPI);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPDOIKPEDBI(Vector3 CBJANMEJBGH, ForceMode CANGLBGJCPI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BHCHLDCHHFL(Vector3 CBJANMEJBGH, ForceMode CANGLBGJCPI = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MCCJOBJCMBM
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool LPFIGPLMNDA
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
	void PJKJGDBGKEH(Rigidbody LAOKNIPNNGA);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HOAAGADNBMC(Rigidbody LAOKNIPNNGA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ILGBNFHCIEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	IReadOnlyList<EMDBJMNALPM> FKKBFLEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	EMDBJMNALPM BPFDMKBMANG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	EMDBJMNALPM NBMBHAFDNEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event BLAAMJOBEEE NCBJLMBEHFG;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event BLAAMJOBEEE LJAHMKBAAIB;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event DGPNAMMLLPB PDDBENPFEPL;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action FEHPDLLKCIM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action DGHPPEHFMIF;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<EMDBJMNALPM> HFNBJMNLEKJ;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<EMDBJMNALPM> BKADNMJHLGB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action PKIIOPKEIOH;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<EMDBJMNALPM> FDNJOFBPPJG;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IDPLHFEAHGA(EMDBJMNALPM AOBPGDDFDPP, bool IPPGFKCBGDF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NPPALMBMLIC
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 EPJFKHCBLCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 CEHEIBFKKOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HKBGFGOJEON(EMDBJMNALPM NNFBEGDDJKL, object AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FFNJBPJAKJG(object AICEIDIHFDO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IIKOCPHBMNK
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 AHOBNOJHENE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 HDLBEGIIEFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float GIIBDOCINFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float PFJKDDDJDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Vector3 IHGNAKKEGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Quaternion KPFPNKFBJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event BLAAMJOBEEE JIHLKOMLNNH;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IEPGNEHCFEJ((Quaternion rot, Vector3 moments) KKAJDAFCIAC);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OODODGDCHBB();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CHBMIBIEJPP();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DLIODOCICLA();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PJKJGDBGKEH(Rigidbody LAOKNIPNNGA);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HOAAGADNBMC(Rigidbody LAOKNIPNNGA);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CECLIFIGODF();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FNAPAJCHKEB
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POAPKFKGGGK();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCLJEKODOGI(object AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFOJHJPIBIB(object AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GFBHNMALNPP(EMDBJMNALPM IENODGFEGDN);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FGAJEBGGDED(EMDBJMNALPM IENODGFEGDN);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LHOOMNMMBIP();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EFPOOJKIJOG
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool JJCHKHAJCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event BLAAMJOBEEE GNNFAOIGKGM;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BJEICFOFOPJ(object AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FAAMKFNFGMK(object AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MJFNHNBOHCA(object AICEIDIHFDO, bool FMLBLIGLDAH);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PJKJGDBGKEH(Rigidbody PILKPKKMGBO);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HOAAGADNBMC(Rigidbody LAOKNIPNNGA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BAMOAHHDCCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool GADPAMAMFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool PDLJPLJNAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event BLAAMJOBEEE MPNCCFFFFBP;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void POAPKFKGGGK();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MJKFKOIHMCG(EMDBJMNALPM NNFBEGDDJKL);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BBCFEBHLHFO(EMDBJMNALPM NNFBEGDDJKL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MEJOFGOJLKB
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool MENJAPAJHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool KCFPCMINNPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	RigidbodyConstraints DBJKAAHHHHA
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
	void PJKJGDBGKEH(Rigidbody LAOKNIPNNGA);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HOAAGADNBMC(Rigidbody LAOKNIPNNGA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AJCGLEKKFBF
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float MGKIELOGHHP
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float JDKPBHKKMLB
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
	void PJKJGDBGKEH(Rigidbody LAOKNIPNNGA);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HOAAGADNBMC(Rigidbody LAOKNIPNNGA);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DPFLOHDBNLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	static bool FKGBMACPFPB;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event BLAAMJOBEEE HOBFPBHLJJH;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POAPKFKGGGK();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AGJPHHNBENE();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GPEIBAIFBKL();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PPHLEEINLKK();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JLCEFJGMAHI();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool AMIOKLMGIAL();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LPNCALMJDNO(bool KEDHDANCMIE);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KENOEKIHLML();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GJHPBEBEHCE
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	Rigidbody FCBIBJMADMG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool OCMMMDPDPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POAPKFKGGGK();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IOKBKGFNBPE(object AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPGCLCKCEII(object AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LAFEHIMCOAB();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JIBNMBLKEBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	JJEINIEAKAA ECNMJPDBICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	BJJKGMHOOAO ACAOJPDEBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 PPNKKHAMFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 NMOHGCEFAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 HGNJJNFMGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 CIEAHJKCIAF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float IKPNNFFHMJP
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool LCGAAJEHGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void POAPKFKGGGK();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PBLMEEKDKGH(object AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EKDNDOCPGKO(GMFDOIJJCHD CGOIMLAMHPC, Vector3 DMCEEOHELFI, float NNLBEODNLOO = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JCDHLOBADCA(KKJPMEMAAIK FCEHKBPNPGC, Vector3 MKNILOBHEGF, float EJFAFPILBDC, float LKIICJOHOKF = 8f, float IJKLJKHKJLJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BDIABJAJDLG(GMFDOIJJCHD CGOIMLAMHPC, Vector3 MHLCHCEFDAI, float PBNDEELCJLM = 7f, float ODIFALBIEHN = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LMDHPCGCNPE();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MGGAMOMIHGC();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IJAONGNMNCH();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EDEFKNBFHID();

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PJKJGDBGKEH(Rigidbody LAOKNIPNNGA);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 HFFKFPNDNMK(Vector3 FOPADPEODOF);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CFKPDPKNIBL(object AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LACGMGEGMJN(Vector3 OBENCGMBKHP);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OCBKHLCDJCG(Vector3 OANMBMGADDF, Vector3 FABHBEPNFKA);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KLOIDLONHHL(Vector3 FBMAHADPHLI, Vector3 CNJKLEBNEPP);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 PFJCCGNMAEC(Vector3 EANDNBDFHAK);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 KDLALPJKADG(Vector3 OLMGFKCPIAD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface POHKPODFKBK
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool CPGDCCKAHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNBCCPDGBGI(string BHAOKKINJPA);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JLBAMCLOBPE(RigidbodyEx IENODGFEGDN, Action EFFBNJEBEKP);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PALGLEFKFHF GAJGLGAIHNG(int ODIALMGLNPL);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCMNJKHPHIN(Vector3 KGJOHJIDBGF, float CHNBAENDLIH, Color GNADFIPFMAK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface BAGKGABDFPN
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	POHKPODFKBK NBHKINAHGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	PHDGCDABAGM DCJGJHLOHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EMDBJMNALPM FJPEGLCEAKN(RigidbodyEx IENODGFEGDN, JBINEELBOCE GGEMPJLCHFC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AGHIFENMFLP : EMDBJMNALPM, IDisposable, ABPBDHDGDKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly BAGKGABDFPN PLJBPLDMFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal ILGBNFHCIEB CGCEELNOAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal FNAPAJCHKEB ABBJKCNAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal BAMOAHHDCCC GMBIGMMKCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal JIBNMBLKEBB FOPADPEODOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal NPPALMBMLIC GFBCLGMPBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal IIKOCPHBMNK IIGHEGMFFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal AJCGLEKKFBF EDBBJHMHFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal MCCJOBJCMBM MHCEDKPEOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal DPFLOHDBNLA JMGAHNBMPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal BHLCFOJDBOB KGLDHJEIENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal EFPOOJKIJOG FODEAEPDPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal HJLOADKOONE DEDPJAGPBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal MEJOFGOJLKB GOKCEPLCGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal GJHPBEBEHCE LAOKNIPNNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal DDEIHFGCAKN GIDBBLELAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable BBDBEJDIKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool LBKBCGMANPP;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public PPOLLJKPCNH MDFEOCGBIGF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "22")]
		get
		{
			return default(PPOLLJKPCNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public PLAOFEANGHJ DGGJCJBFJJP
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9FF200", Offset = "0x9FDC00", VA = "0x1809FF200", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9FF250", Offset = "0x9FDC50", VA = "0x1809FF250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public GameObject LCAKBKAANHO
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8B69A0", Offset = "0x8B53A0", VA = "0x1808B69A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6910", Offset = "0x8B5310", VA = "0x1808B6910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Transform DNOKGDKBFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9824B0", Offset = "0x980EB0", VA = "0x1809824B0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA0F4D0", Offset = "0xA0DED0", VA = "0x180A0F4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Rigidbody FCBIBJMADMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x747EC60", Offset = "0x747D660", VA = "0x18747EC60", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public EMDBJMNALPM NBMBHAFDNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x74798E0", Offset = "0x74782E0", VA = "0x1874798E0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x747A160", Offset = "0x7478B60", VA = "0x18747A160", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int GHOKDFBENLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x747FB30", Offset = "0x747E530", VA = "0x18747FB30", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public EMDBJMNALPM BPFDMKBMANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x747D730", Offset = "0x747C130", VA = "0x18747D730", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool GOAPGGKHPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x747EF90", Offset = "0x747D990", VA = "0x18747EF90", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool GADPAMAMFPB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x747D020", Offset = "0x747BA20", VA = "0x18747D020", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool PDLJPLJNAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x747B250", Offset = "0x7479C50", VA = "0x18747B250", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public JJEINIEAKAA ECNMJPDBICD
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x74799E0", Offset = "0x74783E0", VA = "0x1874799E0", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x747F120", Offset = "0x747DB20", VA = "0x18747F120", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public BJJKGMHOOAO ACAOJPDEBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x747A6D0", Offset = "0x74790D0", VA = "0x18747A6D0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x747DD60", Offset = "0x747C760", VA = "0x18747DD60", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public float IKPNNFFHMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x747A7C0", Offset = "0x74791C0", VA = "0x18747A7C0", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x747EA90", Offset = "0x747D490", VA = "0x18747EA90", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 NMOHGCEFAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x747F660", Offset = "0x747E060", VA = "0x18747F660", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x747E7B0", Offset = "0x747D1B0", VA = "0x18747E7B0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 CIEAHJKCIAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x747C6C0", Offset = "0x747B0C0", VA = "0x18747C6C0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x747F350", Offset = "0x747DD50", VA = "0x18747F350", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 PPNKKHAMFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x747E470", Offset = "0x747CE70", VA = "0x18747E470", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7479800", Offset = "0x7478200", VA = "0x187479800", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 HGNJJNFMGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x747C340", Offset = "0x747AD40", VA = "0x18747C340", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x747B810", Offset = "0x747A210", VA = "0x18747B810", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool MFCCKPHMLOB
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x747CEC0", Offset = "0x747B8C0", VA = "0x18747CEC0", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool LNDJGKIFOMK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x747E9D0", Offset = "0x747D3D0", VA = "0x18747E9D0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool HABDOFFELHD
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x747C150", Offset = "0x747AB50", VA = "0x18747C150", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool LCGAAJEHGII
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7479930", Offset = "0x7478330", VA = "0x187479930", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 EPJFKHCBLCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x747E550", Offset = "0x747CF50", VA = "0x18747E550", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 CEHEIBFKKOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x747F580", Offset = "0x747DF80", VA = "0x18747F580", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 AHOBNOJHENE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x747D390", Offset = "0x747BD90", VA = "0x18747D390", Slot = "54")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x747CD20", Offset = "0x747B720", VA = "0x18747CD20", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 HDLBEGIIEFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x747DE20", Offset = "0x747C820", VA = "0x18747DE20", Slot = "56")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float GIIBDOCINFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x747B950", Offset = "0x747A350", VA = "0x18747B950", Slot = "57")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float PFJKDDDJDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7479A30", Offset = "0x7478430", VA = "0x187479A30", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x747D070", Offset = "0x747BA70", VA = "0x18747D070", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Vector3 IHGNAKKEGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x747D140", Offset = "0x747BB40", VA = "0x18747D140", Slot = "60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Quaternion KPFPNKFBJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x747AE00", Offset = "0x7479800", VA = "0x18747AE00", Slot = "61")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float MGKIELOGHHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x747CFD0", Offset = "0x747B9D0", VA = "0x18747CFD0", Slot = "63")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x747C620", Offset = "0x747B020", VA = "0x18747C620", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float JDKPBHKKMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x74797B0", Offset = "0x74781B0", VA = "0x1874797B0", Slot = "65")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7479980", Offset = "0x7478380", VA = "0x187479980", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public bool LPFIGPLMNDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x747A950", Offset = "0x7479350", VA = "0x18747A950", Slot = "67")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x747C900", Offset = "0x747B300", VA = "0x18747C900", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public GALLBHMJHEK NKANKIIJBHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x747EF40", Offset = "0x747D940", VA = "0x18747EF40", Slot = "69")]
		get
		{
			return default(GALLBHMJHEK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x747E080", Offset = "0x747CA80", VA = "0x18747E080", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public bool JJCHKHAJCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x747C2F0", Offset = "0x747ACF0", VA = "0x18747C2F0", Slot = "71")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Transform AJEFDBEKCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x9824B0", Offset = "0x980EB0", VA = "0x1809824B0", Slot = "72")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Vector3 CKGGBMOJAHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x747B2A0", Offset = "0x7479CA0", VA = "0x18747B2A0", Slot = "73")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x747B510", Offset = "0x7479F10", VA = "0x18747B510", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float ADJELPJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x747D0D0", Offset = "0x747BAD0", VA = "0x18747D0D0", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x747E890", Offset = "0x747D290", VA = "0x18747E890", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float PJHFMEAGLEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x747E460", Offset = "0x747CE60", VA = "0x18747E460", Slot = "77")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x747F210", Offset = "0x747DC10", VA = "0x18747F210", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Quaternion DJLLDBFMJAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x747D220", Offset = "0x747BC20", VA = "0x18747D220", Slot = "79")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x747CB60", Offset = "0x747B560", VA = "0x18747CB60", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Vector3 IOMJHJIHLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x747C680", Offset = "0x747B080", VA = "0x18747C680", Slot = "81")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x747AD60", Offset = "0x7479760", VA = "0x18747AD60", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Quaternion FGEPHFKCKHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x747C230", Offset = "0x747AC30", VA = "0x18747C230", Slot = "83")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x747CC90", Offset = "0x747B690", VA = "0x18747CC90", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public RigidbodyConstraints DBJKAAHHHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x747C5D0", Offset = "0x747AFD0", VA = "0x18747C5D0", Slot = "85")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x747EDF0", Offset = "0x747D7F0", VA = "0x18747EDF0", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public bool MENJAPAJHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x747D470", Offset = "0x747BE70", VA = "0x18747D470", Slot = "87")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x747DDC0", Offset = "0x747C7C0", VA = "0x18747DDC0", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public CollisionDetectionMode CMGMHCINOBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x747DA80", Offset = "0x747C480", VA = "0x18747DA80", Slot = "89")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x747A8F0", Offset = "0x74792F0", VA = "0x18747A8F0", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool NDEPCDPFHME
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x747ECB0", Offset = "0x747D6B0", VA = "0x18747ECB0", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool HDGOEBJIEEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x747DF00", Offset = "0x747C900", VA = "0x18747DF00", Slot = "91")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event BLAAMJOBEEE NCBJLMBEHFG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x747D4C0", Offset = "0x747BEC0", VA = "0x18747D4C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x747EA30", Offset = "0x747D430", VA = "0x18747EA30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event BLAAMJOBEEE LJAHMKBAAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x747EC00", Offset = "0x747D600", VA = "0x18747EC00", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x747F930", Offset = "0x747E330", VA = "0x18747F930", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event DGPNAMMLLPB PDDBENPFEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x747C960", Offset = "0x747B360", VA = "0x18747C960", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x747B8F0", Offset = "0x747A2F0", VA = "0x18747B8F0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event BLAAMJOBEEE MPNCCFFFFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x747DBC0", Offset = "0x747C5C0", VA = "0x18747DBC0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x747E900", Offset = "0x747D300", VA = "0x18747E900", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event BLAAMJOBEEE LKLCCIDKHCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x747CCC0", Offset = "0x747B6C0", VA = "0x18747CCC0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x747E140", Offset = "0x747CB40", VA = "0x18747E140", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event BLAAMJOBEEE HOBFPBHLJJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x747F8D0", Offset = "0x747E2D0", VA = "0x18747F8D0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x747C290", Offset = "0x747AC90", VA = "0x18747C290", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<DEMMDJFFENH, DEMMDJFFENH> NKBFNBGBAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x747E0E0", Offset = "0x747CAE0", VA = "0x18747E0E0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x747ADA0", Offset = "0x74797A0", VA = "0x18747ADA0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event BLAAMJOBEEE GNNFAOIGKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x747DC20", Offset = "0x747C620", VA = "0x18747DC20", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x747F480", Offset = "0x747DE80", VA = "0x18747F480", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event BLAAMJOBEEE FFLCPLKELGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x747C420", Offset = "0x747AE20", VA = "0x18747C420", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x747D9D0", Offset = "0x747C3D0", VA = "0x18747D9D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x747FC30", Offset = "0x747E630", VA = "0x18747FC30")]
	public AGHIFENMFLP(GameObject NJFNKLJIFDE, RigidbodyEx NDJKCCIODDI, BAGKGABDFPN PLJBPLDMFHL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x747B9A0", Offset = "0x747A3A0", VA = "0x18747B9A0", Slot = "138")]
	protected virtual void FMDNDAKLPJE(BAGKGABDFPN PLJBPLDMFHL, JBINEELBOCE GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x747B3A0", Offset = "0x7479DA0", VA = "0x18747B3A0", Slot = "139")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x747F9F0", Offset = "0x747E3F0", VA = "0x18747F9F0", Slot = "92")]
	public void POAPKFKGGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x747F840", Offset = "0x747E240", VA = "0x18747F840", Slot = "93")]
	public void PGCGCBNPLCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x747C0F0", Offset = "0x747AAF0", VA = "0x18747C0F0", Slot = "94")]
	public void GCOFPPAKMDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x747C270", Offset = "0x747AC70", VA = "0x18747C270", Slot = "95")]
	public void GLAIFLPDBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x747E1F0", Offset = "0x747CBF0", VA = "0x18747E1F0")]
	private void LPNCALMJDNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x747A590", Offset = "0x7478F90", VA = "0x18747A590")]
	private void BIOGFNMMIHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x747A100", Offset = "0x7478B00", VA = "0x18747A100")]
	private void AMIOKLMGIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x747F0A0", Offset = "0x747DAA0", VA = "0x18747F0A0", Slot = "30")]
	public EMDBJMNALPM OLBCECPDEAH(int GCBONJOGHCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x747CA10", Offset = "0x747B410", VA = "0x18747CA10", Slot = "97")]
	public void IDPLHFEAHGA(EMDBJMNALPM PKCLPFEIPFH, bool IPPGFKCBGDF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x747F2F0", Offset = "0x747DCF0", VA = "0x18747F2F0", Slot = "98")]
	public void OMIABCIINMP(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x747F990", Offset = "0x747E390", VA = "0x18747F990", Slot = "99")]
	public void PLDNBDIGDAI(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x747D630", Offset = "0x747C030", VA = "0x18747D630", Slot = "100")]
	public Vector3 KDLALPJKADG(Vector3 OLMGFKCPIAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x747F740", Offset = "0x747E140", VA = "0x18747F740", Slot = "101")]
	public Vector3 PFJCCGNMAEC(Vector3 EANDNBDFHAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x747B4C0", Offset = "0x7479EC0", VA = "0x18747B4C0", Slot = "102")]
	public void EDEFKNBFHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x747E620", Offset = "0x747D020", VA = "0x18747E620", Slot = "103")]
	public void MGGAMOMIHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x747E1A0", Offset = "0x747CBA0", VA = "0x18747E1A0", Slot = "104")]
	public void LMDHPCGCNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x747DAD0", Offset = "0x747C4D0", VA = "0x18747DAD0", Slot = "105")]
	public void KLOIDLONHHL(Vector3 FBMAHADPHLI, Vector3 CNJKLEBNEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x747EE50", Offset = "0x747D850", VA = "0x18747EE50", Slot = "106")]
	public void OCBKHLCDJCG(Vector3 OANMBMGADDF, Vector3 FABHBEPNFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x747DC80", Offset = "0x747C680", VA = "0x18747DC80", Slot = "107")]
	public void LACGMGEGMJN(Vector3 OBENCGMBKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x747CF10", Offset = "0x747B910", VA = "0x18747CF10", Slot = "108")]
	public void JCDHLOBADCA(KKJPMEMAAIK FCEHKBPNPGC, Vector3 MKNILOBHEGF, float EJFAFPILBDC, float LKIICJOHOKF = 8f, float IJKLJKHKJLJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x747B5C0", Offset = "0x7479FC0", VA = "0x18747B5C0", Slot = "109")]
	public void EKDNDOCPGKO(GMFDOIJJCHD CGOIMLAMHPC, Vector3 DMCEEOHELFI, float NNLBEODNLOO = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x747A400", Offset = "0x7478E00", VA = "0x18747A400", Slot = "110")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void BDIABJAJDLG(GMFDOIJJCHD CGOIMLAMHPC, Vector3 MHLCHCEFDAI, float PBNDEELCJLM = 7f, float ODIFALBIEHN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x747C4D0", Offset = "0x747AED0", VA = "0x18747C4D0", Slot = "111")]
	public Vector3 HFFKFPNDNMK(Vector3 PKCLPFEIPFH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x747BFF0", Offset = "0x747A9F0", VA = "0x18747BFF0", Slot = "112")]
	public Vector3 GAGILMCFBAE(Vector3 PKCLPFEIPFH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x747CC40", Offset = "0x747B640", VA = "0x18747CC40", Slot = "113")]
	public void IJAONGNMNCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x747E960", Offset = "0x747D360", VA = "0x18747E960", Slot = "114")]
	public void NEODKHBLGHG(EMDBJMNALPM GFPGCNCDHHH, object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x747D0E0", Offset = "0x747BAE0", VA = "0x18747D0E0", Slot = "115")]
	public void JHHPMCOCFLA(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x747CA80", Offset = "0x747B480", VA = "0x18747CA80", Slot = "62")]
	public void IEPGNEHCFEJ((Quaternion rot, Vector3 moments) KKAJDAFCIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x747A770", Offset = "0x7479170", VA = "0x18747A770", Slot = "116")]
	public void CHBMIBIEJPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x747F430", Offset = "0x747DE30", VA = "0x18747F430", Slot = "117")]
	public void OODODGDCHBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x747B350", Offset = "0x7479D50", VA = "0x18747B350", Slot = "118")]
	public void DLIODOCICLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7479A80", Offset = "0x7478480", VA = "0x187479A80", Slot = "119")]
	public bool AGJPHHNBENE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x747FBA0", Offset = "0x747E5A0", VA = "0x18747FBA0", Slot = "96")]
	public void PPHLEEINLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x747D780", Offset = "0x747C180", VA = "0x18747D780", Slot = "120")]
	public void KENOEKIHLML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x747A610", Offset = "0x7479010", VA = "0x18747A610", Slot = "121")]
	public void BJEICFOFOPJ(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x747B7B0", Offset = "0x747A1B0", VA = "0x18747B7B0", Slot = "122")]
	public void FAAMKFNFGMK(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x747E670", Offset = "0x747D070", VA = "0x18747E670", Slot = "123")]
	public void MJFNHNBOHCA(object AICEIDIHFDO, bool FMLBLIGLDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x747D7D0", Offset = "0x747C1D0", VA = "0x18747D7D0", Slot = "124")]
	public void KFFIAGMEOOF(Vector3 PLLEBMPNFEL, Quaternion FGKDIHJEKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x747AC30", Offset = "0x7479630", VA = "0x18747AC30", Slot = "125")]
	public void DAEKGIIBKMN(Vector3 PEMNGFDEAMG, Quaternion GIPBDKHCLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x747C9C0", Offset = "0x747B3C0", VA = "0x18747C9C0", Slot = "126")]
	public bool ICCMLKBJBPN(float BPHGKAKALMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x747A670", Offset = "0x7479070", VA = "0x18747A670", Slot = "127")]
	public void BOPLBAJFAKH(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x747A3A0", Offset = "0x7478DA0", VA = "0x18747A3A0", Slot = "128")]
	public void BBMOKNELFCC(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x747CE00", Offset = "0x747B800", VA = "0x18747CE00", Slot = "129")]
	public void IOKBKGFNBPE(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x747CE60", Offset = "0x747B860", VA = "0x18747CE60", Slot = "130")]
	public void IPGCLCKCEII(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x747A810", Offset = "0x7479210", VA = "0x18747A810", Slot = "131")]
	public void CHMBEIJKPMH(Vector3 DEDPJAGPBOL, ForceMode CANGLBGJCPI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x747A1C0", Offset = "0x7478BC0", VA = "0x18747A1C0", Slot = "132")]
	public void BAFLKMCMKBG(Vector3 DEDPJAGPBOL, Vector3 PCPIJKGKPCE, ForceMode CANGLBGJCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x747AB50", Offset = "0x7479550", VA = "0x18747AB50", Slot = "133")]
	public void CPDOIKPEDBI(Vector3 CBJANMEJBGH, ForceMode CANGLBGJCPI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x747A4B0", Offset = "0x7478EB0", VA = "0x18747A4B0", Slot = "134")]
	public void BHCHLDCHHFL(Vector3 CBJANMEJBGH, ForceMode CANGLBGJCPI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x747F4E0", Offset = "0x747DEE0", VA = "0x18747F4E0", Slot = "135")]
	public bool PAHLANEJDEJ(Vector3 GPCBHKJPHLL, [Out] RaycastHit HCINLPJJHIB, float FHNFOJHGAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x747A720", Offset = "0x7479120", VA = "0x18747A720", Slot = "136")]
	public void CECLIFIGODF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x747FBF0", Offset = "0x747E5F0", VA = "0x18747FBF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x747D2C0", Offset = "0x747BCC0", VA = "0x18747D2C0")]
	private void JLIDCAMENEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x747EAF0", Offset = "0x747D4F0", VA = "0x18747EAF0")]
	private void NNNODPFEMJM(EMDBJMNALPM NNFBEGDDJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7479AD0", Offset = "0x74784D0", VA = "0x187479AD0")]
	private void AKLEGLODHJG(EMDBJMNALPM NNFBEGDDJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x747EFF0", Offset = "0x747D9F0", VA = "0x18747EFF0")]
	private void OHIDIMHHNDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7479690", Offset = "0x7478090", VA = "0x187479690")]
	private void AAECOFMPHFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x747A9A0", Offset = "0x74793A0", VA = "0x18747A9A0")]
	private void CKAICMBAODO(EMDBJMNALPM KBEMHCJOEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x747E6E0", Offset = "0x747D0E0", VA = "0x18747E6E0")]
	private void MJKFKOIHMCG(EMDBJMNALPM NNFBEGDDJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x747A2D0", Offset = "0x7478CD0", VA = "0x18747A2D0")]
	private void BBCFEBHLHFO(EMDBJMNALPM NNFBEGDDJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x747B660", Offset = "0x747A060", VA = "0x18747B660")]
	private void EKPPDCADENI(PLAOFEANGHJ NNFBEGDDJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7479CB0", Offset = "0x74786B0", VA = "0x187479CB0", Slot = "142")]
	protected virtual void ALEOMBBOOPL(PLAOFEANGHJ IENODGFEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x747BC90", Offset = "0x747A690", VA = "0x18747BC90")]
	protected void FOGHKEMMCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x747AED0", Offset = "0x74798D0", VA = "0x18747AED0")]
	protected void DJJCBNHKEEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x747D520", Offset = "0x747BF20", VA = "0x18747D520")]
	private void KCIFOIBPFLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x747C7A0", Offset = "0x747B1A0", VA = "0x18747C7A0")]
	private void HMJCDNOLEMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class KPIBBIAEGAB
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x748AE20", Offset = "0x7489820", VA = "0x18748AE20")]
	public static EMDBJMNALPM GBLKGOOAMBI(this EMDBJMNALPM IENODGFEGDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x748AF50", Offset = "0x7489950", VA = "0x18748AF50")]
	public static bool NHFFENJINGK(this EMDBJMNALPM IENODGFEGDN, EMDBJMNALPM PAEILBCCLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x748AD80", Offset = "0x7489780", VA = "0x18748AD80")]
	public static bool BGPIBEFDANH(this EMDBJMNALPM IENODGFEGDN, EMDBJMNALPM MNDJIEJPDKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x748AFF0", Offset = "0x74899F0", VA = "0x18748AFF0")]
	public static PLAOFEANGHJ OIMIODGOBFK(this EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x748AEE0", Offset = "0x74898E0", VA = "0x18748AEE0")]
	public static AGHIFENMFLP HENAOOHCJCI(this EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IICLONBOIBD : PHDGCDABAGM
{
	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7486BC0", Offset = "0x74855C0", VA = "0x187486BC0", Slot = "19")]
	public EMDBJMNALPM FJPEGLCEAKN(RigidbodyEx IENODGFEGDN, JBINEELBOCE GGEMPJLCHFC, BAGKGABDFPN PLJBPLDMFHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "4")]
	public ILGBNFHCIEB DLHFDKKPIFH(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "5")]
	public JIBNMBLKEBB LCMGEGCLONK(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "6")]
	public NPPALMBMLIC OIDAKKDFHIN(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "7")]
	public AJCGLEKKFBF FJLFKAAEGCH(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "8")]
	public DPFLOHDBNLA NPOOLBOJEOL(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "9")]
	public BHLCFOJDBOB MLOEDFIJBPC(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "10")]
	public EFPOOJKIJOG FDHKEDLNBCD(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "11")]
	public HJLOADKOONE EPHBBFBEKDI(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "12")]
	public DDEIHFGCAKN KFGEODBLPAK(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "13")]
	public MCCJOBJCMBM NMJEHOPHIEE(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60")]
	public GJHPBEBEHCE IKDAJPNGHEO(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60")]
	public BAMOAHHDCCC NGKFPBEFMAK(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60")]
	public FNAPAJCHKEB JAGBNDHJPNB(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60")]
	public IIKOCPHBMNK KICFJJCJJKJ(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60")]
	public MEJOFGOJLKB JDHNGLCELNI(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public IICLONBOIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "14")]
	private GJHPBEBEHCE ELELGOJMNCA(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "15")]
	private BAMOAHHDCCC MJIGEOFLBKE(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "16")]
	private FNAPAJCHKEB KHKHKDDFDJK(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "17")]
	private IIKOCPHBMNK EOLLCFPOGFB(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "18")]
	private MEJOFGOJLKB IAFFLOPDDDE(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(PHDGCDABAGM), new string[] { })]
public class MMFMGGLHKAN : PHDGCDABAGM, DCJNOFKEBGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly PHDGCDABAGM LPMCCJFDBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly PHDGCDABAGM ECCBINLOMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private OCIHNPJKNKJ EPAHAMBEDDO;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private PHDGCDABAGM DCJGJHLOHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x748DF40", Offset = "0x748C940", VA = "0x18748DF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x748E510", Offset = "0x748CF10", VA = "0x18748E510", Slot = "20")]
	public void InitReferences(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x748DFA0", Offset = "0x748C9A0", VA = "0x18748DFA0", Slot = "4")]
	public ILGBNFHCIEB DLHFDKKPIFH(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x748E6B0", Offset = "0x748D0B0", VA = "0x18748E6B0", Slot = "5")]
	public JIBNMBLKEBB LCMGEGCLONK(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x748E9E0", Offset = "0x748D3E0", VA = "0x18748E9E0", Slot = "6")]
	public NPPALMBMLIC OIDAKKDFHIN(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x748E2E0", Offset = "0x748CCE0", VA = "0x18748E2E0", Slot = "7")]
	public AJCGLEKKFBF FJLFKAAEGCH(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x748E940", Offset = "0x748D340", VA = "0x18748E940", Slot = "8")]
	public DPFLOHDBNLA NPOOLBOJEOL(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x748E800", Offset = "0x748D200", VA = "0x18748E800", Slot = "9")]
	public BHLCFOJDBOB MLOEDFIJBPC(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x748E240", Offset = "0x748CC40", VA = "0x18748E240", Slot = "10")]
	public EFPOOJKIJOG FDHKEDLNBCD(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x748E1A0", Offset = "0x748CBA0", VA = "0x18748E1A0", Slot = "11")]
	public HJLOADKOONE EPHBBFBEKDI(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x748E610", Offset = "0x748D010", VA = "0x18748E610", Slot = "12")]
	public DDEIHFGCAKN KFGEODBLPAK(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x748E8A0", Offset = "0x748D2A0", VA = "0x18748E8A0", Slot = "13")]
	public MCCJOBJCMBM NMJEHOPHIEE(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x748E040", Offset = "0x748CA40", VA = "0x18748E040")]
	public GJHPBEBEHCE IKDAJPNGHEO(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x748E750", Offset = "0x748D150", VA = "0x18748E750")]
	public BAMOAHHDCCC NGKFPBEFMAK(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x748E560", Offset = "0x748CF60", VA = "0x18748E560")]
	public FNAPAJCHKEB JAGBNDHJPNB(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x748E0F0", Offset = "0x748CAF0", VA = "0x18748E0F0")]
	public IIKOCPHBMNK KICFJJCJJKJ(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x748E460", Offset = "0x748CE60", VA = "0x18748E460")]
	public MEJOFGOJLKB JDHNGLCELNI(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x748E380", Offset = "0x748CD80", VA = "0x18748E380", Slot = "19")]
	public EMDBJMNALPM FJPEGLCEAKN(RigidbodyEx IENODGFEGDN, JBINEELBOCE GGEMPJLCHFC, BAGKGABDFPN PLJBPLDMFHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x748EA80", Offset = "0x748D480", VA = "0x18748EA80")]
	public MMFMGGLHKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x748E040", Offset = "0x748CA40", VA = "0x18748E040", Slot = "14")]
	private GJHPBEBEHCE ELELGOJMNCA(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x748E750", Offset = "0x748D150", VA = "0x18748E750", Slot = "15")]
	private BAMOAHHDCCC MJIGEOFLBKE(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x748E560", Offset = "0x748CF60", VA = "0x18748E560", Slot = "16")]
	private FNAPAJCHKEB KHKHKDDFDJK(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x748E0F0", Offset = "0x748CAF0", VA = "0x18748E0F0", Slot = "17")]
	private IIKOCPHBMNK EOLLCFPOGFB(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x748E460", Offset = "0x748CE60", VA = "0x18748E460", Slot = "18")]
	private MEJOFGOJLKB IAFFLOPDDDE(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KHMDPBOOHKF : ILGBNFHCIEB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMLJIONIHGH(EMDBJMNALPM IENODGFEGDN);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEIIALBJNKK(EMDBJMNALPM IENODGFEGDN);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OFFIINMBBHG(EMDBJMNALPM KBEMHCJOEGI);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EPMBKPJNHAL(EMDBJMNALPM KBEMHCJOEGI);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NPDIDPNIDCG : NPPALMBMLIC
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	CJMINKLKFDO<EMDBJMNALPM> GPNKGHDPHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	EMDBJMNALPM GDGFGHMHDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FINPCEIOLEF : IIKOCPHBMNK
{
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) GFGPCOJONOG(Rigidbody DJKHOAHHICL);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface EJCHLAHHOJC : BAMOAHHDCCC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	PhotonView IHBFPCFLEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class LHGDKCIMGEA : DDEIHFGCAKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly AGHIFENMFLP IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode AMLEBCOENJD;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private Rigidbody FCBIBJMADMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7487BB0", Offset = "0x74865B0", VA = "0x187487BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public CollisionDetectionMode CMGMHCINOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x748B0B0", Offset = "0x7489AB0", VA = "0x18748B0B0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x748B040", Offset = "0x7489A40", VA = "0x18748B040", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7486E10", Offset = "0x7485810", VA = "0x187486E10")]
	public LHGDKCIMGEA(EMDBJMNALPM IENODGFEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x748B4E0", Offset = "0x7489EE0", VA = "0x18748B4E0", Slot = "6")]
	public void POAPKFKGGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x748B460", Offset = "0x7489E60", VA = "0x18748B460", Slot = "9")]
	public void PJKJGDBGKEH(Rigidbody LAOKNIPNNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x748B2F0", Offset = "0x7489CF0", VA = "0x18748B2F0", Slot = "7")]
	public void NACJJBOJHAP(bool MOMBAGMGJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x748B1C0", Offset = "0x7489BC0", VA = "0x18748B1C0", Slot = "8")]
	public void LBFBAKHANJH(bool MOMBAGMGJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x748B300", Offset = "0x7489D00", VA = "0x18748B300", Slot = "10")]
	public bool PAHLANEJDEJ(Vector3 GPCBHKJPHLL, [Out] RaycastHit HCINLPJJHIB, float FHNFOJHGAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x748B1D0", Offset = "0x7489BD0", VA = "0x18748B1D0")]
	private void MKNDFLPNOEI(bool MOMBAGMGJKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class ACBNFOJAKNE : BHLCFOJDBOB, IDisposable, LFILLLADNAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly AGHIFENMFLP IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private GALLBHMJHEK LLHAALNCPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private PALGLEFKFHF DKLEHOGNPLC;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public GALLBHMJHEK NKANKIIJBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7479250", Offset = "0x7477C50", VA = "0x187479250", Slot = "6")]
		get
		{
			return default(GALLBHMJHEK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x74790D0", Offset = "0x7477AD0", VA = "0x1874790D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Transform GJDFJMJFFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x20DF5F0", Offset = "0x20DDFF0", VA = "0x1820DF5F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<DEMMDJFFENH, DEMMDJFFENH> NKBFNBGBAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x74791A0", Offset = "0x7477BA0", VA = "0x1874791A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7478FD0", Offset = "0x74779D0", VA = "0x187478FD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7479600", Offset = "0x7478000", VA = "0x187479600")]
	public ACBNFOJAKNE(EMDBJMNALPM IENODGFEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7479390", Offset = "0x7477D90", VA = "0x187479390", Slot = "8")]
	public void POAPKFKGGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7479080", Offset = "0x7477A80", VA = "0x187479080", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0xCD5010", Offset = "0xCD3A10", VA = "0x180CD5010", Slot = "11")]
	private void GAMJLPBNLJK(DEMMDJFFENH PACMIPCMEFO, DEMMDJFFENH AMIFOGIJCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "12")]
	private void DMNMKJGNCBJ(bool IOGPMONELGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class IFEKFDMPBJK : PHDGCDABAGM
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7485B40", Offset = "0x7484540", VA = "0x187485B40", Slot = "4")]
	public ILGBNFHCIEB DLHFDKKPIFH(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7486580", Offset = "0x7484F80", VA = "0x187486580", Slot = "5")]
	public JIBNMBLKEBB LCMGEGCLONK(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7486A90", Offset = "0x7485490", VA = "0x187486A90", Slot = "6")]
	public NPPALMBMLIC OIDAKKDFHIN(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x74860E0", Offset = "0x7484AE0", VA = "0x1874860E0", Slot = "7")]
	public AJCGLEKKFBF FJLFKAAEGCH(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x74869C0", Offset = "0x74853C0", VA = "0x1874869C0", Slot = "8")]
	public DPFLOHDBNLA NPOOLBOJEOL(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7486830", Offset = "0x7485230", VA = "0x187486830", Slot = "9")]
	public BHLCFOJDBOB MLOEDFIJBPC(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7485FC0", Offset = "0x74849C0", VA = "0x187485FC0", Slot = "10")]
	public EFPOOJKIJOG FDHKEDLNBCD(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7485F00", Offset = "0x7484900", VA = "0x187485F00", Slot = "11")]
	public HJLOADKOONE EPHBBFBEKDI(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x74864C0", Offset = "0x7484EC0", VA = "0x1874864C0", Slot = "12")]
	public DDEIHFGCAKN KFGEODBLPAK(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7486900", Offset = "0x7485300", VA = "0x187486900", Slot = "13")]
	public MCCJOBJCMBM NMJEHOPHIEE(EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7485C30", Offset = "0x7484630", VA = "0x187485C30")]
	public GJHPBEBEHCE IKDAJPNGHEO(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x74866A0", Offset = "0x74850A0", VA = "0x1874866A0")]
	public BAMOAHHDCCC NGKFPBEFMAK(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7486390", Offset = "0x7484D90", VA = "0x187486390")]
	public FNAPAJCHKEB JAGBNDHJPNB(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7485D70", Offset = "0x7484770", VA = "0x187485D70")]
	public IIKOCPHBMNK KICFJJCJJKJ(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x74862B0", Offset = "0x7484CB0", VA = "0x1874862B0")]
	public MEJOFGOJLKB JDHNGLCELNI(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7486160", Offset = "0x7484B60", VA = "0x187486160", Slot = "19")]
	public EMDBJMNALPM FJPEGLCEAKN(RigidbodyEx IENODGFEGDN, JBINEELBOCE GGEMPJLCHFC, BAGKGABDFPN PLJBPLDMFHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public IFEKFDMPBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7485C30", Offset = "0x7484630", VA = "0x187485C30", Slot = "14")]
	private GJHPBEBEHCE ELELGOJMNCA(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x74866A0", Offset = "0x74850A0", VA = "0x1874866A0", Slot = "15")]
	private BAMOAHHDCCC MJIGEOFLBKE(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7486390", Offset = "0x7484D90", VA = "0x187486390", Slot = "16")]
	private FNAPAJCHKEB KHKHKDDFDJK(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7485D70", Offset = "0x7484770", VA = "0x187485D70", Slot = "17")]
	private IIKOCPHBMNK EOLLCFPOGFB(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x74862B0", Offset = "0x7484CB0", VA = "0x1874862B0", Slot = "18")]
	private MEJOFGOJLKB IAFFLOPDDDE(EMDBJMNALPM OAAFMJBAJGL, [In] JBINEELBOCE GGEMPJLCHFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class JJEJPMFJDEH : HJLOADKOONE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly AGHIFENMFLP IENODGFEGDN;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Rigidbody FCBIBJMADMG
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7487BB0", Offset = "0x74865B0", VA = "0x187487BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool JJCHKHAJCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7487900", Offset = "0x7486300", VA = "0x187487900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool GOAPGGKHPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7487C00", Offset = "0x7486600", VA = "0x187487C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private EMDBJMNALPM NBMBHAFDNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7486EA0", Offset = "0x74858A0", VA = "0x187486EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7486E10", Offset = "0x7485810", VA = "0x187486E10")]
	public JJEJPMFJDEH(EMDBJMNALPM IENODGFEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x74873E0", Offset = "0x7485DE0", VA = "0x1874873E0", Slot = "4")]
	public void CHMBEIJKPMH(Vector3 DEDPJAGPBOL, ForceMode CANGLBGJCPI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x74876A0", Offset = "0x74860A0", VA = "0x1874876A0")]
	private void EFLANMHPJJC(Vector3 DEDPJAGPBOL, ForceMode CANGLBGJCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7486F00", Offset = "0x7485900", VA = "0x187486F00", Slot = "5")]
	public void BAFLKMCMKBG(Vector3 DEDPJAGPBOL, Vector3 PCPIJKGKPCE, ForceMode CANGLBGJCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7487540", Offset = "0x7485F40", VA = "0x187487540", Slot = "6")]
	public void CPDOIKPEDBI(Vector3 CBJANMEJBGH, ForceMode CANGLBGJCPI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x7487950", Offset = "0x7486350", VA = "0x187487950")]
	private void KELNLDBAKPP(Vector3 CBJANMEJBGH, ForceMode CANGLBGJCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x7487180", Offset = "0x7485B80", VA = "0x187487180", Slot = "7")]
	public void BHCHLDCHHFL(Vector3 CBJANMEJBGH, ForceMode CANGLBGJCPI = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class JBCOFMFGADH : MCCJOBJCMBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly AGHIFENMFLP IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool JFKDHBBKCKJ;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool LPFIGPLMNDA
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xBB0080", Offset = "0xBAEA80", VA = "0x180BB0080", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7486CD0", Offset = "0x74856D0", VA = "0x187486CD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7486E10", Offset = "0x7485810", VA = "0x187486E10")]
	public JBCOFMFGADH(EMDBJMNALPM IENODGFEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7486DE0", Offset = "0x74857E0", VA = "0x187486DE0", Slot = "6")]
	public void PJKJGDBGKEH(Rigidbody LAOKNIPNNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7486C60", Offset = "0x7485660", VA = "0x187486C60", Slot = "7")]
	public void HOAAGADNBMC(Rigidbody LAOKNIPNNGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class LHKDMLFJIMM : KHMDPBOOHKF, ILGBNFHCIEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly EMDBJMNALPM IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<EMDBJMNALPM> IEMMACPKNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EMDBJMNALPM ELFANOAFHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EMDBJMNALPM NNFBEGDDJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform NHKAOMMGEOG;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private Transform DNOKGDKBFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x748C1A0", Offset = "0x748ABA0", VA = "0x18748C1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public EMDBJMNALPM NBMBHAFDNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8AB220", Offset = "0x8A9C20", VA = "0x1808AB220", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x748B750", Offset = "0x748A150", VA = "0x18748B750", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public EMDBJMNALPM BPFDMKBMANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1C0", Offset = "0x8A9BC0", VA = "0x1808AB1C0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public IReadOnlyList<EMDBJMNALPM> FKKBFLEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8AB230", Offset = "0x8A9C30", VA = "0x1808AB230", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event BLAAMJOBEEE NCBJLMBEHFG
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x748CB40", Offset = "0x748B540", VA = "0x18748CB40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x748CF10", Offset = "0x748B910", VA = "0x18748CF10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event BLAAMJOBEEE LJAHMKBAAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x748CFB0", Offset = "0x748B9B0", VA = "0x18748CFB0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x748D360", Offset = "0x748BD60", VA = "0x18748D360", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event DGPNAMMLLPB PDDBENPFEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x748C200", Offset = "0x748AC00", VA = "0x18748C200", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x748BFB0", Offset = "0x748A9B0", VA = "0x18748BFB0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action FEHPDLLKCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x748BC90", Offset = "0x748A690", VA = "0x18748BC90", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x748CD30", Offset = "0x748B730", VA = "0x18748CD30", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action DGHPPEHFMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x748B940", Offset = "0x748A340", VA = "0x18748B940", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x748C100", Offset = "0x748AB00", VA = "0x18748C100", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<EMDBJMNALPM> HFNBJMNLEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x748B5F0", Offset = "0x7489FF0", VA = "0x18748B5F0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x748C050", Offset = "0x748AA50", VA = "0x18748C050", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<EMDBJMNALPM> BKADNMJHLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x748B9E0", Offset = "0x748A3E0", VA = "0x18748B9E0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x748B890", Offset = "0x748A290", VA = "0x18748B890", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action PKIIOPKEIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x748D2C0", Offset = "0x748BCC0", VA = "0x18748D2C0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x748CBE0", Offset = "0x748B5E0", VA = "0x18748CBE0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<EMDBJMNALPM> FDNJOFBPPJG
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x748CC80", Offset = "0x748B680", VA = "0x18748CC80", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x748B6A0", Offset = "0x748A0A0", VA = "0x18748B6A0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x748D400", Offset = "0x748BE00", VA = "0x18748D400")]
	public LHKDMLFJIMM(EMDBJMNALPM IENODGFEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x748BBF0", Offset = "0x748A5F0", VA = "0x18748BBF0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x748C2A0", Offset = "0x748ACA0", VA = "0x18748C2A0", Slot = "30")]
	public void IDPLHFEAHGA(EMDBJMNALPM AOBPGDDFDPP, bool IPPGFKCBGDF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x748D050", Offset = "0x748BA50", VA = "0x18748D050", Slot = "6")]
	public void OFFIINMBBHG(EMDBJMNALPM KBEMHCJOEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x748BD30", Offset = "0x748A730", VA = "0x18748BD30", Slot = "7")]
	public void EPMBKPJNHAL(EMDBJMNALPM KBEMHCJOEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x748C8C0", Offset = "0x748B2C0", VA = "0x18748C8C0", Slot = "4")]
	public void IMLJIONIHGH(EMDBJMNALPM IENODGFEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x748BB50", Offset = "0x748A550", VA = "0x18748BB50", Slot = "5")]
	public void DEIIALBJNKK(EMDBJMNALPM IENODGFEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x748C820", Offset = "0x748B220", VA = "0x18748C820")]
	private void IELMDOLOJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x748C9D0", Offset = "0x748B3D0", VA = "0x18748C9D0")]
	private void JGMIJGLELCC(EMDBJMNALPM KBEMHCJOEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x748CDD0", Offset = "0x748B7D0", VA = "0x18748CDD0")]
	private void MGFEPMEFLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x748CA10", Offset = "0x748B410", VA = "0x18748CA10")]
	private void JIPNCPCGJGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x748B760", Offset = "0x748A160", VA = "0x18748B760")]
	private void BHJBKMFJAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x748BA90", Offset = "0x748A490", VA = "0x18748BA90")]
	[CompilerGenerated]
	private object CNNLIGDCIBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class ELDGPLFGFHL
{
	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x74846E0", Offset = "0x74830E0", VA = "0x1874846E0")]
	public static KHMDPBOOHKF KHKIEEJFJCE(this EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class BNFOGJCEAIJ : NPDIDPNIDCG, NPPALMBMLIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly AGHIFENMFLP IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly CJMINKLKFDO<EMDBJMNALPM> KLLDHNHALHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool BALEABCLMFA;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public CJMINKLKFDO<EMDBJMNALPM> GPNKGHDPHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 EPJFKHCBLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7480D60", Offset = "0x747F760", VA = "0x187480D60", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 CEHEIBFKKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7480D90", Offset = "0x747F790", VA = "0x187480D90", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private Vector3 PPNKKHAMFDF
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7480C70", Offset = "0x747F670", VA = "0x187480C70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public EMDBJMNALPM GDGFGHMHDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7480AF0", Offset = "0x747F4F0", VA = "0x187480AF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7480F50", Offset = "0x747F950", VA = "0x187480F50")]
	public BNFOGJCEAIJ(EMDBJMNALPM IENODGFEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7480C00", Offset = "0x747F600", VA = "0x187480C00", Slot = "8")]
	public void HKBGFGOJEON(EMDBJMNALPM NNFBEGDDJKL, object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7480BA0", Offset = "0x747F5A0", VA = "0x187480BA0", Slot = "9")]
	public void FFNJBPJAKJG(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7480750", Offset = "0x747F150", VA = "0x187480750")]
	private Vector3 CEGLPGNJIIO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x74803C0", Offset = "0x747EDC0", VA = "0x1874803C0")]
	private void CAOPPLLCALC(EMDBJMNALPM MLGKAFBPLGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class MPEKEOPBPEC
{
	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x748EB30", Offset = "0x748D530", VA = "0x18748EB30")]
	public static NPDIDPNIDCG PBOAEKPNDFN(this EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class KBLBPDGKFMH : FINPCEIOLEF, IIKOCPHBMNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly AGHIFENMFLP IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 HBLDFDJINKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 JGMPLNIFFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float GLKLENNKDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float AMDGFJNPKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 LNHNAMIBKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? ACCJDJLAHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? KAFODNIOJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool PBIMHGIKAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool NPJEMJNNAGE;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 AHOBNOJHENE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x10CE240", Offset = "0x10CCC40", VA = "0x1810CE240", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7488560", Offset = "0x7486F60", VA = "0x187488560", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 HDLBEGIIEFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x748A830", Offset = "0x7489230", VA = "0x18748A830", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float GIIBDOCINFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xBB00A0", Offset = "0xBAEAA0", VA = "0x180BB00A0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7488610", Offset = "0x7487010", VA = "0x187488610")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float PFJKDDDJDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xBB0090", Offset = "0xBAEA90", VA = "0x180BB0090", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7489230", Offset = "0x7487C30", VA = "0x187489230", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 IHGNAKKEGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x748A600", Offset = "0x7489000", VA = "0x18748A600", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Quaternion KPFPNKFBJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7488F00", Offset = "0x7487900", VA = "0x187488F00", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private Rigidbody FCBIBJMADMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x748A920", Offset = "0x7489320", VA = "0x18748A920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event BLAAMJOBEEE JIHLKOMLNNH
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x748A150", Offset = "0x7488B50", VA = "0x18748A150", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x748A790", Offset = "0x7489190", VA = "0x18748A790", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x748AC20", Offset = "0x7489620", VA = "0x18748AC20")]
	public KBLBPDGKFMH(EMDBJMNALPM IENODGFEGDN, [In] JBINEELBOCE GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7488D50", Offset = "0x7487750", VA = "0x187488D50", Slot = "17")]
	public void CHBMIBIEJPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x748A970", Offset = "0x7489370", VA = "0x18748A970", Slot = "16")]
	public void OODODGDCHBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x748AA50", Offset = "0x7489450", VA = "0x18748AA50", Slot = "19")]
	public void PJKJGDBGKEH(Rigidbody LAOKNIPNNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x748A1F0", Offset = "0x7488BF0", VA = "0x18748A1F0", Slot = "20")]
	public void HOAAGADNBMC(Rigidbody LAOKNIPNNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7489080", Offset = "0x7487A80", VA = "0x187489080", Slot = "18")]
	public void DLIODOCICLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x74888C0", Offset = "0x74872C0", VA = "0x1874888C0", Slot = "21")]
	public void CECLIFIGODF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7488560", Offset = "0x7486F60", VA = "0x187488560")]
	private void AMBLKGJDAMJ(Vector3 PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x748AB30", Offset = "0x7489530", VA = "0x18748AB30")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 PMCHNPAJCCK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7488610", Offset = "0x7487010", VA = "0x187488610")]
	private void BNHNBGIFJML(float PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7489230", Offset = "0x7487C30", VA = "0x187489230")]
	private void FKDPCIIOJNA(float PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7488720", Offset = "0x7487120", VA = "0x187488720")]
	private Vector3 BOIJOPHJBDC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x748A3D0", Offset = "0x7488DD0", VA = "0x18748A3D0", Slot = "15")]
	public void IEPGNEHCFEJ((Quaternion rot, Vector3 moments) KKAJDAFCIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x74883E0", Offset = "0x7486DE0", VA = "0x1874883E0")]
	private Quaternion AIKGNGEOPOK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x748A080", Offset = "0x7488A80", VA = "0x18748A080")]
	public void GFGPCOJONOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x74892E0", Offset = "0x7487CE0", VA = "0x1874892E0", Slot = "4")]
	public (float, Vector3) GFGPCOJONOG(Rigidbody DJKHOAHHICL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class AALLNOBKBFC
{
	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7478F10", Offset = "0x7477910", VA = "0x187478F10")]
	public static FINPCEIOLEF NHEKFNKIBBJ(this EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class JNDPIADEGHC : FNAPAJCHKEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly AGHIFENMFLP IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly JKLEGNGEMOG DLBNKCDBHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AKCEHIDIOBB AKHMGCKIEOM;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool JBNADNGKHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x125A3B0", Offset = "0x1258DB0", VA = "0x18125A3B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public AKCEHIDIOBB BALMKFGADML
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x9826F0", Offset = "0x9810F0", VA = "0x1809826F0", Slot = "11")]
		get
		{
			return default(AKCEHIDIOBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7488270", Offset = "0x7486C70", VA = "0x187488270")]
	public JNDPIADEGHC(EMDBJMNALPM IENODGFEGDN, [In] JBINEELBOCE GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x74881A0", Offset = "0x7486BA0", VA = "0x1874881A0", Slot = "4")]
	public void POAPKFKGGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7487C60", Offset = "0x7486660", VA = "0x187487C60")]
	private bool DAMAOEOINIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7488170", Offset = "0x7486B70", VA = "0x187488170", Slot = "5")]
	public void NCLJEKODOGI(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7487D80", Offset = "0x7486780", VA = "0x187487D80", Slot = "6")]
	public void HFOJHJPIBIB(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7488040", Offset = "0x7486A40", VA = "0x187488040", Slot = "9")]
	public void LHOOMNMMBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7487F30", Offset = "0x7486930", VA = "0x187487F30")]
	private void KMMPANIOGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7487DB0", Offset = "0x74867B0", VA = "0x187487DB0")]
	private void JONCFMLOIFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7487D00", Offset = "0x7486700", VA = "0x187487D00", Slot = "8")]
	public void FGAJEBGGDED(EMDBJMNALPM IENODGFEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7487D40", Offset = "0x7486740", VA = "0x187487D40", Slot = "7")]
	public void GFBHNMALNPP(EMDBJMNALPM IENODGFEGDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class AOHFJCDDENF : EFPOOJKIJOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly AGHIFENMFLP IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly JKLEGNGEMOG KCANJNKMFCD;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool JJCHKHAJCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x747FD40", Offset = "0x747E740", VA = "0x18747FD40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event BLAAMJOBEEE GNNFAOIGKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x747FE60", Offset = "0x747E860", VA = "0x18747FE60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7480010", Offset = "0x747EA10", VA = "0x187480010", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7480130", Offset = "0x747EB30", VA = "0x187480130")]
	public AOHFJCDDENF(EMDBJMNALPM IENODGFEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x747FD20", Offset = "0x747E720", VA = "0x18747FD20", Slot = "7")]
	public void BJEICFOFOPJ(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x747FD30", Offset = "0x747E730", VA = "0x18747FD30", Slot = "8")]
	public void FAAMKFNFGMK(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x747FF00", Offset = "0x747E900", VA = "0x18747FF00", Slot = "9")]
	public void MJFNHNBOHCA(object AICEIDIHFDO, bool FMLBLIGLDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x747FE20", Offset = "0x747E820", VA = "0x18747FE20", Slot = "12")]
	public void JNDMDKADFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x74800B0", Offset = "0x747EAB0", VA = "0x1874800B0", Slot = "10")]
	public void PJKJGDBGKEH(Rigidbody PILKPKKMGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x747FDF0", Offset = "0x747E7F0", VA = "0x18747FDF0", Slot = "11")]
	public void HOAAGADNBMC(Rigidbody LAOKNIPNNGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class NPICBHBGOPK : EJCHLAHHOJC, BAMOAHHDCCC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly AGHIFENMFLP IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PhotonView MAGOHDADLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool HOGINAFEGKE;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public PhotonView IHBFPCFLEDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool GADPAMAMFPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x748F450", Offset = "0x748DE50", VA = "0x18748F450", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool PDLJPLJNAGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x9A2DD0", Offset = "0x9A17D0", VA = "0x1809A2DD0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event BLAAMJOBEEE MPNCCFFFFBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x748F470", Offset = "0x748DE70", VA = "0x18748F470", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x748F680", Offset = "0x748E080", VA = "0x18748F680", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x748F9C0", Offset = "0x748E3C0", VA = "0x18748F9C0")]
	public NPICBHBGOPK(EMDBJMNALPM IENODGFEGDN, [In] JBINEELBOCE GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x748F890", Offset = "0x748E290", VA = "0x18748F890", Slot = "9")]
	public void POAPKFKGGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x748F350", Offset = "0x748DD50", VA = "0x18748F350", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x748F510", Offset = "0x748DF10", VA = "0x18748F510", Slot = "10")]
	public void MJKFKOIHMCG(EMDBJMNALPM NNFBEGDDJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x748EF70", Offset = "0x748D970", VA = "0x18748EF70", Slot = "11")]
	public void BBCFEBHLHFO(EMDBJMNALPM NNFBEGDDJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x748F720", Offset = "0x748E120", VA = "0x18748F720")]
	private void PEIJFANDLHC(PhotonView HONFIDOJGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x748EE20", Offset = "0x748D820", VA = "0x18748EE20")]
	private void ABNCMIENEBO(PLAOFEANGHJ IPMILMEPKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x748F0E0", Offset = "0x748DAE0", VA = "0x18748F0E0")]
	private void BILFJCKLGPB(PhotonView PGJJGHNKENL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class LIHMNDLLNPI
{
	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x748D4C0", Offset = "0x748BEC0", VA = "0x18748D4C0")]
	public static EJCHLAHHOJC ADENCINHPGK(this EMDBJMNALPM OAAFMJBAJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class NIODBKFNMGH : MEJOFGOJLKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly AGHIFENMFLP IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints LFELAMOCLPH;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool MENJAPAJHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x951C20", Offset = "0x950620", VA = "0x180951C20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x48FFF10", Offset = "0x48FE910", VA = "0x1848FFF10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool KCFPCMINNPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xBB0040", Offset = "0xBAEA40", VA = "0x180BB0040", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x48FFF00", Offset = "0x48FE900", VA = "0x1848FFF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public RigidbodyConstraints DBJKAAHHHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D20", Offset = "0x8B3720", VA = "0x1808B4D20", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x748EC20", Offset = "0x748D620", VA = "0x18748EC20", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x748ED80", Offset = "0x748D780", VA = "0x18748ED80")]
	public NIODBKFNMGH(EMDBJMNALPM IENODGFEGDN, [In] JBINEELBOCE GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x748ED50", Offset = "0x748D750", VA = "0x18748ED50", Slot = "9")]
	public void PJKJGDBGKEH(Rigidbody LAOKNIPNNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x748EBF0", Offset = "0x748D5F0", VA = "0x18748EBF0", Slot = "10")]
	public void HOAAGADNBMC(Rigidbody LAOKNIPNNGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class HFDCALAGBMF : AJCGLEKKFBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly EMDBJMNALPM IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float IJHMBBOGMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float JFLELCGIBFO;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float MGKIELOGHHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xAA37C0", Offset = "0xAA21C0", VA = "0x180AA37C0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7485940", Offset = "0x7484340", VA = "0x187485940", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float JDKPBHKKMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xBF02D0", Offset = "0xBEECD0", VA = "0x180BF02D0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7485870", Offset = "0x7484270", VA = "0x187485870", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x7485B00", Offset = "0x7484500", VA = "0x187485B00")]
	public HFDCALAGBMF(EMDBJMNALPM IENODGFEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7485AB0", Offset = "0x74844B0", VA = "0x187485AB0", Slot = "8")]
	public void PJKJGDBGKEH(Rigidbody LAOKNIPNNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7485A10", Offset = "0x7484410", VA = "0x187485A10", Slot = "9")]
	public void HOAAGADNBMC(Rigidbody LAOKNIPNNGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class GHHIIGAAGAE : DPFLOHDBNLA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly KLEHBGEJMBN ICAILLKFJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private AIIJEJIPADL GDFBFAOBLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly AGHIFENMFLP IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool HFFELBLDJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private bool BGPLPEEGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private int EBBCHAFPHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool FFPANKPPHLI;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private Rigidbody FCBIBJMADMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7485270", Offset = "0x7483C70", VA = "0x187485270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private bool NDEPCDPFHME
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x74852C0", Offset = "0x7483CC0", VA = "0x1874852C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private EMDBJMNALPM NBMBHAFDNEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x74847A0", Offset = "0x74831A0", VA = "0x1874847A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private bool GOAPGGKHPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x74852E0", Offset = "0x7483CE0", VA = "0x1874852E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event BLAAMJOBEEE HOBFPBHLJJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7485340", Offset = "0x7483D40", VA = "0x187485340", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7484CF0", Offset = "0x74836F0", VA = "0x187484CF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7485710", Offset = "0x7484110", VA = "0x187485710")]
	public GHHIIGAAGAE(EMDBJMNALPM IENODGFEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x74853E0", Offset = "0x7483DE0", VA = "0x1874853E0", Slot = "6")]
	public void POAPKFKGGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7484A80", Offset = "0x7483480", VA = "0x187484A80", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7484D90", Offset = "0x7483790", VA = "0x187484D90", Slot = "8")]
	public void GPEIBAIFBKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7484800", Offset = "0x7483200", VA = "0x187484800", Slot = "7")]
	public bool AGJPHHNBENE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x74855A0", Offset = "0x7483FA0", VA = "0x1874855A0", Slot = "9")]
	public void PPHLEEINLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7484DA0", Offset = "0x74837A0", VA = "0x187484DA0")]
	private void JHIEKFDHIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x74850B0", Offset = "0x7483AB0", VA = "0x1874850B0", Slot = "13")]
	public void KENOEKIHLML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7485150", Offset = "0x7483B50", VA = "0x187485150", Slot = "12")]
	public void LPNCALMJDNO(bool KEDHDANCMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7484E60", Offset = "0x7483860", VA = "0x187484E60", Slot = "10")]
	public bool JLCEFJGMAHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7484950", Offset = "0x7483350", VA = "0x187484950", Slot = "11")]
	public bool AMIOKLMGIAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7484ED0", Offset = "0x74838D0", VA = "0x187484ED0")]
	private bool KCHEKCJBCMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7484B60", Offset = "0x7483560", VA = "0x187484B60")]
	private void FHLOGEFBHLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class MKPDIPFEMIA : GJHPBEBEHCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly AGHIFENMFLP IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly JKLEGNGEMOG POILEDONGMP;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Rigidbody FCBIBJMADMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8AD750", Offset = "0x8AC150", VA = "0x1808AD750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool GOAPGGKHPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x7487C00", Offset = "0x7486600", VA = "0x187487C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool OCMMMDPDPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x125A3B0", Offset = "0x1258DB0", VA = "0x18125A3B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x748DE30", Offset = "0x748C830", VA = "0x18748DE30")]
	public MKPDIPFEMIA(EMDBJMNALPM IENODGFEGDN, [In] JBINEELBOCE GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x748DD90", Offset = "0x748C790", VA = "0x18748DD90", Slot = "5")]
	public void POAPKFKGGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x748D690", Offset = "0x748C090", VA = "0x18748D690", Slot = "7")]
	public void IOKBKGFNBPE(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x748D6C0", Offset = "0x748C0C0", VA = "0x18748D6C0", Slot = "8")]
	public void IPGCLCKCEII(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x748D870", Offset = "0x748C270", VA = "0x18748D870", Slot = "9")]
	public void LAFEHIMCOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x748DBA0", Offset = "0x748C5A0", VA = "0x18748DBA0", Slot = "10")]
	public void LIJKJAMAAHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x748D6F0", Offset = "0x748C0F0", VA = "0x18748D6F0", Slot = "11")]
	public void KFDACCHGEFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class EIJFPDCJEGP : JIBNMBLKEBB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly AGHIFENMFLP IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly JKLEGNGEMOG LOGLJEDIHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private float NFBFBMGOOIH;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public JJEINIEAKAA ECNMJPDBICD
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB30", Offset = "0x8AC530", VA = "0x1808ADB30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public BJJKGMHOOAO ACAOJPDEBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D30", Offset = "0x8B3730", VA = "0x1808B4D30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 PPNKKHAMFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x7483650", Offset = "0x7482050", VA = "0x187483650", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x7481050", Offset = "0x747FA50", VA = "0x187481050", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 NMOHGCEFAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x74841E0", Offset = "0x7482BE0", VA = "0x1874841E0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x7483800", Offset = "0x7482200", VA = "0x187483800", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 HGNJJNFMGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7482240", Offset = "0x7480C40", VA = "0x187482240", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x74820D0", Offset = "0x7480AD0", VA = "0x1874820D0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 CIEAHJKCIAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7482470", Offset = "0x7480E70", VA = "0x187482470", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x74841B0", Offset = "0x7482BB0", VA = "0x1874841B0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public float IKPNNFFHMJP
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xBB00B0", Offset = "0xBAEAB0", VA = "0x180BB00B0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7481C40", Offset = "0x7480640", VA = "0x187481C40", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool LCGAAJEHGII
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x1BEB9E0", Offset = "0x1BEA3E0", VA = "0x181BEB9E0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private HJLOADKOONE NIBKBKBGOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6C34E20", Offset = "0x6C33820", VA = "0x186C34E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private bool NDEPCDPFHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7483CB0", Offset = "0x74826B0", VA = "0x187483CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x74845F0", Offset = "0x7482FF0", VA = "0x1874845F0")]
	public EIJFPDCJEGP(EMDBJMNALPM IENODGFEGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7481DB0", Offset = "0x74807B0", VA = "0x187481DB0", Slot = "19")]
	public void POAPKFKGGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7481D50", Offset = "0x7480750", VA = "0x187481D50", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x74844C0", Offset = "0x7482EC0", VA = "0x1874844C0", Slot = "28")]
	public void PJKJGDBGKEH(Rigidbody LAOKNIPNNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x1082B90", Offset = "0x1081590", VA = "0x181082B90", Slot = "20")]
	public void PBLMEEKDKGH(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x10802D0", Offset = "0x107ECD0", VA = "0x1810802D0", Slot = "30")]
	public void CFKPDPKNIBL(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7482E90", Offset = "0x7481890", VA = "0x187482E90", Slot = "35")]
	public Vector3 KDLALPJKADG(Vector3 OLMGFKCPIAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7484300", Offset = "0x7482D00", VA = "0x187484300", Slot = "34")]
	public Vector3 PFJCCGNMAEC(Vector3 EANDNBDFHAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7481DB0", Offset = "0x74807B0", VA = "0x187481DB0", Slot = "27")]
	public void EDEFKNBFHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x74837A0", Offset = "0x74821A0", VA = "0x1874837A0", Slot = "25")]
	public void MGGAMOMIHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x74835F0", Offset = "0x7481FF0", VA = "0x1874835F0", Slot = "24")]
	public void LMDHPCGCNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7483210", Offset = "0x7481C10", VA = "0x187483210", Slot = "33")]
	public void KLOIDLONHHL(Vector3 FBMAHADPHLI, Vector3 CNJKLEBNEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7483CD0", Offset = "0x74826D0", VA = "0x187483CD0", Slot = "32")]
	public void OCBKHLCDJCG(Vector3 OANMBMGADDF, Vector3 FABHBEPNFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7483450", Offset = "0x7481E50", VA = "0x187483450", Slot = "31")]
	public void LACGMGEGMJN(Vector3 OBENCGMBKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7482840", Offset = "0x7481240", VA = "0x187482840", Slot = "22")]
	public void JCDHLOBADCA(KKJPMEMAAIK FCEHKBPNPGC, Vector3 MKNILOBHEGF, float EJFAFPILBDC, float LKIICJOHOKF = 8f, float IJKLJKHKJLJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7481E50", Offset = "0x7480850", VA = "0x187481E50", Slot = "21")]
	public void EKDNDOCPGKO(GMFDOIJJCHD CGOIMLAMHPC, Vector3 DMCEEOHELFI, float NNLBEODNLOO = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7481110", Offset = "0x747FB10", VA = "0x187481110", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void BDIABJAJDLG(GMFDOIJJCHD CGOIMLAMHPC, Vector3 MHLCHCEFDAI, float PBNDEELCJLM = 7f, float ODIFALBIEHN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x11AFCE0", Offset = "0x11AE6E0", VA = "0x1811AFCE0")]
	private static void HALFCCLMCHB(Vector3 FOPADPEODOF, Vector3 LIGJJEDBJEP, [Out] Vector3 PFDNIPGEHME, [Out] Vector3 PEKPAAGCGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7482390", Offset = "0x7480D90", VA = "0x187482390", Slot = "29")]
	public Vector3 HFFKFPNDNMK(Vector3 FOPADPEODOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7482590", Offset = "0x7480F90", VA = "0x187482590", Slot = "26")]
	public void IJAONGNMNCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x7481C40", Offset = "0x7480640", VA = "0x187481C40")]
	private void CPOHMMJGBLD(float PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7483070", Offset = "0x7481A70", VA = "0x187483070")]
	private void KIAJNFCHOJF(Vector3 DMCEEOHELFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7481590", Offset = "0x747FF90", VA = "0x187481590")]
	private Vector3 BIKFEGNGOFG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7483D30", Offset = "0x7482730", VA = "0x187483D30")]
	private void OEABDIDPJKM(Vector3 EANDNBDFHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7482720", Offset = "0x7481120", VA = "0x187482720")]
	private Vector3 INLBOCEPIIN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7483830", Offset = "0x7482230", VA = "0x187483830")]
	private void NBABINPDBPP(Vector3 PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x74816A0", Offset = "0x74800A0", VA = "0x1874816A0")]
	private void CPLELGOALIH(Vector3 EANDNBDFHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7482190", Offset = "0x7480B90", VA = "0x187482190")]
	private void GGPKHLELEFB()
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
