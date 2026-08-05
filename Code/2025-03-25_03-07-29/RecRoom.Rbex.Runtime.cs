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
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F5BF80", Offset = "0x7F5B380", VA = "0x187F5BF80", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F206C0", Offset = "0x1F1FAC0", VA = "0x181F206C0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F6DA10", Offset = "0x7F6CE10", VA = "0x187F6DA10")]
		private void LBKELEMAONI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F6DD20", Offset = "0x7F6D120", VA = "0x187F6DD20", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F6DD80", Offset = "0x7F6D180", VA = "0x187F6DD80")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, NFIBELDGELK, OKEGJBDPDCK, MCFNOLNCJAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly ABDDJEPKCOD EFLHEJHJIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool GDJLDBBLBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private ABPNPGANBHP DNFLNJBKIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[HBPAIPBJNDJ(FPABMOGJDEH.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[HBPAIPBJNDJ(FPABMOGJDEH.SelfAndParent, true, false, false)]
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
		private GLFKKJMEHNE physicsInterpolation;

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

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Transform PKFFAABMEKJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal ABPNPGANBHP NBCLFPBJMAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7F69700", Offset = "0x7F68B00", VA = "0x187F69700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ABPNPGANBHP OKDLCIHPPAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int BOEFJFFDNFN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7F6AEE0", Offset = "0x7F6A2E0", VA = "0x187F6AEE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx NFDHGOGEECM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B240", Offset = "0x7F6A640", VA = "0x187F6B240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx OFMCPLOCJBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B180", Offset = "0x7F6A580", VA = "0x187F6B180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx PBIFOHNGFLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BE50", Offset = "0x7F6B250", VA = "0x187F6BE50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D380", Offset = "0x7F6C780", VA = "0x187F6D380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OENONAGGDKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7BD23F0", Offset = "0x7BD17F0", VA = "0x187BD23F0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7BD3420", Offset = "0x7BD2820", VA = "0x187BD3420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform NPHMCHFKJHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1D562A0", Offset = "0x1D556A0", VA = "0x181D562A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform HFOBAENLHHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1D562A0", Offset = "0x1D556A0", VA = "0x181D562A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform KFBNOFJKFOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1D562A0", Offset = "0x1D556A0", VA = "0x181D562A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public GDMNGFOCBGE CIPGJOKIEPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7F6AF40", Offset = "0x7F6A340", VA = "0x187F6AF40")]
			get
			{
				return default(GDMNGFOCBGE);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CB30", Offset = "0x7F6BF30", VA = "0x187F6CB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool EECHAMFCOHI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B550", Offset = "0x7F6A950", VA = "0x187F6B550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool HNEOKNHIFND
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B060", Offset = "0x7F6A460", VA = "0x187F6B060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public MBIEHGKALBL OAGGEAOJCID
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B490", Offset = "0x7F6A890", VA = "0x187F6B490")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CCF0", Offset = "0x7F6C0F0", VA = "0x187F6CCF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public EANAJLOACDP MPNOFNPOHKF
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B430", Offset = "0x7F6A830", VA = "0x187F6B430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CC80", Offset = "0x7F6C080", VA = "0x187F6CC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GOJJGCIMGFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B380", Offset = "0x7F6A780", VA = "0x187F6B380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody PCCLPPLGLJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B3E0", Offset = "0x7F6A7E0", VA = "0x187F6B3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DAPFLDLDOIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B0C0", Offset = "0x7F6A4C0", VA = "0x187F6B0C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CBA0", Offset = "0x7F6BFA0", VA = "0x187F6CBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool MFOCMHPGPHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x148D2A0", Offset = "0x148C6A0", VA = "0x18148D2A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float DFGMCFFNFOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BDF0", Offset = "0x7F6B1F0", VA = "0x187F6BDF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float BCAEEENABOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BD90", Offset = "0x7F6B190", VA = "0x187F6BD90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D310", Offset = "0x7F6C710", VA = "0x187F6D310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float BOIPLNDCDIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B7B0", Offset = "0x7F6ABB0", VA = "0x187F6B7B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CF90", Offset = "0x7F6C390", VA = "0x187F6CF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float KDAJJEOPCMK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B5B0", Offset = "0x7F6A9B0", VA = "0x187F6B5B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CD60", Offset = "0x7F6C160", VA = "0x187F6CD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool NLDPPPEEPPI
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C3D0", Offset = "0x7F6B7D0", VA = "0x187F6C3D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D8C0", Offset = "0x7F6CCC0", VA = "0x187F6D8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 GEEMLGBIHNN
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BB70", Offset = "0x7F6AF70", VA = "0x187F6BB70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D0E0", Offset = "0x7F6C4E0", VA = "0x187F6D0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 HBCNLDFDEHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C510", Offset = "0x7F6B910", VA = "0x187F6C510")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode KKJEIMODGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B6F0", Offset = "0x7F6AAF0", VA = "0x187F6B6F0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CEB0", Offset = "0x7F6C2B0", VA = "0x187F6CEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float NLAEEPGFOCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B120", Offset = "0x7F6A520", VA = "0x187F6B120")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CC10", Offset = "0x7F6C010", VA = "0x187F6CC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints PLJHFLIEIHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B750", Offset = "0x7F6AB50", VA = "0x187F6B750")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CF20", Offset = "0x7F6C320", VA = "0x187F6CF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 DBCCHHPOFJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BF10", Offset = "0x7F6B310", VA = "0x187F6BF10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 LLHFFMKNNEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BF10", Offset = "0x7F6B310", VA = "0x187F6BF10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D6A0", Offset = "0x7F6CAA0", VA = "0x187F6D6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float KDIMAMFLKGH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BC50", Offset = "0x7F6B050", VA = "0x187F6BC50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D1C0", Offset = "0x7F6C5C0", VA = "0x187F6D1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float EFJBOKHCJMI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C370", Offset = "0x7F6B770", VA = "0x187F6C370")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D850", Offset = "0x7F6CC50", VA = "0x187F6D850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion JBJPALHCAPA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BFF0", Offset = "0x7F6B3F0", VA = "0x187F6BFF0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D420", Offset = "0x7F6C820", VA = "0x187F6D420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DIAICBJMMND
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C290", Offset = "0x7F6B690", VA = "0x187F6C290")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D780", Offset = "0x7F6CB80", VA = "0x187F6D780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 PDEGBNPEJKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C0D0", Offset = "0x7F6B4D0", VA = "0x187F6C0D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D4F0", Offset = "0x7F6C8F0", VA = "0x187F6D4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion AKBGKOPCGEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C1B0", Offset = "0x7F6B5B0", VA = "0x187F6C1B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D5D0", Offset = "0x7F6C9D0", VA = "0x187F6D5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 APPPFHHBPEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C430", Offset = "0x7F6B830", VA = "0x187F6C430")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D930", Offset = "0x7F6CD30", VA = "0x187F6D930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 DKOOKAOCABK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BCB0", Offset = "0x7F6B0B0", VA = "0x187F6BCB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D230", Offset = "0x7F6C630", VA = "0x187F6D230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 KNDCDNHAEAI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B610", Offset = "0x7F6AA10", VA = "0x187F6B610")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CDD0", Offset = "0x7F6C1D0", VA = "0x187F6CDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 DGBDKEHBLNN
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BA90", Offset = "0x7F6AE90", VA = "0x187F6BA90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D000", Offset = "0x7F6C400", VA = "0x187F6D000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 JBHGIONPKCL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B950", Offset = "0x7F6AD50", VA = "0x187F6B950")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion FGKBLICLIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B870", Offset = "0x7F6AC70", VA = "0x187F6B870")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 MKPCEHLADCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C6D0", Offset = "0x7F6BAD0", VA = "0x187F6C6D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 EMDCMBLENKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C5F0", Offset = "0x7F6B9F0", VA = "0x187F6C5F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool PKHJAFFAAAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BA30", Offset = "0x7F6AE30", VA = "0x187F6BA30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NEMHFFDMFKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B4F0", Offset = "0x7F6A8F0", VA = "0x187F6B4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DJKGDLKOJHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B000", Offset = "0x7F6A400", VA = "0x187F6B000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool BMPFOOBGIFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7F6AFA0", Offset = "0x7F6A3A0", VA = "0x187F6AFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool KLOIFCAIMIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7F6AE80", Offset = "0x7F6A280", VA = "0x187F6AE80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool IGAPMONGMAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B810", Offset = "0x7F6AC10", VA = "0x187F6B810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool NFLEONEBCBN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2202070", Offset = "0x2201470", VA = "0x182202070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event HIBPMBDIIHN CONOJEDMEKF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7F6ADA0", Offset = "0x7F6A1A0", VA = "0x187F6ADA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CA50", Offset = "0x7F6BE50", VA = "0x187F6CA50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event GPIDENABAMJ AAEODNCKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7F6AB10", Offset = "0x7F69F10", VA = "0x187F6AB10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C7B0", Offset = "0x7F6BBB0", VA = "0x187F6C7B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event GPIDENABAMJ ICNCDCNELHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7F6AB70", Offset = "0x7F69F70", VA = "0x187F6AB70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C820", Offset = "0x7F6BC20", VA = "0x187F6C820")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event GPIDENABAMJ BEAPIEPMNJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7F6ACC0", Offset = "0x7F6A0C0", VA = "0x187F6ACC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C970", Offset = "0x7F6BD70", VA = "0x187F6C970")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<GPKPAEJIOJM, GPKPAEJIOJM> DGDACCPKEMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7F6AC50", Offset = "0x7F6A050", VA = "0x187F6AC50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C900", Offset = "0x7F6BD00", VA = "0x187F6C900")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event GPIDENABAMJ LJFLMIBFEJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7F6AD30", Offset = "0x7F6A130", VA = "0x187F6AD30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C9E0", Offset = "0x7F6BDE0", VA = "0x187F6C9E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event GPIDENABAMJ JFOIANHPPEA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7F6AE10", Offset = "0x7F6A210", VA = "0x187F6AE10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CAC0", Offset = "0x7F6BEC0", VA = "0x187F6CAC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event GPIDENABAMJ APLIDELNJCM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7F6ABE0", Offset = "0x7F69FE0", VA = "0x187F6ABE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C890", Offset = "0x7F6BC90", VA = "0x187F6C890")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x991DF0", Offset = "0x9911F0", VA = "0x180991DF0", Slot = "8")]
		private void DEFACFEEKDA(ABPNPGANBHP KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F69670", Offset = "0x7F68A70", VA = "0x187F69670", Slot = "9")]
		public MHBKLDJGOMO GetData()
		{
			return default(MHBKLDJGOMO);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F69A10", Offset = "0x7F68E10", VA = "0x187F69A10")]
		internal void JKJACAMMFKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A840", Offset = "0x7F69C40", VA = "0x187F6A840")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody AFAGNFKPAMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F693C0", Offset = "0x7F687C0", VA = "0x187F693C0")]
		public NFIBELDGELK GetChild(int KDCAMOIGIMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A500", Offset = "0x7F69900", VA = "0x187F6A500")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) JDPGMOJPEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7F69000", Offset = "0x7F68400", VA = "0x187F69000")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A790", Offset = "0x7F69B90", VA = "0x187F6A790")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7F69700", Offset = "0x7F68B00", VA = "0x187F69700")]
		private ABPNPGANBHP NINBNPBDMPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7F68530", Offset = "0x7F67930", VA = "0x187F68530")]
		private void AEJOPFDILPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7F69CD0", Offset = "0x7F690D0", VA = "0x187F69CD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7F69C10", Offset = "0x7F69010", VA = "0x187F69C10")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7F69A10", Offset = "0x7F68E10", VA = "0x187F69A10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7F69C70", Offset = "0x7F69070", VA = "0x187F69C70")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7F69D30", Offset = "0x7F69130", VA = "0x187F69D30")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F686B0", Offset = "0x7F67AB0", VA = "0x187F686B0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object HEJFDMJNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F69D90", Offset = "0x7F69190", VA = "0x187F69D90")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object HEJFDMJNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7F69350", Offset = "0x7F68750", VA = "0x187F69350")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7F69BB0", Offset = "0x7F68FB0", VA = "0x187F69BB0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A660", Offset = "0x7F69A60", VA = "0x187F6A660")]
		public void SetParent(RigidbodyEx FIIKLGCIAGG, bool AFNGBHPONPL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A0A0", Offset = "0x7F694A0", VA = "0x187F6A0A0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7F697B0", Offset = "0x7F68BB0", VA = "0x187F697B0")]
		public bool IsRigidbodyAncestor(RigidbodyEx DNNGPJEOBMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7F698B0", Offset = "0x7F68CB0", VA = "0x187F698B0")]
		public bool IsRigidbodyDescendant(RigidbodyEx HFKKFBAMOEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7F68920", Offset = "0x7F67D20", VA = "0x187F68920")]
		public void AddInterpolationRestriction(object HEJFDMJNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7F69E00", Offset = "0x7F69200", VA = "0x187F69E00")]
		public void RemoveInterpolationRestriction(object HEJFDMJNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7F68990", Offset = "0x7F67D90", VA = "0x187F68990")]
		public void AddKinematic(object HEJFDMJNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7F69E70", Offset = "0x7F69270", VA = "0x187F69E70")]
		public void RemoveKinematic(object HEJFDMJNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A5E0", Offset = "0x7F699E0", VA = "0x187F6A5E0")]
		public void SetKinematic(object HEJFDMJNIGB, bool ABPFJPCEHML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A400", Offset = "0x7F69800", VA = "0x187F6A400")]
		public void SetDiscontinuousPositionAndRotation(Vector3 MLDJJHKJDLF, Quaternion DOOMCOJKDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A300", Offset = "0x7F69700", VA = "0x187F6A300")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 PDMIDFCIAPG, Quaternion JKPGBJBJNEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7F69560", Offset = "0x7F68960", VA = "0x187F69560")]
		public Vector3 GetConstrainedVelocity(Vector3 APPPFHHBPEI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7F69450", Offset = "0x7F68850", VA = "0x187F69450")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 KNDCDNHAEAI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7F68830", Offset = "0x7F67C30", VA = "0x187F68830")]
		public void AddForce(Vector3 HEGINIGEJIB, ForceMode GABCLKPOPAL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7F68720", Offset = "0x7F67B20", VA = "0x187F68720")]
		public void AddForceAtPosition(Vector3 HEGINIGEJIB, Vector3 JPKKPDPLAGA, ForceMode GABCLKPOPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7F68B60", Offset = "0x7F67F60", VA = "0x187F68B60")]
		public void AddTorque(Vector3 JKFHICALMPP, ForceMode GABCLKPOPAL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7F68A00", Offset = "0x7F67E00", VA = "0x187F68A00")]
		public void AddRelativeTorque(Vector3 JKFHICALMPP, ForceMode GABCLKPOPAL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A910", Offset = "0x7F69D10", VA = "0x187F6A910")]
		public Vector3 WorldToLocalVelocity(Vector3 BIBMPFNJDHN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7F69AA0", Offset = "0x7F68EA0", VA = "0x187F69AA0")]
		public Vector3 LocalToWorldVelocity(Vector3 DKOOKAOCABK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7F692F0", Offset = "0x7F686F0", VA = "0x187F692F0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7F69290", Offset = "0x7F68690", VA = "0x187F69290")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7F69230", Offset = "0x7F68630", VA = "0x187F69230")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7F691D0", Offset = "0x7F685D0", VA = "0x187F691D0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A200", Offset = "0x7F69600", VA = "0x187F6A200")]
		public void ResetVelocityWorldSpace(Vector3 MFLOLBJJFAN, Vector3 OLILCJIJJPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A100", Offset = "0x7F69500", VA = "0x187F6A100")]
		public void ResetVelocityLocalSpace(Vector3 HCDBLHJEFCC, Vector3 DGBDKEHBLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7F69FC0", Offset = "0x7F693C0", VA = "0x187F69FC0")]
		public void ResetLinearVelocityLocalSpace(Vector3 HCDBLHJEFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A7A0", Offset = "0x7F69BA0", VA = "0x187F6A7A0")]
		public bool SweepTest(Vector3 DLBKBBJEBDD, [Out] RaycastHit OOEIPEFIGGM, float DIHBFHDIEJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7F699B0", Offset = "0x7F68DB0", VA = "0x187F699B0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A730", Offset = "0x7F69B30", VA = "0x187F6A730")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A8B0", Offset = "0x7F69CB0", VA = "0x187F6A8B0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7F68AF0", Offset = "0x7F67EF0", VA = "0x187F68AF0")]
		public void AddShouldHaveUnityRigidbodyToken(object HEJFDMJNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7F69EE0", Offset = "0x7F692E0", VA = "0x187F69EE0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object HEJFDMJNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7F68E90", Offset = "0x7F68290", VA = "0x187F68E90")]
		public void ApplyForceVelocityChange(MKCFIBLOAOL BGLADFLHHKF, Vector3 AGDHNHLHGLH, float LBELLPAGBED, float IMNOGCHOKIO = 8f, float OKEDDGNFDNJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F68DF0", Offset = "0x7F681F0", VA = "0x187F68DF0")]
		public void ApplyAngularVelocityChange(CPBDFAEEPJE FNJKBBLHAEP, Vector3 GJJMKPHOIEI, float CHIDEEDFLPE = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7F68F50", Offset = "0x7F68350", VA = "0x187F68F50")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(CPBDFAEEPJE FNJKBBLHAEP, Vector3 BENMKDDDBDG, float NLOEFCPHCMO = 7f, float NMGNOONDDJM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7F68D20", Offset = "0x7F68120", VA = "0x187F68D20")]
		public bool AllowedScaleChange(float FJCBEEKIKKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7F68C50", Offset = "0x7F68050", VA = "0x187F68C50")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx FOKNBBMEPAI, object HEJFDMJNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7F69F50", Offset = "0x7F69350", VA = "0x187F69F50")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object HEJFDMJNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F693B0", Offset = "0x7F687B0", VA = "0x187F693B0", Slot = "12")]
		private void FFOLBKOEMCN(BPMCNODDCDP PFPNPMCGHHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AAA0", Offset = "0x7F69EA0", VA = "0x187F6AAA0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB0D540", Offset = "0xB0C940", VA = "0x180B0D540", Slot = "4")]
		private GameObject IFPCHGPLJOJ()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9BDB30", Offset = "0x9BCF30", VA = "0x1809BDB30", Slot = "10")]
		private bool DBFPPDPFIPJ()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class ABHGMGCOIMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F51AB0", Offset = "0x7F50EB0", VA = "0x187F51AB0")]
	public static ABPNPGANBHP NBCLFPBJMAA(this RigidbodyEx GFMEDDDNANC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(LPEAJCAOGEO), new string[] { })]
public class GABHCKKBELJ : LPEAJCAOGEO, IHCCKBEFLCO
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private NOANFBMLPEH MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private LIGPLJIGNDK OLPDMNHMICP;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NOANFBMLPEH OGNNDGMLFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public LIGPLJIGNDK JJAEJGCBAFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F54AE0", Offset = "0x7F53EE0", VA = "0x187F54AE0", Slot = "7")]
	public void InitReferences(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F549B0", Offset = "0x7F53DB0", VA = "0x187F549B0", Slot = "6")]
	public ABPNPGANBHP HLNLBBPBIKA(RigidbodyEx GFMEDDDNANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public GABHCKKBELJ()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static OLDENIALAEA UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int FFLLLPJJPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int KLHLHPDBOOM;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F683B0", Offset = "0x7F677B0", VA = "0x187F683B0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7F683F0", Offset = "0x7F677F0", VA = "0x187F683F0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7F683D0", Offset = "0x7F677D0", VA = "0x187F683D0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string EIGJGBPHOMK, [Optional] UnityEngine.Object PFPNPMCGHHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string EIGJGBPHOMK, [Optional] UnityEngine.Object PFPNPMCGHHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7F684E0", Offset = "0x7F678E0", VA = "0x187F684E0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DJIFHHJDKBM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class MMFNLNNHFLB : MBIEHGKALBL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A00", Offset = "0x9A0E00", VA = "0x1809A1A00", Slot = "4")]
		public Vector3 BHENEBLMGLB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A00", Offset = "0x9A0E00", VA = "0x1809A1A00", Slot = "5")]
		public Vector3 JDCHDEPPCCJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "6")]
		public bool EMNDPFHJPNE(float OKOLCPMBOJC, float PHNAHBGECDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MMFNLNNHFLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static MBIEHGKALBL BILAMANOMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F51D60", Offset = "0x7F51160", VA = "0x187F51D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DJPCDPJPCLD
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode LNKDIGIOAAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CBNFMMEJBDH();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JEHGKHFMALB(bool PKHJAFFAAAC);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECGEMHCJOAM(bool PKHJAFFAAAC);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BLIMLPFEJGA(Rigidbody COMCLPGENOG);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BLOJPOCBLHN(Vector3 DLBKBBJEBDD, [Out] RaycastHit OOEIPEFIGGM, float DIHBFHDIEJB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LMPHFKIGLEG : IDisposable, LALFMDHBCFM
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GDMNGFOCBGE CIPGJOKIEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<GPKPAEJIOJM, GPKPAEJIOJM> DGDACCPKEMF;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CBNFMMEJBDH();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface LIGPLJIGNDK
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FBOIFHJOBNJ IOHMKIDJAGJ(ABPNPGANBHP KKDALLBMKBI);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DBPCILMDGMD EOHHAIHHJJJ(ABPNPGANBHP KKDALLBMKBI);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GKJHJCDKENI PEJMGMILPKF(ABPNPGANBHP KKDALLBMKBI);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FPEJNOBHICC BJBJJICDFFM(ABPNPGANBHP KKDALLBMKBI);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HPIGFHCLCMI JKENCDPDCMG(ABPNPGANBHP KKDALLBMKBI);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LMPHFKIGLEG OFNJCJLEDPP(ABPNPGANBHP KKDALLBMKBI);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FBJEDNAGIGL LDEJLHKNOGM(ABPNPGANBHP KKDALLBMKBI);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PKBJJCGKHNG FJPCILKFONC(ABPNPGANBHP KKDALLBMKBI);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DJPCDPJPCLD HNICKLOPJFL(ABPNPGANBHP KKDALLBMKBI);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KLLGIDCCFGJ HEIGMAOFCOH(ABPNPGANBHP KKDALLBMKBI);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MDGIPIMJHGM INMAMPKJFOJ(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FLDKJMJIPHJ GOPDDKMGEMA(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ODAJCLOPNKH LKIBHBFNKAF(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MANAINKOLAE HGILLMDOBBI(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NNPJLLLEEIL BFMBCNIFAPA(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ABPNPGANBHP HLNLBBPBIKA(RigidbodyEx GFMEDDDNANC, MHBKLDJGOMO AMHCLKHIFKH, LPEAJCAOGEO ECPDNOJCJEA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PKBJJCGKHNG
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFIMLDICNMO(Vector3 HEGINIGEJIB, ForceMode GABCLKPOPAL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFPOKLAMMGF(Vector3 HEGINIGEJIB, Vector3 JPKKPDPLAGA, ForceMode GABCLKPOPAL);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMCKIPAKBHE(Vector3 JKFHICALMPP, ForceMode GABCLKPOPAL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CFHCHDAEEKA(Vector3 JKFHICALMPP, ForceMode GABCLKPOPAL = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KLLGIDCCFGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool OABNKIIPEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLIMLPFEJGA(Rigidbody COMCLPGENOG);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DMDHHFOCCLM(Rigidbody COMCLPGENOG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FBOIFHJOBNJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<ABPNPGANBHP> GOIMIEIGHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ABPNPGANBHP OFMCPLOCJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	ABPNPGANBHP DHHOIDHGNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event GPIDENABAMJ AAEODNCKGDC;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event GPIDENABAMJ ICNCDCNELHO;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event HIBPMBDIIHN DMKGFBBAMMD;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action EHFGMODGAFM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action CPMJIKBODKH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<ABPNPGANBHP> MPHCBABFJKN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<ABPNPGANBHP> JDCMCCPMIJC;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action KENHKLDMPFE;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<ABPNPGANBHP> HFDEHHCKLOM;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MEECIGHOFNG(ABPNPGANBHP DPOGHMAJNAL, bool AFNGBHPONPL = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GKJHJCDKENI
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 FIHKAKPAEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 NJOEFMNFIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKKJNOPKEDN(ABPNPGANBHP PBIFOHNGFLL, object HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MLDMFGPNAGM(object HEJFDMJNIGB);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MANAINKOLAE
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 DHEOELELEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 MFJPIABNDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float IDILBJNLFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float KHHHPLLGBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 IIBPDJKEGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion KHIPDNEPOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event GPIDENABAMJ INGLCPFOMKN;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NPGHKIBGLOJ((Quaternion rot, Vector3 moments) JDPGMOJPEJH);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AMPANMEHBAJ();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EJNMHEHDJAO();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LPIDANGHMAD();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BLIMLPFEJGA(Rigidbody COMCLPGENOG);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DMDHHFOCCLM(Rigidbody COMCLPGENOG);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NBBNNHEIMPM();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ODAJCLOPNKH
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBNFMMEJBDH();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFIDBLKDFND(object HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFDFLIBPKAL(object HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IOHAHINACIH(ABPNPGANBHP GFMEDDDNANC);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGAODLMFIAK(ABPNPGANBHP GFMEDDDNANC);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MELOPOCFMEA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FBJEDNAGIGL
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool AGIEDJEBCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event GPIDENABAMJ DBJBBFONLHL;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LGKPPJMIBHI(object HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BGOBBPBCLNB(object HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHHHMHGONEH(object HEJFDMJNIGB, bool ABPFJPCEHML);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BLIMLPFEJGA(Rigidbody KPFMMNMCDOD);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DMDHHFOCCLM(Rigidbody COMCLPGENOG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FLDKJMJIPHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool EECHAMFCOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool HNEOKNHIFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event GPIDENABAMJ HJJPPDJCLNP;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CBNFMMEJBDH();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JKNIGBHGJEP(ABPNPGANBHP PBIFOHNGFLL);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EMAGNAGFONI(ABPNPGANBHP PBIFOHNGFLL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NNPJLLLEEIL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool DAPFLDLDOIN
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool ELPLLDLCILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints EPHIBNCPBKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BLIMLPFEJGA(Rigidbody COMCLPGENOG);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DMDHHFOCCLM(Rigidbody COMCLPGENOG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FPEJNOBHICC
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float ICIOKBHPMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float DNGLPCEHJBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLIMLPFEJGA(Rigidbody COMCLPGENOG);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DMDHHFOCCLM(Rigidbody COMCLPGENOG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HPIGFHCLCMI
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool PGJKIHAENDK;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event GPIDENABAMJ CFOPMACODOH;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CBNFMMEJBDH();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JFNOKHADCEB();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BOMPPCOCJAL();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GJFOLMOILPE();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CEKIEOBMOJN();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JCGNBANABHB();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CPNDKNDPJHP(bool DBIKHNEGCJB);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CDDHGOGLNLE();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MDGIPIMJHGM
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody PCCLPPLGLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool EGCGEHDBFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBNFMMEJBDH();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PKGDLNOFFAD(object HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KLLOFBBEJHD(object HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NPDMDNNMFDC();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DBPCILMDGMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	MBIEHGKALBL OAGGEAOJCID
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	EANAJLOACDP MPNOFNPOHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 JFHHNMDFJLH
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 KLCGOIFMDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 KACGJOFGFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 ABOMJEBMGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float NLAEEPGFOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool GOJJGCIMGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CBNFMMEJBDH();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LOHPHHJLAOM(object HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EDADPIMKJFM(CPBDFAEEPJE FNJKBBLHAEP, Vector3 GJJMKPHOIEI, float CHIDEEDFLPE = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FNDGFADDOAK(MKCFIBLOAOL BGLADFLHHKF, Vector3 AGDHNHLHGLH, float LBELLPAGBED, float IMNOGCHOKIO = 8f, float OKEDDGNFDNJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JLBJNKEOFNO(CPBDFAEEPJE FNJKBBLHAEP, Vector3 BENMKDDDBDG, float NLOEFCPHCMO = 7f, float NMGNOONDDJM = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OEPIDIHHPHN();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NFELBKGHMGK();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CFECGDNLHCJ();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void IOLODGPALJM();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BLIMLPFEJGA(Rigidbody COMCLPGENOG);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 NBHBNLJLOJM(Vector3 APPPFHHBPEI);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void EAFOKDOGKDG(object HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void OHMJKDJBLJH(Vector3 MHABPNKEBDF);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void DJBEDAAFHJD(Vector3 HCDBLHJEFCC, Vector3 DGBDKEHBLNN);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LHFCKNCENKB(Vector3 MFLOLBJJFAN, Vector3 OLILCJIJJPJ);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 CBEENJNMBPD(Vector3 DKOOKAOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 GGHHHBBPAHD(Vector3 BIBMPFNJDHN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface NOANFBMLPEH
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool LAGBPCPILCG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HAOOELDBOEB(string DFEFGBECJNJ);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HOHALFOFNAC(RigidbodyEx GFMEDDDNANC, Action AKLHLNJOCEK);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OIAJDJPLGCF NIMDCJBMJLO(int HPKLPFGLEEE);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCMJKLKHLDG(Vector3 HBCNLDFDEHD, float KHBDCJIBNML, Color CKANMCILFBE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface LPEAJCAOGEO
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	NOANFBMLPEH OGNNDGMLFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	LIGPLJIGNDK JJAEJGCBAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ABPNPGANBHP HLNLBBPBIKA(RigidbodyEx GFMEDDDNANC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MCPBFHABCGI : ABPNPGANBHP, IDisposable, AGKJBAALLCP
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool BMKMLMIPMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly LPEAJCAOGEO ECPDNOJCJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal FBOIFHJOBNJ PANHPCJJMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal ODAJCLOPNKH FBIPKEJIHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal FLDKJMJIPHJ LFENNGLFPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal DBPCILMDGMD APPPFHHBPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal GKJHJCDKENI GAFKDEIHEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal MANAINKOLAE GBFDFNDCEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal FPEJNOBHICC OKPGMMJHFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal KLLGIDCCFGJ JIANMMDDGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal HPIGFHCLCMI APDOPDODKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal LMPHFKIGLEG MFAGMEPLOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal FBJEDNAGIGL OMKGKJJBPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal PKBJJCGKHNG HEGINIGEJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal NNPJLLLEEIL CKPDHBHHMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal MDGIPIMJHGM COMCLPGENOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal DJPCDPJPCLD IPHKOCINJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable HIOOKKKKJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool EKIMFAOIJCL;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public PMMHELJLBHE GCAGKJECMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "22")]
		get
		{
			return default(PMMHELJLBHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public NFIBELDGELK LHJEEEFGHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xC2B3E0", Offset = "0xC2A7E0", VA = "0x180C2B3E0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xD940F0", Offset = "0xD934F0", VA = "0x180D940F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject JAHMEOIAOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x999C90", Offset = "0x999090", VA = "0x180999C90", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x999C50", Offset = "0x999050", VA = "0x180999C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform GFBMHFBKABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB7A750", Offset = "0xB79B50", VA = "0x180B7A750", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xDA8080", Offset = "0xDA7480", VA = "0x180DA8080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody PCCLPPLGLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CAC0", Offset = "0x7F5BEC0", VA = "0x187F5CAC0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public ABPNPGANBHP DHHOIDHGNKB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7F5EA00", Offset = "0x7F5DE00", VA = "0x187F5EA00", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CA60", Offset = "0x7F5BE60", VA = "0x187F5CA60", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int BOEFJFFDNFN
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7F62560", Offset = "0x7F61960", VA = "0x187F62560", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public ABPNPGANBHP OFMCPLOCJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C4B0", Offset = "0x7F5B8B0", VA = "0x187F5C4B0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool IJOBLCOANHP
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7F60B70", Offset = "0x7F5FF70", VA = "0x187F60B70", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool EECHAMFCOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C890", Offset = "0x7F5BC90", VA = "0x187F5C890", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool HNEOKNHIFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7F60070", Offset = "0x7F5F470", VA = "0x187F60070", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public MBIEHGKALBL OAGGEAOJCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7F60DB0", Offset = "0x7F601B0", VA = "0x187F60DB0", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E610", Offset = "0x7F5DA10", VA = "0x187F5E610", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public EANAJLOACDP MPNOFNPOHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E0B0", Offset = "0x7F5D4B0", VA = "0x187F5E0B0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7F60970", Offset = "0x7F5FD70", VA = "0x187F60970", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float NLAEEPGFOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7F620F0", Offset = "0x7F614F0", VA = "0x187F620F0", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7F61EC0", Offset = "0x7F612C0", VA = "0x187F61EC0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 KLCGOIFMDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7F615E0", Offset = "0x7F609E0", VA = "0x187F615E0", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7F61B90", Offset = "0x7F60F90", VA = "0x187F61B90", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 ABOMJEBMGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7F5EF80", Offset = "0x7F5E380", VA = "0x187F5EF80", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7F5EBA0", Offset = "0x7F5DFA0", VA = "0x187F5EBA0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 JFHHNMDFJLH
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C090", Offset = "0x7F5B490", VA = "0x187F5C090", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D180", Offset = "0x7F5C580", VA = "0x187F5D180", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 KACGJOFGFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7F5FAA0", Offset = "0x7F5EEA0", VA = "0x187F5FAA0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7F61F90", Offset = "0x7F61390", VA = "0x187F61F90", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool DJKGDLKOJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D50", Offset = "0x7F61150", VA = "0x187F61D50", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool BMPFOOBGIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7F5ED80", Offset = "0x7F5E180", VA = "0x187F5ED80", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool KLOIFCAIMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DF70", Offset = "0x7F5D370", VA = "0x187F5DF70", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool GOJJGCIMGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7F5ECD0", Offset = "0x7F5E0D0", VA = "0x187F5ECD0", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 FIHKAKPAEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F7B0", Offset = "0x7F5EBB0", VA = "0x187F5F7B0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 NJOEFMNFIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CCB0", Offset = "0x7F5C0B0", VA = "0x187F5CCB0", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 DHEOELELEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F60E00", Offset = "0x7F60200", VA = "0x187F60E00", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F880", Offset = "0x7F5EC80", VA = "0x187F5F880", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 MFJPIABNDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C3D0", Offset = "0x7F5B7D0", VA = "0x187F5C3D0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float IDILBJNLFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F60D00", Offset = "0x7F60100", VA = "0x187F60D00", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float KHHHPLLGBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D780", Offset = "0x7F5CB80", VA = "0x187F5D780", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F5ED20", Offset = "0x7F5E120", VA = "0x187F5ED20", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 IIBPDJKEGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E530", Offset = "0x7F5D930", VA = "0x187F5E530", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion KHIPDNEPOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F210", Offset = "0x7F5E610", VA = "0x187F5F210", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float ICIOKBHPMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F61AF0", Offset = "0x7F60EF0", VA = "0x187F61AF0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C320", Offset = "0x7F5B720", VA = "0x187F5C320", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float DNGLPCEHJBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DCB0", Offset = "0x7F5D0B0", VA = "0x187F5DCB0", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7F60D50", Offset = "0x7F60150", VA = "0x187F60D50", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool OABNKIIPEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F608D0", Offset = "0x7F5FCD0", VA = "0x187F608D0", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E050", Offset = "0x7F5D450", VA = "0x187F5E050", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public GDMNGFOCBGE CIPGJOKIEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F5EB50", Offset = "0x7F5DF50", VA = "0x187F5EB50", Slot = "70")]
		get
		{
			return default(GDMNGFOCBGE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F520", Offset = "0x7F5E920", VA = "0x187F5F520", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool AGIEDJEBCBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E7C0", Offset = "0x7F5DBC0", VA = "0x187F5E7C0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform KFBNOFJKFOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xB7A750", Offset = "0xB79B50", VA = "0x180B7A750", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 HKCKOLMCNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F62330", Offset = "0x7F61730", VA = "0x187F62330", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C270", Offset = "0x7F5B670", VA = "0x187F5C270", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float CPJHIDFOMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C500", Offset = "0x7F5B900", VA = "0x187F5C500", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F61F20", Offset = "0x7F61320", VA = "0x187F61F20", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float OONPNOBNMFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DBA0", Offset = "0x7F5CFA0", VA = "0x187F5DBA0", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F62250", Offset = "0x7F61650", VA = "0x187F62250", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion DDMNKOBANOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C170", Offset = "0x7F5B570", VA = "0x187F5C170", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D0A0", Offset = "0x7F5C4A0", VA = "0x187F5D0A0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 FGILNKLNPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F060", Offset = "0x7F5E460", VA = "0x187F5F060", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F5FFD0", Offset = "0x7F5F3D0", VA = "0x187F5FFD0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion MECFJFDBHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D740", Offset = "0x7F5CB40", VA = "0x187F5D740", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F5FA70", Offset = "0x7F5EE70", VA = "0x187F5FA70", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints EPHIBNCPBKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DF20", Offset = "0x7F5D320", VA = "0x187F5DF20", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E860", Offset = "0x7F5DC60", VA = "0x187F5E860", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool DAPFLDLDOIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F580", Offset = "0x7F5E980", VA = "0x187F5F580", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E100", Offset = "0x7F5D500", VA = "0x187F5E100", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode LNKDIGIOAAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F614D0", Offset = "0x7F608D0", VA = "0x187F614D0", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7F61E00", Offset = "0x7F61200", VA = "0x187F61E00", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool LFLDNOHIFOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7F609D0", Offset = "0x7F5FDD0", VA = "0x187F609D0", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool NEMHFFDMFKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C8E0", Offset = "0x7F5BCE0", VA = "0x187F5C8E0", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event GPIDENABAMJ AAEODNCKGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7F5EEA0", Offset = "0x7F5E2A0", VA = "0x187F5EEA0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7F61DA0", Offset = "0x7F611A0", VA = "0x187F61DA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event GPIDENABAMJ ICNCDCNELHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E8C0", Offset = "0x7F5DCC0", VA = "0x187F5E8C0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CD90", Offset = "0x7F5C190", VA = "0x187F5CD90", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event HIBPMBDIIHN DMKGFBBAMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7F61520", Offset = "0x7F60920", VA = "0x187F61520", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7F60C40", Offset = "0x7F60040", VA = "0x187F60C40", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event GPIDENABAMJ HJJPPDJCLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7F5EE40", Offset = "0x7F5E240", VA = "0x187F5EE40", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7F619B0", Offset = "0x7F60DB0", VA = "0x187F619B0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event GPIDENABAMJ BEAPIEPMNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C210", Offset = "0x7F5B610", VA = "0x187F5C210", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7F60CA0", Offset = "0x7F600A0", VA = "0x187F60CA0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event GPIDENABAMJ CFOPMACODOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DDA0", Offset = "0x7F5D1A0", VA = "0x187F5DDA0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C510", Offset = "0x7F5B910", VA = "0x187F5C510", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<GPKPAEJIOJM, GPKPAEJIOJM> DGDACCPKEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F5EF00", Offset = "0x7F5E300", VA = "0x187F5EF00", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F61E60", Offset = "0x7F61260", VA = "0x187F61E60", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event GPIDENABAMJ DBJBBFONLHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F60B10", Offset = "0x7F5FF10", VA = "0x187F60B10", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7F61580", Offset = "0x7F60980", VA = "0x187F61580", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event GPIDENABAMJ APLIDELNJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F160", Offset = "0x7F5E560", VA = "0x187F5F160", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F9C0", Offset = "0x7F5EDC0", VA = "0x187F5F9C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7F62670", Offset = "0x7F61A70", VA = "0x187F62670")]
	public MCPBFHABCGI(GameObject MKMGIAEJNDJ, RigidbodyEx JJMBAHNFBMH, LPEAJCAOGEO ECPDNOJCJEA, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7F616C0", Offset = "0x7F60AC0", VA = "0x187F616C0", Slot = "139")]
	protected virtual void NHCAALFBLMO(LPEAJCAOGEO ECPDNOJCJEA, MHBKLDJGOMO AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DBB0", Offset = "0x7F5CFB0", VA = "0x187F5DBB0", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CEF0", Offset = "0x7F5C2F0", VA = "0x187F5CEF0", Slot = "93")]
	public void CBNFMMEJBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7F607C0", Offset = "0x7F5FBC0", VA = "0x187F607C0", Slot = "94")]
	public void LLMLFNBIJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7F5EDE0", Offset = "0x7F5E1E0", VA = "0x187F5EDE0", Slot = "95")]
	public void HKHMHHNKGHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7F5EF60", Offset = "0x7F5E360", VA = "0x187F5EF60", Slot = "96")]
	public void IDLNIFCMKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D4C0", Offset = "0x7F5C8C0", VA = "0x187F5D4C0")]
	private void CPNDKNDPJHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7F60850", Offset = "0x7F5FC50", VA = "0x187F60850")]
	private void LMGPMKKIGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F410", Offset = "0x7F5E810", VA = "0x187F5F410")]
	private void JCGNBANABHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7F62070", Offset = "0x7F61470", VA = "0x187F62070", Slot = "30")]
	public ABPNPGANBHP PCBLLHJHMGG(int KDCAMOIGIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7F60BD0", Offset = "0x7F5FFD0", VA = "0x187F60BD0", Slot = "98")]
	public void MEECIGHOFNG(ABPNPGANBHP FIIKLGCIAGG, bool AFNGBHPONPL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F960", Offset = "0x7F5ED60", VA = "0x187F5F960", Slot = "99")]
	public void KADBLJBFJOL(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F750", Offset = "0x7F5EB50", VA = "0x187F5F750", Slot = "100")]
	public void JLFBHPJDILA(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7F5EA50", Offset = "0x7F5DE50", VA = "0x187F5EA50", Slot = "101")]
	public Vector3 GGHHHBBPAHD(Vector3 BIBMPFNJDHN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CDF0", Offset = "0x7F5C1F0", VA = "0x187F5CDF0", Slot = "102")]
	public Vector3 CBEENJNMBPD(Vector3 DKOOKAOCABK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F110", Offset = "0x7F5E510", VA = "0x187F5F110", Slot = "103")]
	public void IOLODGPALJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7F61480", Offset = "0x7F60880", VA = "0x187F61480", Slot = "104")]
	public void NFELBKGHMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7F61B40", Offset = "0x7F60F40", VA = "0x187F61B40", Slot = "105")]
	public void OEPIDIHHPHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7F600C0", Offset = "0x7F5F4C0", VA = "0x187F600C0", Slot = "106")]
	public void LHFCKNCENKB(Vector3 MFLOLBJJFAN, Vector3 OLILCJIJJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DAB0", Offset = "0x7F5CEB0", VA = "0x187F5DAB0", Slot = "107")]
	public void DJBEDAAFHJD(Vector3 HCDBLHJEFCC, Vector3 DGBDKEHBLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F61C70", Offset = "0x7F61070", VA = "0x187F61C70", Slot = "108")]
	public void OHMJKDJBLJH(Vector3 MHABPNKEBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E700", Offset = "0x7F5DB00", VA = "0x187F5E700", Slot = "109")]
	public void FNDGFADDOAK(MKCFIBLOAOL BGLADFLHHKF, Vector3 AGDHNHLHGLH, float LBELLPAGBED, float IMNOGCHOKIO = 8f, float OKEDDGNFDNJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DD00", Offset = "0x7F5D100", VA = "0x187F5DD00", Slot = "110")]
	public void EDADPIMKJFM(CPBDFAEEPJE FNJKBBLHAEP, Vector3 GJJMKPHOIEI, float CHIDEEDFLPE = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F6A0", Offset = "0x7F5EAA0", VA = "0x187F5F6A0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JLBJNKEOFNO(CPBDFAEEPJE FNJKBBLHAEP, Vector3 BENMKDDDBDG, float NLOEFCPHCMO = 7f, float NMGNOONDDJM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F60F30", Offset = "0x7F60330", VA = "0x187F60F30", Slot = "112")]
	public Vector3 NBHBNLJLOJM(Vector3 FIIKLGCIAGG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CBB0", Offset = "0x7F5BFB0", VA = "0x187F5CBB0", Slot = "113")]
	public Vector3 BMLODMDNGFN(Vector3 FIIKLGCIAGG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D260", Offset = "0x7F5C660", VA = "0x187F5D260", Slot = "114")]
	public void CFECGDNLHCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F0A0", Offset = "0x7F5E4A0", VA = "0x187F5F0A0", Slot = "115")]
	public void IJOHHDLFDFA(ABPNPGANBHP FOKNBBMEPAI, object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F4C0", Offset = "0x7F5E8C0", VA = "0x187F5F4C0", Slot = "116")]
	public void JGAPDFOGKDP(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F61A10", Offset = "0x7F60E10", VA = "0x187F61A10", Slot = "63")]
	public void NPGHKIBGLOJ((Quaternion rot, Vector3 moments) JDPGMOJPEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DE00", Offset = "0x7F5D200", VA = "0x187F5DE00", Slot = "117")]
	public void EJNMHEHDJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C380", Offset = "0x7F5B780", VA = "0x187F5C380", Slot = "118")]
	public void AMPANMEHBAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F60920", Offset = "0x7F5FD20", VA = "0x187F60920", Slot = "119")]
	public void LPIDANGHMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F470", Offset = "0x7F5E870", VA = "0x187F5F470", Slot = "120")]
	public bool JFNOKHADCEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F5EC80", Offset = "0x7F5E080", VA = "0x187F5EC80", Slot = "97")]
	public void GJFOLMOILPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D030", Offset = "0x7F5C430", VA = "0x187F5D030", Slot = "121")]
	public void CDDHGOGLNLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F60010", Offset = "0x7F5F410", VA = "0x187F60010", Slot = "122")]
	public void LGKPPJMIBHI(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C570", Offset = "0x7F5B970", VA = "0x187F5C570", Slot = "123")]
	public void BGOBBPBCLNB(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E4C0", Offset = "0x7F5D8C0", VA = "0x187F5E4C0", Slot = "124")]
	public void FHHHMHGONEH(object HEJFDMJNIGB, bool ABPFJPCEHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F5FCC0", Offset = "0x7F5F0C0", VA = "0x187F5FCC0", Slot = "125")]
	public void KPCPLIGAFMP(Vector3 MLDJJHKJDLF, Quaternion DOOMCOJKDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D980", Offset = "0x7F5CD80", VA = "0x187F5D980", Slot = "126")]
	public void DICIBPHBBCF(Vector3 PDMIDFCIAPG, Quaternion JKPGBJBJNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E810", Offset = "0x7F5DC10", VA = "0x187F5E810", Slot = "127")]
	public bool FPDLHLHGHIB(float FJCBEEKIKKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F2E0", Offset = "0x7F5E6E0", VA = "0x187F5F2E0", Slot = "128")]
	public void JBEHDIDDEJF(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F625D0", Offset = "0x7F619D0", VA = "0x187F625D0", Slot = "129")]
	public void PONPLHDJHHA(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F623E0", Offset = "0x7F617E0", VA = "0x187F623E0", Slot = "130")]
	public void PKGDLNOFFAD(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7F5FB80", Offset = "0x7F5EF80", VA = "0x187F5FB80", Slot = "131")]
	public void KLLOFBBEJHD(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E920", Offset = "0x7F5DD20", VA = "0x187F5E920", Slot = "132")]
	public void GFIMLDICNMO(Vector3 HEGINIGEJIB, ForceMode GABCLKPOPAL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7F62140", Offset = "0x7F61540", VA = "0x187F62140", Slot = "133")]
	public void PFPOKLAMMGF(Vector3 HEGINIGEJIB, Vector3 JPKKPDPLAGA, ForceMode GABCLKPOPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7F5FBE0", Offset = "0x7F5EFE0", VA = "0x187F5FBE0", Slot = "134")]
	public void KMCKIPAKBHE(Vector3 JKFHICALMPP, ForceMode GABCLKPOPAL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D2B0", Offset = "0x7F5C6B0", VA = "0x187F5D2B0", Slot = "135")]
	public void CFHCHDAEEKA(Vector3 JKFHICALMPP, ForceMode GABCLKPOPAL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CB10", Offset = "0x7F5BF10", VA = "0x187F5CB10", Slot = "136")]
	public bool BLOJPOCBLHN(Vector3 DLBKBBJEBDD, [Out] RaycastHit OOEIPEFIGGM, float DIHBFHDIEJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7F60EE0", Offset = "0x7F602E0", VA = "0x187F60EE0", Slot = "137")]
	public void NBBNNHEIMPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7F62630", Offset = "0x7F61A30", VA = "0x187F62630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F340", Offset = "0x7F5E740", VA = "0x187F5F340")]
	private void JCBEPOIHJGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7F5FEC0", Offset = "0x7F5F2C0", VA = "0x187F5FEC0")]
	private void LAGDNJHCBBO(ABPNPGANBHP PBIFOHNGFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7F605E0", Offset = "0x7F5F9E0", VA = "0x187F605E0")]
	private void LLLHDHBEHAA(ABPNPGANBHP PBIFOHNGFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7F60530", Offset = "0x7F5F930", VA = "0x187F60530")]
	private void LLFJILIGHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F62440", Offset = "0x7F61840", VA = "0x187F62440")]
	private void PKKGAHCGCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D7D0", Offset = "0x7F5CBD0", VA = "0x187F5D7D0")]
	private void DEPLPMPEGKG(ABPNPGANBHP IMHLCBJKIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F5D0", Offset = "0x7F5E9D0", VA = "0x187F5F5D0")]
	private void JKNIGBHGJEP(ABPNPGANBHP PBIFOHNGFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DE50", Offset = "0x7F5D250", VA = "0x187F5DE50")]
	private void EMAGNAGFONI(ABPNPGANBHP PBIFOHNGFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C5D0", Offset = "0x7F5B9D0", VA = "0x187F5C5D0")]
	private void BHEKGPMBFGO(NFIBELDGELK PBIFOHNGFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7F61030", Offset = "0x7F60430", VA = "0x187F61030", Slot = "142")]
	protected virtual void NEOOHMPHMON(NFIBELDGELK GFMEDDDNANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E160", Offset = "0x7F5D560", VA = "0x187F5E160")]
	protected void FFCGKAAADNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7F601B0", Offset = "0x7F5F5B0", VA = "0x187F601B0")]
	protected void LKDHKHLPIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D390", Offset = "0x7F5C790", VA = "0x187F5D390")]
	private void CFNMMEDFBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C720", Offset = "0x7F5BB20", VA = "0x187F5C720")]
	private void BHPIABLCEFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class NECAOBNDIFK
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7F62A20", Offset = "0x7F61E20", VA = "0x187F62A20")]
	public static ABPNPGANBHP PAFJIBLPLKM(this ABPNPGANBHP GFMEDDDNANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7F62980", Offset = "0x7F61D80", VA = "0x187F62980")]
	public static bool FKHNMPFIECF(this ABPNPGANBHP GFMEDDDNANC, ABPNPGANBHP DNNGPJEOBMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7F62820", Offset = "0x7F61C20", VA = "0x187F62820")]
	public static bool DCACGGPIJPJ(this ABPNPGANBHP GFMEDDDNANC, ABPNPGANBHP HFKKFBAMOEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7F628C0", Offset = "0x7F61CC0", VA = "0x187F628C0")]
	public static NFIBELDGELK DNDOOPEFKON(this ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7F62910", Offset = "0x7F61D10", VA = "0x187F62910")]
	public static MCPBFHABCGI FDIBAKAAFDN(this ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ICKNCLLAGPF : LIGPLJIGNDK
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7F568F0", Offset = "0x7F55CF0", VA = "0x187F568F0", Slot = "19")]
	public ABPNPGANBHP HLNLBBPBIKA(RigidbodyEx GFMEDDDNANC, MHBKLDJGOMO AMHCLKHIFKH, LPEAJCAOGEO ECPDNOJCJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "4")]
	public FBOIFHJOBNJ IOHMKIDJAGJ(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "5")]
	public DBPCILMDGMD EOHHAIHHJJJ(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "6")]
	public GKJHJCDKENI PEJMGMILPKF(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "7")]
	public FPEJNOBHICC BJBJJICDFFM(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "8")]
	public HPIGFHCLCMI JKENCDPDCMG(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "9")]
	public LMPHFKIGLEG OFNJCJLEDPP(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "10")]
	public FBJEDNAGIGL LDEJLHKNOGM(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "11")]
	public PKBJJCGKHNG FJPCILKFONC(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "12")]
	public DJPCDPJPCLD HNICKLOPJFL(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "13")]
	public KLLGIDCCFGJ HEIGMAOFCOH(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350")]
	public MDGIPIMJHGM INMAMPKJFOJ(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350")]
	public FLDKJMJIPHJ GOPDDKMGEMA(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350")]
	public ODAJCLOPNKH LKIBHBFNKAF(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350")]
	public MANAINKOLAE HGILLMDOBBI(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350")]
	public NNPJLLLEEIL BFMBCNIFAPA(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public ICKNCLLAGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "14")]
	private MDGIPIMJHGM GJALPIEJHNM(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "15")]
	private FLDKJMJIPHJ NGDLHOKPHOM(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "16")]
	private ODAJCLOPNKH APLNBDFOPEN(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "17")]
	private MANAINKOLAE MDBBHJEKLNA(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "18")]
	private NNPJLLLEEIL DJBCJHJLONJ(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(LIGPLJIGNDK), new string[] { })]
public class ECFOPIFBIDN : LIGPLJIGNDK, IHCCKBEFLCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly LIGPLJIGNDK AOMNNEICHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly LIGPLJIGNDK IKHHOKGFBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private HPNLNJDOCDA KMMHJFEAHEE;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private LIGPLJIGNDK JJAEJGCBAFM
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7F52420", Offset = "0x7F51820", VA = "0x187F52420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7F526A0", Offset = "0x7F51AA0", VA = "0x187F526A0", Slot = "20")]
	public void InitReferences(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7F52600", Offset = "0x7F51A00", VA = "0x187F52600", Slot = "4")]
	public FBOIFHJOBNJ IOHMKIDJAGJ(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7F52030", Offset = "0x7F51430", VA = "0x187F52030", Slot = "5")]
	public DBPCILMDGMD EOHHAIHHJJJ(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7F528D0", Offset = "0x7F51CD0", VA = "0x187F528D0", Slot = "6")]
	public GKJHJCDKENI PEJMGMILPKF(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7F51F90", Offset = "0x7F51390", VA = "0x187F51F90", Slot = "7")]
	public FPEJNOBHICC BJBJJICDFFM(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7F526F0", Offset = "0x7F51AF0", VA = "0x187F526F0", Slot = "8")]
	public HPIGFHCLCMI JKENCDPDCMG(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7F52830", Offset = "0x7F51C30", VA = "0x187F52830", Slot = "9")]
	public LMPHFKIGLEG OFNJCJLEDPP(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7F52790", Offset = "0x7F51B90", VA = "0x187F52790", Slot = "10")]
	public FBJEDNAGIGL LDEJLHKNOGM(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7F520D0", Offset = "0x7F514D0", VA = "0x187F520D0", Slot = "11")]
	public PKBJJCGKHNG FJPCILKFONC(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7F52560", Offset = "0x7F51960", VA = "0x187F52560", Slot = "12")]
	public DJPCDPJPCLD HNICKLOPJFL(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7F522D0", Offset = "0x7F516D0", VA = "0x187F522D0", Slot = "13")]
	public KLLGIDCCFGJ HEIGMAOFCOH(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7F52170", Offset = "0x7F51570", VA = "0x187F52170")]
	public MDGIPIMJHGM INMAMPKJFOJ(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7F52220", Offset = "0x7F51620", VA = "0x187F52220")]
	public FLDKJMJIPHJ GOPDDKMGEMA(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7F51E30", Offset = "0x7F51230", VA = "0x187F51E30")]
	public ODAJCLOPNKH LKIBHBFNKAF(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7F52370", Offset = "0x7F51770", VA = "0x187F52370")]
	public MANAINKOLAE HGILLMDOBBI(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7F51EE0", Offset = "0x7F512E0", VA = "0x187F51EE0")]
	public NNPJLLLEEIL BFMBCNIFAPA(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7F52480", Offset = "0x7F51880", VA = "0x187F52480", Slot = "19")]
	public ABPNPGANBHP HLNLBBPBIKA(RigidbodyEx GFMEDDDNANC, MHBKLDJGOMO AMHCLKHIFKH, LPEAJCAOGEO ECPDNOJCJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7F52970", Offset = "0x7F51D70", VA = "0x187F52970")]
	public ECFOPIFBIDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7F52170", Offset = "0x7F51570", VA = "0x187F52170", Slot = "14")]
	private MDGIPIMJHGM GJALPIEJHNM(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7F52220", Offset = "0x7F51620", VA = "0x187F52220", Slot = "15")]
	private FLDKJMJIPHJ NGDLHOKPHOM(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7F51E30", Offset = "0x7F51230", VA = "0x187F51E30", Slot = "16")]
	private ODAJCLOPNKH APLNBDFOPEN(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7F52370", Offset = "0x7F51770", VA = "0x187F52370", Slot = "17")]
	private MANAINKOLAE MDBBHJEKLNA(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7F51EE0", Offset = "0x7F512E0", VA = "0x187F51EE0", Slot = "18")]
	private NNPJLLLEEIL DJBCJHJLONJ(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface DKKBBICEFHK : FBOIFHJOBNJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFKMCGFGABH(ABPNPGANBHP GFMEDDDNANC);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGIBIOCAJCM(ABPNPGANBHP GFMEDDDNANC);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GIPEOLDHGEH(ABPNPGANBHP IMHLCBJKIGA);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OMEKPCGPNAM(ABPNPGANBHP IMHLCBJKIGA);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FLDLIEJHAMH : GKJHJCDKENI
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	FLMNLPKDHJA<ABPNPGANBHP> EGHPLEOFMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	ABPNPGANBHP PIJCKKOJFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LPEFKIBIOEM : MANAINKOLAE
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) KDCJBAKFJLH(Rigidbody IDAHHHNOPAN);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface HOMLOJDHPDE : FLDKJMJIPHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PhotonView AIGALBLONIB
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class HCBCANOALJI : DJPCDPJPCLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly MCPBFHABCGI GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode KBOAMGEJCOF;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody PCCLPPLGLJB
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7F55430", Offset = "0x7F54830", VA = "0x187F55430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode LNKDIGIOAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7F55710", Offset = "0x7F54B10", VA = "0x187F55710", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7F55820", Offset = "0x7F54C20", VA = "0x187F55820", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7F51CD0", Offset = "0x7F510D0", VA = "0x187F51CD0")]
	public HCBCANOALJI(ABPNPGANBHP GFMEDDDNANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7F555E0", Offset = "0x7F549E0", VA = "0x187F555E0", Slot = "6")]
	public void CBNFMMEJBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7F553B0", Offset = "0x7F547B0", VA = "0x187F553B0", Slot = "9")]
	public void BLIMLPFEJGA(Rigidbody COMCLPGENOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7F55700", Offset = "0x7F54B00", VA = "0x187F55700", Slot = "7")]
	public void JEHGKHFMALB(bool PKHJAFFAAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7F556F0", Offset = "0x7F54AF0", VA = "0x187F556F0", Slot = "8")]
	public void ECGEMHCJOAM(bool PKHJAFFAAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7F55480", Offset = "0x7F54880", VA = "0x187F55480", Slot = "10")]
	public bool BLOJPOCBLHN(Vector3 DLBKBBJEBDD, [Out] RaycastHit OOEIPEFIGGM, float DIHBFHDIEJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7F55290", Offset = "0x7F54690", VA = "0x187F55290")]
	private void BBNBELKGBGD(bool PKHJAFFAAAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class GODBBIFCJHK : LMPHFKIGLEG, IDisposable, LALFMDHBCFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly MCPBFHABCGI GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private GDMNGFOCBGE DFNKPICLEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private OIAJDJPLGCF GILMMDEEPGL;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public GDMNGFOCBGE CIPGJOKIEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7F54E90", Offset = "0x7F54290", VA = "0x187F54E90", Slot = "6")]
		get
		{
			return default(GDMNGFOCBGE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7F55080", Offset = "0x7F54480", VA = "0x187F55080", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform CHFIGKILJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xC13B10", Offset = "0xC12F10", VA = "0x180C13B10", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<GPKPAEJIOJM, GPKPAEJIOJM> DGDACCPKEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7F54FD0", Offset = "0x7F543D0", VA = "0x187F54FD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7F55150", Offset = "0x7F54550", VA = "0x187F55150", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7F55200", Offset = "0x7F54600", VA = "0x187F55200")]
	public GODBBIFCJHK(ABPNPGANBHP GFMEDDDNANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7F54BD0", Offset = "0x7F53FD0", VA = "0x187F54BD0", Slot = "8")]
	public void CBNFMMEJBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7F54E40", Offset = "0x7F54240", VA = "0x187F54E40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1098520", Offset = "0x1097920", VA = "0x181098520", Slot = "11")]
	private void ANFOLEMKBKB(GPKPAEJIOJM CIOPJANLAMG, GPKPAEJIOJM CKDFMHIEDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "12")]
	private void BCGPBIEHAKE(bool BCMJICCFPOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LIGOEHNNKEF : LIGPLJIGNDK
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7F584D0", Offset = "0x7F578D0", VA = "0x187F584D0", Slot = "4")]
	public FBOIFHJOBNJ IOHMKIDJAGJ(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7F57BC0", Offset = "0x7F56FC0", VA = "0x187F57BC0", Slot = "5")]
	public DBPCILMDGMD EOHHAIHHJJJ(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7F58880", Offset = "0x7F57C80", VA = "0x187F58880", Slot = "6")]
	public GKJHJCDKENI PEJMGMILPKF(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7F57B40", Offset = "0x7F56F40", VA = "0x187F57B40", Slot = "7")]
	public FPEJNOBHICC BJBJJICDFFM(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7F585C0", Offset = "0x7F579C0", VA = "0x187F585C0", Slot = "8")]
	public HPIGFHCLCMI JKENCDPDCMG(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7F587B0", Offset = "0x7F57BB0", VA = "0x187F587B0", Slot = "9")]
	public LMPHFKIGLEG OFNJCJLEDPP(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7F58690", Offset = "0x7F57A90", VA = "0x187F58690", Slot = "10")]
	public FBJEDNAGIGL LDEJLHKNOGM(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7F57CE0", Offset = "0x7F570E0", VA = "0x187F57CE0", Slot = "11")]
	public PKBJJCGKHNG FJPCILKFONC(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7F58410", Offset = "0x7F57810", VA = "0x187F58410", Slot = "12")]
	public DJPCDPJPCLD HNICKLOPJFL(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7F58070", Offset = "0x7F57470", VA = "0x187F58070", Slot = "13")]
	public KLLGIDCCFGJ HEIGMAOFCOH(ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7F57DA0", Offset = "0x7F571A0", VA = "0x187F57DA0")]
	public MDGIPIMJHGM INMAMPKJFOJ(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7F57EE0", Offset = "0x7F572E0", VA = "0x187F57EE0")]
	public FLDKJMJIPHJ GOPDDKMGEMA(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7F57930", Offset = "0x7F56D30", VA = "0x187F57930")]
	public ODAJCLOPNKH LKIBHBFNKAF(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7F58130", Offset = "0x7F57530", VA = "0x187F58130")]
	public MANAINKOLAE HGILLMDOBBI(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7F57A60", Offset = "0x7F56E60", VA = "0x187F57A60")]
	public NNPJLLLEEIL BFMBCNIFAPA(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7F582C0", Offset = "0x7F576C0", VA = "0x187F582C0", Slot = "19")]
	public ABPNPGANBHP HLNLBBPBIKA(RigidbodyEx GFMEDDDNANC, MHBKLDJGOMO AMHCLKHIFKH, LPEAJCAOGEO ECPDNOJCJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public LIGOEHNNKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7F57DA0", Offset = "0x7F571A0", VA = "0x187F57DA0", Slot = "14")]
	private MDGIPIMJHGM GJALPIEJHNM(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7F57EE0", Offset = "0x7F572E0", VA = "0x187F57EE0", Slot = "15")]
	private FLDKJMJIPHJ NGDLHOKPHOM(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7F57930", Offset = "0x7F56D30", VA = "0x187F57930", Slot = "16")]
	private ODAJCLOPNKH APLNBDFOPEN(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7F58130", Offset = "0x7F57530", VA = "0x187F58130", Slot = "17")]
	private MANAINKOLAE MDBBHJEKLNA(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7F57A60", Offset = "0x7F56E60", VA = "0x187F57A60", Slot = "18")]
	private NNPJLLLEEIL DJBCJHJLONJ(ABPNPGANBHP KKDALLBMKBI, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class JPOFNFPEJEK : PKBJJCGKHNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MCPBFHABCGI GFMEDDDNANC;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody PCCLPPLGLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7F55430", Offset = "0x7F54830", VA = "0x187F55430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool AGIEDJEBCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7F56E20", Offset = "0x7F56220", VA = "0x187F56E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool IJOBLCOANHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7F573F0", Offset = "0x7F567F0", VA = "0x187F573F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private ABPNPGANBHP DHHOIDHGNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7F56FD0", Offset = "0x7F563D0", VA = "0x187F56FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7F51CD0", Offset = "0x7F510D0", VA = "0x187F51CD0")]
	public JPOFNFPEJEK(ABPNPGANBHP GFMEDDDNANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7F56E70", Offset = "0x7F56270", VA = "0x187F56E70", Slot = "4")]
	public void GFIMLDICNMO(Vector3 HEGINIGEJIB, ForceMode GABCLKPOPAL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7F57030", Offset = "0x7F56430", VA = "0x187F57030")]
	private void HEEDDFHEPMF(Vector3 HEGINIGEJIB, ForceMode GABCLKPOPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7F576B0", Offset = "0x7F56AB0", VA = "0x187F576B0", Slot = "5")]
	public void PFPOKLAMMGF(Vector3 HEGINIGEJIB, Vector3 JPKKPDPLAGA, ForceMode GABCLKPOPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7F57290", Offset = "0x7F56690", VA = "0x187F57290", Slot = "6")]
	public void KMCKIPAKBHE(Vector3 JKFHICALMPP, ForceMode GABCLKPOPAL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7F57450", Offset = "0x7F56850", VA = "0x187F57450")]
	private void OEBFLCBCPHL(Vector3 JKFHICALMPP, ForceMode GABCLKPOPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7F56BC0", Offset = "0x7F55FC0", VA = "0x187F56BC0", Slot = "7")]
	public void CFHCHDAEEKA(Vector3 JKFHICALMPP, ForceMode GABCLKPOPAL = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class ABNKDMMIOCP : KLLGIDCCFGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly MCPBFHABCGI GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool NLDPPPEEPPI;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool OABNKIIPEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA110A0", Offset = "0xA104A0", VA = "0x180A110A0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7F51BC0", Offset = "0x7F50FC0", VA = "0x187F51BC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7F51CD0", Offset = "0x7F510D0", VA = "0x187F51CD0")]
	public ABNKDMMIOCP(ABPNPGANBHP GFMEDDDNANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7F51B20", Offset = "0x7F50F20", VA = "0x187F51B20", Slot = "6")]
	public void BLIMLPFEJGA(Rigidbody COMCLPGENOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7F51B50", Offset = "0x7F50F50", VA = "0x187F51B50", Slot = "7")]
	public void DMDHHFOCCLM(Rigidbody COMCLPGENOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class EKNJIDGBPJE : DKKBBICEFHK, FBOIFHJOBNJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ABPNPGANBHP GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<ABPNPGANBHP> NJIGLGKNGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private ABPNPGANBHP FDNIDHBNFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private ABPNPGANBHP PBIFOHNGFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform HLCFPLAFMMP;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform GFBMHFBKABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7F53750", Offset = "0x7F52B50", VA = "0x187F53750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public ABPNPGANBHP DHHOIDHGNKB
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x993460", Offset = "0x992860", VA = "0x180993460", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7F52C90", Offset = "0x7F52090", VA = "0x187F52C90", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public ABPNPGANBHP OFMCPLOCJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x993540", Offset = "0x992940", VA = "0x180993540", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<ABPNPGANBHP> GOIMIEIGHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x997460", Offset = "0x996860", VA = "0x180997460", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event GPIDENABAMJ AAEODNCKGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7F536B0", Offset = "0x7F52AB0", VA = "0x187F536B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7F54530", Offset = "0x7F53930", VA = "0x187F54530", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event GPIDENABAMJ ICNCDCNELHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7F532F0", Offset = "0x7F526F0", VA = "0x187F532F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7F52CA0", Offset = "0x7F520A0", VA = "0x187F52CA0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event HIBPMBDIIHN DMKGFBBAMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7F541E0", Offset = "0x7F535E0", VA = "0x187F541E0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7F54140", Offset = "0x7F53540", VA = "0x187F54140", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action EHFGMODGAFM
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7F531A0", Offset = "0x7F525A0", VA = "0x187F531A0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7F52E70", Offset = "0x7F52270", VA = "0x187F52E70", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action CPMJIKBODKH
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7F52FB0", Offset = "0x7F523B0", VA = "0x187F52FB0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7F54320", Offset = "0x7F53720", VA = "0x187F54320", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<ABPNPGANBHP> MPHCBABFJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7F530F0", Offset = "0x7F524F0", VA = "0x187F530F0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7F543C0", Offset = "0x7F537C0", VA = "0x187F543C0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<ABPNPGANBHP> JDCMCCPMIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7F539D0", Offset = "0x7F52DD0", VA = "0x187F539D0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7F53240", Offset = "0x7F52640", VA = "0x187F53240", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action KENHKLDMPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7F545D0", Offset = "0x7F539D0", VA = "0x187F545D0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7F52BF0", Offset = "0x7F51FF0", VA = "0x187F52BF0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<ABPNPGANBHP> HFDEHHCKLOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7F53600", Offset = "0x7F52A00", VA = "0x187F53600", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7F537B0", Offset = "0x7F52BB0", VA = "0x187F537B0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7F548F0", Offset = "0x7F53CF0", VA = "0x187F548F0")]
	public EKNJIDGBPJE(ABPNPGANBHP GFMEDDDNANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7F53050", Offset = "0x7F52450", VA = "0x187F53050", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7F53BC0", Offset = "0x7F52FC0", VA = "0x187F53BC0", Slot = "30")]
	public void MEECIGHOFNG(ABPNPGANBHP DPOGHMAJNAL, bool AFNGBHPONPL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7F53390", Offset = "0x7F52790", VA = "0x187F53390", Slot = "6")]
	public void GIPEOLDHGEH(ABPNPGANBHP IMHLCBJKIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7F54670", Offset = "0x7F53A70", VA = "0x187F54670", Slot = "7")]
	public void OMEKPCGPNAM(ABPNPGANBHP IMHLCBJKIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7F52AE0", Offset = "0x7F51EE0", VA = "0x187F52AE0", Slot = "4")]
	public void AFKMCGFGABH(ABPNPGANBHP GFMEDDDNANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7F52F10", Offset = "0x7F52310", VA = "0x187F52F10", Slot = "5")]
	public void DGIBIOCAJCM(ABPNPGANBHP GFMEDDDNANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7F54280", Offset = "0x7F53680", VA = "0x187F54280")]
	private void NFOKJNJBJGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7F53860", Offset = "0x7F52C60", VA = "0x187F53860")]
	private void KINLABJEHHK(ABPNPGANBHP IMHLCBJKIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7F53A80", Offset = "0x7F52E80", VA = "0x187F53A80")]
	private void LLDLKAACBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7F52D40", Offset = "0x7F52140", VA = "0x187F52D40")]
	private void CEJPOFGMHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7F538A0", Offset = "0x7F52CA0", VA = "0x187F538A0")]
	private void KMMFAHGBGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7F54470", Offset = "0x7F53870", VA = "0x187F54470")]
	[CompilerGenerated]
	private object NMGNHNLENGC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class MPCGNALGING
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7F62760", Offset = "0x7F61B60", VA = "0x187F62760")]
	public static DKKBBICEFHK NMKFHFPOIDG(this ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class PKKHDAENMJJ : FLDLIEJHAMH, GKJHJCDKENI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly MCPBFHABCGI GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly FLMNLPKDHJA<ABPNPGANBHP> MKKIHEHDDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool CLJFFAAALIA;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public FLMNLPKDHJA<ABPNPGANBHP> EGHPLEOFMPH
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 FIHKAKPAEAL
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7F64B80", Offset = "0x7F63F80", VA = "0x187F64B80", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 NJOEFMNFIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7F64170", Offset = "0x7F63570", VA = "0x187F64170", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 JFHHNMDFJLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F64080", Offset = "0x7F63480", VA = "0x187F64080")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ABPNPGANBHP PIJCKKOJFHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F64AD0", Offset = "0x7F63ED0", VA = "0x187F64AD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7F64C10", Offset = "0x7F64010", VA = "0x187F64C10")]
	public PKKHDAENMJJ(ABPNPGANBHP GFMEDDDNANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7F646C0", Offset = "0x7F63AC0", VA = "0x187F646C0", Slot = "8")]
	public void FKKJNOPKEDN(ABPNPGANBHP PBIFOHNGFLL, object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F64BB0", Offset = "0x7F63FB0", VA = "0x187F64BB0", Slot = "9")]
	public void MLDMFGPNAGM(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F64730", Offset = "0x7F63B30", VA = "0x187F64730")]
	private Vector3 FPENIDGFEPD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F64330", Offset = "0x7F63730", VA = "0x187F64330")]
	private void EKFILGFADKE(ABPNPGANBHP GEAALBODFKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class EILOGKPDKIJ
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F52A20", Offset = "0x7F51E20", VA = "0x187F52A20")]
	public static FLDLIEJHAMH LPHKEEGKCHD(this ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class LPEEIIEEINF : LPEFKIBIOEM, MANAINKOLAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly MCPBFHABCGI GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 BALHMJNIFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 AFMPDNDMACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float BCAEEENABOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float DFGMCFFNFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 GEEMLGBIHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? JBHGIONPKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? FGKBLICLIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool AMHBCNIGLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool LGIGCMLOMLM;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 DHEOELELEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x14C80E0", Offset = "0x14C74E0", VA = "0x1814C80E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F5A2A0", Offset = "0x7F596A0", VA = "0x187F5A2A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 MFJPIABNDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F597A0", Offset = "0x7F58BA0", VA = "0x187F597A0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float IDILBJNLFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xC36FF0", Offset = "0xC363F0", VA = "0x180C36FF0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7F5BA40", Offset = "0x7F5AE40", VA = "0x187F5BA40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float KHHHPLLGBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xB41360", Offset = "0xB40760", VA = "0x180B41360", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7F5A070", Offset = "0x7F59470", VA = "0x187F5A070", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 IIBPDJKEGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7F59DF0", Offset = "0x7F591F0", VA = "0x187F59DF0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion KHIPDNEPOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F5A120", Offset = "0x7F59520", VA = "0x187F5A120", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody PCCLPPLGLJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7F58A50", Offset = "0x7F57E50", VA = "0x187F58A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event GPIDENABAMJ INGLCPFOMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B370", Offset = "0x7F5A770", VA = "0x187F5B370", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F5BD80", Offset = "0x7F5B180", VA = "0x187F5BD80", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BE20", Offset = "0x7F5B220", VA = "0x187F5BE20")]
	public LPEEIIEEINF(ABPNPGANBHP GFMEDDDNANC, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F59B50", Offset = "0x7F58F50", VA = "0x187F59B50", Slot = "17")]
	public void EJNMHEHDJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7F596C0", Offset = "0x7F58AC0", VA = "0x187F596C0", Slot = "16")]
	public void AMPANMEHBAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7F59890", Offset = "0x7F58C90", VA = "0x187F59890", Slot = "19")]
	public void BLIMLPFEJGA(Rigidbody COMCLPGENOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F59970", Offset = "0x7F58D70", VA = "0x187F59970", Slot = "20")]
	public void DMDHHFOCCLM(Rigidbody COMCLPGENOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B1C0", Offset = "0x7F5A5C0", VA = "0x187F5B1C0", Slot = "18")]
	public void LPIDANGHMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B410", Offset = "0x7F5A810", VA = "0x187F5B410", Slot = "21")]
	public void NBBNNHEIMPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A2A0", Offset = "0x7F596A0", VA = "0x187F5A2A0")]
	private void NECCNAJBHOK(Vector3 FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F59F80", Offset = "0x7F59380", VA = "0x187F59F80")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 FNGDMDLJPHJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BA40", Offset = "0x7F5AE40", VA = "0x187F5BA40")]
	private void NNLAPJJKCME(float FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A070", Offset = "0x7F59470", VA = "0x187F5A070")]
	private void FPIOOMBGIOM(float FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B8A0", Offset = "0x7F5ACA0", VA = "0x187F5B8A0")]
	private Vector3 NMIMJNBKOKJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BB50", Offset = "0x7F5AF50", VA = "0x187F5BB50", Slot = "15")]
	public void NPGHKIBGLOJ((Quaternion rot, Vector3 moments) JDPGMOJPEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7F59C70", Offset = "0x7F59070", VA = "0x187F59C70")]
	private Quaternion EOJNHBPOILB()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B0F0", Offset = "0x7F5A4F0", VA = "0x187F5B0F0")]
	public void KDCJBAKFJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A350", Offset = "0x7F59750", VA = "0x187F5A350", Slot = "4")]
	public (float, Vector3) KDCJBAKFJLH(Rigidbody IDAHHHNOPAN)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class HNLNAEPOAMC
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F56560", Offset = "0x7F55960", VA = "0x187F56560")]
	public static LPEFKIBIOEM AIHPPEOJGHK(this ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class HFBHGLBLALH : ODAJCLOPNKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly MCPBFHABCGI GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly OFGINBALPIL BPPBOCNDILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly GLFKKJMEHNE MCDBMEFMBGO;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool CHAFJLFJBDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x167F210", Offset = "0x167E610", VA = "0x18167F210", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public GLFKKJMEHNE DFCEMBAMBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xB327A0", Offset = "0xB31BA0", VA = "0x180B327A0", Slot = "11")]
		get
		{
			return default(GLFKKJMEHNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F55EA0", Offset = "0x7F552A0", VA = "0x187F55EA0")]
	public HFBHGLBLALH(ABPNPGANBHP GFMEDDDNANC, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F55930", Offset = "0x7F54D30", VA = "0x187F55930", Slot = "4")]
	public void CBNFMMEJBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F55890", Offset = "0x7F54C90", VA = "0x187F55890")]
	private bool BDDEHBDGCLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F55BC0", Offset = "0x7F54FC0", VA = "0x187F55BC0", Slot = "5")]
	public void LFIDBLKDFND(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F55A00", Offset = "0x7F54E00", VA = "0x187F55A00", Slot = "6")]
	public void FFDFLIBPKAL(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F55D70", Offset = "0x7F55170", VA = "0x187F55D70", Slot = "9")]
	public void MELOPOCFMEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F55A70", Offset = "0x7F54E70", VA = "0x187F55A70")]
	private void IILNKKFNJHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7F55BF0", Offset = "0x7F54FF0", VA = "0x187F55BF0")]
	private void LODJHFDPAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7F55A30", Offset = "0x7F54E30", VA = "0x187F55A30", Slot = "8")]
	public void IGAODLMFIAK(ABPNPGANBHP GFMEDDDNANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7F55B80", Offset = "0x7F54F80", VA = "0x187F55B80", Slot = "7")]
	public void IOHAHINACIH(ABPNPGANBHP GFMEDDDNANC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class HGMCPKDJBBC : FBJEDNAGIGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly MCPBFHABCGI GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly OFGINBALPIL PIBMAJKPJPE;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool AGIEDJEBCBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F561B0", Offset = "0x7F555B0", VA = "0x187F561B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event GPIDENABAMJ DBJBBFONLHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F56270", Offset = "0x7F55670", VA = "0x187F56270", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F56310", Offset = "0x7F55710", VA = "0x187F56310", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F563B0", Offset = "0x7F557B0", VA = "0x187F563B0")]
	public HGMCPKDJBBC(ABPNPGANBHP GFMEDDDNANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7F56260", Offset = "0x7F55660", VA = "0x187F56260", Slot = "7")]
	public void LGKPPJMIBHI(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7F55FA0", Offset = "0x7F553A0", VA = "0x187F55FA0", Slot = "8")]
	public void BGOBBPBCLNB(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7F560A0", Offset = "0x7F554A0", VA = "0x187F560A0", Slot = "9")]
	public void FHHHMHGONEH(object HEJFDMJNIGB, bool ABPFJPCEHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7F56060", Offset = "0x7F55460", VA = "0x187F56060", Slot = "12")]
	public void ELDDOPMHPKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F55FB0", Offset = "0x7F553B0", VA = "0x187F55FB0", Slot = "10")]
	public void BLIMLPFEJGA(Rigidbody KPFMMNMCDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F56030", Offset = "0x7F55430", VA = "0x187F56030", Slot = "11")]
	public void DMDHHFOCCLM(Rigidbody COMCLPGENOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class NELPENKDIJF : HOMLOJDHPDE, FLDKJMJIPHJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly MCPBFHABCGI GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PhotonView EDGHLNOFAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool LPGNLENCHCD;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView AIGALBLONIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool EECHAMFCOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F62AE0", Offset = "0x7F61EE0", VA = "0x187F62AE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool HNEOKNHIFND
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xD13190", Offset = "0xD12590", VA = "0x180D13190", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event GPIDENABAMJ HJJPPDJCLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7F63010", Offset = "0x7F62410", VA = "0x187F63010", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F63490", Offset = "0x7F62890", VA = "0x187F63490", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F63680", Offset = "0x7F62A80", VA = "0x187F63680")]
	public NELPENKDIJF(ABPNPGANBHP GFMEDDDNANC, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F62B00", Offset = "0x7F61F00", VA = "0x187F62B00", Slot = "9")]
	public void CBNFMMEJBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7F62C30", Offset = "0x7F62030", VA = "0x187F62C30", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F630B0", Offset = "0x7F624B0", VA = "0x187F630B0", Slot = "10")]
	public void JKNIGBHGJEP(ABPNPGANBHP PBIFOHNGFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7F62D30", Offset = "0x7F62130", VA = "0x187F62D30", Slot = "11")]
	public void EMAGNAGFONI(ABPNPGANBHP PBIFOHNGFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F62EA0", Offset = "0x7F622A0", VA = "0x187F62EA0")]
	private void FFBGPMCEMDD(PhotonView FJNCMNFBAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7F63530", Offset = "0x7F62930", VA = "0x187F63530")]
	private void OGGEKFEHDMF(NFIBELDGELK EOBLLJEGHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F63220", Offset = "0x7F62620", VA = "0x187F63220")]
	private void JMLFIICCHNP(PhotonView FDHOINCAODL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class HKGEODFDEFE
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F564A0", Offset = "0x7F558A0", VA = "0x187F564A0")]
	public static HOMLOJDHPDE GELMIAFEAMJ(this ABPNPGANBHP KKDALLBMKBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class IGBLPLOHGKF : NNPJLLLEEIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly MCPBFHABCGI GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints PLJHFLIEIHI;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool DAPFLDLDOIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9E6CE0", Offset = "0x9E60E0", VA = "0x1809E6CE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xC6C060", Offset = "0xC6B460", VA = "0x180C6C060", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool ELPLLDLCILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xC6C050", Offset = "0xC6B450", VA = "0x180C6C050", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xC6CB20", Offset = "0xC6BF20", VA = "0x180C6CB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints EPHIBNCPBKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x991DB0", Offset = "0x9911B0", VA = "0x180991DB0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F569F0", Offset = "0x7F55DF0", VA = "0x187F569F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7F56B20", Offset = "0x7F55F20", VA = "0x187F56B20")]
	public IGBLPLOHGKF(ABPNPGANBHP GFMEDDDNANC, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F56990", Offset = "0x7F55D90", VA = "0x187F56990", Slot = "9")]
	public void BLIMLPFEJGA(Rigidbody COMCLPGENOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7F569C0", Offset = "0x7F55DC0", VA = "0x187F569C0", Slot = "10")]
	public void DMDHHFOCCLM(Rigidbody COMCLPGENOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class HOHOJLNMPIP : FPEJNOBHICC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly ABPNPGANBHP GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float BOIPLNDCDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float KDAJJEOPCMK;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float ICIOKBHPMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xE2E720", Offset = "0xE2DB20", VA = "0x180E2E720", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F56620", Offset = "0x7F55A20", VA = "0x187F56620", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float DNGLPCEHJBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xC80DD0", Offset = "0xC801D0", VA = "0x180C80DD0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F567E0", Offset = "0x7F55BE0", VA = "0x187F567E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F568B0", Offset = "0x7F55CB0", VA = "0x187F568B0")]
	public HOHOJLNMPIP(ABPNPGANBHP GFMEDDDNANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7F566F0", Offset = "0x7F55AF0", VA = "0x187F566F0", Slot = "8")]
	public void BLIMLPFEJGA(Rigidbody COMCLPGENOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7F56740", Offset = "0x7F55B40", VA = "0x187F56740", Slot = "9")]
	public void DMDHHFOCCLM(Rigidbody COMCLPGENOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class LJNAKJAKGOM : HPIGFHCLCMI
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly ABDDJEPKCOD EMBHJMGIJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly MCPBFHABCGI GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool HGIPNNEJKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool NGDAPNPGIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int NAFDCKOIIIF;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody PCCLPPLGLJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7F58A50", Offset = "0x7F57E50", VA = "0x187F58A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool LFLDNOHIFOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7F59530", Offset = "0x7F58930", VA = "0x187F59530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private ABPNPGANBHP DHHOIDHGNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F59220", Offset = "0x7F58620", VA = "0x187F59220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool IJOBLCOANHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7F59550", Offset = "0x7F58950", VA = "0x187F59550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event GPIDENABAMJ CFOPMACODOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7F58D70", Offset = "0x7F58170", VA = "0x187F58D70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7F589B0", Offset = "0x7F57DB0", VA = "0x187F589B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7F59630", Offset = "0x7F58A30", VA = "0x187F59630")]
	public LJNAKJAKGOM(ABPNPGANBHP GFMEDDDNANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7F58AB0", Offset = "0x7F57EB0", VA = "0x187F58AB0", Slot = "6")]
	public void CBNFMMEJBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7F58AA0", Offset = "0x7F57EA0", VA = "0x187F58AA0", Slot = "8")]
	public void BOMPPCOCJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7F593E0", Offset = "0x7F587E0", VA = "0x187F593E0", Slot = "7")]
	public bool JFNOKHADCEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7F59280", Offset = "0x7F58680", VA = "0x187F59280", Slot = "9")]
	public void GJFOLMOILPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7F58B40", Offset = "0x7F57F40", VA = "0x187F58B40", Slot = "13")]
	public void CDDHGOGLNLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7F58C50", Offset = "0x7F58050", VA = "0x187F58C50", Slot = "12")]
	public void CPNDKNDPJHP(bool DBIKHNEGCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7F58BE0", Offset = "0x7F57FE0", VA = "0x187F58BE0", Slot = "10")]
	public bool CEKIEOBMOJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7F59320", Offset = "0x7F58720", VA = "0x187F59320", Slot = "11")]
	public bool JCGNBANABHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7F58E10", Offset = "0x7F58210", VA = "0x187F58E10")]
	private bool FHPNMALGBHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7F59090", Offset = "0x7F58490", VA = "0x187F59090")]
	private void FPNFDHMOEBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class PAEIBLBBPFG : MDGIPIMJHGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly MCPBFHABCGI GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly OFGINBALPIL OJGEKJLDFFO;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody PCCLPPLGLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x991DF0", Offset = "0x9911F0", VA = "0x180991DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool IJOBLCOANHP
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7F573F0", Offset = "0x7F567F0", VA = "0x187F573F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool EGCGEHDBFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x167F210", Offset = "0x167E610", VA = "0x18167F210", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7F63F70", Offset = "0x7F63370", VA = "0x187F63F70")]
	public PAEIBLBBPFG(ABPNPGANBHP GFMEDDDNANC, [In] MHBKLDJGOMO AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7F637D0", Offset = "0x7F62BD0", VA = "0x187F637D0", Slot = "5")]
	public void CBNFMMEJBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7F63F40", Offset = "0x7F63340", VA = "0x187F63F40", Slot = "7")]
	public void PKGDLNOFFAD(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7F63BE0", Offset = "0x7F62FE0", VA = "0x187F63BE0", Slot = "8")]
	public void KLLOFBBEJHD(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7F63C10", Offset = "0x7F63010", VA = "0x187F63C10", Slot = "9")]
	public void NPDMDNNMFDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7F63870", Offset = "0x7F62C70", VA = "0x187F63870", Slot = "10")]
	public void JKMNIANOILI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7F63A60", Offset = "0x7F62E60", VA = "0x187F63A60", Slot = "11")]
	public void KBBLEODDKFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class POIOCMBGCFH : DBPCILMDGMD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly MCPBFHABCGI GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly OFGINBALPIL NAAOFINMBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float LCGBLMMDBID;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public MBIEHGKALBL OAGGEAOJCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x99BAC0", Offset = "0x99AEC0", VA = "0x18099BAC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public EANAJLOACDP MPNOFNPOHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x991DA0", Offset = "0x9911A0", VA = "0x180991DA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 JFHHNMDFJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7F64D10", Offset = "0x7F64110", VA = "0x187F64D10", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7F65670", Offset = "0x7F64A70", VA = "0x187F65670", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 KLCGOIFMDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7F67A30", Offset = "0x7F66E30", VA = "0x187F67A30", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7F67BB0", Offset = "0x7F66FB0", VA = "0x187F67BB0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 KACGJOFGFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7F67430", Offset = "0x7F66830", VA = "0x187F67430", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7F67D80", Offset = "0x7F67180", VA = "0x187F67D80", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 ABOMJEBMGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7F667C0", Offset = "0x7F65BC0", VA = "0x187F667C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7F665F0", Offset = "0x7F659F0", VA = "0x187F665F0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float NLAEEPGFOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xE35BB0", Offset = "0xE34FB0", VA = "0x180E35BB0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7F677E0", Offset = "0x7F66BE0", VA = "0x187F677E0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool GOJJGCIMGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1FB15B0", Offset = "0x1FB09B0", VA = "0x181FB15B0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private PKBJJCGKHNG JEEAABJOECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x75D1D90", Offset = "0x75D1190", VA = "0x1875D1D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool LFLDNOHIFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7F677C0", Offset = "0x7F66BC0", VA = "0x187F677C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7F682C0", Offset = "0x7F676C0", VA = "0x187F682C0")]
	public POIOCMBGCFH(ABPNPGANBHP GFMEDDDNANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7F655D0", Offset = "0x7F649D0", VA = "0x187F655D0", Slot = "19")]
	public void CBNFMMEJBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7F65920", Offset = "0x7F64D20", VA = "0x187F65920", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7F652E0", Offset = "0x7F646E0", VA = "0x187F652E0", Slot = "28")]
	public void BLIMLPFEJGA(Rigidbody COMCLPGENOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x148ABF0", Offset = "0x1489FF0", VA = "0x18148ABF0", Slot = "20")]
	public void LOHPHHJLAOM(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x148A210", Offset = "0x1489610", VA = "0x18148A210", Slot = "30")]
	public void EAFOKDOGKDG(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7F66360", Offset = "0x7F65760", VA = "0x187F66360", Slot = "35")]
	public Vector3 GGHHHBBPAHD(Vector3 BIBMPFNJDHN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7F65410", Offset = "0x7F64810", VA = "0x187F65410", Slot = "34")]
	public Vector3 CBEENJNMBPD(Vector3 DKOOKAOCABK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7F655D0", Offset = "0x7F649D0", VA = "0x187F655D0", Slot = "27")]
	public void IOLODGPALJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7F679D0", Offset = "0x7F66DD0", VA = "0x187F679D0", Slot = "25")]
	public void NFELBKGHMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7F67B50", Offset = "0x7F66F50", VA = "0x187F67B50", Slot = "24")]
	public void OEPIDIHHPHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7F67580", Offset = "0x7F66980", VA = "0x187F67580", Slot = "33")]
	public void LHFCKNCENKB(Vector3 MFLOLBJJFAN, Vector3 OLILCJIJJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7F658C0", Offset = "0x7F64CC0", VA = "0x187F658C0", Slot = "32")]
	public void DJBEDAAFHJD(Vector3 HCDBLHJEFCC, Vector3 DGBDKEHBLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7F67BE0", Offset = "0x7F66FE0", VA = "0x187F67BE0", Slot = "31")]
	public void OHMJKDJBLJH(Vector3 MHABPNKEBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7F65D10", Offset = "0x7F65110", VA = "0x187F65D10", Slot = "22")]
	public void FNDGFADDOAK(MKCFIBLOAOL BGLADFLHHKF, Vector3 AGDHNHLHGLH, float LBELLPAGBED, float IMNOGCHOKIO = 8f, float OKEDDGNFDNJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7F65980", Offset = "0x7F64D80", VA = "0x187F65980", Slot = "21")]
	public void EDADPIMKJFM(CPBDFAEEPJE FNJKBBLHAEP, Vector3 GJJMKPHOIEI, float CHIDEEDFLPE = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7F66FB0", Offset = "0x7F663B0", VA = "0x187F66FB0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JLBJNKEOFNO(CPBDFAEEPJE FNJKBBLHAEP, Vector3 BENMKDDDBDG, float NLOEFCPHCMO = 7f, float NMGNOONDDJM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x15C2CB0", Offset = "0x15C20B0", VA = "0x1815C2CB0")]
	private static void LIANCBJOMJO(Vector3 APPPFHHBPEI, Vector3 HAKFDJFOEPG, [Out] Vector3 HDLHCIMEEPD, [Out] Vector3 KKAMAOHPLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7F678F0", Offset = "0x7F66CF0", VA = "0x187F678F0", Slot = "29")]
	public Vector3 NBHBNLJLOJM(Vector3 APPPFHHBPEI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7F65730", Offset = "0x7F64B30", VA = "0x187F65730", Slot = "26")]
	public void CFECGDNLHCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7F677E0", Offset = "0x7F66BE0", VA = "0x187F677E0")]
	private void MLJKCEGFGMP(float FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7F66620", Offset = "0x7F65A20", VA = "0x187F66620")]
	private void HHJPNLKGDEO(Vector3 GJJMKPHOIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7F65C00", Offset = "0x7F65000", VA = "0x187F65C00")]
	private Vector3 EJIMEMACLAK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7F64E60", Offset = "0x7F64260", VA = "0x187F64E60")]
	private void AHCJEKBHPDH(Vector3 DKOOKAOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7F66E90", Offset = "0x7F66290", VA = "0x187F66E90")]
	private Vector3 JDCHDEPPCCJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7F67E40", Offset = "0x7F67240", VA = "0x187F67E40")]
	private void PLJIBPBJDIE(Vector3 FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7F668E0", Offset = "0x7F65CE0", VA = "0x187F668E0")]
	private void IKLCANBLICE(Vector3 DKOOKAOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7F66540", Offset = "0x7F65940", VA = "0x187F66540")]
	private void GHBOJPNDICE()
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
