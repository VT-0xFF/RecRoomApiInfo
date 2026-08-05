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
	public class LogRegistrationIndex : BOJNKDJNMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F350", Offset = "0x6F1DF50", VA = "0x186F1F350", Slot = "4")]
		public override void FHCDBNBHAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
	public class _AssemblyIndex : IPFMOKLMBLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private CKEMOIBJBPA bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x14CFF50", Offset = "0x14CEB50", VA = "0x1814CFF50", Slot = "5")]
		public override void JGJIGEFNIIB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A880", Offset = "0x6F29480", VA = "0x186F2A880")]
		private void MNGJLCJEIMO(FKPMNNCCCMF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A820", Offset = "0x6F29420", VA = "0x186F2A820", Slot = "6")]
		public override void GILNKLKCLKE(FKPMNNCCCMF registry, [In] OLGFJANFKOO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "8")]
		public override void NFNLBHNCOKJ(JNBPEJFJHHP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F2AB80", Offset = "0x6F29780", VA = "0x186F2AB80")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, OOHKIHMPJNC
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly KEDKJKIEEGM OHPIPAHKBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool JKMKBKGGACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private DDAOGFDCOOH PDKKBNFMBEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[ENJEIGPOGID(LBBGAALIOCK.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[ENJEIGPOGID(LBBGAALIOCK.SelfAndParent, true, false, false)]
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
		private IIIFFGPCIFG physicsInterpolation;

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
		internal DDAOGFDCOOH DJIIOHPILON
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6F253C0", Offset = "0x6F23FC0", VA = "0x186F253C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private DDAOGFDCOOH LLLJGGHHONP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int COCCIAEPPKD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F27C90", Offset = "0x6F26890", VA = "0x186F27C90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx CFJLCBJACGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F27FF0", Offset = "0x6F26BF0", VA = "0x186F27FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx MOHNEGNCIIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F27F30", Offset = "0x6F26B30", VA = "0x186F27F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx GPMGJNAOOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6F28C90", Offset = "0x6F27890", VA = "0x186F28C90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A190", Offset = "0x6F28D90", VA = "0x186F2A190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform GALBGPPIIKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x86C790", Offset = "0x86B390", VA = "0x18086C790", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform AGEKEPENCGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x86C790", Offset = "0x86B390", VA = "0x18086C790", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public EHMENGICDDK AMMIBIKIAOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F27CF0", Offset = "0x6F268F0", VA = "0x186F27CF0")]
			get
			{
				return default(EHMENGICDDK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F29940", Offset = "0x6F28540", VA = "0x186F29940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OOAGPJDKLHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F28300", Offset = "0x6F26F00", VA = "0x186F28300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool APMKCCEHIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F27E10", Offset = "0x6F26A10", VA = "0x186F27E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public DGGLCAMAKMJ LEMHLCNHAMF
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F28240", Offset = "0x6F26E40", VA = "0x186F28240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F29B00", Offset = "0x6F28700", VA = "0x186F29B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FJFFINOAFID CCPBGIMFGAL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F281E0", Offset = "0x6F26DE0", VA = "0x186F281E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F29A90", Offset = "0x6F28690", VA = "0x186F29A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool LALIMOBDCIM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F28130", Offset = "0x6F26D30", VA = "0x186F28130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody KEIMENOGDOD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F28190", Offset = "0x6F26D90", VA = "0x186F28190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GEKFGNKAHFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F27E70", Offset = "0x6F26A70", VA = "0x186F27E70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F299B0", Offset = "0x6F285B0", VA = "0x186F299B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool EICKEJPPKMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6624110", Offset = "0x6622D10", VA = "0x186624110", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float GCGIBKMHOBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F28C30", Offset = "0x6F27830", VA = "0x186F28C30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float IDCLPNLDLEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F28BD0", Offset = "0x6F277D0", VA = "0x186F28BD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A120", Offset = "0x6F28D20", VA = "0x186F2A120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float IDDLGGDDKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F28560", Offset = "0x6F27160", VA = "0x186F28560")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F29DA0", Offset = "0x6F289A0", VA = "0x186F29DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float JDFIFBHABCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F28360", Offset = "0x6F26F60", VA = "0x186F28360")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6F29B70", Offset = "0x6F28770", VA = "0x186F29B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool KBBECALAIBN
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6F291E0", Offset = "0x6F27DE0", VA = "0x186F291E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A6D0", Offset = "0x6F292D0", VA = "0x186F2A6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 BCGHFAHHJCO
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F289B0", Offset = "0x6F275B0", VA = "0x186F289B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F29EF0", Offset = "0x6F28AF0", VA = "0x186F29EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 PEGHOEABPKB
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F29320", Offset = "0x6F27F20", VA = "0x186F29320")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode FCIJMAPDANF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F284A0", Offset = "0x6F270A0", VA = "0x186F284A0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6F29CC0", Offset = "0x6F288C0", VA = "0x186F29CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float BKCEMCMHNFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F27ED0", Offset = "0x6F26AD0", VA = "0x186F27ED0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F29A20", Offset = "0x6F28620", VA = "0x186F29A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints JMGKMOJEHOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F28500", Offset = "0x6F27100", VA = "0x186F28500")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F29D30", Offset = "0x6F28930", VA = "0x186F29D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 KOLANLOOALD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F28D50", Offset = "0x6F27950", VA = "0x186F28D50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 PBNNBIPAAHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F28D50", Offset = "0x6F27950", VA = "0x186F28D50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A4B0", Offset = "0x6F290B0", VA = "0x186F2A4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float GOMEDJNNMDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6F28A90", Offset = "0x6F27690", VA = "0x186F28A90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F29FD0", Offset = "0x6F28BD0", VA = "0x186F29FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float DOFFNGPMNBG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F29180", Offset = "0x6F27D80", VA = "0x186F29180")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A660", Offset = "0x6F29260", VA = "0x186F2A660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion MLAOJHBMJJN
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F28E30", Offset = "0x6F27A30", VA = "0x186F28E30")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A230", Offset = "0x6F28E30", VA = "0x186F2A230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion BGKNPGABJGE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F290B0", Offset = "0x6F27CB0", VA = "0x186F290B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A590", Offset = "0x6F29190", VA = "0x186F2A590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 NPCOAGLPAAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F28F00", Offset = "0x6F27B00", VA = "0x186F28F00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A300", Offset = "0x6F28F00", VA = "0x186F2A300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion PONFLNJPMEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F28FE0", Offset = "0x6F27BE0", VA = "0x186F28FE0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A3E0", Offset = "0x6F28FE0", VA = "0x186F2A3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 LEDLAOFKHKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F29240", Offset = "0x6F27E40", VA = "0x186F29240")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A740", Offset = "0x6F29340", VA = "0x186F2A740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 JNDAJMGACPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6F28AF0", Offset = "0x6F276F0", VA = "0x186F28AF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6F2A040", Offset = "0x6F28C40", VA = "0x186F2A040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 ICGDBJCJHBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6F283C0", Offset = "0x6F26FC0", VA = "0x186F283C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6F29BE0", Offset = "0x6F287E0", VA = "0x186F29BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 HHFOOHMFEHK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6F288D0", Offset = "0x6F274D0", VA = "0x186F288D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6F29E10", Offset = "0x6F28A10", VA = "0x186F29E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 ADLCNIKBPAI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6F28790", Offset = "0x6F27390", VA = "0x186F28790")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion JBNGPHNPCMH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6F286C0", Offset = "0x6F272C0", VA = "0x186F286C0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 MDCHBOBLPON
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6F294E0", Offset = "0x6F280E0", VA = "0x186F294E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 CEAGLEJJPBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6F29400", Offset = "0x6F28000", VA = "0x186F29400")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool LBAKCFOHGIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6F28870", Offset = "0x6F27470", VA = "0x186F28870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool FLGDOCPBPEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6F282A0", Offset = "0x6F26EA0", VA = "0x186F282A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool JJABIKNJBLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6F27DB0", Offset = "0x6F269B0", VA = "0x186F27DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BENMOBGHGPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6F27D50", Offset = "0x6F26950", VA = "0x186F27D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool NFODCDHNEMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6F27C30", Offset = "0x6F26830", VA = "0x186F27C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool AGCMNKKJPNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6F285C0", Offset = "0x6F271C0", VA = "0x186F285C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool OKAHPDGICCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x23BC560", Offset = "0x23BB160", VA = "0x1823BC560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event LHPNJLPJABN BLEKLBGCMMA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F27B50", Offset = "0x6F26750", VA = "0x186F27B50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6F29860", Offset = "0x6F28460", VA = "0x186F29860")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event KHPGPMAKEDG CNCOOAKKEOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6F278C0", Offset = "0x6F264C0", VA = "0x186F278C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6F295C0", Offset = "0x6F281C0", VA = "0x186F295C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event KHPGPMAKEDG OGGACPOBCAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F27920", Offset = "0x6F26520", VA = "0x186F27920")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6F29630", Offset = "0x6F28230", VA = "0x186F29630")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event KHPGPMAKEDG GJCOGAIJJAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6F27A70", Offset = "0x6F26670", VA = "0x186F27A70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6F29780", Offset = "0x6F28380", VA = "0x186F29780")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<PHMIKAKJJJM, PHMIKAKJJJM> CPOONJOIHHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F27A00", Offset = "0x6F26600", VA = "0x186F27A00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F29710", Offset = "0x6F28310", VA = "0x186F29710")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event KHPGPMAKEDG GIHFIOIHPFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F27AE0", Offset = "0x6F266E0", VA = "0x186F27AE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F297F0", Offset = "0x6F283F0", VA = "0x186F297F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event KHPGPMAKEDG GIABHGAMPJG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F27BC0", Offset = "0x6F267C0", VA = "0x186F27BC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F298D0", Offset = "0x6F284D0", VA = "0x186F298D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event KHPGPMAKEDG ONFGNGCFKEI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F27990", Offset = "0x6F26590", VA = "0x186F27990")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F296A0", Offset = "0x6F282A0", VA = "0x186F296A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500", Slot = "8")]
		private void HOJHAOIKHMC(DDAOGFDCOOH NHLLCDFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F265A0", Offset = "0x6F251A0", VA = "0x186F265A0")]
		internal void JEKPEDKDFDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F275E0", Offset = "0x6F261E0", VA = "0x186F275E0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody ODGAOFGKFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F260D0", Offset = "0x6F24CD0", VA = "0x186F260D0")]
		public OOHKIHMPJNC GetChild(int OPDMGNJCACB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6F27250", Offset = "0x6F25E50", VA = "0x186F27250")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) FGLOGFKAGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F25E80", Offset = "0x6F24A80", VA = "0x186F25E80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F253C0", Offset = "0x6F23FC0", VA = "0x186F253C0")]
		private DDAOGFDCOOH AHGKACKGGEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F26630", Offset = "0x6F25230", VA = "0x186F26630")]
		private void JOJMDOFEJMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F26A20", Offset = "0x6F25620", VA = "0x186F26A20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F265A0", Offset = "0x6F251A0", VA = "0x186F265A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F269C0", Offset = "0x6F255C0", VA = "0x186F269C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F26A80", Offset = "0x6F25680", VA = "0x186F26A80")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F25470", Offset = "0x6F24070", VA = "0x186F25470")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object FGIAGALCIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F26AE0", Offset = "0x6F256E0", VA = "0x186F26AE0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object FGIAGALCIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F26070", Offset = "0x6F24C70", VA = "0x186F26070")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F26960", Offset = "0x6F25560", VA = "0x186F26960")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F273B0", Offset = "0x6F25FB0", VA = "0x186F273B0")]
		public void SetParent(RigidbodyEx GLMEMJNJKAN, bool AHOFFNDGFPE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F26DF0", Offset = "0x6F259F0", VA = "0x186F26DF0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F26380", Offset = "0x6F24F80", VA = "0x186F26380")]
		public bool IsRigidbodyAncestor(RigidbodyEx NCADPGLHNFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F26460", Offset = "0x6F25060", VA = "0x186F26460")]
		public bool IsRigidbodyDescendant(RigidbodyEx JIEMKOOHJHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F256E0", Offset = "0x6F242E0", VA = "0x186F256E0")]
		public void AddInterpolationRestriction(object FGIAGALCIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F26B50", Offset = "0x6F25750", VA = "0x186F26B50")]
		public void RemoveInterpolationRestriction(object FGIAGALCIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F25750", Offset = "0x6F24350", VA = "0x186F25750")]
		public void AddKinematic(object FGIAGALCIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F26BC0", Offset = "0x6F257C0", VA = "0x186F26BC0")]
		public void RemoveKinematic(object FGIAGALCIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F27330", Offset = "0x6F25F30", VA = "0x186F27330")]
		public void SetKinematic(object FGIAGALCIAP, bool KLOJNKJOLCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F27150", Offset = "0x6F25D50", VA = "0x186F27150")]
		public void SetDiscontinuousPositionAndRotation(Vector3 DFICJCFPDHF, Quaternion MFLPLOGCDIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F27050", Offset = "0x6F25C50", VA = "0x186F27050")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JDMAEIMLNKI, Quaternion NCDIEHFMCNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F26270", Offset = "0x6F24E70", VA = "0x186F26270")]
		public Vector3 GetConstrainedVelocity(Vector3 LEDLAOFKHKA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F26160", Offset = "0x6F24D60", VA = "0x186F26160")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 ICGDBJCJHBC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F255F0", Offset = "0x6F241F0", VA = "0x186F255F0")]
		public void AddForce(Vector3 NDHMLIPBMEM, ForceMode CABLINBFCNG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F254E0", Offset = "0x6F240E0", VA = "0x186F254E0")]
		public void AddForceAtPosition(Vector3 NDHMLIPBMEM, Vector3 DFPHDEDIHFK, ForceMode CABLINBFCNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F25920", Offset = "0x6F24520", VA = "0x186F25920")]
		public void AddTorque(Vector3 LGNHCCNOFPE, ForceMode CABLINBFCNG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F257C0", Offset = "0x6F243C0", VA = "0x186F257C0")]
		public void AddRelativeTorque(Vector3 LGNHCCNOFPE, ForceMode CABLINBFCNG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F276B0", Offset = "0x6F262B0", VA = "0x186F276B0")]
		public Vector3 WorldToLocalVelocity(Vector3 IBKMAAFCHJE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F26850", Offset = "0x6F25450", VA = "0x186F26850")]
		public Vector3 LocalToWorldVelocity(Vector3 JNDAJMGACPK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F26010", Offset = "0x6F24C10", VA = "0x186F26010")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F25FB0", Offset = "0x6F24BB0", VA = "0x186F25FB0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F25F50", Offset = "0x6F24B50", VA = "0x186F25F50")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F25EF0", Offset = "0x6F24AF0", VA = "0x186F25EF0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F26F50", Offset = "0x6F25B50", VA = "0x186F26F50")]
		public void ResetVelocityWorldSpace(Vector3 MBKALLPNBAM, Vector3 OAMEOEEJNEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F26E50", Offset = "0x6F25A50", VA = "0x186F26E50")]
		public void ResetVelocityLocalSpace(Vector3 HLKLDKCKCEH, Vector3 HHFOOHMFEHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F26D10", Offset = "0x6F25910", VA = "0x186F26D10")]
		public void ResetLinearVelocityLocalSpace(Vector3 HLKLDKCKCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F274E0", Offset = "0x6F260E0", VA = "0x186F274E0")]
		public bool SweepTest(Vector3 ALGFLILJAIC, [Out] RaycastHit PFOKHEBHEKI, float CEGICKHHGEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F26540", Offset = "0x6F25140", VA = "0x186F26540")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F27480", Offset = "0x6F26080", VA = "0x186F27480")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F27650", Offset = "0x6F26250", VA = "0x186F27650")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F258B0", Offset = "0x6F244B0", VA = "0x186F258B0")]
		public void AddShouldHaveUnityRigidbodyToken(object FGIAGALCIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F26C30", Offset = "0x6F25830", VA = "0x186F26C30")]
		public void RemoveShouldHaveUnityRigidbodyToken(object FGIAGALCIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6F25CB0", Offset = "0x6F248B0", VA = "0x186F25CB0")]
		public void ApplyForceVelocityChange(OJJDFFFIEGN NPNMFINKOEA, Vector3 ENPIBMKFHAB, float EHFKNBFHCDH, float OLKAKNJODNP = 8f, float JFBCEBFFGCN = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F25BB0", Offset = "0x6F247B0", VA = "0x186F25BB0")]
		public void ApplyAngularVelocityChange(JHDMGOFKGOA BCJMONNKMDM, Vector3 MMKABMNCDKC, float IFBKEEKNDLA = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F25D70", Offset = "0x6F24970", VA = "0x186F25D70")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(JHDMGOFKGOA BCJMONNKMDM, Vector3 DELGPMLKBMI, float DENHBDKCCBI = 7f, float FHILGBPMMLD = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F25AE0", Offset = "0x6F246E0", VA = "0x186F25AE0")]
		public bool AllowedScaleChange(float EIHPNDPLKCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F25A10", Offset = "0x6F24610", VA = "0x186F25A10")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx NFNMFDHLBLI, object FGIAGALCIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6F26CA0", Offset = "0x6F258A0", VA = "0x186F26CA0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object FGIAGALCIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F27850", Offset = "0x6F26450", VA = "0x186F27850")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x934F90", Offset = "0x933B90", VA = "0x180934F90", Slot = "4")]
		private GameObject KGLAGLEGKLD()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x86C790", Offset = "0x86B390", VA = "0x18086C790", Slot = "5")]
		private Transform FBNMLOJJBFM()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class EMBJFKBPGFK
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F16960", Offset = "0x6F15560", VA = "0x186F16960")]
	public static DDAOGFDCOOH DJIIOHPILON(this RigidbodyEx DFNINMKDEHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[IGNIBOOGGBF(typeof(FIPJMGIAFHO), new string[] { })]
public class BHOJNNFDHNJ : FIPJMGIAFHO, ILBMAEJLCCN
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private GDNNDJMCIJI CPJPHKBDDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private BBPLMBEFAFG KHAIJLCNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private LDCKLJPHLPO LMEMDKBPHGL;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public BBPLMBEFAFG AAMGPEDMLJF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public LDCKLJPHLPO FKDDLANHFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E980", Offset = "0x6F0D580", VA = "0x186F0E980", Slot = "7")]
	public void InitReferences(OIDPNHHGIAF KIDLIDBBLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EA10", Offset = "0x6F0D610", VA = "0x186F0EA10", Slot = "6")]
	public DDAOGFDCOOH OPHFHLBLMHI(RigidbodyEx DFNINMKDEHN, JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public BHOJNNFDHNJ()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static DEHOLECDIJP UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int NMKIDFJFAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int EEKPOBLKNKL;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F25220", Offset = "0x6F23E20", VA = "0x186F25220")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F25260", Offset = "0x6F23E60", VA = "0x186F25260")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F25240", Offset = "0x6F23E40", VA = "0x186F25240")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string JIMAFLGJGFB, [Optional] UnityEngine.Object FBMKGECLCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string JIMAFLGJGFB, [Optional] UnityEngine.Object FBMKGECLCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F25370", Offset = "0x6F23F70", VA = "0x186F25370")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LJKIFGHCPAP
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class PCAHCFLBBHD : DGGLCAMAKMJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x853CF0", Offset = "0x8528F0", VA = "0x180853CF0", Slot = "4")]
		public Vector3 FMOBGOPIDCM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x853CF0", Offset = "0x8528F0", VA = "0x180853CF0", Slot = "5")]
		public Vector3 AAMDMGMPHFH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public PCAHCFLBBHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static DGGLCAMAKMJ FJJPNEHHLBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F280", Offset = "0x6F1DE80", VA = "0x186F1F280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LFHHDFJKEAB
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode HMLOKICDEBK
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
	void BECEGOJLPJN();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DMNFKPPIFEA(bool LBAKCFOHGIP);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OGAKLICPFAE(bool LBAKCFOHGIP);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HPCLGJNEBKB(Rigidbody GOCIBKPJBKN);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JIGNGHLIKCP(Vector3 ALGFLILJAIC, [Out] RaycastHit PFOKHEBHEKI, float CEGICKHHGEL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MLOKBKMMCMC : IDisposable, AHPBPMBKKIF
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	EHMENGICDDK AMMIBIKIAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<PHMIKAKJJJM, PHMIKAKJJJM> CPOONJOIHHO;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BECEGOJLPJN();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface LDCKLJPHLPO
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ADKBOIAKFOI CDEDBCFFDLJ(DDAOGFDCOOH NHLLCDFJMEP);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ALLAFFFGHIG OJDJGDPKAOK(DDAOGFDCOOH NHLLCDFJMEP);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FCDCIFAAJMP EENGNDGKIBF(DDAOGFDCOOH NHLLCDFJMEP);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PFOIFLIHLAF FAHKEJAGHDJ(DDAOGFDCOOH NHLLCDFJMEP);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LFGOPKGFLIK MPIJLOMIPHJ(DDAOGFDCOOH NHLLCDFJMEP);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MLOKBKMMCMC GDPMCOIHNBC(DDAOGFDCOOH NHLLCDFJMEP);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EHCJFPHGDJK GHBOFDIBNLL(DDAOGFDCOOH NHLLCDFJMEP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FIMABJLPNLI JJOMNJKCDDJ(DDAOGFDCOOH NHLLCDFJMEP);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LFHHDFJKEAB GFDFLCNLDDN(DDAOGFDCOOH NHLLCDFJMEP);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GIDFPNJMLGK LNFJNNGPPPC(DDAOGFDCOOH NHLLCDFJMEP);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DIGOEIFJEHA BELCDOAENMC(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MMPFBFNDBAP EGFJEOGNMHH(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HHEJOIEHFOB MANFEPMPJKC(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GCFAKEECCLK IMILKPEBPEO(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ADKDEGODHEJ ABCDMOAGOGK(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DDAOGFDCOOH OPHFHLBLMHI(RigidbodyEx DFNINMKDEHN, JFIFCIHDNHP IMCLGJBJJKP, FIPJMGIAFHO DJIBBLNPCFA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FIMABJLPNLI
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOOEEJBKFBI(Vector3 NDHMLIPBMEM, ForceMode CABLINBFCNG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LALOIGOPNAL(Vector3 NDHMLIPBMEM, Vector3 DFPHDEDIHFK, ForceMode CABLINBFCNG);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEAEDKNBCBH(Vector3 LGNHCCNOFPE, ForceMode CABLINBFCNG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PDKLEDPMGBI(Vector3 LGNHCCNOFPE, ForceMode CABLINBFCNG = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GIDFPNJMLGK
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool BEAIDGLDKIJ
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
	void HPCLGJNEBKB(Rigidbody GOCIBKPJBKN);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ICAOHPGLGMP(Rigidbody GOCIBKPJBKN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ADKBOIAKFOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<DDAOGFDCOOH> CFJHAEFECEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	DDAOGFDCOOH MOHNEGNCIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	DDAOGFDCOOH MHBJGCIDGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KHPGPMAKEDG CNCOOAKKEOP;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event KHPGPMAKEDG OGGACPOBCAN;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event LHPNJLPJABN AIIAMCJPDCG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action LDMPHBJOJBH;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action NNMPIENFNLP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<DDAOGFDCOOH> GEFOPEGNDOO;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<DDAOGFDCOOH> JMNCKEBMKNM;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action AAJBLDPEHNI;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<DDAOGFDCOOH> AOJEAOMFEEA;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void INMMMEFJOBK(DDAOGFDCOOH IAAJMIGCLIP, bool AHOFFNDGFPE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FCDCIFAAJMP
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 EJOCFBACPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 DECBMPLODHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BAJGPMHECEI(DDAOGFDCOOH GPMGJNAOOEP, object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ECEFPJBEJFN(object FGIAGALCIAP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GCFAKEECCLK
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 KELEGGHFEML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 FHFAIIKLIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float JKDIHAGIKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float JHGNOGKIPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 EHBJFKCKNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion POMDKKODDGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event KHPGPMAKEDG IFBDFMDCINE;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OAIJLGJIIJM((Quaternion rot, Vector3 moments) FGLOGFKAGCE);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HMDNDJHJMGO();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LAALAMLCKCE();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OLAAAIDJIIL();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HPCLGJNEBKB(Rigidbody GOCIBKPJBKN);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ICAOHPGLGMP(Rigidbody GOCIBKPJBKN);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BFDEJOCCNGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HHEJOIEHFOB
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BECEGOJLPJN();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDDOBAAOAIC(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJIJGINABEP(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JBJMMPEFLCE(DDAOGFDCOOH DFNINMKDEHN);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OFOKIMBNION(DDAOGFDCOOH DFNINMKDEHN);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACGNHAMJGPG();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EHCJFPHGDJK
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool JOEIBFGJACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event KHPGPMAKEDG IFLNCOKIILG;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGALEIOGJOF(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BCJCJCALFOM(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFDOKFMNMMN(object FGIAGALCIAP, bool KLOJNKJOLCC);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HPCLGJNEBKB(Rigidbody GKIOHLGLLID);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ICAOHPGLGMP(Rigidbody GOCIBKPJBKN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MMPFBFNDBAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool OOAGPJDKLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool APMKCCEHIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event KHPGPMAKEDG AOLHLNBDNKL;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BECEGOJLPJN();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BMHEEBNDFGG(DDAOGFDCOOH GPMGJNAOOEP);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LIDJLDEBGHG(DDAOGFDCOOH GPMGJNAOOEP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ADKDEGODHEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool GEKFGNKAHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool HCEPJOAJBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints IOEFEOBLGDM
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
	void HPCLGJNEBKB(Rigidbody GOCIBKPJBKN);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ICAOHPGLGMP(Rigidbody GOCIBKPJBKN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PFOIFLIHLAF
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float IJDINGPGKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float KDHPPPPOPDJ
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
	void HPCLGJNEBKB(Rigidbody GOCIBKPJBKN);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ICAOHPGLGMP(Rigidbody GOCIBKPJBKN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LFGOPKGFLIK
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event KHPGPMAKEDG JOFIODJILGG;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BECEGOJLPJN();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MPBEMIDPCGA();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BIHNNNNPIFL();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IGHLBBNBECA();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ALIFGOPEEIG();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AMKCDMMGKBK();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DIGOEIFJEHA
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody KEIMENOGDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool NIHDACHAINP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BECEGOJLPJN();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGEJKFLBIDJ(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GKHMFBAFNFD(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHLPLOGMLBF();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ABPGKJKIEFM();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ALLAFFFGHIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	DGGLCAMAKMJ LEMHLCNHAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	FJFFINOAFID CCPBGIMFGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 ONPFKEDCNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 ALLHEBGBOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 MPGJMEAJPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 CHLEMIIMBME
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float BKCEMCMHNFA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool LALIMOBDCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BECEGOJLPJN();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OGDIDOPEBAJ(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ENJKBCNDMJI(JHDMGOFKGOA BCJMONNKMDM, Vector3 MMKABMNCDKC, float IFBKEEKNDLA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PIJBCDAOOME(OJJDFFFIEGN NPNMFINKOEA, Vector3 ENPIBMKFHAB, float EHFKNBFHCDH, float OLKAKNJODNP = 8f, float JFBCEBFFGCN = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KDPDANBCNFI(JHDMGOFKGOA BCJMONNKMDM, Vector3 DELGPMLKBMI, float DENHBDKCCBI = 7f, float FHILGBPMMLD = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GCNFOIDKAPE();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BJEALMDBJNC();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void INOLOIMKMCF();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void ABBPAIPCJHO();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HPCLGJNEBKB(Rigidbody GOCIBKPJBKN);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 KMKFKNHLOKH(Vector3 LEDLAOFKHKA);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void BOBOALFAGNF(object FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MGDPJEOBKAG(Vector3 LBMPLEAJHCD);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JLNKDNILLCM(Vector3 HLKLDKCKCEH, Vector3 HHFOOHMFEHK);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void NGCILIKOJJD(Vector3 MBKALLPNBAM, Vector3 OAMEOEEJNEL);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 JDACKOKKNNG(Vector3 JNDAJMGACPK);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 GFCJMJHAGDM(Vector3 IBKMAAFCHJE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface BBPLMBEFAFG
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool MJPEMBPNCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFCLNNNDFJG(string MCOFJPDPPAJ);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDEEJPIFIOM(RigidbodyEx DFNINMKDEHN, Action FIPNCHEIGMJ);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KCBEDPNLCFC PIEKPAINLCG(int JNHMFGAHIDH);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BJMPLMCINGL(Vector3 PEGHOEABPKB, float EGDLMKNMLKI, Color BFOBNFFGJIL);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NHFPIAMGNEJ();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HFBLLEIPKFH();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface FIPJMGIAFHO
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	BBPLMBEFAFG AAMGPEDMLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	LDCKLJPHLPO FKDDLANHFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DDAOGFDCOOH OPHFHLBLMHI(RigidbodyEx DFNINMKDEHN, JFIFCIHDNHP IMCLGJBJJKP);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EFLAOMOMLIE : DDAOGFDCOOH, IDisposable, CCILGPDIFOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly FIPJMGIAFHO DJIBBLNPCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal ADKBOIAKFOI BCEHGAICLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal HHEJOIEHFOB AHIAGNODFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal MMPFBFNDBAP ODHIEEDCLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal ALLAFFFGHIG LEDLAOFKHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal FCDCIFAAJMP EKBFGEABIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal GCFAKEECCLK LPOLOGJIHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal PFOIFLIHLAF JGFHOOKPDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal GIDFPNJMLGK DGALMEBLHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal LFGOPKGFLIK GCPKHAJCFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal MLOKBKMMCMC OOBCEONMDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal EHCJFPHGDJK CDKHPACBNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal FIMABJLPNLI NDHMLIPBMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal ADKDEGODHEJ DMAPFAMKPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal DIGOEIFJEHA GOCIBKPJBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal LFHHDFJKEAB IFNIFAMJBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable KCDBLLANKDG;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "22")]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public OOHKIHMPJNC DBEPHNOIOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8515A0", Offset = "0x8501A0", VA = "0x1808515A0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x851550", Offset = "0x850150", VA = "0x180851550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject KNJFPDLIBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9B01E0", Offset = "0x9AEDE0", VA = "0x1809B01E0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9B0300", Offset = "0x9AEF00", VA = "0x1809B0300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform KIMEAEOEPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6F160A0", Offset = "0x6F14CA0", VA = "0x186F160A0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody KEIMENOGDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6F10F30", Offset = "0x6F0FB30", VA = "0x186F10F30", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public DDAOGFDCOOH MHBJGCIDGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6F12C10", Offset = "0x6F11810", VA = "0x186F12C10", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6F12A90", Offset = "0x6F11690", VA = "0x186F12A90", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int COCCIAEPPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6F152E0", Offset = "0x6F13EE0", VA = "0x186F152E0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public DDAOGFDCOOH MOHNEGNCIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6F12C60", Offset = "0x6F11860", VA = "0x186F12C60", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool KANIPLBECCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6F14BE0", Offset = "0x6F137E0", VA = "0x186F14BE0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool OOAGPJDKLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6F12D20", Offset = "0x6F11920", VA = "0x186F12D20", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool APMKCCEHIKI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6F158F0", Offset = "0x6F144F0", VA = "0x186F158F0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public DGGLCAMAKMJ LEMHLCNHAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6F13110", Offset = "0x6F11D10", VA = "0x186F13110", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6F14860", Offset = "0x6F13460", VA = "0x186F14860", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public FJFFINOAFID CCPBGIMFGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6F13DE0", Offset = "0x6F129E0", VA = "0x186F13DE0", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6F164A0", Offset = "0x6F150A0", VA = "0x186F164A0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float BKCEMCMHNFA
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6F138C0", Offset = "0x6F124C0", VA = "0x186F138C0", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6F110E0", Offset = "0x6F0FCE0", VA = "0x186F110E0", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 ALLHEBGBOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6F15810", Offset = "0x6F14410", VA = "0x186F15810", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6F11680", Offset = "0x6F10280", VA = "0x186F11680", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 CHLEMIIMBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6F15E90", Offset = "0x6F14A90", VA = "0x186F15E90", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6F12800", Offset = "0x6F11400", VA = "0x186F12800", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 ONPFKEDCNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6F11210", Offset = "0x6F0FE10", VA = "0x186F11210", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6F15200", Offset = "0x6F13E00", VA = "0x186F15200", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 MPGJMEAJPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6F14D10", Offset = "0x6F13910", VA = "0x186F14D10", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6F13BB0", Offset = "0x6F127B0", VA = "0x186F13BB0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool JJABIKNJBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6F112F0", Offset = "0x6F0FEF0", VA = "0x186F112F0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool BENMOBGHGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6F14260", Offset = "0x6F12E60", VA = "0x186F14260", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool NFODCDHNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6F120D0", Offset = "0x6F10CD0", VA = "0x186F120D0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool LALIMOBDCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6F14630", Offset = "0x6F13230", VA = "0x186F14630", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 EJOCFBACPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6F14C40", Offset = "0x6F13840", VA = "0x186F14C40", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 DECBMPLODHA
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6F13AD0", Offset = "0x6F126D0", VA = "0x186F13AD0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 KELEGGHFEML
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F13EB0", Offset = "0x6F12AB0", VA = "0x186F13EB0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F15B60", Offset = "0x6F14760", VA = "0x186F15B60", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 FHFAIIKLIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F10910", Offset = "0x6F0F510", VA = "0x186F10910", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float JKDIHAGIKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F115E0", Offset = "0x6F101E0", VA = "0x186F115E0", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float JHGNOGKIPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F11420", Offset = "0x6F10020", VA = "0x186F11420", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F133D0", Offset = "0x6F11FD0", VA = "0x186F133D0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 EHBJFKCKNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F15FC0", Offset = "0x6F14BC0", VA = "0x186F15FC0", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion POMDKKODDGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F11470", Offset = "0x6F10070", VA = "0x186F11470", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float IJDINGPGKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F165C0", Offset = "0x6F151C0", VA = "0x186F165C0", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F12730", Offset = "0x6F11330", VA = "0x186F12730", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float KDHPPPPOPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F11590", Offset = "0x6F10190", VA = "0x186F11590", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F125B0", Offset = "0x6F111B0", VA = "0x186F125B0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool BEAIDGLDKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F11630", Offset = "0x6F10230", VA = "0x186F11630", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F13D80", Offset = "0x6F12980", VA = "0x186F13D80", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public EHMENGICDDK AMMIBIKIAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F107E0", Offset = "0x6F0F3E0", VA = "0x186F107E0", Slot = "68")]
		get
		{
			return default(EHMENGICDDK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F141A0", Offset = "0x6F12DA0", VA = "0x186F141A0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool JOEIBFGJACF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F11540", Offset = "0x6F10140", VA = "0x186F11540", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform AGEKEPENCGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F162F0", Offset = "0x6F14EF0", VA = "0x186F162F0", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 EOHOOMJOMKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F167A0", Offset = "0x6F153A0", VA = "0x186F167A0", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F10A40", Offset = "0x6F0F640", VA = "0x186F10A40", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float MFAPAGPDOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F13E30", Offset = "0x6F12A30", VA = "0x186F13E30", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F12CB0", Offset = "0x6F118B0", VA = "0x186F12CB0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float LAJFDNOAJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F12790", Offset = "0x6F11390", VA = "0x186F12790", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F13660", Offset = "0x6F12260", VA = "0x186F13660", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion BHIAIJDAHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F129E0", Offset = "0x6F115E0", VA = "0x186F129E0", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F163B0", Offset = "0x6F14FB0", VA = "0x186F163B0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 OCLAILDFLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F14680", Offset = "0x6F13280", VA = "0x186F14680", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F11090", Offset = "0x6F0FC90", VA = "0x186F11090", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion OJMCLJJHOHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F132E0", Offset = "0x6F11EE0", VA = "0x186F132E0", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6F16760", Offset = "0x6F15360", VA = "0x186F16760", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints IOEFEOBLGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F12320", Offset = "0x6F10F20", VA = "0x186F12320", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6F14A40", Offset = "0x6F13640", VA = "0x186F14A40", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool GEKFGNKAHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F15C40", Offset = "0x6F14840", VA = "0x186F15C40", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6F13600", Offset = "0x6F12200", VA = "0x186F13600", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode HMLOKICDEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F11FB0", Offset = "0x6F10BB0", VA = "0x186F11FB0", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6F10830", Offset = "0x6F0F430", VA = "0x186F10830", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool NOEHGCFIJDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6F12470", Offset = "0x6F11070", VA = "0x186F12470", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool FLGDOCPBPEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F148C0", Offset = "0x6F134C0", VA = "0x186F148C0", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event KHPGPMAKEDG CNCOOAKKEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6F12EA0", Offset = "0x6F11AA0", VA = "0x186F12EA0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6F14470", Offset = "0x6F13070", VA = "0x186F14470", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event KHPGPMAKEDG OGGACPOBCAN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6F14AA0", Offset = "0x6F136A0", VA = "0x186F14AA0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6F10F80", Offset = "0x6F0FB80", VA = "0x186F10F80", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event LHPNJLPJABN AIIAMCJPDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6F13910", Offset = "0x6F12510", VA = "0x186F13910", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6F11E80", Offset = "0x6F10A80", VA = "0x186F11E80", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event KHPGPMAKEDG AOLHLNBDNKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6F12AF0", Offset = "0x6F116F0", VA = "0x186F12AF0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6F11030", Offset = "0x6F0FC30", VA = "0x186F11030", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event KHPGPMAKEDG GJCOGAIJJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F157B0", Offset = "0x6F143B0", VA = "0x186F157B0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F15B00", Offset = "0x6F14700", VA = "0x186F15B00", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event KHPGPMAKEDG JOFIODJILGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F13760", Offset = "0x6F12360", VA = "0x186F13760", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6F14800", Offset = "0x6F13400", VA = "0x186F14800", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<PHMIKAKJJJM, PHMIKAKJJJM> CPOONJOIHHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F14200", Offset = "0x6F12E00", VA = "0x186F14200", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F12670", Offset = "0x6F11270", VA = "0x186F12670", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event KHPGPMAKEDG IFLNCOKIILG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6F10CE0", Offset = "0x6F0F8E0", VA = "0x186F10CE0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F11D70", Offset = "0x6F10970", VA = "0x186F11D70", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event KHPGPMAKEDG ONFGNGCFKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F16300", Offset = "0x6F14F00", VA = "0x186F16300", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F143C0", Offset = "0x6F12FC0", VA = "0x186F143C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6F16890", Offset = "0x6F15490", VA = "0x186F16890")]
	public EFLAOMOMLIE(GameObject OLFFLDPKCIP, RigidbodyEx GJCLNIHGGMA, FIPJMGIAFHO DJIBBLNPCFA, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6F11A80", Offset = "0x6F10680", VA = "0x186F11A80", Slot = "136")]
	protected virtual void DDNOAGCFDIL(FIPJMGIAFHO DJIBBLNPCFA, JFIFCIHDNHP IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6F12000", Offset = "0x6F10C00", VA = "0x186F12000", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6F10DA0", Offset = "0x6F0F9A0", VA = "0x186F10DA0", Slot = "91")]
	public void BECEGOJLPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6F10790", Offset = "0x6F0F390", VA = "0x186F10790", Slot = "92")]
	public void BPJHNHCEHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6F12D70", Offset = "0x6F11970", VA = "0x186F12D70", Slot = "93")]
	public void HGNFAKEJLFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6F12D90", Offset = "0x6F11990", VA = "0x186F12D90")]
	private void HHCIDMMBLDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6F10890", Offset = "0x6F0F490", VA = "0x186F10890", Slot = "30")]
	public DDAOGFDCOOH AIKBLINKLIA(int OPDMGNJCACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6F13540", Offset = "0x6F12140", VA = "0x186F13540", Slot = "95")]
	public void INMMMEFJOBK(DDAOGFDCOOH GLMEMJNJKAN, bool AHOFFNDGFPE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6F13320", Offset = "0x6F11F20", VA = "0x186F13320", Slot = "96")]
	public void IFECGGABOHG(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6F13E50", Offset = "0x6F12A50", VA = "0x186F13E50", Slot = "97")]
	public void JOLLHBHENCJ(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6F128E0", Offset = "0x6F114E0", VA = "0x186F128E0", Slot = "98")]
	public Vector3 GFCJMJHAGDM(Vector3 IBKMAAFCHJE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6F137C0", Offset = "0x6F123C0", VA = "0x186F137C0", Slot = "99")]
	public Vector3 JDACKOKKNNG(Vector3 JNDAJMGACPK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6F10790", Offset = "0x6F0F390", VA = "0x186F10790", Slot = "100")]
	public void ABBPAIPCJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6F10FE0", Offset = "0x6F0FBE0", VA = "0x186F10FE0", Slot = "101")]
	public void BJEALMDBJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6F127B0", Offset = "0x6F113B0", VA = "0x186F127B0", Slot = "102")]
	public void GCNFOIDKAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6F15350", Offset = "0x6F13F50", VA = "0x186F15350", Slot = "103")]
	public void NGCILIKOJJD(Vector3 MBKALLPNBAM, Vector3 OAMEOEEJNEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6F13C90", Offset = "0x6F12890", VA = "0x186F13C90", Slot = "104")]
	public void JLNKDNILLCM(Vector3 HLKLDKCKCEH, Vector3 HHFOOHMFEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6F14B00", Offset = "0x6F13700", VA = "0x186F14B00", Slot = "105")]
	public void MGDPJEOBKAG(Vector3 LBMPLEAJHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6F16500", Offset = "0x6F15100", VA = "0x186F16500", Slot = "106")]
	public void PIJBCDAOOME(OJJDFFFIEGN NPNMFINKOEA, Vector3 ENPIBMKFHAB, float EHFKNBFHCDH, float OLKAKNJODNP = 8f, float JFBCEBFFGCN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6F12370", Offset = "0x6F10F70", VA = "0x186F12370", Slot = "107")]
	public void ENJKBCNDMJI(JHDMGOFKGOA BCJMONNKMDM, Vector3 MMKABMNCDKC, float IFBKEEKNDLA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6F13F90", Offset = "0x6F12B90", VA = "0x186F13F90", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void KDPDANBCNFI(JHDMGOFKGOA BCJMONNKMDM, Vector3 DELGPMLKBMI, float DENHBDKCCBI = 7f, float FHILGBPMMLD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6F142C0", Offset = "0x6F12EC0", VA = "0x186F142C0", Slot = "109")]
	public Vector3 KMKFKNHLOKH(Vector3 GLMEMJNJKAN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6F12F00", Offset = "0x6F11B00", VA = "0x186F12F00", Slot = "110")]
	public Vector3 HJINCKJFPJP(Vector3 GLMEMJNJKAN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6F135B0", Offset = "0x6F121B0", VA = "0x186F135B0", Slot = "111")]
	public void INOLOIMKMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6F11340", Offset = "0x6F0FF40", VA = "0x186F11340", Slot = "112")]
	public void BOBKKGMMEEN(DDAOGFDCOOH NFNMFDHLBLI, object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F12BB0", Offset = "0x6F117B0", VA = "0x186F12BB0", Slot = "113")]
	public void GKNKGHFBOEN(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F15940", Offset = "0x6F14540", VA = "0x186F15940", Slot = "61")]
	public void OAIJLGJIIJM((Quaternion rot, Vector3 moments) FGLOGFKAGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F144D0", Offset = "0x6F130D0", VA = "0x186F144D0", Slot = "114")]
	public void LAALAMLCKCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F13000", Offset = "0x6F11C00", VA = "0x186F13000", Slot = "115")]
	public void HMDNDJHJMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F15F70", Offset = "0x6F14B70", VA = "0x186F15F70", Slot = "116")]
	public void OLAAAIDJIIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F151B0", Offset = "0x6F13DB0", VA = "0x186F151B0", Slot = "117")]
	public bool MPBEMIDPCGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F13380", Offset = "0x6F11F80", VA = "0x186F13380", Slot = "94")]
	public void IGHLBBNBECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F109F0", Offset = "0x6F0F5F0", VA = "0x186F109F0", Slot = "118")]
	public void AMKCDMMGKBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F12610", Offset = "0x6F11210", VA = "0x186F12610", Slot = "119")]
	public void FGALEIOGJOF(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F10D40", Offset = "0x6F0F940", VA = "0x186F10D40", Slot = "120")]
	public void BCJCJCALFOM(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F113B0", Offset = "0x6F0FFB0", VA = "0x186F113B0", Slot = "121")]
	public void CFDOKFMNMMN(object FGIAGALCIAP, bool KLOJNKJOLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F15C90", Offset = "0x6F14890", VA = "0x186F15C90", Slot = "122")]
	public void OHKJLLPEMBE(Vector3 DFICJCFPDHF, Quaternion MFLPLOGCDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F16610", Offset = "0x6F15210", VA = "0x186F16610", Slot = "123")]
	public void PNAKNPIEKIA(Vector3 JDMAEIMLNKI, Quaternion NCDIEHFMCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F126D0", Offset = "0x6F112D0", VA = "0x186F126D0", Slot = "124")]
	public bool GBENLCKHGAO(float EIHPNDPLKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F12E40", Offset = "0x6F11A40", VA = "0x186F12E40", Slot = "125")]
	public void HICPHMAMADG(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F147A0", Offset = "0x6F133A0", VA = "0x186F147A0", Slot = "126")]
	public void LIKLOMCELCB(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F13970", Offset = "0x6F12570", VA = "0x186F13970", Slot = "127")]
	public void JGEJKFLBIDJ(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F12B50", Offset = "0x6F11750", VA = "0x186F12B50", Slot = "128")]
	public void GKHMFBAFNFD(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F16130", Offset = "0x6F14D30", VA = "0x186F16130", Slot = "129")]
	public void OOOEEJBKFBI(Vector3 NDHMLIPBMEM, ForceMode CABLINBFCNG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F14520", Offset = "0x6F13120", VA = "0x186F14520", Slot = "130")]
	public void LALOIGOPNAL(Vector3 NDHMLIPBMEM, Vector3 DFPHDEDIHFK, ForceMode CABLINBFCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F15A20", Offset = "0x6F14620", VA = "0x186F15A20", Slot = "131")]
	public void OEAEDKNBCBH(Vector3 LGNHCCNOFPE, ForceMode CABLINBFCNG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F16210", Offset = "0x6F14E10", VA = "0x186F16210", Slot = "132")]
	public void PDKLEDPMGBI(Vector3 LGNHCCNOFPE, ForceMode CABLINBFCNG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F139D0", Offset = "0x6F125D0", VA = "0x186F139D0", Slot = "133")]
	public bool JIGNGHLIKCP(Vector3 ALGFLILJAIC, [Out] RaycastHit PFOKHEBHEKI, float CEGICKHHGEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F10EE0", Offset = "0x6F0FAE0", VA = "0x186F10EE0", Slot = "134")]
	public void BFDEJOCCNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F16850", Offset = "0x6F15450", VA = "0x186F16850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F11EE0", Offset = "0x6F10AE0", VA = "0x186F11EE0")]
	private void DNGLNLAHKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F13430", Offset = "0x6F12030", VA = "0x186F13430")]
	private void INKAFMGLDGK(DDAOGFDCOOH GPMGJNAOOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F10B00", Offset = "0x6F0F700", VA = "0x186F10B00")]
	private void BAMOFAMDODO(DDAOGFDCOOH GPMGJNAOOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F11DD0", Offset = "0x6F109D0", VA = "0x186F11DD0")]
	private void DJDFEANJEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F140A0", Offset = "0x6F12CA0", VA = "0x186F140A0")]
	private void KHOOFFBCMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F13160", Offset = "0x6F11D60", VA = "0x186F13160")]
	private void HOJBKENGAHD(DDAOGFDCOOH GDOEEPFFCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F11140", Offset = "0x6F0FD40", VA = "0x186F11140")]
	private void BMHEEBNDFGG(DDAOGFDCOOH GPMGJNAOOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F146D0", Offset = "0x6F132D0", VA = "0x186F146D0")]
	private void LIDJLDEBGHG(DDAOGFDCOOH GPMGJNAOOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F121B0", Offset = "0x6F10DB0", VA = "0x186F121B0")]
	private void EGFFENCOLEN(OOHKIHMPJNC GPMGJNAOOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F14DF0", Offset = "0x6F139F0", VA = "0x186F14DF0", Slot = "141")]
	protected virtual void MOAGONMHJOO(OOHKIHMPJNC DFNINMKDEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F11760", Offset = "0x6F10360", VA = "0x186F11760")]
	protected void DDCCMBPNPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F15440", Offset = "0x6F14040", VA = "0x186F15440")]
	protected void NHKJEBCMEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F13050", Offset = "0x6F11C50", VA = "0x186F13050", Slot = "142")]
	protected virtual IDisposable HMFHLIPLHHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class GMIGOKNPNBK
{
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F17E50", Offset = "0x6F16A50", VA = "0x186F17E50")]
	public static DDAOGFDCOOH NFJFEOCGBJN(this DDAOGFDCOOH DFNINMKDEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F17F90", Offset = "0x6F16B90", VA = "0x186F17F90")]
	public static bool PMPGIBKOIOE(this DDAOGFDCOOH DFNINMKDEHN, DDAOGFDCOOH NCADPGLHNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F17F10", Offset = "0x6F16B10", VA = "0x186F17F10")]
	public static bool PIAFJFIJECB(this DDAOGFDCOOH DFNINMKDEHN, DDAOGFDCOOH JIEMKOOHJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F17D90", Offset = "0x6F16990", VA = "0x186F17D90")]
	public static OOHKIHMPJNC GPOPDMJJFGF(this DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F17DE0", Offset = "0x6F169E0", VA = "0x186F17DE0")]
	public static EFLAOMOMLIE LPOHELALBDI(this DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NLJEFOFCLJF : LDCKLJPHLPO
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F21B00", Offset = "0x6F20700", VA = "0x186F21B00", Slot = "19")]
	public DDAOGFDCOOH OPHFHLBLMHI(RigidbodyEx DFNINMKDEHN, JFIFCIHDNHP IMCLGJBJJKP, FIPJMGIAFHO DJIBBLNPCFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "4")]
	public ADKBOIAKFOI CDEDBCFFDLJ(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "5")]
	public ALLAFFFGHIG OJDJGDPKAOK(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "6")]
	public FCDCIFAAJMP EENGNDGKIBF(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "7")]
	public PFOIFLIHLAF FAHKEJAGHDJ(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "8")]
	public LFGOPKGFLIK MPIJLOMIPHJ(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "9")]
	public MLOKBKMMCMC GDPMCOIHNBC(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "10")]
	public EHCJFPHGDJK GHBOFDIBNLL(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "11")]
	public FIMABJLPNLI JJOMNJKCDDJ(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "12")]
	public LFHHDFJKEAB GFDFLCNLDDN(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "13")]
	public GIDFPNJMLGK LNFJNNGPPPC(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0")]
	public DIGOEIFJEHA BELCDOAENMC(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0")]
	public MMPFBFNDBAP EGFJEOGNMHH(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0")]
	public HHEJOIEHFOB MANFEPMPJKC(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0")]
	public GCFAKEECCLK IMILKPEBPEO(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0")]
	public ADKDEGODHEJ ABCDMOAGOGK(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public NLJEFOFCLJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "14")]
	private DIGOEIFJEHA NOCIACNBKEN(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "15")]
	private MMPFBFNDBAP HFLNJEPBEMF(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "16")]
	private HHEJOIEHFOB DBIOGDGONFJ(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "17")]
	private GCFAKEECCLK LFKDAJBGBFM(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "18")]
	private ADKDEGODHEJ NMFONCLOHEE(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[IGNIBOOGGBF(typeof(LDCKLJPHLPO), new string[] { })]
public class FCIOHOACDJA : LDCKLJPHLPO, ILBMAEJLCCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly LDCKLJPHLPO FLJCHMNMIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly LDCKLJPHLPO CEPMCBDOCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private GDNNDJMCIJI CPJPHKBDDMA;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private LDCKLJPHLPO FKDDLANHFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6F17050", Offset = "0x6F15C50", VA = "0x186F17050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6F17160", Offset = "0x6F15D60", VA = "0x186F17160", Slot = "20")]
	public void InitReferences(OIDPNHHGIAF KIDLIDBBLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6F16B30", Offset = "0x6F15730", VA = "0x186F16B30", Slot = "4")]
	public ADKBOIAKFOI CDEDBCFFDLJ(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6F17390", Offset = "0x6F15F90", VA = "0x186F17390", Slot = "5")]
	public ALLAFFFGHIG OJDJGDPKAOK(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6F16C80", Offset = "0x6F15880", VA = "0x186F16C80", Slot = "6")]
	public FCDCIFAAJMP EENGNDGKIBF(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6F16DD0", Offset = "0x6F159D0", VA = "0x186F16DD0", Slot = "7")]
	public PFOIFLIHLAF FAHKEJAGHDJ(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6F172F0", Offset = "0x6F15EF0", VA = "0x186F172F0", Slot = "8")]
	public LFGOPKGFLIK MPIJLOMIPHJ(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6F16E70", Offset = "0x6F15A70", VA = "0x186F16E70", Slot = "9")]
	public MLOKBKMMCMC GDPMCOIHNBC(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6F16FB0", Offset = "0x6F15BB0", VA = "0x186F16FB0", Slot = "10")]
	public EHCJFPHGDJK GHBOFDIBNLL(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6F171B0", Offset = "0x6F15DB0", VA = "0x186F171B0", Slot = "11")]
	public FIMABJLPNLI JJOMNJKCDDJ(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6F16F10", Offset = "0x6F15B10", VA = "0x186F16F10", Slot = "12")]
	public LFHHDFJKEAB GFDFLCNLDDN(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6F17250", Offset = "0x6F15E50", VA = "0x186F17250", Slot = "13")]
	public GIDFPNJMLGK LNFJNNGPPPC(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F16A80", Offset = "0x6F15680", VA = "0x186F16A80")]
	public DIGOEIFJEHA BELCDOAENMC(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F16D20", Offset = "0x6F15920", VA = "0x186F16D20")]
	public MMPFBFNDBAP EGFJEOGNMHH(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6F16BD0", Offset = "0x6F157D0", VA = "0x186F16BD0")]
	public HHEJOIEHFOB MANFEPMPJKC(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6F170B0", Offset = "0x6F15CB0", VA = "0x186F170B0")]
	public GCFAKEECCLK IMILKPEBPEO(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6F169D0", Offset = "0x6F155D0", VA = "0x186F169D0")]
	public ADKDEGODHEJ ABCDMOAGOGK(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6F17430", Offset = "0x6F16030", VA = "0x186F17430", Slot = "19")]
	public DDAOGFDCOOH OPHFHLBLMHI(RigidbodyEx DFNINMKDEHN, JFIFCIHDNHP IMCLGJBJJKP, FIPJMGIAFHO DJIBBLNPCFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6F17580", Offset = "0x6F16180", VA = "0x186F17580")]
	public FCIOHOACDJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6F16A80", Offset = "0x6F15680", VA = "0x186F16A80", Slot = "14")]
	private DIGOEIFJEHA NOCIACNBKEN(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6F16D20", Offset = "0x6F15920", VA = "0x186F16D20", Slot = "15")]
	private MMPFBFNDBAP HFLNJEPBEMF(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6F16BD0", Offset = "0x6F157D0", VA = "0x186F16BD0", Slot = "16")]
	private HHEJOIEHFOB DBIOGDGONFJ(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6F170B0", Offset = "0x6F15CB0", VA = "0x186F170B0", Slot = "17")]
	private GCFAKEECCLK LFKDAJBGBFM(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6F169D0", Offset = "0x6F155D0", VA = "0x186F169D0", Slot = "18")]
	private ADKDEGODHEJ NMFONCLOHEE(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EOFAOBGJGPA : ADKBOIAKFOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEMHFMODGPL(DDAOGFDCOOH DFNINMKDEHN);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLPBDNHKHGC(DDAOGFDCOOH DFNINMKDEHN);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGCHDLNGOPF(DDAOGFDCOOH GDOEEPFFCLG);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OPHCJHAGHLI(DDAOGFDCOOH GDOEEPFFCLG);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CGNPJCCBPDD : FCDCIFAAJMP
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	IKLOBMHBPKB<DDAOGFDCOOH> PKEKIOLPDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	DDAOGFDCOOH BJKBLGIOJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HNMDEIKCLLM : GCFAKEECCLK
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) AEOJIDGCEJO(Rigidbody OHJKALBCCDA);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface EMNIGLPBBPA : MMPFBFNDBAP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView GHFOOIFBFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class GEIKMLMBFHP : LFHHDFJKEAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly EFLAOMOMLIE DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode JCOJADOCEFP;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody KEIMENOGDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F7C0", Offset = "0x6F0E3C0", VA = "0x186F0F7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode HMLOKICDEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6F17A90", Offset = "0x6F16690", VA = "0x186F17A90", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6F177E0", Offset = "0x6F163E0", VA = "0x186F177E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6F10580", Offset = "0x6F0F180", VA = "0x186F10580")]
	public GEIKMLMBFHP(DDAOGFDCOOH DFNINMKDEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6F17850", Offset = "0x6F16450", VA = "0x186F17850", Slot = "6")]
	public void BECEGOJLPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6F17BA0", Offset = "0x6F167A0", VA = "0x186F17BA0", Slot = "9")]
	public void HPCLGJNEBKB(Rigidbody GOCIBKPJBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6F17A80", Offset = "0x6F16680", VA = "0x186F17A80", Slot = "7")]
	public void DMNFKPPIFEA(bool LBAKCFOHGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6F17D80", Offset = "0x6F16980", VA = "0x186F17D80", Slot = "8")]
	public void OGAKLICPFAE(bool LBAKCFOHGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6F17C20", Offset = "0x6F16820", VA = "0x186F17C20", Slot = "10")]
	public bool JIGNGHLIKCP(Vector3 ALGFLILJAIC, [Out] RaycastHit PFOKHEBHEKI, float CEGICKHHGEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6F17960", Offset = "0x6F16560", VA = "0x186F17960")]
	private void CIOLICNOLEJ(bool LBAKCFOHGIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class HODLFFMEEIN : MLOKBKMMCMC, IDisposable, AHPBPMBKKIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly EFLAOMOMLIE DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private EHMENGICDDK FIECOHGHKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KCBEDPNLCFC HJJJAFOMJDF;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public EHMENGICDDK AMMIBIKIAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6F18010", Offset = "0x6F16C10", VA = "0x186F18010", Slot = "6")]
		get
		{
			return default(EHMENGICDDK);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6F184E0", Offset = "0x6F170E0", VA = "0x186F184E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform MGHBFGIEJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6F184C0", Offset = "0x6F170C0", VA = "0x186F184C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<PHMIKAKJJJM, PHMIKAKJJJM> CPOONJOIHHO
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6F185B0", Offset = "0x6F171B0", VA = "0x186F185B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6F18410", Offset = "0x6F17010", VA = "0x186F18410", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6F18660", Offset = "0x6F17260", VA = "0x186F18660")]
	public HODLFFMEEIN(DDAOGFDCOOH DFNINMKDEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6F18150", Offset = "0x6F16D50", VA = "0x186F18150", Slot = "8")]
	public void BECEGOJLPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6F183C0", Offset = "0x6F16FC0", VA = "0x186F183C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x95AF80", Offset = "0x959B80", VA = "0x18095AF80", Slot = "11")]
	private void CBPPFADCOLD(PHMIKAKJJJM DGFKPDOHAJL, PHMIKAKJJJM GKENGHGOOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "12")]
	private void MFPGAPFFHEO(bool JABMDCHHMKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JCAPENLKNGL : LDCKLJPHLPO
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A7E0", Offset = "0x6F193E0", VA = "0x186F1A7E0", Slot = "4")]
	public ADKBOIAKFOI CDEDBCFFDLJ(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B3D0", Offset = "0x6F19FD0", VA = "0x186F1B3D0", Slot = "5")]
	public ALLAFFFGHIG OJDJGDPKAOK(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AA00", Offset = "0x6F19600", VA = "0x186F1AA00", Slot = "6")]
	public FCDCIFAAJMP EENGNDGKIBF(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ACC0", Offset = "0x6F198C0", VA = "0x186F1ACC0", Slot = "7")]
	public PFOIFLIHLAF FAHKEJAGHDJ(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B300", Offset = "0x6F19F00", VA = "0x186F1B300", Slot = "8")]
	public LFGOPKGFLIK MPIJLOMIPHJ(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AD40", Offset = "0x6F19940", VA = "0x186F1AD40", Slot = "9")]
	public MLOKBKMMCMC GDPMCOIHNBC(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AED0", Offset = "0x6F19AD0", VA = "0x186F1AED0", Slot = "10")]
	public EHCJFPHGDJK GHBOFDIBNLL(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B180", Offset = "0x6F19D80", VA = "0x186F1B180", Slot = "11")]
	public FIMABJLPNLI JJOMNJKCDDJ(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AE10", Offset = "0x6F19A10", VA = "0x186F1AE10", Slot = "12")]
	public LFHHDFJKEAB GFDFLCNLDDN(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B240", Offset = "0x6F19E40", VA = "0x186F1B240", Slot = "13")]
	public GIDFPNJMLGK LNFJNNGPPPC(DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A6A0", Offset = "0x6F192A0", VA = "0x186F1A6A0")]
	public DIGOEIFJEHA BELCDOAENMC(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AB30", Offset = "0x6F19730", VA = "0x186F1AB30")]
	public MMPFBFNDBAP EGFJEOGNMHH(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A8D0", Offset = "0x6F194D0", VA = "0x186F1A8D0")]
	public HHEJOIEHFOB MANFEPMPJKC(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AFF0", Offset = "0x6F19BF0", VA = "0x186F1AFF0")]
	public GCFAKEECCLK IMILKPEBPEO(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A5C0", Offset = "0x6F191C0", VA = "0x186F1A5C0")]
	public ADKDEGODHEJ ABCDMOAGOGK(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B4F0", Offset = "0x6F1A0F0", VA = "0x186F1B4F0", Slot = "19")]
	public DDAOGFDCOOH OPHFHLBLMHI(RigidbodyEx DFNINMKDEHN, JFIFCIHDNHP IMCLGJBJJKP, FIPJMGIAFHO DJIBBLNPCFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public JCAPENLKNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A6A0", Offset = "0x6F192A0", VA = "0x186F1A6A0", Slot = "14")]
	private DIGOEIFJEHA NOCIACNBKEN(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AB30", Offset = "0x6F19730", VA = "0x186F1AB30", Slot = "15")]
	private MMPFBFNDBAP HFLNJEPBEMF(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A8D0", Offset = "0x6F194D0", VA = "0x186F1A8D0", Slot = "16")]
	private HHEJOIEHFOB DBIOGDGONFJ(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AFF0", Offset = "0x6F19BF0", VA = "0x186F1AFF0", Slot = "17")]
	private GCFAKEECCLK LFKDAJBGBFM(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A5C0", Offset = "0x6F191C0", VA = "0x186F1A5C0", Slot = "18")]
	private ADKDEGODHEJ NMFONCLOHEE(DDAOGFDCOOH NHLLCDFJMEP, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class DGDDKADAAMI : FIMABJLPNLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly EFLAOMOMLIE DFNINMKDEHN;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody KEIMENOGDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F7C0", Offset = "0x6F0E3C0", VA = "0x186F0F7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool JOEIBFGJACF
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F810", Offset = "0x6F0E410", VA = "0x186F0F810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool KANIPLBECCM
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FDA0", Offset = "0x6F0E9A0", VA = "0x186F0FDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private DDAOGFDCOOH MHBJGCIDGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F860", Offset = "0x6F0E460", VA = "0x186F0F860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6F10580", Offset = "0x6F0F180", VA = "0x186F10580")]
	public DGDDKADAAMI(DDAOGFDCOOH DFNINMKDEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6F101C0", Offset = "0x6F0EDC0", VA = "0x186F101C0", Slot = "4")]
	public void OOOEEJBKFBI(Vector3 NDHMLIPBMEM, ForceMode CABLINBFCNG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FF60", Offset = "0x6F0EB60", VA = "0x186F0FF60")]
	private void OODLKMFCCMD(Vector3 NDHMLIPBMEM, ForceMode CABLINBFCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FB20", Offset = "0x6F0E720", VA = "0x186F0FB20", Slot = "5")]
	public void LALOIGOPNAL(Vector3 NDHMLIPBMEM, Vector3 DFPHDEDIHFK, ForceMode CABLINBFCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FE00", Offset = "0x6F0EA00", VA = "0x186F0FE00", Slot = "6")]
	public void OEAEDKNBCBH(Vector3 LGNHCCNOFPE, ForceMode CABLINBFCNG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F8C0", Offset = "0x6F0E4C0", VA = "0x186F0F8C0")]
	private void JNIOOJGPAAI(Vector3 LGNHCCNOFPE, ForceMode CABLINBFCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6F10320", Offset = "0x6F0EF20", VA = "0x186F10320", Slot = "7")]
	public void PDKLEDPMGBI(Vector3 LGNHCCNOFPE, ForceMode CABLINBFCNG = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class GDECCPNOEAA : GIDFPNJMLGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly EFLAOMOMLIE DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool KBBECALAIBN;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BEAIDGLDKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x90BF40", Offset = "0x90AB40", VA = "0x18090BF40", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6F176D0", Offset = "0x6F162D0", VA = "0x186F176D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6F10580", Offset = "0x6F0F180", VA = "0x186F10580")]
	public GDECCPNOEAA(DDAOGFDCOOH DFNINMKDEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6F17630", Offset = "0x6F16230", VA = "0x186F17630", Slot = "6")]
	public void HPCLGJNEBKB(Rigidbody GOCIBKPJBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6F17660", Offset = "0x6F16260", VA = "0x186F17660", Slot = "7")]
	public void ICAOHPGLGMP(Rigidbody GOCIBKPJBKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class IMHBHJFNJFG : EOFAOBGJGPA, ADKBOIAKFOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DDAOGFDCOOH DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<DDAOGFDCOOH> HHGPLJEIAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private DDAOGFDCOOH BLPDMPJLPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private DDAOGFDCOOH GPMGJNAOOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform PBHGIEICHLJ;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform KIMEAEOEPFL
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A180", Offset = "0x6F18D80", VA = "0x186F1A180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public DDAOGFDCOOH MHBJGCIDGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8431C0", Offset = "0x841DC0", VA = "0x1808431C0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6F18BF0", Offset = "0x6F177F0", VA = "0x186F18BF0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public DDAOGFDCOOH MOHNEGNCIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8432E0", Offset = "0x841EE0", VA = "0x1808432E0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<DDAOGFDCOOH> CFJHAEFECEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x848BE0", Offset = "0x8477E0", VA = "0x180848BE0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event KHPGPMAKEDG CNCOOAKKEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6F18F30", Offset = "0x6F17B30", VA = "0x186F18F30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6F198E0", Offset = "0x6F184E0", VA = "0x186F198E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event KHPGPMAKEDG OGGACPOBCAN
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6F19B40", Offset = "0x6F18740", VA = "0x186F19B40", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6F18790", Offset = "0x6F17390", VA = "0x186F18790", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event LHPNJLPJABN AIIAMCJPDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6F196F0", Offset = "0x6F182F0", VA = "0x186F196F0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6F18AB0", Offset = "0x6F176B0", VA = "0x186F18AB0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action LDMPHBJOJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6F186F0", Offset = "0x6F172F0", VA = "0x186F186F0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6F188D0", Offset = "0x6F174D0", VA = "0x186F188D0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action NNMPIENFNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6F18C00", Offset = "0x6F17800", VA = "0x186F18C00", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6F190D0", Offset = "0x6F17CD0", VA = "0x186F190D0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<DDAOGFDCOOH> GEFOPEGNDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6F19830", Offset = "0x6F18430", VA = "0x186F19830", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6F19BE0", Offset = "0x6F187E0", VA = "0x186F19BE0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<DDAOGFDCOOH> JMNCKEBMKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6F18CA0", Offset = "0x6F178A0", VA = "0x186F18CA0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6F18E80", Offset = "0x6F17A80", VA = "0x186F18E80", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action AAJBLDPEHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A460", Offset = "0x6F19060", VA = "0x186F1A460", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A030", Offset = "0x6F18C30", VA = "0x186F1A030", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<DDAOGFDCOOH> AOJEAOMFEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6F19980", Offset = "0x6F18580", VA = "0x186F19980", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A0D0", Offset = "0x6F18CD0", VA = "0x186F1A0D0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A500", Offset = "0x6F19100", VA = "0x186F1A500")]
	public IMHBHJFNJFG(DDAOGFDCOOH DFNINMKDEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x6F18B50", Offset = "0x6F17750", VA = "0x186F18B50", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6F19170", Offset = "0x6F17D70", VA = "0x186F19170", Slot = "30")]
	public void INMMMEFJOBK(DDAOGFDCOOH IAAJMIGCLIP, bool AHOFFNDGFPE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6F19DC0", Offset = "0x6F189C0", VA = "0x186F19DC0", Slot = "6")]
	public void MGCHDLNGOPF(DDAOGFDCOOH GDOEEPFFCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A1E0", Offset = "0x6F18DE0", VA = "0x186F1A1E0", Slot = "7")]
	public void OPHCJHAGHLI(DDAOGFDCOOH GDOEEPFFCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6F19A30", Offset = "0x6F18630", VA = "0x186F19A30", Slot = "4")]
	public void LEMHFMODGPL(DDAOGFDCOOH DFNINMKDEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6F18830", Offset = "0x6F17430", VA = "0x186F18830", Slot = "5")]
	public void BLPBDNHKHGC(DDAOGFDCOOH DFNINMKDEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6F19790", Offset = "0x6F18390", VA = "0x186F19790")]
	private void KAEJNIJFCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6F18FD0", Offset = "0x6F17BD0", VA = "0x186F18FD0")]
	private void HOPKKAFFANJ(DDAOGFDCOOH GDOEEPFFCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6F18970", Offset = "0x6F17570", VA = "0x186F18970")]
	private void CLLMLDGDAJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6F19C90", Offset = "0x6F18890", VA = "0x186F19C90")]
	private void MFOGPAMDCDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6F18D50", Offset = "0x6F17950", VA = "0x186F18D50")]
	private void GOLJCCFLHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6F19010", Offset = "0x6F17C10", VA = "0x186F19010")]
	[CompilerGenerated]
	private object IHJIDBABGHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class DLHPFKIIKKF
{
	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6F106D0", Offset = "0x6F0F2D0", VA = "0x186F106D0")]
	public static EOFAOBGJGPA MJOGDCELAPN(this DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class NBBJCKNBIIH : CGNPJCCBPDD, FCDCIFAAJMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly EFLAOMOMLIE DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly IKLOBMHBPKB<DDAOGFDCOOH> FGEEFLDNDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool PAMCPBGIIGI;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public IKLOBMHBPKB<DDAOGFDCOOH> PKEKIOLPDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 EJOCFBACPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6F219D0", Offset = "0x6F205D0", VA = "0x186F219D0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 DECBMPLODHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6F21480", Offset = "0x6F20080", VA = "0x186F21480", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 ONPFKEDCNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6F20EF0", Offset = "0x6F1FAF0", VA = "0x186F20EF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public DDAOGFDCOOH BJKBLGIOJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6F213D0", Offset = "0x6F1FFD0", VA = "0x186F213D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6F21A00", Offset = "0x6F20600", VA = "0x186F21A00")]
	public NBBJCKNBIIH(DDAOGFDCOOH DFNINMKDEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6F20E80", Offset = "0x6F1FA80", VA = "0x186F20E80", Slot = "8")]
	public void BAJGPMHECEI(DDAOGFDCOOH GPMGJNAOOEP, object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F21370", Offset = "0x6F1FF70", VA = "0x186F21370", Slot = "9")]
	public void ECEFPJBEJFN(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6F21640", Offset = "0x6F20240", VA = "0x186F21640")]
	private Vector3 LKADJPIGHAE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6F20FE0", Offset = "0x6F1FBE0", VA = "0x186F20FE0")]
	private void DBPBOGOEPAO(DDAOGFDCOOH GEFCHNJIDDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class DGOJNDCLGMO
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6F10610", Offset = "0x6F0F210", VA = "0x186F10610")]
	public static CGNPJCCBPDD GKBHODCHGIE(this DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class OBPMPPBADBI : HNMDEIKCLLM, GCFAKEECCLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly EFLAOMOMLIE DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 AFOBJDMFBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 OGNCCDPDPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float IDCLPNLDLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float GCGIBKMHOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 BCGHFAHHJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? ADLCNIKBPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? JBNGPHNPCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool IELELOGCCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool HAMCDHNCMFP;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 KELEGGHFEML
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xD5DCA0", Offset = "0xD5C8A0", VA = "0x180D5DCA0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6F23F40", Offset = "0x6F22B40", VA = "0x186F23F40", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 FHFAIIKLIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6F22AD0", Offset = "0x6F216D0", VA = "0x186F22AD0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float JKDIHAGIKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B30A0", Offset = "0x8B1CA0", VA = "0x1808B30A0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F23390", Offset = "0x6F21F90", VA = "0x186F23390")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float JHGNOGKIPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B31B0", Offset = "0x8B1DB0", VA = "0x1808B31B0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F22A20", Offset = "0x6F21620", VA = "0x186F22A20", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 EHBJFKCKNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F241A0", Offset = "0x6F22DA0", VA = "0x186F241A0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion POMDKKODDGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F23070", Offset = "0x6F21C70", VA = "0x186F23070", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody KEIMENOGDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F0EE90", Offset = "0x6F0DA90", VA = "0x186F0EE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event KHPGPMAKEDG IFBDFMDCINE
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6F24330", Offset = "0x6F22F30", VA = "0x186F24330", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6F239D0", Offset = "0x6F225D0", VA = "0x186F239D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F243D0", Offset = "0x6F22FD0", VA = "0x186F243D0")]
	public OBPMPPBADBI(DDAOGFDCOOH DFNINMKDEHN, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F23A70", Offset = "0x6F22670", VA = "0x186F23A70", Slot = "17")]
	public void LAALAMLCKCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F234A0", Offset = "0x6F220A0", VA = "0x186F234A0", Slot = "16")]
	public void HMDNDJHJMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F23580", Offset = "0x6F22180", VA = "0x186F23580", Slot = "19")]
	public void HPCLGJNEBKB(Rigidbody GOCIBKPJBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F23660", Offset = "0x6F22260", VA = "0x186F23660", Slot = "20")]
	public void ICAOHPGLGMP(Rigidbody GOCIBKPJBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F23FF0", Offset = "0x6F22BF0", VA = "0x186F23FF0", Slot = "18")]
	public void OLAAAIDJIIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F22BD0", Offset = "0x6F217D0", VA = "0x186F22BD0", Slot = "21")]
	public void BFDEJOCCNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F23F40", Offset = "0x6F22B40", VA = "0x186F23F40")]
	private void PIOHELJALPL(Vector3 GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F23C20", Offset = "0x6F22820", VA = "0x186F23C20")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 MMHBOAEKGKA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F23390", Offset = "0x6F21F90", VA = "0x186F23390")]
	private void GHPHJANMHLF(float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F22A20", Offset = "0x6F21620", VA = "0x186F22A20")]
	private void AGGFNPCHGFI(float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F231F0", Offset = "0x6F21DF0", VA = "0x186F231F0")]
	private Vector3 DJCKCGCJGJD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F23D10", Offset = "0x6F22910", VA = "0x186F23D10", Slot = "15")]
	public void OAIJLGJIIJM((Quaternion rot, Vector3 moments) FGLOGFKAGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F23850", Offset = "0x6F22450", VA = "0x186F23850")]
	private Quaternion IKEEMDLFFNC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F21BA0", Offset = "0x6F207A0", VA = "0x186F21BA0")]
	public void AEOJIDGCEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F21C70", Offset = "0x6F20870", VA = "0x186F21C70", Slot = "4")]
	public (float, Vector3) AEOJIDGCEJO(Rigidbody OHJKALBCCDA)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class LIFEGFJGGBD
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F1C0", Offset = "0x6F1DDC0", VA = "0x186F1F1C0")]
	public static HNMDEIKCLLM LELCEJDIFOO(this DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class MIDJJEJACCL : HHEJOIEHFOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly EFLAOMOMLIE DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly EFNEIMDDKAG NDGGBONFJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly IIIFFGPCIFG DPJMCLAAMAE;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool GENIKBMNKEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xEDA0C0", Offset = "0xED8CC0", VA = "0x180EDA0C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IIIFFGPCIFG GAOEFIHNHPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEF0", Offset = "0x8B9AF0", VA = "0x1808BAEF0", Slot = "11")]
		get
		{
			return default(IIIFFGPCIFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F20B50", Offset = "0x6F1F750", VA = "0x186F20B50")]
	public MIDJJEJACCL(DDAOGFDCOOH DFNINMKDEHN, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F20790", Offset = "0x6F1F390", VA = "0x186F20790", Slot = "4")]
	public void BECEGOJLPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F20A00", Offset = "0x6F1F600", VA = "0x186F20A00")]
	private bool FMHBPOHJOKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F20AE0", Offset = "0x6F1F6E0", VA = "0x186F20AE0", Slot = "5")]
	public void KDDOBAAOAIC(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F20860", Offset = "0x6F1F460", VA = "0x186F20860", Slot = "6")]
	public void BJIJGINABEP(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F20530", Offset = "0x6F1F130", VA = "0x186F20530", Slot = "9")]
	public void ACGNHAMJGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F20670", Offset = "0x6F1F270", VA = "0x186F20670")]
	private void ALGAIPAMAHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F20890", Offset = "0x6F1F490", VA = "0x186F20890")]
	private void EMOMFAOGDMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F20B10", Offset = "0x6F1F710", VA = "0x186F20B10", Slot = "8")]
	public void OFOKIMBNION(DDAOGFDCOOH DFNINMKDEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F20AA0", Offset = "0x6F1F6A0", VA = "0x186F20AA0", Slot = "7")]
	public void JBJMMPEFLCE(DDAOGFDCOOH DFNINMKDEHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class KJLFMDKPFIM : EHCJFPHGDJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly EFLAOMOMLIE DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly EFNEIMDDKAG KDCMBIOCEGE;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool JOEIBFGJACF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F1EE80", Offset = "0x6F1DA80", VA = "0x186F1EE80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event KHPGPMAKEDG IFLNCOKIILG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F1ECC0", Offset = "0x6F1D8C0", VA = "0x186F1ECC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F1EF30", Offset = "0x6F1DB30", VA = "0x186F1EF30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F0D0", Offset = "0x6F1DCD0", VA = "0x186F1F0D0")]
	public KJLFMDKPFIM(DDAOGFDCOOH DFNINMKDEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EFD0", Offset = "0x6F1DBD0", VA = "0x186F1EFD0", Slot = "7")]
	public void FGALEIOGJOF(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ED60", Offset = "0x6F1D960", VA = "0x186F1ED60", Slot = "8")]
	public void BCJCJCALFOM(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ED70", Offset = "0x6F1D970", VA = "0x186F1ED70", Slot = "9")]
	public void CFDOKFMNMMN(object FGIAGALCIAP, bool KLOJNKJOLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F090", Offset = "0x6F1DC90", VA = "0x186F1F090", Slot = "12")]
	public void IMEFPBLGEAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EFE0", Offset = "0x6F1DBE0", VA = "0x186F1EFE0", Slot = "10")]
	public void HPCLGJNEBKB(Rigidbody GKIOHLGLLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F060", Offset = "0x6F1DC60", VA = "0x186F1F060", Slot = "11")]
	public void ICAOHPGLGMP(Rigidbody GOCIBKPJBKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class OLEMGKBANNO : EMNIGLPBBPA, MMPFBFNDBAP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly EFLAOMOMLIE DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView GNOFKBHKOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool ICJIAEGCJDH;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView GHFOOIFBFJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool OOAGPJDKLHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F24A10", Offset = "0x6F23610", VA = "0x186F24A10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool APMKCCEHIKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA53410", Offset = "0xA52010", VA = "0x180A53410", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event KHPGPMAKEDG AOLHLNBDNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F24970", Offset = "0x6F23570", VA = "0x186F24970", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F24660", Offset = "0x6F23260", VA = "0x186F24660", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F250D0", Offset = "0x6F23CD0", VA = "0x186F250D0")]
	public OLEMGKBANNO(DDAOGFDCOOH DFNINMKDEHN, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F24530", Offset = "0x6F23130", VA = "0x186F24530", Slot = "9")]
	public void BECEGOJLPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F24870", Offset = "0x6F23470", VA = "0x186F24870", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F24700", Offset = "0x6F23300", VA = "0x186F24700", Slot = "10")]
	public void BMHEEBNDFGG(DDAOGFDCOOH GPMGJNAOOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F24A30", Offset = "0x6F23630", VA = "0x186F24A30", Slot = "11")]
	public void LIDJLDEBGHG(DDAOGFDCOOH GPMGJNAOOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F24F60", Offset = "0x6F23B60", VA = "0x186F24F60")]
	private void PIEOCFDLFIG(PhotonView ILEKIPBKCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F24BA0", Offset = "0x6F237A0", VA = "0x186F24BA0")]
	private void OMBGKFGBDDA(OOHKIHMPJNC PHALCLBJBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F24CF0", Offset = "0x6F238F0", VA = "0x186F24CF0")]
	private void PANOPNPDCAK(PhotonView FFIAJBHDMGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class CFDEMCIMCBE
{
	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F700", Offset = "0x6F0E300", VA = "0x186F0F700")]
	public static EMNIGLPBBPA IPFGIONPBMG(this DDAOGFDCOOH NHLLCDFJMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class MNPMLMAOHFB : ADKDEGODHEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly EFLAOMOMLIE DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints JMGKMOJEHOB;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool GEKFGNKAHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xCDD560", Offset = "0xCDC160", VA = "0x180CDD560", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x4475170", Offset = "0x4473D70", VA = "0x184475170", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool HCEPJOAJBJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xF299A0", Offset = "0xF285A0", VA = "0x180F299A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x4475160", Offset = "0x4473D60", VA = "0x184475160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints IOEFEOBLGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x84DDF0", Offset = "0x84C9F0", VA = "0x18084DDF0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6F20CB0", Offset = "0x6F1F8B0", VA = "0x186F20CB0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F20DE0", Offset = "0x6F1F9E0", VA = "0x186F20DE0")]
	public MNPMLMAOHFB(DDAOGFDCOOH DFNINMKDEHN, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F20C50", Offset = "0x6F1F850", VA = "0x186F20C50", Slot = "9")]
	public void HPCLGJNEBKB(Rigidbody GOCIBKPJBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F20C80", Offset = "0x6F1F880", VA = "0x186F20C80", Slot = "10")]
	public void ICAOHPGLGMP(Rigidbody GOCIBKPJBKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class MEFDBFCAIBI : PFOIFLIHLAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly DDAOGFDCOOH DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float IDDLGGDDKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float JDFIFBHABCG;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float IJDINGPGKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8B3230", Offset = "0x8B1E30", VA = "0x1808B3230", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F20330", Offset = "0x6F1EF30", VA = "0x186F20330", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float KDHPPPPOPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8B31F0", Offset = "0x8B1DF0", VA = "0x1808B31F0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F20260", Offset = "0x6F1EE60", VA = "0x186F20260", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F204F0", Offset = "0x6F1F0F0", VA = "0x186F204F0")]
	public MEFDBFCAIBI(DDAOGFDCOOH DFNINMKDEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F20400", Offset = "0x6F1F000", VA = "0x186F20400", Slot = "8")]
	public void HPCLGJNEBKB(Rigidbody GOCIBKPJBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F20450", Offset = "0x6F1F050", VA = "0x186F20450", Slot = "9")]
	public void ICAOHPGLGMP(Rigidbody GOCIBKPJBKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class BOMLJLEHCEN : LFGOPKGFLIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly EFLAOMOMLIE DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool INECCDDJBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool BHGNDDGPKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int MEGGOENOEGE;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody KEIMENOGDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F0EE90", Offset = "0x6F0DA90", VA = "0x186F0EE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool NOEHGCFIJDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F080", Offset = "0x6F0DC80", VA = "0x186F0F080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private DDAOGFDCOOH MHBJGCIDGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F0A0", Offset = "0x6F0DCA0", VA = "0x186F0F0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool KANIPLBECCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F4C0", Offset = "0x6F0E0C0", VA = "0x186F0F4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event KHPGPMAKEDG JOFIODJILGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F380", Offset = "0x6F0DF80", VA = "0x186F0F380", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F420", Offset = "0x6F0E020", VA = "0x186F0F420", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F670", Offset = "0x6F0E270", VA = "0x186F0F670")]
	public BOMLJLEHCEN(DDAOGFDCOOH DFNINMKDEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EE00", Offset = "0x6F0DA00", VA = "0x186F0EE00", Slot = "6")]
	public void BECEGOJLPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EEE0", Offset = "0x6F0DAE0", VA = "0x186F0EEE0", Slot = "8")]
	public void BIHNNNNPIFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F520", Offset = "0x6F0E120", VA = "0x186F0F520", Slot = "7")]
	public bool MPBEMIDPCGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F100", Offset = "0x6F0DD00", VA = "0x186F0F100", Slot = "9")]
	public void IGHLBBNBECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F0ED60", Offset = "0x6F0D960", VA = "0x186F0ED60", Slot = "11")]
	public void AMKCDMMGKBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EBB0", Offset = "0x6F0D7B0", VA = "0x186F0EBB0", Slot = "10")]
	public void ALIFGOPEEIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F1A0", Offset = "0x6F0DDA0", VA = "0x186F0F1A0")]
	private bool JADDNPHNEBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EEF0", Offset = "0x6F0DAF0", VA = "0x186F0EEF0")]
	private void DMPBNMGPKOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class MBOOGNILHOK : DIGOEIFJEHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly EFLAOMOMLIE DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly EFNEIMDDKAG KBOLCIDGIAI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody KEIMENOGDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool KANIPLBECCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FDA0", Offset = "0x6F0E9A0", VA = "0x186F0FDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool NIHDACHAINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xEDA0C0", Offset = "0xED8CC0", VA = "0x180EDA0C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F20150", Offset = "0x6F1ED50", VA = "0x186F20150")]
	public MBOOGNILHOK(DDAOGFDCOOH DFNINMKDEHN, [In] JFIFCIHDNHP IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F730", Offset = "0x6F1E330", VA = "0x186F1F730", Slot = "5")]
	public void BECEGOJLPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FD30", Offset = "0x6F1E930", VA = "0x186F1FD30", Slot = "7")]
	public void JGEJKFLBIDJ(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FD00", Offset = "0x6F1E900", VA = "0x186F1FD00", Slot = "8")]
	public void GKHMFBAFNFD(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F9D0", Offset = "0x6F1E5D0", VA = "0x186F1F9D0", Slot = "9")]
	public void FHLPLOGMLBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FD60", Offset = "0x6F1E960", VA = "0x186F1FD60", Slot = "11")]
	public void JLJJFHDGOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F5B0", Offset = "0x6F1E1B0", VA = "0x186F1F5B0", Slot = "12")]
	public void AEACPMFNDCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F420", Offset = "0x6F1E020", VA = "0x186F1F420", Slot = "10")]
	public void ABPGKJKIEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FF50", Offset = "0x6F1EB50", VA = "0x186F1FF50")]
	private void KAHLJGKPNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F7D0", Offset = "0x6F1E3D0", VA = "0x186F1F7D0")]
	private void ECHPKEBHPLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class JMIMABJIABE : ALLAFFFGHIG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly EFLAOMOMLIE DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly EFNEIMDDKAG CKGNIECPCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float BEAGJEPHPFC;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public DGGLCAMAKMJ LEMHLCNHAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x847810", Offset = "0x846410", VA = "0x180847810", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public FJFFINOAFID CCPBGIMFGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 ONPFKEDCNHK
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B950", Offset = "0x6F1A550", VA = "0x186F1B950", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DA60", Offset = "0x6F1C660", VA = "0x186F1DA60", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 ALLHEBGBOEI
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DD60", Offset = "0x6F1C960", VA = "0x186F1DD60", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6F1BAB0", Offset = "0x6F1A6B0", VA = "0x186F1BAB0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 MPGJMEAJPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D350", Offset = "0x6F1BF50", VA = "0x186F1D350", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CBC0", Offset = "0x6F1B7C0", VA = "0x186F1CBC0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 CHLEMIIMBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DFA0", Offset = "0x6F1CBA0", VA = "0x186F1DFA0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C0A0", Offset = "0x6F1ACA0", VA = "0x186F1C0A0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float BKCEMCMHNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8B3110", Offset = "0x8B1D10", VA = "0x1808B3110", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B840", Offset = "0x6F1A440", VA = "0x186F1B840", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool LALIMOBDCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x189AC60", Offset = "0x1899860", VA = "0x18189AC60", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private FIMABJLPNLI ABFEDHOPHGB
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6758810", Offset = "0x6757410", VA = "0x186758810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool NOEHGCFIJDF
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6F1BDD0", Offset = "0x6F1A9D0", VA = "0x186F1BDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EBD0", Offset = "0x6F1D7D0", VA = "0x186F1EBD0")]
	public JMIMABJIABE(DDAOGFDCOOH DFNINMKDEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B730", Offset = "0x6F1A330", VA = "0x186F1B730", Slot = "19")]
	public void BECEGOJLPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BAE0", Offset = "0x6F1A6E0", VA = "0x186F1BAE0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C2B0", Offset = "0x6F1AEB0", VA = "0x186F1C2B0", Slot = "28")]
	public void HPCLGJNEBKB(Rigidbody GOCIBKPJBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0xD1A9E0", Offset = "0xD195E0", VA = "0x180D1A9E0", Slot = "20")]
	public void OGDIDOPEBAJ(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0xD1A1A0", Offset = "0xD18DA0", VA = "0x180D1A1A0", Slot = "30")]
	public void BOBOALFAGNF(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C0D0", Offset = "0x6F1ACD0", VA = "0x186F1C0D0", Slot = "35")]
	public Vector3 GFCJMJHAGDM(Vector3 IBKMAAFCHJE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CA00", Offset = "0x6F1B600", VA = "0x186F1CA00", Slot = "34")]
	public Vector3 JDACKOKKNNG(Vector3 JNDAJMGACPK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B730", Offset = "0x6F1A330", VA = "0x186F1B730", Slot = "27")]
	public void ABBPAIPCJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B7E0", Offset = "0x6F1A3E0", VA = "0x186F1B7E0", Slot = "25")]
	public void BJEALMDBJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C040", Offset = "0x6F1AC40", VA = "0x186F1C040", Slot = "24")]
	public void GCNFOIDKAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DB20", Offset = "0x6F1C720", VA = "0x186F1DB20", Slot = "33")]
	public void NGCILIKOJJD(Vector3 MBKALLPNBAM, Vector3 OAMEOEEJNEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CC80", Offset = "0x6F1B880", VA = "0x186F1CC80", Slot = "32")]
	public void JLNKDNILLCM(Vector3 HLKLDKCKCEH, Vector3 HHFOOHMFEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D1B0", Offset = "0x6F1BDB0", VA = "0x186F1D1B0", Slot = "31")]
	public void MGDPJEOBKAG(Vector3 LBMPLEAJHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E560", Offset = "0x6F1D160", VA = "0x186F1E560", Slot = "22")]
	public void PIJBCDAOOME(OJJDFFFIEGN NPNMFINKOEA, Vector3 ENPIBMKFHAB, float EHFKNBFHCDH, float OLKAKNJODNP = 8f, float JFBCEBFFGCN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BB40", Offset = "0x6F1A740", VA = "0x186F1BB40", Slot = "21")]
	public void ENJKBCNDMJI(JHDMGOFKGOA BCJMONNKMDM, Vector3 MMKABMNCDKC, float IFBKEEKNDLA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CCE0", Offset = "0x6F1B8E0", VA = "0x186F1CCE0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void KDPDANBCNFI(JHDMGOFKGOA BCJMONNKMDM, Vector3 DELGPMLKBMI, float DENHBDKCCBI = 7f, float FHILGBPMMLD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0xE35260", Offset = "0xE33E60", VA = "0x180E35260")]
	private static void NNABJGJCJDH(Vector3 LEDLAOFKHKA, Vector3 KLEPCPADMKG, [Out] Vector3 IIINHOJBIMB, [Out] Vector3 FDIHFBEEFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D0D0", Offset = "0x6F1BCD0", VA = "0x186F1D0D0", Slot = "29")]
	public Vector3 KMKFKNHLOKH(Vector3 LEDLAOFKHKA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C870", Offset = "0x6F1B470", VA = "0x186F1C870", Slot = "26")]
	public void INOLOIMKMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B840", Offset = "0x6F1A440", VA = "0x186F1B840")]
	private void MFNFPJIJMGH(float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BEA0", Offset = "0x6F1AAA0", VA = "0x186F1BEA0")]
	private void FJICKLPPCAD(Vector3 MMKABMNCDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DE80", Offset = "0x6F1CA80", VA = "0x186F1DE80")]
	private Vector3 OJJAMLOHPON()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E0D0", Offset = "0x6F1CCD0", VA = "0x186F1E0D0")]
	private void OMJJJFMCKIL(Vector3 JNDAJMGACPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B610", Offset = "0x6F1A210", VA = "0x186F1B610")]
	private Vector3 AAMDMGMPHFH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C3E0", Offset = "0x6F1AFE0", VA = "0x186F1C3E0")]
	private void IGCHKEABOJF(Vector3 GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D4B0", Offset = "0x6F1C0B0", VA = "0x186F1D4B0")]
	private void MLINKEIEAPL(Vector3 JNDAJMGACPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BDF0", Offset = "0x6F1A9F0", VA = "0x186F1BDF0")]
	private void FDNPGBIAPKB()
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
